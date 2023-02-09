const url = "https://geek-jokes.sameerkumar.website/api?format=json"
const otherUrl = "https://v2.jokeapi.dev/joke/Any"

// 2 basic requests
//   Get - browser can only do get (since that's what they r designed to do)
//   Post - aka fetch ex: signing in

// async - allows to run while waiting for response
// async function getText(file){
//     let x = await fetch(file)
//     let y = await x.text()
//     myDisplay(y)
// }

// single joke
// async function getJoke(){
//     let response = await fetch(`${url}`) // have to convert to json
//     let data = await response.json()
//     console.log('the data: ', data)
//     console.log('just the joke: ', data.joke)
//     let joke = await data.joke()

//     // display on html
//     document.getElementById('joke').innerHTML = joke
// }

// multiple jokes
let jokes = []
async function getJoke(){
    let response = await fetch(`${url}`) // have to convert to json
    let data = await response.json()
    console.log('the data: ', data)
    console.log('just the joke: ', data.joke)
    let joke = await data.joke()

    jokes.push(joke)
}

function populateJoke(){
    getJoke()

    let tr = document.createElement('tr')
    let td = document.createElement('td')
    let text = jokes[jokes.length-1]
    td.append(text) // use just append bc it's a text not an object
    tr.appendChild(td)
    document.getElementById('jokeTable').appendChild(tr)

}

//  in jQuery
$(document).ready(function(){
    $('#jqueryJoke').click(function(){
        $.get(url, function(res){
            console.log(res)
            $('#jokeTable').append(`<td>${res.joke}</td>`)
        }, 'json')
    })
})