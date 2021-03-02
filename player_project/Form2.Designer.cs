
namespace player_project
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.dtp_Birthdate = new System.Windows.Forms.DateTimePicker();
            this.rdb_Injured = new System.Windows.Forms.RadioButton();
            this.rdb_safe = new System.Windows.Forms.RadioButton();
            this.bt_Remove = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "List Of Players";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(62, 269);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(453, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_Remove);
            this.groupBox1.Controls.Add(this.rdb_safe);
            this.groupBox1.Controls.Add(this.rdb_Injured);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.dtp_Birthdate);
            this.groupBox1.Controls.Add(this.txt_Id);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Tomato;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 188);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payer\'s Informations";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(310, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "State";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(19, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Player Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(19, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Player Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(19, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "BirthDate";
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_Name.ForeColor = System.Drawing.Color.Black;
            this.txt_Name.Location = new System.Drawing.Point(125, 75);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(151, 20);
            this.txt_Name.TabIndex = 5;
            // 
            // txt_Id
            // 
            this.txt_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_Id.ForeColor = System.Drawing.Color.Black;
            this.txt_Id.Location = new System.Drawing.Point(125, 33);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(151, 20);
            this.txt_Id.TabIndex = 6;
            // 
            // dtp_Birthdate
            // 
            this.dtp_Birthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dtp_Birthdate.Location = new System.Drawing.Point(125, 110);
            this.dtp_Birthdate.MaxDate = new System.DateTime(8739, 11, 30, 0, 0, 0, 0);
            this.dtp_Birthdate.MinDate = new System.DateTime(1971, 6, 17, 0, 0, 0, 0);
            this.dtp_Birthdate.Name = "dtp_Birthdate";
            this.dtp_Birthdate.Size = new System.Drawing.Size(151, 20);
            this.dtp_Birthdate.TabIndex = 7;
            this.dtp_Birthdate.Value = new System.DateTime(2023, 6, 15, 0, 0, 0, 0);
            // 
            // rdb_Injured
            // 
            this.rdb_Injured.AutoSize = true;
            this.rdb_Injured.Checked = true;
            this.rdb_Injured.ForeColor = System.Drawing.Color.Black;
            this.rdb_Injured.Location = new System.Drawing.Point(368, 75);
            this.rdb_Injured.Name = "rdb_Injured";
            this.rdb_Injured.Size = new System.Drawing.Size(73, 20);
            this.rdb_Injured.TabIndex = 9;
            this.rdb_Injured.TabStop = true;
            this.rdb_Injured.Text = "Injured";
            this.rdb_Injured.UseVisualStyleBackColor = true;
            // 
            // rdb_safe
            // 
            this.rdb_safe.AutoSize = true;
            this.rdb_safe.ForeColor = System.Drawing.Color.Black;
            this.rdb_safe.Location = new System.Drawing.Point(473, 77);
            this.rdb_safe.Name = "rdb_safe";
            this.rdb_safe.Size = new System.Drawing.Size(58, 20);
            this.rdb_safe.TabIndex = 10;
            this.rdb_safe.Text = "Safe";
            this.rdb_safe.UseVisualStyleBackColor = true;
            // 
            // bt_Remove
            // 
            this.bt_Remove.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bt_Remove.Location = new System.Drawing.Point(388, 111);
            this.bt_Remove.Name = "bt_Remove";
            this.bt_Remove.Size = new System.Drawing.Size(127, 33);
            this.bt_Remove.TabIndex = 11;
            this.bt_Remove.Text = "Remove Player";
            this.bt_Remove.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(298, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Position";
            // 
            // comboBox1
            // 
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(368, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 24);
            this.comboBox1.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 431);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "List Of Players";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_Remove;
        private System.Windows.Forms.RadioButton rdb_safe;
        private System.Windows.Forms.RadioButton rdb_Injured;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dtp_Birthdate;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
    }
}