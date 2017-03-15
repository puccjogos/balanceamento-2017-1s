# Técnicas para equilibrar sistemas

Nesta aula, vamos primeiro jogar e discutir os [sistemas de combate criados pelos alunos](../materiais/SistemasCombate.pdf). Depois, vamos ver algumas ferramentas e técnicas que facilitam a análise e equilíbrio de sistemas.

## Técnicas para análise

### Habilidade e sorte

Aqui estão algumas perguntas para ajudar quando se está determinando o equilíbrio entre sorte e habilidade em um jogo.

- Eu espero julgar meus jogadores por habilidade ou quero que tomem riscos?
- Habilidade tende a ser levada mais a sério que sorte: o meu jogo é mais "sério" ou mais casual?
- Existem partes do jogo entediantes? Se sim, será que elementos aleatórios as tornariam mais dinâmicas?
- Existem partes do meu jogo que estejam muito aleatórias? Se sim, trocar elementos aleatórios por habilidade ou estratégia dão mais controle aos jogadores?

### Justiça

Pense a partir do ponto de vista do jogador. Levando em conta a habilidade de cada jogador, encontre uma maneira de dar a cada jogador uma chance de ganhar que cada um considere justa.

- O meu jogo deveria ser simétrico? Por que?
- O meu jogo deveria ser assimétrico? Por que?
- O que é mais importante: que meu jogo seja uma medida confiável de quem tem mais habilidade ou que ele crie desafios interessantes para todos os jogadores?
- Se eu quero que jogadores de habilidades diferentes joguem juntos, que meios vou usar para que o jogo seja interessante e desafiador para todos?

### Decisões significativas

Quando tomamos decisões significativas, sentimos que estamos fazendo coisas que importam, que afetam nossas escolhas futuras e que mudam nossa situação no jogo.

- Que escolhas estou exigindo dos jogadores?
- Elas são significativas? Como?
- Eu estou dando aos jogadores uma quantidade correta de escolhas? Mais escolhas fariam eles se sentirem mais empoderados? Menos escolhas tornariam o jogo mais claro?
- Existem estratégias dominantes no meu jogo?
- Existem decisões óbvias ou triviais?

### Triangularidade

Dar ao jogador a escolha de jogar seguro por pouca recompensa ou se arriscar por uma grande é uma boa maneira de tornar seu jogo mais interessante e empolgante. Esse padrão é bastante recorrente em jogos e saber identificá-lo e utilizá-lo é chave.

- Existe triangularidade no meu jogo? Se não, como poderia incorporá-la?
- A triangularidade no meu jogo está equilibrada? As recompensas condizem com os riscos?

### Elegância

- Quais são os elementos do meu jogo?
- Qual é o propósito de cada elemento? Conte os usos e tente montar um ranking de elementos com mais e menos propósitos.
- Para elementos com apenas um ou dois usos, eles podem ser combinados ou removidos?
- Para elementos com muitos propósitos, é possível carregá-los com mais significado?

## Ferramentas para equilíbrio de sistemas

Enquanto as técnicas acima focam em perguntas e análise sobre o equilíbrio de forma geral, as ferramentas abaixo fornecem mais informações para a tomada de decisões de design. Para começar, uma dica é usar as [Planilhas Google](https://www.google.com/sheets/about/) como forma de compartilhar, comentar e elaborar análises numéricas e de probabilidade. É uma ferramenta flexível e poderosa.

### Valor esperado

Se temos um objeto com uma determinada propriedade que pode ser afetada por elementos probabilísticos, faz sentido pensar em seu valor em termos de **valor esperado**. De forma simplificada, o valor dessa propriedade do objeto é multiplicada pela probabilidade do objeto.

| Item | Dano | Acerto | Dano esperado |
| --- | --- | --- | --- |
| Espada | 10 | 30% | 3,3 |
| Machado | 30 | 15% | 4,5 |
| Pergaminho mágico | 90 | 8% | ? |

*Exemplo: uma espada dá 10 pontos de dano, mas só acerta ataques 30% das vezes. O seu valor esperado é de 3,3 pontos de dano. Um machado dá dano de 30 pontos, mas a chance de acertar é apenas 15%, com dano esperado de 4,5. O pergaminho é mais forte ou mais fraco que os outros itens?*

### Avaliação de prós e contras

Quanto estamos avaliando os comportamentos de um sistema, uma boa ferramenta para identificar problemas com seus objetos é atribuir valores numéricos de utilidade (positiva e negativa) para as diferentes propriedades de um objeto. Dessa forma, podemos encontrar mais facilmente quais objetos tem um impacto maior ou menor no sistema e considerar se essa distribuição condiz com o que buscamos. Essa utilidade pode ter a forma de valores que relacionam diferentes atributos, como no exemplo abaixo.

| Item | Dano | Preço | Utilidade (preço/dano) |
| --- | --- | --- | --- |
| Espada | 10 | 25 | 2,5 |
| Machado | 30 | 60 | 2 |
| Pergaminho mágico | 90 | 200 | 2,22 |

*Exemplo: A espada no exemplo acima tem um custo menor por dano que os outros itens, mesmo eles sendo mais poderosos. Em termos de custo monetário e dano, ela é uma escolha melhor, mas como se levarmos em conta a porcentagem de acertos, como que fica a análise?*

### Metades e dobros

Quando se está equilibrando quantidades numéricas, é comum que as pessoas tentem acertar números fazendo pequenas alterações. Esse método pode funcionar, mas é mais lento do que o método de alterar valores sempre em metades e dobros. Quando precisar aumentar um `valor1`, dobre-o. Se o novo resultado, `valor2` ficar muito acima do desejado, divida a diferença entre `valor2` e `valor1` pela metade para encontrar o `valor3`. Com isso você está realizando um tipo de busca binária entre os valores possíveis.
