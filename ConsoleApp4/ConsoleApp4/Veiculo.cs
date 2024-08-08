
public abstract class Veiculo
    {
    public string placa { get; set; }
    public int qtdEixos { get; set; }
    public int tipo { get; set; }
    public double precoPedagio { get; set; }
    public double ValorFinal { get; set; }

    public Veiculo(int quantidadeEixo, int TipoEixo)
    {
        this.qtdEixos = quantidadeEixo;
        this.tipo = TipoEixo;
    }

    /*abstract vai cair na prova*/
    public abstract void CalcularPedagio();

    public virtual void CalcularDesconto()
    {

    }
    }

