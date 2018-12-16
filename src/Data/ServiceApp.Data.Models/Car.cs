namespace ServiceApp.Data.Models
{
    public class Car : BaseModel<int>
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public string RegistrationNum { get; set; }

        public string VinNumber { get; set; }

        public int CarOwnerId { get; set; }

        public CarOwner CarOwner { get; set; }
    }
}
