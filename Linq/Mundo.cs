// -----------------------------------------------------------------------
// <copyright file="Mundo.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

using System.Collections.Generic;

namespace Linq
{
    public class Mundo : Entidade
    {
        public Mundo()
        {
            ListaDeContinentes = new List<Continente>();
        }
        public List<Continente> ListaDeContinentes { get; set; }

        public bool PossuiVidaInteligente { get; set; }
    }
}
