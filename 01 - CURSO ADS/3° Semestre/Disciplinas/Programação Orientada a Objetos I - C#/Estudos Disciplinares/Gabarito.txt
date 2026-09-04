Gabarito e Justificativas - Exercícios de C# (1 a 12)

Exercício 1: D 


Justificativa: A instrução new Classel(1,1) aciona o construtor de dois parâmetros. Porém, a diretiva : this(p12, p12, p3) redireciona a execução primeiro para o construtor de três parâmetros. Ele imprime "construtor com 3 parametros: " e, ao finalizar, retorna ao escopo anterior para imprimir "construtor com 2 parametros". A tela que reflete essa ordem é a da alternativa D .
+4


Exercício 2: D 


Justificativa: O encapsulamento correto exige que atributos não tenham acesso externo direto, ou seja, devem ser private . A alteração do valor do atributo total deve ser feita exclusivamente pelo método público incrementa . A alternativa D implementa essa estrutura corretamente, permitindo o funcionamento esperado na classe Program .
+2


Exercício 3: B 
+2


Justificativa: As classes herdam e sobrescrevem/utilizam o método genérico soma, encadeando chamadas à classe base (base.soma()) . Cada classe filha incrementa um valor específico ao parâmetro recebido antes de repassá-lo para a lógica da classe mãe, acumulando as operações matemáticas. As saídas geradas para as instâncias c2, c3 e c4, passando o valor 0, resultam na sequência 2, 4 e 8.
+2


Exercício 4: B 


Justificativa: O método Main possui as instruções new Aluno(); declaradas duas vezes . Mesmo que os objetos não tenham sido atribuídos a variáveis de referência (como Aluno a = new Aluno();), a palavra reservada new garante que as instâncias sejam criadas e alocadas na memória. Portanto, o programa cria duas instâncias .
+1


Exercício 5: D 


Justificativa: A lógica estrutural deste código é idêntica à do Exercício 1 . A chamada new Classel(1,1) entra no construtor de dois parâmetros , é redirecionada pelo : this para o de três parâmetros , imprime a mensagem de 3 parâmetros e finaliza imprimindo a mensagem original de 2 parâmetros.
+4


Exercício 6: B 

Justificativa: Na orientação a objetos, você precisa criar as dependências antes de injetá-las. A alternativa B é a única que instancia corretamente os objetos Motor (m1, m2, m3) e só depois os passa como parâmetros na criação dos objetos Carro (c1, c2) . Em seguida, ela realiza as modificações de troca de motor (c2.motor = m3) e alteração de capacidade (c1.motor.capacidade = 1.2) corretamente .
+2


Exercício 7: B 


Justificativa: A instância Classel() aciona seu próprio construtor imprimindo "a". Quando Classe2("e") é instanciada , a regra de herança dita que o construtor da classe base (Classel) execute primeiro recebendo a string e imprimindo "e\n" . Após isso, o construtor da própria Classe2 executa, imprimindo a string concatenada com "\nd" .
+4


Exercício 8: A 


Justificativa: Como a classe Empresa encapsulou o atributo de contratação, o acesso direto e.contratacao.ano não é permitido. É necessário resgatar o objeto Data pelo método getter (getContratacao()) e, a partir desse retorno, utilizar o setter correspondente ao ano (setAno(2014)) para aplicar a modificação com segurança.
+1


Exercício 9: C 


Justificativa: O acesso às posições v[3] e v[4] tentam divisões por zero, gerando exceções aritméticas capturadas pelo bloco catch (ArithmeticException), que imprime "X" (seguido da execução do bloco finally padrão) . O acesso a v[6] estoura o limite do vetor (que tem tamanho 5), disparando uma IndexOutOfRangeException que é tratada no catch genérico do método Main, imprimindo "W" .
+4


Exercício 10: D 


Justificativa: O valor inicial de d1 é 3. A chamada c1.metodol() aciona chamadas encadeadas repassando this.d1 até chegar no método com dois parâmetros genéricos. Lá, o cálculo d1 *= (3 + 3) atualiza a variável para 18. Ao retornar ao escopo do método anterior, a variável sofre nova operação com o parâmetro m (valendo 3), resultando no valor final exibido no console: 54.
+4


Exercício 11: D 


Justificativa: Devido à herança (class Classel: Classe2) , instanciar Classel força a execução prévia do construtor genérico de Classe2 (imprimindo "Lugar2" ), seguido do construtor de Classel (imprimindo "Lugar1" ). A instanciação direta de Classe2  executa apenas seu próprio construtor (imprimindo "Lugar2"). A ordem exibida na tela é Lugar2, Lugar1 e Lugar2 .
+4


Exercício 12: C 


Justificativa: A variável numero é do tipo static, o que significa que seu valor é compartilhado e acumulado através de todas as instâncias da classe Teste. Cada novo construtor chamado pelas instâncias p1, p2 e p3 aciona repasses via this() que somam e multiplicam valores ao montante global . Ao final da cadeia de execuções das três instâncias, o valor persistido atinge 73.