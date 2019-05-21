#!/bin/bash

rm ../processedImages/*.pgm

source env/bin/activate
python3 main.py 172
deactivate
echo "done"
