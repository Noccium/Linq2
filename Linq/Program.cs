
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var universo = RepositorioDeUniverso.ConsulteUniverso();

            var estatistica = new Estatistica_v2(universo);

            Console.WriteLine("TodosPaisesPossuemReservasNaturais: " + estatistica.TodosPaisesPossuemReservasNaturais());

            Console.WriteLine("\nAlgum pais com PIB > 5000: " + estatistica.AlgumPaisTemPIBAcimaDeCincoMil());

            Console.WriteLine("\nAlgum pais com PIB > 10000: " + estatistica.AlgumPaisTemPIBAcimaDeDezMil());

            Console.WriteLine("\nContinente com Maior PIB: "+ estatistica.ObtenhaContinenteComMaiorPIB());
            
            Console.Write("\nContinentes sem paises: ");
            estatistica.ObtenhaContinentesQueNaoPossuemPais().ForEach(continente => Console.Write(String.Format("{0}\n", continente.Descricao)));

            Console.WriteLine("\nPais com maior PIB: " + estatistica.ObtenhaDescricaoDoPaisComMaiorPIB());

            Console.Write("\nContinentes com mais de tres paises: \n");
            estatistica.ObtenhaDescricaoDosContinentesComMaisDeTresPaises().ForEach(continente => Console.Write(String.Format("{0}\n", continente)));

            Console.WriteLine("\nMaior PIB: " + estatistica.ObtenhaMaiorPIB());

            Console.Write("\nPaises com PIB > 5000: \n");
            estatistica.ObtenhaPaisesComPIBAcimaDeCincoMil().ForEach(pais => Console.Write(String.Format("{0}\n", pais.Descricao)));

            var c = "E";
            Console.Write("\nPaises que começam com: " + c + "\n");
            estatistica.ObtenhaPaisQueComeceCom(c).ForEach(pais => Console.Write(String.Format("{0}\n", pais.Descricao)));

            var listaNumeros = new List<int>() { 1, 2, 3, 4, 5, 17, 51, 18, 20, 12, 44, 25, 22, 41, 12 };

            var listaPaises = new List<string>() { "Cuba", "Inglaterra", "Dinamarca" };

            var somaPares = listaNumeros.Where(y => y % 2 == 0).Sum();
            var somaImpares = listaNumeros.Where(y => y % 2 != 0).Sum();

            Console.WriteLine("Soma Pares: " + somaPares);
            Console.WriteLine("Soma Impares: " + somaImpares);

            var lista2 = listaNumeros.Skip(5).Take(10).ToList();
            Console.WriteLine("\nLista2:");
            lista2.ForEach(x => Console.WriteLine(x));

            var contemNumero1 = lista2.Contains(1);
            lista2.Add(5);
            lista2.AddRange(lista2);
            var array = lista2.ToArray();
            lista2.Reverse();
            lista2.RemoveAll(x => x % 2 == 0);
            lista2.Remove(12);
            lista2.RemoveAt(0);
            lista2.RemoveRange(0, 5);
            lista2.OrderBy(x => x).ThenBy(x => x);

            var novaLista = lista2.Concat(new List<int>(){ 1, 2 });

            //Queue queue;
            //Stack stack;
            //HashSet<int> set = new HashSet<int>(lista2);

            //IQueryable<int> query;
            //IEnumerable<int> numerable;
            //IList<int> list;
            //ICollection<int> collection;
            
            var paises = listaPaises.Select(x => new Pais().Descricao = x);
        }
    }
}
