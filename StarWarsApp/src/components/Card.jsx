import { Link } from 'react-router-dom';

function Card({starship}) {
  return (
    <>
        <Link to={`/starship/${starship.url.split('/').slice(-2, -1)[0]}`}>
            <div className='flex flex-wrap items-center'>
                <div className="card ">
                    <div className="card-image">
                        <img src="/img/Star-Wars-Ship.png" alt="Star Wars Ship" />
                    </div>
                    <div className="card-content">
                        <h2><b>{starship.name}</b></h2>
                        <p className='text-left text-sm'><b>Model:</b> {starship.model}</p>
                        <p className='text-left text-sm'><b>Hyperdrive Rating:</b> {starship.hyperdrive_rating}</p>
                    </div>
                </div>
                
            </div>
        </Link>
       
    </>
    
  );
}

export default Card 