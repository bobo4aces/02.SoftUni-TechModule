function printLines(arr) {
    for (let i in arr) {
        if (arr[i]==="Stop") {
            break;
        }
        console.log(arr[i]);
    }
}
