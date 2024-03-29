﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaResultadosDeportivos.Modelos
{
    public class Anotacion
    {
        public int idAnotacion { get; set; }
        public int idJugador { get; set; }
        public int minuto { get; set; }
        public int idEncuentro { get; set; }
        public int puntuacion { get; set; }
        public int segundo { get; set; }

        public Anotacion(int idA, int idJ, int m, int idE, int p, int segundo)
        {
            idAnotacion = idA;
            idJugador = idJ;
            minuto = m;
            idEncuentro = idE;
            puntuacion = p;
            this.segundo = segundo;
        }
    }
}
