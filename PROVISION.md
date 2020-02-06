# Provision Virtual Machine

Installation of Ubuntu 18.04.4 using VMware Workstation 15.

- 8Gb memory
- 4 CPUs
- Enable Virtualization Intel VT -x/EPT

## Enable SSH access
```console
sudo apt install openssh-server
```

## Upgrade
```console
sudo apt-get upgrade -y
```

## Support KVM
```console
sudo apt install -y qemu-kvm
sudo apt install -y cpu-checker
kvm-ok
sudo apt install -y acl
sudo setfacl -m u:${USER}:rw /dev/kvm
```

## Change network
```console
sudo nano /etc/netplan/50-cloud-init.yaml

            dhcp4: true
            dhcp-identifier: mac
```

## Set NFS share
```console
sudo apt-get install -y nfs-kernel-server
mkdir ~/src
sudo nano /etc/fstab
```

```text
192.168.0.3:/nfs/Source/machine-learning    /home/ubuntu/src   nfs      defaults    0       0
```

```console
sudo mount -a
```

## Docker

### Install Docker

```console

sudo apt-get update
sudo apt-get install \
    apt-transport-https \
    ca-certificates \
    curl \
    gnupg-agent \
    software-properties-common

curl -fsSL https://download.docker.com/linux/ubuntu/gpg | sudo apt-key add -

sudo add-apt-repository "deb [arch=amd64] https://download.docker.com/linux/ubuntu $(lsb_release -cs) stable"

sudo apt-get update
sudo apt-get install docker-ce docker-ce-cli containerd.io
sudo usermod -aG docker $USER
-- reboot VM --
```

### Docker Images

```console
docker pull alpine             -- sha256:ab00606a42621fb68f2ed6ad3c88be54397f981a7b70a79db3d1172b11c4367d
docker pull debian:buster-slim -- sha256:9ab269df3cfa21324fcbfcf5366722d99d77ab480a8cbb0727612f7ea4e6ae27
docker pull photon             -- sha256:9785fc642d79e7d2f89ab82c289098b7e40383d86a54f85b8f6475598b627c57
docker pull fsharp             -- sha256:3e7e6b0c2081baa4b5aeefea29f4597bc4eaf72c329f3e0bb6bfdcd53f8e8514

docker container run -it alpine ping -c 3 google.com
```

## Docker Compose

```console
sudo curl -L "https://github.com/docker/compose/releases/download/1.25.0/docker-compose-$(uname -s)-$(uname -m)" -o /usr/local/bin/docker-compose

sudo chmod +x /usr/local/bin/docker-compose
```

## Set ports for Docker Swarm

```console
sudo iptables -A INPUT -p tcp --dport 2376 -j ACCEPT
sudo iptables -A INPUT -p tcp --dport 2377 -j ACCEPT
sudo iptables -A INPUT -p tcp --dport 7946 -j ACCEPT
sudo iptables -A INPUT -p udp --dport 7946 -j ACCEPT
sudo iptables -A INPUT -p udp --dport 4789 -j ACCEPT
```