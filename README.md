# _Animal Shelter API_

#### _An API program created to practice CRUD API's in ASP.NET 11/01/2019_

#### By _Zach Krogh_

## Description

_This API program allows the user to Create, Read, Update, and Delete animals from an animal shelter database using an API._

## Setup/Installation Requirements
* _Install dotnet core._
* _Download all files into the same directory_
* _Setup MySQL database as folows:_
  * _Using mysql or MySQL workbench:_
    * DROP DATABASE zach_krogh;
  * _Using the terminal:_
    * _run "dotnet ef databse update"_

* _run "dotnet run"_
* _(The database is pre-populated with 13 animals of test data)_

## API Usage
* _All GET results are paginated to return a maximum of 5 elements per page_
* _Base URL format: localhost:5000/api/animals_
* _GET Request options:_
  * _name(string), taxonomy(string), breed(string), age(int), gender(string), isfixed(string), page(int)_
  * _example Get Request: localhost:5000/api/animals?page=1&taxonomy=dog&gender=Male&isfixed=true_

* _POST Request format:_
  * _Post URL: localhost:5000/api/animals_
  * _Send post requests as a JSON object format with the following body:_
    * `{
    "name": "TestAnimal",
    "taxonomy": "Dog",
    "breed": "Labrador",
    "age": 2,
    "gender": "Male",
    "isFixed": true
    }`
* _PUT Request format:_
  * _PUT URL: localhost:5000/api/animals/2_
    * _Selects animal with id == 2_
  * _PUT requests have the same JSON body format as POST:_

* _DELETE Request format:_
  * _DELETE URL: localhost:5000/api/animals/2_
    * _Deletes animal with id ==2_
  * _Delete requests do not require a body_

## Project Specifications

* _The user can create an animal._
  * _input:_
    * _name:"Bob"_
    * _taxonomy:"Dog_
    * _breed:"Labrador"_
    * _age:"2"_
    * _gender:"Male"_
    * _isFixed:"true"_

  * _output: none (all are saved to database)_
  * _description: Users can post data to the api and it will be saved in the database._

* _The user can get animals from the database._
  * _input: GET request: localhost:5000/api/animals_
  * _output: A list of the first 5 animals in the database_
  * _Users can get information from the database using api GET requests._


## Support and contact details

_contact: zakrogh@gmail.com_

## Technologies Used

_C#, ASP.NET MVC, MySQL_

### License

*MIT License*

Copyright (c) 2019 **_Zach Krogh_**
