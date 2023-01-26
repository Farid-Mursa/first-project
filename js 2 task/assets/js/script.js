const button = document.querySelector(".btn5");


button.onclick = function(){
let name=Name();
let surname=Surname();
let chechpass=Checkpass();
let email=Email();
if(name==true && surname==true && chechpass==true && email==true){
  window.location.href="https://www.google.com"
}
}

function Name(){
  let name=document.getElementById("name").value;
  if(name.length>3){
    return true;
  }
  else{
    let warning="Name must be 3 lenght";
    document.getElementById("first-w").innerHTML = warning;
    return false;
  }
}

function Surname(){
  let surname=document.getElementById("surname").value;
  if(surname.length>3){
    return true;
  }
  else{
    let warning="Surname must be 3 lenght";
    document.getElementById("second-w").innerHTML = warning;
    return false;
  }
}

function Checkpass(){
  let password=document.getElementById("password").value;
  if(password.length>7){
    return true;
  }
  else{
    let warning="Password must be 8 length";
    document.getElementById("third-w").innerHTML = warning;
    return false;
  }
}

function Email(){
  let email=document.getElementById("email").value;
  if(email.includes("@")==true){
    return true;
  }
  else{
    let warning="In your email must be @";
    document.getElementById("fourth-w").innerHTML = warning;
    return false;
  }
}