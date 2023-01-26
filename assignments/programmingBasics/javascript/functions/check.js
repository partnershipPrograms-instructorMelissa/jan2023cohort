//  Return the second-to-last element of an array. Given [42, true, 4, "Liam", 7], return "Liam".  If array is too short, return null.

function secMax(arr) {
  var max = arr[0];
  var sec = arr[0];
  for (var i = 0; i < arr.length; i++) {
    if (arr.length < 2) {
      return null;
    } else if (arr[i] > max) {
      sec = max;
      max = arr[i];
    } else if (arr[i] > sec && arr[i] < max) sec = arr[i];
  }
  return sec;
}
console.log(secMax([1, 9, 5, 4]));
console.log(secMax([2, 10, 15, 4]));
console.log(secMax([1]));
console.log(secMax([]));
