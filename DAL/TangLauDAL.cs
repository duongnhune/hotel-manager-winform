using DTO;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class TangLauDAL
    {
        private HyggeDbDataContext dataContext = new HyggeDbDataContext();

        public List<tb_TangLau> GetFloors()
        {
            return dataContext.tb_TangLaus.Select(tang => tang).ToList();
        }
    }
}