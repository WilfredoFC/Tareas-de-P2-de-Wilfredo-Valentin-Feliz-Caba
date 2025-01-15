namespace Tarea1
{
    public class Persona
    {
        public string nombres, apellidos;
        public int edad;
        public Persona(string nombres, string apellidos, int edad)
        {
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.edad = edad;

        }
    }

    public class Escuela
    {
        public string nombre;
        public string direccion;
        private List<Clase> clases;
        private string descripcion;
        public Escuela(string nombre, string direccion)
        {
            this.nombre = nombre;
            this.direccion = direccion;

        }

        public void agregarClase(Clase clase)
        {
            this .clases.Add(clase);
        }

        public void establecerDescripcion(string descripcion)
        {
            this.descripcion = descripcion;

        }

    }
    

    public class Estudiante : Persona
    {
        public int matricula;
        private int numeroUnico = 0;
        public Estudiante(string nombres, string apellidos, int edad, int matricula, int numeroUnico) : base(nombres, apellidos, edad)
        {
            this.matricula = matricula;
            this.numeroUnico = numeroUnico;
        }

        public void establecerNumeroUnuco(int numeroUnico)
        {
            if (numeroUnico == 0)
            {
                this.numeroUnico=numeroUnico;
                Console.WriteLine("El numero : "+numeroUnico+", se ha establecido como numero unuco");
            }
            else
            {
                Console.WriteLine("Ya tiene numero unico, el cual es: "+numeroUnico);
            }
        }
    }

    public class Profesor : Persona
    {
        private int id;
        public List<Curso> cursos;
        public Profesor(string nombres, string apelliidos, int edad, int id) : base(nombres, apelliidos, edad)
        {
            this.id = id;

        }

        public void añadirCurso(Curso curso)
        {
            cursos.Add(curso);
        }        
    }

    public class Clase
    {
        public string identificador;
        protected int id;
        private List<Estudiante> estudiantes;
        private List<Profesor> profesores;

        public Clase(string identificador, int id)
        {
            this.identificador = identificador;
            this.id = id;
        }

        public void  añadirEstudiante(Estudiante estudiante)
        {
            estudiantes.Add(estudiante);
        }

        public void añadirProfesor(Profesor profesor)
        {
            profesores.Add(profesor);
        }
    }

    public class Curso
    {
        string nombre;
        public List <Clase> clases;
        public List<string> recuentoClases;
        public List<string> recuentoEjercicios;
        
        public Curso(string nombre)
        {
            this.nombre = nombre;
        }

        public void agregarClase(Clase clase)
        {
            clases.Add(clase);
        }

        public void agregarReceuntoClase(string recuento)
        {
            recuentoClases.Add(recuento);
        }

        public void agregarReceuntoEjercicio(string recuento)
        {
            recuentoClases.Add(recuento);
        }
    }

}
