// -----------------------------------------------------------------------
// <copyright file="Estatistica_v1.cs" company="">
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
    public class Estatistica_v1 : IEstatistica
    {
        public Universo Universo { get; set; }

        public Estatistica_v1(Universo universo)
        {
            Universo = universo;
        }

        public bool AlgumPaisTemPIBAcimaDeCincoMil()
        {
            foreach (var mundo in Universo.ListaDeMundos)
            {
                foreach (var continente in mundo.ListaDeContinentes)
                {
                    foreach (var pais in continente.ListaDePaises)
                    {
                        if (pais.PIB > 5000)
                            Console.WriteLine("Pais: " + pais.Descricao + " PIB: " + pais.PIB);
                            return true;
                    }
                }
            }
            return false;
        }

        public bool AlgumPaisTemPIBAcimaDeDezMil()
        {
            foreach (var mundo in Universo.ListaDeMundos)
            {
                foreach (var continente in mundo.ListaDeContinentes)
                {
                    foreach (var pais in continente.ListaDePaises)
                    {
                        if (pais.PIB > 10000)
                            Console.WriteLine("Pais: " + pais.Descricao + " PIB: " + pais.PIB);
                        return true;
                    }
                }
            }
            return false;
        }

        public string ObtenhaContinenteComMaiorPIB()
        {
            string continenteComMaiorPIB = null;
            var maiorPIBContinente = 0;
            var PIBContinente = 0;

            foreach (var mundo in Universo.ListaDeMundos)
            {
                foreach (var continente in mundo.ListaDeContinentes)
                {
                    foreach (var pais in continente.ListaDePaises)
                    {
                        PIBContinente += pais.PIB;
                    }
                    if (PIBContinente > maiorPIBContinente)
                    {
                        maiorPIBContinente = PIBContinente;
                        continenteComMaiorPIB = continente.Descricao;
                    }
                    PIBContinente = 0;
                }
            }
            return continenteComMaiorPIB; 
        }

        public List<Continente> ObtenhaContinentesQueNaoPossuemPais()
        {
            List<Continente> continentesQueNaoPossuemPais = new List<Continente>();
            foreach (var mundo in Universo.ListaDeMundos)
            {
                foreach (var continente in mundo.ListaDeContinentes)
                {
                    
                    if(continente.ListaDePaises.Count == 0)
                        continentesQueNaoPossuemPais.Add(continente);
                }
            }
            return continentesQueNaoPossuemPais;
        }

        public string ObtenhaDescricaoDoPaisComMaiorPIB()
        {
            string paisComMaiorPIB = null;
            int maiorPIB = 0;
            foreach (var mundo in Universo.ListaDeMundos)
            {
                foreach (var continente in mundo.ListaDeContinentes)
                {
                    foreach (var pais in continente.ListaDePaises)
                    {
                        if (pais.PIB > maiorPIB)
                        {
                            maiorPIB = pais.PIB;
                            paisComMaiorPIB = pais.Descricao;
                        }                  
                    }
                }
            }
            return paisComMaiorPIB;
        }

        public string ObtenhaDescricaoDoPaisComMenorPIB()
        {
            string paisComMenorPIB = null;
            int menorPIB = int.MaxValue;
            foreach (var mundo in Universo.ListaDeMundos)
            {
                foreach (var continente in mundo.ListaDeContinentes)
                {
                    foreach (var pais in continente.ListaDePaises)
                    {
                        if (pais.PIB < menorPIB)
                        {
                            menorPIB = pais.PIB;
                            paisComMenorPIB = pais.Descricao;
                        }
                    }
                }
            }
            return paisComMenorPIB;
        }

        public List<string> ObtenhaDescricaoDosContinentesComMaisDeTresPaises()
        {
            List<string> continenteComMaisDeTrasPaises = new List<string>();
            
            foreach (var mundo in Universo.ListaDeMundos)
            {
                foreach (var continente in mundo.ListaDeContinentes)
                {
                    if (continente.ListaDePaises.Count > 3)
                        continenteComMaisDeTrasPaises.Add(continente.Descricao);
                }
            }

            return continenteComMaisDeTrasPaises;
        }

        public Dictionary<string, int> ObtenhaDicionarioDePIBPorPais()
        {
            throw new NotImplementedException();
        }

        public int ObtenhaMaiorPIB()
        {
            int maiorPIB = 0;
            foreach (var mundo in Universo.ListaDeMundos)
            {
                foreach (var continente in mundo.ListaDeContinentes)
                {
                    foreach (var pais in continente.ListaDePaises)
                    {
                        if (pais.PIB < maiorPIB)
                        {
                            maiorPIB = pais.PIB;                       
                        }
                    }
                }
            }
            return maiorPIB;
        }

        public int ObtenhaMenorPIB()
        {
            int menorPIB = 0;
            foreach (var mundo in Universo.ListaDeMundos)
            {
                foreach (var continente in mundo.ListaDeContinentes)
                {
                    foreach (var pais in continente.ListaDePaises)
                    {
                        if (pais.PIB < menorPIB)
                        {
                            menorPIB = pais.PIB;
                        }
                    }
                }
            }
            return menorPIB;
        }

        public List<Pais> ObtenhaPaisesComPIBAcimaDeCincoMil()
        {
            List<Pais> paisesComPIBAcimaDeCincoMil = new List<Pais>();

            foreach (var mundo in Universo.ListaDeMundos)
            {
                foreach (var continente in mundo.ListaDeContinentes)
                {
                    foreach (var pais in continente.ListaDePaises)
                    {
                        if (pais.PIB > 5000)
                            paisesComPIBAcimaDeCincoMil.Add(pais);
                    }
                }
            }
            return paisesComPIBAcimaDeCincoMil;
        }

        public List<Pais> ObtenhaPaisQueComeceCom(string inicio)
        {
            List<Pais> paisesQueComeceCom = new List<Pais>();

            foreach (var mundo in Universo.ListaDeMundos)
            {
                foreach (var continente in mundo.ListaDeContinentes)
                {
                    foreach (var pais in continente.ListaDePaises)
                    {
                        if (pais.Descricao.StartsWith(inicio))
                            paisesQueComeceCom.Add(pais);
                    }
                }
            }
            return paisesQueComeceCom;
        }

        public bool TodosPaisesPossuemReservasNaturais()
        {
 
            foreach (var mundo in Universo.ListaDeMundos)
            {

                foreach (var continente in mundo.ListaDeContinentes)
                {
                    foreach (var pais in continente.ListaDePaises)
                    {
                        if (pais.PossuiRiquezasNaturais == false)
                            return false;
                    }
                }
            }
            return true;
        }
    }
}
