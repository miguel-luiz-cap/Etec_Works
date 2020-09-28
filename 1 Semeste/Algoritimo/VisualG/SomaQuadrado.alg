Algoritmo "SomaQuadrado"
// Descrição   : Soma do quadrado e exibe os valores ou a metade do total
// Autor(a)    : Miguel Luiz
// Data atual  : 24/08/2020
Var
quadrado_a : real
quadrado_b : real
soma_quadrado : real

Inicio
escreva("Digite o 1º Número: ")
leia(quadrado_a)

escreva("Digite o 2º Número: ")
leia(quadrado_b)

soma_quadrado <- (quadrado_a^2) + (quadrado_b^2)

escreval("Total Final: ", soma_quadrado)

se(soma_quadrado >= 20) entao
     escreval("Valor 1:", (quadrado_a^2), " | Valor 2:", (quadrado_b^2))
senao
     escreval("Metade: ", (soma_quadrado/2))
fimse

Fimalgoritmo
