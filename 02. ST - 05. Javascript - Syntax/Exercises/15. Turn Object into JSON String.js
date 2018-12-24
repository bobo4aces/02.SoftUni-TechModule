function turnObject (args) {
    let studentInfo = {};
    for (let obj of args) {
        let input = obj.split(" -> ");
        let key = input[0];
        let value = input[1];

        //if(isFinite(value))
        if (!isNaN(value)) {
            value = Number(value);
        }
        studentInfo[key]=value;
    }
    console.log(JSON.stringify(studentInfo));
}
turnObject([
    'name -> Angel',
    'surname -> Georgiev',
    'age -> 20',
    'grade -> 6.00',
    'date -> 23/05/1995',
    'town -> Sofia'
]);