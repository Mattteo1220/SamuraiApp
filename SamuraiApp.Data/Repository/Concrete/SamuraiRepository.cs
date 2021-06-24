using System;
using System.Collections.Generic;
using System.Linq;
using SamuraiApp.Data.Entities;
using SamuraiApp.Data.Repository.Interface;

namespace SamuraiApp.Data.Repository.Concrete
{
    public class SamuraiRepository : ISamuraiRepository
    {
        private readonly SamuraiContext _samuraiContext;
        public SamuraiRepository(SamuraiContext samuraiContext)
        {
            _samuraiContext = samuraiContext ?? throw new ArgumentNullException(nameof(samuraiContext));
            _samuraiContext.Database.EnsureCreated();
        }
        public void AddSamurai(Samurai Samurai)
        {
            _samuraiContext.Samurais.Add(Samurai);
            _samuraiContext.SaveChanges();
        }

        public List<Samurai> GetSamurais()
        {
            return _samuraiContext.Samurais.ToList();
        }
    }
}
