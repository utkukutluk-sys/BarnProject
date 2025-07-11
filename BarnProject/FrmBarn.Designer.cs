namespace BarnProject
{
    partial class FrmBarn
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAnimalSpecies = new System.Windows.Forms.ComboBox();
            this.txtAnimalAge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pbarBeef = new System.Windows.Forms.ProgressBar();
            this.pbarCow = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.pbarChicken = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMeatCount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMeatSellCount = new System.Windows.Forms.TextBox();
            this.btnMeatSell = new System.Windows.Forms.Button();
            this.btnEggSell = new System.Windows.Forms.Button();
            this.txtEggSellCount = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblEggCount = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnMilkSell = new System.Windows.Forms.Button();
            this.txtMilkSellCount = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblMilkCount = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridViewAnimals = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblCashAmount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timerProduction = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnimals)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Animal Species:";
            // 
            // cmbAnimalSpecies
            // 
            this.cmbAnimalSpecies.FormattingEnabled = true;
            this.cmbAnimalSpecies.Location = new System.Drawing.Point(138, 40);
            this.cmbAnimalSpecies.Name = "cmbAnimalSpecies";
            this.cmbAnimalSpecies.Size = new System.Drawing.Size(121, 24);
            this.cmbAnimalSpecies.TabIndex = 1;
            // 
            // txtAnimalAge
            // 
            this.txtAnimalAge.Location = new System.Drawing.Point(138, 79);
            this.txtAnimalAge.Name = "txtAnimalAge";
            this.txtAnimalAge.Size = new System.Drawing.Size(121, 22);
            this.txtAnimalAge.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Animal Age:";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(138, 115);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(121, 24);
            this.cmbGender.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gender:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(138, 172);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Beef:";
            // 
            // pbarBeef
            // 
            this.pbarBeef.Location = new System.Drawing.Point(101, 360);
            this.pbarBeef.Name = "pbarBeef";
            this.pbarBeef.Size = new System.Drawing.Size(129, 23);
            this.pbarBeef.TabIndex = 8;
            // 
            // pbarCow
            // 
            this.pbarCow.Location = new System.Drawing.Point(101, 422);
            this.pbarCow.Name = "pbarCow";
            this.pbarCow.Size = new System.Drawing.Size(129, 23);
            this.pbarCow.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cow:";
            // 
            // pbarChicken
            // 
            this.pbarChicken.Location = new System.Drawing.Point(101, 490);
            this.pbarChicken.Name = "pbarChicken";
            this.pbarChicken.Size = new System.Drawing.Size(129, 23);
            this.pbarChicken.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 485);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 28);
            this.label6.TabIndex = 11;
            this.label6.Text = "Chicken:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.lblMeatCount);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(384, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 112);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // lblMeatCount
            // 
            this.lblMeatCount.AutoSize = true;
            this.lblMeatCount.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMeatCount.Location = new System.Drawing.Point(93, 65);
            this.lblMeatCount.Name = "lblMeatCount";
            this.lblMeatCount.Size = new System.Drawing.Size(24, 28);
            this.lblMeatCount.TabIndex = 24;
            this.lblMeatCount.Text = "0";
            this.lblMeatCount.Click += new System.EventHandler(this.lblMeatCount_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(75, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 24);
            this.label9.TabIndex = 23;
            this.label9.Text = "Meat";
            // 
            // txtMeatSellCount
            // 
            this.txtMeatSellCount.Location = new System.Drawing.Point(402, 172);
            this.txtMeatSellCount.Name = "txtMeatSellCount";
            this.txtMeatSellCount.Size = new System.Drawing.Size(82, 22);
            this.txtMeatSellCount.TabIndex = 0;
            // 
            // btnMeatSell
            // 
            this.btnMeatSell.Location = new System.Drawing.Point(499, 172);
            this.btnMeatSell.Name = "btnMeatSell";
            this.btnMeatSell.Size = new System.Drawing.Size(75, 23);
            this.btnMeatSell.TabIndex = 14;
            this.btnMeatSell.Text = "Sell";
            this.btnMeatSell.UseVisualStyleBackColor = true;
            this.btnMeatSell.Click += new System.EventHandler(this.btnMeatSell_Click);
            // 
            // btnEggSell
            // 
            this.btnEggSell.Location = new System.Drawing.Point(499, 374);
            this.btnEggSell.Name = "btnEggSell";
            this.btnEggSell.Size = new System.Drawing.Size(75, 23);
            this.btnEggSell.TabIndex = 17;
            this.btnEggSell.Text = "Sell";
            this.btnEggSell.UseVisualStyleBackColor = true;
            this.btnEggSell.Click += new System.EventHandler(this.btnEggSell_Click);
            // 
            // txtEggSellCount
            // 
            this.txtEggSellCount.Location = new System.Drawing.Point(402, 374);
            this.txtEggSellCount.Name = "txtEggSellCount";
            this.txtEggSellCount.Size = new System.Drawing.Size(82, 22);
            this.txtEggSellCount.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(126)))));
            this.groupBox2.Controls.Add(this.lblEggCount);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(384, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 112);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // lblEggCount
            // 
            this.lblEggCount.AutoSize = true;
            this.lblEggCount.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEggCount.Location = new System.Drawing.Point(91, 60);
            this.lblEggCount.Name = "lblEggCount";
            this.lblEggCount.Size = new System.Drawing.Size(24, 28);
            this.lblEggCount.TabIndex = 26;
            this.lblEggCount.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(82, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 24);
            this.label12.TabIndex = 25;
            this.label12.Text = "Egg";
            // 
            // btnMilkSell
            // 
            this.btnMilkSell.Location = new System.Drawing.Point(499, 583);
            this.btnMilkSell.Name = "btnMilkSell";
            this.btnMilkSell.Size = new System.Drawing.Size(75, 23);
            this.btnMilkSell.TabIndex = 20;
            this.btnMilkSell.Text = "Sell";
            this.btnMilkSell.UseVisualStyleBackColor = true;
            this.btnMilkSell.Click += new System.EventHandler(this.btnMilkSell_Click);
            // 
            // txtMilkSellCount
            // 
            this.txtMilkSellCount.Location = new System.Drawing.Point(402, 583);
            this.txtMilkSellCount.Name = "txtMilkSellCount";
            this.txtMilkSellCount.Size = new System.Drawing.Size(82, 22);
            this.txtMilkSellCount.TabIndex = 18;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.groupBox3.Controls.Add(this.lblMilkCount);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(384, 441);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 112);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // lblMilkCount
            // 
            this.lblMilkCount.AutoSize = true;
            this.lblMilkCount.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMilkCount.Location = new System.Drawing.Point(91, 60);
            this.lblMilkCount.Name = "lblMilkCount";
            this.lblMilkCount.Size = new System.Drawing.Size(24, 28);
            this.lblMilkCount.TabIndex = 26;
            this.lblMilkCount.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(75, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 24);
            this.label14.TabIndex = 25;
            this.label14.Text = "Milk";
            // 
            // dataGridViewAnimals
            // 
            this.dataGridViewAnimals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnimals.Location = new System.Drawing.Point(758, 40);
            this.dataGridViewAnimals.Name = "dataGridViewAnimals";
            this.dataGridViewAnimals.RowHeadersWidth = 51;
            this.dataGridViewAnimals.RowTemplate.Height = 24;
            this.dataGridViewAnimals.Size = new System.Drawing.Size(499, 304);
            this.dataGridViewAnimals.TabIndex = 21;
            this.dataGridViewAnimals.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAnimals_CellContentClick);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.groupBox4.Controls.Add(this.lblCashAmount);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(758, 393);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(499, 226);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            // 
            // lblCashAmount
            // 
            this.lblCashAmount.AutoSize = true;
            this.lblCashAmount.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCashAmount.Location = new System.Drawing.Point(182, 131);
            this.lblCashAmount.Name = "lblCashAmount";
            this.lblCashAmount.Size = new System.Drawing.Size(113, 40);
            this.lblCashAmount.TabIndex = 24;
            this.lblCashAmount.Text = "0.00 TL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(156, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 35);
            this.label7.TabIndex = 23;
            this.label7.Text = "Cash Amount:";
            // 
            // timerProduction
            // 
            this.timerProduction.Tick += new System.EventHandler(this.timerProduction_Tick);
            // 
            // FrmBarn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1316, 643);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dataGridViewAnimals);
            this.Controls.Add(this.btnMilkSell);
            this.Controls.Add(this.txtMilkSellCount);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnEggSell);
            this.Controls.Add(this.txtEggSellCount);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnMeatSell);
            this.Controls.Add(this.txtMeatSellCount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbarChicken);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pbarCow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbarBeef);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAnimalAge);
            this.Controls.Add(this.cmbAnimalSpecies);
            this.Controls.Add(this.label1);
            this.Name = "FrmBarn";
            this.Text = "FrmBarn";
            this.Load += new System.EventHandler(this.FrmBarn_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnimals)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAnimalSpecies;
        private System.Windows.Forms.TextBox txtAnimalAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar pbarBeef;
        private System.Windows.Forms.ProgressBar pbarCow;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar pbarChicken;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMeatSellCount;
        private System.Windows.Forms.Button btnMeatSell;
        private System.Windows.Forms.Button btnEggSell;
        private System.Windows.Forms.TextBox txtEggSellCount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMilkSell;
        private System.Windows.Forms.TextBox txtMilkSellCount;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewAnimals;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblCashAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMeatCount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblEggCount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblMilkCount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Timer timerProduction;
    }
}