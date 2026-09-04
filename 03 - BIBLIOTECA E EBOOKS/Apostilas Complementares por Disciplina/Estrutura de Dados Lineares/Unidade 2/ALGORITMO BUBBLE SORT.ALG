Algoritmo "BUBBLE SORT"
// Disciplina   : [Estrutura de Dados Lineares]
// Professor   : Luciano Rossi
// Descrição   : Ordenação
// Autor(a)    : Maycon Douglas Inácio Silva
// Data atual  : 23/04/2024

Var
// Seção de Declarações das variáveis
    i, j, temp, tamanho: Inteiro
    V: Vetor[0..5] de Inteiro

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc...
    tamanho <- 5
    V[1] <- 5
    V[2] <- 3
    V[3] <- 4
    V[4] <- 1
    V[5] <- 2

    para i <- 1 ate tamanho - 1 faca
        para j <- tamanho ate i + 1 passo -1 faca
            se V[j] < V[j - 1] entao
                // Trocar os elementos
                temp <- V[j]
                V[j] <- V[j - 1]
                V[j - 1] <- temp
            fimse
        fimpara
    fimpara

    // Exibir o vetor ordenado
    para i <- 1 ate tamanho faca
        escreva(V[i], " ")
    fimpara

Fimalgoritmo

