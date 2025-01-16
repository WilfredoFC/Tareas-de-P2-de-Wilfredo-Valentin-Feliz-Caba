namespace Tarea1_2
{
     class Proyect
    {
         static void Main(String[] args)
         {
            Shape triangulo = new Triangle(5.2, 7.6);
            Shape rectangulo = new Rectangle(6.9, 3.1);
            Shape circulo = new Circle(8);
            Shape[] shapesDiferentes = new Shape[3];

            shapesDiferentes[0] = triangulo;
            shapesDiferentes[1] = rectangulo;
            shapesDiferentes[2] = circulo;

            double[] shapesAreas = new double[3];

            for (int i = 0; i < 3; i++)
            {
                shapesAreas[i] = shapesDiferentes[i].CalculateSurface();
                Console.WriteLine("Se añadio el valor: "+ i);
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("El area de la figura " + i + " es de: " + shapesAreas[i]);
            }
         }
    }

    public abstract class Shape
    {
        public double ancho, alto;
        public double surface;
        public Shape(double ancho, double alto) 
        {
            this.ancho = ancho;
            this.alto = alto;

        }
        public abstract double CalculateSurface();
    }

    public class Triangle : Shape
    {
        public Triangle(double ancho, double alto) : base(ancho, alto) { }
        

        public override double CalculateSurface()
        {
            surface = ancho * alto;
            return surface;
            
        }

    }

    public class Rectangle : Shape
    {
        public Rectangle(double ancho, double alto) : base(ancho, alto) { }
        

        public override double CalculateSurface()
        {
            surface = (ancho * alto)/2;
            return surface;

        }

    }

    public class Circle : Shape
    {
        public Circle(double radio) : base(radio, radio) { }
        

        public override double CalculateSurface()
        {
            surface = Math.PI*alto*ancho;
            return surface;

        }

    }

}
