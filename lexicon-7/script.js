
function clearErrors()
{
    errors= document.getElementsByClassName(`formerror`);
    for(let item of errors)
    {
        item.innerHTML="";
    }
}

function seterror(id, error)
{
   element = document.getElementById(id);
   element.getElementsByClassName("formerror")[0].innerHTML = error;
}

function validateForm()
{  var returnval=true;
    clearErrors();
    var name = document.forms["myform"]["fname"].value;
if(name.length<5)
{
    seterror("name", "length of name is short");
    returnval=false;
}

/*if(name.length==0)
{
    seterror("name", "length of name cannot be zero");
    returnval=false;
}*/
// Email
 var email = document.forms["myform"]["femail"].value;

if(email.length<20)
{
    seterror("email", "length of email is short");
    returnval=false;
}

//password
var password = document.forms["myform"]["fpass"].value;

if(password.length<5)
{
    seterror("pass", "length of password is short");
    returnval=false;
}

//confirm Password
var cpassword = document.forms["myform"]["fcpass"].value;

if(cpassword!=password)
{
    seterror("cpass", "Password should be same");
    returnval=false;
}


return returnval;

}