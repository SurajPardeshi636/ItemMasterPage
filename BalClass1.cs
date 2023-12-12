using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;
using Dal;
namespace Bal
{
    
    public class BalClass1
    {
        DalClass1 dal = new DalClass1();



        public DataTable GetBindItmCode()
        {
            return dal.GetBindItmCode(); 
        }

        public DataTable GetBindItmName()
        {
            return dal.GetBindItmName();
        }
        //public DataTable GetBindItmCatagory()
        //{
        //    return dal.GetBindItmCatagory();
        //}


        public DataTable GetBindItmSubCatagory(int CategoryId)
        {
            return dal.GetBindItmSubCatagory(CategoryId);
        }




        public int SaveData(ModelClass1 model)
        {
            return dal.SaveData(model);

        }

        //public int Update(ModelClass1 model)
        //{

        //    return dal.Update(model);

        //}

        public DataTable SearchData(string ItemCode)
        {
            return dal.SearchData(ItemCode);

        }

        public int DeleteData(string itemCode)
        {
            return dal.DeleteData(itemCode);
        }


    }
}
