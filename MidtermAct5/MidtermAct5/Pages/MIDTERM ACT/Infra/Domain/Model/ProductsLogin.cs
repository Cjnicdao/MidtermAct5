
namespace MidtermAct5.Infrastructure.Domain.Models
{
    public class productsLogin
    {
        public Guid? Id { get; set; }
        public Guid? UserId { get; set; }
        public string? Type { get; set; } //Consumable, NonConsumable
        public string? Key { get; set; }
        public string? Value { get; set; }
    }

}
