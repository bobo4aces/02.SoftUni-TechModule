function calcSumsByTown(arr) {
    let objects = arr.map(JSON.parse);
    let sums = {};
    for (obj of objects) {
        if (obj.town in sums) {
            sums[obj.town] += obj.income;
        } else {
            sums[obj.town] = obj.income;
        }
    }
    let towns = Object.keys(sums).sort();
    for (let town of towns) {
        console.log(`${town} -> ${sums[town]}`);
    }
}
let arr={"town":"Sofia","income":200};
calcSumsByTown(arr);