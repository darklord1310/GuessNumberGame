namespace GuessNumberGame
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
            this.gbxMsg = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGuessNumber = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.gbxMsg.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxMsg
            // 
            this.gbxMsg.Controls.Add(this.label3);
            this.gbxMsg.Controls.Add(this.label2);
            this.gbxMsg.Controls.Add(this.txtMsg);
            this.gbxMsg.Location = new System.Drawing.Point(15, 248);
            this.gbxMsg.Name = "gbxMsg";
            this.gbxMsg.Size = new System.Drawing.Size(277, 85);
            this.gbxMsg.TabIndex = 0;
            this.gbxMsg.TabStop = false;
            this.gbxMsg.Text = "Feedback";
            this.gbxMsg.Enter += new System.EventHandler(this.gbxMsg_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(23, 37);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.ReadOnly = true;
            this.txtMsg.Size = new System.Drawing.Size(235, 20);
            this.txtMsg.TabIndex = 0;
            this.txtMsg.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your Guess :  ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtGuessNumber
            // 
            this.txtGuessNumber.Location = new System.Drawing.Point(92, 6);
            this.txtGuessNumber.Name = "txtGuessNumber";
            this.txtGuessNumber.Size = new System.Drawing.Size(123, 20);
            this.txtGuessNumber.TabIndex = 2;
            this.txtGuessNumber.TextChanged += new System.EventHandler(this.txtGuessNumber_TextChanged);
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(92, 72);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(123, 25);
            this.btnGuess.TabIndex = 3;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 395);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.txtGuessNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbxMsg);
            this.Name = "Form1";
            this.Text = "Guess The Number!";
            this.gbxMsg.ResumeLayout(false);
            this.gbxMsg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxMsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGuessNumber;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMsg;
    }
}

