# _Animal Shelter_

#### By: _*Anna Pittman*_

#### _A C# application with CRUD functionality and an API._

## Technologies Used

* _C#_
* _.NET 5_
* _ASP.NET Core MVC_
* _Razor_
* _Git_
* _MySql and MySQL Workbench_
* _Swagger_

## Description

An C# application to keep track of animals at an animal shelter. Information such as an animal's name, gender, age and breed can be returned using API calls. In addition, Swagger is utilized to organize API documentation. 

## Setup/Installation Requirements

* Download [.NET5](https://dotnet.microsoft.com/en-us/download/dotnet/5.0)
* Download MySQL and MySQL Workbench
* Download [Swagger](https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-3.1&tabs=visual-studio-code)

## Application Setup

* Clone this repository to your desktop using the command: `git clone https://github.com/an12346/AnimalShelter.git`
* Navigate to the project directory: `cd AnimalShelter.Solution`
* Then, navigate to the production file: `cd AnimalShelter`
* Create a file named "appsettings.json" in the `AnimalShelter` directory
* Add the following code to appsettings.json:
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=animal_shelter;uid=[YOUR DATABASE];pwd=[YOUR PASSWORD];"
  }
}
```
* Add the name of your database and password to the appsettings.json file
* To update the databse, run the command: `$ dotnet ef database update`
* To download obj and bin files, run the command `$ dotnet restore` 
* To start the server, run the command: `$ dotnet run`

## Swagger

* Swagger allows for interactive documentation for your API
* Download Swagger
* Start the server
* After starting the server, go to http://localhost:your-port-number/swagger/ to view your API
* Now, you can send different requests within this application

## Known Bugs

* _No known bugs_

## License

_MIT License: https://opensource.org/licenses/MIT_

Copyright (c) _2021_ _Anna Pittman_