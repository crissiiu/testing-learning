namespace Calculator
{
    partial class frm_calculator
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_title = new System.Windows.Forms.Label();
            this.lb_sothunhat = new System.Windows.Forms.Label();
            this.lb_sothuhai = new System.Windows.Forms.Label();
            this.lb_ketqua = new System.Windows.Forms.Label();
            this.txt_sothunhat = new System.Windows.Forms.TextBox();
            this.txt_sothuhai = new System.Windows.Forms.TextBox();
            this.txt_ketqua = new System.Windows.Forms.TextBox();
            this.btn_cong = new System.Windows.Forms.Button();
            this.btn_tru = new System.Windows.Forms.Button();
            this.btn_nhan = new System.Windows.Forms.Button();
            this.btn_chia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.ForeColor = System.Drawing.Color.Crimson;
            this.lb_title.Location = new System.Drawing.Point(123, 47);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(542, 32);
            this.lb_title.TabIndex = 0;
            this.lb_title.Text = "CHƯƠNG TRÌNH MÁY TÍNH ĐƠN GIẢN";
            // 
            // lb_sothunhat
            // 
            this.lb_sothunhat.AutoSize = true;
            this.lb_sothunhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sothunhat.ForeColor = System.Drawing.Color.Crimson;
            this.lb_sothunhat.Location = new System.Drawing.Point(63, 142);
            this.lb_sothunhat.Name = "lb_sothunhat";
            this.lb_sothunhat.Size = new System.Drawing.Size(130, 25);
            this.lb_sothunhat.TabIndex = 1;
            this.lb_sothunhat.Text = "Số thứ nhất:";
            // 
            // lb_sothuhai
            // 
            this.lb_sothuhai.AutoSize = true;
            this.lb_sothuhai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sothuhai.ForeColor = System.Drawing.Color.Crimson;
            this.lb_sothuhai.Location = new System.Drawing.Point(76, 231);
            this.lb_sothuhai.Name = "lb_sothuhai";
            this.lb_sothuhai.Size = new System.Drawing.Size(117, 25);
            this.lb_sothuhai.TabIndex = 2;
            this.lb_sothuhai.Text = "Số thứ hai:";
            // 
            // lb_ketqua
            // 
            this.lb_ketqua.AutoSize = true;
            this.lb_ketqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ketqua.ForeColor = System.Drawing.Color.Crimson;
            this.lb_ketqua.Location = new System.Drawing.Point(99, 324);
            this.lb_ketqua.Name = "lb_ketqua";
            this.lb_ketqua.Size = new System.Drawing.Size(94, 25);
            this.lb_ketqua.TabIndex = 3;
            this.lb_ketqua.Text = "Kết quả:";
            // 
            // txt_sothunhat
            // 
            this.txt_sothunhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sothunhat.Location = new System.Drawing.Point(221, 133);
            this.txt_sothunhat.Name = "txt_sothunhat";
            this.txt_sothunhat.Size = new System.Drawing.Size(444, 34);
            this.txt_sothunhat.TabIndex = 4;
            // 
            // txt_sothuhai
            // 
            this.txt_sothuhai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sothuhai.Location = new System.Drawing.Point(221, 222);
            this.txt_sothuhai.Name = "txt_sothuhai";
            this.txt_sothuhai.Size = new System.Drawing.Size(444, 34);
            this.txt_sothuhai.TabIndex = 5;
            // 
            // txt_ketqua
            // 
            this.txt_ketqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ketqua.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txt_ketqua.Location = new System.Drawing.Point(221, 315);
            this.txt_ketqua.Name = "txt_ketqua";
            this.txt_ketqua.ReadOnly = true;
            this.txt_ketqua.Size = new System.Drawing.Size(444, 34);
            this.txt_ketqua.TabIndex = 6;
            // 
            // btn_cong
            // 
            this.btn_cong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cong.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_cong.Location = new System.Drawing.Point(221, 378);
            this.btn_cong.Name = "btn_cong";
            this.btn_cong.Size = new System.Drawing.Size(75, 48);
            this.btn_cong.TabIndex = 7;
            this.btn_cong.Text = "+";
            this.btn_cong.UseVisualStyleBackColor = true;
            this.btn_cong.Click += new System.EventHandler(this.btn_cong_Click);
            // 
            // btn_tru
            // 
            this.btn_tru.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tru.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_tru.Location = new System.Drawing.Point(344, 378);
            this.btn_tru.Name = "btn_tru";
            this.btn_tru.Size = new System.Drawing.Size(75, 48);
            this.btn_tru.TabIndex = 8;
            this.btn_tru.Text = "-";
            this.btn_tru.UseVisualStyleBackColor = true;
            this.btn_tru.Click += new System.EventHandler(this.btn_tru_Click);
            // 
            // btn_nhan
            // 
            this.btn_nhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhan.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_nhan.Location = new System.Drawing.Point(472, 378);
            this.btn_nhan.Name = "btn_nhan";
            this.btn_nhan.Size = new System.Drawing.Size(75, 48);
            this.btn_nhan.TabIndex = 9;
            this.btn_nhan.Text = "*";
            this.btn_nhan.UseVisualStyleBackColor = true;
            this.btn_nhan.Click += new System.EventHandler(this.btn_nhan_Click);
            // 
            // btn_chia
            // 
            this.btn_chia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chia.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_chia.Location = new System.Drawing.Point(590, 378);
            this.btn_chia.Name = "btn_chia";
            this.btn_chia.Size = new System.Drawing.Size(75, 48);
            this.btn_chia.TabIndex = 10;
            this.btn_chia.Text = "/";
            this.btn_chia.UseVisualStyleBackColor = true;
            this.btn_chia.Click += new System.EventHandler(this.btn_chia_Click);
            // 
            // frm_calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_chia);
            this.Controls.Add(this.btn_nhan);
            this.Controls.Add(this.btn_tru);
            this.Controls.Add(this.btn_cong);
            this.Controls.Add(this.txt_ketqua);
            this.Controls.Add(this.txt_sothuhai);
            this.Controls.Add(this.txt_sothunhat);
            this.Controls.Add(this.lb_ketqua);
            this.Controls.Add(this.lb_sothuhai);
            this.Controls.Add(this.lb_sothunhat);
            this.Controls.Add(this.lb_title);
            this.Name = "frm_calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label lb_sothunhat;
        private System.Windows.Forms.Label lb_sothuhai;
        private System.Windows.Forms.Label lb_ketqua;
        private System.Windows.Forms.TextBox txt_sothunhat;
        private System.Windows.Forms.TextBox txt_sothuhai;
        private System.Windows.Forms.TextBox txt_ketqua;
        private System.Windows.Forms.Button btn_cong;
        private System.Windows.Forms.Button btn_tru;
        private System.Windows.Forms.Button btn_nhan;
        private System.Windows.Forms.Button btn_chia;
    }
}

