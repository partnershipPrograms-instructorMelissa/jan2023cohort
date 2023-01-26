// ======= Pet Training =======
const {petTrainingOwner, users, owners, trainers, pets, cohorts, enrolled} = require('./data1')

console.log('whole data set:', petTrainingOwner) // [ { owners: [ [Object], [Object], [Object], [Object] ] } ]

console.log('==========================================')

let oneOwner = petTrainingOwner[0].owners[0]
console.log('one owner:', oneOwner)

console.log('==========================================')

let onePet = petTrainingOwner[0].owners[0].pets[0]
console.log('one pet:', onePet)

console.log('==========================================')

let oneEnroll = petTrainingOwner[0].owners[0].pets[0].enrolled[0]
console.log('one enrolled:', oneEnroll)

console.log('==========================================')

let oneCohort = petTrainingOwner[0].owners[0].pets[0].enrolled[0].cohorts[0]
console.log('one class instance:', oneCohort)

console.log('==========================================')



// ======= MEALS =======
const {meals} = require('./data2')