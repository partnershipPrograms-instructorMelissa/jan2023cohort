function increase(element){
    // get number
    element = document.getElementById(element)
    let num = element.textContent.split(' ', 1)

    // replace number value
    element.textContent = element.textContent.replace(num, ++num)
}