<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>rogerio do get</title>
</head>
<body>
    <h1>soma de dois valores utilizando o formulario e o metodo GET para envio de informaçoes</h1>
    <form method="GET">
        Valor 1:
        <input type="decimal" name="osvaldo">
        <br></br>
        Valor 2:
        <input type="decimal" name="valdemar">
        <br></br>
        <input type="submit" value ="somar">
        <br></br>
    </form>
    <?php
        $v1 = $_GET['osvaldo']?? 0;
        $v2 = $_GET['valdemar']?? 0;
        $soma = $v1 + $v2;
        echo "Sua soma deu: " .$soma;
    ?>
</body>
</html>