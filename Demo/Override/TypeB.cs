namespace Demo.Override
{
    internal class TypeB : TypeA
    {
        public int B { get; set; }

        // override or Hide
        // apply override
        // 1. Apply override using "new" Keyword ()
        // 2. Apply override using "override" Keyword


        // Static Binding
        // Compilier Will Bind Function Based on Reference Type Not The Object Type
        public new void Fun01() //using "new" Keyword
        {
            Console.WriteLine("Fun01 From TypeB");
        }

        // Dynamic Binding
        // CLR Will Bind The Function Call Based on Object Type Not The Reference Type
        // At The Runtime
        // Must be Not Private and Virtual
        public override void Fun02() // using "override" Keyword
        {
            Console.WriteLine($"A : {A}, B : {B}");
        }







    }
}
