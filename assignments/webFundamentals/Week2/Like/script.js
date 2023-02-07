console.log('connected!');

let count = 0;
let count1 = 0;
let count2 = 0;
let val = [];

function addLikes(element) {
  count += 1;
  document.getElementById('num').innerText = count;
}

function addLikes1(element) {
  count1 += 1;
  document.getElementById('num1').innerText = count1;
  console.log(count);
}

function addLikes2(element) {
  count2 += 1;
  document.getElementById('num2').innerText = count2;
  console.log(count);
}

// let likes = [0, 0, 0]
// let spans = [
//   document.querySelector('#num'),
//   document.querySelector('#num1'),
//   document.querySelector('#num2'),
// ];

// function addLikes(id) {
//     likes[id] += 1;
//     spans[id].innerHTML = likes[id];
//  }
