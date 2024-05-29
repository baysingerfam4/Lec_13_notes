namespace Lec_13_notes
{
    internal class Program
    {
        // Carla Baysinger
        // May 28th 2024
        // Lecture 13 notes

        // Array
        // Create a FoodItem with a size of 5
        static FoodItem[] foodItems = new FoodItem[5];

        static void Main(string[] args)
        {
            PreLoad();
            FoodItem kiwi = new FoodItem("kiwi", 1, 42);
            DoubleArraySize();
            AddNewFoodItem(kiwi);

            foreach(FoodItem singleFoodItem in foodItems)
            {
                if(singleFoodItem != null)
                {
                    Console.WriteLine(singleFoodItem.DisplayFoodInformation());
                }
                
            }

        }//main
        public static void AddNewFoodItem(FoodItem newFoodItem)
        {
            // Else return error no space found
            // Loop through my food item Array


            for (int i = 0; i < foodItems.Length; i++)
            {
                // Check for an empty spot
                if (foodItems[i] == null)
                {
                    // if an empty spot is found, add to space
                    foodItems[i] = newFoodItem;
                    // You can use the return keyword in a method that is void. To leave the method
                    return;
                }
            }
            //Throw a new exception
            throw new Exception();
        }
        public static void DoubleArraySize()
        {
            int arraySize = foodItems.Length;
            int newSize = arraySize * 2;
            FoodItem[] tempArray = new FoodItem[newSize];

            for (int i = 0; i < foodItems.Length; i++)
            {
                tempArray[i] = foodItems[i];
            }

            foodItems = tempArray;
        }
        

        public static void DoubleArraySizeExample()
        {
            int ogArraySize = foodItems.Length;
            Console.WriteLine($"Original Array Size: {ogArraySize}");

            DoubleArraySize();

            int doubleArraySize = ogArraySize * 2;
            bool isArraySizeDoubled = doubleArraySize == foodItems.Length;

            if (isArraySizeDoubled)
            {
                Console.WriteLine("The array size has doubled");
                foreach (FoodItem singleItem in foodItems)
                {
                    //how do we prevent a null exception error
                    // We check to see if something is not null

                    if (singleItem != null)
                    {
                        Console.WriteLine(singleItem.DisplayFoodInformation());
                    }
                    else
                    {
                        Console.WriteLine("Item Not Found");
                    }
                }
            }
            else
            {
                Console.WriteLine("The array size did not double");
            }
        } // doublearraysizeexample
        public static void PreLoad()
        {
            // Apple 7 95 665
            foodItems[0] = new FoodItem("Apple", 7, 95);

            // Banana 4  105  420
            foodItems[1] = new FoodItem("Banana", 4, 105);

            // Chicken Breast 8  165  1320
            foodItems[2] = new FoodItem("Chicken Breast", 8, 165);

            // Broccoli 5  55  275
            foodItems[3] = new FoodItem("Broccoli", 5, 55);

            // Almonds 7  70  490
            foodItems[4] = new FoodItem("Almonds", 7, 70);

        }

        public static void ClassMethodExample()
        {
            // FoodItem() ; Default Constructor
            // New Constructor : FoodItem(string, double, double)

            FoodItem apple = new FoodItem("Apple", 7, 95);
            FoodItem noValues = new FoodItem();

            // FoodItem
            // Name
            // Qty
            // Calories
            apple.Qty = 9;

            //Console.WriteLine(apple.Name);
            //Console.WriteLine(apple.TotalCalories());
            Console.WriteLine(apple.DisplayFoodInformation());
        }

        // Talk about throwing exceptions
        // class Methods
        // Arrays
    }// class

    // create a class
    // access modifier class keyword name ( starts with an uppercase,  and is singular)
    public class FoodItem
    {
        //Fields
        public string Name;
        public double Qty;
        public double Calories;

        // Constructors
        // Name of class
        public FoodItem(string name, double qty, double calories)
        {
            // Fields = argument
            Name = name;
            Qty = qty;
            Calories = calories;
        }
        // Overloading methods
        // Overloading methods allows you to name similar methods the same name but with different parameters
        public FoodItem()
        {
            Name = "Placeholder";
            Qty = 1;
            Calories = 0;
        }
        //Methods
        // Total Calories : Return the qty * calories
        public double TotalCalories()
        {
            return Qty * Calories;
        }

        //Display Data
        // Name | Qty | Calories | Total Calories
        public string DisplayFoodInformation()
        {
            return $"{Name} | { Qty} | { Calories} | {TotalCalories}";
        }

    } // class FoodItem

}// namespace
