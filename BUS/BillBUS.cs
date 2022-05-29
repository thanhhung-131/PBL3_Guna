using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BillBUS
    {
        private static BillBUS instance;
        public static BillBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillBUS();
                return instance;
            }
        }
        public int GetUnCheckIDBillByIDTable(int id)
        {
            try
            {
                return BillDAO.Instance.GetUnCheckIDBillByIDTable(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
