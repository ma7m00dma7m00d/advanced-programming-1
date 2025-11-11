using System.Text.RegularExpressions;

namespace Lecture07.Regex
{
    class RegexExercises
    {
        /// Exercise 1: Validating a Product ID
        /// A valid product ID starts with a capital 'P' followed by exactly 6 digits.
        public static void RunValidation()
        {
            Console.WriteLine("\n--- Regex Exercise 1: Validation ---");

            // ^  -> Anchor to the start of the string
            // P  -> Must be a literal capital 'P'
            // \d -> Any digit (0-9)
            // {6} -> Exactly 6 times
            // $  -> Anchor to the end of the string
            string pattern = @"^P\d{6}$";

            string[] testCases = { "P123456", "p123456", "P123", "P1234567" };

            foreach (string id in testCases)
            {
                bool isValid = System.Text.RegularExpressions.Regex.IsMatch(id, pattern);
                Console.WriteLine($"ID: {id}  ->  Is Valid: {isValid}");
            }
        }

        /// Exercise 2: Matching and Extracting from Logs
        /// Extract timestamps and messages from log entries.
        public static void RunLogParsing()
        {
            Console.WriteLine("\n--- Regex Exercise 2: Matching & Groups ---");
            string logEntries =
                "[2025-10-29 09:15:01] ERROR: File not found. " +
                "[2025-10-29 09:16:22] INFO: User 'admin' logged in. " +
                "[2025-10-29 09:17:00] WARNING: Disk space low." +
                "[2025-10-29 09:18:45] INFO: Scheduled backup completed.";

            // We use () to create "Capturing Groups"
            // Group 1: \[([\d\s:-]+)\] -> Capture the content inside of [ ] (timestamp)
            //          \s\w+:\s         -> Match the log level (e.g., " INFO: ")
            // Group 2: ([^.]+\.)     -> Capture the message until a period, 
            // note: the . loses its special meaning inside [] character class
            string pattern = @"\[([\d\s:-]+)\]\s\w+:\s([^.]+\.)";
            //for our examples the pattern will work fine, but in real world scenarios we might want to make it more robust.
            //because what if the message contains multiple sentences or different punctuation or.
            //your task is to improve the pattern to handle such cases.

            MatchCollection matches = System.Text.RegularExpressions.Regex.Matches(logEntries, pattern);

            foreach (Match match in matches)
            {
                // Group 0 is the *entire* match
                // Groups[1] is the first ( )
                // Groups[2] is the second ( )
                string timestamp = match.Groups[1].Value;
                string message = match.Groups[2].Value;
                Console.WriteLine($"Timestamp: {timestamp} | Message: {message}");
            }
        }

        /// Exercise 3: Replacing Sensitive Information
        /// Redact email addresses and Syrian mobile phone numbers from text.
        public static void RunRedaction()
        {
            Console.WriteLine("\n--- Regex Exercise 3: Replacing ---");
            string text = "Contact support at support@company.com or call 0931234567. " +
                          "Forward invoices to billing@company.com. " +
                          "International line is +963998765432. Do not call 555-123-4567.";

            // Pattern 1: A simple email pattern
            string emailPattern = @"\w+@\w+\.\w+";
            //the previous pattern won't work  for someting like 
            // - "john.doe@example.com" (period in username)
            // - "info@mail.example.com" (subdomain)
            //a better email pattern could be @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}"

            // Pattern 2: Syrian mobile numbers
            string phonePattern = @"(?:09|\+9639)\d{8}"; //(?: ) is a non-capturing group and the | means OR

            // 1. Redact Emails
            string redactedText = System.Text.RegularExpressions.Regex.Replace(text, emailPattern, "[REDACTED_EMAIL]");

            // 2. Redact Phone Numbers (on the already redacted text)
            redactedText = System.Text.RegularExpressions.Regex.Replace(redactedText, phonePattern, "[REDACTED_SY_PHONE]");

            Console.WriteLine("Original text: " + text);
            Console.WriteLine("Redacted text: " + redactedText);
        }
    }
}