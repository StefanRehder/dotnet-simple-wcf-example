# Simple RESTful Web Service implemented with .NET 4.7 and WCF

This is a simple RESTful web service implemented with .NET 4.7 and WCF. 
The example web service exposes a number of operations that can be used to handle hero objects stored in memory. 
The web service exposes the same operations as [dotnetcore-simple-nancy-example](https://github.com/StefanRehder/dotnetcore-simple-nancy-example) but the version in this repository can only run on Windows computers.

## Requirements

- [Microsoft Visual Studio (recommended but not required)](https://visualstudio.microsoft.com/) 
- [.NET 4.7 Framework (included with Visual Studio so no need to install both)](http://go.microsoft.com/fwlink/?LinkId=528259)

## Getting Started
Build the solution from Visual Studio and run the ConsoleApp project (or build from command line with [Microsoft Build Tools](http://www.microsoft.com/en-us/download/details.aspx?id=48159) and execute the output exe file).
When the web service is running, you can play around with the running web service with curl or Postman.
e.g. `curl -X PUT http://localhost:8210/hero -H 'content-type: application/json' -v -d '{ "Name": "Robin",  "Strength": 1 }'`