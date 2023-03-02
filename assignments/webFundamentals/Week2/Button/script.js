console.log('connected!')

function hideMe(element) {
    element.style.display = 'none';
}

function changeText(element){
    console.log('clicked')
    if(element.innerText === 'Login')
    {
        element.innerText = 'Logout'
    } else {
        element.innerText = 'Login'
    }
}

function ninjaLiked(element){
    alert("Ninja was liked!");
}