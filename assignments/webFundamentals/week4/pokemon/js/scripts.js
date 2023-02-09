url = 'https://pokeapi.co/api/v2/pokemon?offset=151&limit=151'

async function genPokemon(){
    let req = await fetch(`${url}`)
    let res = await req.json()
    let data = (res.results)

    console.log(res)
    for(let i=0; i<data.length; i++){
        // console.log(data[i])
        let node = document.createElement('div')
        let h3 = document.createElement('h3')
        let img = new Image()

        img.src = `https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/shiny/${i+1}.png`
        img.alt = `${data[i].name}`
        node.appendChild(img)

        let name = document.createTextNode(data[i].name)
        h3.appendChild(name)
        node.appendChild(h3)

        // console.log(node)
        document.getElementById("pokemon").appendChild(node)
    }
}
