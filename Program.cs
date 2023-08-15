namespace oop_vazifa_3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.CalculatePerimeter();
            rectangle.CalculateDiagonal();
            rectangle.CalculateArea();

            Circle circle = new Circle();
            circle.CalculatePerimeter();
            circle.CalculateArea();
            
        }
    }
    class Rectangle
    {
        public int Hight { get; set; }
        public int Width { get; set; }
        public Rectangle()
        {
            Width = 0;// boshlang'ich qiymat sifatida qabul qilinadi
            Hight = 0;

        }
        public void CalculatePerimeter()
        {
            int Perimeter = 2*(Hight + Width);
            Console.WriteLine( Perimeter);
        }
        public void CalculateArea()
        {
            Console.WriteLine(Hight*Width);
        }
        public void CalculateDiagonal()
        {
            float diagonal = (float)Math.Sqrt(Width*Width + Hight*Hight);
            Console.WriteLine(diagonal);
        }
    }
    class Circle
    {
        public double Radius { get; set; }
        public Circle()
        {
            Radius = 0;// boshlang'ich qiymat sifatida qabul qilinadi
        }
        public void CalculatePerimeter()// peremetri l uzunligi
        {
            Console.WriteLine(2*Math.PI*Radius);

        }
        public void CalculateArea()// yuzi
        {
            Console.WriteLine(Math.PI*Radius*Radius);

        }
    }
}