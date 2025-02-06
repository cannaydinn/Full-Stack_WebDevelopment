import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import StarShips from './pages/StarShips';
import StarShipsDetails from './pages/StarShipsDetails';
import { ShipsProvider } from './context/ShipsContext';
import './App.css';

function App() {
  return (
    <ShipsProvider>
      <Router>
        <Routes>
          <Route path="/" element={<StarShips />} />
          <Route path="/starship/:id" element={<StarShipsDetails />} />
        </Routes>
      </Router>
    </ShipsProvider>
  );
}

export default App
