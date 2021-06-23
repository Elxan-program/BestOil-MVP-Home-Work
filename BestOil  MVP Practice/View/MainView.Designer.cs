
namespace BestOil__MVP_Practice
{
    partial class MainView
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Litertxtbox = new System.Windows.Forms.TextBox();
            this.Cashtxtbox = new System.Windows.Forms.TextBox();
            this.Liter_radio_btn = new System.Windows.Forms.RadioButton();
            this.Cash_radio_btn = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GasComboBox = new System.Windows.Forms.ComboBox();
            this.Buy_Btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Amount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.GasComboBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 452);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gas Station";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.Price);
            this.groupBox3.Location = new System.Drawing.Point(7, 350);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(334, 96);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(206, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "AZN";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price.Location = new System.Drawing.Point(85, 44);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(74, 36);
            this.Price.TabIndex = 0;
            this.Price.Text = "0.00";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Litertxtbox);
            this.groupBox2.Controls.Add(this.Cashtxtbox);
            this.groupBox2.Controls.Add(this.Liter_radio_btn);
            this.groupBox2.Controls.Add(this.Cash_radio_btn);
            this.groupBox2.Location = new System.Drawing.Point(7, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 117);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "By";
            // 
            // Litertxtbox
            // 
            this.Litertxtbox.Location = new System.Drawing.Point(174, 71);
            this.Litertxtbox.Name = "Litertxtbox";
            this.Litertxtbox.Size = new System.Drawing.Size(154, 34);
            this.Litertxtbox.TabIndex = 3;
            this.Litertxtbox.TextChanged += new System.EventHandler(this.Litertxtbox_TextChanged);
            // 
            // Cashtxtbox
            // 
            this.Cashtxtbox.Location = new System.Drawing.Point(174, 31);
            this.Cashtxtbox.Name = "Cashtxtbox";
            this.Cashtxtbox.Size = new System.Drawing.Size(154, 34);
            this.Cashtxtbox.TabIndex = 2;
            this.Cashtxtbox.TextChanged += new System.EventHandler(this.Cashtxtbox_TextChanged);
            // 
            // Liter_radio_btn
            // 
            this.Liter_radio_btn.AutoSize = true;
            this.Liter_radio_btn.Location = new System.Drawing.Point(24, 72);
            this.Liter_radio_btn.Name = "Liter_radio_btn";
            this.Liter_radio_btn.Size = new System.Drawing.Size(81, 33);
            this.Liter_radio_btn.TabIndex = 1;
            this.Liter_radio_btn.TabStop = true;
            this.Liter_radio_btn.Text = "Liter";
            this.Liter_radio_btn.UseVisualStyleBackColor = true;
            // 
            // Cash_radio_btn
            // 
            this.Cash_radio_btn.AutoSize = true;
            this.Cash_radio_btn.Location = new System.Drawing.Point(24, 33);
            this.Cash_radio_btn.Name = "Cash_radio_btn";
            this.Cash_radio_btn.Size = new System.Drawing.Size(89, 33);
            this.Cash_radio_btn.TabIndex = 0;
            this.Cash_radio_btn.TabStop = true;
            this.Cash_radio_btn.Text = "Cash";
            this.Cash_radio_btn.UseVisualStyleBackColor = true;
            this.Cash_radio_btn.CheckedChanged += new System.EventHandler(this.Cash_radio_btn_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(256, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "AZN";
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Amount.Location = new System.Drawing.Point(162, 140);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(71, 32);
            this.Amount.TabIndex = 3;
            this.Amount.Text = "0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(24, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gas";
            // 
            // GasComboBox
            // 
            this.GasComboBox.FormattingEnabled = true;
            this.GasComboBox.Location = new System.Drawing.Point(152, 53);
            this.GasComboBox.Name = "GasComboBox";
            this.GasComboBox.Size = new System.Drawing.Size(168, 37);
            this.GasComboBox.TabIndex = 0;
            this.GasComboBox.SelectedIndexChanged += new System.EventHandler(this.GasComboBox_SelectedIndexChanged);
            // 
            // Buy_Btn
            // 
            this.Buy_Btn.AutoSize = true;
            this.Buy_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Buy_Btn.Location = new System.Drawing.Point(13, 472);
            this.Buy_Btn.Name = "Buy_Btn";
            this.Buy_Btn.Size = new System.Drawing.Size(347, 83);
            this.Buy_Btn.TabIndex = 1;
            this.Buy_Btn.Text = "BUY";
            this.Buy_Btn.UseVisualStyleBackColor = true;
            this.Buy_Btn.Click += new System.EventHandler(this.Buy_Btn_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 561);
            this.Controls.Add(this.Buy_Btn);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(388, 608);
            this.MinimumSize = new System.Drawing.Size(388, 608);
            this.Name = "MainView";
            this.Text = "BestOil";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox GasComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Litertxtbox;
        private System.Windows.Forms.TextBox Cashtxtbox;
        private System.Windows.Forms.RadioButton Liter_radio_btn;
        private System.Windows.Forms.RadioButton Cash_radio_btn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Button Buy_Btn;
    }
}

