/*function handleSubmit(event)
{
    event.preventDefault()

    fetch('https://jsonplaceholder.typicode.com/todos/1000')
    .then(response =>
        {
            if(response.status==400)
            {
                console.log("Något gick fel")
            }
            if(response.status==404)
            {
                console.log("Jag hittar inte det")
            }
        })


}   **/
 
let mybtn = document.getElementById("mybtn");
// div with id content
let content = document.getElementById("content");


function getdata()
{   url='https://jsonplaceholder.typicode.com/todos/1';
    fetch(url).then((response) =>
    {    
        return response.json();
    }) .then((data) =>
    {
        console.log(data);
    })
}

getdata()


//POST---//

function postdata()
{   url="https://netfund22-webapi.azurewebsites.net/swagger/index.html",
    data= {"email": "string","password": "string" },
params={
    method:"post",
    Headers :
    {
      
   'Content-type': 'application/json'
    },
    body: JSON.stringify(data),
}
    fetch(url,params).then((response) =>
    {    
        return response.json();
    }) .then((data) =>
    {
        console.log(data);
    })
}

   postdata()


 