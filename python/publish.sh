#!/bin/bash

cp main.py ~/Thesis/Testing/Images/python/
cp requirements.txt ~/Thesis/Testing/Images/python/
wait 

cd ~/Thesis/Testing/Images/python/
wait

source env/bin/activate
pip install -r requirements.txt
wait