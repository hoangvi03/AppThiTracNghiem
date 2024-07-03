using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

namespace ChucNang
{
    public class InPhieuDiem_CN
    {
        KetNoi ketnoi = new KetNoi();

        public DataTable loadPhieuDiem_ThiSinh(InPhieuDiem pd)
        {
            int parameter = 2;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MATS";
            name[1] = "@MADT";
            values[0] = pd.MATS;
            values[1] = pd.Madethi;
            string sql = "Load_PhieuDiem";
            return ketnoi.Load_DataWithParameter(sql,name,values,parameter);
        }

        public DataTable insert_PhieuDiem(InPhieuDiem pd)
        {
            int parameter = 8;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@monthi";
            name[1] = "@tongsocau";
            name[2] = "@socaudung";
            name[3] = "@socausai";
            name[4] = "@tongdiem";
            name[5] = "@MATS";
            name[6] = "@madethi";
            name[7] = "@magv";
            values[0] = pd.Monthi;
            values[1] = pd.Tongsocau;
            values[2] = pd.Socaudung;
            values[3] = pd.Socausai;
            values[4] = pd.Tongdiem;
            values[5] = pd.MATS;
            values[6] = pd.Madethi;
            values[7] = pd.MAGV;
            string sql = "insert_PhieuDiem";
            return ketnoi.Load_DataWithParameter(sql, name, values, parameter);
        }




    }
}
