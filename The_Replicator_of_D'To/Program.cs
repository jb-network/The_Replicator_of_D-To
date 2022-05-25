// This is challenge work for the "C# Players Guide"
// Level 12 The Replicator of D'To
// This challenge is to build an array, have the user enter date into each element, and then copy the data into another array

int[] array1 = new int[5];
int[] array2 = new int[5];
string line = "_____________________________________________________";

//Build the initial array
for (int element = 0; element < array1.Length; element++)
{
    Console.Write($"Enter the value for element {element}: ");
    array1[element] = Convert.ToInt32(Console.ReadLine());
    //Copy the first array into the second
    array2[element] = array1[element];
    
}

Console.Clear();
Console.WriteLine("Array Check");
Console.WriteLine(line);

//Print arrays to check if they match
for (int element = 0; element < array1.Length; element++)
{
    Console.WriteLine($"Element Number: {element}       Array1: {array1[element]}    \tArray2: {array2[element]}");
    
}

Console.WriteLine(line);
Console.WriteLine("Press any key to end program");
Console.ReadKey();
