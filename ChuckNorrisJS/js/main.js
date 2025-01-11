


const parag = document.querySelector("#jokes")
const button = document.querySelector("#button")

async function getData() {
    try{
        const responseAwait = await fetch("https://api.chucknorris.io/jokes/random")
        const dataAwait = await responseAwait.json()
        parag.innerHTML = dataAwait.value
    }catch(err){
        console.log(err)
    }
}

button.addEventListener("click", getData)