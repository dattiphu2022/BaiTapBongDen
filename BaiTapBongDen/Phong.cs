using BaiTapBongDen.Interfaces;
using BaiTapBongDen.Models;
using MrDHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapBongDen
{
    public partial class Phong : UserControl, IPhong, ICoDien, ICoThietBiDien
    {
        
        public Phong(int idPhong, bool codien)
        {
            this.IdPhong = idPhong;
            this.CoDien = codien;
            InitializeComponent();
            ThietBiDiens = new();
            ThietBiDiens.Add(new BongDen(idThietBi: 1, mau: Color.RebeccaPurple));
            ThietBiDiens.Add(new DieuHoa(idThietBi: 2));
            label1.Text = "phòng:"+idPhong.ToString();
        }
        bool DangBatDen = false;
        bool DangBatDieuHoa = false;
        public int IdPhong { get; set; }
        public bool CoDien { get; set; }
        public List<IThietBiDien> ThietBiDiens { get; protected set; }

        internal protected static bool BatThietBi(IThietBiDien thietBi)
        {
            if (thietBi == null)
            {
                return false;
            }
            thietBi.DangBat = true;
            return true;
        }
        internal protected static bool TatThietBi(IThietBiDien thietBi)
        {
            if (thietBi == null)
            {
                return false;
            }
            thietBi.DangBat = false;
            return true;
        }
        public void BatDen()
        {
            var bongDenTrongPhong = ThietBiDiens.
                Where(i => i.LoaiThietBi == Enums.LoaiThietBiEnum.BongDen);
            if (bongDenTrongPhong != null)
            {
                bongDenTrongPhong.ForEach((b) =>
                {
                    b.DangBat = true;
                });
            }
        }
        public void TatDen()
        {
            var bongDens = ThietBiDiens.
                Where(i => i.LoaiThietBi == Enums.LoaiThietBiEnum.BongDen);
            if (bongDens != null)
            {
                bongDens.ForEach((b) =>
                {
                    b.DangBat = false;
                });
            }
        }
        public void BatDieuHoa()
        {
            var bongDens = ThietBiDiens.
                Where(i => i.LoaiThietBi == Enums.LoaiThietBiEnum.DieuHoa);
            if (bongDens != null)
            {
                bongDens.ForEach((b) =>
                {
                    b.DangBat = true;
                });
            }
        }
        public void TatDieuHoa()
        {
            var dieuHoas = ThietBiDiens.
                Where(i => i.LoaiThietBi == Enums.LoaiThietBiEnum.DieuHoa);
            if (dieuHoas != null)
            {
                dieuHoas.ForEach((b) =>
                {
                    b.DangBat = false;
                });
            }
        }
        public void btnDen_Click(object sender, EventArgs e)
        {
            if (!DangBatDen)
            {
                BatDen();
                trangThaiDen.Checked = true;
            }
            else
            {
                TatDen();
                trangThaiDen.Checked = false;
            }
            DangBatDen = !DangBatDen;
        }        
        public void btnDieuHoa_Click(object sender, EventArgs e)
        {
            if (!DangBatDieuHoa)
            {
                BatDieuHoa();
                trangThaiDieuHoa.Checked = true;
            }
            else
            {
                TatDieuHoa();
                trangThaiDieuHoa.Checked = false;
            }
            DangBatDieuHoa = !DangBatDieuHoa;
        }
    }
}
