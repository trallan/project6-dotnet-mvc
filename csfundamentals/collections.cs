/*
1. List<T> (Generic List):
A dynamic array that can grow or shrink in size. It stores elements in a specific order and allows access by index. 

using System.Collections.Generic;
List<int> numbers = new List<int>();
numbers.Add(10);
numbers.Add(20);
numbers.Add(30);

int firstElement = numbers[0]; // 10

foreach (int num in numbers)
{
    Console.WriteLine(num);
}


2. Dictionary<TKey, TValue> (Generic Dictionary):
Stores key-value pairs, where each key is unique and maps to a specific value. Provides efficient lookup by key.

using System.Collections.Generic;
Dictionary<string, int> ages = new Dictionary<string, int>();

// Add key-value pairs
ages.Add("Alice", 30);
ages["Bob"] = 25; // Another way to add or update

// Access values by key
int aliceAge = ages["Alice"]; // 30

// Check if a key exists
if (ages.ContainsKey("Charlie"))
{
    Console.WriteLine("Charlie is in the dictionary.");
}


3. HashSet<T> (Generic HashSet):
Stores a collection of unique elements. It offers efficient operations for adding, removing, and checking for the existence of elements, as it doesn't allow duplicates.

using System.Collections.Generic;
HashSet<string> uniqueNames = new HashSet<string>();

// Add elements
uniqueNames.Add("John");
uniqueNames.Add("Jane");
uniqueNames.Add("John"); // This will not be added as it's a duplicate

// Check for existence
if (uniqueNames.Contains("Jane"))
{
    Console.WriteLine("Jane is in the set.");
}



4. Queue<T> (Generic Queue):
Represents a first-in, first-out (FIFO) collection of objects. Elements are added to one end and removed from the other.

using System.Collections.Generic;

// Create a Queue of strings
Queue<string> messageQueue = new Queue<string>();

// Enqueue elements
messageQueue.Enqueue("Message 1");
messageQueue.Enqueue("Message 2");

// Dequeue elements
string firstMessage = messageQueue.Dequeue(); // "Message 1"



5. Stack<T> (Generic Stack):
Represents a last-in, first-out (LIFO) collection of objects. Elements are added and removed from the same end.
Kod

using System.Collections.Generic;

// Create a Stack of integers
Stack<int> numberStack = new Stack<int>();

// Push elements onto the stack
numberStack.Push(1);
numberStack.Push(2);

// Pop elements from the stack
int topNumber = numberStack.Pop(); // 2

*/


