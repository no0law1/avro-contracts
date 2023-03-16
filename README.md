# Avro Contracts

## Description
This repository provides step-by-step instructions and example code for generating .NET classes from Avro schema definitions using Docker containers.

The repository is aimed at developers who want to learn how to convert Avro IDL (.avdl) files to Avro schema (.avsc) files and then generate .NET classes from those schemas.

## Features
* A Dockerfile that installs the necessary tools (Java, Avro tools, .NET Core) and sets up the required directories for the conversion process.
* A docker-compose.yml file that defines the two Docker containers: one for generating the .avsc files from the .avdl files, and one for generating the .NET classes from the .avsc files.
* Example .avdl files and corresponding .avsc files that can be used to test the conversion process.
* Example C# code that uses the generated .NET classes to read and write Avro-encoded data.

## Usage
To use this, clone the repository to your local machine, ensure that Docker is installed and running, and then follow the instructions in this README.md file. The README.md file would provide step-by-step instructions for using the docker-compose command to run the two containers, converting the .avdl files to .avsc files, and then generating the .NET classes from the .avsc files.

## Contributors
* @no0law1

## License
tbd