// Screen Sound


void ExibirBoasVindas () {
  string mensagemBoasVindas = "Sejam bem vindo ao Screen Sound";

  Console.Write("Pfv insira seu login: ");
  string login = Console.ReadLine()!;
  Console.Clear();

  Console.WriteLine(@"
    █▀ █▀▀ █▀█ █▀▀ █▀▀ █▄░█   █▀ █▀█ █░█ █▄░█ █▀▄
    ▄█ █▄▄ █▀▄ ██▄ ██▄ █░▀█   ▄█ █▄█ █▄█ █░▀█ █▄▀
  ");

  Console.WriteLine("{0} {1}", mensagemBoasVindas, login);
  Console.Write("\n");
}

void ExibirMenu () {
  
  Console.WriteLine("Escolha uma das opções abaixo para prosseguir");
  Console.WriteLine("Digite 1 para registrar");
  Console.WriteLine("Digite 2 para exibir todas");
  Console.WriteLine("Digite 3 para avaliar");
  Console.WriteLine("Digite 4 para uma media geral");
  Console.WriteLine("Digite 9 para sair");
  
  Console.Write("\nOpção escolhida: ");
  string optionEscolhida = Console.ReadLine()!; 
  int optionEscolhidaInt = int.Parse(optionEscolhida);

  switch (optionEscolhidaInt) {
    case 1:
      break;

    case 2:
      break;

    case 3:
      break;

    case 4:
      break;

    default:
      Console.WriteLine("Encerrando Exibição");
      break;
  }

}
ExibirBoasVindas();
ExibirMenu();