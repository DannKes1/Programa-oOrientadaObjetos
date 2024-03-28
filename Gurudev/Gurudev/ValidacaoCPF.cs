
using System.Threading.Channels;

internal class ValidacaoCPF
    {
    public static bool validaCPF(string cpf)
    {
        cpf = cpf.Replace(".","").Replace("-","");
        if (cpf.Length != 11)
        {
            Console.WriteLine("CPF invalido");
            return false;
        }
        int a1 = Convert.ToInt32(cpf[0].ToString());



        return true;
    }
    
   
    }

