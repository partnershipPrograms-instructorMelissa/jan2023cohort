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
    if (count === 0) {
        count++
        // console.log('if triggered', count)
    } else {
        count++
        // console.log('else triggered', count)
    }
    document.getElementById('cart').innerText = count
}

function salePrices(element) {
    // console.log('button click')

    // making the div disappear 
    document.getElementById('sale').style.display = 'none'

    // reduce the price of each squishy by 20%
    console.log(sale); 
 
    // var price = document.getElementsByClassName('price').value;
    // var salePrice = price * .2;
    // document.getElementById('sale').value = salePrice;
    
}