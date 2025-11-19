namespace Lecture08.Models
{
    class Customer : IEntity{
        public int Id {get; set;}
        public required string Name {get; set;}
        public required string Email {get; set;}

        public override string ToString(){
            return $"Customer [Id={Id}, Name={Name}, Email={Email}]";
        }
    } 
}