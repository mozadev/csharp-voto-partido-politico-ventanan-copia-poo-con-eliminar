using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VOTO_ELECTRONICO_ONPE
{
    public class gestionVotacion
    {

        public static List<partidosPoliticos> Partidos { get; set; }
        public gestionVotacion()
        {
            if (Partidos == null)
            {
                Partidos = new List<partidosPoliticos>();
            }
        }
        public void insertarPartidos(partidosPoliticos partido)
        {
            Partidos.Add(partido);
        }


        public void insertarVotosEnPartido(string codigoPartido, votosDeCiudadanos voto)
        {
            partidosPoliticos partidoEncontrado = Partidos.Find(delegate (partidosPoliticos value) { return (value.Codigo == codigoPartido); });//devuelve v o f


            if (partidoEncontrado != null)
            {
                partidoEncontrado.Votos.Add(voto);
            }
        }


        public List<votosDeCiudadanos> ListarVotosDePartido(string codigoPartido)
        {
            partidosPoliticos partidoEncontrado = Partidos.Find(delegate (partidosPoliticos value) { return value.Codigo == codigoPartido; });
            //v o f.
            if (partidoEncontrado != null)
            {
                return partidoEncontrado.Votos;
            }
            else
            {
                return null;
            }
        }

        public partidosPoliticos damePartidoConMasVotos()
        {
            partidosPoliticos temp = new partidosPoliticos();
            foreach (partidosPoliticos partido in Partidos)
            {
                if (partido.Votos.Count > temp.Votos.Count)
                {
                    temp = partido;
                }
            }
            return temp;
        }

        public bool CursoExiste(string codigoPartido)
        {
            return Partidos.Exists(delegate (partidosPoliticos value) { return value.Codigo == codigoPartido; });

        }

        //public List<partidosPoliticos> ListarCursoMatriculadosPorAlumno(int)
        //{

        //    List<partidosPoliticos> cursosMatriculadosDeAlumno = new List<partidosPoliticos>();
        //    foreach (partidosPoliticos partido in Partidos)
        //    {
        //        if (partido.Votos.Exists(delegate (votosDeCiudadanos value)
        //        {
        //            return value. == ;

        //        }))
        //            cursosMatriculadosDeAlumno.Add(curso);
        //    }
        //    return cursosMatriculadosDeAlumno;

        //}


    }


}

