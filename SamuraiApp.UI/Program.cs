using System;
using SamuraiApp.Data.Entities;
using SamuraiApp.Data.Repository.Concrete;
using SamuraiApp.Data.Repository.Interface;
using SamuraiApp.Domain.Service.Concrete;
using SamuraiApp.Domain.Service.Interface;
using Unity;

namespace SamuraiApp.UI
{
    public class Program
    {
        private static ISamuraiService _samuraiService;
        static void Main(string[] args)
        {
            var unityContainer = new UnityContainer();
            unityContainer.RegisterType<ISamuraiRepository, SamuraiRepository>();
            unityContainer.RegisterType<ISamuraiService, SamuraiService>();
            _samuraiService = unityContainer.Resolve<ISamuraiService>();

            Console.WriteLine("Please type a name for your samurai");
            var name = Console.ReadLine();
            var samurai = new Samurai() { Name = name };
            AddSamurai(samurai);

            GetSamurais();
        }

        private static void AddSamurai(Samurai samurai)
        {
            _samuraiService.AddSamurai(samurai);
        }

        private static void GetSamurais()
        {
            var samurais = _samuraiService.GetSamurais();
            Console.WriteLine($"Samurai count is {samurais.Count}");

            foreach (var samurai in samurais)
            {
                Console.WriteLine(samurai.Name);
            }
        }
    }
}
