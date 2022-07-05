using DAL;

namespace BLL
{
    public class IdentifyBLL
    {
        public static int GetCounter(string parameter)
        {
            return new IdentifyDAL().GetCounter(parameter);
        }
    }
}