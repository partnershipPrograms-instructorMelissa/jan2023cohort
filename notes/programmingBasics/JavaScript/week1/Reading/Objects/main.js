// == Objects ==
// when an array has too much info, easier to keep in an object
var Dany = ['Daenerys', 'Targaryen', 22, 'House Targaryen', 'Valyrian', 'Queen of the Andals the Rhoynar and the First Men', 'Lady Regnant of the Seven Kingdoms', 'Protector of the Realm', 'Khaleesi of the Great Grass Sea', 'Breaker of Chains', 'Mother of Dragons', 'Queen of Meereen']

// in object form, with key: value set
var Dany = {  
    first_name: 'Daenerys',  
    last_name: 'Targaryen',  
    age: 22,  
    allegiance: 'House Targaryen',  
    ancestry: 'Valyrian',  
    titles: ['Queen of the Andals, the Rhoynar and the First Men', 'Lady Regent of the Seven Kingdoms', 'Protector of the Realm', 'Khaleesi of the Great Grass Sea', 'Breaker of Chains', 'Mother of Dragons', 'Queen of Meereen']
}

// access object properties with dot (.)
console.log(Dany.allegiance) // House Targaryen

var dojo = {}   // create empty object
//input info into object
dojo = {
    name: 'Coding Dojo',                         // property can store a string
    number_of_students: 25,                      // property can store a number
    instructors: ['Andrew', 'Michael', 'Jay'],   // property can store arrays
    location: {                                  // property can even store another object!
      city: 'San Jose',
      state: 'CA',
      zipcode: 95112
    }
}

// ways to print information from object
console.log(dojo.name, dojo.number_of_students, dojo.instructors, dojo.location)
console.log(dojo["name"]) // can also use bracket notation

// adding a new key with new value
dojo.snacks = ['fig bars', 'bagels', 'popcorn', 'apples']

// reassigning any of the properties
dojo.number_of_students = 40
dojo.location.city = "Bellevue"
dojo.location.state = 'Washington'
dojo.location.zipcode = 'unknown'

// print all data in dojo object
console.log(dojo)

// array of objects
var glazedDonuts = [
    {
      frosting: 'glazed',
      style: 'cake',
      type: 'old fashioned',
      age: '45',
      time: 'minutes'
    },
    {
      frosting: 'glazed',
      style: 'yeast raised',
      type: 'regular',
      age: '5',
      time: 'minutes'
    },
    {
      frosting: 'glazed',
      style: 'yeast raised',
      type: 'jelly filled',
      age: '1',
      time: 'seconds'
    }
]

var numPurchase = 0
for (var donut in glazedDonuts){
  console.log(glazedDonuts[donut].type)
  if((glazedDonuts[donut].age < 25 && glazedDonuts[donut].time == 'minutes') || glazedDonuts[donut].time == 'seconds'){
    numPurchase++
  }
  else {
    console.log('not this donut...')
   }
}
console.log(numPurchase) // 2

