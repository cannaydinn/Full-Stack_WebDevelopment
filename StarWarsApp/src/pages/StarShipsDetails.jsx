import { useParams, useNavigate } from "react-router-dom";
import { useEffect, useState } from "react";
import CardDetail from "../components/CardDetail";

function StarShipsDetails() {
    const { id } = useParams();
    const [starship, setStarship] = useState(null);
    const navigate = useNavigate();

    useEffect(() => {
        fetch(`https://swapi.dev/api/starships/${id}/`)
          .then((response) => response.json())
          .then((data) => setStarship(data));
      }, [id]);

  return (
      <>
          <button className="bg-sky-500/50 rounded-full w-16 h-16 justify-items-center cursor" onClick={() => navigate("/")}>
            <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" strokeWidth={1.5} stroke="currentColor" className="size-6">
              <path strokeLinecap="round" strokeLinejoin="round" d="M10.5 19.5 3 12m0 0 7.5-7.5M3 12h18" />
            </svg>

          </button>
        <div className="flex items-center justify-center">
          <CardDetail starship={starship} />
        </div>
      </>
  );
}

export default StarShipsDetails