namespace CHKGVoprosGenerator
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
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtVopros = new System.Windows.Forms.TextBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.txtNumber.Location = new System.Drawing.Point(88, 70);
            this.txtNumber.Multiline = true;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.ReadOnly = true;
            this.txtNumber.Size = new System.Drawing.Size(59, 51);
            this.txtNumber.TabIndex = 0;
            this.txtNumber.Text = "00";
            // 
            // txtVopros
            // 
            this.txtVopros.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtVopros.Location = new System.Drawing.Point(189, 70);
            this.txtVopros.Multiline = true;
            this.txtVopros.Name = "txtVopros";
            this.txtVopros.ReadOnly = true;
            this.txtVopros.Size = new System.Drawing.Size(849, 305);
            this.txtVopros.TabIndex = 1;
            // 
            // picBox
            // 
            this.picBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox.Location = new System.Drawing.Point(154, 401);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(930, 319);
            this.picBox.TabIndex = 2;
            this.picBox.TabStop = false;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackgroundImage = global::CHKGVoprosGenerator.Properties.Resources.vopros1;
            this.btnGenerate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGenerate.Location = new System.Drawing.Point(524, 717);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(231, 79);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CHKGVoprosGenerator.Properties.Resources.frame;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1227, 873);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.txtVopros);
            this.Controls.Add(this.txtNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtVopros;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button btnGenerate;
    }
}

