namespace Demo.Binding
{
    internal class FullTimeEmployee : Employee
    {
        public double Salary { get; set; }


        public new void Fun01()
        {
            Console.WriteLine("I am Full Time Employee");
        }
        public override void Fun02()
        {
            Console.WriteLine($"Salary : {Salary}");
        }
    }
}
