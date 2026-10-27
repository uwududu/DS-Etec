<!DOCTYPE html>
<html lang="pt-BR">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Osmar</title>
</head>
<body>

<?php
/*calculos */
$areaTriangulo = ($_POST['calcTriangulo'])
  ? (($_POST['baseTri'] * $_POST['alturaTri']) / 2)
  : "";

$areaQuadrado = ($_POST['calcQuadrado'])
  ? ($_POST['ladoQuad'] * $_POST['ladoQuad'])
  : "";

$areaRetangulo = ($_POST['calcRetangulo'])
  ? ($_POST['baseRet'] * $_POST['alturaRet'])
  : "";

$areaCirculo = ($_POST['calcCirculo'])
  ? (pi() * ($_POST['raioCirc'] * $_POST['raioCirc']))
  : "";

$areaTrapezio = ($_POST['calcTrapezio'])
  ? (($_POST['baseMaior'] + $_POST['baseMenor']) * $_POST['alturaTrap']) / 2
  : "";

$areaLosango = ($_POST['calcLosango'])
  ? (($_POST['diagMaior'] * $_POST['diagMenor']) / 2)
  : "";

?>

<div class="topo">
  Cálculo de Área
</div>
<div class="container">


  <!--triangulo-->
  <div class="box" id="triangulo">
    <div class="triangulo"></div>
    <div class="titulo">Triângulo</div>
   
                        <form method="POST" action="#triangulo">
                        <div class="inputs">
                            <input type="number" name="baseTri" placeholder="Base" required>
                            <input type="number" name="alturaTri" placeholder="Altura" required>
                            <button type="submit" name="calcTriangulo">Calcular</button>
                          </div>
                        </form>

    <div class="resultado">
                        <?= ($areaTriangulo !== "") ? "Área: " . $areaTriangulo . " m²" : "" ?>
    </div>
  </div>


<!--quadrado-->
  <div class="box" id="quadrado">
    <div class="quadrado"></div>
    <div class="titulo">Quadrado</div>
                          <form method="POST" action="#quadrado">
                            <div class="inputs">
                              <input type="number" name="ladoQuad" placeholder="Lado" required>
                              <button type="submit" name="calcQuadrado">Calcular</button>
                            </div>
                          </form>
    <div class="resultado">
                           <?= ($areaQuadrado !== "") ? "Área: " . $areaQuadrado . " m²" : "" ?>
    </div>
  </div>


<!--retangulo-->
  <div class="box" id="retangulo">
    <div class="retangulo"></div>
    <div class="titulo">Retângulo</div>
                          <form method="POST" action="#retangulo">
                            <div class="inputs">
                              <input type="number" name="baseRet" placeholder="Base" required>
                              <input type="number" name="alturaRet" placeholder="Altura" required>
                              <button type="submit" name="calcRetangulo">Calcular</button>
                            </div>
                          </form>
    <div class="resultado">
                           <?= ($areaRetangulo !== "") ? "Área: " . $areaRetangulo . " m²" : "" ?>
    </div>
  </div>


<!--circulo-->
  <div class="box" id="circulo">
    <div class="circulo"></div>
    <div class="titulo">Círculo</div>
                          <form method="POST" action="#circuleirito">
                            <div class="inputs">
                              <input type="number" name="raioCirc" placeholder="Raio" required>
                              <button type="submit" name="calcCirculo">Calcular</button>
                            </div>
                          </form>
    <div class="resultado">
                          <?= ($areaCirculo !== "") ? "Área: " . $areaCirculo . " m²" : "" ?>
    </div>
  </div>


<!--trapezio-->
  <div class="box" id="trapezio">
    <div class="trapezio"></div>
    <div class="titulo">Trapézio</div>
                              <div class="inputs">
                                <input type="number" name="baseMaior" placeholder="Base Maior" required>
                                <input type="number" name="baseMenor" placeholder="Base Menor" required>
                                <input type="number" name="alturaTrap" placeholder="Altura" required>
                                <button type="submit" name="calcTrapezio">Calcular</button>
                              </div>

    <div class="resultado">
                              <?= ($areaTrapezio !== "") ? "Área: " . $areaTrapezio . " m²" : "" ?>
    </div>
  </div>


<!--losango-->
  <div class="box" id="losango">
    <div class="losangulo"></div>
    <div class="titulo">Losango</div>
                              <form method="POST" action="#losango">
                                <div class="inputs">
                                  <input type="number" name="diagMaior" placeholder="Diagonal Maior" required>
                                  <input type="number" name="diagMenor" placeholder="Diagonal Menor" required>
                                  <button type="submit" name="calcLosango">Calcular</button>
                                </div>
                              </form>
    <div class="resultado">
                                <?= ($areaLosango !== "") ? "Área: " . $areaLosango . " m²" : "" ?>
    </div>
  </div>
</div>
</body>
</html>