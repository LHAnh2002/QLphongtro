using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongTro.DTO
{
    class KhutroDTO
    {
        public int ID { get; set; }
        public string KhuTro { get; set; }
        public KhutroDTO(string TenKhu)
        {
            this.KhuTro = TenKhu;
        }
        public KhutroDTO(int id, string TenKhu)
        {
            this.ID = id;
            this.KhuTro = TenKhu;
        }

        public KhutroDTO(DataRow row)
        {
            this.ID = (int)row["ID_Khu"];
            this.KhuTro = row["TenKhu"].ToString();
        }
    }
}
