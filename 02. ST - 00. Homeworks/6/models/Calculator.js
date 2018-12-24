function Calculator (leftOperand, operator, rightOperand){
    this.leftOperand = leftOperand;
    this.operator = operator;
    this.rightOperand = rightOperand;

    this.calculateResult = function() {
        let result = 0;

        switch(this.operator){
            case "+":
                result = this.leftOperand + this.rightOperand;
                break;
            case "-":
                result = this.leftOperand - this.rightOperand;
                break;
            case "*":
                result = this.leftOperand * this.rightOperand;
                break;
            case "/":
                result = this.leftOperand / this.rightOperand;
                break;
            case "pow":
                result = (Math.pow(this.leftOperand, this.rightOperand));
                break;
            case "max":
                result = Math.max(this.leftOperand, this.rightOperand);
                break;
            case "min":
                result = Math.min(this.leftOperand, this.rightOperand);
                break;
            case "Rectangle Area":
                result = this.leftOperand * this.rightOperand;
                break;
            case "Rectangle Perimeter":
                result = 2 *(this.leftOperand + this.rightOperand);
                break;


        }

        return result;
    }

}

module.exports = Calculator;