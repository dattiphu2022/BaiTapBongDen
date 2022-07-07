namespace BaiTapBongDen
{
    partial class Phong
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDen = new System.Windows.Forms.Button();
            this.btnDieuHoa = new System.Windows.Forms.Button();
            this.trangThaiDen = new System.Windows.Forms.CheckBox();
            this.trangThaiDieuHoa = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDen
            // 
            this.btnDen.Location = new System.Drawing.Point(15, 14);
            this.btnDen.Name = "btnDen";
            this.btnDen.Size = new System.Drawing.Size(98, 23);
            this.btnDen.TabIndex = 0;
            this.btnDen.Text = "Bật/Tắt đèn";
            this.btnDen.UseVisualStyleBackColor = true;
            this.btnDen.Click += new System.EventHandler(this.btnDen_Click);
            // 
            // btnDieuHoa
            // 
            this.btnDieuHoa.Location = new System.Drawing.Point(15, 43);
            this.btnDieuHoa.Name = "btnDieuHoa";
            this.btnDieuHoa.Size = new System.Drawing.Size(98, 23);
            this.btnDieuHoa.TabIndex = 0;
            this.btnDieuHoa.Text = "Bật/Tắt ĐH";
            this.btnDieuHoa.UseVisualStyleBackColor = true;
            this.btnDieuHoa.Click += new System.EventHandler(this.btnDieuHoa_Click);
            // 
            // trangThaiDen
            // 
            this.trangThaiDen.AutoSize = true;
            this.trangThaiDen.Location = new System.Drawing.Point(126, 18);
            this.trangThaiDen.Name = "trangThaiDen";
            this.trangThaiDen.Size = new System.Drawing.Size(15, 14);
            this.trangThaiDen.TabIndex = 1;
            this.trangThaiDen.UseVisualStyleBackColor = true;
            // 
            // trangThaiDieuHoa
            // 
            this.trangThaiDieuHoa.AutoSize = true;
            this.trangThaiDieuHoa.Location = new System.Drawing.Point(126, 48);
            this.trangThaiDieuHoa.Name = "trangThaiDieuHoa";
            this.trangThaiDieuHoa.Size = new System.Drawing.Size(15, 14);
            this.trangThaiDieuHoa.TabIndex = 1;
            this.trangThaiDieuHoa.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 2;
            // 
            // Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trangThaiDieuHoa);
            this.Controls.Add(this.trangThaiDen);
            this.Controls.Add(this.btnDieuHoa);
            this.Controls.Add(this.btnDen);
            this.Name = "Phong";
            this.Size = new System.Drawing.Size(155, 110);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Button btnDen;
        public Button btnDieuHoa;
        private CheckBox trangThaiDen;
        private CheckBox trangThaiDieuHoa;
        private Label label1;
    }
}
