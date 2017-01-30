namespace GST
{
    partial class MainForm
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
            this.ButtonInput = new System.Windows.Forms.Button();
            this.GenerateExcel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonInput
            // 
            this.ButtonInput.Location = new System.Drawing.Point(379, 154);
            this.ButtonInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonInput.Name = "ButtonInput";
            this.ButtonInput.Size = new System.Drawing.Size(173, 79);
            this.ButtonInput.TabIndex = 0;
            this.ButtonInput.Text = "Input File";
            this.ButtonInput.UseVisualStyleBackColor = true;
            this.ButtonInput.Click += new System.EventHandler(this.ButtonInput_Click);
            // 
            // GenerateExcel
            // 
            this.GenerateExcel.Location = new System.Drawing.Point(379, 463);
            this.GenerateExcel.Name = "GenerateExcel";
            this.GenerateExcel.Size = new System.Drawing.Size(173, 79);
            this.GenerateExcel.TabIndex = 1;
            this.GenerateExcel.Text = "Generate Excel";
            this.GenerateExcel.UseVisualStyleBackColor = true;
            this.GenerateExcel.Click += new System.EventHandler(this.GenerateExcel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 749);
            this.Controls.Add(this.GenerateExcel);
            this.Controls.Add(this.ButtonInput);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "GST";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonInput;
        private System.Windows.Forms.Button GenerateExcel;
    }
}

