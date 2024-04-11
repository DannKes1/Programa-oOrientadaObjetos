
using System.Runtime.Serialization;

public class Matematica
    {
    public double n1;
    public double n2;

    public double Soma()
    {
        double soma = this.n1 + this.n2;
        return soma;
    }


    public double Multi()
    {
        double x = n1 * n2;
        return x;
    }



}

