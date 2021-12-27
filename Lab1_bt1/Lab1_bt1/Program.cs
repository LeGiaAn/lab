using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_bt1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ứng viên 1
            Console.WriteLine("Chuong trinh nhap xuat thong tin ung vien");
            Console.WriteLine("=========================================");
            Console.WriteLine("***Moi nhap ung vien so 1");
            Console.Write("Nhap ho ten: ");
            string ten = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            string namsinh= Console.ReadLine();
            Console.Write("Nhap gioi tinh: ");
            string goitinh = Console.ReadLine();
            Console.Write("Nhap chieu cao: ");
            string chieucao = Console.ReadLine();
            Console.Write("Nhap can nang: ");
            string cannang = Console.ReadLine();
            Console.Write("Nhap que quan: ");
            string quequan = Console.ReadLine();
            Console.Write("Nhap chuyen nganh: ");
           string chuyennganh = Console.ReadLine();
            Console.Write("Nhap diem tb: ");
           string diemtb = Console.ReadLine();

            //ứng viên 2
            Console.WriteLine("***Moi nhap ung vien so 2");
            Console.Write("Nhap ho ten: ");
            string ten1= Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            string namsinh1 = Console.ReadLine();
            Console.Write("Nhap gioi tinh: ");
            string goitinh1= Console.ReadLine();
            Console.Write("Nhap chieu cao: ");
            string chieucao1= Console.ReadLine();
            Console.Write("Nhap can nang: ");
            string cannang1= Console.ReadLine();
            Console.Write("Nhap que quan: ");
            string quequan1= Console.ReadLine();
            Console.Write("Nhap chuyen nganh: ");
            string chuyennganh1= Console.ReadLine();
            Console.Write("Nhap diem tb: ");
            string diemtb1= Console.ReadLine();

            //ứng viên 3
            Console.WriteLine("***Moi nhap ung vien so 3");
            Console.Write("Nhap ho ten: ");
            string ten2= Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            string namsinh2= Console.ReadLine();
            Console.Write("Nhap gioi tinh: ");
            string goitinh2= Console.ReadLine();
            Console.Write("Nhap chieu cao: ");
            string chieucao2= Console.ReadLine();
            Console.Write("Nhap can nang: ");
            string cannang2= Console.ReadLine();
            Console.Write("Nhap que quan: ");
            string quequan2= Console.ReadLine();
            Console.Write("Nhap chuyen nganh: ");
           string chuyennganh2= Console.ReadLine();
            Console.Write("Nhap diem tb: ");
           string diemtb2= Console.ReadLine();


            Console.WriteLine("STT  HO TEN     NAM SINH    GIOI TINH       CHIEU CAO       CAN NANG      QUE QUAN    CHUYEN NGANH       DTB");
            Console.WriteLine("============================================================================================================");

            Console.WriteLine("{0}   {1}      {2}       {3}      {4}      {5}       {6}       {7}        {8}", 1, ten, namsinh, goitinh, chieucao, cannang, quequan, chuyennganh, diemtb);
            Console.WriteLine("{0}   {1}      {2}       {3}      {4}      {5}       {6}       {7}        {8}", 2, ten1, namsinh1, goitinh1, chieucao1, cannang1, quequan1, chuyennganh1, diemtb1);
            Console.WriteLine("{0}   {1}      {2}       {3}      {4}      {5}       {6}       {7}        {8}", 3, ten2, namsinh2, goitinh2, chieucao2, cannang2, quequan2, chuyennganh2, diemtb2);
            Console.ReadKey()
        }
    }
}
