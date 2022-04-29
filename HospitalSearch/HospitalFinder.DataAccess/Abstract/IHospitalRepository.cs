using HospitalFinderEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalFinder.DataAccess.Abstract
{
  public  interface IHospitalRepository
    {
        List<Hospital> GetAllHospital();



        Hospital GetAlHospitalById(int id);



        Hospital CreateHospital(Hospital hospital);



        Hospital UpdateHospital(Hospital hospital);



        void DeleteHospital(int id);
        Hospital GetHospitalById(int ıd);
    }
}
