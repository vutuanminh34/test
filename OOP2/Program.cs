using System;
using System.Collections.Generic;

namespace OOP2
{
    class Officers
    {
        public string fullName { get; set; }
        public int yearOfBirth { get; set; }
        public string gender { get; set; }
        public string address { get; set; }

        public Officers()
        {
                
        }
        public virtual void inputInfor()
        {
            Console.WriteLine("Ho ten: ");
            fullName = Console.ReadLine();
            Console.WriteLine("Nam sinh: ");
            yearOfBirth = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Gioi tinh: ");
            gender = Console.ReadLine();
            Console.WriteLine("Dia chi: ");
            address = Console.ReadLine();
        }

        public virtual void showInfor()
        {
            Console.Write("Ho ten: {0}, Gioi tinh: {1}, Nam sinh: {2}, Dia chi: {3}", fullName, gender, yearOfBirth, address);
        }

        public string getName()
        {
            return fullName;
        }
    }

    class Worker : Officers
    {
        public int level { get; set; }

        public Worker()
        {

        }
        
        public override void inputInfor()
        {
            base.inputInfor();
            Console.WriteLine("Bac: ");
            level = Int32.Parse(Console.ReadLine());
        }

        public override void showInfor()
        {
            base.showInfor();
            Console.WriteLine(", Bac: " + level);
        }
    }

    class Employee : Officers
    {
        public string job { get; set; }
        public Employee()
        {

        }
        public override void inputInfor()
        {
            base.inputInfor();
            Console.WriteLine("Cong viec: ");
            job = Console.ReadLine();
        }

        public override void showInfor()
        {
            base.showInfor();
            Console.WriteLine(", Cong viec: " + job);
        }
    }

    class Engineer : Officers
    {
        public string major { get; set; }
        public Engineer()
        {

        }

        public override void inputInfor()
        {
            base.inputInfor();
            Console.WriteLine("Nganh dao tao: ");
            major = Console.ReadLine();
        }

        public override void showInfor()
        {
            base.showInfor();
            Console.WriteLine(", Nganh dao tao: " + major);
        }
    }

    class OfficerManagement
    {
        public List<Officers> listOfficers { get; set; }

        public OfficerManagement()
        {
            listOfficers = new List<Officers>();
        }
        public void input()
        {
            Officers cb = new Officers();
            Console.WriteLine("So can bo muon nhap vao: ");
            int scb = Int32.Parse(Console.ReadLine());
            for(int i = 0; i < scb; i++)
            {
                Console.WriteLine("Can bo thu " + (i + 1) + " la(1 - cong nhan, 2 - nhan vien, 3 - ky su): ");
                int type = Int32.Parse(Console.ReadLine());
                switch (type)
                {
                    case 1:
                        cb = new Worker();
                        break;
                    case 2:
                        cb = new Employee();
                        break;
                    case 3:
                        cb = new Engineer();
                        break;
                    default:
                        break;
                }
                cb.inputInfor();
                listOfficers.Add(cb);
            }
        }

        public void show()
        {
            foreach(Officers cb in listOfficers)
            {
                cb.showInfor();
            }
        }

        public void search(string name)
        {
            foreach(Officers cb in listOfficers)
            {
                if (name.Equals(cb.getName()))
                    cb.showInfor();
            }
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            OfficerManagement om = new OfficerManagement();
            om.input();
            Console.WriteLine("--Thong tin can bo--");
            om.show();
            Console.WriteLine("Nhap ten can bo can tim: ");
            string name = Console.ReadLine();
            om.search(name);

        }
    }
}
