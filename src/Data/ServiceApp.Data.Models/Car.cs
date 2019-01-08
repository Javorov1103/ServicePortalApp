namespace ServiceApp.Data.Models
{
    public class Car : BaseModel<int>
    {
        public string Make { get; set; }

        public string CarModel { get; set; }

        public string RegistrationNum { get; set; }

        public string VinNumber { get; set; }

        public virtual CarOwner CarOwner { get; set; }
    }
}
