﻿using System.Collections.Generic;
using ConquistadorAbsolutoBiblioteca.Origem;

namespace ConquistadorAbsolutoBiblioteca.Essencia
{
    public interface IEssencia : IOrigem
    {
        /// <summary>
        /// Atributos da essência. Ex: congelante, eletrizante, gravitacional.
        /// </summary>
        List<string> Propriedades { get; set; }
        /// <summary>
        /// Condição atual da essência(destruída, adormecida, etc...).
        /// </summary>
        Estado Estado { get; set; }
        /// <summary>
        /// Energia que aumenta o poder da essência. Ex.: Fogo: raiva; Água: calma.
        /// </summary>
        EnergiaPropulsora Potencializador { get; set; }

        void ConferirRequisitos();
    }
}