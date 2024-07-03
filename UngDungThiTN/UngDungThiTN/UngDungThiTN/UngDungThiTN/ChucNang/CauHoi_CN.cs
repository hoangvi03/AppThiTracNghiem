using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Classes;
using System.Web.UI.WebControls;

namespace ChucNang
{
    public class CauHoi_CN
    {
        KetNoi ketnoi = new KetNoi();

        public DataTable load_dethi()
        {
            string sql = "SELECT * FROM DETHI";
            return ketnoi.Load_DataNotProcedure(sql);
        }
        public DataTable load_MonHoc()
        {
            string sql = "SELECT * FROM MonHoc";
            return ketnoi.Load_DataNotProcedure(sql);
        }
        public DataTable load_cauhoi(string madt)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MADETHI";
            values[0] = madt;
            string sql = "Load_CauHoi";
            return ketnoi.Load_DataWithParameter(sql, name, values, parameter);
        }
        public DataTable load_cauhoi_DeThi(string madt)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MADETHI";
            values[0] = madt;
            string sql = "Load_CauHoi";
            return ketnoi.Load_DataWithParameter(sql, name, values, parameter);
        }


        public DataTable load_cauhoi_chitiet(string noidung)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@NOIDUNG";
            values[0] = noidung;
            string sql = "load_cauhoi_chitiet";
            return ketnoi.Load_DataWithParameter(sql, name, values, parameter);
        }

        public int Check_CauHoi(string ch)
        {
            string sql = "SELECT COUNT(*) FROM CAUHOI WHERE NOIDUNG = N'" + ch + "'";
            return ketnoi.ReturnInteger(sql);
        }
        //public DataTable load_cauhoi_insert(CauHoi cauhoi_public)
        //{
        //    int parameter = 2;
        //    string[] name = new string[parameter];
        //    object[] values = new object[parameter];
        //    name[0] = "@MAMONHOC";
        //    name[1] = "@MADT";
        //    values[0] = cauhoi_public.MAMONHOC;
        //    values[1] = cauhoi_public.MADETHI;
        //    string sql = "SELECT cauhoi.noidung,cauhoi.DA1,cauhoi.DA2,cauhoi.DA3,cauhoi.DA4,cauhoi.DA,monhoc.TENMONHOC,cauhoi.DAPAN,cauhoi.MADT FROM CAUHOI INNER JOIN monhoc ON monhoc.MAMONHOC = cauhoi.MAMONHOC where cauhoi.MAMONHOC= @MAMONHOC AND CAUHOI.MADT = @MADT";
        //    return ketnoi.Load_DataWithParameterNotprocedure(sql, name, values, parameter);
        //}
        //public int insert_GV_in_DT(GiaoVien maGV, string made)
        //{
        //    int parameter = 2;
        //    string[] name = new string[parameter];
        //    object[] values = new object[parameter];
        //    name[0] = "@MAGV";
        //    name[1] = "@MADT";
        //    values[0] = maGV.MAGV;
        //    values[1] = made;
        //    string sql = "Insert_MAGV_in_DTHI";
        //    return ketnoi.Execute(sql, name, values, parameter);
        //}
        public int insert_cauhoi(CauHoi cauhoi_public)
        {
            int parameter = 8;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@NOIDUNG";
            name[1] = "@DA1";
            name[2] = "@DA2";
            name[3] = "@DA3";
            name[4] = "@DA4";
            name[5] = "@DA";
            name[6] = "@DAPAN";
            name[7] = "@MADETHI";
            values[0] = cauhoi_public.NOIDUNG;
            values[1] = cauhoi_public.DA1;
            values[2] = cauhoi_public.DA2;
            values[3] = cauhoi_public.DA3;
            values[4] = cauhoi_public.DA4;
            values[5] = cauhoi_public.DA;
            values[6] = cauhoi_public.DAPAN;
            values[7] = cauhoi_public.MADETHI;
            string sql = "Insert_CauHoi";
            return ketnoi.Execute(sql, name, values, parameter);
        }
        public int update_cauhoi(CauHoi cauhoi_public)
        {
            int parameter = 8;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@NOIDUNG";
            name[1] = "@NOIDUNGOLD";
            name[2] = "@DA1";
            name[3] = "@DA2";
            name[4] = "@DA3";
            name[5] = "@DA4";
            name[6] = "@DA";
            name[7] = "@DAPAN";
            values[0] = cauhoi_public.NOIDUNG;
            values[1] = cauhoi_public.NOIDUNGOLD;
            values[2] = cauhoi_public.DA1;
            values[3] = cauhoi_public.DA2;
            values[4] = cauhoi_public.DA3;
            values[5] = cauhoi_public.DA4;
            values[6] = cauhoi_public.DA;
            values[7] = cauhoi_public.DAPAN;
            string sql = "Update_CauHoi";
            return ketnoi.Execute(sql, name, values, parameter);
        }
        public int delete_cauhoi(CauHoi cauhoi_public)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@NOIDUNG";
            values[0] = cauhoi_public.NOIDUNG;
            string sql = "Delete_CauHoi";
            return ketnoi.Execute(sql, name, values, parameter);
        }
        public int delete_cauhoiDACHON(CauHoi cauhoi_public)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@NOIDUNG";
            values[0] = cauhoi_public.NOIDUNG;
            string sql = "Delete_CauHoiDaChon";
            return ketnoi.Execute(sql, name, values, parameter);
        }
       
        public int check_caudung(CauHoi cauhoi_public)
        {
            string sql = "SELECT COUNT(*) FROM cauhoi WHERE cauhoi.DA=N'" + cauhoi_public.DA + "' and cauhoi.noidung=N'" + cauhoi_public.NOIDUNG + "'";
            return ketnoi.ReturnInteger(sql);
        }
        public int TongCauHoi(string ma)
        {
            string sql = "SELECT COUNT(*) FROM CAUHOI WHERE MADT = '" + ma + "'";
            return ketnoi.ReturnInteger(sql);
        }

        public DataTable load_DapAn_CauHoi(string nd)
        {
            string sql = "SELECT * FROM CAUHOI WHERE NOIDUNG = N'" + nd + "'";
            return ketnoi.Load_DataNotProcedure(sql);
        }
    }
}
