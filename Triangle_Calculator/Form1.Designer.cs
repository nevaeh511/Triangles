namespace Triangle_Calculator
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
            this.Lbl_SideA = new System.Windows.Forms.Label();
            this.Lbl_SideB = new System.Windows.Forms.Label();
            this.Lbl_SideC = new System.Windows.Forms.Label();
            this.TxtBox_SideA = new System.Windows.Forms.TextBox();
            this.TxtBox_SideB = new System.Windows.Forms.TextBox();
            this.TxtBox_SideC = new System.Windows.Forms.TextBox();
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.Lbl_Sides = new System.Windows.Forms.Label();
            this.Lbl_Output = new System.Windows.Forms.Label();
            this.Lbl_OutputText = new System.Windows.Forms.Label();
            this.Lbl_ErrorMessage_SideA = new System.Windows.Forms.Label();
            this.Lbl_ErrorMessage_SideB = new System.Windows.Forms.Label();
            this.Lbl_ErrorMessage_SideC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_SideA
            // 
            this.Lbl_SideA.AutoSize = true;
            this.Lbl_SideA.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_SideA.Location = new System.Drawing.Point(50, 83);
            this.Lbl_SideA.Name = "Lbl_SideA";
            this.Lbl_SideA.Size = new System.Drawing.Size(68, 20);
            this.Lbl_SideA.TabIndex = 7;
            this.Lbl_SideA.Text = "Side A:";
            // 
            // Lbl_SideB
            // 
            this.Lbl_SideB.AutoSize = true;
            this.Lbl_SideB.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_SideB.Location = new System.Drawing.Point(50, 109);
            this.Lbl_SideB.Name = "Lbl_SideB";
            this.Lbl_SideB.Size = new System.Drawing.Size(68, 20);
            this.Lbl_SideB.TabIndex = 8;
            this.Lbl_SideB.Text = "Side B:";
            // 
            // Lbl_SideC
            // 
            this.Lbl_SideC.AutoSize = true;
            this.Lbl_SideC.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_SideC.Location = new System.Drawing.Point(50, 133);
            this.Lbl_SideC.Name = "Lbl_SideC";
            this.Lbl_SideC.Size = new System.Drawing.Size(68, 20);
            this.Lbl_SideC.TabIndex = 9;
            this.Lbl_SideC.Text = "Side C:";
            // 
            // TxtBox_SideA
            // 
            this.TxtBox_SideA.Location = new System.Drawing.Point(117, 83);
            this.TxtBox_SideA.Name = "TxtBox_SideA";
            this.TxtBox_SideA.Size = new System.Drawing.Size(100, 20);
            this.TxtBox_SideA.TabIndex = 1;
            this.TxtBox_SideA.TextChanged += new System.EventHandler(this.TxtBox_SideA_TextChanged);
            // 
            // TxtBox_SideB
            // 
            this.TxtBox_SideB.Location = new System.Drawing.Point(117, 109);
            this.TxtBox_SideB.Name = "TxtBox_SideB";
            this.TxtBox_SideB.Size = new System.Drawing.Size(100, 20);
            this.TxtBox_SideB.TabIndex = 2;
            this.TxtBox_SideB.TextChanged += new System.EventHandler(this.TxtBox_SideB_TextChanged);
            // 
            // TxtBox_SideC
            // 
            this.TxtBox_SideC.Location = new System.Drawing.Point(117, 133);
            this.TxtBox_SideC.Name = "TxtBox_SideC";
            this.TxtBox_SideC.Size = new System.Drawing.Size(100, 20);
            this.TxtBox_SideC.TabIndex = 3;
            this.TxtBox_SideC.TextChanged += new System.EventHandler(this.TxtBox_SideC_TextChanged);
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.AutoSize = true;
            this.Lbl_Title.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Title.Location = new System.Drawing.Point(50, 9);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(210, 24);
            this.Lbl_Title.TabIndex = 13;
            this.Lbl_Title.Text = "Triangle Calculator";
            // 
            // Lbl_Sides
            // 
            this.Lbl_Sides.AutoSize = true;
            this.Lbl_Sides.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Sides.Location = new System.Drawing.Point(113, 60);
            this.Lbl_Sides.Name = "Lbl_Sides";
            this.Lbl_Sides.Size = new System.Drawing.Size(185, 20);
            this.Lbl_Sides.TabIndex = 12;
            this.Lbl_Sides.Text = "Enter Lengths Below:";
            // 
            // Lbl_Output
            // 
            this.Lbl_Output.AutoSize = true;
            this.Lbl_Output.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Output.Location = new System.Drawing.Point(49, 185);
            this.Lbl_Output.Name = "Lbl_Output";
            this.Lbl_Output.Size = new System.Drawing.Size(73, 20);
            this.Lbl_Output.TabIndex = 10;
            this.Lbl_Output.Text = "Output:";
            // 
            // Lbl_OutputText
            // 
            this.Lbl_OutputText.AutoSize = true;
            this.Lbl_OutputText.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_OutputText.Location = new System.Drawing.Point(128, 185);
            this.Lbl_OutputText.Name = "Lbl_OutputText";
            this.Lbl_OutputText.Size = new System.Drawing.Size(143, 20);
            this.Lbl_OutputText.TabIndex = 11;
            this.Lbl_OutputText.Text = "Output Message";
            // 
            // Lbl_ErrorMessage_SideA
            // 
            this.Lbl_ErrorMessage_SideA.AutoSize = true;
            this.Lbl_ErrorMessage_SideA.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ErrorMessage_SideA.Location = new System.Drawing.Point(223, 86);
            this.Lbl_ErrorMessage_SideA.Name = "Lbl_ErrorMessage_SideA";
            this.Lbl_ErrorMessage_SideA.Size = new System.Drawing.Size(180, 20);
            this.Lbl_ErrorMessage_SideA.TabIndex = 4;
            this.Lbl_ErrorMessage_SideA.Text = "Error Message_SideA";
            // 
            // Lbl_ErrorMessage_SideB
            // 
            this.Lbl_ErrorMessage_SideB.AutoSize = true;
            this.Lbl_ErrorMessage_SideB.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ErrorMessage_SideB.Location = new System.Drawing.Point(223, 112);
            this.Lbl_ErrorMessage_SideB.Name = "Lbl_ErrorMessage_SideB";
            this.Lbl_ErrorMessage_SideB.Size = new System.Drawing.Size(180, 20);
            this.Lbl_ErrorMessage_SideB.TabIndex = 5;
            this.Lbl_ErrorMessage_SideB.Text = "Error Message_SideB";
            // 
            // Lbl_ErrorMessage_SideC
            // 
            this.Lbl_ErrorMessage_SideC.AutoSize = true;
            this.Lbl_ErrorMessage_SideC.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ErrorMessage_SideC.Location = new System.Drawing.Point(223, 136);
            this.Lbl_ErrorMessage_SideC.Name = "Lbl_ErrorMessage_SideC";
            this.Lbl_ErrorMessage_SideC.Size = new System.Drawing.Size(180, 20);
            this.Lbl_ErrorMessage_SideC.TabIndex = 6;
            this.Lbl_ErrorMessage_SideC.Text = "Error Message_SideC";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 261);
            this.Controls.Add(this.Lbl_ErrorMessage_SideC);
            this.Controls.Add(this.Lbl_ErrorMessage_SideB);
            this.Controls.Add(this.Lbl_ErrorMessage_SideA);
            this.Controls.Add(this.Lbl_OutputText);
            this.Controls.Add(this.Lbl_Output);
            this.Controls.Add(this.Lbl_Sides);
            this.Controls.Add(this.Lbl_Title);
            this.Controls.Add(this.TxtBox_SideC);
            this.Controls.Add(this.TxtBox_SideB);
            this.Controls.Add(this.TxtBox_SideA);
            this.Controls.Add(this.Lbl_SideC);
            this.Controls.Add(this.Lbl_SideB);
            this.Controls.Add(this.Lbl_SideA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_SideA;
        private System.Windows.Forms.Label Lbl_SideB;
        private System.Windows.Forms.Label Lbl_SideC;
        private System.Windows.Forms.TextBox TxtBox_SideA;
        private System.Windows.Forms.TextBox TxtBox_SideB;
        private System.Windows.Forms.TextBox TxtBox_SideC;
        private System.Windows.Forms.Label Lbl_Title;
        private System.Windows.Forms.Label Lbl_Sides;
        private System.Windows.Forms.Label Lbl_Output;
        private System.Windows.Forms.Label Lbl_OutputText;
        private System.Windows.Forms.Label Lbl_ErrorMessage_SideA;
        private System.Windows.Forms.Label Lbl_ErrorMessage_SideB;
        private System.Windows.Forms.Label Lbl_ErrorMessage_SideC;
    }
}

