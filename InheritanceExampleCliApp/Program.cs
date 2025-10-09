using System.Security.Principal;

namespace lab_2_oop_member
{
    using InheritanceExampleCliApp;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Memberapp
    {
        public static void Main(String[] args)
        {

            List<Member> memberAccounts = new List<Member>();
            var member = new Member()
            {
                MemberID = 1,
                LastName = "Smith",
                Fee = 100.0
            };

          

            int option = 0;
            do
            {
                Console.WriteLine("1.  Set Up Data");
                Console.WriteLine("2.  Display Data");
                Console.WriteLine("3.  Search by Member ID.");
                Console.WriteLine("4.  Delete Member.");
                Console.WriteLine("5.  Record Competition Result");
                Console.WriteLine("6.  Check Membership Status");
                Console.WriteLine("7.  Display Statistics");
                Console.WriteLine("8.  Exit");
                option = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine(option);
                switch (option)
                {
                    case 1:
                        {

                            break;
                        }
                    case 2:
                        {

                            break;
                        }
                    case 3:
                        {

                            break;
                        }
                    case 4:
                        {

                            break;
                        }

                    case 5:
                        {

                            break;
                        }
                    case 6:
                        {

                            break;
                        }
                    case 7:
                        {

                            break;
                        }
                    case 8:

                        Console.WriteLine("Exiting");
                        return;

                    default:
                        {
                            Console.WriteLine("option not implemented ");
                            break;
                        }
                }
            } while (option != 6);
        }
    }
}

