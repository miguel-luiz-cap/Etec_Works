Algoritmo "VerificaIdade2"
// Descrição   : Verificar se o boy é kid, boy, adulto ou idoso
// Autor(a)    : Miguel Luiz
// Data atual  : 28/08/2020
Var
idade : inteiro

Inicio
escreva("Digite a Idade do Individuo: ")
leia(idade)

se (idade <= 11) entao
   escreva("Você é uma Criança")
senao
      se (idade <= 17) entao
         escreva("Você é um(a) Adolescente")
      senao
            se (idade <= 59) entao
                  escreva("Você é um(a) Adulto(a)")
            senao
                  escreva("Você é um(a) idoso(a)")
            fimse
      fimse
fimse

Fimalgoritmo
