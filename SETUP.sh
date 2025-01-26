#!/bin/bash -v
echo on

sudo apt install curl

sudo apt install dotnet-sdk-9.0
sudo apt install dotnet-runtime-9.0

cd ..
echo "source ~/bin/bashrc-definitions" >> ~/.bashrc
sudo ./update-bashrc.sh
source ~/.bashrc
