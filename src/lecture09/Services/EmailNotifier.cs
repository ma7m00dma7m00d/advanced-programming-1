namespace Lecture09.Services;

using System.Text.RegularExpressions;

class EmailNotifier : INotifier{
    public void Notify(string contactInfo, string message){
        string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; //simple email regex pattern
        bool isValidEmail = Regex.IsMatch(contactInfo, emailPattern);
        if(!isValidEmail)   
            throw new ArgumentException("email is not in a correct format");
        System.Console.WriteLine($"message : {message}\n was sent to {contactInfo}");
    }
}