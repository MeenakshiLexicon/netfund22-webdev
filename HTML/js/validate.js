function validateEmail(value) {
    // https://stackoverflow.com/questions/46155/how-to-validate-an-email-address-in-javascript
    const regEx = /^(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;   

    if(regEx.test(value))
        return true

    return false
}

function validatePassword(value) {
    // https://www.thepolyglotdeveloper.com/2015/05/use-regex-to-test-password-strength-in-javascript/
    const regEx = /^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#\$%\^&\*])(?=.{8,})/;

    if(regEx.test(value))
        return true

    return false
}

function validateLength(value, minLength = 2) {
    if(value.length >= minLength)
        return true

    return false
}

function compareValues(value, compareValue) {
    if (value === compareValue)
        return true

    return false
}


function configureValidation() {
    let validateElements = document.querySelectorAll('[data-validate="true"]')
    let compareElements = document.querySelectorAll('[data-compare="true"]')

    validateElements.forEach(element => {       
        switch(element.type) {
            case "email":
                element.addEventListener('keyup', function(e) {
                    if(!validateEmail(e.target.value))
                        e.target.classList.add('is-invalid')
                    else
                        e.target.classList.remove('is-invalid')
                })
                break;

            case "password":
                element.addEventListener('keyup', function(e) {
                    if(!validatePassword(e.target.value))
                        e.target.classList.add('is-invalid')
                    else
                        e.target.classList.remove('is-invalid')
                })
                break;  

            case "text":
                element.addEventListener('keyup', function(e) {
                    if(!validateLength(e.target.value))
                        e.target.classList.add('is-invalid')
                    else
                        e.target.classList.remove('is-invalid')
                })
                break;      
        }
    })


    compareElements.forEach(element => {
        element.addEventListener('keyup', function(e) {
            if (!compareValues(e.target.value, document.getElementById(element.dataset.compareTo).value))
                e.target.classList.add('is-invalid')
            else
                e.target.classList.remove('is-invalid')  
        })
    })

}
configureValidation() 