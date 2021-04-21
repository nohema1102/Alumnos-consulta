using System;
using System.Collections.Generic;

namespace Alumnos_consulta
{
    class Multimedia
    {
        static void Main(string[] args)
        {
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




            Grupo alumnosMulti2 = new Grupo();
            alumnosMulti2.alumnoCarrera.Add(new Alumno("Pedro", "Infante", 101));
            alumnosMulti2.alumnoCarrera.Add(new Alumno("Carmen", "Salinas", 102));
            alumnosMulti2.alumnoCarrera.Add(new Alumno("Rocío", "Dúrcal", 103));
            alumnosMulti2.alumnoCarrera.Add(new Alumno("María", "Aguilar", 104));
            alumnosMulti2.alumnoCarrera.Add(new Alumno("Javier", "Rodríguez", 105));

            Grupo alumnosMulti4 = new Grupo();
            alumnosMulti4.alumnoCarrera.Add(new Alumno("Rosa", "Lechuga",106 ));
            alumnosMulti4.alumnoCarrera.Add(new Alumno("Mauricio", "Aguilar",107 ));
            alumnosMulti4.alumnoCarrera.Add(new Alumno("Kevin", "Gutierrez",108 ));
            alumnosMulti4.alumnoCarrera.Add(new Alumno("Paul", "De la riva",109 ));
            alumnosMulti4.alumnoCarrera.Add(new Alumno("Adrian", "Apodaca",110 ));

            Grupo alumnosMulti6 = new Grupo();
            alumnosMulti6.alumnoCarrera.Add(new Alumno("Eugenio", "Derbez", 111));
            alumnosMulti6.alumnoCarrera.Add(new Alumno("Juan", "Huerta", 112));
            alumnosMulti6.alumnoCarrera.Add(new Alumno("Hugo", "Domínguez", 113));
            alumnosMulti6.alumnoCarrera.Add(new Alumno("Valeria", "Morales", 114));
            alumnosMulti6.alumnoCarrera.Add(new Alumno("Sebastián", "Moreno", 115));

            Grupo alumnosMulti8 = new Grupo();
            alumnosMulti8.alumnoCarrera.Add(new Alumno("José", "Aguilar", 116));
            alumnosMulti8.alumnoCarrera.Add(new Alumno("Angélica", "Valencia", 117));
            alumnosMulti8.alumnoCarrera.Add(new Alumno("Susana", "Vázquez", 118));
            alumnosMulti8.alumnoCarrera.Add(new Alumno("Alejandro", "Peña", 119));
            alumnosMulti8.alumnoCarrera.Add(new Alumno("Brandon", "Herrera", 120));

            Alumno resultadoConsultaMatricula = alumnosMulti2.ConsultarPorMatricula(104);
            Console.WriteLine("Datos del alumno: " + resultadoConsultaMatricula.nombre);
            Console.WriteLine("______________________");
            alumnosMulti2.ConsultarPorMatricula(104);


        }
    }
}