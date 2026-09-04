Algoritmo "Exemplo1"

var n1, n2: real

procedimento somar
var
s: real
inicio
s <- n1 + n2
escreval ("soma = " ,s)
fimprocedimento

procedimento subtrair
var
sb: real
inicio
sb <- n1 - n2
escreval ("subtrair = " ,sb)
fimprocedimento

procedimento multiplicar
var
m: real
inicio
m <- n1 *n2
escreval ("multiplicar = " ,m)
fimprocedimento

procedimento dividir
var
d: real
inicio
se (n2 = 0) entao
   escreval ("Impossivel dividir por zero")

senao
     d <- n1 / n2
     escreval ("divisão = " ,d)
   fimse
fimprocedimento

// Inicio do programa principal
inicio
      escreval ("Digite o primeiro numero ")
      leia (n1)
      escreval ("Digite o segundo numero ")
      leia (n2)
      somar
      subtrair
      multiplicar
      dividir
fimalgoritmo


