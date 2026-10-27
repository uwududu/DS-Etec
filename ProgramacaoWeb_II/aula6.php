<?php
    // Comentário --> Exercício =
    // Desenvolva um programa que calcule o desconto de um produto
    //exiba o nome do PRODUTO , VALOR = 100, DESCONTO = 10%, VALOR A PAGAR = 90.
    $produto = readline("Digite o nome do produto: ");
    $valor = readline("Digite o valor do produto: ");
    $desconto = readline("Digite o desconto (Ex: 10): ");
    
    echo "O nome do produto digitado é: " . $produto . "\n";
    echo "O valor do produto digitado foi de: " . $valor . "\n";
    echo "O desconto foi de: " . $desconto . "\n";
    
    $total = $valor - ($valor * ($desconto / 100));
    
    echo "O valor a ser pago com desconto é de: " . $total;
?>