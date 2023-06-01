
namespace QLPhongTro.View
{
    partial class backupData
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(backupData));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.txtTep = new DevExpress.XtraEditors.TextEdit();
            this.btnTep = new DevExpress.XtraEditors.SimpleButton();
            this.btnBackup = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTep.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(38, 47);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(78, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Đường dẫn:";
            // 
            // txtTep
            // 
            this.txtTep.Enabled = false;
            this.txtTep.Location = new System.Drawing.Point(122, 45);
            this.txtTep.Name = "txtTep";
            this.txtTep.Size = new System.Drawing.Size(335, 22);
            this.txtTep.TabIndex = 1;
            // 
            // btnTep
            // 
            this.btnTep.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTep.Appearance.Options.UseFont = true;
            this.btnTep.Location = new System.Drawing.Point(130, 98);
            this.btnTep.Name = "btnTep";
            this.btnTep.Size = new System.Drawing.Size(71, 29);
            this.btnTep.TabIndex = 2;
            this.btnTep.Text = "Browse";
            this.btnTep.Click += new System.EventHandler(this.btnTep_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.Appearance.Options.UseFont = true;
            this.btnBackup.Location = new System.Drawing.Point(302, 98);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(71, 29);
            this.btnBackup.TabIndex = 3;
            this.btnBackup.Text = "BackUp";
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // backupData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 149);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.btnTep);
            this.Controls.Add(this.txtTep);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("backupData.IconOptions.Image")));
            this.Name = "backupData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup Data";
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTep.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.TextEdit txtTep;
        private DevExpress.XtraEditors.SimpleButton btnTep;
        private DevExpress.XtraEditors.SimpleButton btnBackup;
    }
}