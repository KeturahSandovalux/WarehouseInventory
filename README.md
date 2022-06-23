# WarehouseInventory




## About Warehouse Inventory Project

**Warehouse Inventory Project acts as a database to store items as if a company is storing a list of items
in a warehouse and need to keep track of their inventory.** 

## What Can Users Do 

- Allows the user to keep track of the amount of inventory items
- User can add new items with:
                 1. *An item identification number*
                 2. *A description of the item*
                 3. *The price to customers per item*
                 4. *How much or the quantity the company has in inventory*
                 5. *The cost of the item at wholesale per item*
                 6. *The total value of all items in inventory (PricePerItem * Quanity = the total value) - this is calculated in the program without the users help*
     
- User can change any of the attributes of the item, but not the item # becuase it defines the actual items lookup
- User can delete an item using the item # to delete an entire record
- User can see a list of all the items added to the inventory with all current changes
- User can also choose to quit the program/ exit the console application

## How It Works (Code Explanation)

### Start of Program Breakdown
1. A structure called ItemData is added to create all data typesvthat will be used to make a record.
2. The program then defines a variable to keep track of the number of items in the array.
3. The array is created and initialized with a total of 30 index spaces (or 30 - 1 as the array starts at 0)
4. A for loop is then added to cycle through the array as long as the number of items (30) isn't maxed out as the array cannot hold more than what was initialize or it will need to be copied to new array.
5. The number of items is assigned a value of the array length (or get the array length #)
6. A WELCOME to the user is printed
7. Then, a while true staement is added to always show the main menu options when a action is completed. 
8. A lot of blank lines are added for spacing and readability
9. Main Menu is printed to user with options 1 - 5, user is asked to pick one
10. Users input is parsed or converted into a variable that we can use, which then leads to a Switch statement using that variable. 

### Case 1, if chosen by user
1. This case is used to add an item
2. [ please refer to comments in code for further breakdown of code]

### Case 2, if chosen by user
1. This case is used to change an items attributes in a record based on the previously inputted data - based on the struct ItemData
[ please refer to comments in code for further breakdown of code]

### Case 3 if chosen by user
1. This case is used to delete an item from the entire inventory, eliminating it from the array and inventory entirely 
[ please refer to comments in code for further breakdown of code]

### Case 4, if chosen by user
1. This case is used to list all of the current items in the inventory with all changes current and all deleted items gone (this is a good way to confirm the program has made the necessary changes)
2. The list is formatted to look presentable for the user. I used lines on each side of the data to make a table when the list is shown. Even console apps can look kinda pretty. 
[ please refer to comments in code for further breakdown of code]

### Case 5, if chosen by user
1. This case is used to quit the program
2. The user is first asked if they want to quit, as they could have accidently chosen case 5 and may accidently loose all their data
3. If the user inputs y for "yes" the if staement used executes a nifty c# .NET commant called Environment.Exit (0); (this was a hard one to figure out)
4. If the user inputs n for "no" the progam then prints that the user has returned to the main menu and the program continues to the main menu loop. 

### Default, if none chosen by user
1. Console prints the words that user has chosen an invalid option. 
2. Then, cycles back to the Main Menu loop at the top after the break;


## What I Would Change
- [ ] A lot of blank lines are added for design and spacing which probably could be made into a method so it is shorter and takes up less space/ bits. 
- [ ] I really wanted to add error protection when the user inputs a item number that has already been chosen. Right now it just takes the user back to the main menu after telling them the item was already added, but I want it to allow the user to keep trying until they find a item ID that hasn't been used instead of requiring they go back to the main menu and then choose the "add Item/ case 1" option again.


