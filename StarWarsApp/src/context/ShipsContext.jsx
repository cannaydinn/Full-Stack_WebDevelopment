import {  createContext, useEffect, useState } from "react"

export const ShipsContext = createContext()

export const ShipsProvider = ({children}) => {
    const [starships, setStarships] = useState([]);
    const [nextPage, setNextPage] = useState('https://swapi.dev/api/starships/');
    const [searchQuery, setSearchQuery] = useState('');

    const fetchStarships = () => {
        if (!nextPage) return;
    
        fetch(nextPage)
          .then(response => response.json())
          .then(data => {
            setStarships(prevStarships => [...prevStarships, ...data.results]);
            setNextPage(data.next);
          });
    };

    useEffect(() => {
        fetchStarships();
    }, []);

    const filteredStarships = starships.filter(starship =>
        starship.name.toLowerCase().includes(searchQuery.toLowerCase())
    );

    return (
        <ShipsContext.Provider value={{ starships: filteredStarships, fetchStarships, setSearchQuery }}>
            {children}
        </ShipsContext.Provider>
    );
};

// export function useShips() {
//     return useContext(ShipsContext);
// };