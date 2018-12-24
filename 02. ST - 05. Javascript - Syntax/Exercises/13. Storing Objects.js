function storingObjects (args) {
    let result = [];
    for (let obj of args) {
        let input = obj.split(" -> ");
        let name = input[0];
        let age = input[1];
        let grade = input[2];

        let usernameInfo = {};
        usernameInfo['name'] = name;
        usernameInfo['age'] = age;
        usernameInfo['grade'] = grade;
        result.push(usernameInfo);
    }
    for (let obj of result) {
        console.log(`Name: ${obj.name}`);
        console.log(`Age: ${obj.age}`);
        console.log(`Grade: ${obj.grade}`);
    }
}
storingObjects([
    'Pesho -> 13 -> 6.00',
    'Ivan -> 12 -> 5.57',
    'Toni -> 13 -> 4.90'
])