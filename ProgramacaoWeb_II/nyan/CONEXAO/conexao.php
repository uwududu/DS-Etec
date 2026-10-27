<?php
   /* ==========================================================
      DADOS PARA CONEXÃO COM O BANCO DE DADOS
   ========================================================== */
   // Servidor onde o MySQL está instalado.
   $servidor = "localhost";
   // Nome do usuário do banco de dados.
   $usuario = "root";
   // Senha do banco.
   // No XAMPP, normalmente fica vazia.
   $senha = "";
   // Nome do banco criado anteriormente.
   $banco = "cadastro_clientes_ta";
   /* ==========================================================
      REALIZA A CONEXÃO COM O BANCO
   ========================================================== */
   $conexao = mysqli_connect($servidor, $usuario, $senha, $banco);
   /* ==========================================================
      VERIFICA SE A CONEXÃO FOI REALIZADA
   ========================================================== */
   if(!$conexao)
   {
       die("Erro ao conectar com o banco de dados.");
   }
?>
