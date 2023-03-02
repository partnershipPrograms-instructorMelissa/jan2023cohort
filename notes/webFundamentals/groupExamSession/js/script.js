console.log('Wired up')

function changeImg(element) {
    // console.log('activated mouse event')
}
function changeBack(element) {
    // console.log('new event')
}
let count = 0;
function addToCart(element) {
    console.log('button clicked')
    // let count = 0;
    if (count) {
        count++
        console.log('if triggered', count)
    } else {
        count++
        // console.log('else triggered', count)
    }
    document.getElementById('cart').innerText = count
}

function salePrices(element) {

    document.getElementById('sale').style.display ='none'
    let value = document.getElementsByClassName('price')
    console.log(value)

    for(let i = 0; i < value.length; i++){
        let newValue = parseInt(.8 * value[i].innerText)
        value[i].textContent = newValue
    }

}