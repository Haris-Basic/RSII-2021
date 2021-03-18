using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class ProizvodService : IProizvodService
    {
        private static List<Proizvod> _proizvodi { get; set; }
        public ProizvodService()
        {
            _proizvodi = new List<Proizvod>
            {
                new Proizvod()
                {
                    Id=1,
                    Name = "Laptop"
                },
                new Proizvod()
                {
                    Id=2,
                    Name = "Tablet"
                },
                new Proizvod()
                {
                    Id=3,
                    Name = "Mobitel"
                },
            };
        }
        public IEnumerable<Proizvod> Get()
        {
            return _proizvodi;
        }
        public Proizvod GetById(int id)
        {
            return _proizvodi.FirstOrDefault(x => x.Id == id);
        }
        public Proizvod Insert(Proizvod proizvod)
        {
            _proizvodi.Add(proizvod);
            return proizvod;
        }
        public Proizvod Update(int id, Proizvod proizvod)
        {
            var current = _proizvodi.FirstOrDefault(x => x.Id == id);
            current.Name = proizvod.Name;

            return current;
        }
    }

    public class Proizvod
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
