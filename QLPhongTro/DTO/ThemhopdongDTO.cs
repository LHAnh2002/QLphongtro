using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongTro.DTO
{
    class ThemhopdongDTO
    {   
        public int id_phong { get; set; }
        public int dat_coc { get; set; }
        public DateTime ngaybatdau { get; set; }
        public DateTime ngayketthuc { get; set; }
        public int csn_cu { get; set; }
        public int csd_cu { get; set; }
        public int tienvesinh { get; set; }
        public int tieninternet { get; set; }

        public ThemhopdongDTO(DateTime ngaybatdau, DateTime ngayketthuc, int csncu, int csdcu)
        {
            this.ngaybatdau = ngaybatdau;
            this.ngayketthuc = ngayketthuc;
            this.csd_cu = csdcu;
            this.csn_cu = csncu;
        }
        public ThemhopdongDTO(int idphong,int datcoc, int tienvesinh, int tieninternet)
        {
            this.id_phong = idphong;
            this.dat_coc = datcoc;
            this.tienvesinh = tienvesinh;
            this.tieninternet = tieninternet;
        }
       

    }
}
