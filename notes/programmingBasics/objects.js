let meals = [
  {
    meal: 'spaghetti',
    ingredients: {
      grains: ['pasta'],
      fruits: ['olives'],
      vegetables: ['tomato sauce'],
      proteins: ['meataballs'],
      dairy: ['cheese'],
    },
  },
  {
    meal: 'french toast',
    ingredients: {
      grains: ['bread'],
      fruits: [],
      vegetables: [],
      proteins: ['eggs'],
      dairy: ['milk'],
    },
  },
  {
    meal: 'salad',
    ingredients: {
      grains: ['croutons', 'corn'],
      fruits: [],
      vegetables: ['lettuce', 'carrots', 'cucumber', 'peppers', 'onions'],
      proteins: ['ham', 'bacon'],
      dairy: ['cheese', 'blue cheese dressing'],
    },
  },
];

function printMeals(arr, a){
    for(let i = 0; i < arr.length; i++){
        console.log(arr[i]);
    }
}
