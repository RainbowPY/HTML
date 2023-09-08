let display = document.getElementById('result');

function insert(value) {
  display.value += value;
}

function clearDisplay() {
  display.value = '';
}

function backspace() {
  display.value = display.value.slice(0, -1);
}

function calculate() {
  let expression = display.value;
  let result = eval(expression);
  display.value = result;
}
