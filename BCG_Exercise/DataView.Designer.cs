
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
            this.Datagridview1 = new System.Windows.Forms.DataGridView();
            this.State_list = new System.Windows.Forms.ComboBox();
            this.States = new System.Windows.Forms.Label();
            this.Average = new System.Windows.Forms.TextBox();
            this.Sum = new System.Windows.Forms.TextBox();
            this.Median = new System.Windows.Forms.TextBox();
            this.MedianSaleLable = new System.Windows.Forms.Label();
            this.AveragesaleLable = new System.Windows.Forms.Label();
            this.SumSaleLable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Datagridview1)).BeginInit();
            this.SuspendLayout();
            // 
            // Datagridview1
            // 
            this.Datagridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datagridview1.Location = new System.Drawing.Point(158, 106);
            this.Datagridview1.Name = "Datagridview1";
            this.Datagridview1.Size = new System.Drawing.Size(361, 163);
            this.Datagridview1.TabIndex = 0;
            // 
            // State_list
            // 
            this.State_list.FormattingEnabled = true;
            this.State_list.Location = new System.Drawing.Point(294, 63);
            this.State_list.Name = "State_list";
            this.State_list.Size = new System.Drawing.Size(121, 21);
            this.State_list.TabIndex = 3;
            this.State_list.SelectedIndexChanged += new System.EventHandler(this.StateSelectedChange);
            // 
            // States
            // 
            this.States.AllowDrop = true;
            this.States.AutoSize = true;
            this.States.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.States.Location = new System.Drawing.Point(232, 64);
            this.States.Name = "States";
            this.States.Size = new System.Drawing.Size(47, 20);
            this.States.TabIndex = 5;
            this.States.Text = "States";
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
            // MedianSaleLable
            // 
            this.MedianSaleLable.AutoSize = true;
            this.MedianSaleLable.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.MedianSaleLable.Location = new System.Drawing.Point(584, 198);
            this.MedianSaleLable.Name = "MedianSaleLable";
            this.MedianSaleLable.Size = new System.Drawing.Size(86, 20);
            this.MedianSaleLable.TabIndex = 12;
            this.MedianSaleLable.Text = "Median_sale";
            // 
            // AveragesaleLable
            // 
            this.AveragesaleLable.AutoSize = true;
            this.AveragesaleLable.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AveragesaleLable.Location = new System.Drawing.Point(584, 106);
            this.AveragesaleLable.Name = "AveragesaleLable";
            this.AveragesaleLable.Size = new System.Drawing.Size(91, 20);
            this.AveragesaleLable.TabIndex = 13;
            this.AveragesaleLable.Text = "Average_sale";
            // 
            // SumSaleLable
            // 
            this.SumSaleLable.AutoSize = true;
            this.SumSaleLable.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.SumSaleLable.Location = new System.Drawing.Point(584, 148);
            this.SumSaleLable.Name = "SumSaleLable";
            this.SumSaleLable.Size = new System.Drawing.Size(70, 20);
            this.SumSaleLable.TabIndex = 14;
            this.SumSaleLable.Text = "Sum_sale";
            // 
            // DataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SumSaleLable);
            this.Controls.Add(this.AveragesaleLable);
            this.Controls.Add(this.MedianSaleLable);
            this.Controls.Add(this.Median);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.Average);
            this.Controls.Add(this.States);
            this.Controls.Add(this.State_list);
            this.Controls.Add(this.Datagridview1);
            this.Name = "DataView";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Datagridview1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView Datagridview1;
        private System.Windows.Forms.ComboBox State_list;
        private System.Windows.Forms.Label States;
        public System.Windows.Forms.TextBox Average;
        public System.Windows.Forms.TextBox Sum;
        public System.Windows.Forms.TextBox Median;
        private System.Windows.Forms.Label MedianSaleLable;
        private System.Windows.Forms.Label AveragesaleLable;
        private System.Windows.Forms.Label SumSaleLable;
    }
}

