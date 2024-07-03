using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

namespace ChucNang
{
    public class MonHoc_CN
    {
        KetNoi ketnoi = new KetNoi();
        public DataTable load_monhoc()
        {
            string sql = "Load_MonHoc";
            return ketnoi.Load_Data(sql);
        }

        public MonHoc load_monhoc_id(string mamonhoc)
        {
            string sql = "SELECT * FROM MONHOC WHERE MAMONHOC='" + mamonhoc + "'";

            DataTable table = ketnoi.Load_DataNotProcedure(sql);
            if (table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];
                MonHoc mh = new MonHoc()
                {
                    MAMONHOC = row["MAMONHOC"].ToString(),
                    TENMONHOC = row["TENMONHOC"].ToString(),
                    TGTHI = int.Parse(row["TGTHI"].ToString())
                };
                return mh;
            }
            return null;
        }

        public DataTable load_dethi()
        {
            string sql = "SELECT MADT FROM DETHI";
            return ketnoi.Load_DataNotProcedure(sql);
        }
        
        public string get_TGthi_MonThi(string ma)
        {
            string sql = "SELECT TGTHI FROM MONHOC WHERE MAMONHOC = '" + ma + "'";
            return ketnoi.ReturnString(sql);
        }

        public DataTable load_monhocwithwhere(MonHoc monhoc)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MAMONHOC";
            values[0] = monhoc.MAMONHOC;
            string sql = "Load_MonHocWith_Where";
            return ketnoi.Load_DataWithParameter(sql, name, values, parameter);
        }
        public int insert_monhoc(MonHoc monhoc)
        {
            int parameter = 3;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MAMONHOC";
            name[1] = "@TENMONHOC";
            name[2] = "@TGTHI";
            values[0] = monhoc.MAMONHOC;
            values[1] = monhoc.TENMONHOC;
            values[2] = monhoc.TGTHI;
            string sql = "Insert_MonHoc";
            return ketnoi.Execute(sql, name, values, parameter);
        }
        public int update_monhoc(MonHoc monhoc)
        {
            int parameter = 4;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MAMONHOC";
            name[1] = "@MAMONHOCOLD";
            name[2] = "@TENMONHOC";
            name[3] = "@TGTHI";
            values[0] = monhoc.MAMONHOC;
            values[1] = monhoc.MAMONHOCOLD;
            values[2] = monhoc.TENMONHOC;
            values[3] = monhoc.TGTHI;
            string sql = "Update_MonHoc";
            return ketnoi.Execute(sql, name, values, parameter);
        }
        public int delete_monhoc(MonHoc monhoc)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MAMONHOC";
            values[0] = monhoc.MAMONHOC;
            string sql = "Delete_MonHoc";
            return ketnoi.Execute(sql, name, values, parameter);
        }
        public DataTable load_made()
        {
            string sql = "SELECT * FROM iddethi";
            return ketnoi.Load_DataNotProcedure(sql);
        }
    }
}
