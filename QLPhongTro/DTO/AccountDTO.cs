using System.Data;

namespace QLPhongTro.DTO
{
    public class AccountDTO
    {
        public string taikhoan { get; set; }
        public string matkhau { get; set; }
        public string newpass { get; set; }
        public string tenchutro { get; set; }
        public string chuphongtro { get; set; }
        public string diachiphongtro { get; set; }
        public int dongiadien { get; set; }
        public int dongianuoc { get; set; }
        public string sodienthoai { get; set; }
        public int idtype { get; set; }

        public AccountDTO (string taikhoan, string tenphongtro, string chuphongtro, string diachiphongtro, int dongiadien, int dongianuoc, string sodienthoai)
        {
            this.taikhoan = taikhoan;
            this.tenchutro = tenphongtro;
            this.chuphongtro = chuphongtro;
            this.diachiphongtro = diachiphongtro;
            this.dongiadien = dongiadien;
            this.dongianuoc = dongianuoc;
            this.sodienthoai = sodienthoai;
           
        }
        public AccountDTO(string taikhoan,string matkhau, string tenphongtro, string chuphongtro, string diachiphongtro,string sodienthoai, int idtype)
        {
            this.taikhoan = taikhoan;
            this.matkhau = matkhau;
            this.tenchutro = tenphongtro;
            this.chuphongtro = chuphongtro;
            this.diachiphongtro = diachiphongtro;
            this.sodienthoai = sodienthoai;
            this.idtype = idtype;
        }
        public AccountDTO(string taikhoan, string matkhau)
        {
            this.taikhoan = taikhoan;
            this.matkhau = matkhau;
        }
        public AccountDTO(string taikhoan, string matkhau,string newpass)
        {
            this.taikhoan = taikhoan;
            this.matkhau = matkhau;
            this.newpass = newpass;
        }
        public AccountDTO(DataRow row)
        {
            this.taikhoan = row["taikhoan"].ToString();
            this.matkhau = row["matkhau"].ToString();
            this.tenchutro = row["Tenphongtro"].ToString();
            this.chuphongtro = row["Chuphongtro"].ToString();
            this.diachiphongtro = row["Diachiphongtro"].ToString();
            this.dongiadien = (int)row["Dongiadien"];
            this.dongianuoc = (int)row["Dongianuoc"];
            this.sodienthoai = row["SDT"].ToString();
            this.idtype = (int)row["IDtype"];
        }
    }
}
