
    internal class ValidacaoNIV
    {
    public static bool validaNIV(string niv)
    {
        if (niv.Length != 17)
        {
            Console.WriteLine("O NIV contém 17 caracteres.");
            return false;
        }
        string norma2001 = niv[17].ToString();

        // as letras O , I  e Q nao podem ter nesse array de string


        return true;
    }

    }

