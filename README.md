# Challenges Dio Avanade C#

Code Challenges. Coding The Future Avanade - Dio  . Net

## Challenge 1
Descrição

Uma nova feature para um sistema bancário foi analisada pela equipe de desenvolvimento e será uma das tarefas a serem trabalhadas durante a sprint, como desenvolvedor da empresa você recebeu os requisitos para a nova implementação que consiste em uma solução algorítmica que permita aos clientes realizarem saques em caixas eletrônicos. No entanto, existem algumas regras a serem seguidas para garantir que um saque possa ser realizado com sucesso.

Regras do saque:

Cada cliente digitará o valor do seu saldoTotal de sua conta bancária e o valorSaque.
Um saque só pode ser realizado se o saldoDisponível na conta for igual ou superior ao valor solicitado.
Se o saldo for suficiente, o valor solicitado deve ser subtraído do saldo disponível, indicando que o saque foi realizado.

[👩‍💻resolution 1 ](https://github.com/nadiduno/ChallengesDioAvanadeC-/blob/main/conditionally.cs)

## Challenge 2

Em um jogo de RPG, os personagens geralmente possuem uma lista de itens que podem ser utilizados durante o jogo. Esses itens podem ser armas, armaduras, poções de cura, entre outros. É importante que o jogador tenha um controle desses itens para poder utilizá-los no momento adequado.

Crie um programa que permita cadastrar uma lista de itens que o personagem possui. A lista deve conter o valor fixo de 3 itens e deve ser exibida na tela.
Entrada

O programa deve solicitar ao usuário o nome dos 3 itens que o personagem possui. Cada item deve ser cadastrado separadamente.
Saída

Após receber os itens cadastrados pelo usuário, o programa deve exibir na tela a lista de itens que o personagem possui. A saída deve ter o seguinte formato:

Lista de itens:
- [item1]
- [item2]
- [item3]

[👩‍💻resolution 2 ](https://github.com/nadiduno/ChallengesDioAvanadeC-/blob/main/gameRPG.cs)


## Challenge 3

Em jogos de RPG, é comum haver ações de ataque dos personagens, que causam um certo dano ao inimigo. Este dano pode ser calculado de diferentes formas, dependendo do sistema do jogo. Neste desafio, você deve criar uma função que calcula o dano de um ataque, levando em consideração o valor do ataque e a defesa do inimigo.

Crie uma função chamada "calcular_dano" que recebe dois parâmetros: "ataque" e "defesa". A função deve retornar o valor do dano causado pelo ataque, utilizando a seguinte fórmula:

    dano = ataque - defesa


Se o valor do dano for negativo, ele deve ser considerado zero.
Entrada:
[👩‍💻resolution 3 ](https://github.com/nadiduno/ChallengesDioAvanadeC-/blob/main/joRPGAtaque.cs)

## Challenge 4

Em jogos de RPG, os personagens possuem atributos que determinam suas habilidades em diferentes áreas, como força, agilidade, inteligência, etc. Neste desafio, você deve criar uma função que verifica se o valor de um determinado atributo está dentro de um intervalo aceitável.

Crie uma função chamada "verificar_atributo" que recebe três parâmetros: "atributo", "valor_minimo" e "valor_maximo". A função deve verificar se o valor do atributo está dentro do intervalo definido pelos valores mínimo e máximo.
Caso o valor esteja dentro do intervalo, a função deve retornar true. Caso contrário, deve retornar false.


[👩‍💻resolution 4 ](https://github.com/nadiduno/ChallengesDioAvanadeC-/blob/main/jogoRPGAtributos.cs)
