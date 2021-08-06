
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityDL;
using EntityDTO;

namespace EntityBL
{
   public  class FacultyBL
    {
        FacultyDL dalObj;
        public FacultyBL()
        {
            dalObj = new FacultyDL();

        }
        public List<FacultyDTO> GetFaculties()
        {

            try
             {
                List<FacultyDTO> facData = new List<FacultyDTO>();
                 facData = dalObj.GetFaculties();
                return facData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
