namespace OgameFarmingInterface
{
    partial class FormAffichageRapport
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && (components != null) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.webBrowserAffichageRapport = new System.Windows.Forms.WebBrowser();
            this.buttonFermer = new System.Windows.Forms.Button();
            this.buttonCopier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowserAffichageRapport
            // 
            this.webBrowserAffichageRapport.AllowWebBrowserDrop = false;
            this.webBrowserAffichageRapport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowserAffichageRapport.IsWebBrowserContextMenuEnabled = false;
            this.webBrowserAffichageRapport.Location = new System.Drawing.Point(8, 8);
            this.webBrowserAffichageRapport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.webBrowserAffichageRapport.MinimumSize = new System.Drawing.Size(13, 13);
            this.webBrowserAffichageRapport.Name = "webBrowserAffichageRapport";
            this.webBrowserAffichageRapport.ScriptErrorsSuppressed = true;
            this.webBrowserAffichageRapport.ScrollBarsEnabled = false;
            this.webBrowserAffichageRapport.Size = new System.Drawing.Size(468, 428);
            this.webBrowserAffichageRapport.TabIndex = 1;
            this.webBrowserAffichageRapport.WebBrowserShortcutsEnabled = false;
            // 
            // buttonFermer
            // 
            this.buttonFermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFermer.Location = new System.Drawing.Point(391, 443);
            this.buttonFermer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonFermer.Name = "buttonFermer";
            this.buttonFermer.Size = new System.Drawing.Size(85, 23);
            this.buttonFermer.TabIndex = 2;
            this.buttonFermer.Text = "Fermer";
            this.buttonFermer.UseVisualStyleBackColor = true;
            this.buttonFermer.Click += new System.EventHandler(this.buttonFermer_Click);
            // 
            // buttonCopier
            // 
            this.buttonCopier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCopier.Location = new System.Drawing.Point(301, 443);
            this.buttonCopier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCopier.Name = "buttonCopier";
            this.buttonCopier.Size = new System.Drawing.Size(85, 23);
            this.buttonCopier.TabIndex = 3;
            this.buttonCopier.Text = "Copier";
            this.buttonCopier.UseVisualStyleBackColor = true;
            this.buttonCopier.Click += new System.EventHandler(this.buttonCopier_Click);
            // 
            // FormAffichageRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 474);
            this.Controls.Add(this.buttonCopier);
            this.Controls.Add(this.buttonFermer);
            this.Controls.Add(this.webBrowserAffichageRapport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAffichageRapport";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "FormAffichageRapport";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAffichageRapport_FormClosing);
            this.Load += new System.EventHandler(this.FormAffichageRapport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserAffichageRapport;
        private System.Windows.Forms.Button buttonFermer;
        private System.Windows.Forms.Button buttonCopier;
    }
}