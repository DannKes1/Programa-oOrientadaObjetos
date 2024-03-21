
/*Crie uma classe Produto que possui os seguintes atributos: Código do produto,
descrição (o nome do produto), unidade (LT, CX, KG, UN, MT), preço,
quantidade em estoque.

a) O preço de um produto só pode ser valores maiores de zero;
b) O tipo de unidade do produto deve estar dentro das opções listadas;
Obs.A verificação do preço e do tipo de unidade deve ser implementada na
classe Produto*/


    internal class Produto
    {
    private int Codigo;
    private string Descricao;
    private string Unidade;
    private double Preco;
    private int QtdEstoque;


    public Produto()
    {
        Random random = new Random();
        this.Codigo = random.Next(1,100);
    }
    public Produto(string descricao, string unidade, double preco, int qtdestoque)
    {
        this.Descricao = descricao;
        this.Unidade = unidade;
        this.Preco = preco;
        this.QtdEstoque = qtdestoque;

    }

    public void SetQtdEstoque(int qtdestoque)
    {
        this.QtdEstoque = qtdestoque;
    }
    public int GetQtdEstoque()
    {
        return this.QtdEstoque;
    }

    public int GetCodigo() 
    { 
        return this.Codigo; 
    } 

    public void SetDescricao(string descricao)
    {
        this.Descricao = descricao; 
    }
    public string GetDescricao()
    {
        return this.Descricao;
    }


    public void SetPreco(double preco)
    {
        if(preco > 0)
        {
           this.Preco = preco;

        }else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("O valor do produto não pode ser menor que zero");
            Console.ResetColor();
            
        }
    }
    public double GetPreco()
    {
        return this.Preco;
    }

    public void SetUnidade (string unidade)
    {
        if (unidade == "lt" || unidade == "cx" || unidade == "kg" || unidade == "mt" || unidade == "un")
        {
            this.Unidade = unidade.ToUpper();
        }
        else
        {
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine("Sinto muito, não temos essa unidade em estoque");
            Console.ResetColor();
        }
    }
    public string GetUnidade()
    {
        return this.Unidade;
    }

 
}

    

