namespace Demo.Override
{
    internal class TypeA
    {
        public int A { get; set; }

        public void Fun01()
        {
            Console.WriteLine("Fun01 From TypeA");
        }
        // Must be Not Private and Virtual
        public virtual void Fun02()
        {
            Console.WriteLine($"A : {A}");
        }
    }
}
