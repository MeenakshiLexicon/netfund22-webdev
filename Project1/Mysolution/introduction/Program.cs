// See https://aka.ms/new-console-template for more information//

namespace Introduction
{
    class program
    {
        /* public void Show()  // declaring Methods   &  Non-static Methods
         {
             Console.WriteLine("Welcome to C#");
             Console.WriteLine("Welcome to Program");


         }


         public static void Show1()  // declaring Methods   & static Methods
         {
             Console.WriteLine("Welcome to C#");
             Console.WriteLine("Welcome to Program");


         }*/
        public static void Add(int num1,int num2)  //parameterized Methods
        {
            int result = num1 + num2;
            Console.WriteLine("Welcome to C#:" + result );
            }





            static void Main(string[] args)
        {
            // program p1 = new program();// p1 is an Object
            //p1.Show();   //call
            // program.Show1();  // in Static Methods we do not need to create object

            program.Add(1000, 200);
            program.Add(5000, 200);


            Console.ReadLine();




            //----------String--------//
            /*  Console.WriteLine("Enter your Firstname.");
            string fname = Console.ReadLine();

            Console.WriteLine("Enter your Lastname.");
            string lname = Console.ReadLine();

            Console.WriteLine("Your name is: {0} {1}" ,fname,lname); this is for showing name
            Console.ReadLine();*/

            //-----Int-----------//
            /* Console.WriteLine("Enter Firstno.");
             int num1 = int.Parse(Console.ReadLine());
             Console.WriteLine("Enter Secondno.");
             int num2 = int.Parse(Console.ReadLine());
             // Console.WriteLine("Your no is: {0} {1}", num1,num2);  this is for showing no only//
             int sum = num1 + num2;
             Console.WriteLine("Adding no is: {0}", sum);
             Console.ReadLine();*/

            /* Console.WriteLine(int.MaxValue);
             Console.WriteLine(int.MinValue);
             Console.ReadLine();

             int a = 50;
             int b = 20;
            bool c = a > b;

             Console.WriteLine(c);
             /* if (a > b)
              {
                  Console.WriteLine("boolen value is true");
              }
              else
              {
                  Console.WriteLine("boolen value is false");
              } */




        }
    }
}
