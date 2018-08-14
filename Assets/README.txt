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

