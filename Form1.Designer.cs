namespace BitImgChaineCodeApp
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
            this.LoadImage1Button = new System.Windows.Forms.Button();
            this.LoadImage2Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.GenerateChainCode1Button = new System.Windows.Forms.Button();
            this.GenerateChainCode2Button = new System.Windows.Forms.Button();
            this.chainCode1TextBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.ApplyLogicalOperationButton = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SaveResultButton = new System.Windows.Forms.Button();
            this.ConvertToBinaryImageButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadImage1Button
            // 
            this.LoadImage1Button.Location = new System.Drawing.Point(12, 13);
            this.LoadImage1Button.Name = "LoadImage1Button";
            this.LoadImage1Button.Size = new System.Drawing.Size(96, 23);
            this.LoadImage1Button.TabIndex = 0;
            this.LoadImage1Button.Text = "Load Image 1";
            this.LoadImage1Button.UseVisualStyleBackColor = true;
            // 
            // LoadImage2Button
            // 
            this.LoadImage2Button.Location = new System.Drawing.Point(12, 42);
            this.LoadImage2Button.Name = "LoadImage2Button";
            this.LoadImage2Button.Size = new System.Drawing.Size(97, 23);
            this.LoadImage2Button.TabIndex = 1;
            this.LoadImage2Button.Text = "Load Image 2";
            this.LoadImage2Button.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(306, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(442, 429);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(793, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(442, 429);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(306, 462);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(442, 429);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // GenerateChainCode1Button
            // 
            this.GenerateChainCode1Button.Location = new System.Drawing.Point(12, 90);
            this.GenerateChainCode1Button.Name = "GenerateChainCode1Button";
            this.GenerateChainCode1Button.Size = new System.Drawing.Size(154, 23);
            this.GenerateChainCode1Button.TabIndex = 5;
            this.GenerateChainCode1Button.Text = "Generate Chain Code 1";
            this.GenerateChainCode1Button.UseVisualStyleBackColor = true;
            // 
            // GenerateChainCode2Button
            // 
            this.GenerateChainCode2Button.Location = new System.Drawing.Point(12, 119);
            this.GenerateChainCode2Button.Name = "GenerateChainCode2Button";
            this.GenerateChainCode2Button.Size = new System.Drawing.Size(154, 23);
            this.GenerateChainCode2Button.TabIndex = 6;
            this.GenerateChainCode2Button.Text = "Generate Chain Code 2";
            this.GenerateChainCode2Button.UseVisualStyleBackColor = true;
            // 
            // chainCode1TextBox
            // 
            this.chainCode1TextBox.Location = new System.Drawing.Point(12, 170);
            this.chainCode1TextBox.Name = "chainCode1TextBox";
            this.chainCode1TextBox.Size = new System.Drawing.Size(154, 20);
            this.chainCode1TextBox.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 196);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(153, 20);
            this.textBox2.TabIndex = 8;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "AND",
            "NOT ",
            "AndNot",
            "OR",
            "XOR"});
            this.checkedListBox1.Location = new System.Drawing.Point(12, 240);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(122, 79);
            this.checkedListBox1.TabIndex = 10;
            // 
            // ApplyLogicalOperationButton
            // 
            this.ApplyLogicalOperationButton.Location = new System.Drawing.Point(12, 344);
            this.ApplyLogicalOperationButton.Name = "ApplyLogicalOperationButton";
            this.ApplyLogicalOperationButton.Size = new System.Drawing.Size(154, 23);
            this.ApplyLogicalOperationButton.TabIndex = 11;
            this.ApplyLogicalOperationButton.Text = "Apply Logical Operation";
            this.ApplyLogicalOperationButton.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 399);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(153, 20);
            this.textBox3.TabIndex = 12;
            // 
            // SaveResultButton
            // 
            this.SaveResultButton.Location = new System.Drawing.Point(12, 492);
            this.SaveResultButton.Name = "SaveResultButton";
            this.SaveResultButton.Size = new System.Drawing.Size(96, 23);
            this.SaveResultButton.TabIndex = 13;
            this.SaveResultButton.Text = "Save Result";
            this.SaveResultButton.UseVisualStyleBackColor = true;
            // 
            // ConvertToBinaryImageButton
            // 
            this.ConvertToBinaryImageButton.Location = new System.Drawing.Point(11, 452);
            this.ConvertToBinaryImageButton.Name = "ConvertToBinaryImageButton";
            this.ConvertToBinaryImageButton.Size = new System.Drawing.Size(154, 23);
            this.ConvertToBinaryImageButton.TabIndex = 14;
            this.ConvertToBinaryImageButton.Text = "Generate Chain Code 1";
            this.ConvertToBinaryImageButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 903);
            this.Controls.Add(this.ConvertToBinaryImageButton);
            this.Controls.Add(this.SaveResultButton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.ApplyLogicalOperationButton);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.chainCode1TextBox);
            this.Controls.Add(this.GenerateChainCode2Button);
            this.Controls.Add(this.GenerateChainCode1Button);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LoadImage2Button);
            this.Controls.Add(this.LoadImage1Button);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadImage1Button;
        private System.Windows.Forms.Button LoadImage2Button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button GenerateChainCode1Button;
        private System.Windows.Forms.Button GenerateChainCode2Button;
        private System.Windows.Forms.TextBox chainCode1TextBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button ApplyLogicalOperationButton;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button SaveResultButton;
        private System.Windows.Forms.Button ConvertToBinaryImageButton;
    }
}

