using System;

class Pessoa
{
    //atributos
    public string nome;
    public int idade;

    public int soma;
    public int x1;
    public int x2;

    //metodos
    public void mensagem()
    {
        Console.WriteLine("olá " + nome +" você tem " + idade + " anos");
        soma = x1 + x2;
        Console.WriteLine("o resultado é " + soma);
    }
}