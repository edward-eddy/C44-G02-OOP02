namespace Demo.Override
{
    internal class TypeB : TypeA
    {
        public int B { get; set; }

        // override or Hide
        // apply override
        // 1. Apply override using "new" Keyword ()
        // 2. Apply override using "override" Keyword

        public new void Fun01() //using "new" Keyword
        {
            Console.WriteLine("Fun01 From TypeB");
        }

        // Must be Not Private and Virtual
        public override void Fun02() // using "override" Keyword
        {
            Console.WriteLine($"A : {A}, B : {B}");
        }







    }
}
