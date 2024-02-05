namespace CoreyCollins_CPT_236_Lab_1
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
            this.dataBaseListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch2 = new System.Windows.Forms.Button();
            this.problem42TextBox = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.problem4TextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sortUnitsASC = new System.Windows.Forms.Button();
            this.btnLessThan = new System.Windows.Forms.Button();
            this.btnGTRThan = new System.Windows.Forms.Button();
            this.problem5TextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.sortPriceByASC = new System.Windows.Forms.Button();
            this.btnMinPrice = new System.Windows.Forms.Button();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataBaseListBox
            // 
            this.dataBaseListBox.FormattingEnabled = true;
            this.dataBaseListBox.ItemHeight = 20;
            this.dataBaseListBox.Location = new System.Drawing.Point(52, 45);
            this.dataBaseListBox.Name = "dataBaseListBox";
            this.dataBaseListBox.Size = new System.Drawing.Size(231, 244);
            this.dataBaseListBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSearch2);
            this.groupBox1.Controls.Add(this.problem42TextBox);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.problem4TextBox);
            this.groupBox1.Location = new System.Drawing.Point(448, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 183);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Programming Problem 4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MingLiU-ExtB", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search by description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU-ExtB", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search by product number:";
            // 
            // btnSearch2
            // 
            this.btnSearch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch2.Location = new System.Drawing.Point(251, 121);
            this.btnSearch2.Name = "btnSearch2";
            this.btnSearch2.Size = new System.Drawing.Size(52, 27);
            this.btnSearch2.TabIndex = 3;
            this.btnSearch2.Text = "&Go";
            this.btnSearch2.UseVisualStyleBackColor = true;
            this.btnSearch2.Click += new System.EventHandler(this.btnSearch2_Click);
            // 
            // problem42TextBox
            // 
            this.problem42TextBox.Location = new System.Drawing.Point(6, 122);
            this.problem42TextBox.Name = "problem42TextBox";
            this.problem42TextBox.Size = new System.Drawing.Size(239, 26);
            this.problem42TextBox.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(247, 73);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(52, 27);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "&Go";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // problem4TextBox
            // 
            this.problem4TextBox.Location = new System.Drawing.Point(6, 74);
            this.problem4TextBox.Name = "problem4TextBox";
            this.problem4TextBox.Size = new System.Drawing.Size(239, 26);
            this.problem4TextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sortUnitsASC);
            this.groupBox2.Controls.Add(this.btnLessThan);
            this.groupBox2.Controls.Add(this.btnGTRThan);
            this.groupBox2.Controls.Add(this.problem5TextBox);
            this.groupBox2.Location = new System.Drawing.Point(448, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 210);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Programming Problem 5";
            // 
            // sortUnitsASC
            // 
            this.sortUnitsASC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortUnitsASC.Location = new System.Drawing.Point(30, 41);
            this.sortUnitsASC.Name = "sortUnitsASC";
            this.sortUnitsASC.Size = new System.Drawing.Size(239, 33);
            this.sortUnitsASC.TabIndex = 3;
            this.sortUnitsASC.Text = "Sort Units by ASC";
            this.sortUnitsASC.UseVisualStyleBackColor = true;
            this.sortUnitsASC.Click += new System.EventHandler(this.sortUnitsASC_Click);
            // 
            // btnLessThan
            // 
            this.btnLessThan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLessThan.Location = new System.Drawing.Point(158, 148);
            this.btnLessThan.Name = "btnLessThan";
            this.btnLessThan.Size = new System.Drawing.Size(104, 47);
            this.btnLessThan.TabIndex = 2;
            this.btnLessThan.Text = "qty < x";
            this.btnLessThan.UseVisualStyleBackColor = true;
            this.btnLessThan.Click += new System.EventHandler(this.btnLessThan_Click);
            // 
            // btnGTRThan
            // 
            this.btnGTRThan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGTRThan.Location = new System.Drawing.Point(30, 148);
            this.btnGTRThan.Name = "btnGTRThan";
            this.btnGTRThan.Size = new System.Drawing.Size(104, 47);
            this.btnGTRThan.TabIndex = 1;
            this.btnGTRThan.Text = "qty > x";
            this.btnGTRThan.UseVisualStyleBackColor = true;
            this.btnGTRThan.Click += new System.EventHandler(this.btnGTRThan_Click);
            // 
            // problem5TextBox
            // 
            this.problem5TextBox.Location = new System.Drawing.Point(30, 100);
            this.problem5TextBox.Name = "problem5TextBox";
            this.problem5TextBox.Size = new System.Drawing.Size(239, 26);
            this.problem5TextBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.maxTextBox);
            this.groupBox3.Controls.Add(this.sortPriceByASC);
            this.groupBox3.Controls.Add(this.btnMinPrice);
            this.groupBox3.Controls.Add(this.minTextBox);
            this.groupBox3.Location = new System.Drawing.Point(464, 450);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(305, 179);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Programming Problem 6";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MingLiU-ExtB", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(151, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Highest Cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MingLiU-ExtB", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lowest Cost";
            // 
            // maxTextBox
            // 
            this.maxTextBox.Location = new System.Drawing.Point(142, 92);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(104, 26);
            this.maxTextBox.TabIndex = 6;
            // 
            // sortPriceByASC
            // 
            this.sortPriceByASC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortPriceByASC.Location = new System.Drawing.Point(14, 25);
            this.sortPriceByASC.Name = "sortPriceByASC";
            this.sortPriceByASC.Size = new System.Drawing.Size(232, 33);
            this.sortPriceByASC.TabIndex = 4;
            this.sortPriceByASC.Text = "Sort Price by ASC";
            this.sortPriceByASC.UseVisualStyleBackColor = true;
            this.sortPriceByASC.Click += new System.EventHandler(this.sortPriceByASC_Click);
            // 
            // btnMinPrice
            // 
            this.btnMinPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinPrice.Location = new System.Drawing.Point(85, 136);
            this.btnMinPrice.Name = "btnMinPrice";
            this.btnMinPrice.Size = new System.Drawing.Size(118, 37);
            this.btnMinPrice.TabIndex = 1;
            this.btnMinPrice.Text = "&Min/Max";
            this.btnMinPrice.UseVisualStyleBackColor = true;
            this.btnMinPrice.Click += new System.EventHandler(this.btnMinPrice_Click);
            // 
            // minTextBox
            // 
            this.minTextBox.Location = new System.Drawing.Point(6, 92);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(112, 26);
            this.minTextBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(989, 656);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataBaseListBox);
            this.Name = "Form1";
            this.Text = "CoreyDeanCollinsJr-CPT-236-Lab-1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox dataBaseListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox problem4TextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLessThan;
        private System.Windows.Forms.Button btnGTRThan;
        private System.Windows.Forms.TextBox problem5TextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnMinPrice;
        private System.Windows.Forms.TextBox minTextBox;
        private System.Windows.Forms.Button btnSearch2;
        private System.Windows.Forms.TextBox problem42TextBox;
        private System.Windows.Forms.Button sortUnitsASC;
        private System.Windows.Forms.Button sortPriceByASC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

