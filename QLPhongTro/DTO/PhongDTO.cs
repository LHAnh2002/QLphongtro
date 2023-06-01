namespace QLPhongTro.DTO
{
    class PhongDTO
    {
        public int ID_Phong { get; set; }
        public int ID_Loaiphong { get; set; }
        public int ID_Tang { get; set; }
        public string TenPhong { get; set; }
        public bool TrangThai { get; set; }
        public PhongDTO(int idtang, int idLoaiphong,string tenphong)
        {
            this.ID_Loaiphong = idLoaiphong;
            this.ID_Tang = idtang;
            this.TenPhong = tenphong;
        }

        public PhongDTO(int idphong,int idLoaiphong, int idtang, string tenphong, bool trangthai)
        {
            this.ID_Phong = idphong;
            this.ID_Loaiphong = idLoaiphong;
            this.ID_Tang = idtang;
            this.TenPhong = tenphong;
            this.TrangThai = trangthai;
        }

    }
}
