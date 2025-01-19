namespace CromSharp
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolbar = new System.Windows.Forms.Panel();
            this.refresh = new System.Windows.Forms.PictureBox();
            this.forward = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.PictureBox();
            this.urlText = new System.Windows.Forms.TextBox();
            this.browserPanel = new System.Windows.Forms.Panel();
            this.toolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            this.SuspendLayout();
            // 
            // toolbar
            // 
            this.toolbar.Controls.Add(this.urlText);
            this.toolbar.Controls.Add(this.refresh);
            this.toolbar.Controls.Add(this.forward);
            this.toolbar.Controls.Add(this.back);
            this.toolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolbar.Location = new System.Drawing.Point(0, 0);
            this.toolbar.Name = "toolbar";
            this.toolbar.Size = new System.Drawing.Size(800, 32);
            this.toolbar.TabIndex = 0;
            // 
            // refresh
            // 
            this.refresh.Image = global::CromSharp.Properties.Resources.refresh;
            this.refresh.Location = new System.Drawing.Point(76, 0);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(32, 32);
            this.refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refresh.TabIndex = 3;
            this.refresh.TabStop = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // forward
            // 
            this.forward.Image = global::CromSharp.Properties.Resources.forward;
            this.forward.Location = new System.Drawing.Point(38, 0);
            this.forward.Name = "forward";
            this.forward.Size = new System.Drawing.Size(32, 32);
            this.forward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.forward.TabIndex = 1;
            this.forward.TabStop = false;
            this.forward.Click += new System.EventHandler(this.forward_Click);
            // 
            // back
            // 
            this.back.Image = global::CromSharp.Properties.Resources.back;
            this.back.Location = new System.Drawing.Point(0, 0);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(32, 32);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back.TabIndex = 0;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // urlText
            // 
            this.urlText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlText.Location = new System.Drawing.Point(114, 6);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(674, 20);
            this.urlText.TabIndex = 6;
            this.urlText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.urlText_KeyDown);
            // 
            // browserPanel
            // 
            this.browserPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browserPanel.Location = new System.Drawing.Point(0, 32);
            this.browserPanel.Name = "browserPanel";
            this.browserPanel.Size = new System.Drawing.Size(800, 418);
            this.browserPanel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.browserPanel);
            this.Controls.Add(this.toolbar);
            this.Name = "Form1";
            this.Text = "CromSharp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel toolbar;
        private System.Windows.Forms.PictureBox forward;
        private System.Windows.Forms.PictureBox refresh;
        private System.Windows.Forms.TextBox urlText;
        private System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.Panel browserPanel;
    }
}

