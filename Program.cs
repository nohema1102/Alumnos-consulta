using System;
using System.Collections.Generic;

namespace Alumnos_consulta
{
    class Multimedia
    {
        static void Main(string[] args)
        {
           //Artes visuales
            //2do semestre Alumnos de artes visuales
            Grupo alumnosArtVis2 = new Grupo();
             alumnosArtVis2.alumnoCarrera.Add(new Alumno("Luis","Macías", 201));
             alumnosArtVis2.alumnoCarrera.Add(new Alumno("Karla","Piñón", 202));
             alumnosArtVis2.alumnoCarrera.Add(new Alumno("Nicole","Arellano", 203));
             alumnosArtVis2.alumnoCarrera.Add(new Alumno("Adrián","Sandoval", 204));
             alumnosArtVis2.alumnoCarrera.Add(new Alumno("Angel","Payán", 205));
            //4to semestre
             Grupo alumnosArtVis4 = new Grupo();
             alumnosArtVis4.alumnoCarrera.Add(new Alumno("Alondra","Segovia", 206));
             alumnosArtVis4.alumnoCarrera.Add(new Alumno("Isaac","Tena", 207));
             alumnosArtVis4.alumnoCarrera.Add(new Alumno("Fernanda","Urciaga", 208));
             alumnosArtVis4.alumnoCarrera.Add(new Alumno("Mario","Sosa", 209));
             alumnosArtVis4.alumnoCarrera.Add(new Alumno("Naydelin","Montoya", 210));
            //6to semestre
             Grupo alumnosArtVis6 = new Grupo();
             alumnosArtVis6.alumnoCarrera.Add(new Alumno("Luis","Macías", 211));
             alumnosArtVis6.alumnoCarrera.Add(new Alumno("Karla","Piñón", 212));
             alumnosArtVis6.alumnoCarrera.Add(new Alumno("Nicole","Arellano", 213));
             alumnosArtVis6.alumnoCarrera.Add(new Alumno("Adrián","Sandoval", 214));
             alumnosArtVis6.alumnoCarrera.Add(new Alumno("Angel","Payán", 215));
            //8vo semestre
             Grupo alumnosArtVis8 = new Grupo();
             alumnosArtVis8.alumnoCarrera.Add(new Alumno("Daniel","Baca", 216));
             alumnosArtVis8.alumnoCarrera.Add(new Alumno("Axel","Nevárez", 217));
             alumnosArtVis8.alumnoCarrera.Add(new Alumno("Daniela","Sánchez", 218));
             alumnosArtVis8.alumnoCarrera.Add(new Alumno("Carlos","Villagrán", 219));
             alumnosArtVis8.alumnoCarrera.Add(new Alumno("Enrique","Segoviano", 220));


            Console.WriteLine("Artes visuales"); 
            for(int i=0; i<alumnosArtVis8.alumnoCarrera.Count; i++ )
            {
                Console.WriteLine(alumnosArtVis8.alumnoCarrera[i].nombre + " " + alumnosArtVis8.alumnoCarrera[i].apellido);
            }


            //------------ Ingeniería Multimedia ---------------
            //2do Semestre
            Grupo alumnosMulti2 = new Grupo();
            alumnosMulti2.alumnoCarrera.Add(new Alumno("Pedro", "Infante", 101));
            alumnosMulti2.alumnoCarrera.Add(new Alumno("Carmen", "Salinas", 102));
            alumnosMulti2.alumnoCarrera.Add(new Alumno("Rocío", "Dúrcal", 103));
            alumnosMulti2.alumnoCarrera.Add(new Alumno("María", "Aguilar", 104));
            alumnosMulti2.alumnoCarrera.Add(new Alumno("Javier", "Rodríguez", 105));

            //4to semestre

            Grupo alumnosMulti4 = new Grupo();
            alumnosMulti4.alumnoCarrera.Add(new Alumno("Rosa", "Lechuga",106 ));
            alumnosMulti4.alumnoCarrera.Add(new Alumno("Mauricio", "Aguilar",107 ));
            alumnosMulti4.alumnoCarrera.Add(new Alumno("Kevin", "Gutierrez",108 ));
            alumnosMulti4.alumnoCarrera.Add(new Alumno("Paul", "De la riva",109 ));
            alumnosMulti4.alumnoCarrera.Add(new Alumno("Adrian", "Apodaca",110 ));
            //6to semestre
            Grupo alumnosMulti6 = new Grupo();
            alumnosMulti6.alumnoCarrera.Add(new Alumno("Eugenio", "Derbez", 111));
            alumnosMulti6.alumnoCarrera.Add(new Alumno("Juan", "Huerta", 112));
            alumnosMulti6.alumnoCarrera.Add(new Alumno("Hugo", "Domínguez", 113));
            alumnosMulti6.alumnoCarrera.Add(new Alumno("Valeria", "Morales", 114));
            alumnosMulti6.alumnoCarrera.Add(new Alumno("Sebastián", "Moreno", 115));
            //8vo semestre
            Grupo alumnosMulti8 = new Grupo();
            alumnosMulti8.alumnoCarrera.Add(new Alumno("José", "Aguilar", 116));
            alumnosMulti8.alumnoCarrera.Add(new Alumno("Angélica", "Valencia", 117));
            alumnosMulti8.alumnoCarrera.Add(new Alumno("Susana", "Vázquez", 118));
            alumnosMulti8.alumnoCarrera.Add(new Alumno("Alejandro", "Peña", 119));
            alumnosMulti8.alumnoCarrera.Add(new Alumno("Brandon", "Herrera", 120));

            Console.WriteLine("\n--------\n");
            Console.WriteLine("Ingeniería en multimedia"); 
            for(int i=0; i<alumnosMulti6.alumnoCarrera.Count; i++ )
            {
                Console.WriteLine(alumnosMulti6.alumnoCarrera[i].nombre + " " + alumnosMulti6.alumnoCarrera[i].apellido);
            }


           

            Alumno resultadoConsultaMatricula = alumnosArtVis8.ConsultarPorMatricula(217);
            
            Console.WriteLine("Datos del alumno ");
            Console.WriteLine("Nombre: " + resultadoConsultaMatricula.nombre + " " +resultadoConsultaMatricula.apellido);
            Console.WriteLine("Matrícula: " + resultadoConsultaMatricula.matricula);
            Console.WriteLine("\n--------\n");

            

             
            Dictionary<string,string> carrerasInfo = new Dictionary<string, string>();

            carrerasInfo.Add("Licenciatura en artes visuales","PERFIL DE LA CARRERA. En Artes Visuales aprenderás a ilustrar con diferentes técnicas, a crear imagen corporativa y branding (logotipos y sus aplicaciones, crear experiencia); fotografía comercial, documental y artística; diseño editorial (revistas, libros, catálogos y folletos); diseño y programación de páginas web y multimedia, así como desarrollo de proyectos audiovisuales como comerciales de TV, animación, cortometrajes, anuncios para la radio, Motion Graphics y más... También cuenta con materias que te permiten crear y administrar tu propio negocio si así lo deseas. La Lic. en Artes Visuales tiene una duración de 8 semestres, en turno matutino, con un horario entre 8am y 2pm. Estamos incorporados a la SEC y D y somos parte del Sistema Educativo Nacional (SEN).");
            carrerasInfo.Add("Ingeniería en multimedia","El programa de Ingeniera en Multimedia, forma profesionistas competentes en el diseño, desarrollo y puesta en marcha de sistemas informáticos que utilicen intensivamente el potencial tecnológico de la multimedia.  Además desarrollará software y aplicaciones que aprovechen, mejoren o creen nuevas opciones tecnológicas sobre las herramientas de desarrollo que componen lo más avanzado  en tecnología multimedia. Sabrá dimensionar y administrar  proyectos de sistemas y multimedia con habilidades en la coordinación de equipos interdisciplinarios de desarrollo.");
        
            foreach(var key in carrerasInfo.Keys)
            {
                Console.WriteLine(key + ": " + carrerasInfo.GetValueOrDefault(key));
            }

        }
    }
}
