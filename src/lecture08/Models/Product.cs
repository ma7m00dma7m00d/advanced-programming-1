namespace Lecture08.Models
{
    class Product : IEntity{
        public int Id {get; set;}
        public required string Name {get; set;}
        public decimal Price {get; set;}

        public override string ToString(){
            return $"Product [Id={Id}, Name={Name}, Price={Price}]";
        }
    }
}