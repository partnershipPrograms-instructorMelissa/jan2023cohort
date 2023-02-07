console.log('Wired up')

function changeImg(element) {
    console.log('activated mouse event')
    // console.log(element)
    // console.log(element.src)
    // console.log(element.alt)
    if(element.alt == "Breezee") {
        element.src = "./images/yankeeBoy.png"
        element.alt = "Yankee Boy"
    } else {
        element.src = "./images/breezee.png"
        element.alt = "Breezee"
    }
}
// function changeBack(element) {
//     console.log('new event')
// }
let count = 0;
function addToCart(element) {
    console.log('button clicked')
    // let count = 0;
    if (count === 0) {
        count++
        console.log('if triggered', count)
    } else {
        count++
        console.log('else triggered', count)
    }
    document.getElementById('cart').innerText = count
}

function salePrices(element) {
    // console.log('button click')
<<<<<<< HEAD:assignments/webFundamentals/groupExamSession/js/script.js

    // making the div disappear 
    document.getElementById('sale').style.display = 'none'

    // reduce the price of each squishy by 20%
    console.log(sale); 
 
    // var price = document.getElementsByClassName('price').value;
    // var salePrice = price * .2;
    // document.getElementById('sale').value = salePrice;
    
=======
    document.getElementById('sale').style.display = 'none'
    let price = document.getElementsByClassName('price')
    console.log(price)
    console.log(price[0])
>>>>>>> 26e236c955715d7a5e82448ac368220d9a3ae3a5:lectures/webFundamentals/week2/day1/groupExamSession/js/script.js
}