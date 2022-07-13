/*Title: Online Shoping Portal to Validate name, email, password
 * Author: Ajai kumar V
 * Created at: 27/12/2021
 * Updated at: 28/12/2021
 * Reviewed by: Akshaya
 */
using System;
using System.Text.RegularExpressions;

namespace OnlineShopingWebSite
{
    class Program
    {

        static void ContentPage()
        {

            String UserName = "";
            String UserEmail = "";
            string Password = "";
        Content:
            int Option1;
            Console.WriteLine("Welcome to our OnlineShoppingApplication");

            Console.WriteLine(" ");

            Console.WriteLine(" ");

            Console.WriteLine(" 1.SignUp");

            Console.WriteLine(" 2.Login");

        Loop1:
            int UserChoice;

            Console.WriteLine("Enter Your Choice");

            bool IsValidUserChoice = int.TryParse(Console.ReadLine(), out UserChoice);

            if (IsValidUserChoice && UserChoice == 1 || UserChoice == 2)
            {
                Console.WriteLine($"User Choice is {UserChoice}");




                if (UserChoice == 1)
                {

                Loop:
                    Console.WriteLine("Enter UserName");


                    UserName = Console.ReadLine();

                    bool IsValidUserName = true;

                    for (int user = 0; user < UserName.Length; user++)
                    {
                        if ((UserName[user] >= 97 && UserName[user] <= 122) || (UserName[user] >= 65 && UserName[user] <= 96))
                        {

                        }
                        else
                        {
                            IsValidUserName = false;
                        }

                    }

                    if (IsValidUserName)
                    {
                        Console.WriteLine($"Valid Name {UserName}");
                    }
                    else
                    {
                        Console.WriteLine("Not Valid Name");
                        goto Loop;
                    }

                Email:
                    Console.WriteLine("Enter Email Id:");

                    UserEmail = Console.ReadLine();

                    bool IsValidEmail = false;

                    Regex regex = new Regex(@"^([\w\.\-]+)@([\w]+)((\.([com]){2,3})+)$");

                    if (regex.IsMatch(UserEmail))
                    {
                        IsValidEmail = true;


                    }
                    else
                    {
                        Console.WriteLine("Email is not valid");
                        goto Email;
                    }

                Password:
                    Console.WriteLine("Enter Your Password");
                    Password = Console.ReadLine();
                    string ErrorMessage = " ";
                    var input = Password;
                    ErrorMessage = string.Empty;

                    if (string.IsNullOrWhiteSpace(input))
                    {
                        throw new Exception("Password should not be empty");
                        goto Password;
                    }

                    var hasNumber = new Regex(@"[0-9]+");
                    var hasUpperChar = new Regex(@"[A-Z]+");
                    var hasMiniMaxChars = new Regex(@".{8,15}");
                    var hasLowerChar = new Regex(@"[a-z]+");
                    var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

                    if (!hasLowerChar.IsMatch(input))
                    {
                        //ErrorMessage = "Password should contain at least one lower case letter.";
                        Console.WriteLine("Password should contain at least one lower case letter.");
                        goto Password;
                    }
                    else if (!hasUpperChar.IsMatch(input))
                    {
                        //ErrorMessage = "Password should contain at least one upper case letter.";
                        Console.WriteLine("Password should contain at least one upper case letter.");
                        goto Password;
                    }
                    else if (!hasMiniMaxChars.IsMatch(input))
                    {
                        // ErrorMessage = "Password should not be lesser than 8 or greater than 15 characters.";
                        Console.WriteLine("Password should not be lesser than 8 or greater than 15 characters.");
                        goto Password;
                    }
                    else if (!hasNumber.IsMatch(input))
                    {
                        // ErrorMessage = "Password should contain at least one numeric value.";
                        Console.WriteLine("Password should contain at least one numeric value.");
                        goto Password;
                    }

                    else if (!hasSymbols.IsMatch(input))
                    {
                        //ErrorMessage = "Password should contain at least one special case character.";
                        Console.WriteLine("Password should contain at least one special case character.");
                        goto Password;
                    }
                    else
                    {
                        Console.WriteLine("Password created");

                    }




                }

                if (UserChoice == 2)
                {
                    Console.WriteLine("Enter Your Email:");
                    String Mail = Console.ReadLine();

                    Console.WriteLine("Enter Your Password:");
                    String UserPassword = Console.ReadLine();



                    if (UserEmail == Mail && UserPassword == Password)
                    {
                        Console.WriteLine("Congrats");

                        int Count = 1;




                        int[] Ids = new int[10];

                        int Select1 = 0;

                        int Select2 = 0;

                        int Select3 = 0;

                        int Select4 = 0;

                        int TotalPrice = 0;

                        String[] Names = new string[10];

                        int[] Quantities = new int[10];

                        int[] Price = new int[10];



                        int Option2 = 0;
                        int Option3 = 0;


                        while (Count == 1)
                        {
                            int PriceRate = 0;

                            Console.WriteLine("");

                            Console.WriteLine("OUR PRODUCTS");

                            Console.WriteLine("1.Books");

                            Console.Write("|Book Id|                         |Books Name|                        |Book Price|");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("  101                                  Java                                2000");
                            Console.WriteLine("  201                                  C                                   4000");
                            Console.WriteLine("  301                                  C++                                 3000");
                            Console.WriteLine("  401                                  JS                                  2500");
                            Console.WriteLine("  501                                  C#                                  4500");


                            Console.WriteLine(" ");


                            Console.WriteLine("Enter Item Id : ");
                            int ItemId = Convert.ToInt32(Console.ReadLine());
                            Ids[Select1++] = ItemId;
                            switch (ItemId)
                            {
                                case 101:

                                    Names[Select2++] = "Java";

                                    Price[Select3++] = 2000;

                                    break;

                                case 201:

                                    Names[Select2++] = "C";

                                    Price[Select3++] = 4000;

                                    break;

                                case 301:

                                    Names[Select2++] = "C++";

                                    Price[Select3++] = 3000;

                                    break;

                                case 401:

                                    Names[Select2++] = "JS";

                                    Price[Select3++] = 2500;

                                    break;

                                case 501:

                                    Names[Select2++] = "C#";

                                    Price[Select3++] = 4500;

                                    break;
                            }
                            Console.WriteLine("Enter Quantity : ");
                            int Quantity = Convert.ToInt32(Console.ReadLine());

                            Quantities[Select4++] = Quantity;




                            Console.WriteLine("Product Added To Cart ");

                            Console.Write("    |Product Id|        |Product Name|          |Product Quantity|      |Product Price|");

                            Console.WriteLine("");
                            Console.WriteLine("");
                            for (int ProductStock = 0; ProductStock < Ids.Length; ProductStock++)
                            {
                                if (Ids[ProductStock] != 0)
                                {
                                    Console.WriteLine("        " + Ids[ProductStock] + "                " + Names[ProductStock] + "                         " + Quantities[ProductStock] + "                       " + Quantities[ProductStock] * Price[ProductStock]);
                                    PriceRate = (Quantities[ProductStock] * Price[ProductStock]);
                                    Console.WriteLine(PriceRate);




                                }

                            }
                            TotalPrice += PriceRate;
                            Console.WriteLine(TotalPrice);

                            Console.WriteLine("Total Price Is : " + TotalPrice);

                            Console.WriteLine(" ");

                            Console.WriteLine(" ");










                            Console.WriteLine("Enter If you Want To Continue: Press 1");

                            Count = Convert.ToInt32(Console.ReadLine());


                        }
                    }




                }
            }
            else
            {
                Console.WriteLine("Enter Valid Choice");
                goto Loop1;

            }
            Console.WriteLine("If you want to Continue press 1:");

            bool OptionValid = int.TryParse(Console.ReadLine(), out Option1);

            if (OptionValid && Option1 == 1)
            {
                goto Content;
            }



        }
        static void Main(string[] args)
        {
            ContentPage();
        }
    }
}