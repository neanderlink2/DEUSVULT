-----Mecanismos-----


Os objetos inter�veis estar�o de maneira gen�rica, ou seja, haver�, por exemplo, um fog�o e uma fornalha com a mesma funcionalidade, deixar algo por um tempo para que esteja pronto.

Eu dividi por enquanto em tr�s estados do objeto cada um:

-Inicial: Estado inicial do objeto, sa�do direto de sua fonte.
-EmManipulacao: Estado em que o objeto come�ou a ser manipulado. O jogador poder� ver esse estado apenas caso tenha o colocado para manipula��o.
-PreparadoParaAperfeicoar: Estado em que o objeto est� pronto para ser Aperfei�oado. Este estado � opcional e depender� do objeto usado.
-EmAperfeicoamento: Estado em que o objeto est� em processo de Aperfei�oamento. Este estado � opcional e depender� do objeto usado.
-Pronto: Estado final em que o objeto est� pronto para ser entregue.


Esses estados est�o descritos com a enumera��o EstadoObjeto.



Existem cinco tipos de objetos inter�veis:

-Fonte: Aonde o jogador poder� retirar objetos em estado inicial.
-Manipulador: Local em que o jogador deixar� o objeto para ser manipulado at� o estado Pronto.
-Aperfei�oador: Neste inter�vel o jogador poder� aperfei�oar um objeto. Para tal, ele deve 
-Armazenador: O Armazenador servir� para dois prop�sitos. Para guardar um objeto ou juntar dois objetos para formar uma combina��o. 
-Receptor: Receber� o objeto pronto.

A classe Fonte, Manipulador, Aperfei�oador, Armazenador e Receptor s�o especifica��es de Interavel, mas ser�o usadas como base para criar classes espec�ficas de cada momento, como a Fornalha por exemplo.


Tamb�m foi criada uma classe Personagem, que contar� com todas as a��es padr�es de personagens. Ele dever� ser especificado de acordo com cada personagem e sua particularidade.

-----Jogabilidade------

Est�o sujeitos a altera��es a qualquer momento, mas por enquanto:

Player 1 - Azul:

Movimenta��o - Setas >>> Est� definido em Input -> HorizontalP1 e VerticalP1
Interagir - ENTER >>> Este � um campo dentro da classe Personagem, � facilmente trocado.


Player 2 - Verde:

Movimenta��o - WASD >>> Est� definido em Input -> HorizontalP2 e VerticalP2
Interagir - F >>> Este � um campo dentro da classe Personagem, � facilmente trocado.


Player 3 - Amarelo:

Movimenta��o - IJKL >>> Est� definido em Input -> HorizontalP3 e VerticalP3.
Interagir - P >>> Este � um campo dentro da classe Personagem, � facilmente trocado.


---------Mec�nica-------


O cen�rio que o personagem Verde se encontra � a �rea de conserto de armaduras e armas.
As encomendas chegar�o no Balc�o (cubo cinza) a cada 15 segundos.
O Jogador deve pegar uma encomenda e lev�-la � fornalha para deix�-la male�vel (apertar uma vez o bot�o de intera��o deixar� a encomenda na fornalha).
Ap�s, deve consertar a armadura com um martelo (segurar o bot�o de intera��o far� isto) e deix�-la nova em folha.
Por fim, a encomenda pronta deve ser levada ao carrinho que levar� para o campo de batalha.


-------Configura��o----------

Objetos:
	Quando estiver criando objetos de itens, como Armadura, Alimentos e etc, sempre criar um Prefab com o mesmo NOME
do Objeto. Este prefab ser� procurado pelo c�digo e criar� o Prefab na "m�o" do jogador.

Combina��o:
	O jogador poder� criar combina��es dos itens. Para resolver esse problema, deve-se criar um ScriptableObject de Combinacao. Esse objeto ter� as configura��es necess�rias para criar as combina��es.
	Em outras palavras, existir� um banco de Combina��es, assim como ter� um banco de Objetos e de Prefabs de Objetos.

Pedido:

	Pedidos ser�o enviados para o jogador. A barra inferior mostrar� os pedido em andamento. 