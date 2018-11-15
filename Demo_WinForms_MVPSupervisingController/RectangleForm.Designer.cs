namespace Demo_WinForms_MVPExamples
{
    partial class RectangleForm
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
            this.lbl_Length = new System.Windows.Forms.Label();
            this.lbl_Width = new System.Windows.Forms.Label();
            this.txt_Length = new System.Windows.Forms.TextBox();
            this.txt_Width = new System.Windows.Forms.TextBox();
            this.btn_CalculateArea = new System.Windows.Forms.Button();
            this.lbl_Area = new System.Windows.Forms.Label();
            this.txt_Area = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Length
            // 
            this.lbl_Length.AutoSize = true;
            this.lbl_Length.Location = new System.Drawing.Point(36, 32);
            this.lbl_Length.Name = "lbl_Length";
            this.lbl_Length.Size = new System.Drawing.Size(52, 17);
            this.lbl_Length.TabIndex = 0;
            this.lbl_Length.Text = "Length";
            // 
            // lbl_Width
            // 
            this.lbl_Width.AutoSize = true;
            this.lbl_Width.Location = new System.Drawing.Point(39, 68);
            this.lbl_Width.Name = "lbl_Width";
            this.lbl_Width.Size = new System.Drawing.Size(44, 17);
            this.lbl_Width.TabIndex = 1;
            this.lbl_Width.Text = "Width";
            // 
            // txt_Length
            // 
            this.txt_Length.Location = new System.Drawing.Point(95, 32);
            this.txt_Length.Name = "txt_Length";
            this.txt_Length.Size = new System.Drawing.Size(100, 22);
            this.txt_Length.TabIndex = 2;
            // 
            // txt_Width
            // 
            this.txt_Width.Location = new System.Drawing.Point(95, 68);
            this.txt_Width.Name = "txt_Width";
            this.txt_Width.Size = new System.Drawing.Size(100, 22);
            this.txt_Width.TabIndex = 3;
            // 
            // btn_CalculateArea
            // 
            this.btn_CalculateArea.Location = new System.Drawing.Point(39, 104);
            this.btn_CalculateArea.Name = "btn_CalculateArea";
            this.btn_CalculateArea.Size = new System.Drawing.Size(155, 33);
            this.btn_CalculateArea.TabIndex = 4;
            this.btn_CalculateArea.Text = "Calculate Area";
            this.btn_CalculateArea.UseVisualStyleBackColor = true;
            this.btn_CalculateArea.Click += new System.EventHandler(this.btn_CalculateArea_Click);
            // 
            // lbl_Area
            // 
            this.lbl_Area.AutoSize = true;
            this.lbl_Area.Location = new System.Drawing.Point(42, 162);
            this.lbl_Area.Name = "lbl_Area";
            this.lbl_Area.Size = new System.Drawing.Size(38, 17);
            this.lbl_Area.TabIndex = 5;
            this.lbl_Area.Text = "Area";
            // 
            // txt_Area
            // 
            this.txt_Area.Location = new System.Drawing.Point(95, 156);
            this.txt_Area.Name = "txt_Area";
            this.txt_Area.Size = new System.Drawing.Size(100, 22);
            this.txt_Area.TabIndex = 6;
            // 
            // ShapesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 203);
            this.Controls.Add(this.txt_Area);
            this.Controls.Add(this.lbl_Area);
            this.Controls.Add(this.btn_CalculateArea);
            this.Controls.Add(this.txt_Width);
            this.Controls.Add(this.txt_Length);
            this.Controls.Add(this.lbl_Width);
            this.Controls.Add(this.lbl_Length);
            this.Name = "ShapesForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Length;
        private System.Windows.Forms.Label lbl_Width;
        private System.Windows.Forms.TextBox txt_Length;
        private System.Windows.Forms.TextBox txt_Width;
        private System.Windows.Forms.Button btn_CalculateArea;
        private System.Windows.Forms.Label lbl_Area;
        private System.Windows.Forms.TextBox txt_Area;
    }
}

