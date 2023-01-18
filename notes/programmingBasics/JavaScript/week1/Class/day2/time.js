// == Manipulating Time == :O

// 1. Pull the Current date and time
const today = new Date()

// 2. Console.log the current data and time YYYY-MM-DD'T'HH:MM:SS.XXX'Z'
console.log(today)

// 3. console.log the time only
//const time = today.getHours() + ':' + today.getMinutes() + ':' + today.getSeconds()
//const time = today.toTimeString() // shows time zone
const time = today.toLocaleTimeString() // does not show time zone
console.log(time)

// 4. console.log the date only
const date = today.toDateString()
console.log(date)

// 5a. What time zone is displaying?

// 5b. Change to the different time zones (ET, CT, MT, PT)
const zoneTime = today.toLocaleTimeString('en-US', {timeZone: 'EST'})
console.log(zoneTime)