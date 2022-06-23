using System;

struct ItemData
{
    public string ItemNumber;
    public string Description;
    public double PricePerItem;
    public int QuantityOnHand;
    public double OurCostPerItem;
    public double ValueOfItem;
}

class Program
{
    public static void Main()
    {
        //interger to keep track of the count of items in inventory
        int numberOfItems = 0;
             
        //initializing an array to hold the item data
        var items = new ItemData[30];
        items.Initialize();

        //counter to keep track of array length
        for (int i = 0; i < numberOfItems; i++)
        numberOfItems = items.Length;


       Console.WriteLine("                 ---- WELCOME ----          ");
       

        while (true)
        {
            // asks user for choice of action
            Console.WriteLine();//blank line
            Console.WriteLine("                     MAIN MENU                       ");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Please choose/type an option number and hit 'Enter':");
            Console.WriteLine(" 1. Add an item \r\n 2. Change an items data \r\n 3. Delete an item \r\n 4. List of all items in inventory \r\n 5. Quit program");
            Console.WriteLine();//blank line
            //user inputs choice
            string userInput = Console.ReadLine();   
            var userChoice = int.Parse(userInput);

        // provides an extra blank line on screen
        Console.WriteLine();

            //based on users input choice above, a certain action/ case will execute 
            switch (userChoice)
            {

                case 1: // add an item to the list if this option is selected

                    {

                        
                        // asks user to enter item ID number 
                        Console.WriteLine("Please enter the Item ID number (3 digits):");
                        var ItemNumber = Console.ReadLine();
                        Console.WriteLine();//blank line

                        bool found = false;
                        for (int i = 0; i < numberOfItems; i++)

                            if (items[i].ItemNumber == ItemNumber)

                            {
                                Console.WriteLine(); // blank line for spacing
                                Console.WriteLine(" ------ * Oops! This Item ID is already stored! Please choose another option. * ------  ");
                                Console.WriteLine(); // blank line for spacing
                                found = true;
                                break;

                            }
                        if (!found)
                        {


                            //asks the user to enter an item description
                            Console.WriteLine("Please enter an Item Description or name:");
                            string Description = Console.ReadLine();
                            Console.WriteLine();//blank line

                            // asks the user to enter item price ($)
                            Console.WriteLine("Please enter the Item Price($) - example: ##.##:");
                            double PricePerItem = double.Parse(Console.ReadLine());
                            Console.WriteLine();//blank line

                            //ask user to enter quantity on hand
                            Console.WriteLine("Please enter the Quantity On Hand:");
                            int QuantityOnHand = int.Parse(Console.ReadLine());
                            Console.WriteLine();//blank line

                            //asks user to enter our item cost
                            Console.WriteLine("Please enter our Item Cost($) - example: ##.##:");
                            double OurCostPerItem = double.Parse(Console.ReadLine());
                            Console.WriteLine();//blank line

                            // stores the value of the item (price multiplied by quantity on hand)
                            double ValueOfItem = PricePerItem * QuantityOnHand;


                            //adds the item data into the list

                            items[numberOfItems].ItemNumber = ItemNumber;
                            items[numberOfItems].Description = Description;
                            items[numberOfItems].PricePerItem = PricePerItem;
                            items[numberOfItems].QuantityOnHand = QuantityOnHand;
                            items[numberOfItems].OurCostPerItem = OurCostPerItem;
                            items[numberOfItems].ValueOfItem = ValueOfItem;



                            //tells user which new item was added
                            Console.WriteLine(); // blank line for spacing and readability
                            Console.WriteLine("  ---- Thank you! The new Item {0} was successfully added. ---- ", ItemNumber);
                            Console.WriteLine();//blank line
                            // keeps track of array length
                            numberOfItems++;

                            break;
                            
                        }



                        break;
                       

                    }


                case 2: //change items in the list if this option is selected
                    {

                        //ask user to enter an item ID number to be changed
                        Console.WriteLine("Please enter the Item ID of the item you'd like to CHANGE (3 digits):");
                        string changeItemNumber = Console.ReadLine();
                        //int changeItemNumberTwo = int.Parse(changeItemNumber);    

                        bool fFound = false;
                        for (int x = 0; x < numberOfItems; x++)
                        {
                            //searches for the item in the list and if it is found, then will do the change
                            if (items[x].ItemNumber == changeItemNumber)
                            {
                                fFound = true;
                                Console.WriteLine(); // blank line to make readable space
                                Console.WriteLine("  --- The Item ID {0} was found --- ", changeItemNumber);
                                Console.WriteLine(); // blank line to seperate sentences
                                Console.WriteLine("Now, please select the No. option of what you'd like to change for Item ID {0}:", changeItemNumber);

                                // user asked to chooses an option, option is read and stored for the switch statement
                                Console.WriteLine(); // blank line to seperate sentences
                                Console.WriteLine(" --- OPTIONS --- \r\n 1. Description \r\n 2. Price Per Item \r\n 3. Qauntity On Hand \r\n 4. Our Cost Per Item \r\n ");
                                string choicePicked = Console.ReadLine();
                                int choiceToChange = int.Parse(choicePicked);


                                switch (choiceToChange)
                                {
                                    case 1: // to change the description of item


                                        {
                                            Console.WriteLine(); // blank line to make readable space
                                            Console.WriteLine("Please enter the new DESCRIPTION of Item ID {0} here:", changeItemNumber);
                                            string DescriptionNew = Console.ReadLine();
                                            int changeItemNumberTwo = int.Parse(changeItemNumber);
                                            // adds new description in place
                                            //items[changeItemNumberTwo].Description = DescriptionNew;
                                            items[x].Description = DescriptionNew;
                                            Console.WriteLine(); // blank line to make readable space
                                            //tells user the new data was added in place of the old
                                            Console.WriteLine("  ---- Thank you! The new DESCRIPTION: " + "'" + DescriptionNew + "'" + " for Item {0} was successfully added. ---- ", changeItemNumberTwo);
                                            break;

                                        }

                                    case 2: // to change the price of each item
                                        {
                                            Console.WriteLine(); // blank line to make readable space
                                            Console.WriteLine("Please enter the new ITEM PRICE($) of Item ID {0} here - example: ##.##:", changeItemNumber);
                                            double PricePerItemNew = double.Parse(Console.ReadLine());
                                            //int changeItemNumberTwo = int.Parse(changeItemNumber); 
                                            // adds new description in place
                                            items[x].PricePerItem = PricePerItemNew;
                                            Console.WriteLine(); // blank line to make readable space
                                            //tells user the new data was added in place of the old
                                            Console.WriteLine("  ---- Thank you! The new ITEM PRICE: " + "'$" + PricePerItemNew + "'" + " for Item {0} was successfully added. ---- ", changeItemNumber);
                                            break;
                                        }

                                    case 3: // to change the quantity of items on hand
                                        {
                                            Console.WriteLine(); // blank line to make readable space
                                            Console.WriteLine("Please enter the new QUANTITY ON HAND of Item ID {0} here:", changeItemNumber);
                                            int QuantityOnHandNew = int.Parse(Console.ReadLine());
                                            int changeItemNumberTwo = int.Parse(changeItemNumber);
                                            // adds new description in place
                                            items[x].QuantityOnHand = QuantityOnHandNew;
                                            Console.WriteLine(); // blank line to make readable space
                                            //tells user the new data was added in place of the old
                                            Console.WriteLine("  ---- Thank you! The new QUANTITY: " + "'" + QuantityOnHandNew + "'" + " for Item {0} was successfully added. ---- ", changeItemNumberTwo);
                                            break;
                                        }

                                    case 4: // to change our cost per item
                                        {
                                            Console.WriteLine(); // blank line to make readable space
                                            Console.WriteLine("Please enter our COST PER ITEM for Item ID {0} here - example: ##.##:", changeItemNumber);
                                            double OurCostPerItemNew = double.Parse(Console.ReadLine());
                                            int changeItemNumberTwo = int.Parse(changeItemNumber);
                                            // adds new description in place
                                            items[x].OurCostPerItem = OurCostPerItemNew;
                                            Console.WriteLine(); // blank line to make readable space
                                            //tells user the new data was added in place of the old
                                            Console.WriteLine("  ---- Thank you! The new COST PER ITEM: " + "'$" + OurCostPerItemNew + "'" + " for Item {0} was successfully added. ---- ", changeItemNumberTwo);
                                            break;

                                        }

                                }
                                // code to show what has to happen if the item in the list is found
                                //items[indexToChange].
                                // reset the count to show a new count for your list                           
                            }
                        }
                        if (!fFound) // if item ID No. is not found
                        {
                            Console.WriteLine(); // blank line for space
                            Console.WriteLine("--- Oops! Item {0} was NOT found ---", changeItemNumber);
                        }
                        break;

                    }


                case 3: //was delete items in the list if this option is selected

                {
                    //asks the user to enter item ID number to delete
                    Console.Write("Please enter the Item ID of the item you'd like to DELETE (3 digits):");

                    // user inputs item ID and it is stored in variable name, then converted to integer
                    string deleteItemNumber = Console.ReadLine();
                    //var indexNumToDelete = int.Parse(deleteItemNumber);
                        //"to delete" action is set to false in begnning
                        bool deleted = false;              

                        // item ID is searched and delete action is determined based on result
                        for (int x = 0; x < numberOfItems; x++)
                        {
                            if (items[x].ItemNumber == deleteItemNumber) // if item is found, will delete
                            {
                                deleted = true;           
                                   
                                items[x] = items[x + 1];
                                items.Initialize();
                                                       
                            }
                             
                        }
                    if (deleted) // tells the user that the requested item was deleted
                    {
                        Console.WriteLine();//blank line for space
                        Console.WriteLine("--- Item {0} was successfully deleted ---", deleteItemNumber);
                        // reduces by 1
                        numberOfItems--;

                        }
                    else // if did not find it, tells the user that it was not found
                    {
                         Console.WriteLine();//blank line for space
                         Console.WriteLine("           --- Item {0} not found ---       ", deleteItemNumber);
                    } 
                        
                break;

                }

            case 4:  //lists all items in the current database if this option is selected
              

                    {
                        Console.WriteLine("|Item#|  ItemID  |     Description      |  Price  |  QOH |  Cost  |  Value   |");
                        Console.WriteLine("|-----|----------|----------------------|---------|------|--------|----------|");
                        //the above line format is used as a guide forprinting or displaying the items in the list right under it

                        if (numberOfItems == 0)  // tells user if there is no items stored to list
                        {
                            Console.WriteLine();//blank line
                            Console.WriteLine(" --- [There are currently no items in this database.] ---  ");
                            Console.WriteLine();//blank line
                        }
                        
                        for (int x = 0; x < numberOfItems; x++) //goes through list
                        {
                           // formats the data on the console
                            Console.WriteLine("|{0,-5}|  {1,6}  |{2,-20}  |{3,7:c}  |{4,4}  |{5,6:c}  |{6,10:c}|", x + 1, items[x].ItemNumber, items[x].Description, items[x].PricePerItem, items[x].QuantityOnHand, items[x].OurCostPerItem, items[x].ValueOfItem);
                            Console.WriteLine("|-----|----------|----------------------|---------|------|--------|----------|");
                        }

                        break;
                    }


            case 5: //quit the program if this option is selected
                {
                    Console.Write("Are you sure that you want to quit(y/n)?");
                    string input = Console.ReadLine();
                         
                    if (input == "y")
                    {

                            Environment.Exit(0);
                    }
                    else if (input == "n")
                    {
                            Console.WriteLine();//blank line for spacing
                            Console.WriteLine("Okay, you have returned to the main menu.");
                            Console.WriteLine();//blank line for spacing
                            continue;
                    }
                    break;
                }

            default:
                    {
                        Console.WriteLine(); // blank line for spacing
                        Console.Write("Invalid Option, try again.");
                        Console.WriteLine(); // blank line for spacing
                        break;
                    }
            }
        }
    }
}
