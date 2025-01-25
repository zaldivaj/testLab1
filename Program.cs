using static System.Console;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

 Console.WriteLine("Hello, Jorge!");
 Console.WriteLine("Version: {0}", Environment.Version.ToString());
 string text = System.IO.File.ReadAllText("text.txt");
Console.WriteLine(text);

string[] names; // can reference any size array of strings

// allocating memory for four strings in an array
names = new string[6];  // I changed this to hold 6 names

// storing items at index positions
names[0] = "Kate";
names[1] = "Jack";
names[2] = "Rebecca";
names[3] = "Tom";
names[4] = "Sophia";  // Added new name
names[5] = "Lucas";   // Added new name

string[] names2 = new[] { "Kate", "Jack", "Rebecca", "Tom", "Sophia", "Lucas" };  // Added new names

// looping through the names
for (int i = 0; i < names2.Length; i++)
{
    // output the item at index position i
    WriteLine(names2[i]);
}

string[,] grid1 = new[,] // two dimensions
{
  { "Alpha", "Beta", "Gamma", "Delta" },
  { "Anne", "Ben", "Charlie", "Doug" },
  { "Aardvark", "Bear", "Cat", "Dog" },
  { "Echo", "Foxtrot", "Golf", "Hotel" }  // Added a new row
};

WriteLine($"Lower bound of the first dimension is: {grid1.GetLowerBound(0)}");
WriteLine($"Upper bound of the first dimension is: {grid1.GetUpperBound(0)}");
WriteLine($"Lower bound of the second dimension is: {grid1.GetLowerBound(1)}");
WriteLine($"Upper bound of the second dimension is: {grid1.GetUpperBound(1)}");

for (int row = 0; row <= grid1.GetUpperBound(0); row++)
{
  for (int col = 0; col <= grid1.GetUpperBound(1); col++)
  {
    WriteLine($"Row {row}, Column {col}: {grid1[row, col]}");
  }
}

// alternative syntax
string[,] grid2 = new string[4,4]; // I changed this to 4x4
grid2[0, 0] = "Alpha"; // assign string values
grid2[0, 1] = "Beta"; 
grid2[0, 2] = "Gamma";
grid2[0, 3] = "Delta";
grid2[1, 0] = "Anne";
grid2[1, 1] = "Ben"; 
grid2[1, 2] = "Charlie";
grid2[1, 3] = "Doug";
grid2[2, 0] = "Aardvark";
grid2[2, 1] = "Bear"; 
grid2[2, 2] = "Cat";
grid2[2, 3] = "Dog";
grid2[3, 0] = "Echo"; 
grid2[3, 1] = "Foxtrot";
grid2[3, 2] = "Golf";
grid2[3, 3] = "Hotel";  // added values for the new row

string[][] jagged = new[] // array of string arrays
{
  new[] { "Alpha", "Beta", "Gamma" },
  new[] { "Anne", "Ben", "Charlie", "Doug" },
  new[] { "Aardvark", "Bear", "Cat", "Dog" },
  new[] { "Echo", "Foxtrot", "Golf", "Hotel" }  // added new array
};

WriteLine("Upper bound of array of arrays is: {0}",
  jagged.GetUpperBound(0));

for (int array = 0; array <= jagged.GetUpperBound(0); array++)
{
  WriteLine("Upper bound of array {0} is: {1}",
    arg0: array,
    arg1: jagged[array].GetUpperBound(0));
}

for (int row = 0; row <= jagged.GetUpperBound(0); row++)
{
  for (int col = 0; col <= jagged[row].GetUpperBound(0); col++)
  {
    WriteLine($"Row {row}, Column {col}: {jagged[row][col]}");
  }
}

// Pattern matching with arrays

int[] sequentialNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };  // Added 11
int[] oneTwoNumbers = new int[] { 1, 2, 3 };  // Added 3
int[] oneTwoTenNumbers = new int[] { 1, 2, 10, 12 };  // Added 12
int[] oneTwoThreeTenNumbers = new int[] { 1, 2, 3, 10, 11 };  // Added 11
int[] primeNumbers = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31 };  // Added 31
int[] fibonacciNumbers = new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 };  // Added 144
int[] emptyNumbers = new int[] { 0 };  // Changed to have one element
int[] threeNumbers = new int[] { 9, 7, 5, 3 };  // Added 3
int[] sixNumbers = new int[] { 9, 7, 5, 4, 2, 10, 12 };  // Added 12

WriteLine($"{nameof(sequentialNumbers)}: {CheckSwitch(sequentialNumbers)}");
WriteLine($"{nameof(oneTwoNumbers)}: {CheckSwitch(oneTwoNumbers)}");
WriteLine($"{nameof(oneTwoTenNumbers)}: {CheckSwitch(oneTwoTenNumbers)}");
WriteLine($"{nameof(oneTwoThreeTenNumbers)}: {CheckSwitch(oneTwoThreeTenNumbers)}");
WriteLine($"{nameof(primeNumbers)}: {CheckSwitch(primeNumbers)}");
WriteLine($"{nameof(fibonacciNumbers)}: {CheckSwitch(fibonacciNumbers)}");
WriteLine($"{nameof(emptyNumbers)}: {CheckSwitch(emptyNumbers)}");
WriteLine($"{nameof(threeNumbers)}: {CheckSwitch(threeNumbers)}");
WriteLine($"{nameof(sixNumbers)}: {CheckSwitch(sixNumbers)}");

static string CheckSwitch(int[] values) => values switch
{
  [] => "Empty array",
  [1, 2, _, 10] => "Contains 1, 2, any single number, 10.",
  [1, 2, .., 10] => "Contains 1, 2, any range including empty, 10.",
  [1, 2] => "Contains 1 then 2.",
  [int item1, int item2, int item3] => 
    $"Contains {item1} then {item2} then {item3}.",
  [0, _] => "Starts with 0, then one other number.",
  [0, ..] => "Starts with 0, then any range of numbers.",
  [2, .. int[] others] => $"Starts with 2, then {others.Length} more numbers.",
  [..] => "Any items in any order.",
};
