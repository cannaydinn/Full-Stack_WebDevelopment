import { useState } from 'react'
import './App.css'

function App() {
  const [playerScore, setPlayerScore] = useState(0);
  const [computerScore, setComputerScore] = useState(0);
  const [highScore, setHighScore] = useState(0);

  const [playerDice, setPlayerDice] = useState(1);
  const [computerDice, setComputerDice] = useState(1);
  const [rolling, setRolling] = useState(false);



  const rollDice = async () => {
    setRolling(true);

    let counter = 0;
    const interval = setInterval(() => {
      // Rastgele zar görselleri oluşturuluyor
      const randomPlayerDice = Math.floor(Math.random() * 6) + 1;
      const randomComputerDice = Math.floor(Math.random() * 6) + 1;

      setPlayerDice(randomPlayerDice);
      setComputerDice(randomComputerDice);

      counter++;
      if (counter > 10) {
        clearInterval(interval);

        // Nihai zar değerlerini belirleme
        const finalPlayerDice = Math.floor(Math.random() * 6) + 1;
        const finalComputerDice = Math.floor(Math.random() * 6) + 1;

        setPlayerDice([finalPlayerDice]); // Nihai değer tek zar gösterir
        setComputerDice([finalComputerDice]);

        // Skorları hesaplama
        if (finalPlayerDice > finalComputerDice) {
          setPlayerScore((prev) => prev + 1);
          setHighScore((prev) => Math.max(prev, playerScore + 1));
        } else if (finalPlayerDice < finalComputerDice) {
          setComputerScore((prev) => prev + 1);
        }
        else{
          setPlayerScore((prev) => prev);
          setComputerScore((prev) => prev);
        }

        setRolling(false);
      }
    }, 100); 
  }

  return (
    <>
      <h1>Dice Game</h1>
      <div>
        <h2>Player</h2>
        <div>
          <img
            src={`src/assets/images/dice${playerDice}.png`}
            alt={`Player Dice ${playerDice}`}
            style={{ width: '80px', height: '80px' }}
          />
        </div>
      </div>
      <div>
        <h2>Computer</h2>
        <div>
          <img
            src={`src/assets/images/dice${computerDice}.png`}
            alt={`Computer Dice ${computerDice}`}
            style={{ width: '80px', height: '80px' }}
          />
        </div>
      </div>
      <br />
      <button disabled={rolling} onClick={rollDice}>
        {rolling ? "Rolling..." : "Roll Dice"}
      </button>
      <div>
        <h2>Score</h2>
        <p>Player Score: {playerScore} </p>
        <p>Computer Score: {computerScore} </p>
        <p>High Score: {highScore} </p>
      </div>
    </>
  )
}

export default App
