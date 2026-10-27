CREATE DATABASE  IF NOT EXISTS `select_aula` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `select_aula`;

-- Table structure for table `cliente`

CREATE TABLE `cliente` (
  `CODIGO_CLIENTE` int(11) NOT NULL,
  `NOME_CLIENTE` varchar(45) DEFAULT NULL,
  `ENDERECO` varchar(45) DEFAULT NULL,
  `CIDADE` varchar(45) DEFAULT NULL,
  `CEP` varchar(20) DEFAULT NULL,
  `UF` char(2) DEFAULT NULL,
  `CNPJ` varchar(45) DEFAULT NULL,
  `IE` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`CODIGO_CLIENTE`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='		';

-- Produto

DROP TABLE IF EXISTS `produto`;

CREATE TABLE `produto` (
  `codigo_produto` int(11) NOT NULL,
  `unidade` char(3) DEFAULT NULL,
  `descricao` varchar(45) DEFAULT NULL,
  `val_unit` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`codigo_produto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;


-- Vendedor
DROP TABLE IF EXISTS `vendedor`;

 SET character_set_client = utf8mb4 ;
CREATE TABLE `vendedor` (
  `CODIGO_VENDEDOR` int(11) NOT NULL,
  `NOME_VENDEDOR` varchar(45) DEFAULT NULL,
  `SALARIO_FIXO` decimal(10,2) DEFAULT NULL,
  `FAIXA_COMISSAO` char(2) DEFAULT NULL,
  PRIMARY KEY (`CODIGO_VENDEDOR`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;



-- Pedido 
DROP TABLE IF EXISTS `pedido`;
CREATE TABLE `pedido` (
  `num_pedido` int(11) NOT NULL,
  `prazo_entrega` varchar(45) DEFAULT NULL,
  `codigo_cliente` int(11) NOT NULL,
  `codigo_vendedor` int(11) NOT NULL,
  PRIMARY KEY (`num_pedido`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

alter table pedido add CONSTRAINT `FK_CODIGO_cliente` FOREIGN KEY (`codigo_cliente`) REFERENCES `cliente` (`codigo_cliente`) ON DELETE NO ACTION ON UPDATE NO ACTION;
alter table pedido add CONSTRAINT `FK_pedido_vendedor` FOREIGN KEY (`codigo_vendedor`) REFERENCES `vendedor` (`codigo_vendedor`) ON DELETE NO ACTION ON UPDATE NO ACTION;


-- Itens pedidos

DROP TABLE IF EXISTS `item_pedido`;

CREATE TABLE `item_pedido` (
  `NUM_PEDIDO` int(11) NOT NULL,
  `CODIGO_PRODUTO` int(11) NOT NULL,
  `QUANTIDADE` int(11) DEFAULT NULL,
  KEY `CODIGO_PEDIDO_idx` (`NUM_PEDIDO`),
  KEY `CODIGO_PRODUTO_idx` (`CODIGO_PRODUTO`),
  CONSTRAINT `CODIGO_PEDIDO` FOREIGN KEY (`NUM_PEDIDO`) REFERENCES `pedido` (`num_pedido`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `CODIGO_PRODUTO` FOREIGN KEY (`CODIGO_PRODUTO`) REFERENCES `produto` (`codigo_produto`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;


-- Inserção do dados
 
INSERT INTO `cliente` VALUES (20,'Beth','Av. Climério n.45','São Paulo','25679300','SP','3248126/7326-8','9280'),(110,'Jorge','Rua Caiapo 13','Curitiba','30078500','PR','14512764/9834-9',NULL),(130,'Edmar','Rua da Praia sn','Salvador','30079300','BA','23463284/234-9','7121'),(157,'Paulo','T. Moraes c/3','Londrina',NULL,'PR','3284223/324-2','1923'),(180,'Lívio','Av. Beira Mar n. 1256','Florianópolis','30077500','SC','12736571/2347',NULL),(222,'Lúcia','Rua Itabira 123 Loja 9','Belo Horizonte','221243491','MG','28315213/9348-8','2985'),(234,'José','Quadra 3 bl. 3 sl. 1003','Brasilia','22841650','DF','21763576/1232-3','2931'),(260,'Susana','Rua Lopes Mendes 12','Niterói','30046500','RJ','21763571/232-9','2530'),(290,'Renato','Rua Meireles n. 123 bl. sl.345','São Paulo','30225900','SP','13276547/213-3','9071'),(390,'Sebastião','Rua da Igreja n.10','Uberaba','30438700','MG','32176547/213-3','9071'),(410,'Rodolfo','Largo da lapa 27 sobrado','Rio de Janeiro','30078900','RJ','12835128/2346-9','7431'),(720,'Ana','Rua 17 n. 19','Niteroi','24358310','RJ','12113231/0001-34','2134'),(830,'Maurício','Av. Paulista 1236','São Paulo','3012683','SP','32816985/7465-6','9343'),(870,'Flávio','Av. Pres. Vargas 10','São Paulo','22763931','SP','22534126/9387-9','4631');
INSERT INTO `produto` VALUES (13,'G','Ouro',6.18),(22,'M','Linho',0.11),(25,'Kg','Queijo',0.97),(30,'SAC','Açúcar',0.30),(31,'BAR','Chocolate',0.87),(45,'M','Madeira',0.25),(53,'M','Linha',1.80),(77,'M','Papel',1.05),(78,'L','Vilho',2.00),(87,'M','Cano',1.97);
INSERT INTO `vendedor` VALUES (11,'João',2780.00,'C'),(101,'João',2650.00,'C'),(111,'Carlos',2490.00,'A'),(209,'José',1800.00,'C'),(213,'Jonas',2300.00,'A'),(240,'Antônio',9500.00,'C'),(250,'Maurício',2930.00,'B'),(310,'Josias',870.00,'B'),(720,'Felipe',4600.00,'A');

ALTER TABLE `pedido` DISABLE KEYS; 
INSERT INTO `pedido` VALUES (91,'20',260,11),(97,'20',720,101),(98,'20',410,209),(101,'15',720,101),(103,'20',260,240),(104,'30',110,101),(105,'15',180,240),(108,'15',290,310),(111,'20',260,240),(119,'30',390,250),(121,'20',410,209),(127,'10',410,11),(137,'20',720,720),(138,'20',260,11),(143,'30',20,111),(148,'20',720,101),(189,'15',870,213),(203,'30',830,250);
ALTER TABLE `pedido` ENABLE KEYS;

INSERT INTO `item_pedido` VALUES (101,78,18),(101,13,5),(98,77,5),(148,45,8),(148,31,7),(148,77,3),(148,25,10),(148,78,30),(104,53,32),(203,31,6),(189,78,45),(143,31,20),(105,78,10),(111,25,10),(111,78,70),(103,53,37),(91,77,40),(138,22,10),(138,77,35),(138,53,18),(108,13,17),(119,77,40),(119,13,6),(119,22,10),(119,53,43),(137,13,8);
