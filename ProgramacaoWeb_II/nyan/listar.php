<?php

/* ==========================================================
   CONEXÃO COM O BANCO DE DADOS
========================================================== */

include("conexao/conexao.php");


/* ==========================================================
   COMANDO SQL
   Busca todos os clientes cadastrados.
========================================================== */

$sql = "SELECT * FROM clientes";


/* ==========================================================
   EXECUTANDO O COMANDO SQL
========================================================== */

$resultado = mysqli_query($conexao, $sql);


/* ==========================================================
   VERIFICANDO SE A CONSULTA FOI REALIZADA
========================================================== */

if(!$resultado)
{
    die("Erro ao consultar os clientes.");
}

?>

<!DOCTYPE html>

<html lang="pt-br">

<head>

    <meta charset="UTF-8">

    <meta name="viewport"
          content="width=device-width, initial-scale=1.0">

    <title>Clientes Cadastrados</title>

    <link rel="stylesheet" href="css/estilo.css">

</head>


<body>


<div class="container container-listagem">


    <!-- =====================================================
         TÍTULO DA PÁGINA
    ====================================================== -->

    <h1>Clientes Cadastrados</h1>


    <!-- =====================================================
         ÁREA DA TABELA
    ====================================================== -->

    <div class="tabela-container">


        <table class="tabela-clientes">


            <!-- =================================================
                 CABEÇALHO DA TABELA
            ================================================== -->

            <thead>

                <tr>

                    <th>Código</th>

                    <th>Nome</th>

                    <th>Endereço</th>

                    <th>Cidade</th>

                    <th>Telefone</th>

                    <th>E-mail</th>

                </tr>

            </thead>


            <!-- =================================================
                 CORPO DA TABELA
            ================================================== -->

            <tbody>


            <?php

            /* ==================================================
               PERCORRENDO OS REGISTROS DO BANCO
            ================================================== */

            while($cliente = mysqli_fetch_assoc($resultado))
            {

            ?>


                <tr>


                    <!-- Código -->

                    <td>

                        <?php echo $cliente["codigo"]; ?>

                    </td>


                    <!-- Nome -->

                    <td>

                        <?php echo $cliente["nome"]; ?>

                    </td>


                    <!-- Endereço -->

                    <td>

                        <?php echo $cliente["endereco"]; ?>

                    </td>


                    <!-- Cidade -->

                    <td>

                        <?php echo $cliente["cidade"]; ?>

                    </td>


                    <!-- Telefone -->

                    <td>

                        <?php echo $cliente["telefone"]; ?>

                    </td>


                    <!-- E-mail -->

                    <td>

                        <?php echo $cliente["email"]; ?>

                    </td>


                </tr>


            <?php

            }

            ?>


            </tbody>


        </table>


    </div>


    <!-- =====================================================
         BOTÃO PARA VOLTAR AO CADASTRO
    ====================================================== -->

    <div class="voltar">

        <a href="index.php">

            Voltar para o cadastro

        </a>

    </div>


</div>


</body>

</html>