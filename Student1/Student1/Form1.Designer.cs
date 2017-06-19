namespace Student1
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
            this.button1 = new System.Windows.Forms.Button();
            this.UserButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.userName = new System.Windows.Forms.TextBox();
            this.MagicButton = new System.Windows.Forms.Button();
            this.MathButton = new System.Windows.Forms.Button();
            this.BoardButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserButton
            // 
            this.UserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserButton.Location = new System.Drawing.Point(32, 61);
            this.UserButton.Name = "UserButton";
            this.UserButton.Size = new System.Drawing.Size(149, 103);
            this.UserButton.TabIndex = 1;
            this.UserButton.Text = "UserButton";
            this.UserButton.UseVisualStyleBackColor = true;
            this.UserButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(32, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 80);
            this.button2.TabIndex = 2;
            this.button2.Text = "GamerButton";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(207, 101);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(100, 20);
            this.userName.TabIndex = 3;
            this.userName.TextChanged += new System.EventHandler(this.userName_TextChanged);
            // 
            // MagicButton
            // 
            this.MagicButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MagicButton.Location = new System.Drawing.Point(31, 311);
            this.MagicButton.Name = "MagicButton";
            this.MagicButton.Size = new System.Drawing.Size(150, 45);
            this.MagicButton.TabIndex = 4;
            this.MagicButton.Text = "magicButton";
            this.MagicButton.UseVisualStyleBackColor = true;
            this.MagicButton.Click += new System.EventHandler(this.MagicButton_Click);
            // 
            // MathButton
            // 
            this.MathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MathButton.Location = new System.Drawing.Point(207, 310);
            this.MathButton.Name = "MathButton";
            this.MathButton.Size = new System.Drawing.Size(173, 46);
            this.MathButton.TabIndex = 5;
            this.MathButton.Text = "Math";
            this.MathButton.UseVisualStyleBackColor = true;
            this.MathButton.Click += new System.EventHandler(this.MathButton_Click);
            // 
            // BoardButton
            // 
            this.BoardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoardButton.Location = new System.Drawing.Point(207, 224);
            this.BoardButton.Name = "BoardButton";
            this.BoardButton.Size = new System.Drawing.Size(159, 37);
            this.BoardButton.TabIndex = 6;
            this.BoardButton.Text = "board";
            this.BoardButton.UseVisualStyleBackColor = true;
            this.BoardButton.Click += new System.EventHandler(this.BoardButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 401);
            this.Controls.Add(this.BoardButton);
            this.Controls.Add(this.MathButton);
            this.Controls.Add(this.MagicButton);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.UserButton);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button UserButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Button MagicButton;
        private System.Windows.Forms.Button MathButton;
        private System.Windows.Forms.Button BoardButton;
    }
}

