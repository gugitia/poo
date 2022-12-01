using System;

class Pessoa
 {
    public double peso, altura;
    public double Calculo()
    {
        return peso /(altura * altura);
    }

    public string situacao(double imc)
    {
        string retorno;
        imc = Calculo(); 

        if(imc < 18.5)
        {
            retorno = "abaixo do peso";
        }

        else if(imc < 25)
        {
            retorno = "peso normal";
        }

        else
        {
            retorno = "gordo";
        }

        return retorno;
    }

    public void mensagem()
    {
        double obtercalculo = Calculo();
        string situation = situacao(obtercalculo);
        Console.WriteLine("seu imc é " + obtercalculo + " e você está " + situation);
    }
 }