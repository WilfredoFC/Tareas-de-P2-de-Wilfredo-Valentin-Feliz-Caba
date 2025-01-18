namespace Tarea1
{
    public abstract class Persona
    {
        public string Nombres{ get; set; }
        public string Apellidos{ get; set; }
        public int Edad{ get; set; }
        public Persona(string nombres, string apellidos, int edad)
        {
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.Edad = edad;

        }
    }

    public class Escuela
    {
        public string Nombre{ get; set; }
        public string Direccion{ get; set; }
        public List<Clase> Clases{ get; } = new List<Clase>(); 
        public string Descripcion{ get; set; }
        public Escuela(string nombre, string direccion)
        {
            this.Nombre = nombre;
            this.Direccion = direccion;

        }

        public void agregarClase(Clase clase)
        {
            this.Clases.Add(clase);
        }


    }



    
    public class Estudiante: Persona
    {
        public int Matricula{ get; set; }
        public int NumeroUnico{ get; set; } 

        public Estudiante(string nombres, string apellidos, int edad, int matricula, int numeroUnico) : base(nombres, apellidos, edad)
        {
            this.Matricula = matricula;
            this.NumeroUnico = numeroUnico;
        }

        public void establecerNumeroUnuco(int numeroUnico)
        {
            if (NumeroUnico ==0)
            {
                this.NumeroUnico = numeroUnico;
                Console.WriteLine("El numero : "+ numeroUnico +", se ha establecido como numero unico");
            }
            else
            {
                Console.WriteLine("Ya tiene numero unico, el cual es: "+ NumeroUnico);
            }
        }
    }

    public class Profesor : Persona
    {
        public int Id{ get; set; }
        public List<Curso> Cursos{ get; } = new List<Curso>(); 
        public Profesor(string nombres, string apelliidos, int edad, int id): base(nombres, apelliidos, edad)
        {
            this.Id = id;

        }

        public void añadirCurso(Curso curso)
        {
            Cursos.Add(curso);
        }
    }

    public class Clase
    {
        public string Identificador{ get; set; }
        public int Id{ get; set; } 
        public List<Estudiante> Estudiantes{ get; } = new List<Estudiante>();
        public List<Profesor> Profesores{ get; } = new List<Profesor>(); 

        public Clase(string identificador, int id)
        {
            this.Identificador = identificador;
            this.Id = id;
        }

        public void añadirEstudiante(Estudiante estudiante)
        {
            Estudiantes.Add(estudiante);
        }

        public void añadirProfesor(Profesor profesor)
        {
            Profesores.Add(profesor);
        }
    }

    public class Curso
    {
        public string Nombre{ get; set; }
        public List<Clase> Clases{ get; } = new List<Clase>();  
        public List<string> RecuentoClases{ get; } = new List<string>(); 
        public List<string> RecuentoEjercicios{ get; } = new List<string>(); 

        public Curso(string nombre)
        {
            this.Nombre = nombre;
        }

        public void agregarClase(Clase clase)
        {
            Clases.Add(clase);
        }
        

        public void agregarReceuntoClase(string recuento)
        {
            RecuentoClases.Add(recuento);
        }

        public void agregarReceuntoEjercicio(string recuento)
        {
            RecuentoEjercicios.Add(recuento);
        }

        
        
    }

    

}
