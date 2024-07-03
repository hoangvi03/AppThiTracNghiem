using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChucNang;
using Classes;

namespace UngDungThiTN.ChucNang
{
    public class DeThi_CN
    {
        KetNoi ketnoi = new KetNoi();

        public int insert_DeThi(DeThi dt)
        {
            int parameter = 2;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MADT";
            name[1] = "@MAMH";
            values[0] = dt.MADT;
            values[1] = dt.MAMH;
            string sql = "insert_DeThi";
            return ketnoi.Execute(sql, name, values, parameter);
        }
        public int Check_deThi(string ma)
        {
            string sql = "SELECT COUNT(*) FROM DETHI WHERE MADT = '"+ma+"'";
            return ketnoi.ReturnInteger(sql);
        }

        public DataTable get_MAMH(string ma)
        {
            string sql = "SELECT MAMH FROM DETHI WHERE MADT = '" + ma + "'";
            return ketnoi.Load_DataNotProcedure(sql);
        }
        public DataTable load_DeThi()
        {
            string sql = "SELECT MADT FROM DETHI";
            return ketnoi.Load_DataNotProcedure(sql);
        }
        public DataTable load_CauHoi_DeThi(string made)
        {
            string sql = "SELECT * FROM CAUHOI WHERE MADT = '" + made + "'";
            return ketnoi.Load_DataNotProcedure(sql);
        }
    }
}
