using System.Data;

namespace QLPhongTro.DTO
{
    class KhachhangDTO
    {
        public int ID_KhachHang { get; set; }
        public string Ho { get; set; }
        public string TenDem { get; set; }
        public string Ten { get; set; }
        public string CCCD { get; set; }
        public string sdt { get; set; }
        public string quequan { get; set; }
        public string hktt { get; set; }
        public bool trangthai { get; set; }
        public KhachhangDTO( string ho, string tendem,  string ten, string cccd, string sdt, string quequan, string hktt)
        {
            this.Ho = ho;
            this.TenDem = tendem;
            this.Ten = ten;
            this.CCCD = cccd;
            this.sdt = sdt;
            this.quequan = quequan;
            this.hktt = hktt;
        }

        public KhachhangDTO(int idkhachhang ,string ho, string tendem, string ten, string cccd, string sdt, string quequan, string hktt ,bool trangthai)
        {
            this.ID_KhachHang = idkhachhang;
            this.Ho = ho;
            this.TenDem = tendem;
            this.Ten = ten;
            this.CCCD = cccd;
            this.sdt = sdt;
            this.quequan = quequan;
            this.hktt = hktt;
            this.trangthai = trangthai;
        }


        public KhachhangDTO(DataRow row)
        {
            this.ID_KhachHang = (int)row["ID_KhachHang"];
            this.Ho = row["Ho"].ToString();
            this.TenDem = row["TenDem"].ToString();
            this.Ten = row["Ten"].ToString();
            this.CCCD = row["CCCD"].ToString();
            this.sdt = row["sdt"].ToString();
            this.quequan = row["QueQuan"].ToString();
            this.hktt = row["HKTT"].ToString();
        }
    }
}
