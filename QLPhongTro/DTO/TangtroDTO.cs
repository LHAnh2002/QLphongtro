namespace QLPhongTro.DTO
{
    class TangtroDTO
    {
        public int ID_Tang { get; set; }
        public int ID_Khu { get; set; }
        public string TenTang { get; set; }

        public TangtroDTO(string TenTang, int ID_Khu)
        {
            this.ID_Khu = ID_Khu;
            this.TenTang = TenTang;
        }

        public TangtroDTO(int id_tang, string TenTang, int ID_Khu)
        {
            this.ID_Tang = id_tang;
            this.TenTang = TenTang;
            this.ID_Khu = ID_Khu;
        }
    }
}
