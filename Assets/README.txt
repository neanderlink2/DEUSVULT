-----Mecanismos-----


Os objetos inter�veis estar�o de maneira gen�rica, ou seja, haver�, por exemplo, um fog�o e uma fornalha com a mesma funcionalidade, deixar algo por um tempo para que esteja pronto.

Eu dividi por enquanto em tr�s estados do objeto cada um:

-Inicial: Estado inicial do objeto, sa�do direto de sua fonte.
-EmManipulacao: Estado em que o objeto come�ou a ser manipulado. O jogador poder� ver esse estado apenas caso tenha o colocado para manipula��o.
-Pronto: Estado final em que o objeto est� pronto para ser entregue.

Esses estados est�o descritos com a enumera��o EstadoObjeto.



Existem tr�s tipos de objetos inter�veis:

-Fonte: Aonde o jogador poder� retirar objetos em estado inicial.
-Manipulador: Local em que o jogador deixar� o objeto para ser manipulado at� o estado Pronto.
-Receptor: Receber� o objeto pronto.

Existem quatro classes para esses objetos inter�veis, sendo que a classe 'Interavel' � designada apenas para ser pai de todos.
A classe Fonte, Manipulador e Receptor s�o especifica��es de Interavel, mas ser�o usadas como base para criar classes espec�ficas de cada momento.


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


