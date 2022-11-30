using System;

namespace _01Conceitos
{
 class program
    {
        static void Main(string[] args)
            {
                //instanciar objeto
                //cria objeto pessoa com nome obj
                Pessoa obj = new Pessoa();
                //atributos do objeto
                obj.nome = "ralf";
                obj.idade= 19;
                obj.x1 = 5;
                obj.x2 = 45;
                obj.mensagem();

            }
    }   
}
