# Jogos e equilíbrio

> **Leitura**
>
> *Level 1: Intro to game balance* em SCHREIBER, I. Game Balance Concepts. Disponível em: <https://gamebalanceconcepts.wordpress.com/2010/07/07/level-1-intro-to-game-balance/>. Acesso em: 10 fev. 2016. 

Na aula de hoje, vamos ver algumas definições e ideias relativas ao equilíbrio de jogos, tentando encontrar conceitos mais relevantes que serão explorados em mais detalhe ao longo da disciplina. Também buscamos, com isso, estabelecer um vocabulário comum.

<iframe src="https://docs.google.com/presentation/d/1shgqjd4YvY9FIsfLvFG507iDHP9Vj1oYVVnJE7NMOGM/embed?start=false&loop=false&delayms=60000" frameborder="0" width="100%" height="400" allowfullscreen="true" mozallowfullscreen="true" webkitallowfullscreen="true"></iframe>


## Conceitos relevantes

### Determinismo

> Um jogo *determinístico* é um jogo onde se você parte de um estado do jogo e realiza uma ação específica e ela sempre irá produzir o mesmo resultado. (Schreiber)

*Esse tipo de jogo é comum? Exemplos?*

### Não-determinismo

É um jogo onde uma ação em um estado determinado pode apresentar resultados variáveis de forma aparentemente aleatória.

*Qual o impacto dessa mudança para o equilíbrio de um jogo?*

### Resolubilidade

Se um jogo é resolúvel, isso implica que ele tem *uma* ação específica que é "melhor" a cada momento e que é possível que os jogadores a descubram.

*Isso é interessante para os jogadores?*

Uma solução para um jogo pode ser **trivial** (se facilmente solúvel) ou não, apenas **teoricamente solúvel** (como no caso do xadrez). Esse úm bom critério para aplicar quando se está testando regras fundamentais de um jogo: ele é solúvel? Que tipo de resolubilidade ele apresenta?

#### Resolvendo jogos não-determinísticos

No caso de jogos determinísticos é "fácil" calcular os resultados e impactos de uma ação. Como proceder em jogos não-determinísticos? É possível resolvê-los? Schreiber acredita que sim, mas que uma solução, nesse caso, "é um conjunto de ações que maximiza a probabilidade do jogador de ganhar".

#### Resolvendo jogos intransitivos

Jogos intransitivos são, para Schreiber, aqueles em que uma escolha depende, para ser efetiva, da escolha de outro jogador. Pense no clássico *jo-ken-po* ou *pedra-papel-tesoura*. A primeira vista, esse tipo de jogo não parece ter uma solução clara, mas pode-se dizer que a sua "solução" seria usar as opções de forma igualitária, dificultando a previsão de suas ações pelo oponente.

### Simetria e assimetria

Um jogo **simétrico** apresenta condições iniciais e regras idênticas para todos os jogadores. Isso não implica, no entanto, que o jogo seja equilibrado de forma geral, pois estratégias ou elementos do jogo podem ser tão dominantes a ponto que "quebrar" a experiência dos jogadores.

*Quais as implicações da ideia de simetria para o equilíbrio de jogos? Como você abordaria o equilíbrio de cada um desses tipos de jogos?*


