﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaResultadosDeportivos.APIs;
using SistemaResultadosDeportivos.Modelos;
using SistemaResultadosDeportivos.Logica;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.IO;

namespace SistemaResultadosDeportivos
{
    public partial class FrmEncuentrosTorneoApp : Form
    {
        APIpublicidad publicidad;
        APIresultados resultados;
        Image imagenBanner;
        LogicaNotificaciones lgn;
        Deporte deporte;
        Torneo torneo;
        LogicaUsuarios lgu;
        String urlSitio;
        List<EncuentroTorneo> encuentros;
        int var = 0;
        Usuario usuario;

        public FrmEncuentrosTorneoApp(Deporte deporte, Torneo torneo, Usuario usuario)
        {
            InitializeComponent();
            publicidad = new APIpublicidad();
            resultados = new APIresultados();
            lgn = new LogicaNotificaciones();
            lgu = new LogicaUsuarios();
            this.deporte = deporte;
            this.torneo = torneo;
            this.usuario = usuario;
            RespuestaPublicidad res = JsonConvert.DeserializeObject<RespuestaPublicidad>(publicidad.publicidadToJSON());
            setImageBanner(res.pathBanner);
            urlSitio = res.urlSitio;
            encuentros = new List<EncuentroTorneo>();
            setEncuentros();
            listarEncuentros();
            actualizarSuscribirse();
        }

        private void setEncuentros()
        {
            List<String> encuentrosJson = resultados.getEncuentrosByTorneo(torneo.idTorneo);
            for (int i = 0; i < encuentrosJson.Count; i++)
            {
                EncuentroTorneo e = JsonConvert.DeserializeObject<EncuentroTorneo>(encuentrosJson[i]);
                encuentros.Add(e);
            }
        }

        public void listarEncuentros()
        {
            flpEncuentros.Controls.Clear();
            if (encuentros != null)
            {
                int i = 0;
                int tamano = flpEncuentros.Width - 5;

                foreach (EncuentroTorneo en in encuentros)
                {
                    String tamanoSt = en.nombreEncuentro;
                    String tamanoSt2 = "Fecha: " + en.fecha;
                    if (tamanoSt.Length > tamano)
                    {
                        tamano = tamanoSt.Length;
                    }
                    else if (tamanoSt2.Length > tamano)
                    {
                        tamano = tamanoSt2.Length;
                    }
                }

                foreach (EncuentroTorneo en in encuentros)
                {
                    Deporte deporte = JsonConvert.DeserializeObject<Deporte>(resultados.getDeporte(en.idDeporte));
                    Label lblBoton = new Label();
                    Label lblBoton2 = new Label();
                    Label lblBoton3 = new Label();
                    Button btnEncuentro = new Button();
                    String textNombre = en.nombreEncuentro + "                          " + deporte.nombreDeporte;
                    String textFecha = "Fecha: " + en.fecha.Day + "/" + en.fecha.Month + "/" + en.fecha.Year;
                    String textHora = "Hora:";
                    if (en.hora.Hour < 10)
                        textHora += " 0" + en.hora.Hour + ":";
                    else
                        textHora += " " + en.hora.Hour + ":";
                    if (en.hora.Minute < 10)
                        textHora += "0" + en.hora.Minute;
                    else
                        textHora += en.hora.Minute;
                    propiedadesBoton(btnEncuentro, i, tamano);
                    propiedadesLabel(lblBoton, textNombre, btnEncuentro, 8);
                    propiedadesLabel(lblBoton2, textFecha, btnEncuentro, 39);
                    propiedadesLabel(lblBoton3, textHora, btnEncuentro, 70);
                    btnEncuentro.Controls.Add(lblBoton);
                    btnEncuentro.Controls.Add(lblBoton2);
                    btnEncuentro.Controls.Add(lblBoton3);
                    flpEncuentros.Controls.Add(btnEncuentro);
                    btnEncuentro.Click += new EventHandler(btnEncuentro_Click);
                    i++;
                }
            }
        }

        private void propiedadesBoton(Button btn, int i, int t)
        {
            btn.Height = 92;
            btn.Tag = i;
            btn.BackColor = System.Drawing.Color.FromArgb(100, 0, 0, 0);
            btn.FlatStyle = FlatStyle.Flat;
            if (t == (flpEncuentros.Width - 5))
            {
                btn.Width = t;
            }
            else
            {
                btn.Width = t * 10;
            }
        }

        private void propiedadesLabel(Label lbl, String s, Button btn, int l)
        {
            lbl.Text = s;
            lbl.BackColor = System.Drawing.Color.Transparent;
            lbl.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            lbl.ForeColor = System.Drawing.Color.White;
            lbl.Width = s.Length * 10;
            lbl.Location = new System.Drawing.Point(110, l);
        }

        private void btnEncuentro_Click(object sender, EventArgs e)
        {
            Button btnEncuentro = sender as Button;
            int i = (Int32)btnEncuentro.Tag;
            var = i;
            EncuentroTorneo enT = encuentros[var];
            Encuentro encuentro = new Encuentro(enT.idEncuentro, enT.fecha, enT.hora, enT.pausado, enT.minActual, enT.segActual, enT.comenzo, enT.finalizo, enT.nombreEncuentro, enT.idDeporte);
            if (deporte.porEquipos)
            {
                new FrmVerEncuentroEquipo(encuentro, usuario).Visible = true;
            }
            else if (!deporte.porEquipos && deporte.cantParticipantes == 2)
            {
                new FrmVerEncuentroIndDeADos(encuentro, usuario).Visible = true;
            }
            else if (deporte.cantParticipantes > 2)
            {
                new FrmVerEncuentroInd(encuentro, usuario).Visible = true;
            }
        }

        private void setImageBanner(string path)
        {
            //Establece la imagen del banner, dado la ruta respectiva
            if (!lgu.esMiembro(usuario.correo))
            {
                try
                {
                    imagenBanner = Image.FromFile(Directory.GetCurrentDirectory() + "\\Img\\" + path);
                    Bitmap bitmapBanner = new Bitmap(imagenBanner, banner.Width, banner.Height);
                    banner.Image = bitmapBanner;
                }
                catch { }
            }
            else
            {
                banner.Visible = false;
            }
        }

        private void FrmEncuentrosTorneoApp_Load(object sender, EventArgs e)
        {
            flpEncuentros.BackColor = System.Drawing.Color.FromArgb(100, 0, 0, 0);
        }

        private void btnSuscribirse_Click(object sender, EventArgs e)
        {
            if (lgu.esMiembro(usuario.correo))
            {
                List<String> correos = lgn.devolverMiembrosPorSuscripcionTorneo(torneo.idTorneo);
                if (correos.Contains(usuario.correo))
                {
                    lgn.eliminarSuscripcionATorneo(usuario.correo, torneo.idTorneo);
                }
                else
                {
                    lgn.agregarSuscripcionATorneo(usuario.correo, torneo.idTorneo);
                }
                actualizarSuscribirse();
            }
            else
            {
                MessageBox.Show("Para acceder a esta función debe de obtener la membresía.");
            }
        }

        private void actualizarSuscribirse()
        {
            List<String> correos = lgn.devolverMiembrosPorSuscripcionTorneo(torneo.idTorneo);
            if (correos.Contains(usuario.correo))
            {
                btnSuscribirse.BackColor = Color.Gray;
                btnSuscribirse.Text = "Suscrito";
            }
            else
            {
                btnSuscribirse.BackColor = Color.MediumTurquoise;
                btnSuscribirse.Text = "Suscribirse";
            }
        }
    }
}
