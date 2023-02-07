console.log('connected!')

let count = 0;

function addLikes(element) {
    count+=1;
    document.getElementById('num').innerText = count
    console.log(count)
}