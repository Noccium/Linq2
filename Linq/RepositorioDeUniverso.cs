// -----------------------------------------------------------------------
// <copyright file="RepositorioDeUniverso.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Linq
{
    using System.Collections.Generic;

    public class RepositorioDeUniverso
    {
        public static Universo ConsulteUniverso()
        {
            return new Universo
            {
                Descricao = "Unico",
                ListaDeMundos = new List<Mundo>()
                {
                    new Mundo()
                    {
                        Descricao = "Terra",
                        PossuiVidaInteligente = true,
                        ListaDeContinentes = new List<Continente>
                        {
                            new Continente()
                            {
                                Descricao = "América",
                                ListaDePaises = new List<Pais>
                                {
                                    new Pais(){ Descricao = "Estados Unidos", PIB = 10000 },
                                    new Pais(){ Descricao = "Brasil", PIB = 6000  },
                                    new Pais(){ Descricao = "Canadá", PIB = 9000  },
                                    new Pais(){ Descricao = "Chile", PIB = 2000 }
                                }
                            },
                            new Continente()
                            {
                                Descricao = "Ásia",
                                ListaDePaises = new List<Pais>
                                {
                                    new Pais(){ Descricao = "Japão", PIB = 9500 },
                                    new Pais(){ Descricao = "Cingapura", PIB = 8520 },
                                    new Pais(){ Descricao = "Taiwan", PIB = 5000 }
                                }
                            },
                            new Continente()
                            {
                                Descricao = "Africa",
                                ListaDePaises = new List<Pais>
                                {
                                    new Pais(){ Descricao = "África do Sul", PIB = 1100 },
                                    new Pais(){ Descricao = "Egito", PIB = 1250 },
                                    new Pais(){ Descricao = "Marrocos", PIB = 1000 },
                                }
                            },
                            new Continente()
                            {
                                Descricao = "Europa",
                                ListaDePaises = new List<Pais>
                                {
                                    new Pais(){ Descricao = "Alemanha", PIB = 9000 },
                                    new Pais(){ Descricao = "França", PIB = 8500 },
                                    new Pais(){ Descricao = "Bélgica", PIB = 8200 },
                                    new Pais(){ Descricao = "Itália", PIB = 7200 },
                                    new Pais(){ Descricao = "Portugal", PIB = 7000 },
                                    new Pais(){ Descricao = "Espanha", PIB = 6800 },
                                    new Pais(){ Descricao = "Suíça", PIB = 7250 },
                                }
                            },
                            new Continente()
                            {
                                Descricao = "Oceania",
                                ListaDePaises = new List<Pais>
                                {
                                    new Pais(){ Descricao = "Austrália", PIB = 7900 },
                                }
                            },
                            new Continente()
                            {
                                Descricao = "Antártida"
                            }
                        }
                    },
                    new Mundo()
                    {
                        Descricao = "Marte"
                    }
                }
            };
        }
    }
}
