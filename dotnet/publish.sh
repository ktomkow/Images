#!/bin/bash

sudo dotnet restore
wait

sudo dotnet publish -o ~/Thesis/Testing/Images/dotnet -r linux-x64 -f netcoreapp2.2 --self-contained -c Release
wait

sudo chmod +x ~/Thesis/Testing/Images/dotnet/dotnet
wait

echo Done
