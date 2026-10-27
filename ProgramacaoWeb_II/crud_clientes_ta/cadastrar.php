<?php
    include("bd/roberto.php");
    $nome       = $_POST['nome'];
    $endereco   = $_POST['endereco'];
    $cidade     = $_POST['cidade'];
    $telefone   = $_POST['telefone'];
    $email      = $_POST['email'];

    //comando sql pra mete trem no bd
    $sql = "INSERT INTO clientes (nome,endereco,cidade,telefone,email) VALUES 
    ('$nome', '$endereco', '$cidade', '$telefone', '$email')";

    //usar os comando sql
    $resultado = mysqli_query($conexao, $sql);
    
    if($resultado){
        echo "cadastrado chefe";
    }

    else{
        echo "foi nao chefe, tem umas parada torta no cliente: ";
    }
?>
