# C# Lab: Regular Expressions & Intro to Generics

A practical exercise to learn powerful text pattern matching with `System.Text.RegularExpressions`,
along with an intro to generics by understanding the importance of type-safe methods using **Generics**.

**Instructor**: Raghad Al Shaer
**GitHub**: Raghad-ALSh

---

## The Exercise - Part 1: Regular Expressions

Your first task is to use the `Regex` class to validate, extract, and replace patterns in text.

### Step 1.1: Validation (Regex.IsMatch)

- **Task:** Create a method to check if a "Product ID" string is valid.
- **Rules:** A valid ID must start with the capital letter 'P' and be followed by exactly 6 digits (e.g., `P123456`).
- **Input (Test Cases):**
  - `"P123456"`
  - `"p123456"`
  - `"P123"`
  - `"P1234567"`
- **Expected Output:**

  ```plaintext
  --- Regex Exercise 1: Validation ---
  ID: P123456   ->  Is Valid: True
  ID: p123456   ->  Is Valid: False
  ID: P123      ->  Is Valid: False
  ID: P1234567  ->  Is Valid: False
  ```

### Step 1.2: Matching & Extracting (Regex.Matches)

- **Task:** Create a method to parse a string containing multiple log entries.
- **Rules:** From each entry, you must extract the timestamp and the log message.
- **Input String:**

  ```csharp
  string logEntries =
      "[2025-10-29 09:15:01] ERROR: File not found. " +
      "[2025-10-29 09:16:22] INFO: User 'admin' logged in. " +
      "[2025-10-29 09:17:00] WARNING: Disk space low."+
      "[2025-10-29 09:18:45] INFO: Scheduled backup completed.";
  ```

- **Expected Output:**

  ```plaintext
  --- Regex Exercise 2: Matching & Groups ---
  Timestamp: 2025-10-29 09:15:01 | Message: File not found.
  Timestamp: 2025-10-29 09:16:22 | Message: User 'admin' logged in.
  Timestamp: 2025-10-29 09:17:00 | Message: Disk space low.
  Timestamp: 2025-10-29 09:18:45 | Message: Scheduled backup completed.
  ```

### Step 1.3: Replacing (Regex.Replace)

- **Task:** Create a method to "redact" sensitive information from a string.
- **Rules:**
  - Find all email addresses (e.g., `support@company.com`) and replace them with `[REDACTED_EMAIL]`.
  - Find all Syrian mobile numbers (e.g., `0931234567` or `+963998765432`) and replace them with `[REDACTED_SY_PHONE]`.
- **Input String:**

  ```csharp
  string text = "Contact support at support@company.com or call 0931234567. " +
                "Forward invoices to billing@company.com. " +
                "International line is +963998765432. Do not call 555-123-4567.";
  ```

- **Expected Output:**

  ```plaintext
  --- Regex Exercise 3: Replacing ---
    Redacted text: Contact support at [REDACTED_EMAIL] or call [REDACTED_SY_PHONE]. Forward invoices to [REDACTED_EMAIL]. International line is [REDACTED_SY_PHONE]. Do not call 555-123-4567.
  ```

---

## The Exercise - Part 2: Generics Intro

Your second task is to understand why generics are necessary by demonstrating the evolution of a `Swap` method.

- check SwapDemo class
- then check GenericsDemo class
- pay attention to the comments in both classes
