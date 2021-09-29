#!/bin/bash

mkdir Console_Lab
cd /home/urarak/Documents/Console_Lab
mkdir A
mkdir B
mkdir C
cd /home/urarak/Documents/Console_Lab/B
mkdir E
mkdir D
cd /home/urarak/Documents/Console_Lab/C
echo My name is Dmitri > file1.txt
cp /home/urarak/Documents/Console_Lab/C/file1.txt  /home/urarak/Documents/Console_Lab/B/E/file1_copied.txt
cd /home/urarak/Documents/Console_Lab/B/E
echo Today is Thursday %date% > file2.txt
mv /home/urarak/Documents/Console_Lab/B/E/file2.txt /home/urarak/Documents/Console_Lab/B/D
cd /home/urarak/Documents/Console_Lab/A
echo It is Autumn > file3.txt
mv file3.txt file4.txt
rm file3.txt
