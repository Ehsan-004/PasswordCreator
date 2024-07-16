namespace PasswordCreator
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
            this.cb_lowercase = new System.Windows.Forms.CheckBox();
            this.cb_uppercase = new System.Windows.Forms.CheckBox();
            this.cb_numbers = new System.Windows.Forms.CheckBox();
            this.cb_special = new System.Windows.Forms.CheckBox();
            this.button_generate = new System.Windows.Forms.Button();
            this.button_copy = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.length_of_password = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.length_of_password)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_lowercase
            // 
            this.cb_lowercase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_lowercase.AutoSize = true;
            this.cb_lowercase.Font = new System.Drawing.Font("Source Sans Pro", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_lowercase.Location = new System.Drawing.Point(236, 64);
            this.cb_lowercase.Name = "cb_lowercase";
            this.cb_lowercase.Size = new System.Drawing.Size(294, 46);
            this.cb_lowercase.TabIndex = 0;
            this.cb_lowercase.Text = "lowercase words";
            this.cb_lowercase.UseVisualStyleBackColor = true;
            this.cb_lowercase.CheckedChanged += new System.EventHandler(this.cb_lowercase_CheckedChanged);
            // 
            // cb_uppercase
            // 
            this.cb_uppercase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_uppercase.AutoSize = true;
            this.cb_uppercase.Font = new System.Drawing.Font("Source Sans Pro", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_uppercase.Location = new System.Drawing.Point(236, 125);
            this.cb_uppercase.Name = "cb_uppercase";
            this.cb_uppercase.Size = new System.Drawing.Size(296, 46);
            this.cb_uppercase.TabIndex = 1;
            this.cb_uppercase.Text = "uppercase words";
            this.cb_uppercase.UseVisualStyleBackColor = true;
            this.cb_uppercase.CheckedChanged += new System.EventHandler(this.cb_uppercase_CheckedChanged);
            // 
            // cb_numbers
            // 
            this.cb_numbers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_numbers.AutoSize = true;
            this.cb_numbers.Font = new System.Drawing.Font("Source Sans Pro", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_numbers.Location = new System.Drawing.Point(236, 187);
            this.cb_numbers.Name = "cb_numbers";
            this.cb_numbers.Size = new System.Drawing.Size(173, 46);
            this.cb_numbers.TabIndex = 2;
            this.cb_numbers.Text = "numbers";
            this.cb_numbers.UseVisualStyleBackColor = true;
            this.cb_numbers.CheckedChanged += new System.EventHandler(this.cb_numbers_CheckedChanged);
            // 
            // cb_special
            // 
            this.cb_special.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_special.AutoSize = true;
            this.cb_special.Font = new System.Drawing.Font("Source Sans Pro", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_special.Location = new System.Drawing.Point(236, 247);
            this.cb_special.Name = "cb_special";
            this.cb_special.Size = new System.Drawing.Size(311, 46);
            this.cb_special.TabIndex = 3;
            this.cb_special.Text = "special characters";
            this.cb_special.UseVisualStyleBackColor = true;
            this.cb_special.CheckedChanged += new System.EventHandler(this.cb_special_CheckedChanged);
            // 
            // button_generate
            // 
            this.button_generate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_generate.Location = new System.Drawing.Point(525, 412);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(104, 36);
            this.button_generate.TabIndex = 4;
            this.button_generate.Text = "generate";
            this.button_generate.UseVisualStyleBackColor = true;
            this.button_generate.Click += new System.EventHandler(this.button_generate_Click);
            // 
            // button_copy
            // 
            this.button_copy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_copy.Location = new System.Drawing.Point(407, 412);
            this.button_copy.Name = "button_copy";
            this.button_copy.Size = new System.Drawing.Size(104, 36);
            this.button_copy.TabIndex = 5;
            this.button_copy.Text = "copy";
            this.button_copy.UseVisualStyleBackColor = true;
            this.button_copy.Click += new System.EventHandler(this.button_copy_Click);
            // 
            // tb_password
            // 
            this.tb_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_password.Font = new System.Drawing.Font("Source Sans Pro", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(153, 412);
            this.tb_password.Name = "tb_password";
            this.tb_password.ReadOnly = true;
            this.tb_password.Size = new System.Drawing.Size(240, 36);
            this.tb_password.TabIndex = 6;
            // 
            // length_of_password
            // 
            this.length_of_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.length_of_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.length_of_password.Location = new System.Drawing.Point(422, 326);
            this.length_of_password.Name = "length_of_password";
            this.length_of_password.Size = new System.Drawing.Size(157, 38);
            this.length_of_password.TabIndex = 7;
            this.length_of_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.length_of_password.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 43);
            this.label1.TabIndex = 8;
            this.label1.Text = "number of digits";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.length_of_password);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.button_copy);
            this.Controls.Add(this.button_generate);
            this.Controls.Add(this.cb_special);
            this.Controls.Add(this.cb_numbers);
            this.Controls.Add(this.cb_uppercase);
            this.Controls.Add(this.cb_lowercase);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "password generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.length_of_password)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_lowercase;
        private System.Windows.Forms.CheckBox cb_uppercase;
        private System.Windows.Forms.CheckBox cb_numbers;
        private System.Windows.Forms.CheckBox cb_special;
        private System.Windows.Forms.Button button_generate;
        private System.Windows.Forms.Button button_copy;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.NumericUpDown length_of_password;
        private System.Windows.Forms.Label label1;
    }
}

