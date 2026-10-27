<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>blyat</title>
</head>
<body>
    <h1>Declare nome de um produto, seu preço e sua quantidade</h1>
    <h2></h2>
    <?php
    $nome_produto = "Playstation 5";
    $produto_preco = 3430;
    $quantidade = 2;
    $total_compra = ($produto_preco*$quantidade);

    echo "O produto $nome_produto custa $produto_preco. sua compra sera no total de $total_compra ";

    ?>
</body>
</html>