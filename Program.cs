using System;
using System.Collections.Generic;

namespace QLy_NhanSu
{
    class Program
    {
        static void Main(string[] args)
        {
            //Khoi tao danh sach luu tru nhan vien, khach hang
            List<NhanVien> DSNV = new List<NhanVien>();
            List<KhachHang> DSKH = new List<KhachHang>();

            //data
            NhanVien nv1 = new NhanVien("NV01", "Thanh Nha", "Nu", "25/07/2000", "Cao dang");
            NhanVien nv2 = new NhanVien("NV02", "Huy Tran", "Nam", "14/02/1999", "Dai hoc");
            KhachHang kh1 = new KhachHang("KH01", "Thanh Cao", "Nam", "19/03/1995", "VipPro");
            KhachHang kh2 = new KhachHang("KH02", "Nguyen Nhi", "Nu", "09/12/2001", "ThanhVien");
            DSNV.Add(nv1);
            DSNV.Add(nv2);
            DSKH.Add(kh1);
            DSKH.Add(kh2);
            try
            {
                while (true)
                {
                    string selection;
                    Console.Clear();
                    menu();
                    Console.Write("Nhap lua chon: ");
                    selection = Console.ReadLine();
                    switch (selection)
                    {
                        case "ae":
                            addEmployee(DSNV);
                            break;
                        case "ac":
                            addCustomer(DSKH);
                            break;
                        case "dae":
                            dataEmployee(DSNV);
                            Console.ReadKey();
                            break;
                        case "dac":
                            dataCustomer(DSKH);
                            Console.ReadKey();
                            break;
                        case "cs":
                            thongke(DSKH);
                            Console.ReadKey();
                            break;
                        default:
                            Console.WriteLine("Nhap khong hop le!! Vui long nhap lai");
                            Console.ReadKey();
                            continue;
                    }

                }
            }
            
            catch(Exception EXC)
            {
                Console.WriteLine(EXC);
            }
        }
        static void menu()
        {
            Console.WriteLine("\n******Quan Ly Nhan Su******");
            Console.WriteLine("1. Them nhan vien (nhap ae)");
            Console.WriteLine("2. Them khach hang (nhap ac)");
            Console.WriteLine("3. Hien thi thong tin nhan vien (nhap dae)");
            Console.WriteLine("4. Hien thi thong tin khach hang (nhap dac)");
            Console.WriteLine("5. Thong ke khach hang (Nhap cs)");
            Console.WriteLine("****************************\n");
        }

        static void addEmployee(List<NhanVien> DSNV)
        {
            string MANV = "NV0" + Convert.ToString(DSNV.Count+1);
            Console.Write("Nhap ho ten nhan vien: ");
            string TEN = Console.ReadLine();
            Console.Write("Nhap gioi tinh: ");
            string GT = Console.ReadLine();
            Console.Write("Nhap ngay thang nam sinh: ");
            string NS = Console.ReadLine();
            Console.Write("Nhap bang cap: ");
            string BC = Console.ReadLine();
            NhanVien NV = new NhanVien(MANV, TEN, GT, NS, BC);
            DSNV.Add(NV);
        }
        static void addCustomer(List<KhachHang> DSKH) {
            string MAKH = "KH0" + Convert.ToString(DSKH.Count+1);
            Console.Write("Nhap ho ten nhan vien: ");
            string TEN = Console.ReadLine();
            Console.Write("Nhap gioi tinh: ");
            string GT = Console.ReadLine();
            Console.Write("Nhap ngay thang nam sinh: ");
            string NS = Console.ReadLine();
            KhachHang KH = new KhachHang(MAKH, TEN, GT, NS);
            DSKH.Add(KH);
        }
        static void dataEmployee(List<NhanVien> DSNV) 
        {
            foreach(NhanVien nv in DSNV)
            {
                nv.info();
            }
        }
        static void dataCustomer(List<KhachHang> DSKH)
        {
            foreach (KhachHang kh in DSKH)
            {
                kh.info();
            }
        }
        static void thongke(List<KhachHang> DSKH)
        {
            int KH_vjp = 0;
            int KH_ThanhVien = 0;
            int KH_Moi = 0;

            foreach (KhachHang kh in DSKH)
            {
                if(kh.LoaiKH == "VipPro") { KH_vjp += 1; }
                else if(kh.LoaiKH == "ThanhVien") { KH_ThanhVien += 1; }
                else if (kh.LoaiKH == "Moi") { KH_Moi += 1; }
            }
            Console.WriteLine("\n******Thong Ke so luong khach hang******");
            Console.WriteLine(" So khach hang Sieu cap VjpPro: {0}", KH_vjp);
            Console.WriteLine(" So khach hang Thanh vien: {0}", KH_ThanhVien);
            Console.WriteLine(" So khach hang Sieu cap VjpPro: {0}", KH_Moi);
            Console.WriteLine("***************************************\n");
        }
    }
}
