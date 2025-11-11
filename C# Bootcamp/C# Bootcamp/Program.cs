
// To output to console, use the method Console.WriteLine();
//Console.WriteLine("Hello, World!");

//1)Output your name to the console

//To create comments, we can use 2 forward slashes '//'
// and this line of code will not run


/// Using the console ///
/// Basic Variables ///
string myString = "Hello";
int myWholeNumber = 12345;
float myDecimalNumber = 1.01f; //needs an 'f' at the end to say that it's a float
bool myBoolean = false; //Only false or true values

//2) Create a string for name and set it to your name

//3) Create an integer for age and set it to your age

//4) Create a floating number for your height in meters i.e. 1.65 meters.

//5) Create a boolean for a value that might be true or false (do you like reading?)

//You can output variables to the console
//Console.WriteLine(myString);

//6) Output your name to the console using the variable you have created
//7) Can you do the same for ints, floats and booleans?


///Basic operations with variables///
//To add numbers
// int integerA = 2
// integerA = integerA + 5;   or    integerA += 5;

//int integerB = 12
//int integerC = integerA + integerB

//8) Add 10 years to your age and write it to the console
//9) Create a variable and multiply it by 6
//10) Create a float and divide it by 2.3

//What happens when you add 2 strings together??
// string userFirstName = "John";
// string userSecondName = "Smith";

//11)What is the issue here? Fix it
//string userFullName = userFirstName + userSecondName;
//Console.WriteLine(userFullName);


///Getting Input from the console
//string userInput = Console.ReadLine();

//12) How can you write the output back into the console

//13) Improve this - if the user writes 'Banana', write back to the console 
// "You chose: Banana"

//The input from a user is always a string, even if that string is just numbers
//int userInputNumber = Convert.ToInt32(userInput); 

//14) Write to the console the number the user inputted times by 8.

//Converting to floats requires a bit more work so for the purposes of these
//Exersizes we will use strings and floats.


///Challenge///
//15) Create a simple program that asks for users first name, age, and height (in centimeters)
//and then writes to the console
//"Hi John, you are 55 years old and 165 centimeters tall. In 10 years time you will be 65"
//Use Console.WriteLine() before the Console.ReadLine() to act as a prompt. 
//The first bit is done for you

//Console.WriteLine("Enter your first name:")
//string userFirstName = Console.ReadLine();

//Challenge//
//Create a simple program that asks a user for 2 numbers
//The program should convert each string input to an integer,
//Add those 2 integers together, and print out the result

//i.e. 
//Enter first number : 
//10
//Enter second number : 
//15
//The 2 numbers added together = 25


///Conditional code (if statements)

//Sometimes you want to only happen if certain conditions are met. For this we can use if statements.

bool isThereADog = false;

if(isThereADog == true)
{
    //Console.WriteLine("Woof");
}

//You can compare strings too.

string password = "minecraft";

//16)Fix this so that "Access Granted" is outputted to the console
if (password == "roblox")
{
    Console.WriteLine("Access Granted.");
}

//17) Add some code above here to get input from the user typing in the password instead.

int howManyApples = 10;

if(howManyApples > 10)
{
   // Console.WriteLine("That's a lot of apples");
}

if(howManyApples >= 10)
{
  //Console.WriteLine("There's 10 or more apples.");
}

//18) How could you check for 4 or less apples?


//Sometimes you want to run code if the condition is NOT met.
int bananas = 23;
if (bananas > 100)
{
  //  Console.WriteLine("You have so many bananas");
}
else
{
   // Console.WriteLine("Ive seen more bananas");
}


//Sometimes you want to check multiple conditions at the same time\\
//Only one of these blocks of code will run.
if (bananas > 100)
{
   //Console.WriteLine("You have so many bananas");
}
else if (bananas > 50)
{
   //Console.WriteLine("That's a lot of bananas, but Ive seen more.");
}
else
{
   //Console.WriteLine("That's not a lot of bananas");
}


/// Challenge ///
//19) Improve your input from task #15. It should take the same input, but if the user is above 60 it should say "You are old" after the age,
////if between 18-60 it should say "You are an adult"
//if less than 18 it should say "You are a child"


///Methods - Reusable Code.

void MyMethod()
{
    Console.WriteLine("This is the code in MyMethod");
}

void MyOtherMethod()
{
    Console.WriteLine("This is the code in MyOtherMethod");
}

//20) Uncomment this
//MyMethod();

// - Allows you to Group code together in 'blocks' of logic, that perform a specific operation
// - Allows you to reuse that code, without writing it out over and over again
// - Can take 'parameters', which can change how the method might function.


//21) Create a method that prints numbers 1-5 like
//1
//2
//3
//4
//5


//Method with parameters
void RepeatWord(string word)
{
    string sentence = "You just wrote: " + word;
    Console.WriteLine(sentence);
}

void DoubleNumber(int number)
{
    int total = number * 2;
    Console.WriteLine(total);
}


//22) Create a method that prints numbers giving a starting number as a parameter
//i.e. starting at 12
//12
//13
//14
//15
//16

void HowMuchFruit(string fruit, int amount)
{
    if (amount > 100)
    {
        string output = "You have so many " + fruit; 
        Console.WriteLine(output);
    }
    else
    {
        string output = "Ive seen more " + fruit;
        Console.WriteLine(output);
    }
}


//23)Create a method that takes 2 numbers and prints out the larger number

//24)Create a method that takes 2 words and prints out the largest? hint; use .length (the '.' is like looking deeper within the variable)



































