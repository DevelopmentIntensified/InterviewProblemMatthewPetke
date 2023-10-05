const billInput = document.getElementById("bill");
const tipInput = document.getElementById("tip");

const page1 = document.getElementById("inputPage");
const page2 = document.getElementById("outputPage");

const calulatedTip = document.getElementById("calculatedTip");
const inputform = document.getElementById("tipCalcForm");

inputform.addEventListener("submit", (event) => {
    event.preventDefault();

    const bill = parseFloat(billInput.value);
    const tip = bill * (parseInt(tipInput.value) / 100);
    const totalBill = Math.round((tip + bill) * 100) / 100

    page1.style.display = "none";
    page2.style.display = "block";

    calulatedTip.innerText = `Your calculated tip is: $${tip}\nYour total cost with tip is: $${totalBill}`;


})
