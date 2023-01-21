

namespace Fast_Food_Builder._Pizza
{
    public class Pizza
    {

        private string? Bread;
        private int SizeInch;
        private string? Sauce;
        private string? Cheese;
        private string? Protein;
        private string? Vegetable;
        private string? PizzaName;
        private string? Description;


        public void SetDescription(string Description)
        {
            this.Description = Description;
        }
        public void SetBread(string bread)
        {
            this.Bread = bread;
        }
        public void SetSizeInch(int sizeInch)
        {
            this.SizeInch = sizeInch;
        }
        public void SetSauce(string sauce)
        {
            this.Sauce = sauce;
        }
        public void SetCheese(string cheese)
        {
            this.Cheese = cheese;
        }
        public void SetProtein(string protein)
        {
            this.Protein = protein;
        }
        public void SetVegetable(string vegetable)
        {
            this.Vegetable = vegetable;
        }
        public void SetPizzaName(string pizzaName)
        {
            this.PizzaName = pizzaName;
        }




        public string GetDescription()
        {
            return Description;
        }
        public string GetBread()
        {
            return Bread;
        }
        public int GetSize()
        {
            return SizeInch;
        }
        public string GetSauce()
        {
            return Sauce;
        }
        public string GetCheese()
        {
            return Cheese;
        }
        public string GetProtein()
        {
            return Protein;
        }
        public string GetVegetable()
        {
            return Vegetable;
        }
        public string GetPizzaName()
        {
            return PizzaName;
        }

        public void Display()
        {
            Console.WriteLine($"Pizza Name: {PizzaName}");
            Console.WriteLine("======================================");
            Console.WriteLine($"Bread: {Bread}");
            Console.WriteLine($"Sauce: {Sauce}");
            Console.WriteLine($"SizeInch: {SizeInch}");
            Console.WriteLine($"Cheese: {Cheese}");
            Console.WriteLine($"Protein: {Protein}");
            Console.WriteLine($"Vegetable: {Vegetable}\n");
            Console.WriteLine($"Description: {Description}");



        }
    }
}




/*public override string ToString()
 {
            
  return String.Format($"Bread: {Bread}, Sauce: {Sauce}, SizeInch: {SizeInch}, Cheese: {Cheese}, Protein: {Protein}, Vegetable: Vegetable");
            
}*/

/*Console.WriteLine("1- Thin Crust");
        Console.WriteLine("2- Thick Crust");


        Console.WriteLine("Which Type of Bread would you like to have?");
        int ans = int.Parse(Console.ReadLine());

        switch (ans)
        {
            case 1:
                Bread = "Thin Crust";
                break;
            case 2:
                Bread = "Thick Crust";
                break;
        }
        return this;*/



/*Console.WriteLine("1- 10\"");
Console.WriteLine("2- 12\"");
Console.WriteLine("3- 14\"");

Console.WriteLine("Which Size of Pizza would you like to have?");
int ans = int.Parse(Console.ReadLine());

switch (ans)
{
    case 1:
        SizeInch = 10;

        break;
    case 2:
        SizeInch = 12;
        break;
    case 3:
        SizeInch = 14;
        break;
}
return SizeInch;*/


/*Console.WriteLine("1- BBQ Sauce");
Console.WriteLine("2- Pizza Sauce");
Console.WriteLine("3 - Not Apply");

Console.WriteLine("Which Type of Sauce would you like to have?");
int ans = int.Parse(Console.ReadLine());

switch (ans)
{
    case 1:
        Sauce = "BBQ Sauce";
        break;
    case 2:
        Sauce = "Pizza Sauce";
        break;
    case 3:
        Sauce = "Not Apply";
        break;
}
return Sauce;*/


/*Console.WriteLine("1- Mozzarella");
Console.WriteLine("2- Parmesan");
Console.WriteLine("3 - Not Apply");

Console.WriteLine("Which Type of Cheese would you like to have?");
int ans = int.Parse(Console.ReadLine());

switch (ans)
{
    case 1:
        Cheese = "Mozzarella";
        break;
    case 2:
        Cheese = "Parmesan";
        break;
    case 3:
        Cheese = "Not Apply";
        break;
}
return Cheese;*/




/*Console.WriteLine("1- Bacon");
Console.WriteLine("2- Chicken");
Console.WriteLine("3- Pepperoni");
Console.WriteLine("4- Sausage");
Console.WriteLine("5- ham");
Console.WriteLine("6 - Not Apply");

Console.WriteLine("Which Type of Protein would you like to have?");
int ans = int.Parse(Console.ReadLine());

switch (ans)
{
    case 1:
        Protein = "Bacon";
        break;
    case 2:
        Protein = "Chicken";
        break;
    case 3:
        Protein = "Pepperoni";
        break;
    case 4:
        Protein = "Sausage";
        break;
    case 5:
        Protein = "ham";
        break;
    case 6:
        Protein = "Not Apply";
        break;
}
return Protein;*/






/*Console.WriteLine("1- Green Pepper");
Console.WriteLine("2- Hot Pepper");
Console.WriteLine("3- Onions");
Console.WriteLine("4- Tomatoes");
Console.WriteLine("5- Black Olives");
Console.WriteLine("6- Mushrooms");
Console.WriteLine("7- Lettuce");
Console.WriteLine("8- Cucumbers");
Console.WriteLine("9- Pickle");
Console.WriteLine("10 - Not Apply");



Console.WriteLine("Which Type of Vegetable would you like to have?");
int ans = int.Parse(Console.ReadLine());

switch (ans)
{
    case 1:
        Vegetable = "Green Pepper";
        break;
    case 2:
        Vegetable = "Hot Pepper";
        break;
    case 3:
        Vegetable = "Onions";
        break;
    case 4:
        Vegetable = "Tomatoes";
        break;
    case 5:
        Vegetable = "Black Olives";
        break;
    case 6:
        Vegetable = "Mushrooms";
        break;
    case 7:
        Vegetable = "Lettuce";
        break;
    case 8:
        Vegetable = "Cucumbers";
        break;
    case 9:
        Vegetable = "Pickle";
        break;
    case 10:
        Vegetable = "Not Apply";
        break;
}
return Vegetable;*/





