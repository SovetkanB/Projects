let num1;
let num2;
let operation;
let result;
let status = true;

alert("Hello, Welcome to Simple Calculator!");

while (status)
{
    num1 = +prompt("Please select you first number: ");
    num2 = +prompt("Please select you second number: ");
    operation = prompt("Please select an operation: a for +, s for -, m for *, d for /");

    if (operation == "a") {
        result = num1 + num2;
    } else if (operation == "s") {
        result = num1 - num2;
    } else if (operation == "m") {
        result = num1 * num2;
    } else {
        if (num2 != 0) {
            result = num1 / num2;
        } else {
            alert("Cannot devide to Zero!");
        }
    }

    alert("The result is equal to " + result);
    status = confirm("Do you wanna continue?")
}
