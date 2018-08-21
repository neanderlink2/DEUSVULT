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

Player 1 - Azul:

Movimentação - Setas >>> Está definido em Input -> HorizontalP1 e VerticalP1
Interagir - ENTER >>> Este é um campo dentro da classe Personagem, é facilmente trocado.


Player 2 - Verde:

Movimentação - WASD >>> Está definido em Input -> HorizontalP2 e VerticalP2
Interagir - F >>> Este é um campo dentro da classe Personagem, é facilmente trocado.


Player 3 - Amarelo:

Movimentação - IJKL >>> Está definido em Input -> HorizontalP3 e VerticalP3.
Interagir - P >>> Este é um campo dentro da classe Personagem, é facilmente trocado.


---------Mecânica-------


O cenário que o personagem Verde se encontra é a área de conserto de armaduras e armas.
As encomendas chegarão no Balcão (cubo cinza) a cada 15 segundos.
O Jogador deve pegar uma encomenda e levá-la à fornalha para deixá-la maleável (apertar uma vez o botão de interação deixará a encomenda na fornalha).
Após, deve consertar a armadura com um martelo (segurar o botão de interação fará isto) e deixá-la nova em folha.
Por fim, a encomenda pronta deve ser levada ao carrinho que levará para o campo de batalha.


