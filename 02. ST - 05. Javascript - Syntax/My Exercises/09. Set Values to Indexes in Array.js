function setValuesToIndexes(arr) {
    let length=Number(arr.shift());
    let newArr=[];
    for (let i in arr)
    {
        currentArr=arr[i].split(' - ').map(Number);
        let index=currentArr[0];
        let value=currentArr[1];
        newArr[index]=value;
    }
    for (let i=0; i<length; i++) {
        if (newArr[i]!=undefined) {
            console.log(newArr[i]);
        } else {
            console.log(0);
        }
    }
}
setValuesToIndexes(
    ['5',
        '0 - 3',
        '3 - -1',
        '4 - 2'

    ]

)