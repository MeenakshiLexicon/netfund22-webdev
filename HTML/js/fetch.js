// https://jsonplaceholder.typicode.com/guide/



// onsubmit="handleSubmit(event)"
function handleSubmit(event) {
    event.preventDefault()

    let data = {
        title: 'Sverige har fått högsta betyg i mijöpåverkan',
        body: 'Under söndagen fick Sverige en utmärkelse att de fått det högsta betyget i miljöpåverkan av WHO',
        userId: 1,
    }

    fetch('https://jsonplaceholder.typicode.com/posts', {
        method: 'post',
        headers: {
            'Content-Type': 'application/json',
        },
        body: JSON.stringify(data)
    })
    .then(res => res.json())
    .then(data => {
        console.log(data)
        document.getElementById('result').innerText = data.title
    });

}
