namespace ClassLibrary1
{
    public class ClassLib01
    {
        public void Public() { }
        private void Private() { }
        internal void Internal() { }
        protected void JustProtected() { }
        private protected void PrivateProtected() { }
        protected internal void InternalProtected() { }


        private void PrivateFun()
        {
            ClassLib01 classLib01 = new ClassLib01();

            classLib01.Public();
            classLib01.Private();
            classLib01.Internal();

            classLib01.JustProtected();
            classLib01.PrivateProtected();
            classLib01.InternalProtected();
        }

    }
}
