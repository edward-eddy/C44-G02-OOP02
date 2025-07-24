namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Class VS. Struct
            // Class ---------------------- VS. ------------------> Struct

            // Reference Type ------------------------------------> Value Type
            // Uses all 4 Pillers of OOP -------------------------> Uses All But Inheritance
            // Have a default constructor ------------------------> structs do not have a default constructor
            // new Keyword creates the object --------------------> Choose the Constructor
            // Has a Default Constructor -------------------------> The default constructor is called implecetly by the compiler 
            // Default constructor does nothing ------------------> Initialize the attributes and assigns the Default Values
            // User Defined Constructor replaces the default -----> Only The Parameterless replaces the default
            // ??????? You cant def
            // All Six Access Modifires --------------------------> Private, Internal, Public
            #endregion

            #region 2. Inheritance
            // 2. Inheritance : 
            // X --> Y
            // DRY 

            //Parent parent = new Parent(1,2);

            //Console.WriteLine(parent);

            //parent.Fun01();
            //parent.Fun02();

            //Child child = new Child(1,2,3); 

            //child.Fun01();
            //child.Fun02(); 
            #endregion

        }
    }
}
