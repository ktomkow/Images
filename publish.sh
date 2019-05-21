#!/bin/bash

cd cpp/
./publish.sh
wait
cd ..

cd python/
./publish.sh
wait
cd ..

cd dotnet/
./publish.sh
wait
cd..

cd results/
cp clean.py ~/Thesis/Testing/Images/results/
cd ..

echo Done
