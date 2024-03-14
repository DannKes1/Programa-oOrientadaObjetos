DateOnly data = DateOnly.FromDateTime(DateTime.Now);

Voo dan = new Voo (data, 1, 100);

for (int i = 0; i < dan.QtdVagas; i++)
{
    Console.WriteLine(dan.cadeiras[i]);
}


Console.WriteLine(dan.ProximoLivre());