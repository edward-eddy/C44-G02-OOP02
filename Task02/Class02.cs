using ClassLibrary1;

namespace Task02
{
    // Different Assembly, Derived Class
    // "public" is accessable
    // "protected" and "internal protected" are accessable
    internal class Class02 : ClassLib01
    {
        public void Fun02()
        {
            Class02 class02 = new Class02();

            class02.Public();
            //class02.Private();
            //class02.Internal();

            class02.JustProtected();
            //class02.PrivateProtected();
            class02.InternalProtected();


        }
    }
}
