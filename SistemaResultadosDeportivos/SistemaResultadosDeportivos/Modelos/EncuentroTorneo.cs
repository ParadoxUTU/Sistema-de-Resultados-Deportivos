﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaResultadosDeportivos.Modelos
{
    public class EncuentroTorneo
    {
        public String etapa { get; set; }
        public int idEncuentro { get; set; }
        public DateTime fecha { get; set; }
        public DateTime hora { get; set; }
        public bool pausado { get; set; }
        public int minActual { get; set; }
        public int segActual { get; set; }
        public bool comenzo { get; set; }
        public bool finalizo { get; set; }
        public String nombreEncuentro { get; set; }
        public int idDeporte { get; set; }
        
        public EncuentroTorneo(String e, int idE, DateTime f, DateTime h, bool p, int m, int s, bool c, bool fi, String nE, int idD)
        {
            etapa = e;
            idEncuentro = idE;
            fecha = f;
            hora = h;
            pausado = p;
            minActual = m;
            segActual = s;
            comenzo = c;
            finalizo = fi;
            nombreEncuentro = nE;
            idDeporte = idD;
        }
    }
}
