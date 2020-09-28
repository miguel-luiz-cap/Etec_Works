Algoritmo "VerificarIdade"
// Descrição   : Mostrar o seu nome e se você é de maior ou não de idade
// Autor(a)    : Miguel Luiz
// Data atual  : 24/08/2020
Var
nome : caracter     // Nome do Boy
idade : inteiro      // Idade do Boy

Inicio

escreva("Digite seu nome: ")
leia(nome)

escreva("Digite sua idade: ")
leia(idade)

escreval("Seu nome: ", nome, " | Sua Idade: ", idade)

se(idade>=18)entao
     escreval("Voce é maior de idade")
senao
     escreval("Voce é menor de idade")
fimse

Fimalgoritmo
