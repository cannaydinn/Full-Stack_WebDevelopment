# Star Wars Starships Search App

This is a web application that allows users to search and explore Star Wars starships. The app fetches data from the Star Wars API (SWAPI) and displays detailed information about each starship. Users can filter the starships by name or model and navigate to a detailed page for more information.

## Features

- **Search**: Filter starships by name or model.
- **Infinite Scroll**: Load more starships as you scroll down.
- **Detailed View**: View detailed information about each starship, including its manufacturer, passengers, crew, speed, and more.

## Technologies Used

- **React**: For building the user interface.
- **React Router**: For handling routing between pages.
- **Context API**: For managing the state of the application, such as starships and search query.
- **Fetch API**: For fetching data from the Star Wars API (SWAPI).
- **CSS (Tailwind)**: For styling the app with a responsive layout.

```plaintext

├── components/               # Contains reusable components
│   ├── Card.js               # Displays individual starship details
│   ├── CardDetail.js         # Displays detailed information about a starship
│   └── ShipsList.js          # Renders a list of starships
│
├── context/                  # Contains the state management context
│   └── ShipsContext.js       # Manages the starships and search query state
│
├── pages/                    # Contains the main pages of the app
│   ├── StarShips.js          # Displays the list of starships with search functionality
│   └── StarShipsDetails.js   # Displays detailed information about a specific starship
│
├── App.js                    # The entry point of the application that sets up routing and context
├── App.css                   # Global CSS styles for the app
└── index.js                  # The entry point for React rendering

```
