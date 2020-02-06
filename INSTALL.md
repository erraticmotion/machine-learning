# F#

## Install F# on Mono

```console
sudo apt install gnupg ca-certificates
sudo apt-key adv --keyserver hkp://keyserver.ubuntu.com:80 --recv-keys 3FA7E0328081BFF6A14DA29AA6A19B38D3D831EF
echo "deb https://download.mono-project.com/repo/ubuntu stable-bionic main" | sudo tee /etc/apt/sources.list.d/mono-official-stable.list
sudo apt update
sudo apt install mono-devel
sudo apt-get update
sudo apt-get install fsharp
```

## File Watcher

Visual Studio Code is unable to watch for file changes in this large workspace (error ENOSPC)

```console
cat /proc/sys/fs/inotify/max_user_watches
8192
sudo nano /etc/sysctl.conf

-- add at the end of the file
fs.inotify.max_user_watches=524288
-- save and close

sudo sysctl -p
cat /proc/sys/fs/inotify/max_user_watches
524288
```

## VS Code Extensions

- Docker
- Docker Explorer