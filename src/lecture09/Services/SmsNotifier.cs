namespace Lecture09.Services;

class SmsNotifier : INotifier {
    
     public void Notify(string contactInfo, string message){
      
        System.Console.WriteLine($"message : {message}\n was sent to {contactInfo}");
     }
}