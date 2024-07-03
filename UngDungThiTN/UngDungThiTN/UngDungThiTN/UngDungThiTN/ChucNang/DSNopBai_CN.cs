using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

namespace ChucNang
{
    public class DSNopBai_CN
    {
        KetNoi ketnoi = new KetNoi();

        public DataTable loadDSNopBai()
        {
            string sql = "SELECT * FROM DSNOPBAI";
            return ketnoi.Load_DataNotProcedure(sql);
        }
        public DataTable loadDSNopBai_DeThi_MH(string made)
        {
            string sql = "SELECT * FROM DSNOPBAI WHERE MADETHI = '" + made + "'";
            return ketnoi.Load_DataNotProcedure(sql);
        }

        public DSNopBai load_NopBai_TS(string maTS, string maDe)
        {
            string sql = "SELECT * FROM DSNOPBAI WHERE MATHISINH = '" + maTS + "' AND MADETHI = '" + maDe + "'";

            DataTable table = ketnoi.Load_DataNotProcedure(sql);
            if (table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];
                DSNopBai dsnb = new DSNopBai()
                {
                    SOCAUDUNG = int.Parse(row["SOCAUDUNG"].ToString()),
                    SOCAUSAI = int.Parse(row["SOCAUSAI"].ToString()),
                };
                return dsnb;
            }
            return null;
        }

        public int Insert_Dsnopbai(DSNopBai ds)
        {
            int parameter = 5;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MATHISINH";
            name[1] = "@TENMONHOC";
            name[2] = "@SOCAUDUNG";
            name[3] = "@SOCAUSAI";
            name[4] = "@MADETHI";
            values[0] = ds.MATHISINH;
            values[1] = ds.TENMONHOC;
            values[2] = ds.SOCAUDUNG;
            values[3] = ds.SOCAUSAI;
            values[4] = ds.MADETHI;
            string sql = "Insert_Dsnopbai";
            return ketnoi.Execute(sql, name, values, parameter);
        }
    }
}
