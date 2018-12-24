<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
<form>
    N: <input type="text" name="num" />
    <input type="submit" />
</form>
<?php
if (isset($_GET['num'])) {
    $num = $_GET['num'];
    $nums = [];
    $counter = 0;
    for ($i = 1; $i <= $num; $i++) {
        if ($i % 2 == 0) {
            $nums += array_fill($counter,1,$i);
            $counter++;
        }
    }
    echo implode(" ",$nums);
}
?>
</body>
</html>