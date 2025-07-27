namespace ClassLibrary1
{
    // Same Assembly, Derived Class
    // "public" and "internal" are accessable
    // "protected", "internal protected" and "private protected" are accessable

    internal class ClassLib02 : ClassLib01
    {
        public void FunTest()
        {
            ClassLib02 classLib02 = new ClassLib02();

            classLib02.Public();
            //classLib02.Private();
            classLib02.Internal();

            classLib02.JustProtected();
            classLib02.PrivateProtected();
            classLib02.InternalProtected();
        }
    }


    // Same Assembly, Non-derived Class
    // "public" and "internal" are accessable
    // Only internal protected is accessable
    internal class ClassLib03
    {
        public void FunTest()
        {
            ClassLib02 classLib02 = new ClassLib02();

            classLib02.Public();
            //classLib02.Private();
            classLib02.Internal();

            //classLib02.JustProtected();
            //classLib02.PrivateProtected();
            classLib02.InternalProtected();
        }
    }
}
