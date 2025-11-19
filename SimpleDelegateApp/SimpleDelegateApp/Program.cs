namespace SimpleDelegateApp
{

    delegate void DPrintMessage(string name);

    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();

            //CaseStudy2();

            PrintWizard(ShutdownComputer);

        }
        static void ShutdownComputer(string name) {
           
            Console.WriteLine("shutting down the computer ");
            Console.WriteLine(name);
        }
        static void SendAnEmail(string name) {
            //your atual code to send email
            Console.WriteLine("sending email notfication for "+name);
        }
        static void PrintWizard(DPrintMessage fnPtrCallbck) //polymorphic
        {
            Console.WriteLine("inside printwizard..");
            Console.WriteLine("doing some printing operation and notify you once done");

            fnPtrCallbck("WORK DONE PrintWizard");
        }
        private static void CaseStudy2()
        {
            var fnPointer = new DPrintMessage(PrintGoodBye);//null pointer
                                                            // fnPointer =  PrintGoodBye;//object of delegate
            fnPointer += PrintHello;
            fnPointer += PrintGoodBye;

            fnPointer("CHAMP");
        }

        private static void CaseStudy1()
        {
            DPrintMessage fnPointer;//expects a function with same signature
            fnPointer = PrintGoodBye;//address or name of funciton
            fnPointer("Emerson");

            fnPointer = PrintHello;
            fnPointer("Krishna");

           // fnPointer = Foo;
        }

        static void PrintGoodBye(string name) {

            Console.WriteLine($"GoodBye says {name}");
        }
        static void PrintHello(string name) {

            Console.WriteLine($"Hello says {name}");
        }
        static void Foo() { 
        
        }
    }
}
