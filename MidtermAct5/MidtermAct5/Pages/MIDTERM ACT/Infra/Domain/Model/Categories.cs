using System.Diagnostics.Contracts;

namespace MidtermAct5.Infrastructure.Domain.Models
{
    public class Categories
    {
        public Guid? Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Abbreviation { get; set; }
    }
}
