function printNNumbers(str) {
    let number=Number(str);
    for (let i=1; i<=number; i++) {
        console.log(i);
    }
    if (number==0) {
        console.log(0);
    }
}
printNNumbers(5);
printNNumbers(2);