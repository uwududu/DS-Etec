<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>suka blayat</title>
</head>
<body>
    <h1>oq ser a pola de um php?</h1>
    <h2>e uma linguagem de programação usada principalmente para programação web no lado do servidor</h2>

    <h3>primeiro codigo em php: exemplo ez</h3>
        <?php
            echo "salve galerinha do youtube!";
        ?>

    <h3>outras pola de php: regras:     1.toda variavel começa com $    2.php nao exige tipo fixo (e dinamicamente tipado)</h3>
        <?php
            $nome = "Vanderley";
            $idade = 38;

            echo "meu nome e $nome e possivelment tenho $idade";
        ?>
    <h3>operadores aritmetricos basicos</h3>
    <h4>adiçao</h4>
        <?php
        $n1 = 10;
        $n2 = 8;
        $soma = $n1 + $n2;
        echo "a soma dos dois valores e de: $soma";
        echo "<br>";
        echo "a soma dos dois valores e de: " . $soma;
        echo "<br>";
        echo "a soma dos dois valores e de: " . ($n1+$n2);

        ?>
    <h4>subtração</h4>
        <?php
        $n1 = 10;
        $n2 = 8;
        $subtracao = $n1 - $n2;
        echo "a subtração dos dois valores e de: $subtracao";
        echo "<br>";
        echo "a subtração dos dois valores e de: " . ($n1-$n2);
        
        ?>
    <h4>multiplicação</h4>
        <?php
        $n1 = 10;
        $n2 = 8;
        $multiplicacao = $n1 * $n2;
        echo "a subtração dos dois valores e de: $multiplicacao";
        echo "<br>";
        echo "a subtração dos dois valores e de: " . ($n1*$n2);
        
        ?>

</body>
</html>