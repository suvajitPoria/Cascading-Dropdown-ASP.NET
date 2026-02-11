using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public class VerifyGetData
    {
        public object VerifyGetCountry()
        {
            DAL.GetData getData = new DAL.GetData();
            var result = getData.GetCountry();
            if (result != null)
            {
                return result;
            }
            else
            {
                return ("GetCountry method is not working.");
            }
        }

        public object VerifyGetState(int CountryId)
        {
            if(CountryId <= 0)
            {
                return ("Invalid CountryId. It must be greater than zero.");
            }
            DAL.GetData getData = new DAL.GetData();
            var result = getData.GetState(CountryId);
            if (result != null)
            {
                return result;
            }
            else
            {
                return ("GetState method is not working.");
            }
        }
        public object VerifyGetCity(int StateId)
        {
            if(StateId <= 0)
            {
                return ("Invalid CountryId. It must be greater than zero.");
            }
            DAL.GetData getData = new DAL.GetData();
            var result = getData.GetCity(StateId);
            if (result != null)
            {
                return result;
            }
            else
            {
                return ("GetCity method is not working.");
            }
        }
        
        
        
    }
}
