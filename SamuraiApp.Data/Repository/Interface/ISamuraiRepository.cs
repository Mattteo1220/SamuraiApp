using System.Collections.Generic;
using SamuraiApp.Data.Entities;

namespace SamuraiApp.Data.Repository.Interface
{
    public interface ISamuraiRepository
    {
        void AddSamurai(Samurai Samurai);
        List<Samurai> GetSamurais();
    }
}
