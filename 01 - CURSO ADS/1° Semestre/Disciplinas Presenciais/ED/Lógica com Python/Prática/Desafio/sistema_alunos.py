# cadastro_alunos.py

def cadastrar_alunos():
    caminho_arquivo = "C:\\Users\\flavi\\Desktop\\Python\\dados.txt"

    try:
        qtd = int(input("Quantos alunos deseja cadastrar? "))
        with open(caminho_arquivo, "w", encoding="utf-8") as arquivo:
            for i in range(qtd):
                print(f"\n--- Aluno {i+1} ---")
                nome = input("Nome: ")
                np1 = float(input("Nota NP1: "))
                np2 = float(input("Nota NP2: "))
                pim = float(input("Nota PIM: "))

                linha = f"{nome},{np1:.2f},{np2:.2f},{pim:.2f}\n"
                arquivo.write(linha)

        print(f"\nArquivo salvo com sucesso em: {caminho_arquivo}")

    except Exception as e:
        print(f"Erro ao cadastrar alunos: {e}")

if __name__ == "__main__":
    cadastrar_alunos()
