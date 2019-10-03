// -----------------------------------------------------------------------
// <copyright file="Estatistica_v2.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Linq
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Estatistica_v2 : IEstatistica
    {
        private readonly Universo _universo;
        private readonly List<Continente> _continentes;
        private readonly List<Pais> _paises;

        public Estatistica_v2(Universo universo)
        {
            _universo = universo;
            _continentes = universo.ListaDeMundos.SelectMany(ObtenhaContinentes).ToList();
            _paises = _continentes.SelectMany(ObtenhaPaises).ToList();
        }

        private List<Pais> ObtenhaPaises(Continente continentes)
        {
            return continentes.ListaDePaises;
        }
        private List<Continente> ObtenhaContinentes(Mundo mundo)
        {
            return mundo.ListaDeContinentes;
        }

        public bool TodosPaisesPossuemReservasNaturais()
        {
            return _paises.Any(ObtenhaPossuiRiquezasNaturais);
        }

        private bool ObtenhaPossuiRiquezasNaturais(Pais pais)
        {
            return (pais.PossuiRiquezasNaturais == true) ? true : false ;
        }
        public bool AlgumPaisTemPIBAcimaDeDezMil()
        {
            return _paises.Any(ObtenhaPIBMaiorQueDezMil);
        }
        private bool ObtenhaPIBMaiorQueDezMil(Pais pais)
        {
            return pais.PIB > 10000;
        }
        public bool AlgumPaisTemPIBAcimaDeCincoMil()
        {
            return _paises.Any(ObtenhaPIBMaiorQueCincoMil);
        }
        private bool ObtenhaPIBMaiorQueCincoMil(Pais pais)
        {
            return pais.PIB > 5000;
        }
        public List<Pais> ObtenhaPaisesComPIBAcimaDeCincoMil()
        {
            return _paises.Where(ObtenhaPIBMaiorQueCincoMil).ToList();
        }

        public List<Continente> ObtenhaContinentesQueNaoPossuemPais()
        {
            return _continentes.Where(ObtenhaContinenteQueNaoPossuiPais).ToList();
        }
        private bool ObtenhaContinenteQueNaoPossuiPais(Continente continente)
        {
            return continente.ListaDePaises.Count == 0 ? true : false;
        }
        public int ObtenhaMaiorPIB()
        {
            return _paises.Max(ObtenhaPIBPais);
        }
        private int ObtenhaPIBPais(Pais pais)
        {
            return pais.PIB;
        }
        public int ObtenhaMenorPIB()
        {
            return _paises.Min(ObtenhaPIBPais);
        }
        public string ObtenhaContinenteComMaiorPIB()
        {
            return _continentes.Aggregate(ComparaContinentePIB)
                .Descricao;
        }
        private Continente ComparaContinentePIB(Continente x, Continente y)
        {
            return x.PIB > y.PIB ? x : y;
        }
        public Dictionary<string, int> ObtenhaDicionarioDePIBPorPais()
        {
            return _paises.ToDictionary(ObtenhaDescricao, ObtenhaPIB);
        }
        private string ObtenhaDescricao(Pais pais)
        {
            return pais.Descricao;
        }
        private int ObtenhaPIB(Pais pais)
        {
            return pais.PIB;
        }
        public string ObtenhaDescricaoDoPaisComMaiorPIB()
        {
            return _paises.Aggregate((x, y) => x.PIB > y.PIB ? x : y).Descricao;
        }
        private Pais ObtenhaPaisComMaiorPIB(Pais x, Pais y)
        {
            return x.PIB > y.PIB ? x : y;
        }
        public string ObtenhaDescricaoDoPaisComMenorPIB()
        {
            return _paises.Aggregate((x, y) => x.PIB < y.PIB ? x : y).Descricao;
        }

        public List<string> ObtenhaDescricaoDosContinentesComMaisDeTresPaises()
        {
            return _continentes.Where(x => x.ListaDePaises.Count > 3).
                    Select(x => x.Descricao).ToList();

        }

        public List<Pais> ObtenhaPaisQueComeceCom(string inicio)
        {
            return _paises.Where(x => x.Descricao.StartsWith(inicio)).ToList();
        }
    }
}
