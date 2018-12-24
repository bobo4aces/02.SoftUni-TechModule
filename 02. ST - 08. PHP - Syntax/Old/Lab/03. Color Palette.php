<head>
    <link rel="stylesheet" type="text/css" href="stylesheet.css">
</head>
<body><?php
    for ($red = 0; $red <= 255; $red+=51) {
        for ($green = 0; $green <= 255; $green+=51) {
            for ($blue = 0; $blue <= 255; $blue+=51) {
                echo "<div style='background:rgb($red, $green, $blue)'>rgb($red, $green, $blue)</div>\n";
            }
        }
    }
    ?>
</body>