
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
const form = document.getElementById(`form`);
 const username = document.getElementById(`username`);
 const email=document.getElementById(`email`);
 const Password=document.getElementById(`Password`);
 const Repassword=document.getElementById(`Repassword`);

 //add-event

 form.addeventlistner(`submit`,(e)=>
 {
    e.preventdefault();
    Validate();
   
 });
 
 //define validate function
 
 
 
 
 const validate=()=>
 {
  const usernameVal =signIn.Name.value.trim();
  const emailVal = signIn.Email.value.trim();
  const PasswordVal =signIn.Password.value.trim();
  const RepasswordVal =Repassword.value.trim();
 }
//validate username
/*
 if(usernameVal ==``)
  {
    setErrormsg(username,`username can not be blank`);
  }
  else if(username.length<2)
  {
    setErrormsg(username,` username min 4 char `);
  }
  else
  {
   setSuccessMsg(username);
  }

  //validate email
  if(emailVal ==``)
  {
    setErrormsg(emailVal,`Email can not be blank`);
  }
  else if(username.length<2)
  {
    setErrormsg(username,` username min 4 char `);
  }
  else
  {
   setSuccessMsg(username);
  }

 }
 */

 
 


 function validateName(event)
{
    if(event.target.value.length<5)
    {
    document.getElementsById(event.target.id).classlist.add(`is-invalid`)
 //console.log(event);
    }
 else{
    document.getElementsById(event.target.id).classlist.remove(`is-invalid`)
 }
}
 function validatEmail(event)
{  
  if(event.target.value.length<5)
  {
  document.getElementsById(event.target.id).classlist.add(`is-invalid`)
  // console.log(event);
  }
else{
  document.getElementsById(event.target.id).classlist.remove(`is-invalid`)
}

}
function validatpassword(event)
{
  
}