function setHidden(){
    document.getElementById('cookie').style.display = 'none'
}

function setAlert(element){
    alert('Loading weather report...')
}

//  change temps to f on change of select and back c if selected
// EX: 24 to 75
// (a) is (C * 9/5) + 32 = F
// (b) is (F - 32) * 5/9 = C
//  call the change class to target temps on change

function changeTemp(){
    let x = document.getElementById('tempChange').value
    console.log('you chose', x)

    // on change, if value = c, do a; else do b
    if(x == 'f'){ // this one changes only high
        let a = document.getElementsByClassName('high')
        for(i=0; i<a.length; i++){
            console.log(a[i].innerText)
            let val = a[i].innerText
            val = val.substring(0, val.length-1)
            val = Math.round((val * 9/5) + 32)
            a[i].textContent = val + '°'
        }

    }
    else{
        let a = document.getElementsByClassName('high')
        for(i=0; i<a.length; i++){
            console.log(a[i].innerText)
            let val = a[i].innerText
            val = val.substring(0, val.length-1)
            val = Math.round((val - 32) * 5/9)
            a[i].textContent = val + '°'
        }
    }
}