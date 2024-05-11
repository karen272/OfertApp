namespace OfertApp.Vista
{
    partial class ViewFeed
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
            this.btnSubirOfeta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSubirOfeta
            // 
            this.btnSubirOfeta.Location = new System.Drawing.Point(500, 70);
            this.btnSubirOfeta.Name = "btnSubirOfeta";
            this.btnSubirOfeta.Size = new System.Drawing.Size(75, 23);
            this.btnSubirOfeta.TabIndex = 0;
            this.btnSubirOfeta.Text = "Subir Oferta";
            this.btnSubirOfeta.UseVisualStyleBackColor = true;
            this.btnSubirOfeta.Click += new System.EventHandler(this.btnSubirOfeta_Click);
            // 
            // ViewFeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubirOfeta);
            this.Name = "ViewFeed";
            this.Text = "ViewFeed";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubirOfeta;
    }
}