// -----------------------------------------------------------------------
// <copyright file="Continente.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    public class Continente : Entidade
    {
        public Continente()
        {
            ListaDePaises = new List<Pais>();
        }

        public List<Pais> ListaDePaises { get; set; }

        public int PIB
        {
            get {
                return ListaDePaises.Sum(x => x.PIB);
            }
        }

    }

    
}
