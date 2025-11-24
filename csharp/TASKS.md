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

---

### CST-02 - Automatic Arrays Population With Random Values (class TaskWithLoops)

We need to extend the solution, implemented in the scope of the CST-01 with
The automatic population of the initial arrays.

Tasks:
1. When the program starts, both initial arrays (arrayA and arrayB) are
populated with randomly generated integers from 1 to 30.

---

### CST-03 - Merge 2 arrays (class TaskWithJoinArrays)

We need to merge the two arrays (arrayA and arrayB) into a single array and remove any duplicate values. The resulting array should contain all unique values from both arrays.

Context:

Use the arrays generated in **CST-02** (populated with random integers from 1 to 30).
The resulting merged array should not contain duplicates.
The order of elements in the resulting array does not matter.

---

### CST-04 - Sort array (class SortArray)
New task. There is an array of integers, with values generated automatically. The
The array has 15 items.
We need to sort out the items in ascending order and get the new array with
sorted items. The result array includes all the items from the basic one, but
sorted.

Context:
1. Any sorting algorithm can be used, but you can start with 'bubble'
2. Add ability to define the order of sorting (Asc/Desc)

---

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

---

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
---

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

---

### CST-08 - Queue/FIFO. Working with strings and Queue operations

```c#
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> customerService = new Queue<string>();
        
        Console.WriteLine("=== CUSTOMER SERVICE QUEUE ===");
        
        // Customers arrive
        customerService.Enqueue("Alice");
        customerService.Enqueue("Bob"); 
        customerService.Enqueue("Charlie");
        
        Console.WriteLine("Customers arrived: Alice, Bob, Charlie");
        Console.WriteLine($"Customers waiting: {customerService.Count}");
        
        // YOUR TASKS - Complete these:
        
        // 1. Check who's next to be served (don't remove them)
        Console.WriteLine("\n1. Next customer to serve:");
        // Write your code here using Peek()
        
        // 2. Serve each customer one by one
        Console.WriteLine("\n2. Serving customers:");
        // Write your code here using Dequeue()
        // Hint: Use while loop with customerService.Count > 0
        
        // 3. Add yourself and two friends to the queue
        Console.WriteLine("\n3. New customers arriving:");
        // Write your code here
        
        // 4. Check if a specific customer is in the queue
        Console.WriteLine("\n4. Is 'Bob' in the queue?");
        // Write your code here using Contains()
        
        // 5. See how many customers are waiting
        Console.WriteLine("\n5. Total customers waiting:");
        // Write your code here using Count property
        
        // 6. Clear the entire queue
        Console.WriteLine("\n6. Closing service - clearing queue:");
        // Write your code here using Clear()
        Console.WriteLine($"Customers remaining: {customerService.Count}");
    }
}
```
##### After completing these tasks, answer:

* What does FIFO mean?
* What's the difference between Enqueue() and Dequeue()?
* What happens when you Dequeue() from an empty queue?
* If you Enqueue numbers 1, 2, 3, what order do they come out?
* How is Queue different from Stack?

---

### CST-09 - Dictionary. P1
Focus: Working with different value types and updating values
```c#
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Dictionary to store student grades
        // Key = Student name (string), Value = Grade (int)
        Dictionary<string, int> studentGrades = new Dictionary<string, int>();
        
        Console.WriteLine("=== STUDENT GRADES DICTIONARY ===");
        
        // Add initial grades
        studentGrades.Add("Alice", 85);
        studentGrades.Add("Bob", 92);
        studentGrades.Add("Charlie", 78);
        
        Console.WriteLine("Initial grades added: Alice=85, Bob=92, Charlie=78");
        Console.WriteLine($"Number of students: {studentGrades.Count}");
        
        // YOUR TASKS - Complete these:
        
        // 1. Show Alice's grade
        Console.WriteLine("\n1. Alice's grade:");
        // Write your code here
        
        // 2. Update Bob's grade to 95
        Console.WriteLine("\n2. Updating Bob's grade to 95:");
        // Write your code here (you can just assign: studentGrades["Bob"] = 95)
        
        // 3. Add a new student with grade
        Console.WriteLine("\n3. Adding new student 'Diana' with grade 88:");
        // Write your code here
        
        // 4. Check if student 'Eve' exists
        Console.WriteLine("\n4. Does student 'Eve' exist?");
        // Write your code here using ContainsKey()
        
        // 5. Show all students and their grades
        Console.WriteLine("\n5. All student grades:");
        // Write your code here using foreach loop
        // Hint: foreach (KeyValuePair<string, int> student in studentGrades)
        
        // 6. Find the highest grade
        Console.WriteLine("\n6. Finding highest grade:");
        // Write your code here - loop through all values
        
        // 7. Remove a student
        Console.WriteLine("\n7. Removing Charlie:");
        // Write your code here using Remove()
        
        // 8. Show final count
        Console.WriteLine($"\nFinal student count: {studentGrades.Count}");
    }
}
```

##### After completing these tasks, answer:

* What is a key-value pair?
* How do you add an item to a Dictionary?
* How do you look up a value by its key?
* What happens if you try to access a key that doesn't exist?
* How is Dictionary different from List?
* When would you use Dictionary instead of List?

---

### CST-10 - Collections sum up. Dictionary, HashSet, Stack, Queue, List, Exceptions
Create a streamlined library system that handles book borrowing and member management using Dictionary, List, HashSet, Queue, and Stack.
```c#
using System;
using System.Collections.Generic;
using System.Linq;

// Simplified Book class
public class Book
{
    public string ISBN { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public bool IsAvailable { get; set; }

    public Book(string isbn, string title, string author)
    {
        ISBN = isbn;
        Title = title;
        Author = author;
        IsAvailable = true;
    }

    public override string ToString()
    {
        return $"{Title} by {Author} - {(IsAvailable ? "Available" : "Borrowed")}";
    }
}

// Simplified Member class
public class Member
{
    public string MemberID { get; set; }
    public string Name { get; set; }
    public List<string> BorrowedBooks { get; set; }

    public Member(string memberID, string name)
    {
        MemberID = memberID;
        Name = name;
        BorrowedBooks = new List<string>();
    }

    public bool CanBorrowMore => BorrowedBooks.Count < 3; // Max 3 books

    public override string ToString()
    {
        return $"{Name} ({MemberID}) - Books borrowed: {BorrowedBooks.Count}";
    }
}

// Simplified Transaction class
public class Transaction
{
    public string Type { get; set; } // "BORROW" or "RETURN"
    public string MemberID { get; set; }
    public string ISBN { get; set; }

    public Transaction(string type, string memberID, string isbn)
    {
        Type = type;
        MemberID = memberID;
        ISBN = isbn;
    }

    public override string ToString()
    {
        return $"{Type}: {MemberID} - {ISBN}";
    }
}

// Main Library Management System
public class LibrarySystem
{
    // TODO: Implement these data structures and explain WHY each one is chosen
    
    // Dictionary for fast book lookup by ISBN
    private Dictionary<string, Book> _bookCatalog;
    
    // Dictionary for fast member lookup by ID
    private Dictionary<string, Member> _members;
    
    // HashSet for tracking unique authors (no duplicates needed)
    private HashSet<string> _authors;
    
    // Queue system for book reservations (FIFO - fair waiting system)
    private Dictionary<string, Queue<string>> _reservations;
    
    // Stack for transaction history (LIFO - recent transactions first for undo)
    private Stack<Transaction> _transactionHistory;

    public LibrarySystem()
    {
        _bookCatalog = new Dictionary<string, Book>();
        _members = new Dictionary<string, Member>();
        _authors = new HashSet<string>();
        _reservations = new Dictionary<string, Queue<string>>();
        _transactionHistory = new Stack<Transaction>();
    }

    // ===== BOOK MANAGEMENT =====
    
    public bool AddBook(string isbn, string title, string author)
    {
        // TODO: Implement this method
        // Requirements:
        // 1. Check if ISBN already exists (use Dictionary.ContainsKey)
        // 2. Add book to catalog
        // 3. Add author to authors set
        // 4. Return success/failure
        
        throw new NotImplementedException();
    }

    public bool RemoveBook(string isbn)
    {
        // TODO: Implement this method
        // Requirements:
        // 1. Check if book exists and is available (not borrowed)
        // 2. Remove from catalog
        // 3. Return success/failure
        
        throw new NotImplementedException();
    }

    // ===== MEMBER MANAGEMENT =====
    
    public bool RegisterMember(string memberID, string name)
    {
        // TODO: Implement this method
        // Requirements:
        // 1. Check if member ID already exists
        // 2. Add member to system
        // 3. Return success/failure
        
        throw new NotImplementedException();
    }

    // ===== BORROWING SYSTEM =====
    
    public string BorrowBook(string memberID, string isbn)
    {
        // TODO: Implement this method
        // Requirements:
        // 1. Check if member exists and can borrow more books
        // 2. Check if book exists and is available
        // 3. Mark book as borrowed and add to member's list
        // 4. Add transaction to history (use Stack.Push)
        // 5. Return success message or error
        
        throw new NotImplementedException();
    }

    public string ReturnBook(string memberID, string isbn)
    {
        // TODO: Implement this method
        // Requirements:
        // 1. Check if member has this book
        // 2. Mark book as available and remove from member's list
        // 3. Process any reservations (notify next person in queue)
        // 4. Add transaction to history
        // 5. Return success message
        
        throw new NotImplementedException();
    }

    // ===== RESERVATION SYSTEM =====
    
    public string ReserveBook(string memberID, string isbn)
    {
        // TODO: Implement this method using Queue
        // Requirements:
        // 1. Check if book exists
        // 2. If available, suggest immediate borrowing
        // 3. If not available, add to reservation queue (use Queue.Enqueue)
        // 4. Return position in queue
        
        throw new NotImplementedException();
    }

    // ===== SEARCH AND REPORTING =====
    
    public List<Book> SearchByAuthor(string author)
    {
        // TODO: Implement this method using List for results
        // Requirements:
        // 1. Find all books by the given author
        // 2. Return as List (allows easy iteration and display)
        // 3. Case-insensitive search
        
        throw new NotImplementedException();
    }

    public List<string> GetAllAuthors()
    {
        // TODO: Implement this method
        // Requirements:
        // 1. Convert HashSet to List for display
        // 2. Sort alphabetically
        // 3. Return sorted list of unique authors
        
        throw new NotImplementedException();
    }

    // ===== TRANSACTION HISTORY =====
    
    public bool UndoLastTransaction()
    {
        // TODO: Implement this method using Stack
        // Requirements:
        // 1. Check if history stack is not empty
        // 2. Pop last transaction (use Stack.Pop)
        // 3. Reverse the transaction:
        //    - If "BORROW", return the book
        //    - If "RETURN", borrow the book again
        // 4. Return success/failure
        
        throw new NotImplementedException();
    }

    public List<Transaction> GetRecentTransactions(int count = 5)
    {
        // TODO: Implement this method
        // Requirements:
        // 1. Get recent transactions from stack without removing them
        // 2. Convert to List for easy display
        // 3. Limit to specified count
        
        throw new NotImplementedException();
    }

    // ===== UTILITY METHODS =====
    
    public void DisplaySystemStatus()
    {
        Console.WriteLine("=== LIBRARY SYSTEM STATUS ===");
        Console.WriteLine($"Total Books: {_bookCatalog.Count}");
        Console.WriteLine($"Available Books: {_bookCatalog.Values.Count(b => b.IsAvailable)}");
        Console.WriteLine($"Total Members: {_members.Count}");
        Console.WriteLine($"Unique Authors: {_authors.Count}");
        Console.WriteLine($"Total Reservations: {_reservations.Values.Sum(q => q.Count)}");
        Console.WriteLine($"Transaction History: {_transactionHistory.Count}");
    }

    public void ShowAllBooks()
    {
        // TODO: Display all books with their status
        Console.WriteLine("\n=== ALL BOOKS ===");
        // Use foreach to iterate through dictionary values
    }

    public void ShowAllMembers()
    {
        // TODO: Display all members with their borrowed books
        Console.WriteLine("\n=== ALL MEMBERS ===");
        // Use foreach to iterate through dictionary values
    }
}

// Demo and Testing Class
class Program
{
    static void Main()
    {
        LibrarySystem library = new LibrarySystem();
        
        Console.WriteLine("=== SIMPLIFIED LIBRARY MANAGEMENT SYSTEM ===");
        
        // Phase 1: Setup
        Console.WriteLine("\n--- Adding Books ---");
        library.AddBook("001", "Clean Code", "Robert Martin");
        library.AddBook("002", "1984", "George Orwell");
        library.AddBook("003", "The Hobbit", "J.R.R. Tolkien");
        library.AddBook("004", "Effective Java", "Joshua Bloch");
        
        Console.WriteLine("\n--- Registering Members ---");
        library.RegisterMember("M01", "Alice");
        library.RegisterMember("M02", "Bob");
        library.RegisterMember("M03", "Charlie");
        
        library.DisplaySystemStatus();
        
        // Phase 2: Borrowing
        Console.WriteLine("\n--- Borrowing Books ---");
        Console.WriteLine(library.BorrowBook("M01", "001"));
        Console.WriteLine(library.BorrowBook("M02", "001")); // Should fail - already borrowed
        Console.WriteLine(library.BorrowBook("M02", "002"));
        
        // Phase 3: Reservations
        Console.WriteLine("\n--- Making Reservations ---");
        Console.WriteLine(library.ReserveBook("M02", "001")); // Should add to queue
        Console.WriteLine(library.ReserveBook("M03", "001")); // Should add to queue
        
        // Phase 4: Search
        Console.WriteLine("\n--- Search Operations ---");
        var martinBooks = library.SearchByAuthor("Robert Martin");
        Console.WriteLine($"Found {martinBooks.Count} books by Robert Martin");
        
        var allAuthors = library.GetAllAuthors();
        Console.WriteLine($"All authors: {string.Join(", ", allAuthors)}");
        
        // Phase 5: Returns and History
        Console.WriteLine("\n--- Returning Books ---");
        Console.WriteLine(library.ReturnBook("M01", "001")); // Should process reservations
        
        Console.WriteLine("\n--- Transaction History ---");
        var recentTransactions = library.GetRecentTransactions();
        foreach (var transaction in recentTransactions)
        {
            Console.WriteLine(transaction);
        }
        
        Console.WriteLine("\n--- Undo Last Transaction ---");
        library.UndoLastTransaction();
        
        library.DisplaySystemStatus();
        library.ShowAllBooks();
        library.ShowAllMembers();
    }
```

##### Phase 1: Basic Implementation
* Complete AddBook() and RegisterMember() methods
* Implement DisplaySystemStatus(), ShowAllBooks(), and ShowAllMembers()

##### Phase 2: Core Functionality
* Implement BorrowBook() and ReturnBook() methods
* Complete SearchByAuthor() and GetAllAuthors() methods

##### Phase 3: Advanced Features
* Implement reservation system with ReserveBook() method
* Complete transaction history with UndoLastTransaction() and GetRecentTransactions()

##### Phase 4: Testing and Validation
* Add error handling for edge cases
* Test all functionality with the provided demo

##### Key Learning Objectives:
* Dictionary Usage: Fast lookups for books and members
* HashSet Benefits: Automatic duplicate prevention for authors
* Queue Fairness: FIFO reservation system
* Stack History: LIFO transaction tracking
* List Flexibility: Search results and display operations

---

### CST-11 - Simple JSON Collection Processing

Read multiple people from JSON file, change their ages, and save to a new file.

```c#
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

// Simple class for JSON
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string City { get; set; }
    
    public override string ToString()
    {
        return $"{Name}, Age: {Age}, City: {City}";
    }
}

// Container for collection
public class PeopleData
{
    public List<Person> People { get; set; } = new List<Person>();
}


class Program
{
    static void Main()
    {
        Console.WriteLine("=== SIMPLE JSON COLLECTION PROCESSING ===");
        
        // Step 1: Create sample JSON file with multiple people
        CreateSampleFile();
        
        // Step 2: Read all people from JSON file
        PeopleData peopleData = ReadPeopleFromFile("people.json");
        Console.WriteLine("\n--- Original People ---");
        ShowAllPeople(peopleData.People);
        
        // Step 3: Change the data
        Console.WriteLine("\n--- Making Changes ---");
        foreach (Person person in peopleData.People)
        {
            person.Age = person.Age + 5;  // Everyone gets 5 years older
            person.City = person.City + " (Updated)"; // Add text to city
            Console.WriteLine($"Updated: {person.Name} is now {person.Age} years old");
        }
        
        // Step 4: Write to new JSON file
        WritePeopleToFile(peopleData, "people_updated.json");
        
        // Step 5: Verify the new file
        Console.WriteLine("\n--- Reading New File ---");
        PeopleData updatedData = ReadPeopleFromFile("people_updated.json");
        ShowAllPeople(updatedData.People);
        
        Console.WriteLine("\n✅ Done!");
    }
    
    // Create a sample JSON file with multiple people
    static void CreateSampleFile()
    {
        Console.WriteLine("Creating sample file with 3 people...");
        
        PeopleData sampleData = new PeopleData();
        sampleData.People.Add(new Person { Name = "Alice Johnson", Age = 25, City = "Boston" });
        sampleData.People.Add(new Person { Name = "Bob Smith", Age = 30, City = "Chicago" });
        sampleData.People.Add(new Person { Name = "Charlie Brown", Age = 22, City = "Miami" });
        
        WritePeopleToFile(sampleData, "people.json");
    }
    
    // Show all people in the list
    static void ShowAllPeople(List<Person> people)
    {
        for (int i = 0; i < people.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {people[i]}");
        }
    }
    
    // TODO: Read people from JSON file
    static PeopleData ReadPeopleFromFile(string fileName)
    {
        Console.WriteLine($"Reading from {fileName}...");
        
        // TODO: Your code here
        // 1. Read all text from file using File.ReadAllText()
        // 2. Convert JSON string to PeopleData object using JsonSerializer.Deserialize()
        // 3. Return the PeopleData object
        
        throw new NotImplementedException();
    }
    
    // TODO: Write people to JSON file  
    static void WritePeopleToFile(PeopleData peopleData, string fileName)
    {
        Console.WriteLine($"Writing to {fileName}...");
        
        // TODO: Your code here
        // 1. Convert PeopleData object to JSON string using JsonSerializer.Serialize()
        // 2. Write JSON string to file using File.WriteAllText()
        // Use WriteIndented = true for nice formatting
        
        throw new NotImplementedException();
    }
}

```

##### After completing these tasks, answer:
1. What does JSON stand for and what is it used for?
2. What are the two main operations when working with JSON in C#?
3. What's the difference between serialization and deserialization?
4. Why do we use WriteIndented = true when writing JSON files?
5. What namespace do you need to import for JSON operations in C#?
