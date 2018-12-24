function storeObjects(arr) {
    let objects=[];
    for (let i in arr) {
        let currentArr = arr[i].split(' -> ');
        let object = {name: currentArr[0], age: currentArr[1], grade: currentArr[2]};
        objects.push(object);
    }
    for (let object of objects) {
        console.log("Name: " + object.name);
        console.log("Age: " + object.age);
        console.log("Grade: " + object.grade);
    }
}
storeObjects([
    'Pesho -> 13 -> 6.00',
    'Ivan -> 12 -> 5.57',
    'Toni -> 13 -> 4.90'

])