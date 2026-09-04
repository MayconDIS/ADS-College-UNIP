import re

path = r'C:\Users\mayco\Documents\GitHub\PIM_III-Parte_Teorica\index.html'

with open(path, 'r', encoding='utf-8') as f:
    html = f.read()

# 1. Update Persona
old_persona = """        <p class="paragrafo">Para guiar as decisões de usabilidade e arquitetura de informação, foi modelada a <strong>Persona</strong> principal do sistema, refletindo com exatidão o público-alvo da plataforma:</p>
        <ul style="margin-left: 1cm; margin-bottom: 0.5cm; font-size: 11pt;">
            <li><strong>Persona Principal:</strong> Jovem de 18 a 20 anos, com o ensino médio recém-concluído.</li>
            <li><strong>Perfil e Dores:</strong> Possui grande interesse em ingressar na área de tecnologia, mas enfrenta insegurança diante da enorme quantidade de jargões técnicos e da complexidade inicial das disciplinas abordadas nos cursos superiores de TI.</li>
            <li><strong>A Jornada na Nex_TI:</strong> Utiliza a plataforma como ferramenta de nivelamento. Através de flashcards de nível introdutório e repetição espaçada, familiariza-se gradativamente com os fundamentos da área. A gamificação (XP e moedas) reduz a frustração comum no aprendizado inicial, mantendo o engajamento diário.</li>
        </ul>"""

new_persona = """        <p class="paragrafo">Para guiar as decisões de usabilidade e arquitetura de informação, foi modelada a <strong>Persona</strong> principal do sistema, baseada na atividade acadêmica proposta:</p>
        <ul style="margin-left: 1cm; margin-bottom: 0.5cm; font-size: 11pt;">
            <li><strong>Persona Principal:</strong> Victor, 23 anos, recém-formado na área de Análise e Desenvolvimento de Sistemas (ADS).</li>
            <li><strong>Perfil e Dores:</strong> É um jovem focado e analítico, com facilidade em tecnologia e domínio básico a intermediário de HTML e CSS. Busca conhecimento e aperfeiçoamento prático, especialmente em back-end (Python), aplicando seus conhecimentos teóricos em projetos reais.</li>
            <li><strong>A Jornada na Nex_TI:</strong> Victor está em casa realizando um projeto onde precisa fazer a parte de back-end em Python. Através da nossa plataforma, ele conseguiu aprimorar seu nível de aprendizado concluindo as etapas e os desafios interativos, conseguindo assim finalizar com excelência sua parte no projeto.</li>
        </ul>"""

html = html.replace(old_persona, new_persona)

# 2. Add Conceptual Diagram to Section 2.3
# Find where to inject: after "lgpd.</p>" in line 215, which is before "Dicionário de Dados Resumido"
old_db_start = """garantindo integridade referencial e segurança conforme os preceitos da LGPD.</p>

        <h4 style="margin-bottom: 0.5cm;">Dicionário de Dados Resumido</h4>"""

new_db_start = """garantindo integridade referencial e segurança conforme os preceitos da LGPD.</p>

        <h4 style="margin-bottom: 0.5cm;">Modelo Conceitual de Banco de Dados</h4>
        <p class="paragrafo">A avaliação do projeto de banco de dados inicia-se pelo modelo conceitual, uma representação abstrata das entidades, atributos e relacionamentos do sistema (Figura 3).</p>
        <div class="diagrama-container" style="margin-top: 0.5cm; margin-bottom: 1cm;">
            <p class="legenda-topo">Figura 3 – Modelo Conceitual do Sistema</p>
            <img src="assets/diagrams/Pesquisa relacionada a Banco de Dados.jpeg" alt="Modelo Conceitual" class="diagrama-img" style="max-height: 12cm;">
            <p class="legenda-fonte">Fonte: Autores, 2026.</p>
        </div>

        <h4 style="margin-bottom: 0.5cm;">Dicionário de Dados Resumido</h4>"""

html = html.replace(old_db_start, new_db_start)

# 3. Add 10 prototype images to Section 2.6
# I will append them at the end of section 2.6 (just before <section class="page" aria-label="Acessibilidade e ML">)

old_ux_end = """<p class="legenda-fonte">Fonte: Autores, 2026.</p>
        </div>
    </section>

    <section class="page" aria-label="Acessibilidade e ML">"""

new_ux_end = """<p class="legenda-fonte">Fonte: Autores, 2026.</p>
        </div>

        <h4 style="margin-top: 1cm; margin-bottom: 0.5cm;">Protótipo Interativo em Alta Fidelidade</h4>
        <p class="paragrafo">As telas abaixo demonstram o fluxo de interação completo do aplicativo, desde a tela inicial, navegação, questionários e perfis, baseando-se no design mobile first e gamificado.</p>
        <div style="display: grid; grid-template-columns: 1fr 1fr; gap: 10px; margin-top: 1cm;">
            <img src="assets/prototypes/proto_1.jpeg" style="width:100%; border-radius: 8px;" alt="Protótipo Interativo 1">
            <img src="assets/prototypes/proto_2.jpeg" style="width:100%; border-radius: 8px;" alt="Protótipo Interativo 2">
            <img src="assets/prototypes/proto_3.jpeg" style="width:100%; border-radius: 8px;" alt="Protótipo Interativo 3">
            <img src="assets/prototypes/proto_4.jpeg" style="width:100%; border-radius: 8px;" alt="Protótipo Interativo 4">
            <img src="assets/prototypes/proto_5.jpeg" style="width:100%; border-radius: 8px;" alt="Protótipo Interativo 5">
            <img src="assets/prototypes/proto_6.jpeg" style="width:100%; border-radius: 8px;" alt="Protótipo Interativo 6">
            <img src="assets/prototypes/proto_7.jpeg" style="width:100%; border-radius: 8px;" alt="Protótipo Interativo 7">
            <img src="assets/prototypes/proto_8.jpeg" style="width:100%; border-radius: 8px;" alt="Protótipo Interativo 8">
            <img src="assets/prototypes/proto_9.jpeg" style="width:100%; border-radius: 8px;" alt="Protótipo Interativo 9">
            <img src="assets/prototypes/proto_10.jpeg" style="width:100%; border-radius: 8px;" alt="Protótipo Interativo 10">
        </div>
    </section>

    <section class="page" aria-label="Acessibilidade e ML">"""

html = html.replace(old_ux_end, new_ux_end)

# 4. Renumber all Figures from 3 onwards.
# Since we added one new Figura 3, we must increment all existing figures starting from 3 up to 15.
# We go in reverse so we don't accidentally replace already incremented numbers.
for i in range(15, 2, -1):
    html = html.replace(f"Figura {i}", f"Figura {i+1}")

# Fix the one we just added (it was added as Figura 3, but the replace loop would have made it Figura 4)
# Let's just fix it manually since we can do regex
html = re.sub(r'Figura 4 – Modelo Conceitual do Sistema', 'Figura 3 – Modelo Conceitual do Sistema', html)

with open(path, 'w', encoding='utf-8') as f:
    f.write(html)

print("Updated index.html successfully.")
