//  Return the second-to-last element of an array. Given [42, true, 4, "Liam", 7], return "Liam".  If array is too short, return null.

function evenAndOdd(arr) {
  for (let i = 0; i < arr.length - 2; i++) {
    if (arr[i] % 2 !== 0) {
      if (arr[i + 1] % 2 !== 0) {
        if (arr[i + 2] % 2 !== 0) {
          console.log(`That's odd!`);
        }
      }
    }

    if (arr[i] % 2 == 0) {
      if (arr[i + 1] % 2 == 0) {
        if (arr[i + 2] % 2 == 0) {
          console.log(`Even more so!`);
        }
      }
    }
  }
}

var d = [2, 4, 6, 1, 5, 7, 8, 0, 6, 5];
evenAndOdd(d);
