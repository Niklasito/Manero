const rememberMeInput = document.querySelector('[data-val="true"][type="checkbox"][name="RememberMe"]');

function toggleRememberMe() {
    const currentValue = rememberMeInput.value;
    rememberMeInput.value = (currentValue === 'false') ? 'true' : 'false';
}

const rememberMeCheckbox = document.querySelector('.sign-in-input-checkbox');
rememberMeCheckbox.addEventListener('change', toggleRememberMe);


const signInButton = document.querySelector('.sign-in-input[type="submit"]');
signInButton.addEventListener('click', function (event) {

    if (rememberMeInput.value === 'true') {
        document.cookie = 'rememberMe=; expires=Thu, 01 Jan 1970 00:00:00 UTC;';
        document.cookie = 'email=; expires=Thu, 01 Jan 1970 00:00:00 UTC;';
        document.cookie = 'password=; expires=Thu, 01 Jan 1970 00:00:00 UTC;';
    }
    else {
        const rememberMeValue = document.getElementById('RememberMe').value;
        const emailValue = document.getElementById('Email').value;
        const passwordValue = document.getElementById('Password').value;
        document.cookie = `rememberMe=${rememberMeValue}; expires=${new Date(Date.now() + 365 * 24 * 60 * 60 * 1000).toUTCString()}`;
        document.cookie = `email=${emailValue}; expires=${new Date(Date.now() + 365 * 24 * 60 * 60 * 1000).toUTCString()}`;
        document.cookie = `password=${passwordValue}; expires=${new Date(Date.now() + 365 * 24 * 60 * 60 * 1000).toUTCString()}`;
    }
});

function getCookie(cookieName) {
    const name = cookieName + "=";
    const decodedCookie = decodeURIComponent(document.cookie);
    const cookieArray = decodedCookie.split(';');

    for (let i = 0; i < cookieArray.length; i++) {
        let cookie = cookieArray[i];
        while (cookie.charAt(0) === ' ') {
            cookie = cookie.substring(1);
        }

        if (cookie.indexOf(name) === 0) {
            return cookie.substring(name.length, cookie.length);
        }
    }

    return null; 
}

window.addEventListener('load', function () {
    const emailValue = getCookie('email');
    const passwordValue = getCookie('password');
    const rememberMeValue = getCookie('rememberMe');

    console.log(emailValue);

    document.querySelector('[data-val="true"][type="email"][name="Email"]').value = emailValue;
    document.querySelector('[data-val="true"][type="password"][name="Password"]').value = passwordValue;

    if (rememberMeValue === 'false') {
        document.querySelector('[data-val="true"][type="checkbox"][name="RememberMe"]').checked = true;
        rememberMeInput.value = false;
    }
});