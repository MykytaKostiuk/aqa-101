### CST-01 - Find Common Items in 2 Arrays (class TaskWithLoops)

There are 2 arrays with 10 items each. Arrays can contain integers from 1 to 20.
We need to find common items in those arrays, i.e. items that are present in
both and then extract them into the new 3rd array.

Example:
> arrayA = [1, **4**, 18, **11**, ...] \
arrayB = [10, **11**, 2, **4**, ...] \
**resultArray** = [4, 11] 

Context:
1. initial arrays are manually populated
2. Optionally the common items could be logged to the console
3. Order of items in the result array doesn't matter

### CST-02 - Automatic Arrays Population With Random Values (class TaskWithLoops)

We need to extend the solution, implemented in the scope of the CST-01 with
The automatic population of the initial arrays.

Tasks:
1. When the program starts, both initial arrays (arrayA and arrayB) are
populated with randomly generated integers from 1 to 30.

### CST-03 - Merge 2 arrays (class TaskWithJoinArrays)

We need to merge the two arrays (arrayA and arrayB) into a single array and remove any duplicate values. The resulting array should contain all unique values from both arrays.

Context:

Use the arrays generated in **CST-02** (populated with random integers from 1 to 30).
The resulting merged array should not contain duplicates.
The order of elements in the resulting array does not matter.

### CST-04 - Sort array (class SortArray)
New task. There is an array of integers, with values generated automatically. The
The array has 15 items.
We need to sort out the items in ascending order and get the new array with
sorted items. The result array includes all the items from the basic one, but
sorted.

Context:
1. Any sorting algorithm can be used, but you can start with 'bubble'
2. Add ability to define the order of sorting (Asc/Desc)

### CST-05 - List vs HashSet. Part#1 Duplicates and Uniqueness (class ProgramForRegistration)

Create a program that manages student registrations for a course.

``` c#
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // TODO: Implement both approaches and compare results
        
        // Part A: Using List<string>
        List<string> studentsWithList = new List<string>();
        
        // Part B: Using HashSet<string>
        HashSet<string> studentsWithHashSet = new HashSet<string>();
        
        // Test data - some students try to register multiple times
        string[] registrationAttempts = {
            "Alice", "Bob", "Charlie", "Alice", 
            "Diana", "Bob", "Eve", "Charlie", "Alice"
        };
    }
}
```
Tasks:
1. Add all registration attempts to both collections
2. Print the contents of both collections
3. Print the count of each collection
4. Observe and explain the differences

### CST-06 - List vs HashSet. Part#2 Playlist Manager with Ordering Requirements

*Focus*: Indexing, Ordering, and Random Access
Create a music playlist manager that demonstrates when ordering matters.

```c#
using System;
using System.Collections.Generic;

public class Song
{
    public string Title { get; set; }
    public string Artist { get; set; }
    public int DurationSeconds { get; set; }
    
    public Song(string title, string artist, int duration)
    {
        Title = title;
        Artist = artist;
        DurationSeconds = duration;
    }
    
    public override string ToString()
    {
        return $"{Artist} - {Title} ({DurationSeconds}s)";
    }
    
    // TODO: Override Equals and GetHashCode for HashSet functionality
}

class Program
{
    static void Main()
    {
        // Sample songs
        Song[] songs = {
            new Song("Bohemian Rhapsody", "Queen", 355),
            new Song("Stairway to Heaven", "Led Zeppelin", 482),
            new Song("Hotel California", "Eagles", 391),
            new Song("Sweet Child O' Mine", "Guns N' Roses", 356),
            new Song("Smells Like Teen Spirit", "Nirvana", 301)
        };
        
        // TODO: Implement both playlist types
        
        // Part A: Ordered Playlist (List<Song>)
        List<Song> orderedPlaylist = new List<Song>();
        
        // Part B: Unique Songs Collection (HashSet<Song>)
        HashSet<Song> uniqueSongs = new HashSet<Song>();
        
        // Your tasks:
        // 1. Add all songs to both collections
        
        // 2. Playlist Operations (try with both collections):
        //    a) Play song at specific position (e.g., 3rd song)
        //    b) Insert a new song at position 2
        //    c) Move a song from position 4 to position 1
        //    d) Shuffle the playlist randomly
        //    e) Play songs in reverse order
        
        // 3. Duplicate Prevention:
        //    a) Try adding the same song twice
        //    b) Add a song with same title but different artist
        //    c) Handle duplicate detection
        
        // 4. Search Operations:
        //    a) Find song by title
        //    b) Find all songs by specific artist
        //    c) Find songs longer than 4 minutes
             
        Console.WriteLine("=== PLAYLIST MANAGER ===");
        // Implement your solutions here
        
    }
}
```

### CST-07 - Stack/LIFO. Stack of Names

Focus: Working with strings and basic Stack operations
```c#
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<string> names = new Stack<string>();
        
        Console.WriteLine("=== STACK OF NAMES ===");
        
        // Add some names
        names.Push("Alice");
        names.Push("Bob");
        names.Push("Charlie");
        
        Console.WriteLine("Added: Alice, Bob, Charlie");
        Console.WriteLine($"Total names in stack: {names.Count}");
        
        // YOUR TASKS - Complete these:
        
        // 1. Print the top name without removing it
        Console.WriteLine("\n1. Top name is: ");
                
        // 2. Remove and print each name (one by one)
        Console.WriteLine("\n2. Removing names:");
        // Hint: Use a while loop with names.Count > 0
        
        // 3. Try to add 3 names
        Console.WriteLine("\n3. Adding my friends:");
        // Write your code here
        
        // 4. Check if the stack contains a specific name
        Console.WriteLine("\n4. Checking if stack contains 'Bob':");
        
        // 5. Clear all names at once
        Console.WriteLine("\n5. Clearing all names:");

        Console.WriteLine($"Names left: {names.Count}");
    }
}
```
After completing these tasks, answer:

* What does LIFO mean?
* What's the difference between Pop() and Peek()?
* What happens when you Pop() from an empty stack?
* If you Push numbers 1, 2, 3, what order do they come out?
* How do you check how many items are in a stack?
