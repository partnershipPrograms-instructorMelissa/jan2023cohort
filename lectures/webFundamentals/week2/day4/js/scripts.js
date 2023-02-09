console.log('wired up')

const url = "https://geek-jokes.sameerkumar.website/api?format=json"
const newUrl = "https://v2.jokeapi.dev/joke/Any"
const squish = 'https://dojo.navyladyveteran.com/squishies/'

async function getSquish() {  // async function so that the rest of the file can run while waiting on response from this
    let res = await fetch(`${squish}`) // sending our get request out to the server via the url in ()
    let data = await res.json() // changing the data / ensuring the data is presented to us in json format
    console.log(data[0].name)
    for(let i = 0 ; i < data.length; i++) { // looping throught the returned data
        let node = document.createElement('div') // creating a div
        let h3 = document.createElement('h3') // creating a h3
        let img = new Image() // creating the image this way allows us to better add the image path and alt tags
        let name = document.createTextNode(data[i].name) // variable to hold the text to be added to the h3
        img.src = `${data[i].img}` // setting the value for the images src tag
        img.alt = `${data[i].name}` // setting the value for the images alt tag
        console.log(img.src)
        h3.appendChild(name) // adding the text to the h3
        node.appendChild(img) // adding the img to the div/node
        node.appendChild(h3) // adding the h3 to to the div/node
        document.getElementById('squishies').appendChild(node) // pushing the newly formed div to the  div  with id squishies
    }
}
let jokes = []
async function getJoke() {
    let res = await fetch(`${url}`)
    console.log('theData', res)
    let data = await res.json()
    console.log("the real data", data)
    console.log("just the jokes ma'am", data.joke)
    // document.getElementById('joke').innerHTML += data.joke
    // jokes.push(data.joke)
    // for(let i = 0; i < jokes.length; i++) {
    //     var node = document.createElement('tr') // creates a new row for each index of the loop
    //     var td = document.createElement('td') // creates a new td element for each index of the loop
    //     var text = jokes[i] // takes the current index sets it equal to text
    //     td.append(text) // adds that text to the td
    //     node.appendChild(td) // adds the td to the tr
    //     document.getElementById('jokeTable').appendChild(node) // adds the new tr to the table
    // }
    var node = document.createElement('tr')
    var td = document.createElement('td')
    var text = data.joke
    td.append(text)
    node.appendChild(td)
    document.getElementById('jokeTable').appendChild(node)
}

$(document).ready(function() {
    $('#jqueryJoke').click(function() {
        $.get(url, function(res) {
            console.log(res.joke)
            $('#jokeTable').append("<tr><td>" + res.joke + "</td></tr>")
        }, 'json')
    })
    $('#squish').click(function() {
        $.get(squish, function(res) {
            console.log(res[0].name)
            for(let i = 0 ; i < res.length; i++) {
                console.log(res[i].name)
                $('#squishies').append(`<div class='row'>
                <h3>${res[i].name}</h3>
                <img src="${res[i].img}" alt="${res[i].name}"}>
                </div>`)
            }
        }, 'json')
    })
})

