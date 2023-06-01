
namespace QLPhongTro.View
{
    partial class fThemKhu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fThemKhu));
            this.txtThemKho = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnThemKho = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtThemKho.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtThemKho
            // 
            this.txtThemKho.Location = new System.Drawing.Point(98, 27);
            this.txtThemKho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtThemKho.Name = "txtThemKho";
            this.txtThemKho.Size = new System.Drawing.Size(129, 22);
            this.txtThemKho.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(35, 28);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 27);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Khu:";
            // 
            // btnThemKho
            // 
            this.btnThemKho.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKho.Appearance.Options.UseFont = true;
            this.btnThemKho.ImageOptions.Image = global::QLPhongTro.Properties.Resources.add_32x32;
            this.btnThemKho.Location = new System.Drawing.Point(234, 17);
            this.btnThemKho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThemKho.Name = "btnThemKho";
            this.btnThemKho.Size = new System.Drawing.Size(101, 43);
            this.btnThemKho.TabIndex = 2;
            this.btnThemKho.Text = "Thêm";
            this.btnThemKho.Click += new System.EventHandler(this.btnThemKho_Click);
            // 
            // fThemKhu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 96);
            this.Controls.Add(this.btnThemKho);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtThemKho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("fThemKhu.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fThemKhu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fThemKhu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fThemKhu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.txtThemKho.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtThemKho;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnThemKho;
    }
}