<?php
    //servidor
    $servidor = "localhost";
    //usuario
    $usuario = "root";
    //senha
    $senha = "";
    //nome do banco
    $banco = "cadastro_clientes_ta";

    //realiza a connection
    $conexao = mysqli_connect($servidor, $usuario, $senha, $banco);
    if (!$conexao) {
        die("Erro, nao sei oque aconteceu cara(possivelmente seje problema de bios ou de banco)");
    }
?>