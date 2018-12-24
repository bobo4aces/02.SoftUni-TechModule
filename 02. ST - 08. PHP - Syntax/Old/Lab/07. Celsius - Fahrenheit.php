<?php
function celsiusToFahrenheit (float $degreesCelsius) : float
{
    return $degreesCelsius * 1.8 + 32;
}
function fahrenheitToCelsius (float $degreesFahrenheit) : float
{
    return ($degreesFahrenheit - 32) / 1.8;
}
$msgAfterCelsius = "";
if (isset($_GET['cel'])) {
    $degreesCelsius = floatval($_GET['cel']);
    $degreesFahrenheit = celsiusToFahrenheit($degreesCelsius);
    $msgAfterCelsius = "{$degreesCelsius} &deg;C = {$degreesFahrenheit} &deg;F";
}
$msgAfterFahrenheit = "";
if (isset($_GET['fah'])) {
    $degreesFahrenheit = floatval($_GET['fah']);
    $degreesCelsius = fahrenheitToCelsius($degreesFahrenheit);
    $msgAfterFahrenheit = "{$degreesFahrenheit} &deg;F = {$degreesCelsius} &deg;C";
}
?>
<form>
    Celsius: <input type="text" name="cel" />
    <input type="submit" value="Convert">
    <?= $msgAfterCelsius ?>
</form>
<form>
    Fahrenheit: <input type="text" name="fah" />
    <input type="submit" value="Convert">
    <?= $msgAfterFahrenheit ?>
</form>

