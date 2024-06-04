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

## Challenge 5

Você está trabalhando para uma empresa que utiliza extensivamente os serviços da AWS, e após algumas análises a equipe de segurança identificou que algumas senhas dos usuários no IAM são fracas e podem representar um risco à segurança dos dados da empresa. Para resolver esse problema, foi solicitado que você desenvolva um programa capaz de analisar as senhas dos usuários e fornecer uma validação de força com base em critérios predefinidos.

Requisitos de segurança para a senha:

    A senha deve ter no mínimo 8 caracteres.
    A senha deve conter pelo menos uma letra maiúscula (A-Z).
    A senha deve conter pelo menos uma letra minúscula (a-z).
    A senha deve conter pelo menos um número (0-9).
    A senha deve conter pelo menos um caractere especial, como !, @, #, $, %, etc.

Entrada

A entrada será uma única string representando a senha que precisa ser validada.
Saída

Seu programa deve retornar uma mensagem indicando se a senha fornecida pelo usuário atende aos requisitos de segurança ou não, juntamente com um feedback explicativo sobre os critérios considerados.

[👩‍💻resolution 5 ](https://github.com/nadiduno/ChallengesDioAvanadeC-/blob/main/password.cs)


## Challenge 6

Em jogos de RPG, os jogadores frequentemente adquirem itens mágicos que possuem poderes e habilidades especiais. Neste desafio, você deve criar uma classe "ItemMagico" que represente um item mágico e seja capaz de armazenar o nome, descrição e poder do item.

Crie a classe "ItemMagico" que possua os seguintes atributos: "nome", "descricao" e "poder". Além disso, a classe deve ter um método chamado "criar", que recebe como argumento os valores do nome, descrição e poder do item, respectivamente.
Entrada

A entrada será dada pela chamada do método "criar" da classe "ItemMagico", utilizando o io.read() para obter os valores dos atributos de cada item:

    nome: nome do item
    descricao: descrição do item
    poder: poder do item

Importante: a entrada deverá ocorrer de acordo com a ordem das informações fornecidas acima.
Saída

A saída deverá ser a impressão das informações do item criado, no formato:

    Nome: [nome do item]
    Descrição: [descrição do item]
    Poder: [poder]

Exemplos

A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

[👩‍💻resolution 6 ](https://github.com/nadiduno/ChallengesDioAvanadeC-/blob/main/itemmagico.cs)


## Challenge 7

Você é um inventor de robôs excêntrico e engraçado, que decidiu criar seu próprio exército de robôs para ajudá-lo em suas tarefas diárias. Para isso, você precisa desenvolver uma classe Robô que permita que cada um dos seus robôs tenha características únicas. Crie seu próprio robô personalizado, escolhendo seu nome, modelo e ano de fabricação, e veja seu exército de robôs engraçados tomar forma diante dos seus olhos!

Você precisa criar uma classe Robo que possua um construtor que inicialize a classe com as características do robô (nome, modelo e ano de fabricação). Além disso, você precisa implementar métodos para exibir as características do robô.

Escreva uma classe Robo, que possua os seguintes atributos e métodos:

    Três atributos: nome, modelo e ano de fabricação;
    Construtor: deverá inicializar a classe com o nome, modelo e ano de fabricação;
    Método chamado exibirInformações: que não receba parâmetros e exiba na tela as características do robô.

Seu programa deve solicitar ao usuário o nome, modelo e ano de fabricação do robô e criar um objeto Robo com essas informações. Em seguida, deve chamar o método exibirInformacoes para exibir as características do robô.
Entrada:

A entrada deverá receber os atributos do robô, conforme exemplo abaixo:

    nome: referente ao nome do robô (string).
    modelo: referente ao modelo do robô (string).
    ano: referente ao ano da criação do robô (int).

IMPORTANTE: A entrada deverá seguir a ordem informada acima.
Saída:

O código deverá retornar uma mensagem (string) informando o nome, modelo e ano do robô criado, de acordo com o que foi recebido como entrada. Veja como exemplo a entrada recebida abaixo:

DioBot
DIO
2020

De acordo com esses valores de entrada, a saída ficará desta maneira:

O robô DioBOT, modelo DIO, foi fabricado em 2020.


[👩‍💻resolution 7 ](https://github.com/nadiduno/ChallengesDioAvanadeC-/blob/main/robot.cs)

## Challenge 8

Nesse desafio, você deverá criar um programa que permita ao usuário escolher o valor e o naipe de uma carta de baralho, e exibir a carta escolhida.

Para isso, será necessário criar uma classe chamada Carta, que possua dois atributos: naipe e valor. Os valores de naipe e valor devem ser definidos como enumerações, para facilitar a escolha do usuário.

Como observação, os valores do enum Valor são:

    Ás = 1; Valete = 2; Dama = 3; Rei = 4.

Já os valores do enum Naipe são :

    Paus = 0; Ouros = 1; Copas = 2; Espadas = 3.

O programa deve permitir que o usuário escolha o valor e o naipe da carta, e em seguida criar uma instância da classe Carta com os valores escolhidos. Por fim, o programa deve exibir a carta escolhida, mostrando tanto o valor quanto o naipe da carta.

Requisitos:

    Utilizar a classe "Carta" que possui dois atributos: "naipe" e "valor", ambos são enums.
    Utilizar switch case para tratar exceções ao escolher o naipe e o valor da carta.
    O programa deve permitir que o usuário escolha o naipe e o valor da carta.
    O programa deve exibir a carta escolhida pelo usuário.

Entrada:

A entrada deve receber duas informações, referentes ao valor e naípe, conforme exemplo abaixo:

    valor: Enum  - representando o valor da carta;
    naipe: Enum  - representando o náipe da carta.

Saída:

O código deverá retornar uma mensagem (string) informando qual o valor da carta e seu náipe, após receber como entrada os Enums valor e naipe. Veja as entradas recebida abaixo:

3
2

De acordo com esses valores de entrada, a saída ficará desta maneira:

Carta escolhida: Dama de Copas

[👩‍💻resolution 8 ](https://github.com/nadiduno/ChallengesDioAvanadeC-/blob/main/cartaNaipe.cs)
