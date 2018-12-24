namespace _07.Sumator___Mine
{
    partial class sumator
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
            this.number1 = new System.Windows.Forms.TextBox();
            this.number2 = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.Label();
            this.equal = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(48, 88);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(100, 20);
            this.number1.TabIndex = 0;
            this.number1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(185, 88);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(88, 20);
            this.number2.TabIndex = 1;
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(310, 88);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(100, 20);
            this.total.TabIndex = 2;
            // 
            // plus
            // 
            this.plus.AutoSize = true;
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plus.Location = new System.Drawing.Point(154, 83);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(25, 25);
            this.plus.TabIndex = 3;
            this.plus.Text = "+";
            this.plus.Click += new System.EventHandler(this.label1_Click);
            // 
            // equal
            // 
            this.equal.AutoSize = true;
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equal.Location = new System.Drawing.Point(279, 83);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(25, 25);
            this.equal.TabIndex = 4;
            this.equal.Text = "=";
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.Location = new System.Drawing.Point(48, 114);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(362, 37);
            this.result.TabIndex = 5;
            this.result.Text = "Result";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // sumator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 207);
            this.Controls.Add(this.result);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.total);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.Name = "sumator";
            this.Text = "Sumator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox number1;
        private System.Windows.Forms.TextBox number2;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Label plus;
        private System.Windows.Forms.Label equal;
        private System.Windows.Forms.Button result;
    }
}

