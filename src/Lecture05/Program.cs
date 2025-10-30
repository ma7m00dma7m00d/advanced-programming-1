using System;
using System.Text;
using System.Diagnostics; // Required for the Stopwatch class

// -----------------------------------------------------------
// 1. Constructors and Default Values
// -----------------------------------------------------------
StringBuilder sb = new StringBuilder(); // Default constructor
System.Console.WriteLine("Default capacity: " + sb.Capacity); // Default capacity is 16.
System.Console.WriteLine("Default max capacity: " + sb.MaxCapacity + "\t int max: " + Int32.MaxValue); // Default MaxCapacity is Int32.MaxValue.

sb = new StringBuilder(10); // Constructor with initial capacity parameter
System.Console.WriteLine("Capacity after setting to 10: " + sb.Capacity); // Capacity is exactly 10.

sb = new StringBuilder("this string length is 34 chars ..."); // Constructor with string parameter
System.Console.WriteLine("Capacity after setting to a 34-char string: " + sb.Capacity); // Capacity is initialized to the string's length (34).

// -----------------------------------------------------------
// 2. Dynamic Capacity Increase Logic
// -----------------------------------------------------------

// Current Length: 34, Current Capacity: 34
sb.Append('a', 20); // Appending 20 chars
                    // Required Length: 34 + 20 = 54. 
                    // Capacity must increase. It doubles the old capacity (34 * 2 = 68), which is > 54.
System.Console.WriteLine("Capacity after appending 20 chars: " + sb.Capacity); // Output: 68
System.Console.WriteLine("After appending 'a' 20 times:\n\t" + sb);

// Current Length: 54, Current Capacity: 68
sb.Append('b', 15); // Appending 15 chars
                    // Required Length: 54 + 15 = 69. 
                    // Capacity must increase. It doubles the old capacity (68 * 2 = 136), which is > 69.
System.Console.WriteLine("Capacity after appending 15 chars: " + sb.Capacity); // Output: 136

// Current Length: 69, Current Capacity: 136
sb.Append('c', 210); // Appending 210 chars
                     // Required Length: 69 + 210 = 279.
                     // Doubling the old capacity (136 * 2 = 272) is LESS than the required length (279).
                     // Therefore, the new capacity is set to the required length: 279.
System.Console.WriteLine("Capacity after appending 210 chars: " + sb.Capacity); // Output: 279

// Current Length: 279, Current Capacity: 279
sb.Append('c', 10); // Appending 10 chars
                    // Required Length: 279 + 10 = 289.
                    // Capacity must increase. It doubles the old capacity (279 * 2 = 558), which is > 289.
System.Console.WriteLine("Capacity after appending 10 chars: " + sb.Capacity); // Output: 558

System.Console.WriteLine("\nWhat happened with capacity?");
System.Console.WriteLine("Capacity either **doubles** or expands to the **required minimum length**, whichever is greater.");

System.Console.WriteLine("\n**In-Memory Concept**");
System.Console.WriteLine("// Every time the capacity is exceeded, a new larger array is allocated, and the old content is copied to the new array.");
System.Console.WriteLine("// This reallocation/copying is the expensive operation StringBuilder helps to minimize compared to repeated string concatenation.");


// -----------------------------------------------------------
// 3. Key Methods from StringBuilder Class
// -----------------------------------------------------------
System.Console.WriteLine("\n-- Key Methods --");
System.Console.WriteLine("Current String: " + sb.ToString());

// Insert: Adds a character or string at a specified index
sb.Insert(3, '*');
System.Console.WriteLine("After sb.Insert(3, '*') : " + sb.ToString());

// Replace: Replaces all occurrences of a string with another
sb.Replace("a", "rr");
System.Console.WriteLine("After sb.Replace(\"a\", \"rr\") : " + sb.ToString());

// Remove: Deletes a specified number of characters starting from an index
sb.Remove(3, 1);
System.Console.WriteLine("After sb.Remove(3, 1) : " + sb);

// Clear: Sets the length to 0 but preserves the capacity
sb.Clear();
sb.Append("2");
System.Console.WriteLine("\nAfter sb.Clear() and sb.Append(\"2\"):");
System.Console.WriteLine("Capacity remains high: " + sb.Capacity); // Capacity is preserved (558)
System.Console.WriteLine("New String: " + sb.ToString());


// -----------------------------------------------------------
// 4. Comparison: StringBuilder vs. String Concatenation (+)
// -----------------------------------------------------------
System.Console.WriteLine("\n-- Practical Comparison: Building a Student ID --");
string university = "DU";
string department = "CSE";
int id = 123456;

// Method 1: Using standard string concatenation (+)
// This creates multiple temporary string objects in memory. (5 objects are created in this case)
string studentId_string = university + "-" + department + "-" + id;
System.Console.WriteLine("Student ID (using +): " + studentId_string);

// Method 2: Using StringBuilder (more efficient)
// This minimizes temporary object creation. (1 object is created in this case)
StringBuilder studentId_builder = new StringBuilder();
studentId_builder.Append(university).Append("-").Append(department).Append("-").Append(id);
System.Console.WriteLine("Student ID (using StringBuilder): " + studentId_builder);


// -----------------------------------------------------------
// 5. Performance Test with Stopwatch
// -----------------------------------------------------------
System.Console.WriteLine("\n-- Performance Test with Stopwatch --");

const int iterations = 100000; // We repeat the operation many times to get a meaningful measurement.
Stopwatch watch = new Stopwatch();

// --- Test 1: String Concatenation (+) ---
// This loop will create hundreds of thousands of temporary string objects,
// which is slow and memory-intensive.
watch.Start();
for (int i = 0; i < iterations; i++)
{
    string s = university + "-" + department + "-" + id;
}
watch.Stop();
System.Console.WriteLine($"String concatenation (+) took : {watch.ElapsedMilliseconds} ms for {iterations:N0} iterations.");

// --- Test 2: StringBuilder ---
// This loop reuses the same StringBuilder, only creating a new final string if needed.
// It's much faster because it avoids creating temporary objects.
watch.Reset(); // Reset the stopwatch for the next test
StringBuilder sb_perf = new StringBuilder();
watch.Start();
for (int i = 0; i < iterations; i++)
{
    sb_perf.Clear(); // Clear the builder for the next iteration's use
    sb_perf.Append(university).Append("-").Append(department).Append("-").Append(id);
}
watch.Stop();
System.Console.WriteLine($"StringBuilder took : {watch.ElapsedMilliseconds} ms for {iterations:N0} iterations.");

//after running the performance test, we can see a significant difference in time taken.
//for instance, on my pc the string concatenation took around 13 ms,
//while the StringBuilder approach took only about 3 ms.
