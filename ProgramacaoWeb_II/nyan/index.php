<?php 
    include("conexao/conexao.php");
?>

<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Cadastro de Clientes</title>
    <link rel="stylesheet" href="css/estilo.css">
</head>
<body>
<div class="container">
    <h1>Cadastro de Clientes</h1>
    <form method="POST" action="cadastrar.php">
        <div class="grupo">
            <label>Código do Cliente</label>
            <input type="text" name="codigo" readonly>
        </div>
        <div class="grupo">
            <label>Nome</label>
            <input type="text" name="nome">
        </div>
        <div class="grupo">
            <label>Endereço</label>
            <input type="text" name="endereco">
        </div>
        <div class="grupo">
            <label>Cidade</label>
            <input type="text" name="cidade">
        </div>
        <div class="grupo">
            <label>Telefone Celular</label>
            <input type="text" name="telefone">
        </div>
        <div class="grupo">
            <label>E-mail</label>
            <input type="email" name="email">
        </div>
        <div class="botoes">
            <button type="button">Novo</button>
            <button type="submit">Salvar</button>
            <button type="button">Alterar</button>
            <button type="button">Excluir</button>
            <button type="reset">Cancelar</button>
        </div>
        
    </form>

    <!-- =====================================================
         BOTÃO PARA A PÁGINA LISTAR
    ====================================================== -->

    <div class="voltar">

        <a href="listar.php">

            LISTAR CLIENTES CADASTRADOS

        </a>

    </div>

    </div>



</body>
</html>
