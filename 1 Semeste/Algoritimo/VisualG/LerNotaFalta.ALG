Algoritmo "LeNotaFalta"
// Descrição   : Le a nota e as faltas e mostra se esta aprovado ou nao
// Autor(a)    : Miguel Luiz
// Data atual  : 24/08/2020
Var
nota : real
faltas : real

Inicio
escreva("Nota do Aluno: ")
leia(nota)

escreva("Número de Faltas: ")
leia(faltas)

se ((nota>=7) e (faltas<=3)) entao
     escreval("Aprovado")
senao
     escreval("Reprovado")
fimse

Fimalgoritmo
