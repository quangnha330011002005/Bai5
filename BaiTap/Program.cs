using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
            // Console.ReadLine();
        }
        static void menu()
        {
            QuanLyCD quanlyCD = new QuanLyCD(); //tạo đối tượng QuanLyCD
            int chon = 0;
            do
            {
                Console.WriteLine("**********Chuong trinh quan ly CD*********");
                Console.WriteLine("1. Them CD");
                Console.WriteLine("2. Tinh gia thanh trung binh");
                Console.WriteLine("3. Sap xep CD giam dan them gia thanh");
                Console.WriteLine("4. Sap xep CD tang dan theo tua CD");
                Console.WriteLine("5. Xuat toan bo CD");
                Console.WriteLine("0. Thoat chuong trinh.");
                Console.WriteLine("-----------------------------------------");
                Console.Write("Ban chon:");
                    chon = int.Parse(Console.ReadLine());
                    switch (chon)
                    {
                        case 1:
                        //xu ly them CD
                        CD cd = new CD();
                            Console.Write("Nhap ma cd:");
                            cd.MaCD = int.Parse(Console.ReadLine());
                            Console.Write("Nhap tua CD:");
                            cd.tuaCD = Console.ReadLine();
                            Console.Write("Nhap ca si:");
                            cd.casy = Console.ReadLine();
                            Console.Write("Nhap so bai hat:");
                            cd.sobaihat = int.Parse(Console.ReadLine());
                            Console.Write("Nhap gia thanh:");
                            cd.giathanh = int.Parse(Console.ReadLine());
                            quanlyCD.ThemCD(cd);
                            break;
                        case 2: //xu ly tinh gia thanh trung binh
                            double kq = quanlyCD.tinhGiaTB();
                            Console.WriteLine("Gia thanh trung binh : {0:#,##0.00}", kq);
                            break;
                       case 3: //sap xep theo gia thanh giam dan
                           quanlyCD.SapXepGiamTheoGiaThanh();
                          Console.WriteLine("Da sap them theo gia thanh giam dan");
                            break;
                        case 4: //sap xep theo tua cd
                        quanlyCD.SapXepTheoTuaCDTangDan();
                        Console.WriteLine("Da sap xep tua cd theo thu tu tang dan");
                            break;
                        case 5:
                            quanlyCD.Xuat();
                            break;
                      case 0:
                            Console.WriteLine("Tam biet. Hen gap lai.");
                           Console.ReadLine();
                            break;
                    }
                } while (chon != 0);
            }

         }   
    }
   

