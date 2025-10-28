//Arrays and Lists

//To Create an integer we would write
int myNumber = 10;

//To Create an array we would write
int[] myNumberArray = new int[10];
//[] at the start means it's an array
// When you want to create a new array, use the new keyword
// followed by the data type and length of the array in brackets i.e. int[10]
//When created, arrays are of a fixed length.

//The values in the array at the moment will be 
// 0,0,0,0,0,0,0,0,0,0
//Values of an array you create will be the 'default' value for that data type
//boolean - false
//float - 0f
//string - ""
//class - null

//Set a value in an array, use the 'index' of the position in the array
myNumberArray[0] = 123;
//Arrays start from 0, so an array with length 10 has indices 0-9

//Uncomment these lines to see that it is working correctly.
//Console.WriteLine("The value at index 0 is: " +myNumberArray[0]);
//Console.WriteLine("The length of the array: " + myNumberArray.Length);

//1) Create a string array of length 5 called snacks
// - assign each value in the array to a different snack i.e. chocolate, crisps
// - Output to the console one of these values




//Lists are similar to arrays, the contain a group of one type of data. 
//They are different because:
// - Not a fixed size
// - Have more functionality to add and remove items from them
// - Has more functionality to iterate and search for data.
// - Are less memory efficient.
//Use lists when you don't know the size of the data you will be working with

List<int> myNumberList = new List<int>();
//The <int> here is how we specify what type of data
// List<> is a class, so when we create one we call a constructor List<>();

//By default, the list has no length
//Console.WriteLine(myNumberList.Count);

//To add To the list - this will add the number '10' to the end of the list
myNumberList.Add(10);
//Console.WriteLine(myNumberList[0]);


//Adding more items to the list
//myNumberList.Add(11);
//myNumberList.Add(12);
//Console.WriteLine(myNumberList.Count);

// .Remove() will take the first item from the list out that matches.
//myNumberList.Remove(10);
//Console.WriteLine(myNumberList[0]);

//Removes item at index 0
//myNumberList.RemoveAt(0); 
//Finds first index containing that value
//myNumberList.IndexOf(11);
//Adds a value at specified index
//myNumberList.Insert(1, 14);


//2A) Create a list of 4 animals from smallest to biggest
////i.e ant, mouse, cat, elephant


//2B) Use .Insert() to add another 2 animals in the space that they would fit in size order.



//3) Here is a list of 5 boolean values, 4 true values and one false value
List<bool> switches = new List<bool>([true, true, false, true, true]);

//Find the index of the false value, and store it as an integer

//Use this index to remove the false value from the list using RemoveAt

//Output the length of the list to the console to show you have removed the false value


//While, For, Foreach.
//When we have a list or an array, it's useful to have code that can loop through all of the items.
//We don't need an array for a loop, so we will look at the different types of loops first

//While loop
int xCounter = 10;

//(counter > 0) is compared to like an if statement, but instead of running the code once,
//it will keep running it until this statement resolves to be false
while (xCounter > 0)
{
    xCounter -= 1;

    //Before you run this what value do you think will be the first and last to be output.
    //Console.WriteLine("Value of xCounter: " + xCounter);
}

//4) Create a while loop that adds 0.1f to a float variable each time it loops.
//The float value should start at -5, and the loop should continue until it reaches 5.
//Output something like "Value of float : X" each time the loop happens.

//5) Create a string variable called password, and a string variable called guess
// Run a while loop that compares the user guess to the password,
// if they are not the same, the loop continues and asks for another input
//if they are the same, the loop should end and  'access granted' logged to the console.

//6) Create a simple higher or lower game. Each time the user guesses,
//the game should print out 'higher' or 'lower'
//if the guess is correct, it should print out 'you win'


//For loop
//A while loop keeps happening until a certain condition is met.
//A for loop happens a certain number of times, i.e. run this loop 50 times.
//The syntax (strcuture of code) for a for loop can look a bit confusing at first
//But most of the time you will write the same code out so you will become familiar with it

//Inside of the brackets can be broken down into 3 statements
// int i = 0; - creating a variable 
// i < 10; - the condition that is checked at the start of each loop
// i++; - incrementing the variable at the end of each loop. i++ is the same as i=i+1;
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

//7) Create a for loop that loops from 20 to 30, incrementing by 2 each time
//output this to the console


///Challenges

//Improve the higher or lower game so that the player has a number of lives to guess the right number

//Allow for another user to pick the number before the game begins. Hint: you can use Console.Clear();
//to remove previous writing 

/////////////////////////////////////////

//8) Log to the console each of the continents
string[] continents = [ "Africa", "Antarctica", "Asia", "Europe", "North America", "Oceania", "South America" ];

for (int i = 0; i < continents.Length; i++)
{

}

//9) double the value of each of the numbers in the array 
int[] numbers = [1, 2, 3, 4, 5];
for (int i = 0;i < numbers.Length; i++)
{
    
}

//10) Go through the array of continents, and any that start with 'A', add to this list
// hint: you can index a string like an array.
List<string> continentsA = new List<string>();


//11) Go through the array of numbers, and find the biggest number, then print it.
int[] bigNumbers = [74918, 28471, 85647, 19395, 96230, 41029, 52734, 17847, 63825, 39582];
int biggestNumber = 0;

for (int i = 0; i < bigNumbers.Length;i++)
{

}

if(biggestNumber > 0)
{
    Console.WriteLine("The Biggest Number in the Array is : " + biggestNumber);
}


//12) Find the smallest number in the numbers array

//13) Find the range of the values (biggest - smallest) in the array

//14) Find the average (mean) of the numbers in the bigNumbers Array.

//Challenge
//Create a program in a new file, it should
//Create an empty list<string> called names
//The program should use Console.ReadLine to take user input
//Add the user input to the list, and then read it again
//hint: use a while loop
//We need some way to exit the program, so if the user types in 'end'
//the while loop should exit, and not add the name to the list
//hint: you can use 'break;' inside of a while loop to force it to stop

//At the end of the program (after user types 'end')
//Write out to the console all of the names, as a list seperated by commas
//i.e. John, Abigail, Tony, Heather, Samantha
// hint 1: use a for loop
// hint 2: you can use += to a string to add to it. 








