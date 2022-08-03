
namespace Customer
{
    class Customer
    {
        int id;
        string name;
        string email;
        int age;

        public void setCustomer(int id, string name, string email, int age)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.age = age;
        }
        public void getCustomer()
        {
            Console.WriteLine("Your Id is:{0}", this.id);
            Console.WriteLine("Your Name is:{0}", this.name);
            Console.WriteLine("Your Email is:{0}", this.email);
            Console.WriteLine("Your Age is:{0}", this.age);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Id:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your Email:");
            string email = Console.ReadLine();
            Console.WriteLine("Enter your Age:");
            int age = int.Parse(Console.ReadLine());

            Customer obj = new Customer();
            obj.setCustomer(id, name, email, age );
            obj.getCustomer();
            Console.ReadLine();
        }
    }
    }







        






        /* Guid Id { get; set; }
        /*public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

    }
    public static void Main(string[] args)
    {
        
        
            var customer = new Customer();
            customer.Id = Guid.NewGuid();
        void AddCustomer();

    }

            /*Console.Write("Enter Customer Name:");
            customer.Name = Console.ReadLine();


            Console.Write("Enter Customer Address:");
            customer.Address = Console.ReadLine();

            Console.Write("Enter Customer Email:");
            customer.Address = Console.ReadLine();
            customers.Add(customer);
        }*/
        
       /* void ShowCustomer()
        {

        }
        void RemoveCustomer()
        {

        }







        /*namespace Exercise -3
            {  
            class Customer
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
            public string Email { get; set; }
            public int Age { get; set; }

        }

        /*class Course
        {
           public string FirstName { get; set; }
            public string Description { get; set; }
            public string Length { get; set; }
        }

        class Product
        {
            public string ArticleNo { get; set; }
            public string ProductionName { get; set; }
        }

    }*/