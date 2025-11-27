namespace montecarlo_theorem
{
    internal class Program
    {

        static void Main(string[] args)
        {
            double area = 0;
            int inside_counter=0, outside_counter=0;
            int x = 0;
            int y = 0;
            Random rnd = new Random();  
            Console.WriteLine("insert lenght of rectangle");
            int lenght=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("insert height of rectangle");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("insert the number of throws");
            int throws = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < throws; i++) {

                x=rnd.Next(lenght); 
                y=rnd.Next(height);
                if (x >= lenght / 2)
                {
                    inside_counter++;
                }
                else if (x <= lenght / 2)
                {
                    outside_counter++;
                }           
            }
            area = (inside_counter / throws) * (height * lenght);
            Console.WriteLine("the area of the second smaller reactangle is " + area);

        }
    }
}
