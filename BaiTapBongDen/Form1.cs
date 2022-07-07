namespace BaiTapBongDen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                var phongI = new Phong(idPhong:i, codien:true);
                phongI.BorderStyle = BorderStyle.FixedSingle;
                
                flowLayoutPanel1.Controls.Add(phongI);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var idChonPhong = (int)numericUpDown1.Value;

            var phongUC_ById = flowLayoutPanel1.Controls.OfType<Phong>()
                .FirstOrDefault(p => p.IdPhong == idChonPhong);

            phongUC_ById?.btnDen.PerformClick();
        }
    }
}