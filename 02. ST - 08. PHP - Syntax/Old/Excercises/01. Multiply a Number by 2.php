<?php
$num = "";
if (isset($_GET['num'])) {
    $num = intval($_GET['num']);
    $num *= 2;
}
?>
<form>
    N: <input type="text" name="num" />
    <input type="submit" value="Submit" />
</form>
<?= $num?>
