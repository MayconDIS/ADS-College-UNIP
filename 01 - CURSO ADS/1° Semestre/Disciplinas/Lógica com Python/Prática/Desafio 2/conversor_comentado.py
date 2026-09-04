import tkinter as tk                # Tkinter: cria a interface gráfica
from tkinter import ttk             # ttk: widgets com aparência moderna

# Funções de conversão
def celsius_para_fahrenheit():
    """Converte Celsius para Fahrenheit e atualiza o rótulo de resultado."""
    try:
        temperatura = float(entry_temperatura.get())
        fahrenheit = 9/5.0 * temperatura + 32
        label_resultado['text'] = f'{fahrenheit:5.2f} \u00B0F'
    except ValueError:
        label_resultado['text'] = "Digite um valor numérico válido."

def fahrenheit_para_celsius():
    """Converte Fahrenheit para Celsius e atualiza o rótulo de resultado."""
    try:
        temperatura = float(entry_temperatura.get())
        celsius = (temperatura - 32) * 5/9.0
        label_resultado['text'] = f'{celsius:5.2f} \u00B0C'
    except ValueError:
        label_resultado['text'] = "Digite um valor numérico válido."

def criar_interface():
    """Cria e organiza os elementos da interface."""
    global entry_temperatura, label_resultado  # Variáveis usadas nas funções

    # Criamos a janela principal
    janela = tk.Tk()
    janela.title("Conversor de Temperaturas")
    janela.geometry("300x250")

    # Criamos um frame (quadro) para agrupar os elementos
    quadro = ttk.Frame(janela)
    quadro.pack(expand=True, pady=10)

    # Rótulo (Label) para indicar o campo de entrada
    label_temperatura = ttk.Label(quadro, text="Temperatura:")
    label_temperatura.pack(pady=5)

    # Campo de entrada (Entry)
    entry_temperatura = ttk.Entry(quadro)
    entry_temperatura.pack(pady=5)

    # Botão 1 – Celsius → Fahrenheit
    botao_CF = ttk.Button(
        quadro,
        text="Celsius para Fahrenheit",
        command=celsius_para_fahrenheit
    )
    botao_CF.pack(pady=5)

    # Botão 2 – Fahrenheit → Celsius
    botao_FC = ttk.Button(
        quadro,
        text="Fahrenheit para Celsius",
        command=fahrenheit_para_celsius
    )
    botao_FC.pack(pady=5)

    # Rótulo de resultado
    label_resultado = ttk.Label(quadro, text="Resultado")
    label_resultado.pack(pady=10)

    # Loop principal da interface
    janela.mainloop()

# Execução do programa
criar_interface()
