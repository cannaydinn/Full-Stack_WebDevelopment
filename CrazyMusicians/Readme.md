# Crazy Musicians API

The Crazy Musicians API is a simple ASP.NET Core Web API project that allows you to manage a list of quirky musicians. You can add, update, delete, and search for musicians, each with unique and entertaining traits.

## Project Structure

- **Controllers/CrazyMusiciansController.cs**: The API controller responsible for handling basic CRUD (Create, Read, Update, Delete) operations for musicians.
- **Entities/MusicianEntity.cs**: The entity class representing the data structure of a musician.

### Technologies Used

- ASP.NET Core Web API
- C#
- Entity Framework (Static data used in this project)
- RESTful API

## API Endpoints

### 1. Get All Musicians

**Endpoint**: `GET /api/CrazyMusicians`  
This endpoint returns a list of all crazy musicians.

**Response:**
```json
[
  {
    "id": 1,
    "fullName": "Ahmet Instrument",
    "profession": "Famous Musical Instrument Player",
    "entertainingTrait": "Always hits the wrong note, but it's so much fun"
  },
  ...
]

### 2. Get Specific Musician by ID

**Endpoint**: `GET /api/CrazyMusicians/{id}`
Returns the musician with the specified id.

**Response:**
```json
{
  "id": 1,
  "fullName": "Ahmet Instrument",
  "profession": "Famous Musical Instrument Player",
  "entertainingTrait": "Always hits the wrong note, but it's so much fun"
}

### 3. Create a New Musician

**Endpoint**: `POST /api/CrazyMusicians`
Adds a new musician to the list.

**Response:**
```json
{
  "fullName": "New Musician",
  "profession": "Music Professional",
  "entertainingTrait": "Interesting trait"
}

### 4. Update a Musician

**Endpoint**: `PUT /api/CrazyMusicians/{id}`
Updates the musician’s details for the given id.

**Response:**
```json
{
  "fullName": "Updated Musician Name",
  "profession": "Updated Job",
  "entertainingTrait": "Updated fun fact"
}

### 5. Partially Update a Musician’s Trait

**Endpoint**: `PATCH /api/CrazyMusicians/{id}`
Updates only the EntertainingTrait of the musician.

**Response:**
```json
{
  "entertainingTrait": "New Entertaining Trait"
}

**Response:**
```json
{
  "id": 1,
  "fullName": "Ahmet Instrument",
  "profession": "Famous Musical Instrument Player",
  "entertainingTrait": "New Entertaining Trait"
}

### 6. Delete a Musician

**Endpoint**: `DELETE /api/CrazyMusicians/{id}`
Marks a musician as deleted (soft delete, sets IsDeleted to true).

**Response:**
```json
{
  "id": 1,
  "isDeleted": true
}
