// -----------------------------------------------------------------------
// <copyright file="IEstatistica.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

using System.Collections.Generic;
namespace Linq
{

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public interface IEstatistica
    {
        bool TodosPaisesPossuemReservasNaturais();

        bool AlgumPaisTemPIBAcimaDeDezMil();

        bool AlgumPaisTemPIBAcimaDeCincoMil();

        List<Pais> ObtenhaPaisesComPIBAcimaDeCincoMil();

        List<Continente> ObtenhaContinentesQueNaoPossuemPais();

        int ObtenhaMaiorPIB();

        int ObtenhaMenorPIB();

        string ObtenhaContinenteComMaiorPIB();

        Dictionary<string, int> ObtenhaDicionarioDePIBPorPais();

        string ObtenhaDescricaoDoPaisComMaiorPIB();

        string ObtenhaDescricaoDoPaisComMenorPIB();

        List<string> ObtenhaDescricaoDosContinentesComMaisDeTresPaises();

        List<Pais> ObtenhaPaisQueComeceCom(string inicio);
    }
}
