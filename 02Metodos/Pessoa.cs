using System;

class Pessoa
{
    //metodos podem ter o mesmo nome se tiverem parametros diferentes
    //metodo 01
    public void apresentar()
    {
        Console.WriteLine("Olá Mundo");
    }

    //metodo 02

    public void apresentar(string nome)
    {
        Console.WriteLine("olá "+ nome);
    }

    //metodo 03
    public void apresentar(string nome, int idade)
    {
         Console.WriteLine("olá "+ nome + " você tem " + idade + " anos");
    }

}