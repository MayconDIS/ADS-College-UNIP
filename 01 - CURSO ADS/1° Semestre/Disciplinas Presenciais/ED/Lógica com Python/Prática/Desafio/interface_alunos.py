# interface_alunos.py

import tkinter as tk

# Caminho para o arquivo
caminho_arquivo = "C:\\Users\\flavi\\Desktop\\Python\\dados.txt"

def calcular_media(np1, np2, pim):
    return ((np1 * 4) + (np2 * 4) + (pim * 2)) / 10

def exibir_dados():
    try:
        with open(caminho_arquivo, "r", encoding="utf-8") as f:
            linhas = f.readlines()

        texto_resultado = ""
        for linha in linhas:
            partes = linha.strip().split(",")
            nome = partes[0]
            np1 = float(partes[1])
            np2 = float(partes[2])
            pim = float(partes[3])

            media = calcular_media(np1, np2, pim)
            status = "✅ Aprovado" if media >= 7 else "❌ Reprovado"

            texto_resultado += f"{nome} | NP1: {np1:.1f} | NP2: {np2:.1f} | PIM: {pim:.1f} | Média: {media:.1f} -> {status}\n"

        resultado.config(text=texto_resultado)

    except FileNotFoundError:
        resultado.config(text="Arquivo de dados não encontrado.")
    except Exception as e:
        resultado.config(text=f"Erro: {e}")

# Interface
janela = tk.Tk()
janela.title("Resultados dos Alunos")
janela.geometry("600x400")

botao = tk.Button(janela, text="Exibir Dados dos Alunos", command=exibir_dados)
botao.pack(pady=20)

resultado = tk.Label(janela, text="", justify="left", font=("Courier New", 10))
resultado.pack(pady=10)

janela.mainloop()
