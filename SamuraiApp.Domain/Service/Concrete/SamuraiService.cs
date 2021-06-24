using System;
using System.Collections.Generic;
using SamuraiApp.Data.Entities;
using SamuraiApp.Data.Repository.Interface;
using SamuraiApp.Domain.Service.Interface;

namespace SamuraiApp.Domain.Service.Concrete
{
    public class SamuraiService : ISamuraiService
    {
        private readonly ISamuraiRepository _samuraiRepository;
        public SamuraiService(ISamuraiRepository samuraiRepository)
        {
            _samuraiRepository = samuraiRepository ?? throw new ArgumentNullException(nameof(samuraiRepository));
        }

        public void AddSamurai(Samurai samurai)
        {
            _samuraiRepository.AddSamurai(samurai);
        }

        public List<Samurai> GetSamurais()
        {
            return _samuraiRepository.GetSamurais();
        }
    }
}
