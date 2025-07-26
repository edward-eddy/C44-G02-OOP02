namespace Demo.Binding
{
    internal class PartTimeEmployee : Employee
    {
        public double HourRate { get; set; }
        public int NumberOfHours { get; set; }


        public new void Fun01()
        {
            Console.WriteLine("I am Full Time Employee");
        }
        public override void Fun02()
        {
            Console.WriteLine($"Salary : {HourRate * NumberOfHours}");
        }
    }
}
