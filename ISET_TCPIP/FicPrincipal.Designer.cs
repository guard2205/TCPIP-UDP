namespace ISET_TCPIP
{
    partial class EcranPrincipal
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mCommunication = new System.Windows.Forms.ToolStripMenuItem();
            this.mcListenerClient = new System.Windows.Forms.ToolStripMenuItem();
            this.mclcEcouter = new System.Windows.Forms.ToolStripMenuItem();
            this.mclcConnecter = new System.Windows.Forms.ToolStripMenuItem();
            this.mcUDPListenerClient = new System.Windows.Forms.ToolStripMenuItem();
            this.mcudpListener = new System.Windows.Forms.ToolStripMenuItem();
            this.mcudpClient = new System.Windows.Forms.ToolStripMenuItem();
            this.mUtilitaire = new System.Windows.Forms.ToolStripMenuItem();
            this.muVerifier = new System.Windows.Forms.ToolStripMenuItem();
            this.mQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblServer = new System.Windows.Forms.Label();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.tbQuestions = new System.Windows.Forms.TextBox();
            this.lblQuestions = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.lblReponse = new System.Windows.Forms.Label();
            this.lbReponses = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mCommunication,
            this.mUtilitaire,
            this.mQuitter});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(362, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mCommunication
            // 
            this.mCommunication.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mcListenerClient,
            this.mcUDPListenerClient});
            this.mCommunication.Name = "mCommunication";
            this.mCommunication.Size = new System.Drawing.Size(126, 24);
            this.mCommunication.Text = "Communication";
            // 
            // mcListenerClient
            // 
            this.mcListenerClient.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mclcEcouter,
            this.mclcConnecter});
            this.mcListenerClient.Name = "mcListenerClient";
            this.mcListenerClient.Size = new System.Drawing.Size(237, 26);
            this.mcListenerClient.Text = "TCPListener/TCPClient";
            // 
            // mclcEcouter
            // 
            this.mclcEcouter.Name = "mclcEcouter";
            this.mclcEcouter.Size = new System.Drawing.Size(181, 26);
            this.mclcEcouter.Text = "Ecouter";
            this.mclcEcouter.Click += new System.EventHandler(this.mclcEcouter_Click);
            // 
            // mclcConnecter
            // 
            this.mclcConnecter.Name = "mclcConnecter";
            this.mclcConnecter.Size = new System.Drawing.Size(181, 26);
            this.mclcConnecter.Text = "Connecter";
            this.mclcConnecter.Click += new System.EventHandler(this.mclcConnecter_Click);
            // 
            // mcUDPListenerClient
            // 
            this.mcUDPListenerClient.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mcudpListener,
            this.mcudpClient});
            this.mcUDPListenerClient.Name = "mcUDPListenerClient";
            this.mcUDPListenerClient.Size = new System.Drawing.Size(237, 26);
            this.mcUDPListenerClient.Text = "UDPListener/UDPClient";
            // 
            // mcudpListener
            // 
            this.mcudpListener.Name = "mcudpListener";
            this.mcudpListener.Size = new System.Drawing.Size(181, 26);
            this.mcudpListener.Text = "Listerner";
            this.mcudpListener.Click += new System.EventHandler(this.mcudpListener_Click);
            // 
            // mcudpClient
            // 
            this.mcudpClient.Name = "mcudpClient";
            this.mcudpClient.Size = new System.Drawing.Size(181, 26);
            this.mcudpClient.Text = "Client";
            this.mcudpClient.Click += new System.EventHandler(this.mcudpClient_Click);
            // 
            // mUtilitaire
            // 
            this.mUtilitaire.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muVerifier});
            this.mUtilitaire.Name = "mUtilitaire";
            this.mUtilitaire.Size = new System.Drawing.Size(84, 24);
            this.mUtilitaire.Text = "Utilitaires";
            // 
            // muVerifier
            // 
            this.muVerifier.Name = "muVerifier";
            this.muVerifier.Size = new System.Drawing.Size(131, 26);
            this.muVerifier.Text = "Vérifier";
            this.muVerifier.Click += new System.EventHandler(this.muVerifier_Click);
            // 
            // mQuitter
            // 
            this.mQuitter.Name = "mQuitter";
            this.mQuitter.Size = new System.Drawing.Size(67, 24);
            this.mQuitter.Text = "Quitter";
            this.mQuitter.Click += new System.EventHandler(this.mQuitter_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(12, 40);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(58, 17);
            this.lblServer.TabIndex = 2;
            this.lblServer.Text = "Serveur";
            // 
            // tbServer
            // 
            this.tbServer.Location = new System.Drawing.Point(15, 60);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(335, 22);
            this.tbServer.TabIndex = 3;
            this.tbServer.Text = "DESKTOP-KKB42TS";
            // 
            // tbQuestions
            // 
            this.tbQuestions.Location = new System.Drawing.Point(15, 112);
            this.tbQuestions.Name = "tbQuestions";
            this.tbQuestions.Size = new System.Drawing.Size(335, 22);
            this.tbQuestions.TabIndex = 5;
            // 
            // lblQuestions
            // 
            this.lblQuestions.AutoSize = true;
            this.lblQuestions.Location = new System.Drawing.Point(12, 92);
            this.lblQuestions.Name = "lblQuestions";
            this.lblQuestions.Size = new System.Drawing.Size(65, 17);
            this.lblQuestions.TabIndex = 4;
            this.lblQuestions.Text = "Question";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(15, 140);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(335, 23);
            this.btnValider.TabIndex = 6;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // lblReponse
            // 
            this.lblReponse.AutoSize = true;
            this.lblReponse.Location = new System.Drawing.Point(12, 191);
            this.lblReponse.Name = "lblReponse";
            this.lblReponse.Size = new System.Drawing.Size(65, 17);
            this.lblReponse.TabIndex = 7;
            this.lblReponse.Text = "Question";
            // 
            // lbReponses
            // 
            this.lbReponses.FormattingEnabled = true;
            this.lbReponses.ItemHeight = 16;
            this.lbReponses.Location = new System.Drawing.Point(15, 211);
            this.lbReponses.Name = "lbReponses";
            this.lbReponses.Size = new System.Drawing.Size(335, 164);
            this.lbReponses.TabIndex = 8;
            // 
            // EcranPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 387);
            this.ControlBox = false;
            this.Controls.Add(this.lbReponses);
            this.Controls.Add(this.lblReponse);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.tbQuestions);
            this.Controls.Add(this.lblQuestions);
            this.Controls.Add(this.tbServer);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EcranPrincipal";
            this.Text = "Communication TCPIP";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mCommunication;
        private System.Windows.Forms.ToolStripMenuItem mUtilitaire;
        private System.Windows.Forms.ToolStripMenuItem mQuitter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.ToolStripMenuItem muVerifier;
        private System.Windows.Forms.ToolStripMenuItem mcListenerClient;
        private System.Windows.Forms.ToolStripMenuItem mclcEcouter;
        private System.Windows.Forms.ToolStripMenuItem mclcConnecter;
        private System.Windows.Forms.TextBox tbQuestions;
        private System.Windows.Forms.Label lblQuestions;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label lblReponse;
        private System.Windows.Forms.ListBox lbReponses;
        private System.Windows.Forms.ToolStripMenuItem mcUDPListenerClient;
        private System.Windows.Forms.ToolStripMenuItem mcudpListener;
        private System.Windows.Forms.ToolStripMenuItem mcudpClient;
    }
}

