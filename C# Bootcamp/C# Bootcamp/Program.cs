//1. Return Methods
//2. New Script Files
//3. .ToString() and Overriding Methods
//4. Classes with Return Methods - Shopping Basket Challenge.
//5. Class Inheritance


//Return Methods.
//1 Create a method called LogLargerNumber that takes in 2 integer parameters
//'a' and 'b' and uses Console.WriteLine() to log the result (the largest of the 2 numbers)

//Using this is helpful for doing the calculation, but it doesn't store the value
//We can use a return type to give a value back from a method, instead of just logging it


int Power(int number, int power)
{
    int result = number;

    for (int i = 1; i < power; i++)
    {
       result = result * number;
    }

    return result;
}

int number = Power(10, 3);
//Console.WriteLine(number);

//2 Create a method called LargerNumber that takes 2 numbers 'a' and 'b'
//and returns the greater value.

//3 Create a method called RemoveVowels that takes a string parameter 'word'
//and returns the word without vowels

//i.e. Hippopotamus becomes Hppptms

//Hint 1 : You can use += on a string to add a character/string to it
//i.e.  "Shar" + 'k' = "Shark"

//Hint 2 : You can index a string like an array
// i.e.
// string word = "Hello"
// word[1] is 'e'


//3 Improve your method LargerNumber to take an array of integers (int[])

//4 Finish below method that takes 2 integer parameters 'start' and 'end' and returns a list of all the integers from start to end

List<int> NumberLine(int start, int end)
{
    List<int> numbers = new List<int>();


    return numbers;
}


//New Script Files

//1 There is a script called ExampleClass. Uncomment Code
//ExampleClass exampleClass = new ExampleClass();
//exampleClass.ExampleMethod();

//It's useful to have classes in different files rather than all toghether 
//To keep the project organised.

//2 Create a class in a new script file called Enemy
//It should have a variable called health set to 5
//It should have a string variable called name.
//A method called Hit(), which takes one off the health each time
//It should log out the health after each hit
//If the health reaches 0, it should say 'enemy has died'

//3 .ToString()
//Every class has a .ToString() method, no matter what, but by default
//it does not give you much information. 
//.ToString()
//Try it on your enemy class


//4 Override toString
//We can use an override method to replace the default behaviour of a method. 
//Override the ToString method in your enemy class, it should log useful information
// "Enemy ghost has 3 health remaining."

//Challenge : Shopping Basket.
//1 Create a class called Product which will be to represent an item in a store. It should have a name and price.
//2 Create a class called BasketItem which will represent an item in a shopper's basket
//It should have variables for a Product, and a quantity (int)
//3 Add a CalculateCost method to your BasketItem class, which returns the product cost * quantity.
//4 Add a Basket class. This should contain a List<BasketItem> to represent all the items in a shopper's basket
//5 Basket class should have a method called CalculateTotalCost which returns total cost of basket
//6 Basket class should have a method called CalculateTotalItems which returns the total number of items in the basket
//7  Override the .ToString method to provide useful information about the basket
//i.e This basket contains a total of 12 items which cost a total of £22.50.
//8 Create a Coupon class. This should have a float variable for discount (i.e. 0.8 is a 20% discount)
//9 Add a Coupon Variable to the Basket class. If this variable is not null, then it should apply the discount
//when using CalculateTotalCost.


//Class Inheritance 

//Create instance of class A ( i.e. A aInstance = new A(); )
//What methods can we call on class A? And What variables does it have.

//Look at class B - it inherits from class A, this means it has all the properties of class A.

//If we create Class B, we can use Method1() and Method2()
//We can call an additional Method - Method3()
//Can you call Method3() from class A?

//Look at class C - it also inherits from class A

//If we create Class C, we can use Method4(), Method1() and Method2().
//Can we use Method3()?

//Add a Method5() to class A - will class B and C be able to use this?

//Create a Class D that inherits from class B - it should have a new variable 'percentage' which is a float
//And a method class Method6() -
//What classes can use Method 6()
//What are all the methods that Class D can use

//Drawing a Diagram of the class structure can often help




//School Record Exersize, Student Teacher Staff Admin.
//1 Create a class Called Person, this will be our base class
//The Person class should have properties of FirstName, LastName and Age.
//2 Create a class Called Student, which inherits from Person
//This class should have a string[] called classes, for the classes they attend
//3 Create a class Called Teacher, which inherits from Person
//This class should have a string called subject, for the subjects they teach
//4 Create a class Called Staff, which inherits from Person
//This class should have a string called role, which is the role they have#
//i.e. cleaning/ admin/ maintenance.
//Create a class called School. This class should have a List<Person> for all the people that are in the school
//This could be a mix of teachers, students and staff.
//Create an instance of the School class
//Create at least 5 students, 2 teachers, and one staff
//Add these to the list of people in the school class.

//Create the following functions on the School Class
// int GetTotalTeachers() 
// int GetTotalStudents()
// int GetTotalStaff()
// Teacher FindTeacherForSubject(string subject)
// List<Student> FindStudentsForSubject(string subject)
// List<Student> FindStudentsForTeacher(Teacher teacher)
//List<Teacher> FindTeachersForStudent(Student student)






