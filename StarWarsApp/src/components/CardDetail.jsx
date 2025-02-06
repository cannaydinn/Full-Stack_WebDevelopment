import React from 'react'

function CardDetail({starship}) {
    if (!starship) {
        return <p>Loading...</p>;
      }
  return (
    <>
            <div className="cardDetail">
                <h2><b>{starship.name}</b></h2>
                <div className="card-image">
                    <img src="/img/Star-Wars-Ship.png" alt="Star Wars Ship" />
                </div>
                <div className="card-content">
                    <p className='text-left text-sm'><b>Model:</b> {starship.model}</p>
                    <p className='text-left text-sm'><b>Hyperdrive Rating:</b> {starship.hyperdrive_rating}</p>
                    <p className='text-left text-sm'><b>Passengers:</b> {starship.passengers}</p>
                    <p className='text-left text-sm'><b>Max Atmosphering Speed:</b> {starship.max_atmosphering_speed}</p>
                    <p className='text-left text-sm'><b>Manufacturer:</b> {starship.manufacturer}</p>
                    <p className='text-left text-sm'><b>Crew:</b> {starship.crew}</p>
                    <p className='text-left text-sm'><b>Cargo Capacity:</b> {starship.cargo_capacity}</p>
                </div>
            </div>
    </>
  );
}

export default CardDetail