namespace ClientA
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btSearch = new System.Windows.Forms.Button();
            this.btCreate = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btDatasemua = new System.Windows.Forms.Button();
            this.txtNIM = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtProdi = new System.Windows.Forms.TextBox();
            this.txtAngkatan = new System.Windows.Forms.TextBox();
            this.NIMSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prodi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Angkatan";
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(109, 304);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 23);
            this.btSearch.TabIndex = 4;
            this.btSearch.Text = "Search by NIM";
            this.btSearch.UseVisualStyleBackColor = true;
            // 
            // btCreate
            // 
            this.btCreate.Location = new System.Drawing.Point(523, 85);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(75, 23);
            this.btCreate.TabIndex = 5;
            this.btCreate.Text = "Create";
            this.btCreate.UseVisualStyleBackColor = true;
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(523, 162);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 6;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            // 
            // btDatasemua
            // 
            this.btDatasemua.Location = new System.Drawing.Point(523, 226);
            this.btDatasemua.Name = "btDatasemua";
            this.btDatasemua.Size = new System.Drawing.Size(75, 23);
            this.btDatasemua.TabIndex = 7;
            this.btDatasemua.Text = "Lihat Data";
            this.btDatasemua.UseVisualStyleBackColor = true;
            // 
            // txtNIM
            // 
            this.txtNIM.Location = new System.Drawing.Point(252, 85);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.Size = new System.Drawing.Size(213, 20);
            this.txtNIM.TabIndex = 8;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(252, 128);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(213, 20);
            this.txtNama.TabIndex = 9;
            // 
            // txtProdi
            // 
            this.txtProdi.Location = new System.Drawing.Point(252, 172);
            this.txtProdi.Name = "txtProdi";
            this.txtProdi.Size = new System.Drawing.Size(213, 20);
            this.txtProdi.TabIndex = 10;
            // 
            // txtAngkatan
            // 
            this.txtAngkatan.Location = new System.Drawing.Point(252, 226);
            this.txtAngkatan.Name = "txtAngkatan";
            this.txtAngkatan.Size = new System.Drawing.Size(213, 20);
            this.txtAngkatan.TabIndex = 11;
            // 
            // NIMSearch
            // 
            this.NIMSearch.Location = new System.Drawing.Point(252, 306);
            this.NIMSearch.Name = "NIMSearch";
            this.NIMSearch.Size = new System.Drawing.Size(322, 20);
            this.NIMSearch.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(109, 342);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(555, 150);
            this.dataGridView1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 494);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.NIMSearch);
            this.Controls.Add(this.txtAngkatan);
            this.Controls.Add(this.txtProdi);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtNIM);
            this.Controls.Add(this.btDatasemua);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btCreate);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btDatasemua;
        private System.Windows.Forms.TextBox txtNIM;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtProdi;
        private System.Windows.Forms.TextBox txtAngkatan;
        private System.Windows.Forms.TextBox NIMSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

