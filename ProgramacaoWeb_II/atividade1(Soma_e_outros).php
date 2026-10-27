<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>blayat</title>
</head>
<body>
    <h1>Programa que receba dois numeros e faça soma, subtraçao, multiplicaçao e divisao</h1>
    <h2>Soma (+)    subtraçao (-)   multiplicaçao (*)   divisao(/)</h2>
    <?php
        $n1 = 101;
        $n2 = 69;

        $soma = ($n1+$n2);
        $subtracao = ($n1-$n2);
        $multiplicacao = ($n1*$n2);
        $divisao = ($n1/$n2);

        echo "sua soma e de $soma";
        echo "<br>";
        echo "sua subtracao e de $subtracao";
        echo "<br>";
        echo "sua multiplicacao e de $multiplicacao";
        echo "<br>";
        echo "sua divisao e de $divisao";
    
    ?>
</body>
</html>