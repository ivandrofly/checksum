checksum [![Build Status](https://travis-ci.org/victorheld/checksum.svg?branch=master)](https://travis-ci.org/victorheld/checksum) [![Build Status](http://80.60.83.220:8080/buildStatus/icon?job=MyGame)](http://80.60.83.220:8080/job/MyGame/)
========

A program to check the hash of a file nicely integrated in the context menu

## Releases ##
* [Stable Release](https://github.com/victorheld/checksum/releases/latest)
* [Beta Version](http://xirion.net/builds/checksum/bin/Debug/checksum.exe) (Build from latest commit)

## Supported Hashes ##
Here is a list of the currently supported hash types:

* MD5
* SHA1
* SHA256
* SHA512

## Recent changes ##
* Added Context Menu (this requires admin privileges to edit the registry)
* Added Drag&Drop Support
* Fixed NullPointerException on close
* Added threading for file processing to prevent application freezing
* Reworked hash functions -> Added support for large file (>2G) Yay!
* Automatic recalculation of hashes when switching methods

## Known Errors ##
* Drag&Drop not working when elevated

## To-Do List ##

## Authors ##
* [Victorheld](https://github.com/victorheld/)
* [Backshifted](https://github.com/backshifted/) -Lead Programmer
* Icons provided by [Pixel Mixer](http://pixel-mixer.com) and [Micheal Rowe](http://stylicons.com/) under the Creative Commons License
