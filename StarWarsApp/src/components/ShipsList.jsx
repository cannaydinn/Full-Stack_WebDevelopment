
import Card from './Card'

function ShipsList({starships}) {
  return (
    <div className='flex flex-wrap gap-10 justify-center items-center'>
      {starships.map((starship, index) => (
        <Card key={index} starship={starship} />
      ))}
      
    </div>
  );
}

export default ShipsList