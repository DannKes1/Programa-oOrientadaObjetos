
    public class Passeio : Veiculo  
    {

    public Passeio(int quantidadeEixo, int TipoEixo)
        : base(quantidadeEixo, TipoEixo)
    {

    }
    
  
    public override void CalcularPedagio()
    {
        precoPedagio = qtdEixos * 3.00;
    }
}

