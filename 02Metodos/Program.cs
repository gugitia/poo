using System;

namespace _02Conceito
{
    class program
    {
        static void Main(string[] args)
        {
            Pessoa jbs = new Pessoa();
            jbs.apresentar();
            jbs.apresentar("Gustavo");
            jbs.apresentar("Ronaldo", 57);
        }
    }
}