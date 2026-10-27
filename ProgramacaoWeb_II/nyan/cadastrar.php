<?php

/* ==========================================================
   CONEXÃO COM O BANCO DE DADOS
========================================================== */

include("conexao/conexao.php");


/* ==========================================================
   RECEBENDO OS DADOS DO FORMULÁRIO
========================================================== */

$nome = $_POST["nome"];
$endereco = $_POST["endereco"];
$cidade = $_POST["cidade"];
$telefone = $_POST["telefone"];
$email = $_POST["email"];


/* ==========================================================
   COMANDO SQL PARA INSERIR O CLIENTE
========================================================== */

$sql = "INSERT INTO clientes
        (nome, endereco, cidade, telefone, email)
        VALUES
        ('$nome', '$endereco', '$cidade', '$telefone', '$email')";


/* ==========================================================
   EXECUTANDO O COMANDO SQL
========================================================== */

$resultado = mysqli_query($conexao, $sql);


/* ==========================================================
   VERIFICANDO SE O CADASTRO FOI REALIZADO
========================================================== */

/* if($resultado)
{
    echo "Cliente cadastrado com sucesso!";
}
else
{
    echo "Erro ao cadastrar o cliente.";
}
*/

if($resultado)
{
    echo "<script>";

    echo "alert('Cliente cadastrado com sucesso!');";

    echo "if(confirm('Deseja cadastrar mais um cliente?'))";
    echo "{";
    echo "    window.location.href='index.php';";
    echo "}";
    echo "else";
    echo "{";
    echo "    window.location.href='index.php';";
    echo "}";

    echo "</script>";
}
else
{
    echo "Erro ao cadastrar o cliente.";
}

?>

