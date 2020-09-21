using System.ComponentModel.DataAnnotations;

namespace MockAPI.Model
{
    public class PaymentData
    {
        [Required]
        public string CardNumber { get; set; }

        public string Name { get; set; }

        [Required]
        public string Expiry { get; set; }

        [Required]
        public string Amount { get; set; }

        [Required]
        public string Currency { get; set; }

        [Required]
        public string Security { get; set; }
    }

}
