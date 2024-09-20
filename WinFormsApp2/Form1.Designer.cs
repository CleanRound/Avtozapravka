namespace Avtozapravka
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.comboBoxGasoline = new System.Windows.Forms.ComboBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelGasoline = new System.Windows.Forms.Label();
            this.labelLiters = new System.Windows.Forms.Label();
            this.labelRemaining = new System.Windows.Forms.Label();
            this.textBoxLiters = new System.Windows.Forms.TextBox();
            this.textBoxRemaining = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(130, 30);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxAmount.TabIndex = 0;
            this.textBoxAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAmount_KeyPress);
            this.textBoxAmount.TextChanged += new System.EventHandler(this.textBoxAmount_TextChanged);

            // 
            // comboBoxGasoline
            // 
            this.comboBoxGasoline.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGasoline.FormattingEnabled = true;
            this.comboBoxGasoline.Items.AddRange(new object[] {
            "A-95 - 50 UAH/L",
            "A-92 - 45 UAH/L",
            "Diesel - 47 UAH/L"});
            this.comboBoxGasoline.Location = new System.Drawing.Point(130, 70);
            this.comboBoxGasoline.Name = "comboBoxGasoline";
            this.comboBoxGasoline.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGasoline.TabIndex = 1;
            this.comboBoxGasoline.SelectedIndexChanged += new System.EventHandler(this.comboBoxGasoline_SelectedIndexChanged);

            // 
            // buttonOK
            // 
            this.buttonOK.Enabled = false;
            this.buttonOK.Location = new System.Drawing.Point(130, 110);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);

            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(50, 33);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(43, 13);
            this.labelAmount.TabIndex = 3;
            this.labelAmount.Text = "Amount";

            // 
            // labelGasoline
            // 
            this.labelGasoline.AutoSize = true;
            this.labelGasoline.Location = new System.Drawing.Point(50, 73);
            this.labelGasoline.Name = "labelGasoline";
            this.labelGasoline.Size = new System.Drawing.Size(47, 13);
            this.labelGasoline.TabIndex = 4;
            this.labelGasoline.Text = "Gasoline";

            // 
            // labelLiters
            // 
            this.labelLiters.AutoSize = true;
            this.labelLiters.Location = new System.Drawing.Point(50, 150);
            this.labelLiters.Name = "labelLiters";
            this.labelLiters.Size = new System.Drawing.Size(32, 13);
            this.labelLiters.TabIndex = 5;
            this.labelLiters.Text = "Liters";

            // 
            // labelRemaining
            // 
            this.labelRemaining.AutoSize = true;
            this.labelRemaining.Location = new System.Drawing.Point(50, 190);
            this.labelRemaining.Name = "labelRemaining";
            this.labelRemaining.Size = new System.Drawing.Size(56, 13);
            this.labelRemaining.TabIndex = 6;
            this.labelRemaining.Text = "Remaining";

            // 
            // textBoxLiters
            // 
            this.textBoxLiters.Location = new System.Drawing.Point(130, 147);
            this.textBoxLiters.Name = "textBoxLiters";
            this.textBoxLiters.ReadOnly = true;
            this.textBoxLiters.Size = new System.Drawing.Size(100, 20);
            this.textBoxLiters.TabIndex = 7;

            // 
            // textBoxRemaining
            // 
            this.textBoxRemaining.Location = new System.Drawing.Point(130, 187);
            this.textBoxRemaining.Name = "textBoxRemaining";
            this.textBoxRemaining.ReadOnly = true;
            this.textBoxRemaining.Size = new System.Drawing.Size(100, 20);
            this.textBoxRemaining.TabIndex = 8;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBoxRemaining);
            this.Controls.Add(this.textBoxLiters);
            this.Controls.Add(this.labelRemaining);
            this.Controls.Add(this.labelLiters);
            this.Controls.Add(this.labelGasoline);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.comboBoxGasoline);
            this.Controls.Add(this.textBoxAmount);
            this.Name = "Form1";
            this.Text = "Avtozapravka";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.ComboBox comboBoxGasoline;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelGasoline;
        private System.Windows.Forms.Label labelLiters;
        private System.Windows.Forms.Label labelRemaining;
        private System.Windows.Forms.TextBox textBoxLiters;
        private System.Windows.Forms.TextBox textBoxRemaining;
    }
}
