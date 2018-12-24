function addRemoveElements(arr) {
    let newArr=[];
    for (let i in arr) {
        let currentArr=arr[i].split(' ');
        if (currentArr[0]==="add") {
            newArr.push(Number(currentArr[1]));
        } else {
            let index=Number(currentArr[1]);
            newArr.splice(index,1);
        }
    }
    for (let number of newArr) {
        console.log(number);
    }
}
addRemoveElements([
    'add 3',
    'add 5',
    'add 7'
])
addRemoveElements([
    'add 3',
    'add 5',
    'remove 1',
    'add 2'
])
addRemoveElements([
    'add 3',
    'add 5',
    'remove 2',
    'remove 0',
    'add 7'
])