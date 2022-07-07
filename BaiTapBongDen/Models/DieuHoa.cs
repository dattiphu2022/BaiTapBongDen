using BaiTapBongDen.Enums;
using BaiTapBongDen.Interfaces;

namespace BaiTapBongDen.Models
{
    public class DieuHoa: IThietBiDien
    {
        public DieuHoa(int idThietBi)
        {
            IdThietBi = idThietBi;
            DangBat = false;
        }

        public LoaiThietBiEnum LoaiThietBi { get; private set; } = LoaiThietBiEnum.DieuHoa;
        public int IdThietBi { get; set; }
        public bool DangBat { get; set; }
    }
}