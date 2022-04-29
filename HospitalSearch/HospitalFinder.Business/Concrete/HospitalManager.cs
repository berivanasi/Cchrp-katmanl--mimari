using HospitalFinder.Business.Abstract;
using HospitalFinder.DataAccess.Abstract;
using HospitalFinderEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalFinder.Business.Concrete
{
    public class HospitalManager : IHospitalService
    {
        private IHospitalRepository _hospitalRepository;

        public Hospital CreateHospital(Hospital hospital)
        {
            return _hospitalRepository.CreateHospital(hospital);
        }

       public void DeleteHospital(int Id)
        {
             _hospitalRepository.DeleteHospital(Id);
        }
        public Hospital GetAlHospitalById(int id)
        {
            throw new NotImplementedException();
        }

        public Hospital GetHospitalById(int Id)
        {
            if (Id > 0)
            {
                return _hospitalRepository.GetHospitalById(Id);
            }
            throw new Exception("id sıfırdan küçük olamaz");
        }

        public Hospital UpdateHospital(Hospital hospital)
        {
            return _hospitalRepository.UpdateHospital(hospital);
        }
    }
}
