namespace MyMvcApiProject.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }

        // Constructor aan lahayn parameters
        public Customer() { }

        // Constructor leh parameters si loo abuuro object-ka xog leh
        public Customer(int customerId, string fullName, string email)
        {
            CustomerId = customerId; // Magaca saxda ah
            FullName = fullName;
            Email = email;
        }
   }
}