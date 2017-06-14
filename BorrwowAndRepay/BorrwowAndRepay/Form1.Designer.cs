namespace BorrwowAndRepay
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.myNameInput = new System.Windows.Forms.TextBox();
            this.FriendNameInput = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.myNameLabel = new System.Windows.Forms.Label();
            this.MyMoneyLabel = new System.Windows.Forms.Label();
            this.FriendNameMoneyLabel = new System.Windows.Forms.Label();
            this.FriendNameLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BorrowButton = new System.Windows.Forms.Button();
            this.RepayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "請輸入我的名字:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "請輸入朋友的名字:";
            // 
            // myNameInput
            // 
            this.myNameInput.Location = new System.Drawing.Point(204, 45);
            this.myNameInput.Name = "myNameInput";
            this.myNameInput.Size = new System.Drawing.Size(100, 20);
            this.myNameInput.TabIndex = 2;
            // 
            // FriendNameInput
            // 
            this.FriendNameInput.Location = new System.Drawing.Point(225, 92);
            this.FriendNameInput.Name = "FriendNameInput";
            this.FriendNameInput.Size = new System.Drawing.Size(100, 20);
            this.FriendNameInput.TabIndex = 3;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(382, 41);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(141, 71);
            this.SubmitButton.TabIndex = 4;
            this.SubmitButton.Text = "確認";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "我的名字:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "我的$$:";
            // 
            // myNameLabel
            // 
            this.myNameLabel.AutoSize = true;
            this.myNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myNameLabel.Location = new System.Drawing.Point(152, 205);
            this.myNameLabel.Name = "myNameLabel";
            this.myNameLabel.Size = new System.Drawing.Size(75, 25);
            this.myNameLabel.TabIndex = 7;
            this.myNameLabel.Text = "無名氏";
            this.myNameLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // MyMoneyLabel
            // 
            this.MyMoneyLabel.AutoSize = true;
            this.MyMoneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyMoneyLabel.Location = new System.Drawing.Point(152, 255);
            this.MyMoneyLabel.Name = "MyMoneyLabel";
            this.MyMoneyLabel.Size = new System.Drawing.Size(24, 25);
            this.MyMoneyLabel.TabIndex = 8;
            this.MyMoneyLabel.Text = "0";
            // 
            // FriendNameMoneyLabel
            // 
            this.FriendNameMoneyLabel.AutoSize = true;
            this.FriendNameMoneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FriendNameMoneyLabel.Location = new System.Drawing.Point(428, 255);
            this.FriendNameMoneyLabel.Name = "FriendNameMoneyLabel";
            this.FriendNameMoneyLabel.Size = new System.Drawing.Size(84, 25);
            this.FriendNameMoneyLabel.TabIndex = 12;
            this.FriendNameMoneyLabel.Text = "200000";
            // 
            // FriendNameLabel
            // 
            this.FriendNameLabel.AutoSize = true;
            this.FriendNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FriendNameLabel.Location = new System.Drawing.Point(428, 205);
            this.FriendNameLabel.Name = "FriendNameLabel";
            this.FriendNameLabel.Size = new System.Drawing.Size(75, 25);
            this.FriendNameLabel.TabIndex = 11;
            this.FriendNameLabel.Text = "無名氏";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(309, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "朋友的$$:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(309, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 25);
            this.label10.TabIndex = 9;
            this.label10.Text = "朋友的名字:";
            // 
            // BorrowButton
            // 
            this.BorrowButton.Enabled = false;
            this.BorrowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrowButton.Location = new System.Drawing.Point(38, 327);
            this.BorrowButton.Name = "BorrowButton";
            this.BorrowButton.Size = new System.Drawing.Size(485, 53);
            this.BorrowButton.TabIndex = 13;
            this.BorrowButton.Text = "跟XXX借$1000";
            this.BorrowButton.UseVisualStyleBackColor = true;
            this.BorrowButton.Click += new System.EventHandler(this.BorrowButton_Click);
            // 
            // RepayButton
            // 
            this.RepayButton.Enabled = false;
            this.RepayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepayButton.Location = new System.Drawing.Point(38, 404);
            this.RepayButton.Name = "RepayButton";
            this.RepayButton.Size = new System.Drawing.Size(485, 52);
            this.RepayButton.TabIndex = 14;
            this.RepayButton.Text = "還$1000給XXX";
            this.RepayButton.UseVisualStyleBackColor = true;
            this.RepayButton.Click += new System.EventHandler(this.RepayButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 545);
            this.Controls.Add(this.RepayButton);
            this.Controls.Add(this.BorrowButton);
            this.Controls.Add(this.FriendNameMoneyLabel);
            this.Controls.Add(this.FriendNameLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.MyMoneyLabel);
            this.Controls.Add(this.myNameLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.FriendNameInput);
            this.Controls.Add(this.myNameInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "借還錢程式";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox myNameInput;
        private System.Windows.Forms.TextBox FriendNameInput;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label myNameLabel;
        private System.Windows.Forms.Label MyMoneyLabel;
        private System.Windows.Forms.Label FriendNameMoneyLabel;
        private System.Windows.Forms.Label FriendNameLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BorrowButton;
        private System.Windows.Forms.Button RepayButton;
    }
}

