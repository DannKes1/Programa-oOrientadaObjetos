
    public class Onibus : Veiculo
    {
    public Onibus(int quantidadeEixo, int TipoEixo)
    : base(quantidadeEixo, TipoEixo)

    {
    }



    public override void CalcularPedagio()
    {
        precoPedagio = qtdEixos * 5.00;
        precoPedagio =  precoPedagio + (precoPedagio * 0.05);
    }

}

