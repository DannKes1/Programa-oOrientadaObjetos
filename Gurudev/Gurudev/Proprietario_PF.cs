
public class Proprietario_PF
{
    public int _id;
    public string _email;
    public string _telefone;
    public string _cpf;
    public int _rg;
    public DateTime _data_nasciment;
    public string _sexo;

    public Cnh _cnh;

    public void SetCPF(string cpf)
    {
       
        if (ValidacaoCPF.validaCPF(cpf))
        {
            this._cpf = cpf;
        }
       else
        {
            Console.WriteLine("CPF Invalido");
        }

    }
    public string GetCPF()
    {
        return this._cpf;
    }
    
}

