using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongTro.DTO
{
    class LoaiphongDTO
    {
        public int ID_LoaiPhong { get; set; }
        public int DonGia { get; set; }
        public string LoaiPhong { get; set; }
        public LoaiphongDTO( string Loaiphong, int dongia)
        {
            this.DonGia = dongia;
            this.LoaiPhong = Loaiphong;
        }
        public LoaiphongDTO(int id_Loaiphong, string Loaiphong, int dongia)
        {
            this.ID_LoaiPhong = id_Loaiphong;
            this.LoaiPhong = Loaiphong;
            this.DonGia = dongia;
        }


    }
}
