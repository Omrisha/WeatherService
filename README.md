﻿# WeatherService

Simple REST API service for querying weather forecast for a city of your choice or multiple cities.

The service is built with .NET Core 3.1 and C#.

## Live Demo
https://forecastserver.herokuapp.com/

## Installation

- Run the command `git clone https://github.com/Omrisha/WeatherService`
- Open the SLN file in Visual Studio/Rider/Visual Studio Code
- Run the project (or  `dotnet run` if in VSCode).  

## Usage

- GET /api/Weather/{cityName}
 Get forecast weather details for one city.
 
- GET /api/Weather?cities=tel%20aviv&cities=new%20york&cities=london&cities=toky
 Get forecast weather details for array of cities.

## JSON Example
```
{
    "cityName": "Tel Aviv",
    "temperature": 23,
    "weatherDescription": {
      "icon": "c01d",
      "description": "Clear sky"
    },
    "sunsetTime": "15:15",
    "windDirection": "0"
} 
```
```
{
    "cityName": "New York City",
    "temperature": 0,
    "weatherDescription": {
      "icon": "c04n",
      "description": "Overcast clouds"
    },
    "sunsetTime": "22:15",
    "windDirection": "350"
}
```
