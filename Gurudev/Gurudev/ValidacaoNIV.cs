
    internal class ValidacaoNIV
    {
    public static bool validaNIV(string niv)
    {
        niv.ToUpper();
        if (niv.Length != 17)
        {
            Console.WriteLine("O NIV contém 17 caracteres.");
            return false;
        }
        
        for (int i = 0; i < niv.Length; i++)
        {

            if (niv[i].ToString() == "O" || niv[i].ToString() == "J" || niv[i].ToString() == "Q")
            {
                Console.WriteLine("Niv Invalido");
                return false;
            }
 
        }
        Console.WriteLine("NIV correto");
        return true;
    }

    }

