using System;
using Mcdoproject.FACTORIES;

namespace Mcdoproject
{
    public class Program
    {
     
        public static void Main()
        {
            char ans;
            int number;
            do
            {
                McdoMenu:
                do
                {
                    Console.WriteLine(" Please select your choices from the Menu: ");
                    Console.WriteLine("  1)Pizza ");
                    Console.WriteLine("  2)Sandwich ");
                    Console.WriteLine("  3)Drink ");
                    Console.WriteLine(" 4)Aliclub ");
                   
                    string input = Console.ReadLine();
                    Int32.TryParse(input, out number);
                    if(number<1 || number > 4)
                    {
                        Console.WriteLine(" Invalid selection ");
                    }

                } while (number < 1 || number > 4);
                
          
            switch (number)
                {
                    case 1:
                        //Pizza
                        Console.WriteLine(" looks like you selected Pizza");
                        Console.WriteLine(" Please select one of the following for the type of pizza topings");
                        string toping = Console.ReadLine();
                        int top;
                        Int32.TryParse(toping, out top);

                        switch (top)
                        {
                            case 1://1 toping
                                Abstractfactory factory = Abstractfactory.factorymethod(TypeMenu.PIZZAFACTORY);
                                factory.MakeVeggy("tomato").Buy();
                                factory.MakeVeggy("tomato").Eat();
                                break;
                            case 2:// 2 toping
                                Abstractfactory factory1 = Abstractfactory.factorymethod(TypeMenu.PIZZAFACTORY);
                                factory1.MakeHawaian(" tomato ", "onion").Buy();
                                factory1.MakeHawaian(" tomato ", "onion").Eat();
                                break;
                            case 3://3 toping
                                Abstractfactory factory2 = Abstractfactory.factorymethod(TypeMenu.PIZZAFACTORY);
                                factory2.MakeAliclub(" tomato ", "onion", "chicken").Order();
                                factory2.MakeAliclub(" tomato ", "onion", "chicken").Eat();
                                break;
                        }
                        break;
                    case 2://Sandwich
                        Console.WriteLine(" looks like you selected Sandwich");
                        Console.WriteLine(" Please select type of sandwich:");
                        Console.WriteLine("1)Veggy 2)Hawaian 3)Aliclub");
                        string sandwich = Console.ReadLine();
                        int type;
                        Int32.TryParse(sandwich, out type);
                        switch (type)
                        {
                            case 1://1 veggy
                                Abstractfactory factory = Abstractfactory.factorymethod(TypeMenu.SANDWICHFACTORY);
                                factory.MakeVeggy("tomato").Buy();
                            
                                break;
                            case 2:// 2 Hawaian
                                Abstractfactory factory1 = Abstractfactory.factorymethod(TypeMenu.SANDWICHFACTORY);
                                factory1.MakeHawaian(" tomato ", "onion").Buy();
                           

                                break;

                            case 3://3 Aliclub
                                Abstractfactory factory2 = Abstractfactory.factorymethod(TypeMenu.SANDWICHFACTORY);
                                factory2.MakeAliclub(" tomato ", "onion", "chicken").Order();
                             
                                break;
                        }
                        break;
                    case 3://drink
                        Console.WriteLine(" looks like you selected Drink");
                        Console.WriteLine(" Please select type of drink:");
                        Console.WriteLine("1)Veggy 2)Hawaian 3)Aliclub");
                        string drink = Console.ReadLine();
                        int choice;
                        Int32.TryParse(drink, out choice);
                        switch (choice)
                        {
                            case 1://1 veggy
                                Abstractfactory factory = Abstractfactory.factorymethod(TypeMenu.DRINKFACTORY);
                                factory.MakeVeggy(" pepsi").Buy();
                                factory.MakeVeggy(" pepsi").Eat();
                                break;
                            case 2:// 2 Hawaian
                                Abstractfactory factory1 = Abstractfactory.factorymethod(TypeMenu.DRINKFACTORY);
                                factory1.MakeHawaian(" pepsi ", "canadadry").Buy();
                                factory1.MakeHawaian(" pepsi ", "canadadry").Eat();

                                break;

                            case 3://3 Aliclub
                                Abstractfactory factory2 = Abstractfactory.factorymethod(TypeMenu.DRINKFACTORY);
                                factory2.MakeAliclub("pepsi ", "water", "canadadry").Order();
                                factory2.MakeAliclub("pepsi ", "water", "canadadry").Eat();
                                break;

                        }
                        break;
                    case 4://Sidedish
                        Console.WriteLine(" looks like you selected Sidedish");
                        Console.WriteLine(" Please select type of sidedish:");
                        Console.WriteLine("1)Veggy 2)Hawaian 3)Aliclub");
                        string sd = Console.ReadLine();
                        int option;
                        Int32.TryParse(sd, out option);
                        switch (option)
                        {
                            case 1://1 veggy
                                Abstractfactory factory = Abstractfactory.factorymethod(TypeMenu.SIDEDISHFACTORY);
                                factory.MakeVeggy(" frites ").Buy();
                                factory.MakeVeggy(" frites ").Eat();
                                break;
                            case 2:// 2 Hawaian
                                Abstractfactory factory1 = Abstractfactory.factorymethod(TypeMenu.SIDEDISHFACTORY);
                                factory1.MakeHawaian(" frites ", "salade").Buy();
                                factory1.MakeHawaian(" frites ", "salade").Eat();
                                break;
                            case 3://3 Aliclub
                                Abstractfactory factory2 = Abstractfactory.factorymethod(TypeMenu.SIDEDISHFACTORY);
                                factory2.MakeAliclub(" frites ", "salade", "poutine").Order();
                                factory2.MakeAliclub(" frites ", "salade", "poutine").Eat();
                                break;
                        }
                        break;
                }
                Console.WriteLine(" would you like to see the menu again:(Y/N)?");
                ans = Char.ToLower(Convert.ToChar(Console.ReadLine()));
                if(ans == 'Y' || ans == 'y')
                {
                    goto McdoMenu;
                }
            } while (number < 1 || number > 4);
        }
    }
}

