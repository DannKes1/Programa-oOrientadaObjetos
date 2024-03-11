using AviaoVoo;


   
    
        Console.Write("Digite o número do voo: ");
        int numeroVoo = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite a data do voo (formato: dd/MM/yyyy): ");
        DateTime dataVoo = DateTime.Parse(Console.ReadLine());

        Console.Write("Digite o número máximo de passageiros: ");
        int maxPassageiros = Convert.ToInt32(Console.ReadLine());

        Voo voo = new Voo(numeroVoo, dataVoo, maxPassageiros);

        while (true)
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1. Verificar a próxima cadeira livre");
            Console.WriteLine("2. Verificar se uma cadeira está ocupada");
            Console.WriteLine("3. Ocupar uma cadeira");
            Console.WriteLine("4. Verificar o número de cadeiras vagas");
            Console.WriteLine("5. Obter o número do voo");
            Console.WriteLine("6. Obter a data do voo");
            Console.WriteLine("7. Sair");
            Console.Write("Opção: ");

            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Próxima cadeira livre: " + voo.ProximoLivre());
                    break;
                case 2:
                    Console.Write("Digite o número da cadeira: ");
                    int cadeira = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("A cadeira " + cadeira + " está " + (voo.Verifica(cadeira) ? "ocupada" : "livre"));
                    break;
                case 3:
                    Console.Write("Digite o número da cadeira: ");
                    cadeira = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(voo.Ocupa(cadeira) ? "Cadeira ocupada com sucesso" : "A cadeira já está ocupada");
                    break;
                case 4:
                    Console.WriteLine("Número de cadeiras vagas: " + voo.Vagas());
                    break;
                case 5:
                    Console.WriteLine("Número do voo: " + voo.GetVoo());
                    break;
                case 6:
                    Console.WriteLine("Data do voo: " + voo.GetData().ToString("dd/MM/yyyy"));
                    break;
                case 7:
                    return;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
    

