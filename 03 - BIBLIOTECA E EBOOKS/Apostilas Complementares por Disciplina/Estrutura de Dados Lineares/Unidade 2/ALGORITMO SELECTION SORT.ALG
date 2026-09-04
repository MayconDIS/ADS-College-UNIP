Algoritmo "SELECTION SORT"
// Disciplina   : [Estrutura de Dados Lineares]
// Professor   : Luciano Rossi
// Descrição   : Ordenação
// Autor(a)    : Maycon Douglas Inácio Silva
// Data atual  : 23/04/2024

Var
// Seção de Declarações das variáveis
    i, j, tamanho, min, temp: Inteiro
    V: Vetor[0..5] de Inteiro

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc...
    tamanho <- 5
    V[1] <- 5
    V[2] <- 4
    V[3] <- 3
    V[4] <- 2
    V[5] <- 1

    para i <- 1 ate tamanho - 1 faca
         min <- i
         para j <- i + 1 ate tamanho faca
            se V[j] < V[min] entao
              min <- j
            fimse
            temp <- V[i]
            V[i] <- V[min]
            V[min] <- temp
         fimpara
    fimpara

    // Exibir o vetor ordenado
    para i <- 1 ate tamanho faca
        escreva(V[i], " ")
    fimpara

Fimalgoritmo
