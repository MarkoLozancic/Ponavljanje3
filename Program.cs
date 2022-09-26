using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponavljanje3
{
    class KlasaX
    {

        int[] arr = new int[100];
        private int index;

        public int Index { get => index; set => index = value; }

        public int Dodjela(int []arr,int i)
        {
            i= Index;
            return arr[Index];
        }
    }
    internal class Program
    {
        /*
         * (12 bodova) Definirajte klasu KlasaX sa sljedećim članicama:
niz tipa int veličine 100 elemenata arr
indeks koji će vraćati i postavljati vrijednost svakog pojedinog člana niza arr.
Definirajte objekt x tipa KlasaX, te koristeći indekse dodijelite nizu arr prvih 100 brojeva i ispišite 50. član niza.

         * */
        static void Main(string[] args)
        {
            int []arr=new int[100];
            KlasaX x = new KlasaX();
            for(int i = 0; i < 100; i++)
        {
                x.Index = i;
                x.Dodjela(arr, i);
        }
            Console.WriteLine(arr[50]);
            Console.ReadKey();
        }
    }
}
