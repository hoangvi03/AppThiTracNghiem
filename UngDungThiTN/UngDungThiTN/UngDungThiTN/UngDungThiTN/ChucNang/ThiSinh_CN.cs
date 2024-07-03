using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

namespace ChucNang
{
    class ThiSinh_CN
    {
        KetNoi ketnoi = new KetNoi();
        public DataTable load_thisinh()
        {
            string sql = "Load_ThiSinh";
            return ketnoi.Load_Data(sql);
        }
        public DataTable load_TenThiSinh(string ma)
        {
            string sql = "SELECT * FROM TENTHISINH WHERE MATS = '" + ma + "'";
            return ketnoi.Load_DataNotProcedure (sql);
        }

        public ThiSinh load_thisinh_id(string thisinh)
        {
            string sql = "SELECT * FROM THISINH WHERE MATS='" + thisinh + "'";

            DataTable table = ketnoi.Load_DataNotProcedure(sql);
            if (table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];
                ThiSinh ts = new ThiSinh()
                {
                    MATS = row["MATS"].ToString(),
                    TENTHISINH = row["TENTHISINH"].ToString(),
                    GIOITINH = row["GIOITINH"].ToString(),
                    NGAYSINH = DateTime.Parse(row["NGAYSINH"].ToString())
                };
                return ts;
            }
            return null;
        }

        public int insert_thisinh(ThiSinh thisinh_public)
        {
            int parameter = 4;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MATS";
            name[1] = "@TENTHISINH";
            name[2] = "@GIOITINH";
            name[3] = "@NGAYSINH";
            values[0] = thisinh_public.MATS;
            values[1] = thisinh_public.TENTHISINH;
            values[2] = thisinh_public.GIOITINH;
            values[3] = thisinh_public.NGAYSINH;
            string sql = "Insert_ThiSinh";
            return ketnoi.Execute(sql, name, values, parameter);
        }
        public int update_thisinh(ThiSinh thisinh_public)
        {
            int parameter = 5;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MATS";
            name[1] = "@MATSOLD";
            name[2] = "@TENTHISINH";
            name[3] = "@GIOITINH";
            name[4] = "@NGAYSINH";
            values[0] = thisinh_public.MATS;
            values[1] = thisinh_public.MATSOLD;
            values[2] = thisinh_public.TENTHISINH;
            values[3] = thisinh_public.GIOITINH;
            values[4] = thisinh_public.NGAYSINH;
            string sql = "Update_ThiSinh";
            return ketnoi.Execute(sql, name, values, parameter);
        }
        public int delete_thisinh(ThiSinh thisinh_public)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MATS";
            values[0] = thisinh_public.MATS;
            string sql = "Delete_ThiSinh";
            return ketnoi.Execute(sql, name, values, parameter);
        }
        public DataTable load_thisinh_voidieukien(ThiSinh thisinh_public)
        {
            string sql = "select thisinh.TENTHISINH,thisinh.MATS,thisinh.GIOITINH,hinhts.HINH from thisinh inner join hinhts on thisinh.MATS=hinhts.MATS where thisinh.MATS='" + thisinh_public.MATS + "'";
            return ketnoi.Load_DataNotProcedure(sql);
        }
        public DataTable load_ts_PD(ThiSinh thisinh_public)
        {
            string sql = "SELECT TENTHISINH,MATS FROM thisinh WHERE MATS='" + thisinh_public.MATS + "'";
            return ketnoi.Load_DataNotProcedure(sql);
        }

        public DataTable loadCauHoiDeThi(string ma)
        {
            string sql = "SELECT NOIDUNG, DA1,DA2,DA3,DA4 FROM CAUHOI WHERE MADT = '" + ma + "'";
            return ketnoi.Load_DataNotProcedure(sql);
        }
    }
}
