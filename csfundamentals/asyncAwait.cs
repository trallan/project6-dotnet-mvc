/* 

using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Main method started.");

        // Call an asynchronous method and await its completion
        await DoWorkAsync(); 

        Console.WriteLine("Main method finished.");
        Console.ReadKey(); // Keep console open
    }

    static async Task DoWorkAsync()
    {
        Console.WriteLine("DoWorkAsync started.");

        // Simulate a long-running operation using Task.Delay
        await Task.Delay(2000); // Pauses for 2 seconds without blocking the calling thread

        Console.WriteLine("DoWorkAsync completed.");
    }
}


async keyword:
The async keyword is used to mark a method as asynchronous. This allows the method to use the await keyword within its body.
Main and DoWorkAsync are both marked async.
await keyword:
The await keyword is used to pause the execution of the async method until the awaited Task completes.
When await Task.Delay(2000) is encountered in DoWorkAsync, the execution of DoWorkAsync is suspended, and control is returned to the caller (Main method in this case).
This allows the calling thread (the main thread) to remain free and responsive, rather than being blocked while waiting for the operation to finish.
Once the Task.Delay completes, the execution of DoWorkAsync resumes from where it left off, and the line Console.WriteLine("DoWorkAsync completed."); is executed.
Task and Task<T>:
Asynchronous methods typically return a Task or Task<T>.
Task represents an asynchronous operation that does not return a value.
Task<T> represents an asynchronous operation that returns a value of type T.
In this example, DoWorkAsync returns Task because it doesn't return a specific value. If it were to return an integer, its signature would be async Task<int> DoWorkAsync().

*/