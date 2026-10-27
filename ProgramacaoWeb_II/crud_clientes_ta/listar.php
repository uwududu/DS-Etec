<?php
    include("bd/roberto.php");
        $sql = "select * from clientes";
        $resultado = mysqli_query($conexao,$sql);
    if(!$resultado){
        die("erro no bd de cliente");
    }
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>clientes cadastrados</title>
</head>
<body>
    <div class="container">
        <h1>Clientes cadastrados</h1>
            <table>
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
                <tbody>
                    <?php
                        while($cliente = mysqli_fetch_assoc($resultado))
                        {
                    ?>
                    <tr>
                        <td>
                            <?php echo $cliente["codigo"];?>
                        </td>
                        <td>
                            <?php echo $cliente["nome"];?>
                        </td>
                        <td>
                            <?php echo $cliente["endereco"];?>
                        </td>
                        <td>
                            <?php echo $cliente["cidade"];?>
                        </td>
                        <td>
                            <?php echo $cliente["telefone"];?>
                        </td>
                        <td>
                            <?php echo $cliente["email"];?>
                        </td>
                    </tr>
                    <?php
                        }
                    ?>
                </tbody>
            </table>
    </div>

    <div class="listar">
        <a href="regianaldorossi.php">Voltar</a>
    </div>
</body>
</html>