function findValuesInKey(arr) {
    let newArr=[];
    let key="";
    for (let i in arr) {
        let currentArr=arr[i].split(' ');
        if (currentArr.length!=1) {
            let isFound=false;
            for (let index in newArr) {
                if (newArr[index][0]===currentArr[0]) {
                    newArr[index].push(currentArr[1]);
                    isFound=true;
                }
            }
            if (!isFound) {
                newArr.push(currentArr);
            }
        } else {
            key=currentArr[0];
        }
    }
    for (let i in newArr) {
        if (newArr[i][0]===key) {
            for (let index in newArr[i]) {
                if (index!=0) {
                    console.log(newArr[i][index]);
                }
            }
            return;
        }
    }
    console.log("None");
}
findValuesInKey([
    'key value',
    'key eulav',
    'test tset',
    'key'
]);
findValuesInKey([
    '3 test',
    '3 test1',
    '4 test2',
    '4 test3',
    '4 test5',
    '4'
]);
findValuesInKey([
    '3 bla',
    '3 alb',
    '2'
]);