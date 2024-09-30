// Criar uma variável chamada notaMedia e atribua um valor inteiro a ela. Caso seu valor seja maior ou igual a 5, escreva na tela "Nota suficiente para aprovação".

void Media() {
    // Console.Clear();
    Console.Write("Insira a nota media: ");
    string textoNotaMedia = Console.ReadLine()!;
    int notaMedia = int.Parse(textoNotaMedia);
    int mediaEsperada = 5;
    
    if(notaMedia >= mediaEsperada) {
        Console.WriteLine("Nota suficiente para aprovação \"{0}\"", notaMedia);
    } else {
        int diffDeNotas = mediaEsperada - notaMedia;
        Console.WriteLine("Nota Insuficiente, falta {0} para aprovação", diffDeNotas);
    }

}

void ExibeLinguagem(){

    // Criar uma lista de linguagens de programação, com as linguagens C#, Java e JavaScript.

    List<string> linguagens = ["C#", "Java", "Javascript"];

    // Exibir o valor "C#" no console, utilizando a lista criada no exercício anterior.

    Console.WriteLine("{0}", linguagens[0]);

    // Criar um programa que, dado a entrada de dados de um número n inteiro, a partir do teclado, exibir a n-ésima posição de uma lista.

    Console.Write("Insira um valor numérico ");
    string textoValorNumerico = Console.ReadLine()!;
    int valorNumerico = int.Parse(textoValorNumerico);

    switch(valorNumerico) {
        case 0:
        case 1:
        case 2:
            Console.WriteLine("Linguagem: {0}", linguagens[valorNumerico]);
            break;

        default:
            Console.WriteLine("Valor inesperado, sem resposta do vetor");
            break;
        
    }

}

void JogoAdivinha () {
    Random random = new Random();
    int MAX_RANGE = 100;
    int MIN_RANGE = 1;
    int MAX_TENTATIVAS = 10;
    int tentativasRestantes = MAX_TENTATIVAS;
    int numeroSortido = random.Next(MIN_RANGE, MAX_RANGE);
    List<string> pluralTentativa = ["tentativa", "tentativas"];
    List<string> pluralRestante = ["restante", "restantes"];

    Console.WriteLine("Escolha um numero de {0} a {1}, você tem {3} ao todo", MIN_RANGE, MAX_RANGE, MAX_TENTATIVAS);
    do {
        Console.Write("\n");
        Console.Write("Chances restantes {0}: ", tentativasRestantes);
        string textoDigitado = Console.ReadLine()!;
        int numeroChutado = int.Parse(textoDigitado);
        Console.WriteLine(numeroSortido);

        if (numeroChutado == numeroSortido) {       
            Console.WriteLine(
                    "Parabéns, você acertou o número {0}, com {1} {2} {3}", 
                    numeroSortido,
                    tentativasRestantes,
                    tentativasRestantes <= 1 ? pluralTentativa[0] : pluralTentativa[1],
                    tentativasRestantes <= 1 ? pluralRestante[0] : pluralRestante[1]
                );
            break;
        } else if (tentativasRestantes <= 1) {
            Console.WriteLine("Não conseguiu acertar o número\nTente novamente");
            tentativasRestantes = MAX_TENTATIVAS;
            numeroSortido = random.Next(1, 10);
        } else {
            if (numeroChutado > numeroSortido) {
                Console.WriteLine("Numero maior que o numero aleatório");
            } else if (numeroChutado < numeroSortido) {
                Console.WriteLine("Numero menor que o numero aleatório");
            }
        }
        tentativasRestantes--;
    } while (tentativasRestantes > 0);

}


void Principal () {
    Console.Clear();
    Console.WriteLine("1 - Função de média");
    Console.WriteLine("2 - Exibe Lista de linguagens");
    Console.WriteLine("3 - Jogo de Adivinhação");
    Console.Write("Escolha uma opção: ");
    string optionEscolhida = Console.ReadLine()!;
    int numOptionEscolhida = int.Parse(optionEscolhida);
    Console.Clear();

    switch (numOptionEscolhida) {
        case 1:
            Media();
            break;
        case 2:
            ExibeLinguagem();
            break;
        case 3:
            JogoAdivinha();
            break;
        default:
            Console.WriteLine("Opção invalida");
            break;
    }
}
Principal();