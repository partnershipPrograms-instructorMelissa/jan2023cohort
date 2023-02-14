// Programming Languages and Frameworks

let tools = [
    "HTML",
    "JavaScript",
    "CSS",
    "C#",
    "Java",
    "Python",
    "Spring Boot",
    ".NET",
    "PHP",
    "Google Fu",
    "Git",
    "Github"
]
// console.log("The root Array:", tools)
// for(let i = 0; i < tools.length; i++){
//     console.log("looping through array:", tools[i])
//     // return tools[i]
// }
function siteTools(arr) {
    var node = document.createElement('div')
    node.setAttribute('class', 'node')
    // var img = document.createElement('img')
    // img.src = ''
    for(let i = 0; i  < arr.length; i++) {
        console.log(arr[i])
        var toolDiv = document.createElement('div')
        var h3 = document.createElement('h3') 
        var tool = document.createTextNode(arr[i])

        // whatever is appended first will appear first
        h3.appendChild(tool) // put text in h3
        toolDiv.appendChild(h3) // where h3 will go
        toolDiv.setAttribute('class', 'btn btn-outline-info') //add class to toolDiv
        node.appendChild(toolDiv)
    }
    console.log(node)
    document.getElementById('tools').appendChild(node)  // add node to existing html div
}





// Clock
// returns new date / seconds + min + hours
function getSecondsSinceStartOfDay() {
    return new Date().getSeconds() + 
      new Date().getMinutes() * 60 + 
      new Date().getHours() * 3600;
}

/* 
    hour hand moves 30 degrees / hour
    minute moves 6 degrees / min
    second moves 1/10th degree / second
*/
setInterval( function() {
    // getting time
    var time = getSecondsSinceStartOfDay();
    // printing time
    // console.log(time);
    // moving the hands
    // hour
    let hours = parseInt(time/3600)         
    var h_angle = (180 + hours*30)%360
    document.getElementById('hour').style.transform = `rotate(${h_angle}deg)`

    // minutes
    let minutes = parseInt((time - hours*3600)/60)
    var m_angle = (180 + minutes*6)%360
    document.getElementById('minutes').style.transform = `rotate(${m_angle}deg)`

    // seconds
    let seconds = parseInt((time-minutes*60-hours*3600))
    var s_angle = (180 + seconds*6)%360
    document.getElementById('seconds').style.transform = `rotate(${s_angle}deg)`

    console.log('change seconds ', seconds,(s_angle))


}, 1000);
// how often to run the function