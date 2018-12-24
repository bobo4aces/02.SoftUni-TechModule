function findKey(arr) {
    let newArr=[];
    let key="";
    for (let i in arr) {
        let currentArr=arr[i].split(' ');
        if (currentArr.length!=1) {
            let isFound=false;
            for (let index in newArr) {
                if (newArr[index][0]===currentArr[0]) {
                    newArr[index]=currentArr;
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
        if (newArr[i][0]==key) {
            console.log(newArr[i][1]);
            return;
        }
    }
    console.log("None");
}
findKey([
    'key value',
    'key eulav',
    'test tset',
    'key'
])
findKey([
    '3 test',
    '3 test1',
    '4 test2',
    '4 test3',
    '4 test5',
    '4'
])
findKey([
    '3 bla',
    '3 alb',
    '2'
])