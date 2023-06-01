namespace QLPhongTro.DTO
{
    class CtHopdongDTO
    {
        public int idhopdong { get; set; }
        public int id_cthopdong { get; set; }
   
        public int dathanhtoan { get; set; }
        public int csd_moi { get; set; }
        public int csn_moi { get; set; }
        public CtHopdongDTO( int idhopdong, int dathanhtoan)
        {
            this.idhopdong = idhopdong;
            this.dathanhtoan = dathanhtoan;
        }
        public CtHopdongDTO(int id_cthopdong, int csd_moi, int csn_moi)
        {
            this.id_cthopdong = id_cthopdong;
            this.csd_moi = csd_moi;
            this.csn_moi = csn_moi;
        }
        public CtHopdongDTO(int idhopdong)
        {
            this.idhopdong = idhopdong;
        }
        
    }
}
