
namespace PhoneNumberTester
{
    partial class MainForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numberInput = new System.Windows.Forms.TextBox();
            this.detailedInfo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.formattedNumberBoxE164 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.formattedNumberBoxInternational = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.formattedNumberBoxNational = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.formattedNumberBoxRFC3966 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 347);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 366);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Default region";
            // 
            // numberInput
            // 
            this.numberInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberInput.Location = new System.Drawing.Point(18, 396);
            this.numberInput.Name = "numberInput";
            this.numberInput.Size = new System.Drawing.Size(632, 44);
            this.numberInput.TabIndex = 2;
            this.numberInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // detailedInfo
            // 
            this.detailedInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailedInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailedInfo.Location = new System.Drawing.Point(3, 16);
            this.detailedInfo.Multiline = true;
            this.detailedInfo.Name = "detailedInfo";
            this.detailedInfo.ReadOnly = true;
            this.detailedInfo.Size = new System.Drawing.Size(467, 347);
            this.detailedInfo.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.detailedInfo);
            this.groupBox2.Location = new System.Drawing.Point(177, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(473, 366);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detailed info";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.formattedNumberBoxE164);
            this.groupBox3.Location = new System.Drawing.Point(18, 446);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(632, 70);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "E164";
            // 
            // formattedNumberBoxE164
            // 
            this.formattedNumberBoxE164.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formattedNumberBoxE164.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formattedNumberBoxE164.Location = new System.Drawing.Point(3, 16);
            this.formattedNumberBoxE164.Name = "formattedNumberBoxE164";
            this.formattedNumberBoxE164.ReadOnly = true;
            this.formattedNumberBoxE164.Size = new System.Drawing.Size(626, 44);
            this.formattedNumberBoxE164.TabIndex = 8;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.formattedNumberBoxInternational);
            this.groupBox4.Location = new System.Drawing.Point(18, 522);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(632, 70);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "International";
            // 
            // formattedNumberBoxInternational
            // 
            this.formattedNumberBoxInternational.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formattedNumberBoxInternational.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formattedNumberBoxInternational.Location = new System.Drawing.Point(3, 16);
            this.formattedNumberBoxInternational.Name = "formattedNumberBoxInternational";
            this.formattedNumberBoxInternational.ReadOnly = true;
            this.formattedNumberBoxInternational.Size = new System.Drawing.Size(626, 44);
            this.formattedNumberBoxInternational.TabIndex = 8;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.formattedNumberBoxNational);
            this.groupBox5.Location = new System.Drawing.Point(18, 598);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(632, 70);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "National";
            // 
            // formattedNumberBoxNational
            // 
            this.formattedNumberBoxNational.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formattedNumberBoxNational.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formattedNumberBoxNational.Location = new System.Drawing.Point(3, 16);
            this.formattedNumberBoxNational.Name = "formattedNumberBoxNational";
            this.formattedNumberBoxNational.ReadOnly = true;
            this.formattedNumberBoxNational.Size = new System.Drawing.Size(626, 44);
            this.formattedNumberBoxNational.TabIndex = 8;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.formattedNumberBoxRFC3966);
            this.groupBox6.Location = new System.Drawing.Point(18, 674);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(632, 70);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "RFC3966";
            // 
            // formattedNumberBoxRFC3966
            // 
            this.formattedNumberBoxRFC3966.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formattedNumberBoxRFC3966.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formattedNumberBoxRFC3966.Location = new System.Drawing.Point(3, 16);
            this.formattedNumberBoxRFC3966.Name = "formattedNumberBoxRFC3966";
            this.formattedNumberBoxRFC3966.ReadOnly = true;
            this.formattedNumberBoxRFC3966.Size = new System.Drawing.Size(626, 44);
            this.formattedNumberBoxRFC3966.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 765);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.numberInput);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Phone Number Tester";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox numberInput;
        private System.Windows.Forms.TextBox detailedInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox formattedNumberBoxE164;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox formattedNumberBoxInternational;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox formattedNumberBoxNational;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox formattedNumberBoxRFC3966;
    }
}

