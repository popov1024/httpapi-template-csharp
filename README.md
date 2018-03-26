# ASP.NET Core Web API (extended)

## About

It's template for dotnetcore 2.0 based on standart `ASP.NET Core Web API` (`webapi`).
Included [swagger](https://swagger.io/) and [docker](https://www.docker.com/).

The templating solution consist of three progect:
* `api` (`/src`) - the very simple api as example 
* `tests` (`/tests`) based on `mstest`
* `docker-compose` for build and run as a docker container.

## Install template
```
dotnet new -i "Popov1024.HttpApi.Template.CSharp::*"
```

## Uninstall template
```
dotnet new -u Popov1024.HttpApi.Template.CSharp
```

## Using
Make some dir:
```
mkdir my_api_project
cd my_api_project
```

Create solution:
```
dotnet new httpapi 
```

Run http api using docker-compose:
```
docker-compose up --build -d
```
And you can see the result: http://localhost

... or run using dotnet runtine:
```
cd src
dotnet run
```

In this case URL will be by http://localhost:5000
