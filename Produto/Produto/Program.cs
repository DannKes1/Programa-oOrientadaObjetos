/* Crie uma classe Produto que possui os seguintes atributos: Código do produto,
descrição (o nome do produto), unidade (LT, CX, KG, UN, MT), preço,
quantidade em estoque.

a) O preço de um produto só pode ser valores maiores de zero;
b) O tipo de unidade do produto deve estar dentro das opções listadas;
Obs.A verificação do preço e do tipo de unidade deve ser implementada na
classe Produto */

using System.ComponentModel;

List<Produto> ListaProdutos = new List<Produto>();

bool loop = true;
while (loop)
{
    Console.WriteLine("Digite 1 para cadastrar\nDigite 2 para listar todos\nDigite 3 para apagar um produto\nDigite 4 para sair da lista");
    int opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        // cadastrar produtos
        case 1:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Lista de produtos");
            Console.ResetColor();
            Console.WriteLine("");

            Console.WriteLine("Digite a descrição (NOME) do produto: ");
            string descricao = Console.ReadLine();
            Console.WriteLine("Digite a Unidade do produto (LT, CX, KG, UN, MT) : ");
            string unidade = Console.ReadLine();
            Console.WriteLine("Digite o preço do produto R$: ");
            double preco = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a quantidade disponivel em estoque");
            int estoque = Convert.ToInt32(Console.ReadLine());

            Produto produto1 = new Produto(descricao, unidade, preco, estoque);
            ListaProdutos.Add(produto1);
            break;

            // listar lista 
        case 2:

            Console.Clear();
            Console.WriteLine("Os elementos da lista são: ");
            foreach (Produto itens in ListaProdutos)
            {
                Console.WriteLine("");
                Console.WriteLine($"O código do protuto é: {itens.GetCodigo()}");
                Console.WriteLine($"O nome do produto é: {itens.GetDescricao()}");
                Console.WriteLine($"O tipo do item cadastrado é: {itens.GetUnidade()}");
                Console.WriteLine($"O preço do item é R$:{itens.GetPreco()}");
                Console.WriteLine($"A quantidade de itens no estoque é {itens.GetQtdEstoque()}");

            }
            break;
            // excluir item da lista


        case 3:

            Console.WriteLine("Digite o ID para excluir ");
            int cod = Convert.ToInt32(Console.ReadLine());

            Produto excluir = ListaProdutos.FirstOrDefault(x => x.GetCodigo() == cod);
            ListaProdutos.Remove(excluir);

            break;
            case 4:
            Console.WriteLine("Você saiu da aplicação");
            loop = false;   
            break;
    }
 }

