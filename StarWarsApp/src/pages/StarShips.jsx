import { useContext } from "react";
import {ShipsContext}  from '../context/ShipsContext';
import ShipsList from '../components/ShipsList';

function StarShips() {
  const { starships, fetchStarships, setSearchQuery } = useContext(ShipsContext);

  const handleSearchChange = (e) => {
    setSearchQuery(e.target.value);
  };

  return (
    <>
      <div className='flex flex-col justify-center items-center'>
        <img src="/img/Star_Wars_Logo.svg" className='w-[400px]' alt="Star Wars Logo" />
        <div className='flex gap-4'>
          <p className='text-white'>Name / Model</p>
          <input 
            className='border border-white rounded-full' 
            type="text" 
            onChange={handleSearchChange}/>
        </div>
      </div>
      <ShipsList starships={starships} />
      <div className="bg-sky-500/50 rounded w-24 h-8 text-center flex justify-center items-center">
        <button onClick={fetchStarships} disabled={!starships.length}>
              Show More
        </button>

      </div>
    </>
    
  );
}

export default StarShips