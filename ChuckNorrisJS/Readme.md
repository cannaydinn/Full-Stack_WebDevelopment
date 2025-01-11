# Chuck Norris Jokes App

Welcome to the **Chuck Norris Jokes App**! This simple and fun web application fetches random Chuck Norris jokes from an external API and displays them on your screen. You can keep clicking the button to generate a new joke every time!

## Features

- Fetches random jokes about Chuck Norris using the [Chuck Norris API](https://api.chucknorris.io/).
- Responsive design created with **HTML**, **CSS**, and **Bootstrap**.
- Dynamically updates jokes using **JavaScript** and the **Fetch API**.
- Interactive button hover effect for better user experience.

## Technologies Used

- **HTML5**: For the structure of the webpage.
- **CSS3**: For styling the page.
- **Bootstrap**: For responsive design.
- **JavaScript (ES6)**: For fetching and displaying jokes dynamically.
- **Async/Await**: For handling asynchronous requests.

## How It Works

1. The app uses `fetch` to make an API call to `https://api.chucknorris.io/jokes/random`.
2. The response is parsed as JSON, and the joke text is extracted from the response.
3. The joke is dynamically inserted into the `<p>` tag with the ID `#jokes`.
4. The user can click the **"Another Joke"** button to fetch a new joke.

```
chuck-norris-jokes/
│
├── css/
│   └── style.css         # Styles for the app
│
├── js/
│   └── main.js           # JavaScript logic for fetching and displaying jokes
│
├── index.html            # Main HTML file
└── README.md             # Documentation file
```
