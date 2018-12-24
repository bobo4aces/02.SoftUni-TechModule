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
//    if (isset($_GET['num'])) {
//        $num = intval($_GET['num']);
//        $primeNumbers = [];
//        while ($num > 0) {
//            if (isPrime($num)) {
//                echo $num . " ";
//            }
//            $num--;
//        }
//
//    }
//    function isPrime($num) {
//        if ($num < 2) {
//            return false;
//        }
//
//        for ($i = 2; $i <= sqrt($num/2); $i++) {
//            if ($num % $i == 0) {
//                return false;
//            }
//        }
//        return true;
//    }
if (isset($_GET['num'])) {
    $num = intval($_GET['num']);
    $nums = [];
    for ($i = $num; $i >=2; $i--) {
        $isPrime = false;
        for ($j = 2; $j <$i; $j++) {
            if ((floatval($i)/floatval($j))!==$i/$j) {
                $isPrime = true;
                break;
            }
        }
        if (!$isPrime) {
            array_push($nums,$i);
        }
    }
    echo implode(" ",$nums);
}
?>
</body>
</html>