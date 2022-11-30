using System;

class Aluno
{
    //atributos
    public string nome = "";
    public double nota1, nota2;

    //metodos
    public double media() 
    {
         return (nota1 + nota2)/ 2;  
    }

    //situação

    public string situacao(double media)
    {
        return media >= 6 ? "aprovado" : "reprovado";
    }

    //mensagem

    public void mensagem()
    {
        //obter media 
        double obterMedia = media();
        string obterS = situacao(obterMedia);
        Console.WriteLine(nome + " está " + obterS + " com " + obterMedia + " de media");

    }
}