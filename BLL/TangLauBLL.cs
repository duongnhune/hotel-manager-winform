using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public class TangLauBLL
    {
        public static List<tb_TangLau> GetFloors()
        {
            return new TangLauDAL().GetFloors();
        }
    }
}