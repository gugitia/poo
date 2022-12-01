using System;

namespace _04ExImc
{
    class Program
    {
        static void Main(string[] args)
        {
          Pessoa obj = new Pessoa();
          obj.altura = 1.5;
          obj.peso = 39;         
          obj.mensagem();                    
        }
    }
}