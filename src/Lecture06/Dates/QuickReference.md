# Date and Time Formatting

## Quick Reference: Standard Date & Time Format Strings
These use a single character to represent a predefined format pattern.

| Specifier     | Name                   | Pattern (en-US Example)         | Example (`DateTime.Now`) | Output                                |
| :------------ | :--------------------- | :------------------------------ | :----------------------- | :------------------------------------ |
| **`d`**       | Short Date             | MM/dd/yyyy                      | `$"{now:d}"`             | `10/27/2023`                          |
| **`D`**       | Long Date              | dddd, MMMM dd, yyyy             | `$"{now:D}"`             | `Friday, October 27, 2023`            |
| **`t`**       | Short Time             | hh:mm tt                        | `$"{now:t}"`             | `2:45 PM`                             |
| **`T`**       | Long Time              | hh:mm:ss tt                     | `$"{now:T}"`             | `2:45:18 PM`                          |
| **`f`**       | Full Date/Time (short) | dddd, MMMM dd, yyyy hh:mm tt    | `$"{now:f}"`             | `Friday, October 27, 2023 2:45 PM`    |
| **`F`**       | Full Date/Time (long)  | dddd, MMMM dd, yyyy hh:mm:ss tt | `$"{now:F}"`             | `Friday, October 27, 2023 2:45:18 PM` |
| **`g`**       | General (short)        | MM/dd/yyyy hh:mm tt             | `$"{now:g}"`             | `10/27/2023 2:45 PM`                  |
| **`G`**       | General (long)         | MM/dd/yyyy hh:mm:ss tt          | `$"{now:G}"`             | `10/27/2023 2:45:18 PM`               |
| **`M` / `m`** | Month Day              | MMMM dd                         | `$"{now:M}"`             | `October 27`                          |
| **`Y` / `y`** | Year Month             | MMMM, yyyy                      | `$"{now:Y}"`             | `October, 2023`                       |
| **`s`**       | Sortable               | yyyy-MM-ddTHH:mm:ss             | `$"{now:s}"`             | `2023-10-27T14:45:18`                 |
| **`o` / `O`** | Round-trip             | yyyy-MM-ddTHH:mm:ss.fffffffzzz  | `$"{now:O}"`             | `2023-10-27T14:45:18.1234567-04:00`   |
| **`u`**       | Universal Sortable     | yyyy-MM-dd HH:mm:ssZ            | `$"{now:u}"`             | `2023-10-27 14:45:18Z`                |

---

## Quick Reference: Custom Date & Time Format Strings
These let you build your own format from components.

| Specifier  | Description                    | Example (`DateTime.Now`) | Output     |
| :--------- | :----------------------------- | :----------------------- | :--------- |
| **`yyyy`** | Four-digit year                | `$"{now:yyyy}"`          | `2023`     |
| **`yy`**   | Two-digit year                 | `$"{now:yy}"`            | `23`       |
| **`MMMM`** | Full month name                | `$"{now:MMMM}"`          | `October`  |
| **`MM`**   | Two-digit month                | `$"{now:MM}"`            | `10`       |
| **`M`**    | One/two-digit month            | `$"{now:M}"`             | `10`       |
| **`dddd`** | Full day name                  | `$"{now:dddd}"`          | `Friday`   |
| **`ddd`**  | Abbreviated day name           | `$"{now:ddd}"`           | `Fri`      |
| **`dd`**   | Two-digit day                  | `$"{now:dd}"`            | `27`       |
| **`d`**    | One/two-digit day              | `$"{now:d}"`             | `27`       |
| **`HH`**   | Two-digit hour (24-hour clock) | `$"{now:HH}"`            | `14`       |
| **`hh`**   | Two-digit hour (12-hour clock) | `$"{now:hh}"`            | `02`       |
| **`mm`**   | Two-digit minute               | `$"{now:mm}"`            | `45`       |
| **`ss`**   | Two-digit second               | `$"{now:ss}"`            | `18`       |
| **`fff`**  | Three-digit millisecond        | `$"{now:fff}"`           | `123`      |
| **`tt`**   | AM/PM designator               | `$"{now:hh:mm tt}"`      | `02:45 PM` |
| **`zzz`**  | Time zone offset with colon    | `$"{now:zzz}"`           | `-04:00`   |

---