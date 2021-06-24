using System.Collections.Generic;
using SamuraiApp.Data.Entities;

namespace SamuraiApp.Domain.Service.Interface
{
    public interface ISamuraiService
    {
        void AddSamurai(Samurai Samurai);
        List<Samurai> GetSamurais();
    }
}
