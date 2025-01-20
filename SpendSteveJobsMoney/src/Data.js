const products = [
    {
      "id": 1,
      "name": "Big Mac",
      "price": 2,
      "img": "https://neal.fun/spend/images/big-mac.jpg",
      "quantity": "0"
    },
    {
      "id": 2,
      "name": "Flip Flops",
      "price": 3,
      "img": "https://neal.fun/spend/images/flip-flops.jpg",
      "quantity": "0"
    },
    {
      "id": 3,
      "name": "Coca-Cola Pack",
      "price": 5,
      "img": "https://neal.fun/spend/images/coca-cola-pack.jpg",
      "quantity": "0"
    },
    {
      "id": 4,
      "name": "Movie Ticket",
      "price": 12,
      "img": "https://neal.fun/spend/images/movie-ticket.jpg",
      "quantity": "0"
    },
    {
      "id": 5,
      "name": "Book",
      "price": 15,
      "img": "https://neal.fun/spend/images/book.jpg",
      "quantity": "0"
    },
    {
      "id": 6,
      "name": "Lobster Dinner",
      "price": 45,
      "img": "https://neal.fun/spend/images/lobster-dinner.jpg",
      "quantity": "0"
    },
    {
      "id": 7,
      "name": "Video Game",
      "price": 60,
      "img": "https://neal.fun/spend/images/video-game.jpg",
      "quantity": "0"
    },
    {
      "id": 8,
      "name": "Amazon Echo",
      "price": 99,
      "img": "https://neal.fun/spend/images/amazon-echo.jpg",
      "quantity": "0"
    },
    {
      "id": 9,
      "name": "Year of Netflix",
      "price": 100,
      "img": "https://neal.fun/spend/images/year-of-netflix.jpg",
      "quantity": "0"
    },
    {
      "id": 10,
      "name": "Air Jordans",
      "price": 125,
      "img": "https://neal.fun/spend/images/air-jordans.jpg",
      "quantity": "0"
    },
    {
      "id": 11,
      "name": "Airpods",
      "price": 199,
      "img": "https://neal.fun/spend/images/airpods.jpg",
      "quantity": "0"
    },
    {
      "id": 12,
      "name": "Gaming Console",
      "price": 299,
      "img": "https://neal.fun/spend/images/gaming-console.jpg",
      "quantity": "0"
    },
    {
      "id": 13,
      "name": "Drone",
      "price": 350,
      "img": "https://neal.fun/spend/images/drone.jpg",
      "quantity": "0"
    },
    {
      "id": 14,
      "name": "Smartphone",
      "price": 699,
      "img": "https://neal.fun/spend/images/smartphone.jpg",
      "quantity": "0"
    },
    {
      "id": 15,
      "name": "Bike",
      "price": 800,
      "img": "https://neal.fun/spend/images/bike.jpg",
      "quantity": "0"
    },
    {
      "id": 16,
      "name": "Kitten",
      "price": 1500,
      "img": "https://neal.fun/spend/images/kitten.jpg",
      "quantity": "0"
    },
    {
      "id": 17,
      "name": "Puppy",
      "price": 1500,
      "img": "https://neal.fun/spend/images/puppy.jpg",
      "quantity": "0"
    },
    {
      "id": 18,
      "name": "Auto Rickshaw",
      "price": 2300,
      "img": "https://neal.fun/spend/images/auto-rickshaw.jpg",
      "quantity": "0"
    },
    {
      "id": 19,
      "name": "Horse",
      "price": 2500,
      "img": "https://neal.fun/spend/images/horse.jpg",
      "quantity": "0"
    },
    {
      "id": 20,
      "name": "Acre of Farmland",
      "price": 3000,
      "img": "https://neal.fun/spend/images/acre-of-farmland.jpg",
      "quantity": "0"
    },
    {
      "id": 21,
      "name": "Designer Handbag",
      "price": 5500,
      "img": "https://neal.fun/spend/images/designer-handbag.jpg",
      "quantity": "0"
    },
    {
      "id": 22,
      "name": "Hot Tub",
      "price": 6000,
      "img": "https://neal.fun/spend/images/hot-tub.jpg",
      "quantity": "0"
    },
    {
      "id": 23,
      "name": "Luxury Wine",
      "price": 7000,
      "img": "https://neal.fun/spend/images/luxury-wine.jpg",
      "quantity": "0"
    },
    {
      "id": 24,
      "name": "Diamond Ring",
      "price": 10000,
      "img": "https://neal.fun/spend/images/diamond-ring.jpg",
      "quantity": "0"
    },
    {
      "id": 25,
      "name": "Jet Ski",
      "price": 12000,
      "img": "https://neal.fun/spend/images/jet-ski.jpg",
      "quantity": "0"
    },
    {
      "id": 26,
      "name": "Rolex",
      "price": 15000,
      "img": "https://neal.fun/spend/images/rolex.jpg",
      "quantity": "0"
    },
    {
      "id": 27,
      "name": "Ford F-150",
      "price": 30000,
      "img": "https://neal.fun/spend/images/ford-f-150.jpg",
      "quantity": "0"
    },
    {
      "id": 28,
      "name": "Tesla",
      "price": 75000,
      "img": "https://neal.fun/spend/images/tesla.jpg",
      "quantity": "0"
    },
    {
      "id": 29,
      "name": "Monster Truck",
      "price": 150000,
      "img": "https://neal.fun/spend/images/monster-truck.jpg",
      "quantity": "0"
    },
    {
      "id": 30,
      "name": "Ferrari",
      "price": 250000,
      "img": "https://neal.fun/spend/images/ferrari.jpg",
      "quantity": "0"
    },
    {
      "id": 31,
      "name": "Single Family Home",
      "price": 300000,
      "img": "https://neal.fun/spend/images/single-family-home.jpg",
      "quantity": "0"
    },
    {
      "id": 32,
      "name": "Gold Bar",
      "price": 700000,
      "img": "https://neal.fun/spend/images/gold-bar.jpg",
      "quantity": "0"
    },
    {
      "id": 33,
      "name": "McDonalds Franchise",
      "price": 1500000,
      "img": "https://neal.fun/spend/images/mcdonalds-franchise.jpg",
      "quantity": "0"
    },
    {
      "id": 34,
      "name": "Superbowl Ad",
      "price": 5250000,
      "img": "https://neal.fun/spend/images/superbowl-ad.jpg",
      "quantity": "0"
    },
    {
      "id": 35,
      "name": "Yacht",
      "price": 7500000,
      "img": "https://neal.fun/spend/images/yacht.jpg",
      "quantity": "0"
    },
    {
      "id": 36,
      "name": "M1 Abrams",
      "price": 8000000,
      "img": "https://neal.fun/spend/images/m1-abrams.jpg",
      "quantity": "0"
    },
    {
      "id": 37,
      "name": "Formula 1 Car",
      "price": 15000000,
      "img": "https://neal.fun/spend/images/formula-1-car.jpg",
      "quantity": "0"
    },
    {
      "id": 38,
      "name": "Apache Helicopter",
      "price": 31000000,
      "img": "https://neal.fun/spend/images/apache-helicopter.jpg",
      "quantity": "0"
    },
    {
      "id": 39,
      "name": "Mansion",
      "price": 45000000,
      "img": "https://neal.fun/spend/images/mansion.jpg",
      "quantity": "0"
    },
    {
      "id": 40,
      "name": "Make a Movie",
      "price": 100000000,
      "img": "https://neal.fun/spend/images/make-a-movie.jpg",
      "quantity": "0"
    },
    {
      "id": 41,
      "name": "Boeing 747",
      "price": 148000000,
      "img": "https://neal.fun/spend/images/boeing-747.jpg",
      "quantity": "0"
    },
    {
      "id": 42,
      "name": "Mona Lisa",
      "price": 780000000,
      "img": "https://neal.fun/spend/images/mona-lisa.jpg",
      "quantity": "0"
    },
    {
      "id": 43,
      "name": "Skyscraper",
      "price": 850000000,
      "img": "https://neal.fun/spend/images/skyscraper.jpg",
      "quantity": "0"
    },
    {
      "id": 44,
      "name": "Cruise Ship",
      "price": 930000000,
      "img": "https://neal.fun/spend/images/cruise-ship.jpg",
      "quantity": "0"
    },
    {
      "id": 45,
      "name": "NBA Team",
      "price": 2120000000,
      "img": "https://neal.fun/spend/images/nba-team.jpg",
      "quantity": "0"
    }
  ]

  export default products;