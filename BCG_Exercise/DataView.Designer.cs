
namespace BCG_Exercise
{
    partial class DataView
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
            this.Dgv1 = new System.Windows.Forms.DataGridView();
            this.Countries_list = new System.Windows.Forms.ComboBox();
            this.Countries = new System.Windows.Forms.Label();
            this.Average = new System.Windows.Forms.TextBox();
            this.Sum = new System.Windows.Forms.TextBox();
            this.Median = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv1
            // 
            this.Dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv1.Location = new System.Drawing.Point(158, 106);
            this.Dgv1.Name = "Dgv1";
            this.Dgv1.Size = new System.Drawing.Size(361, 163);
            this.Dgv1.TabIndex = 0;
            // 
            // Countries_list
            // 
            this.Countries_list.FormattingEnabled = true;
            this.Countries_list.Location = new System.Drawing.Point(338, 61);
            this.Countries_list.Name = "Countries_list";
            this.Countries_list.Size = new System.Drawing.Size(121, 21);
            this.Countries_list.TabIndex = 3;
            this.Countries_list.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // Countries
            // 
            this.Countries.AllowDrop = true;
            this.Countries.AutoSize = true;
            this.Countries.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.Countries.Location = new System.Drawing.Point(250, 62);
            this.Countries.Name = "Countries";
            this.Countries.Size = new System.Drawing.Size(69, 20);
            this.Countries.TabIndex = 5;
            this.Countries.Text = "Countries";
            // 
            // Average
            // 
            this.Average.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.Average.Location = new System.Drawing.Point(688, 106);
            this.Average.Name = "Average";
            this.Average.Size = new System.Drawing.Size(100, 26);
            this.Average.TabIndex = 7;
            // 
            // Sum
            // 
            this.Sum.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.Sum.Location = new System.Drawing.Point(688, 150);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(100, 26);
            this.Sum.TabIndex = 8;
            // 
            // Median
            // 
            this.Median.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.Median.Location = new System.Drawing.Point(688, 192);
            this.Median.Name = "Median";
            this.Median.Size = new System.Drawing.Size(100, 26);
            this.Median.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(584, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Median_sale";
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A.Location = new System.Drawing.Point(584, 106);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(91, 20);
            this.A.TabIndex = 13;
            this.A.Text = "Average_sale";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(584, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Sum_sale";
            // 
            // DataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.A);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Median);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.Average);
            this.Controls.Add(this.Countries);
            this.Controls.Add(this.Countries_list);
            this.Controls.Add(this.Dgv1);
            this.Name = "DataView";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView Dgv1;
        //private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Countries_list;
        private System.Windows.Forms.Label Countries;
        public System.Windows.Forms.TextBox Average;
        public System.Windows.Forms.TextBox Sum;
        public System.Windows.Forms.TextBox Median;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label A;
        private System.Windows.Forms.Label label2;
    }
}

