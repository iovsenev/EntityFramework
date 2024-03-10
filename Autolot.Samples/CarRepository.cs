using AutoLot.Samples.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLot.Samples
{
    public class CarRepository
    {
        private readonly ApplicationDbContext _context;

        public CarRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Car> GetAllCar()
        {
            return _context.Cars;
        }

        public IEnumerable<Make> GetAllMake()
        {
            return _context.Makes;
        }
    }
}
