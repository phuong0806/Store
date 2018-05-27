﻿using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ViewModel
{
     public class SanPhamViewModel
    {
        public int ID { get; set; }

        public string TenSanPham { get; set; }

        public string MoTa { get; set; }

        
        public int Gia { get; set; }

        public string GiaString { get; set; }

       
        public string HinhAnh { get; set; }

        public int? MaPhuKien { get; set; }

        public int? MaThuongHieu { get; set; }

        public int? MaLoai { get; set; }

        public int? MaViTri { get; set; }

        public string TenThuongHieu { get; set; }

        public string TenLoai { get; set; }

        public string Mau { get; set; }
        public string  KichCo { get; set; }

    }
}
