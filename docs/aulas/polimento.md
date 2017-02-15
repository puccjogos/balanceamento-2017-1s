# Polimento 

## Definição

> Criar pistas artificiais (*não-simuladas*) sobre as propriedades físicas de objetos através da interação. (...) Ele dá as pistas visuais, aurais e táteis que o jogador precisa para criar um modelo mental detalhado e expansivo da física de objetos virtuais. Polimento "vende" a interação, de certa forma. (Swink, p. 151)

Nessa criação de um mundo material é que está grande parte do impacto que um jogo tem em fascinar e convidar jogadores a explorá-los. É um fenômeno totalmente relacionado com a **percepção** do jogador, e não as propriedades objetivas do que está sendo mostrado no jogo. Existe uma relação com as propriedades, mas o que importa é a *gestalt*, a impressão, daquilo com o que se interage.

![a sensação de coisas cotidianas](https://dl.dropboxusercontent.com/u/18325132/IMGS/PUC/swink-feel-everyday-things.jpg)

### Exemplos

![hets, por ditto](https://img.itch.io/aW1hZ2UvOTc1OC80MDM3My5naWY=/original/bcvJZh.gif)

![DAGDROM, por ditto](https://i.imgur.com/q3uiJeQ.gif)

![outline, por daniel linssen](https://i.imgur.com/fS951IV.gif)

## Técnicas e métodos

### Animação (tweening/easing)

A animação, ou seja, as mudanças visuais no objeto ao longo do tempo, é fundamental para explicar ao jogador, de forma intuitiva, a sua materialidade. O objeto animado é entendido pelo jogador como sendo da forma que sua animação é, independentemente de sua simulação.

![stretch & squash](https://dl.dropboxusercontent.com/u/18325132/IMGS/PUC/stretch-squash.jpg)

Uma forma rápida e simples de criar animações é chamada de **tweening**. Numa explicação simples, tweening é a interpolação entre dois valores ao longo de tempo. Diferentes fórmulas controlam esses valores intermediários

![diferentes fórmulas de tweening](https://dl.dropboxusercontent.com/u/18325132/IMGS/PUC/tweening.jpg)

Uma ótima referência visual (e em português) para as diferentes funções de tweening é o site [easings.net](http://easings.net/pt-br). Praticamente todas as linguagens de programação tem suporte a algum tipo de biblioteca de tweening. Na Unity, temos várias, como [GoKit](https://github.com/prime31/GoKit) (focada em código) e [iTween](https://www.assetstore.unity3d.com/en/#!/content/84) (com editor visual).

<iframe width="640" height="480" src="https://www.youtube.com/embed/Fy0aCDmgnxg" frameborder="0" allowfullscreen></iframe>

### Efeitos visuais

Swink separa animação de efeitos visuais pensando em como efeitos visuais são usados brevemente para mostrar a interação de dois objetos ou os resultados de um processo. Exemplos seriam faíscas ou fumaça. Pensando na expressividade de efeitos visuais, temos que lembrar que o que importa é o quanto eles contribuem para a linguagem do jogo em questão. Fumaça realista num jogo cartunizado não faz sentido, assim como estrelas douradas não encaixam muito num jogo medieval sombrio.

Outro ponto importante é o quanto o movimento das partículas ou efeitos visuais e como se desenrolam no tempo são fundamentais para comunicar sua natureza, seguindo os princípios de animação discutidos anteriormente.

![planetarium, por daniel linssen](https://i.imgur.com/AD1iNWm.gif)

Outro tipo importante de efeito visual são os **efeitos cinemáticos**, que envolvem o controle da câmera e manipulações extra-diegéticas da imagem do jogo. Coisas como screenshake, mudanças de ângulo, mudanças de zoom, etc.

![efeito cinemático](https://dl.dropboxusercontent.com/u/18325132/IMGS/PUC/bum-ground02.gif)

<iframe width="854" height="480" src="https://www.youtube.com/embed/AJdEqssNZ-U" frameborder="0" allowfullscreen></iframe>

### Efeitos sonoros

O uso de efeitos sonoros é essencial para comunicar a relação entre objetos. Como podemos disparar sons no momento de interação entre dois objetos, podemos comunicar diretamente como essa interação soa. Nós percebemos os sons dessa interação através de um complexo sistema de interpretação, o qual está especialmente treinado para entender a materialidade das coisas através do som. 

## Referências

SWINK, S. **Game Feel: A Game Designer’s Guide to Virtual Sensation.** 1 ed. Amsterdam ; Boston: CRC Press, 2008.
