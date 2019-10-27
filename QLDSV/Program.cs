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
            DangKyTableAdapter = new DangKyTableAdapter()
        };

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
            //SPs

        }
        private static void InitServices()
        {
            TableAdapterManager.Connection = KetNoiDB.SqlConnection;
            FillAllTable();
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
                    Application.Run(new FormMain());
                }
            }
        }
    }
}
