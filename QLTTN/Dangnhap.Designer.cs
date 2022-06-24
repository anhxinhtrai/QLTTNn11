
namespace QLTTN
{
    partial class Dangnhap
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtB1 = new System.Windows.Forms.TextBox();
            this.txtB2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.rdB = new System.Windows.Forms.RadioButton();
            this.rdB2 = new System.Windows.Forms.RadioButton();
            this.chkShow = new System.Windows.Forms.CheckBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(162, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Đăng nhập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtB1
            // 
            this.txtB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB1.Location = new System.Drawing.Point(107, 138);
            this.txtB1.Multiline = true;
            this.txtB1.Name = "txtB1";
            this.txtB1.Size = new System.Drawing.Size(217, 26);
            this.txtB1.TabIndex = 1;
            // 
            // txtB2
            // 
            this.txtB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB2.Location = new System.Drawing.Point(107, 170);
            this.txtB2.Multiline = true;
            this.txtB2.Name = "txtB2";
            this.txtB2.PasswordChar = '*';
            this.txtB2.Size = new System.Drawing.Size(217, 26);
            this.txtB2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(325, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rdB
            // 
            this.rdB.AutoSize = true;
            this.rdB.BackColor = System.Drawing.Color.Transparent;
            this.rdB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdB.Location = new System.Drawing.Point(107, 244);
            this.rdB.Name = "rdB";
            this.rdB.Size = new System.Drawing.Size(75, 21);
            this.rdB.TabIndex = 6;
            this.rdB.TabStop = true;
            this.rdB.Text = "Quản lý";
            this.rdB.UseVisualStyleBackColor = false;
            // 
            // rdB2
            // 
            this.rdB2.AutoSize = true;
            this.rdB2.BackColor = System.Drawing.Color.Transparent;
            this.rdB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdB2.Location = new System.Drawing.Point(216, 244);
            this.rdB2.Name = "rdB2";
            this.rdB2.Size = new System.Drawing.Size(108, 21);
            this.rdB2.TabIndex = 7;
            this.rdB2.TabStop = true;
            this.rdB2.Text = "Thực hiện thi";
            this.rdB2.UseVisualStyleBackColor = false;
            // 
            // chkShow
            // 
            this.chkShow.AutoSize = true;
            this.chkShow.BackColor = System.Drawing.Color.Transparent;
            this.chkShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShow.Location = new System.Drawing.Point(107, 217);
            this.chkShow.Name = "chkShow";
            this.chkShow.Size = new System.Drawing.Size(137, 21);
            this.chkShow.TabIndex = 8;
            this.chkShow.Text = "Hiển thị mật khẩu";
            this.chkShow.UseVisualStyleBackColor = false;
            this.chkShow.CheckedChanged += new System.EventHandler(this.chkshow_CheckedChanged);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.Transparent;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.Red;
            this.lbl3.Location = new System.Drawing.Point(104, 199);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(0, 15);
            this.lbl3.TabIndex = 9;
            // 
            // Dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLTTN.Properties.Resources._287074106_5503411903027258_3846120751481595409_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(411, 395);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.chkShow);
            this.Controls.Add(this.rdB2);
            this.Controls.Add(this.rdB);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtB2);
            this.Controls.Add(this.txtB1);
            this.Controls.Add(this.button1);
            this.Name = "Dangnhap";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtB1;
        private System.Windows.Forms.TextBox txtB2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rdB;
        private System.Windows.Forms.RadioButton rdB2;
        private System.Windows.Forms.CheckBox chkShow;
        private System.Windows.Forms.Label lbl3;
    }
}

