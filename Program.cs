using System;

namespace H.W_7__02._02_
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Write your ID: ");
            int ID = int.Parse(Console.ReadLine());

            Console.Write("Write FirstName: ");
            string FirstName = Console.ReadLine();

            Console.Write("Write LastName: ");
            string LastName = Console.ReadLine();

            Console.Write("Enter your date of birth, ex: 1995-05-05: ");
            string DateOfBirth = Console.ReadLine();

            Console.Write("Enter your weight in kg: ");
            double Weight = double.Parse(Console.ReadLine());

            Console.Write("Enter your height in cm: ");
            int Height = int.Parse(Console.ReadLine());

            Console.Write("Are you married: ");
            string MarriedStatus = Console.ReadLine();

            Console.Write("Where do you work: ");
            string Job = Console.ReadLine();
            Console.Clear();

            Server server = new Server(ID, FirstName, LastName, DateOfBirth, Weight, Height, MarriedStatus, Job);
            server.GetInfo();



        }
    }

    class Server
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string  DateOfBirth { get; set; }
        public double Weight { get; set; }
        public int Height { get; set; }
        public string MarriedStatus { get; set; }
        public string Job { get; set; }


        public Server(int Id, string FirstName, string LastName, string DateOfBirth, double Weight, int Height, string MarriedStatus , string Job)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Weight = Weight;
            this.Height = Height;
            this.MarriedStatus = MarriedStatus;
            this.Job = Job;
        }
        
        public void GetInfo()
        {
            Console.WriteLine($"FirstName: {FirstName}");
            Console.WriteLine($"LastName: {LastName}");
            Console.WriteLine($"DateOfBirth: {DateOfBirth}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Height: {Height}");
            Console.WriteLine($"MarriedStatus: {MarriedStatus}");
            Console.WriteLine($"Job: {Job}");
        }



    }
}
