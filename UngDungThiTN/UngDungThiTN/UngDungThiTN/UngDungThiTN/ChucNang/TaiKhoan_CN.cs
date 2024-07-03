using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

namespace ChucNang
{
    class TaiKhoan_CN
    {
        KetNoi ketnoi = new KetNoi();
        public DataTable load_taikhoan()
        {
            string sql = "Load_TaiKhoan";
            return ketnoi.Load_Data(sql);
        }
        public TaiKhoan load_taikhoan_GV_id(string Id)
        {
            string sql = "SELECT * FROM TAIKHOAN_GV WHERE IDTAIKHOAN = '" + Id + "'";

            DataTable table = ketnoi.Load_DataNotProcedure(sql);
            if (table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];
                TaiKhoan tk = new TaiKhoan()
                {
                    TENTK = row["TENTK"].ToString(),
                    MATKHAU = row["MATKHAU"].ToString(),
                    IDTAIKHOAN = row["IDTAIKHOAN"].ToString(),
                    QUYEN = row["QUYEN"].ToString()
                };
                return tk;
            }
            return null;
        }
        public int insert_taikhoan(TaiKhoan taikhoan_public, string loai)
        {
            int parameter = 4;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@TENTK";
            name[1] = "@MATKHAU";
            name[2] = "@IDTAIKHOAN";
            name[3] = "@QUYEN";
            values[0] = taikhoan_public.TENTK;
            values[1] = taikhoan_public.MATKHAU;
            values[2] = taikhoan_public.IDTAIKHOAN;
            values[3] = taikhoan_public.QUYEN;
            string sql = "Insert_TaiKhoan_" + loai;
            return ketnoi.Execute(sql, name, values, parameter);
        }
        public int update_taikhoan(TaiKhoan taikhoan_public, string loai)
        {
            int parameter = 2;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MATKHAU";
            name[1] = "@IDTAIKHOAN";
            values[0] = taikhoan_public.MATKHAU;
            values[1] = taikhoan_public.IDTAIKHOAN;
            string sql = "Update_TaiKhoan_" + loai;
            return ketnoi.Execute(sql, name, values, parameter);
        }
        public int delete_taikhoan(TaiKhoan taikhoan_public)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@TENTK";
            values[0] = taikhoan_public.TENTK;
            string sql = "Delete_TaiKhoan";
            return ketnoi.Execute(sql, name, values, parameter);
        }
        public int check_dangnhap_TS(TaiKhoan taikhoan_public)
        {
            string sql = "SELECT COUNT(*) FROM TAIKHOAN_TS WHERE TENTK='" + taikhoan_public.TENTK + "' AND MATKHAU='" + taikhoan_public.MATKHAU + "'";
            return ketnoi.ReturnInteger(sql);
        }
        public int check_dangnhap_GV(TaiKhoan taikhoan_public)
        {
            string sql = "SELECT COUNT(*) FROM TAIKHOAN_GV WHERE TENTK='" + taikhoan_public.TENTK + "' AND MATKHAU='" + taikhoan_public.MATKHAU + "'";
            return ketnoi.ReturnInteger(sql);
        }
        public string check_quyentaikhoan_TS(TaiKhoan taikhoan_public)
        {
            string sql = "SELECT QUYEN FROM TAIKHOAN_TS WHERE TENTK='" + taikhoan_public.TENTK + "' AND MATKHAU='" + taikhoan_public.MATKHAU + "'";
            return ketnoi.ReturnString(sql);
        }
        public string check_quyentaikhoan_GV(TaiKhoan taikhoan_public)
        {
            string sql = "SELECT QUYEN FROM TAIKHOAN_GV WHERE TENTK='" + taikhoan_public.TENTK + "' AND MATKHAU='" + taikhoan_public.MATKHAU + "'";
            return ketnoi.ReturnString(sql);
        }
        public string get_IDTAIKHOAN_TS(TaiKhoan taikhoan_public)
        {
            string sql = "SELECT IDTAIKHOAN FROM TAIKHOAN_TS WHERE TENTK='" + taikhoan_public.TENTK + "' AND MATKHAU='" + taikhoan_public.MATKHAU + "'";
            return ketnoi.ReturnString(sql);
        }
        public string get_IDTAIKHOAN_GV(TaiKhoan taikhoan_public)
        {
            string sql = "SELECT IDTAIKHOAN FROM TAIKHOAN_GV WHERE TENTK='" + taikhoan_public.TENTK + "' AND MATKHAU='" + taikhoan_public.MATKHAU + "'";
            return ketnoi.ReturnString(sql);
        }



    }
}
