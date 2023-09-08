.calculator {
    width: 300px;
    background-color: #fff;
    border-radius: 10px;
    box-shadow: 0px 0px 10px rgba(0, 0, 0, 0.2);
    font-family: Arial, sans-serif;
  }
  
  .display {
    padding: 10px;
    background-color: #f2f2f2;
    text-align: right;
    border-radius: 10px 10px 0 0;
  }
  
  .keys {
    display: grid;
    grid-template-columns: repeat(4, 1fr);
    grid-gap: 5px;
    padding: 10px;
  }
  
  .key {
    background-color: #e6e6e6;
    color: #333;
    border-radius: 5px;
    border: none;
    outline: none;
    font-size: 20px;
    cursor: pointer;
    transition: background-color 0.3s ease-in-out;
  }
  
  .key:hover {
    background-color: #d9d9d9;
  }
  
  .operator {
    background-color: #f5a623;
    color: #fff;
  }
  
  .equal {
    background-color: #4caf50;
    color: #fff;
    grid-row: 5 / span 2;
    grid-column: 4 / span 1;
  }
  
  input[type="text"] {
    border: none;
    font-size: 24px;
    width: 100%;
    text-align: right;
    outline: none;
  }
  