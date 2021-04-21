using System;
using System.Collections.Generic;

namespace Alumnos_consulta
{
    class Grupo
    { 
        
     public  List<Alumno> alumnoCarrera;
     public Grupo()
     {
         alumnoCarrera = new List<Alumno>();
         
     }

     public Alumno ConsultarPorMatricula(int matricula)
     {
        for (int i = 0; i < alumnoCarrera.Count; i++)
        {
            Console.WriteLine("Buscando Aumno. . .");
            if(alumnoCarrera[i].matricula == matricula)
            {
                return alumnoCarrera[i];
            }
        }
         return null;
     }



         
      
       

        

        

         
      
    }    
}    