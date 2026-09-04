Algoritmo "INSERTION SORT"
// Disciplina   : [Estrutura de Dados Lineares]
// Professor   : Luciano Rossi
// Descrição   : Ordenação
// Autor(a)    : Maycon Douglas Inácio Silva
// Data atual  : 23/04/2024

Var
// Seção de Declarações das variáveis
    i, j, tamanho, chave: Inteiro
    V: Vetor[0..5] de Inteiro

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc...
    tamanho <- 5
    V[5] <- 1
    V[1] <- 2
    V[3] <- 3
    V[2] <- 4
    V[4] <- 5

    para j <- 2 ate tamanho faca
         chave <- V[j]
         i <- j - 1
         enquanto i >= 1 faca
            se V[i] > chave entao
                V[i + 1] <- V[i]
                i <- i - 1
            senao
                interrompa // Sair do loop se a condição não for atendida
            fimse
        fimenquanto
        V[i + 1] <- chave
    fimpara

    // Exibir o vetor ordenado
    para i <- 1 ate tamanho faca
        escreva(V[i], " ")
    fimpara

Fimalgoritmo
