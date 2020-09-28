Algoritmo "VerificaLucroPreju"
// Descrição   : Verifica se o empresario teve lucro, prejuízo ou nenhum dos dois
// Autor(a)    : Miguel Luiz Capristano
// Data atual  : 30/08/2020
Var
despesas, vendas, resultado : real


Inicio
escreva("Digite o valor total de vendas: R$ ")
leia(vendas)

escreva("Digite o valor total de despesas: R$ ")
leia(despesas)

resultado <- vendas-despesas

se (resultado > 0) entao
   escreva("Você obteve lucro total de: R$", resultado)
senao
   se(resultado < 0) entao
       escreva("Você obteve prejuízo de: R$", resultado*-1.0)
   senao
       escreva("Você permanece na mesma, sem lucro ou prejuízo")
   fimse
fimse


Fimalgoritmo
