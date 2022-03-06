using System;

namespace privat_modificator
{

     class Modificator
    {
        string privateS = "private";
        // have acces only this class
        private string privateS2 = "2 private";

        // have access this class and inharited class this solution
        private protected string privateProtectedS = "private protected s";
        
        // have access this class inharited class this solution and inharited  class another solution
        protected string protectS = "protected s";

        // have access this class inharited class this solution and any class this solutions
        internal string internS = "internal s";

        //have access this class inharited class this solutions any  calass this solutions and inharited class another solutions
        protected internal string protectedInternalS = "protected internak s";

        public string publicS = "public s";

        void Print() => Console.WriteLine(privateS);

        private void privatePrint() => Console.WriteLine(privateS2);

        private protected void privateProtectedPrint() => Console.WriteLine(privateProtectedS);

        protected void protectedPrint() => Console.WriteLine(protectS);

        internal void internalPrint() => Console.WriteLine(internS);

        protected internal void protectedInternalPrint() => Console.WriteLine(protectedInternalS);

        public void publicPrint() => Console.WriteLine(publicS);
        
    
    
    
    }

    class A
    {

        public void PrintModifikcator()
        {
            Modificator f = new Modificator();

            Console.WriteLine(f.internS);
            Console.WriteLine(f.protectedInternalS);
            Console.WriteLine(f.publicS);



        
        
        }




        
      
       
       


    
    
    
    
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
