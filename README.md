# Machine Learning

Machine Learning in F# and Python

Source code when following the projects in the [Machine Learning Projects for .NET Developers][ml] book.

## Install F# on Mono

```console
sudo apt install gnupg ca-certificates
sudo apt-key adv --keyserver hkp://keyserver.ubuntu.com:80 --recv-keys 3FA7E0328081BFF6A14DA29AA6A19B38D3D831EF
echo "deb https://download.mono-project.com/repo/ubuntu stable-bionic main" | sudo tee /etc/apt/sources.list.d/mono-official-stable.list
sudo apt update
sudo apt install -y mono-devel
sudo apt-get update
sudo apt-get install -y fsharp
```

## Install Python3
```console
sudo apt update
sudo apt install software-properties-common
sudo add-apt-repository ppa:deadsnakes/ppa
sudo apt install -y python3.7
python3.7 --version

sudo apt install -y python3-pip
pip3 --version
```

## Install Python3 environment (optional)

```console
sudo apt install -y python3-venv
cd ~/src
mkdir pyenv01
cd pyenv01

python3 -m venv venv
source venv/bin/activate

pip install --upgrade pip

-- when completed in environment
deactivate
```

[ml]: https://www.amazon.co.uk/Machine-Learning-Projects-NET-Developers/dp/1430267674/ref=sr_1_3

