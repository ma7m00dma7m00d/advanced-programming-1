# C# Exercise: Structs, Extension Methods & Anonymous Types

A foundational exercise to practice creating custom value types, extending their functionality, and grouping data for clear output.

**Instructor**: Raghad Al Shaer
**GitHub**: Raghad-ALSh

---

### The Exercise

Your task is to build a small console application that calculates the distances between a series of geometric points and displays a summary of the results.

#### Step 1: Create the `Point` Struct

Create a `struct` named `Point` to represent a 2D coordinate.

- It must have two public `double` properties: `X` and `Y`.
- Include a constructor that accepts `x` and `y` coordinates to initialize the properties.
- **Pro Tip**: Consider using a `readonly record struct` for a more concise and modern implementation.

#### Step 2: Create a `DistanceBetween` Extension Method

Create a new static class named `PointExtensions`.

- Inside this class, write an extension method named `DistanceBetween`.
- This method should extend the `Point` struct and accept a second `Point` as an argument.
- It must calculate and return the distance between the two points using the formula: $$d = \sqrt{(x_2-x_1)^2 + (y_2-y_1)^2}$$

#### Step 3: Implement the Main Program

In your `Program.cs` `Main` method:

1.  Create an array of `Point` objects with at least 4-5 sample coordinates.
2.  Use a loop and your `DistanceBetween` extension method to calculate the distance between each _consecutive_ point in the array (i.e., from point 1 to 2, 2 to 3, etc.).
3.  Calculate the total distance of the entire path.

#### Step 4: Create and Display an Anonymous Type

1.  Create a single **anonymous type** to hold a complete summary of your calculations. This object should contain:
    - The array of points.
    - The total number of points.
    - An array of the individual distances you calculated.
    - The total distance of the path.
2.  Write a final method that accepts this anonymous data (you'll need to pass the properties individually) and displays its content in a clean, human-readable format in the console.

---

### ✨ Expected Output

Your final console output should look similar to this:

```
=== GEOMETRY SUMMARY ===
Total Points: 4
Total Distance: 14.47

Points:
  Point 1: x= 0, y= 0
  Point 2: x= 3, y= 4
  Point 3: x= 6, y= 8
  Point 4: x= 10, y= 10

Distances between consecutive points:
  From x= 0, y= 0 to x= 3, y= 4: 5.00
  From x= 3, y= 4 to x= 6, y= 8: 5.00
  From x= 6, y= 8 to x= 10, y= 10: 4.47
```
