function editProfileForm() {
    document.getElementById('submitButton').classList.remove('d-none')
    document.getElementById('profileForm_success').classList.add('d-none')
    document.getElementById('profileForm_error').classList.add('d-none')

    let elements = document.querySelectorAll('[disabled]')
    for (let element of elements)
        if(element.type !== 'email')
            element.disabled = false
}

function getUserProfile() {
    fetch('https://netfund22-webapi.azurewebsites.net/api/Users/current', {
        method: 'get',
        headers: {
            'Authorization': `bearer ${localStorage.getItem('accessToken')}`
        }
    })
    .then(async res => {
        const data = await res.json()

        if(res.ok)
            return data

        return Promise.reject(data)
    })
    .then(data => {
        document.getElementById('userId').value = data.id
        document.getElementById('firstName').value = data.firstName
        document.getElementById('lastName').value = data.lastName
        document.getElementById('email').value = data.email
        document.getElementById('phoneNumber').value = data.phoneNumber
        document.getElementById('addressLine').value = data.addressLine
        document.getElementById('postalCode').value = data.postalCode
        document.getElementById('city').value = data.city

    })
    .catch(error => {
        document.getElementById('profileForm_error').classList.remove('d-none')
        document.getElementById('profileForm_errorMessage').innerHTML = `<strong>Something when wrong when we tried to get your profile information.</strong>`           
    })
}

function handleProfileForm(event) {
    event.preventDefault()
    document.getElementById('submitButton').classList.add('d-none')
    document.getElementById('profileForm_success').classList.add('d-none')
    document.getElementById('profileForm_error').classList.add('d-none')   

    event.target[0].disabled = true,
    event.target[1].disabled = true,
    event.target[2].disabled = true,
    event.target[3].disabled = true,
    event.target[4].disabled = true,
    event.target[5].disabled = true,
    event.target[6].disabled = true,
    event.target[7].disabled = true


    let json = JSON.stringify({
        id: event.target[0].value,
        firstName: event.target[1].value,
        lastName: event.target[2].value,
        email: event.target[3].value,
        phoneNumber: event.target[4].value,
        addressLine: event.target[5].value,
        postalCode: event.target[6].value,
        city: event.target[7].value     
    })

    fetch('https://netfund22-webapi.azurewebsites.net/api/Users/current', {
        method: 'put',
        headers: {
            'Authorization': `bearer ${localStorage.getItem('accessToken')}`,
            'Content-Type': 'application/json'
        },
        body: json
    })
    .then(async res => {
        const data = await res.json()

        if (res.ok)
            return data

        return Promise.reject(data)
    })
    .then(data => {
        document.getElementById('profileForm_success').classList.remove('d-none')
        document.getElementById('profileForm_successMessage').innerHTML = `<strong>Your profile has been updated.</strong>`  

        setTimeout(function() {
            document.getElementById('profileForm_success').style.opacity = '0'
        }, 2000)
        setTimeout(function() {
            document.getElementById('profileForm_success').classList.add('d-none')
        }, 2500)
    })
    .catch(error => {
        document.getElementById('profileForm_error').classList.remove('d-none')
        document.getElementById('profileForm_errorMessage').innerHTML = `<strong>Something went wrong when we tried to update your profile.</strong> ${error}`       
    })
} 