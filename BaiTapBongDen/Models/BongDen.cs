using BaiTapBongDen.Enums;
using BaiTapBongDen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapBongDen.Models
{
    public class BongDen : IThietBiDien
    {
        private Color mau;

        public BongDen(int idThietBi, Color mau)
        {
            IdThietBi = idThietBi;
            Mau = mau;
            DangBat = false;
        }

        public int IdThietBi { get; set; }
        public LoaiThietBiEnum LoaiThietBi { get; private set; } = LoaiThietBiEnum.BongDen;
        public Color Mau { get => DangBat ? mau : Color.Transparent; set => mau = value; }
        public bool DangBat { get; set; }
    }
}
