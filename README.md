# BBDotnetTest

Required MongoDb, .net core SDK, Visual Studio Code to run
just open folder in Visual Studio Code:
    type: dotnet run

WepApi is configured to run on port 5050.

Can use Postman to Test the api.

### BASIC CRUD operation supported

##### CREATE new Booking:
POST     http://localhost:5000/api/Booking

with following body
{
  "timestamp": "{{$timestamp}}",
  "products": [
    {
      "id": "0123",
      "name": "test1",
      "quantity": "12",
      "sale_amount": "12.34"
    },
    {
      "id": "4567",
      "name": "test2",
      "quantity": "34",
      "sale_amount": "56.78"
    }
  ]
}

##### RETRIEVE all:
GET     http://localhost:5000/api/Booking

will list all booking data in the database

##### RETRIEVE with ID
GET     http://localhost:5000/api/Booking/5d0e057d74c99238a05e38d7

will list all booking data with ID 5d0e057d74c99238a05e38d7 in the database

##### UPDATE existing Booking with ID:
POST    http://localhost:5000/api/Booking/5d0e057d74c99238a05e38d7

with following body
{
  "id": "5d0e057d74c99238a05e38d7",
  "timestamp": "{{$timestamp}}",
  "products": [
    {
      "id": "0123",
      "name": "test1",
      "quantity": "12",
      "sale_amount": "12.34"
    },
    {
      "id": "4567",
      "name": "test2",
      "quantity": "34",
      "sale_amount": "56.78"
    }
  ]
}

##### DELETE existing Booking with ID:
DELETE  http://localhost:5000/api/Booking/5d0e057d74c99238a05e38d7
