console.log("connected!")

let url = 'https://dojo.navyladyveteran.com/squishies/';

async function getPokemon(){
    let res = await fetch(url)
    let data = await res.json()

    console.log(data);

    for(let i = 0; i < data.length; i++){
        let node = document.createElement('div')
        let h2 = document.createElement('h2')
        let img = new Image()
        let name = document.createTextNode(data[i].name)
        img.src = `${data[i].img}`
        img.alt = `${data[i].name}`
        h2.append(name)
        node.appendChild(img)
        node.appendChild(h2)
        document.getElementById('pokemon').appendChild(node)
    } 
 

}