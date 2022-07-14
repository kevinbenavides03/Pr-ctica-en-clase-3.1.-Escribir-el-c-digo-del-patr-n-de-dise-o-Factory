using System;
using System.Collections.Generic;


namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Creator> lista = new List<Creator>();

            lista.Add(new CreateProductA("iPhone 13 Pro Max"));
            lista.Add(new CreateProductA("iPhone 13, iPhone"));
            lista.Add(new CreateProductB("Samsung phones · Galaxy A13(SM - A137) · Galaxy Xcover6 Pro"));
            lista.Add(new CreateProductB("Galaxy F13 · Galaxy M13 · Galaxy"));
            lista.Add(new CreateProductB("Galaxy M53 · Galaxy S20 FE 2022 · Galaxy A73 5G "));

            foreach (Creator creator in lista)
            {
                creator.SomeOperation();
            }
        }
    }

}