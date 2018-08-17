-----Mecanismos-----


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

Existem quatro classes para esses objetos interáveis, sendo que a classe 'Interavel' é designada apenas para ser pai de todos.
A classe Fonte, Manipulador e Receptor são especificações de Interavel, mas serão usadas como base para criar classes específicas de cada momento.



Também foi criada uma classe Personagem, que contará com todas as ações padrões de personagens. Ele deverá ser especificado de acordo com cada personagem e sua particularidade.

-----Jogabilidade------

Estão sujeitos a alterações a qualquer momento, mas por enquanto:

Movimentação - WASD ou Setas. >>> Backlog - Adicionar na parte de INPUT configurações diferentes para cada um dos jogadores.
Interagir - F >>> Este é um campo dentro da classe Personagem, é facilmente arrumado.