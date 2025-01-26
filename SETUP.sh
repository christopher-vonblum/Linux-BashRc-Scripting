#!/bin/bash -v
echo on

sudo apt install curl

sudo apt install dotnet-sdk-9.0
sudo apt install dotnet-runtime-9.0

mkdir dotnet-script
cd dotnet-script
curl https://raw.githubusercontent.com/dotnet-script/dotnet-script/master/install/install.sh > install.sh
sudo chmod +x install.sh
sudo ./install.sh
cd ..
rm -R dotnet-script

cd ..
echo "source ~/bin/bashrc-definitions" >> ~/.bashrc
sudo ./update-bashrc.sh
source ~/.bashrc
