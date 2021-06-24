using System.Collections.Generic;

namespace SamuraiApp.Data.Entities
{
    public class Samurai
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Quote> Quotes { get; set; } = new();
    }
}
