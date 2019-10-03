// -----------------------------------------------------------------------
// <copyright file="Pais.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Linq
{
    public class Pais : Entidade
    {
        public Pais()
        {
            PossuiRiquezasNaturais = true;
        }

        public bool PossuiRiquezasNaturais { get; set; }

        public int PIB { get; set; }
    }
}
