
using System.Data;

namespace QLPhongTro.DTO
{
    class HopdongDTO
    {   
        public int ID_Hopdong { get; set; }
        public int ID_Phong { get; set; }
        public string TenPhong { get; set; }
        public int TienDien { get; set; }
        public int TienNuoc { get; set; }
        public int giaphong { get; set; }
        public int TienInterter { get; set; }
        public int Tienvesinh { get; set; }
        public int Canthanhtoan { get; set; }
        public int Datcoc { get; set; }
        public bool DaKetThuc { get; set; }
        public int Dongiadien { get; set; }
        public int Dongianuoc { get; set; }
        public int sotientra { get; set; }
        public HopdongDTO( int idphong,int giaphong,  int datcoc, int dongiadien, int dongianuoc)
        {
            this.ID_Phong = idphong;
            this.giaphong = giaphong;
            this.Datcoc = datcoc;
            this.Dongiadien = dongiadien;
            this.Dongianuoc = dongianuoc;
        }
        public HopdongDTO(int idhopdong, int idphong, int datcoc, int giaphong, bool daketthuc, int dongiadien, int dongianuoc)
        { 
            this.ID_Hopdong = idhopdong;
            this.ID_Phong = idphong;
            this.Datcoc = datcoc;
            this.giaphong = giaphong;
            this.DaKetThuc = daketthuc;
            this.Dongiadien = dongiadien;
            this.Dongianuoc = dongianuoc;
        }
        public HopdongDTO(int idhopdong)
        {
            this.ID_Hopdong = idhopdong;
        }
        public HopdongDTO(int idhopdong, int sotientra)
        {
            this.ID_Hopdong = idhopdong;
            this.sotientra = sotientra;
        }
        public HopdongDTO(DataRow row)
        {
            this.TenPhong = row["TenPhong"].ToString();
            this.TienDien = (int)row["TienDien"];
            this.TienNuoc = (int)row["TienNuoc"];
            this.TienInterter = (int)row["TienInterter"];
            this.Tienvesinh = (int)row["Tienvesinh"];
            this.Canthanhtoan = (int)row["Canthanhtoan"];
        }
    }
}
