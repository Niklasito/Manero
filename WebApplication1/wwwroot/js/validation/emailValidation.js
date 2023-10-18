var emailInput = document.querySelector('[data-val="true"][type="email"][name="Email"]');

emailInput.addEventListener("keyup", function (e) {
    emailValidator(e.target.value);

});


function emailValidator(value) {
    const emailRegEx = /^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/;
    if (!emailRegEx.test(value))
        document.querySelector('[data-valmsg-for="Email"]').innerHTML = "Email is invalid"
    else
        document.querySelector('[data-valmsg-for="Email"]').innerHTML = ""
}