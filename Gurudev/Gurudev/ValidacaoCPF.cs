using System;

internal class ValidacaoCPF
{
    public static bool validaCPF(string cpf)
    {
        // Remove ponto e traço do CPF
        cpf = cpf.Replace(".", "").Replace("-", "");

        if (cpf.Length != 11)
        {
            Console.WriteLine("CPF inválido: deve conter 11 dígitos.");
            return false;
        }

        int soma = 0;
        for (int i = 0; i < 9; i++) 
        {
            soma += int.Parse(cpf[i].ToString()) * (10 - i);
        }

        int primeiroDigito = 11 - (soma % 11);
        if (primeiroDigito >= 10)
        {
            primeiroDigito = 0;
        }

        // Verifica se o primeiro dígito verificado é igual ao do cálculo
        if (int.Parse(cpf[9].ToString()) != primeiroDigito) 
        {
            Console.WriteLine("CPF inválido: primeiro dígito verificador incorreto.");
            return false;
        }

        // Calculando o segundo dígito verificador
        soma = 0;
        for (int i = 0; i < 10; i++)
        {
            soma += int.Parse(cpf[i].ToString()) * (11 - i);
        }

        int segundoDigito = 11 - (soma % 11);
        if (segundoDigito >= 10)
        {
            segundoDigito = 0;
        }

        // Verifica se o segundo dígito verificado é igual ao do cálculo
        if (int.Parse(cpf[10].ToString()) != segundoDigito) // Correção: troquei o "=="
        {
            Console.WriteLine("CPF inválido: segundo dígito verificador incorreto.");
            return false;
        }

        // CPF correto
        Console.WriteLine("CPF válido.");
        return true;
    }
}
