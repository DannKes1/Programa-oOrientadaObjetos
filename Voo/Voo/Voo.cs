


    public class Voo
    {
        public DateOnly DataVoo;
        public TimeOnly HoraVoo;

        private int QtdVagas;
        private int NVoo;
        public bool[] cadeiras;       
   

        // metodo construtor, todas vez que criar um objeto tera que preencher essas informações 
        public Voo(DateOnly DataVoo, int NVOO, int  QtdVagas)
        {
        // o this. serve para referenciar as variaveis que está na classe global
        this.DataVoo = DataVoo;
        this.NVoo = NVOO;
        this.QtdVagas = QtdVagas;
        cadeiras = new bool[QtdVagas];
        }
      


    // verificar qual é a próxima cadeira livre 
    public int ProximoLivre()
    {
        //percorre o vetor cadeiras
        for (int i = 0; i < cadeiras.Length; i++)
        {
            // se a cadeira for igual a false, ela está desocupada
            if (cadeiras[i] == false)
            {
                // e então vai retornar o numero da cadeira 
                return i + 1;
            }

        }
        // se não ele vai retornar -1 
        return -1;
    }

    // verifica o numero da poltrona se esta ocupada ou nao, ele recebe o numero da poltrana no parametro
    public bool Verifica(int nPoutrana)
    {
        // se o vetor cadeiras + o numero da poltrona for igual a true.  TRUE significa que a poltrona esta ocupada
        if(cadeiras[nPoutrana - 1] == true)
        {
            // ele ira retornar true, no caso a poltrona está ocupada
            return true;
        }
        // se nao
        else
        {
            // ele ira retornar false, FALSE significa que a poltrona esta desocupada.
            return false;
        }
    }

    // Metodo ocupa, ira verificar o numero da poltrona que foi passado pelo o parametro
    public bool Ocupa(int nPoutrana)
    {
        // e verifica SE o numero da poltrona está ocupada aproveitando o outro metodo criado "verifca", e se ela NÃO(FALSE) estiver, ela ira ocupar a poltrona e retornar TRUE(OCUPADA) 
        if (this.Verifica(nPoutrana) == false)
        {
            // nesta condição o vetor cadeiras será ocupada (TRUE)
            cadeiras[nPoutrana - 1] = true;
            // ira retornar como ocupada
            return true;
        }
        // se apos verificar, ela estiver OCUPADA. Ele ira retornar false --> esse false tem haver com o metodo, significa erro na execução
        else
        {
            Console.WriteLine("Poltrana Ocupada");
                return false;
        }
    }
    // esse metodo verifica a quantidade de vagas livres
    public int Vagas()
    {
        int vagasLivres = 0;
        // percorre o for, que é do tamanho do vetor cadeiras
        for (int i = 0; i < cadeiras.Length; i++)
        {
            //se as cadeiras for igual a FALSE que significa desocupada, ele ira contar
            if (cadeiras[i] == false)
            {
                // contando vagas livres
                vagasLivres += 1;
            }

        }
        // ira retornar as vagas livres
        return vagasLivres;
    }

    public int GetNvoo()
    {
        return NVoo;
    }
    public DateOnly GetDataVoo()
    {
        return DataVoo;
    }

    }

