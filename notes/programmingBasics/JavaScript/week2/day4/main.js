// Methods VS Attributes:
// Attributes - how we describe objects (dog, brown, etc.)
// Methods - how we use objects, what they can do (eat, bark, run, etc.)



// Object Oriented Programming (OOP)
// 1. Abstraction - complex actions in simple verbs -- only show necessary details to user -- hides internal implementation
// 2. Inheritance - can pass attributes and methods from the parent class to the child class (carrying down certain things)
//      EX: mom and child - inherits some attributes and methods but also it their own person
//      EX: vehicle and truck - a truck is a vehicle but is its own vehicle
// 3. Polymorphism - same method on different method on different objects (same action but in different ways)
//      EX: caterpillar and butterfly have same dna
// 4. Encapsulation - binding data and methods together that belong logically together, keep responsibility where it belongs -- data and behaviors is contained inside the class / Private vs Global

// Class - Developer vs Website

// Class name
// Constructor Function - tells about the class
// Attributes
// Methods
// Create Instances/Objects and use them

class Developer{
    constructor(name, email){   // attributes
        this.name = name
        this.email = email
        this.skill = []
        this.sites = []
    }

    printNewDev(){      // method
        console.log(`Our newest developer is: ${this.name} and their email is: ${this.email}`)
    }

    addSkill(s){
        this.skill.push(s)
        console.log(`${this.name} has just learned the skill of ${s}`)
        return this // allows for chaining
        // return whole developer object
    }
    printSkills(){
        console.log(this.skill)
        for(let i=0; i<this.skill.length; i++)
            console.log(`${this.name}'s #${i+1} skill: ${this.skill[i]}`)
    }

    addSite(s){
        this.sites.push(s)

    }
}

class Website{
    constructor(siteName, dev){
        this.siteName = siteName
        this.dev = dev
        this.url = ''
        this.front = ''
        this.back = ''
    }
    
    printNewSite(){
        console.log(`${this.dev.name} is creating ${this.siteName}`)
    }
}

let kaitlynn = new Developer('Kaitlynn', 'kaitlynn@email.com')
kaitlynn.printNewDev()  // .addSkill('MySQL') // can also chain here

kaitlynn.addSkill('JavaScript').addSkill('MySQL') // chaining requires return in function

let helper = new Website('Helper Site', kaitlynn)
helper.printNewSite()