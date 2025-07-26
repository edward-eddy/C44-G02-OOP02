namespace Demo
{

    class Order
    {
        public Item[] Items { get; set; }
    }
    class Item { }

    class Room
    {
        public Wall Wall { get; set; }
        public Chair[]? Chairs { get; set; }
    }
    class Wall { }
    class Chair { }
    internal class Program
    {

        #region Sum Function Overloading
        static int Sum(int X, int Y)
        {
            return X + Y;
        }
        static int Sum(int X, int Y, int Z)
        {
            return X + Y + Z;
        }
        static double Sum(double X, double Y)
        {
            return X + Y;
        }
        static double Sum(int X, double Y)
        {
            return X + Y;
        }
        static double Sum(double X, int Y)
        {
            return X + Y;
        }
        #endregion

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

            #region Inheritance
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

            #region Relationship Between Classes
            // Relationship Between Classes

            // 1. Inheritance : "is a"  Relationship [FullTimeEmployee is a Employee]
            // 2. Aggrigation : "has a" Relationship [Order has a Item]
            //   2.1. Composition : Order Has A Item, Room Has a Wall
            //   2.2. Association : Room Has a Chair 
            #endregion

            #region 3. Polymorphism

            #region Polymprphism Overview
            // 3. Polymprphism
            // 3.1. Polymorphism Methods (Functions) Overloading
            // 3.2. Polymorphism Methods (Functions) Overriding

            // Console.WriteLine(); 
            #endregion

            #region 3.1. Polymorphism Methods (Functions) Overloading
            // 3.1. Polymorphism Methods (Functions) Overloading
            // There are more than one function (in the same scope [class - struct]) these have the same Name but with different Signature
            // (Count - Type - Order) Parameters

            //Sum (1, 2);
            //Sum (1.3, 2.4);

            //Sum(1.3, 3.4);
            //Sum(); 
            #endregion

            #region 3.2. Polymorphism Methods (Functions) Overriding

            // 3.2. Polymorphism Methods (Functions) Overriding
            // There are more than one functions [in different scope] these have tha same Name and the same Signature but with different behaviour

            //TypeB typeB = new TypeB() { A = 12, B = 13 }; // Object initializer

            //typeB.A = 12;
            //typeB.B = 13;

            //typeB.Fun01();
            //typeB.Fun02();

            #endregion

            #endregion

            #region Binding
            // Binding 
            // What is Binding ?

            // ReferenceFromParent ---> OpjectOfChild

            //TypeA Ref;

            //Ref = new TypeA();
            //Ref = new TypeB();

            // Child is a Parent

            //Ref = new TypeB();

            //Ref.A = 12;
            //Ref.B = 12; // Error

            //Ref.Fun01(); // TypeA Fun01
            //Ref.Fun02(); // TypeB Fun02 because of Dynamic binding (override keyword) 
            #endregion

            #region Not Binding
            // Binding
            // ParentReference --> ChildObject

            //TypeA Ref = new TypeA();

            //Ref = new TypeB(); // Binding

            //TypeB Ref = new TypeB();

            //Ref = new TypeA(); // Error

            // Child is a Parent

            // Animal --> Dog : Dog is a Animal
            // Dog --> (Dog) Animal : Animal is not a Dog

            //TypeA Ref = new TypeA();
            // Ref = new TypeB();

            //TypeB typeB = (TypeB) Ref; // Not Binding 
            #endregion






        }
    }
}
