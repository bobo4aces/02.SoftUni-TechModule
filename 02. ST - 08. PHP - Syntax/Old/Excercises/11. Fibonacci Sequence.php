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
    $num = intval($_GET['num']);
    $nums = [];
    $fibonacci = 1;
    $f0 = 1;
    $f1 = 1;
    for ($i = 0; $i <$num; $i++) {
        if ($i == 0 || $i == 1) {
            array_push($nums,$fibonacci);
        } else {
            $f0 = $f1;
            $f1 = $fibonacci;
            $fibonacci = $f0+$f1;
            array_push($nums,$fibonacci);
        }
    }
    echo implode(" ", $nums);
}
?>
</body>
</html>