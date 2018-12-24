function keyValuePairs (args){
    let key = args.pop();
    let keyValue = [];
    for (let obj of args) {
        let input = obj.split(' ');
        let key = input[0];
        let value = input[1];
        keyValue[key]=value;
    }
    if (keyValue.hasOwnProperty(key)) {
        console.log(keyValue[key]);
    } else {
        console.log("None");
    }
}
keyValuePairs([
    'key value',
    'key eulav',
    'test tset',
    'key'

])