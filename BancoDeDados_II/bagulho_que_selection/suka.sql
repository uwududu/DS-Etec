select cidade, uf, cep from cliente where cidade = 'São Paulo';
select nome_cliente, endereco, uf, cep, cidade from cliente where cidade = 'são paulo';
select * from cliente;
select * from produto;
use select_aula;

-- 1. apresente todos os dados dos clientes que pertencem ao estado de sp 	
select * from cliente where uf = 'sp';								
-- 2. mostre o codigo, o nome e a cidade dos clientes q moram no estado de rj
select codigo_cliente, nome_cliente, cidade from cliente where uf = 'rj';
-- 3. apresente todos os dados dos clientes que possuem o codigo maior que 200	
select * from cliente where codigo_cliente > 200;							
-- 4. mostre o nome, a cidade e o estado dos clientes que moram na cidade de niteroi
select nome_cliente, cidade, uf from cliente where cidade = 'niteroi';						
-- 5. apresente o codigo, o nome e o cep dos clientes que possuem cep cadastrado 10 minutos, vai	
select codigo_cliente, nome_cliente, cep from cliente where cep;		
-- 6. apresente todos os dados dos produtos cujo o valor unitario seja maior que 1 real			
select * from produto where val_unit > 1.0;
-- 7. mostre o codigo, a descricao e o valor unitario dos produtos q utilizam a unidade de medida M	
select codigo_produto, descricao, val_unit from produto where unidade = 'M';		
-- 8. apresente  todos os dados dos produtos com o codigo igual a 31	
select * from produto where codigo_produto = 31;								
-- 9. mostre a descricao e o valor unitario dos produtos cujo valor seja menor que 50 cent 	
select descricao, val_unit from produto where val_unit < 0.50;							
-- 10. apresente o codigo, a descricao e a unidade dos produtos cuja descricao seja queijo	
select codigo_produto, descricao, unidade from produto where descricao = 'queijo';				
-- 11. apresente todos os dados dos vendedores que pertencem a faixa de comissao A	
select * from vendedor where FAIXA_COMISSAO = 'a';						
-- 12. mostre o codigo, o nome e o salario dos vendedores que recebem salario maior 3k
select codigo_vendedor, nome_vendedor, salario_fixo from vendedor where salario_fixo > 3000;
-- 13. apresente todos os dados dos vendedores que possuem salario menor q 2k
select * from vendedor where salario_fixo < 2000;
-- 14. apresente o nome (VAMO iihhhhhhhhhh e decimo terceirto? decimo quarto) e a faixa de comissao dos vendedores cujo nome seje john
select nome_vendedor, faixa_comissao from vendedor where nome_vendedor = 'João';
-- 15. (sem capinha e brincadeira de criancinha) apresente o codigo, o nome e o salario do vendedor com o codigo igual a 240
select codigo_vendedor, nome_vendedor, salario_fixo from vendedor where codigo_vendedor = 240;
-- 16. apresente todos os dados dos pedidos cujo prazo da entrega  seje igual a 20 dias
select * from pedido where prazo_entrega = 20;
-- 17. mostre o numero do pedido, o codigo do cliente e o codigo do vendedor dos pedidos cujo o codigo do cliente seje 720
select num_pedido, codigo_cliente, codigo_vendedor from pedido where codigo_cliente = 720;
-- 18. apresente todos os dados dos pedidos cujo o codigo do vendedor seje 101 (OH vou dezima, decimo dezoito, repetindo)
select * from pedido where codigo_vendedor = 101;
-- 19. mostre todos os pedidos cujo o numero do pedido seje maior que 120
select * from pedido where num_pedido > 120;
-- 20. apresente o numero do pedido e o prazo de entrega dos pedidos cujo codigo do cliente seje 260
select num_pedido, prazo_entrega, codigo_cliente from pedido where codigo_cliente = 260;
-- 21. apresente todos os dados dos itens de pedido cujo quantidade seje maior que 20
select * from item_pedido where quantidade > 20;
-- 22. mostre o numero do pedido, o codigo do produto e a quantidade dos itens cujo codigo do produto seja 78
select num_pedido, codigo_produto, quantidade from item_pedido where codigo_produto = 78;
-- 23. apresente todos os dados dos itens pertencentes ao pedido numero 148
select * from item_pedido where num_pedido = 148;
-- 24. mostre todos os itens cujo quantidade seja menor q 10
select * from item_pedido where quantidade < 10;
-- 25. apresente o numero do pedido e a quantidade dos itens cujo codigo do produto seja 13
select num_pedido, quantidade from item_pedido where codigo_produto = 13;




select * from cliente;
select distinct cidade, uf from cliente;

-- exemplo: mostre todos os dados dos pedisos que foram efetuados pelo vendedor de codigo 101.
select * from pedido where codigo_vendedor = 101;

-- exemplo: encontre os nomes dos produtos cujo valor unitario esteja entre 0.50 e 2.00
select descricao from produto where val_unit >= 0.50 and val_unit <=2.00;

-- exemplo: mostre os nomes dos clientes que nasceram residem na cidade de 'Campinas' e 'São Paulo'
select nome_cliente from cliente where cidade = 'Campinas' and cidade = 'São Paulo';
select nome_cliente from cliente where cidade = 'Campinas' or cidade = 'São Paulo';
select nome_cliente, cidade from cliente where cidade in ("São Paulo", "Rio de Janeiro","Campínas");
select descricao, val_unit from produto where val_unit <> 1.00; -- pode fazer com !=

-- atividade de estudo
select nome_vendedor from vendedor where salario_fixo >= 1800.76 and salario_fixo <= 4000.23 and faixa_comissao = 'A';
select num_pedido,codigo_vendedor from pedido where codigo_vendedor != 101;
select num_pedido,codigo_produto,quantidade from item_pedido where quantidade >= 6 or quantidade = 3;


 -- mais coisas que eu ja sabia
 select 10 * 5;
 select salario_fixo * 1.1 from vendedor;
 select nome_vendedor, salario_fixo, salario_fixo * 1.1 as 'aumento' from vendedor;
 select nome_vendedor, salario_fixo, salario_fixo * 1.1 as 'reajuste', salario_fixo * 0.03 as 'bonus', salario_fixo * 1.1 + salario_fixo * 0.03 as 'total' from vendedor;
 select descricao, unidade, val_unit as 'preço atual', val_unit - (val_unit * 0.12) as 'preço com desconto' from produto where unidade = 'M';
 select * from vendedor where salario_fixo between 2000 and 3000;
 select codigo_produto, descricao, val_unit from produto where val_unit between 0.32 and 2.00;
 select nome_cliente, uf from cliente where nome_cliente like '%a';
 select nome_cliente, uf from cliente where nome_cliente like 'a__';
 select descricao from produto where descricao like 'q%';
 select nome_vendedor, faixa_comissao from vendedor where nome_vendedor like 'Jo%';
 select nome_vendedor, salario_fixo from vendedor where nome_vendedor like 'jos___';
 select nome_cliente, uf from cliente where uf in ('SP', 'MG');
 select nome_cliente, uf from cliente where uf not in ('SP', 'MG');
 select count(*) from cliente;
 select count(cep) from cliente;
 select count(*) from cliente where uf = 'MG';
 select sum(salario_fixo) as 'total de salario' from vendedor;
 select avg(salario_fixo) as 'media dos salarios' from vendedor;
 select max(salario_fixo) as 'maior salario' from vendedor;
 select min(salario_fixo) as 'menor salario' from vendedor;