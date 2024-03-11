
namespace AviaoVoo
{
    public class Voo
    {
        private DateTime data;
        private int numeroVoo;
        private bool[] cadeiras;
    

        //metodo construtor
        public Voo(int numeroVoo, DateTime data, int maxPassageiros)
        {
            this.numeroVoo = numeroVoo;
            this.data = data;
            this.cadeiras = new bool[maxPassageiros];
        }

        public int ProximoLivre()
        {
            for (int i = 0; i < cadeiras.Length; i++)
            {
                if (!cadeiras[i])
                {
                    return i + 1;
                }
            }
            return -1; //todas as cadeiras estão ocupadas
        }

        public bool Verifica(int numeroCadeira)
        {
            return cadeiras[numeroCadeira - 1];
        }

        public bool Ocupa(int numeroCadeira)
        {
            if (!Verifica(numeroCadeira))
            {
                cadeiras[numeroCadeira - 1] = true;
                return true;
            }
            return false;
        }
         
        public int Vagas()
        {
            int vagas = 0;
            foreach (bool ocupada in cadeiras)
            {
                if (!ocupada)
                {
                    vagas++;
                }
            }
            return vagas;
        }

        public int GetVoo()
        {
            return numeroVoo;
        }

        public DateTime GetData()
        {
            return data;
        }
    }
}
