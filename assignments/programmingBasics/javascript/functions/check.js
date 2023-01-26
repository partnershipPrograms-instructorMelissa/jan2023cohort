//  Return the second-to-last element of an array. Given [42, true, 4, "Liam", 7], return "Liam".  If array is too short, return null.



function NthtoLast(arr,n){
  if(arr.length<n){
    return null;
  } else {
  return arr[arr.length-n];
  }
}
// console.log(NthtoLast ([1,3],3))
console.log(NthtoLast ([5,2,3,6,4,9,7],3));