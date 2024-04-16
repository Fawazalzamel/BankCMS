namespace BankCMS.Models
{

   
    public class Customer
    {
        public string CivilId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }



        public Customer(string CivilId, string Name, string Email, string Phone)
        {
            this.CivilId = CivilId;
            this.Name = Name;   
            this.Email = Email; 
            this.Phone = Phone;

        }
    }

    
  
}
