console.log('js connected')

let studentArr = [] // to store all students and their grades

/* 
    class: Student
    this class will have attributes name, grades, and average of the student
    name and grades will be gathered from the website
    a function will be used to calculate the average of the grades; this will need to be called outside of the 
*/
let Student = function(name, grades){
    this.name = name        // name attribute - required
    this.grades = grades    // grades attribute - required
    this.avg = 0            // avg attribute - when class object made, starts at 0

    // function for average calculation
    this.calcAvg = function(){
        for(let i=0; i<this.grades.length; i++){
            this.avg += this.grades[i]  // sum of all grades
        }
        this.avg /= this.grades.length  // calculate average
        console.log('Calculated Avg:', this.avg)
    }
}

function calcGrades() {
    // get name and grade values from site
    let name = document.grades.firstName.value
    let a = parseInt(document.grades.gradeA.value)
    let b = parseInt(document.grades.gradeB.value)
    let c = parseInt(document.grades.gradeC.value)
    let d = parseInt(document.grades.gradeD.value)

    // set student value to equal instance of class Student using information collected from site
    let student = new Student(name, [a, b, c, d])
    // calculate the student value average
    student.calcAvg()

    // add student value to the student array
    studentArr.push(student)
    console.log(studentArr)

    // print grades to the website
    document.getElementById('student').innerHTML +=
    student.name + ' Calculated Avg: ' + student.avg + '<br>'  
}
