
using System.Net;

public class Utilitario : Veiculo
    {
    public Utilitario (int quantidadeEixo, int TipoEixo)
   : base(quantidadeEixo, TipoEixo)

    {
    }

    public override void CalcularPedagio()
    {
        precoPedagio =  3.50 * qtdEixos;
        precoPedagio = precoPedagio + (precoPedagio * 0.02);
    }

}

