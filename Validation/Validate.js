
//console.log("hello world")
//console.warn("This is warning")
//console.error("This is en error")
//const s="Hello world";
//console.log(s.split(``));//array
//console.clear("clear") for clear 
// variables
//var num1=3020;
//var num2=3090;
//console.log(num1+num2)

// Data types string, object,Booleans,undefined
 //var str1="This is a String";
 //var str2="This is also a String";
// console.log("str1+str2");

 /*const name=document.getElementById(`nm`)
 const Email=document.getElementById(`mail`)
 const Password=document.getElementById(`Password`)

 FormData.addeventlistner(`submit`,(e)=>
 {
    e.preventdefault();
    checkinputs();
 });
 function checkInputs()
 {
  const username value=username.value.trim();
  const email value= Email.value.trim();
  const Password value=Password.value.trim();

  if(username value==``)
  {
    seterrorfor(username,`username can not be blank`)
  }
  else 
  {
    setsuccessfor(username);
  }
 }*/
 function validatname(event)
{
    if(event.target.value.length<5)
    document.getElementsById(event.target.id).classlist.add(`is-invalid`)
 console.log(event);
 else{
    document.getElementsById(event.target.id).classlist.remove(`is-invalid`)
 }
}
 function validatEmail(event)
{

}
function validatpassword(event)
{

}