using System;

internal class ValidacaoCPF
{
    public static bool validaCPF(string cpf)
    {
        // removendo traços e pontos 
        cpf = cpf.Replace(".", "").Replace("-", "");

        // se a contagem dos numeros for nao for igual a 11 tá errado
        if (cpf.Length != 11)
        {
            Console.WriteLine("CPF inválido: deve conter 11 dígitos.");
            return false;
        }
        int resto = 0;

        // calcular o primeiro digito verificador
        int soma = 0;
        for (int i = 0; i < 9; i++)
        {
            soma = soma + int.Parse(cpf[i].ToString()) * (10 - i);
        }
        resto = soma % 11;

        int primeiroDigito = 0;
        // resto for menor que 2, digito é igual a 0
        if (resto < 2)
        {
            primeiroDigito = 0;

        }
        if (resto >= 2)
        {
            primeiroDigito = 11 - resto;

        }

        // Verifica se o CPF na posição 9 NÃO for igual ao primeiro digito ele ira executar o erro
        if (int.Parse(cpf[9].ToString()) != primeiroDigito)
        {
            Console.WriteLine("CPF inválido: primeiro dígito verificador incorreto.");
            return false;
        }


        // calcular segundo digito
        int soma2 = 0;
        for (int i = 0; i < 10; i++)
        {
            soma2 = soma2 + int.Parse(cpf[i].ToString()) * (11 - i);

        }

        int resto2 = soma2 % 11;

        int segundoDigito = 0;
        // regra
        if (resto2 < 2)
        {
            segundoDigito = 0;
        }
        if (resto2 >= 2)
        {
            segundoDigito = 11 - resto2;
        }

        if (int.Parse(cpf[10].ToString()) != segundoDigito) 
        {
            Console.WriteLine("CPF inválido: segundo dígito verificador incorreto.");
            return false;
        }

        // CPF correto
        Console.WriteLine("CPF válido.");
        return true;
    }
}
