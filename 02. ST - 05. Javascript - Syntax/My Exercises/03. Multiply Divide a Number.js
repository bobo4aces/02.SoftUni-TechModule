function calculateNumber(arr) {
    let firstNumber=Number(arr[0]);
    let secondNumber=Number(arr[1]);
    let result=0;
    if (secondNumber>=firstNumber) {
        result=firstNumber*secondNumber;
    } else {
        result=firstNumber/secondNumber;
    }
    console.log(result);
}
calculateNumber([2,3]);
calculateNumber([13,13]);
calculateNumber([3,2]);
calculateNumber([144,12]);