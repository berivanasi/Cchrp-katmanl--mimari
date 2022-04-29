using HospitalFinder.DataAccess.Abstract;
using HospitalFinderEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalFinder.DataAccess.Concrete
{
    class HospitalRepository : IHospitalRepository
    {
        public Hospital CreateHospital(Hospital hospital)
        {
            using(var hospitalDbContext= new HospitalDbContext())
            {
                hospitalDbContext.Hospitals.Add(hospital);
                hospitalDbContext.SaveChanges();
                return hospital;
            }
            
        }

        public void DeleteHospital(int id)
        {
            using (var hospitalDbContext = new HospitalDbContext())
            {
                var deleteHospital = GetHospitalById(id);
                hospitalDbContext.Hospitals.Remove(deleteHospital);
                hospitalDbContext.SaveChanges();
               
            }
        }

        public Hospital GetHospitalById(int id)
        {
            using(var hospitalDbContext= new HospitalDbContext())
            {
                return hospitalDbContext.Hospitals.Find();
            }
        }

        public List<Hospital> GetAllHospital()
        {
            using(var hospitalDbContext=new HospitalDbContext())
            {
                //Contextın içindeki dbset kullandığımız yerden geldi
                return hospitalDbContext.Hospitals.ToList();
            }
        }

        public Hospital UpdateHospital(Hospital hospital)
        {
            using(var hospitalDbContext=new HospitalDbContext())
            {
                hospitalDbContext.Hospitals.Update(hospital);
                hospitalDbContext.SaveChanges();
                return hospital;
            }
        }
    }
}
