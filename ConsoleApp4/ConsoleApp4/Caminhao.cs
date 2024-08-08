
    public class Caminhao : Veiculo
    {
    public Caminhao (int quantidadeEixo, int TipoEixo)
        : base (quantidadeEixo, TipoEixo)
    {

    }

    public override void CalcularPedagio()
    {
        precoPedagio = qtdEixos * 7.00;
        precoPedagio = precoPedagio + (precoPedagio * 0.10);
    }
}

