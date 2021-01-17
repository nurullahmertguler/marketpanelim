namespace marketpanelim
{
    partial class urunstokdurumlari
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
            this.button5 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 33);
            this.button5.TabIndex = 18;
            this.button5.Text = "Ana Sayfa";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 67);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1378, 667);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // urunstokdurumlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 734);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button5);
            this.Name = "urunstokdurumlari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "urunstokdurumlari";
            this.Load += new System.EventHandler(this.urunstokdurumlari_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}