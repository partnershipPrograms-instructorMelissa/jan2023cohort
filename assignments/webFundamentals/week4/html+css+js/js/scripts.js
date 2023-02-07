function increase(element){
    // get number
    let num = element.textContent.split(' ', 1)
    // replace number value
    element.textContent = element.textContent.replace(num, ++num)
    alert('Ninja was liked')
}

function remove(element){
    element.style.visibility = 'hidden'
}

function change(element){
    let str = element.textContent

    if(str.includes('in')){
        element.textContent = str.replace('in', 'out')      
    }
    else{
        element.textContent = str.replace('out', 'in')      
    }
}