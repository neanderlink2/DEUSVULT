Os objetos interáveis estarão de maneira genérica, ou seja, haverá, por exemplo, um fogão e uma fornalha com a mesma funcionalidade, deixar algo por um tempo para que esteja pronto.

Eu dividi por enquanto em três estados do objeto cada um:

-Inicial: Estado inicial do objeto, saído direto de sua fonte.
-EmManipulacao: Estado em que o objeto começou a ser manipulado. O jogador poderá ver esse estado apenas caso tenha o colocado para manipulação.
-Pronto: Estado final em que o objeto está pronto para ser entregue.

Esses estados estão descritos com a enumeração EstadoObjeto.



Existem três tipos de objetos interáveis:

-Fonte: Aonde o jogador poderá retirar objetos em estado inicial.
-Manipulador: Local em que o jogador deixará o objeto para ser manipulado até o estado Pronto.
-Receptor: Receberá o objeto pronto.

