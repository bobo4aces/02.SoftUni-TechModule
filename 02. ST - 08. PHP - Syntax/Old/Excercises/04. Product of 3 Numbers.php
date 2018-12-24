<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
<form>
    X: <input type="text" name="num1" />
    Y: <input type="text" name="num2" />
    Z: <input type="text" name="num3" />
    <input type="submit" />
</form>
<?php
if (isset($_GET['num1']) && isset($_GET['num2']) && isset($_GET['num3'])) {
    $num1 = $_GET['num1'];
    $num2 = $_GET['num2'];
    $num3 = $_GET['num3'];
    $nums = [intval($num1),intval($num2),intval($num3)];
    echo count(array_filter($nums, function ($x) {
        return $x <= 0;
    })) % 2 == 0 ? "Positive" : "Negative";
}
//if (isset($_GET['num1']) && isset($_GET['num2']) && isset($_GET['num3'])) {
//    $num1 = $_GET['num1'];
//    $num2 = $_GET['num2'];
//    $num3 = $_GET['num3'];
//    $nums = [intval($num1),intval($num2),intval($num3)];
//    $counter = 0;
//    foreach ($nums as $num) {
//        if ($num < 0) {
//            $counter++;
//        }
//    }
//    if (array_search(0,$nums)) {
//        echo "Positive";
//        return;
//    }
//    if ($counter % 2 != 0) {
//        echo "Negative";
//    } else {
//        echo "Positive";
//    }
//}
?>
</body>
</html>