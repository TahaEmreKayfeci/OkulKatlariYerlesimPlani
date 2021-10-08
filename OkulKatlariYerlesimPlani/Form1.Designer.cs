
namespace OkulKatlariYerlesimPlani
{
    partial class Form1
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
            this.btn_goster = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_kat = new System.Windows.Forms.TextBox();
            this.lbx_kat = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_goster
            // 
            this.btn_goster.Location = new System.Drawing.Point(183, 54);
            this.btn_goster.Name = "btn_goster";
            this.btn_goster.Size = new System.Drawing.Size(75, 23);
            this.btn_goster.TabIndex = 0;
            this.btn_goster.Text = "Göster";
            this.btn_goster.UseVisualStyleBackColor = true;
            this.btn_goster.Click += new System.EventHandler(this.btn_goster_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Okul Kat Yerleşim Planı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kat Sayısı :";
            // 
            // txt_kat
            // 
            this.txt_kat.Location = new System.Drawing.Point(77, 56);
            this.txt_kat.Name = "txt_kat";
            this.txt_kat.Size = new System.Drawing.Size(100, 20);
            this.txt_kat.TabIndex = 3;
            // 
            // lbx_kat
            // 
            this.lbx_kat.FormattingEnabled = true;
            this.lbx_kat.Location = new System.Drawing.Point(64, 103);
            this.lbx_kat.Name = "lbx_kat";
            this.lbx_kat.Size = new System.Drawing.Size(113, 160);
            this.lbx_kat.TabIndex = 4;
            this.lbx_kat.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 305);
            this.Controls.Add(this.lbx_kat);
            this.Controls.Add(this.txt_kat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_goster);
            this.Name = "Form1";
            this.Text = "Okul Yerlesim Kat Plani Programi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_goster;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_kat;
        private System.Windows.Forms.ListBox lbx_kat;
    }
}

