// See https://aka.ms/new-console-template for more information

class Emp
 {
    public static void Main(String[] args)
    {
        int Full_Time = 1;
        Random r = new Random();
        int empcheck = r.Next(0 , 2);
        if (empcheck == Full_Time)
        {
            Console.WriteLine("Emp is presnt");

        }
        else
        {
            Console.WriteLine("Emp is absent");
        }
        
    }
  }