﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI25
{
    class Program
    {
        static void Main(string[] args)
        {
            QuanLyCanBo qlcb = new QuanLyCanBo();
            qlcb.NhapCanBo();
            
            qlcb.XuatCanBo();

            qlcb.TimKiemCanBo();

            

            Console.ReadLine();
        }
    }
}
