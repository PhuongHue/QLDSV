using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using KetNoi;
using BatLoi;
using System.Data.SqlClient;
using QLDSV.QLDSVDataSetKhoaTableAdapters;

namespace QLDSV
{
    static class Program
    {
        public static bool running = true;
        public static KetNoiDB KetNoiDB = new KetNoiDB();
        public static QLDSVDataSetKhoa QLDSVDataSetKhoa = new QLDSVDataSetKhoa();
        public static TableAdapterManager TableAdapterManager = new TableAdapterManager()
        {
            KhoaTableAdapter = new KhoaTableAdapter(),
            GiangVienTableAdapter = new GiangVienTableAdapter(),
            CTTruongKhoaTableAdapter = new CTTruongKhoaTableAdapter(),
            MonHocTableAdapter = new MonHocTableAdapter(),
            KhaNangDayTableAdapter = new KhaNangDayTableAdapter(),
            LopTableAdapter = new LopTableAdapter(),
            ChuyenNganhTableAdapter = new ChuyenNganhTableAdapter(),
            SinhVienTableAdapter = new SinhVienTableAdapter(),
            LopTinChiTableAdapter = new LopTinChiTableAdapter(),
            CTLopTCTableAdapter = new CTLopTCTableAdapter(),
            KeHoachGiangTableAdapter = new KeHoachGiangTableAdapter(),
            DangKyTableAdapter = new DangKyTableAdapter(),
            V_NhapDiemTableAdapter = new V_NhapDiemTableAdapter()
        };
        public static SP_List_LOGINTableAdapter SP_List_LOGINTableAdapter = new SP_List_LOGINTableAdapter();
        public static SP_List_SV_DangKy_LopTCTableAdapter SP_List_SV_DangKy_LopTCTableAdapter = new SP_List_SV_DangKy_LopTCTableAdapter();
        public static void FillAllTable()
        {
            try
            {
                // fill tables
                TableAdapterManager.KhoaTableAdapter.Fill(QLDSVDataSetKhoa.Khoa);
                TableAdapterManager.GiangVienTableAdapter.Fill(QLDSVDataSetKhoa.GiangVien);
                TableAdapterManager.CTTruongKhoaTableAdapter.Fill(QLDSVDataSetKhoa.CTTruongKhoa);
                TableAdapterManager.MonHocTableAdapter.Fill(QLDSVDataSetKhoa.MonHoc);
                TableAdapterManager.KhaNangDayTableAdapter.Fill(QLDSVDataSetKhoa.KhaNangDay);
                TableAdapterManager.LopTableAdapter.Fill(QLDSVDataSetKhoa.Lop);
                TableAdapterManager.ChuyenNganhTableAdapter.Fill(QLDSVDataSetKhoa.ChuyenNganh);
                TableAdapterManager.SinhVienTableAdapter.Fill(QLDSVDataSetKhoa.SinhVien);
                TableAdapterManager.LopTinChiTableAdapter.Fill(QLDSVDataSetKhoa.LopTinChi);
                TableAdapterManager.CTLopTCTableAdapter.Fill(QLDSVDataSetKhoa.CTLopTC);
                TableAdapterManager.KeHoachGiangTableAdapter.Fill(QLDSVDataSetKhoa.KeHoachGiang);
                TableAdapterManager.DangKyTableAdapter.Fill(QLDSVDataSetKhoa.DangKy);
                TableAdapterManager.V_NhapDiemTableAdapter.Fill(QLDSVDataSetKhoa.V_NhapDiem);
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show(SqlMessageResolver.SqlMessageResolve(e.Message));
            }

        }
        public static void UpdateAll()
        {
            try
            {
                TableAdapterManager.UpdateAll(QLDSVDataSetKhoa);
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show(SqlMessageResolver.SqlMessageResolve(e.Message));
            }
            catch (ArgumentException e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public static void ChangeConnection(SqlConnection sqlConnection)
        {
            //Tables
            TableAdapterManager.Connection = sqlConnection;
            TableAdapterManager.KhoaTableAdapter.Connection = sqlConnection;
            TableAdapterManager.GiangVienTableAdapter.Connection = sqlConnection;
            TableAdapterManager.CTTruongKhoaTableAdapter.Connection = sqlConnection;
            TableAdapterManager.MonHocTableAdapter.Connection = sqlConnection;
            TableAdapterManager.KhaNangDayTableAdapter.Connection = sqlConnection;
            TableAdapterManager.LopTableAdapter.Connection = sqlConnection;
            TableAdapterManager.ChuyenNganhTableAdapter.Connection = sqlConnection;
            TableAdapterManager.SinhVienTableAdapter.Connection = sqlConnection;
            TableAdapterManager.LopTinChiTableAdapter.Connection = sqlConnection;
            TableAdapterManager.CTLopTCTableAdapter.Connection = sqlConnection;
            TableAdapterManager.KeHoachGiangTableAdapter.Connection = sqlConnection;
            TableAdapterManager.DangKyTableAdapter.Connection = sqlConnection;
            //SPs
            SP_List_LOGINTableAdapter.Connection = sqlConnection;
            SP_List_SV_DangKy_LopTCTableAdapter.Connection = sqlConnection;
        }
        private static void InitServices()
        {
            TableAdapterManager.Connection = KetNoiDB.SqlConnection;
            FillAllTable();
            SP_List_LOGINTableAdapter.Connection = KetNoiDB.SqlConnection;
            SP_List_SV_DangKy_LopTCTableAdapter.Connection = KetNoiDB.SqlConnection;
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");

            while (running)
            {
                Application.Run(new FormDangNhap());
                if (KetNoiDB.Ready)
                {
                    InitServices();
                    if (KetNoiDB.GroupId == "SinhVien") Application.Run(new FormDangKyLTC());
                    else Application.Run(new FormMain());
                }
            }
        }
    }
}
