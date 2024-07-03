using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

namespace ChucNang
{
    class GiaoVien_CN
    {
        KetNoi ketnoi = new KetNoi();
        public DataTable load_giaovien()
        {
            string sql = "Load_GiaoVien";
            return ketnoi.Load_Data(sql);
        }
        public int insert_giaovien(GiaoVien giaovien_public)
        {
            int parameter = 4;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MAGV";
            name[1] = "@TENGIAOVIEN";
            name[2] = "@GIOITINH";
            name[3] = "@NGAYSINH";
            values[0] = giaovien_public.MAGV;
            values[1] = giaovien_public.TENGV;
            values[2] = giaovien_public.GIOITINH;
            values[3] = giaovien_public.NGAYSINH;
            string sql = "Insert_GiaoVien";
            return ketnoi.Execute(sql, name, values, parameter);
        }
        public int update_giaovien(GiaoVien giaovien_public)
        {
            int parameter = 5;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MAGV";
            name[1] = "@MAGVOLD";
            name[2] = "@TENGIAOVIEN";
            name[3] = "@GIOITINH";
            name[4] = "@NGAYSINH";
            values[0] = giaovien_public.MAGV;
            values[1] = giaovien_public.MAGVOLD;
            values[2] = giaovien_public.TENGV;
            values[3] = giaovien_public.GIOITINH;
            values[4] = giaovien_public.NGAYSINH;
            string sql = "Update_GiaoVien";
            return ketnoi.Execute(sql, name, values, parameter);
        }
        public int delete_giaovien(GiaoVien giaovien_public)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MAGV";
            values[0] = giaovien_public.MAGV;
            string sql = "Delete_GiaoVien";
            return ketnoi.Execute(sql, name, values, parameter);
        }
        public GiaoVien load_giaovien_id(string giaovien_public)
        {
            string sql = "SELECT * FROM GIAOVIEN WHERE MAGV='" + giaovien_public + "'";

            DataTable table = ketnoi.Load_DataNotProcedure(sql);
            if(table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];
                GiaoVien gv = new GiaoVien()
                {
                    MAGV = row["MAGV"].ToString(),
                    TENGV = row["TENGIAOVIEN"].ToString(),
                    GIOITINH = row["GIOITINH"].ToString(),
                    NGAYSINH = DateTime.Parse(row["NGAYSINH"].ToString())
                };
                return gv;
            }
            return null;
        }
        public DataTable load_gv_PD(GiaoVien giaovien_public)
        {
            string sql = "SELECT TENGIAOVIEN,MAGV FROM giaovien WHERE MAGV='" + giaovien_public.MAGV + "'";
            return ketnoi.Load_DataNotProcedure(sql);
        }

        public string get_MaGV_ID(GiaoVien giaovien_public)
        {
            string sql = "SELECT MAGV FROM giaovien WHERE MAGV='" + giaovien_public.MAGV + "'";
            return ketnoi.ReturnString(sql);
        }
    }
}
