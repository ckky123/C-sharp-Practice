namespace PictureBox
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
            this.catBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.catBox)).BeginInit();
            this.SuspendLayout();
            // 
            // catBox
            // 
            this.catBox.Image = global::PictureBox.Properties.Resources.cat1;
            this.catBox.Location = new System.Drawing.Point(183, 114);
            this.catBox.Name = "catBox";
            this.catBox.Size = new System.Drawing.Size(398, 370);
            this.catBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.catBox.TabIndex = 0;
            this.catBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(183, 522);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(417, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "change cat!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 606);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.catBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.catBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox catBox;
        private System.Windows.Forms.Button button1;
    }
}

