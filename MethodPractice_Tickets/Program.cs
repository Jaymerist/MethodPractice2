namespace MethodPractice_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            int age;
            double price;

            //display menu 
            DisplayMenu();

            //input age
            age = GetSafeInt("Enter age: ");

            //determine ticket price 
            price = GetTicketPrice(age);

            //display ticket price
            Console.WriteLine($"The ticket price is {price:c}");

            Console.ReadLine();

        } //end of Main

        static int GetSafeInt(string prompt)
        {
            bool isValid = false;
            int number;
            do
            {
                try
                {
                    Console.Write(prompt);
                    number = int.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input ... please try again.");
                    number = 0;
                }
            } while (!isValid);
            return number;
        }//end of GetSafeInt

        static double GetTicketPrice(int age)
        {
           
            double price;

            if (age <= 6)
            {
                price = 0;
            }
            else if (age <= 9.8){

                price = 9.8;
            }
            else if (age <= 54)
            {
                price = 11.35;
            }
            else
            {
                price = 10;
            }
            return price;
            
        } //end of GetTicketPrice
        static void DisplayMenu()
        {
            Console.WriteLine("Select one of the following age groups");
            Console.WriteLine("Children 6 and under = FREE ($0.00)");
            Console.WriteLine("Studemts 7 to 17 = $9.80");
            Console.WriteLine("Adults 18 to 54 = $11.35");
            Console.WriteLine("Seniors 55+ = $10.00");
        }// end of DisplayMenu

    }
}