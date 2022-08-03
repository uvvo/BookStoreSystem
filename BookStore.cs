
//TOPIC: BOOK STORE
/*  Requirements: 
    Arithmetic Expression (We used ADDTION for adds the books they purchase to get a total)
    Logical Operators (We used LOGICAL OR ||  for buyer info)
    Relational Operators (We used LESS THAN for initialization if the variable i < BookTitle. EQUAL TO  for BookName == BookTitle)
    Exception Handling (We used TRY, CATCH for FormatException) 
    Classes (We applied CLASS name Book Store to assign the item a category.)
    Methods (We declare methods DISPLAY INTRO for Book items. SELLING ITEMS for making a choice items. DISPLAYORDERTOTAL for total item buy. 
             SEARCHING for search books title. DISPLAYOUTRO to exit the program. DISPLAYINFO for buyer info)
    Arrays (Using Array to organize, and operate the title of the books.)
    Any iteration (Using the IF ELSE to identify the book if avalable, or not avalable. Using the FOR LOOP to search the title book.)
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BookStore
{
    class BookStore //CLASS NAME

    {
        private decimal OrederTotal; //CALCULATE TOTAL BUY
        public BookStore()
        {
            OrederTotal = 0m;
        }
        public void Run() // FOR FUNCTION EACT METHOD WE USED
        {
            ForegroundColor = ConsoleColor.White ;

            DisplayIntro();
            WriteLine();

            DisplayInfo();
            WriteLine();

            SellingItem("The Vince COde, The.", 9.17m);
            WriteLine();

            DisplayOrdertotal();
            WriteLine();

            SellingItem("Fifty Shades of Grey.", 9.9m);
            WriteLine();

            DisplayOrdertotal();
            WriteLine();

            SellingItem("365 Days.", 12.09m);
            WriteLine();

            DisplayOrdertotal();
            WriteLine();

            SellingItem("The Sleeping Beauty trilogy.", 6.18m);
            WriteLine();

            DisplayOrdertotal();
            WriteLine();

            SellingItem("Tropic of Cancer.", 5.15m);
            WriteLine();

            DisplayOrdertotal();
            WriteLine();

            SellingItem("Follow Me DARKLY.", 8.3m);
            WriteLine();

            DisplayOrdertotal();
            WriteLine();

            SellingItem("And Playing The Role Of Herself.", 7.8m);
            WriteLine();

            DisplayOrdertotal();
            WriteLine();

            SellingItem("Bored To You.", 11.12m);
            WriteLine();

            DisplayOrdertotal();
            WriteLine();

            SellingItem("The Surrender.", 4.13m);
            WriteLine();

            DisplayOrdertotal();
            WriteLine();

            SellingItem("One Night Promised.", 18.19m);
            WriteLine();

            DisplayOrdertotal();
            WriteLine();

            Searching();
            WriteLine();

            DisplayOutro();
            WriteLine();


        }
        private void DisplayIntro() //BOOK ITEMS
        {

            WriteLine("\t\t=====================================================================================");
            WriteLine("\t\t===================================BOOK ITEMS========================================");
            WriteLine();
            WriteLine("\t\t====== 1. The Vince Code, The. ================= Author: Brown Dan===================");
            WriteLine();
            WriteLine("\t\t====== 2. Fifty Shades of Grey. ================ Author: E.L James ==================");
            WriteLine();
            WriteLine("\t\t====== 3. 365 Days. ============================ Author: Blanka Lipinska=============");
            WriteLine();
            WriteLine("\t\t====== 4. The Sleeping Beauty trilogy. ========= Author: Anne Rice ==================");
            WriteLine();
            WriteLine("\t\t====== 5. Tropic of Cancer. ==================== Author: Henry Miller ===============");
            WriteLine();
            WriteLine("\t\t====== 6. Follow Me DARKLY. ==================== Author: helen Hardt=================");
            WriteLine();
            WriteLine("\t\t====== 7. And Playing The Role Of Herself. ===== Author: K.E Lane ===================");
            WriteLine();
            WriteLine("\t\t====== 8. Bored To You. ======================== Author: sylvia Day  ================");
            WriteLine();
            WriteLine("\t\t====== 9. The Surrender. ======================= Author: Melody Anne ================");
            WriteLine();
            WriteLine("\t\t======10. One Night Promised. ================== Author: Jodi Ellen Malpas ==========");
            WriteLine("\t\t=====================================================================================");

        }

        private void DisplayInfo() //BUYER INFO
        {
            Console.WriteLine("What is your name:");
            string Name = Console.ReadLine();
            Console.WriteLine("How old are you:");
            int Age = Convert.ToInt32(Console.ReadLine());
            
            if (Age <= 17 || Name == "")
            {
                Console.WriteLine("Bawal kapa bumili, balik kana lang pag 18 kana!");
                WriteLine("Thank you for coming to the Book Store!");
                WriteLine("Press Ctrl + Break key to exit...");
                ReadKey();
                Console.ReadLine();
            }
            
        }

        private void SellingItem(string itemName, decimal cost) //SELLING ITEMS
        {
            WriteLine();
            WriteLine($"Do you want to purchase an {itemName} for {cost}? (y/n)");
            string response = ReadLine().ToUpper();

            if (response.StartsWith("Y"))
            {
                WriteLine("How many do you want?");
                string numResponse = ReadLine();
                try
                {
                    int qty = Convert.ToInt32(numResponse);
                    decimal itemTotal = cost * qty;
                    OrederTotal += itemTotal;
                    WriteLine($"Okay,{qty }x {itemName} is going to be {itemTotal:C2}...");
                }
                catch (FormatException)
                {
                    WriteLine("That wasn't a number... please try Again! ");
                    SellingItem(itemName, cost);
                    return;
                }
                catch (OverflowException)
                {
                    WriteLine("That number was too high or low... please try Again! ");
                    SellingItem(itemName, cost);
                    return;
                }
            }
            else
            {
                WriteLine($"Anyway, you didn't want an {itemName}.");
            }
        }
        private void DisplayOrdertotal() //TOTAL ITEM BUY
        {
            ConsoleColor previousColor = ForegroundColor;
            ForegroundColor = ConsoleColor.Blue;
            WriteLine($">Your current order total is:{OrederTotal:C2}.");
            ForegroundColor = previousColor;
        }

        private void Searching()     //SEARCHING USING ARRAY
        { 
            String[] BookTitle = { "The Vince Code, The",
                                   "Fifty Shades of Grey",
                                   "365 Days",
                                   "The Sleeping Beauty trilogy",
                                   "Tropic of Cancer",
                                   "Follow Me DARKLY",
                                   "And Playing The Role Of Herself",
                                   "Bored To You",
                                   "The Surrender",
                                   "One Night Promised",
                                                         };

            Console.WriteLine("\t\tSearch for the desired title");
            WriteLine();
            Console.WriteLine("\t\tEnter Book title:");
            string BookName = Console.ReadLine();
            
            bool contains = false;
            for (int i=0; i < BookTitle.Length; i++ )
            {
                if (BookName == BookTitle[i] )
                {
                    contains = true;
                }
            }

            if (contains == true)
            {
                Console.WriteLine("\t\tThe Book is Avalable");
            }
            else
            {
                Console.WriteLine("\t\tThe Book is not Avalable");
               
            }
        }
        private void DisplayOutro() //EXIT
        {
            WriteLine("Thank you for coming to the Book Store!");
            WriteLine("Press any key to exit...");
            ReadKey(); 
        }

    }
}
