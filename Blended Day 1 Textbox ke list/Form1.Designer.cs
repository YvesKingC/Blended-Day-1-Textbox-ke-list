namespace Blended_Day_1_Textbox_ke_list
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxInput = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkAktif = new System.Windows.Forms.CheckBox();
            this.radioMerah = new System.Windows.Forms.RadioButton();
            this.radioBiru = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxKoleksi = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblOutList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data: ";
            // 
            // txtBoxInput
            // 
            this.txtBoxInput.Location = new System.Drawing.Point(106, 45);
            this.txtBoxInput.Name = "txtBoxInput";
            this.txtBoxInput.Size = new System.Drawing.Size(301, 23);
            this.txtBoxInput.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(426, 45);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Koleksi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Setting: ";
            // 
            // checkAktif
            // 
            this.checkAktif.AutoSize = true;
            this.checkAktif.Location = new System.Drawing.Point(441, 98);
            this.checkAktif.Name = "checkAktif";
            this.checkAktif.Size = new System.Drawing.Size(51, 19);
            this.checkAktif.TabIndex = 5;
            this.checkAktif.Text = "Aktif";
            this.checkAktif.UseVisualStyleBackColor = true;
            // 
            // radioMerah
            // 
            this.radioMerah.AutoSize = true;
            this.radioMerah.Location = new System.Drawing.Point(441, 123);
            this.radioMerah.Name = "radioMerah";
            this.radioMerah.Size = new System.Drawing.Size(96, 19);
            this.radioMerah.TabIndex = 6;
            this.radioMerah.TabStop = true;
            this.radioMerah.Text = "Warna Merah";
            this.radioMerah.UseVisualStyleBackColor = true;
            this.radioMerah.CheckedChanged += new System.EventHandler(this.radioMerah_CheckedChanged);
            // 
            // radioBiru
            // 
            this.radioBiru.AutoSize = true;
            this.radioBiru.Location = new System.Drawing.Point(441, 148);
            this.radioBiru.Name = "radioBiru";
            this.radioBiru.Size = new System.Drawing.Size(83, 19);
            this.radioBiru.TabIndex = 7;
            this.radioBiru.TabStop = true;
            this.radioBiru.Text = "Warna Biru";
            this.radioBiru.UseVisualStyleBackColor = true;
            this.radioBiru.CheckedChanged += new System.EventHandler(this.radioBiru_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Output:";
            // 
            // listBoxKoleksi
            // 
            this.listBoxKoleksi.FormattingEnabled = true;
            this.listBoxKoleksi.ItemHeight = 15;
            this.listBoxKoleksi.Items.AddRange(new object[] {
            "Halo"});
            this.listBoxKoleksi.Location = new System.Drawing.Point(45, 123);
            this.listBoxKoleksi.Name = "listBoxKoleksi";
            this.listBoxKoleksi.Size = new System.Drawing.Size(284, 274);
            this.listBoxKoleksi.TabIndex = 9;
            this.listBoxKoleksi.SelectedIndexChanged += new System.EventHandler(this.listBoxKoleksi_SelectedIndexChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(541, 387);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblOutList
            // 
            this.lblOutList.AutoSize = true;
            this.lblOutList.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOutList.Location = new System.Drawing.Point(499, 279);
            this.lblOutList.Name = "lblOutList";
            this.lblOutList.Size = new System.Drawing.Size(0, 45);
            this.lblOutList.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOutList);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.listBoxKoleksi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioBiru);
            this.Controls.Add(this.radioMerah);
            this.Controls.Add(this.checkAktif);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBoxInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtBoxInput;
        private Button btnAdd;
        private Label label2;
        private Label label3;
        private CheckBox checkAktif;
        private RadioButton radioMerah;
        private RadioButton radioBiru;
        private Label label4;
        private ListBox listBoxKoleksi;
        private Button btnClear;
        private Label lblOutList;
    }
}