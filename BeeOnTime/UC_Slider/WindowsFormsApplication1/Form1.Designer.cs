namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.uC_Slider1 = new UC_Slider.UC_Slider();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uC_Slider1
            // 
            this.uC_Slider1.BarDisableImage = ((System.Drawing.Image)(resources.GetObject("uC_Slider1.BarDisableImage")));
            this.uC_Slider1.BarEnableImage = ((System.Drawing.Image)(resources.GetObject("uC_Slider1.BarEnableImage")));
            this.uC_Slider1.CursorDisableImage = ((System.Drawing.Image)(resources.GetObject("uC_Slider1.CursorDisableImage")));
            this.uC_Slider1.CursorEnableImage = ((System.Drawing.Image)(resources.GetObject("uC_Slider1.CursorEnableImage")));
            this.uC_Slider1.CursorOverImage = ((System.Drawing.Image)(resources.GetObject("uC_Slider1.CursorOverImage")));
            this.uC_Slider1.Location = new System.Drawing.Point(12, 55);
            this.uC_Slider1.Maximum = 100;
            this.uC_Slider1.Minimum = -100;
            this.uC_Slider1.Name = "uC_Slider1";
            this.uC_Slider1.Size = new System.Drawing.Size(190, 30);
            this.uC_Slider1.TabIndex = 0;
            this.uC_Slider1.Value = 0;
            this.uC_Slider1.ValueChanged += new UC_Slider.UC_Slider.ValueChangedHandler(this.uC_Slider1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 236);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uC_Slider1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UC_Slider.UC_Slider uC_Slider1;
        private System.Windows.Forms.Label label1;
    }
}

