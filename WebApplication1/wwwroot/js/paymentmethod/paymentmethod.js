const cardFirstName = document.getElementById("card-name");
const cardLastName = document.getElementById("card-last-name");
const cardNameInput = document.getElementById("payment-method-card-name");
const cardNumber = document.getElementById("card-number");
const cardNumberInput = document.getElementById("payment-method-card-number");
const cardDate = document.getElementById("card-date");
const cardDateInput = document.getElementById("payment-method-date");

function updateCardDetails() {
    cardNameFormatting(cardNameInput.value);
    cardNumberFormatting(cardNumberInput.value);
    cardDateFormatting(cardDateInput.value);
}

function cardNameFormatting(input) {
    let firstName = "";
    let lastName = "";
    let rowSwitched = false;
    for (let i = 0; i < input.length; i++) {
        if (rowSwitched) {
            lastName += input[i];
        }
        if (input[i] === " ") {
            rowSwitched = true;
        }
        if (!rowSwitched) {
            firstName += input[i];
        }
    }
    cardFirstName.innerHTML = firstName;
    cardLastName.innerHTML = lastName;
}

function cardNumberFormatting(input) {
    let formattedInput = "";
    for (let i = 0; i < input.length; i++) {
        if (isNaN(parseInt(input[i]))) {
            cardNumberInput.value = cardNumberInput.value.slice(0, -1);
            return;
        }
        formattedInput += input[i];
        if ((i + 1) % 4 === 0) {
            formattedInput += " ";
        }
    }
    cardNumber.innerHTML = formattedInput;
}

function cardDateFormatting(input) {
    let formattedInput = "";
    for (let i = 0; i < input.length; i++) {
        if (input[i] === "-") {
            formattedInput += "/";
        } else {
            formattedInput += input[i];
        }
    }
    cardDate.innerHTML = formattedInput;
}

document.addEventListener("keyup", updateCardDetails);