# Ferramentas para equilíbrio de jogos

#### Exercício de progressão

Para a realização desse exercício, deve-se usar a [build com sequencias de fases](../materiais/Build_Progressoes.zip).

## Configurações permanentes

Uma das principais técnicas usadas para facilitar o processo de equilíbrio de jogos é permitir que as principais variáveis de controle de gameplay sejam carregadas de forma permanente, ou seja, a partir de arquivos que possam ser configurados e salvos de forma a possibilitar testes e revisões com histórico. Para isso, é muito utilizado arquivos de alguns formatos, como JSON, CSV, TSV, XML ou até mesmo TXT. Uma outra opção dentro da Unity são os chamados `ScriptableObject`s, que são classes cujas instâncias podem ser salvas como arquivos separados, guardando informações de forma permanente. Assim, diferentes versões de cada configuração podem ser armazenadas e testadas sem maiores dificuldades, talvez até podendo ser visualizadas de formas mais elaboradas.

## Analytics

Uma forma cada vez mais utilizada de validar o equilíbrio de um jogo e de conseguir novas informações é utilizar sistemas de analytics, ou seja, que registram dados sobre partidas realizadas que podem depois ser analisados, filtrados e interpretados pelos desenvolvedores. A Unity tem um sistema próprio de analytics de fácil integração, mas com limitações para usuários da versão Personal. No entanto, já permite uma quantidade de informações válidas e que podem ser bastante úteis.
