

/*Faça um programa que possui uma classe funcionário, essa classe possui os atributos:
matrícula, nome, CPF e salário. Na classe program, crie duas instâncias dessa classe,
lendo os valores do usuário, e ao final imprime o nome do funcionário como maior
salário*/
    internal class Funcionario
    {
    public string matricula;
    public string nome;
    public string cpf;
    public double salario;

    //comparando o salário do funcionário que chama o método 
    public string MaiorSalario(Funcionario funcionario2)
    {
        // salairo do funcinario que chama o metodo for maior que o salario do funcionario2 
        if (this.salario > funcionario2.salario)
        {
            return this.nome;
        }
        else if (funcionario2.salario > this.salario)
        {
            return funcionario2.nome;
        }
        else
        {
            return "Ambos funcionários têm o mesmo salário";
        }
    }
    }

