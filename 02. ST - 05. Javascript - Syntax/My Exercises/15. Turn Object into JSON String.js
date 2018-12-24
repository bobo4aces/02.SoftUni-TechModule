function turnObjectIntoJSONString(arr) {
    let object={};
    for (let i in arr) {
        let currentArr=arr[i].split(' -> ');
        let key=currentArr[0];
        let value=currentArr[1];
        if (value==Number(value)) {
            value=Number(value);
        }
        object[key]=value;
    }
    console.log(JSON.stringify(object));
}
turnObjectIntoJSONString([
    'name -> Angel',
    'surname -> Georgiev',
    'age -> 20',
    'grade -> 6.00',
    'date -> 23/05/1995',
    'town -> Sofia'

])