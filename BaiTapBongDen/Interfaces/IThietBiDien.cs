using BaiTapBongDen.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapBongDen.Interfaces
{
    public interface IThietBiDien
    {
        public int IdThietBi { get; set; }
        public bool DangBat { get; set; }
        public LoaiThietBiEnum LoaiThietBi { get; }
    }
}
