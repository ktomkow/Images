#!/bin/bash

sudo dotnet restore
wait

sudo dotnet publish -o ~/Thesis/Testing/Images/dotnet -r linux-x64 -f netcoreapp2.2 --self-contained -c Release
wait

cd ~/Thesis/Testing/Images/dontet/
wait
sudo chmod +x dotnet

echo Done
