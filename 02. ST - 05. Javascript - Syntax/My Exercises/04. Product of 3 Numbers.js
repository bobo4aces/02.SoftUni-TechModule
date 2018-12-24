function findProduct(arr) {
    let newArr=arr.map(n=>Number(n)).filter(n=>n>0);
    if (newArr.length==1||newArr.length==3) {
        console.log('Positive');
    } else {
        console.log('Negative');
    }
}
findProduct([2,3,-1]);
findProduct([5,4,3]);
findProduct([-3,-4,5]);