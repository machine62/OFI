using Ogame ;

namespace OgameFarmingInterface
{
    partial class FormPrincipale
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipale));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.listViewResultats = new System.Windows.Forms.ListView();
            this.contextMenuStripMenuListView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.simulerUnCombatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lancerLaSimulationMassiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.EnvoyerEnHautToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envoyerALaFinDeLaListeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSupprimerLesRapportsSelectionnes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.AfficherLeRapportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copierLeRapportNormalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copierLeRapportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copierLeRapportsansfontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.envoyerLesRapportsAuServeurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exporterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemCommentaires = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxCommentaire = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItemValideCommentaires = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemCommentairePredefiniPasRentable = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCommentairePredefiniCoffre = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCommentairePredefiniTropPetit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCommentairePredefiniFlotteAQuai = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCommentairePredefiniPille = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.nouveauToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ouvrirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.enregistrerToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.enregistrerSousToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.imprimerToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.couperToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copierToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.collerToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tabControlPrincipal = new System.Windows.Forms.TabControl();
            this.tabPageRapports = new System.Windows.Forms.TabPage();
            this.tabPageAttaquant = new System.Windows.Forms.TabPage();
            this.buttonDescendreFlottePersonnalisee = new System.Windows.Forms.Button();
            this.buttonSupprimerFlottePersonnalisee = new System.Windows.Forms.Button();
            this.buttonMonterFlottePersonnalisee = new System.Windows.Forms.Button();
            this.buttonChargerFlottePersonnalisee = new System.Windows.Forms.Button();
            this.buttonAjouterFlottePersonnalisee = new System.Windows.Forms.Button();
            this.listViewFlottesPersonnalisées = new System.Windows.Forms.ListView();
            this.columnHeaderFP_COOR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFP_PT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFP_GT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFP_CLE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFP_CLO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFP_CR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFP_VB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFP_VC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFP_RC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFP_SE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFP_BB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFP_DS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFP_EM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFP_TR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderRatioVitesse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTP_A = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTP_B = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTP_P = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTP_C = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTP_I = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTP_H = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxEmpire = new System.Windows.Forms.GroupBox();
            this.listViewEmpire = new System.Windows.Forms.ListView();
            this.groupBoxTechnologie = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxFlotteAttaquanteTechHyperespace = new System.Windows.Forms.TextBox();
            this.bindingSourceParametresTechnologieAttaquant = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxFlotteAttaquanteTechImpulsion = new System.Windows.Forms.TextBox();
            this.textBoxFlotteAttaquanteTechCombustion = new System.Windows.Forms.TextBox();
            this.textBoxFlotteAttaquanteTechProtections = new System.Windows.Forms.TextBox();
            this.textBoxFlotteAttaquanteTechBoucliers = new System.Windows.Forms.TextBox();
            this.textBoxFlotteAttaquanteTechArmes = new System.Windows.Forms.TextBox();
            this.groupBoxFlotte = new System.Windows.Forms.GroupBox();
            this.comboBoxVitesse = new System.Windows.Forms.ComboBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.textBoxFlotteAttaquanteTraqueur = new System.Windows.Forms.TextBox();
            this.bindingSourceParametresFlotteAttaquante = new System.Windows.Forms.BindingSource(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFlotteAttaquanteCoordonnees = new System.Windows.Forms.TextBox();
            this.textBoxFlotteAttaquanteEDLM = new System.Windows.Forms.TextBox();
            this.textBoxFlotteAttaquanteDES = new System.Windows.Forms.TextBox();
            this.textBoxFlotteAttaquanteB = new System.Windows.Forms.TextBox();
            this.textBoxFlotteAttaquanteSondes = new System.Windows.Forms.TextBox();
            this.textBoxFlotteAttaquanteRC = new System.Windows.Forms.TextBox();
            this.textBoxFlotteAttaquanteVC = new System.Windows.Forms.TextBox();
            this.textBoxFlotteAttaquanteVB = new System.Windows.Forms.TextBox();
            this.textBoxFlotteAttaquanteCR = new System.Windows.Forms.TextBox();
            this.textBoxFlotteAttaquanteCL = new System.Windows.Forms.TextBox();
            this.textBoxFlotteAttaquanteCle = new System.Windows.Forms.TextBox();
            this.textBoxFlotteAttaquanteGT = new System.Windows.Forms.TextBox();
            this.textBoxFlotteAttaquantePT = new System.Windows.Forms.TextBox();
            this.tabPageUnivers = new System.Windows.Forms.TabPage();
            this.groupBoxRecherche = new System.Windows.Forms.GroupBox();
            this.buttonCopierResultatRecherche = new System.Windows.Forms.Button();
            this.listViewResultatsDeRecherche = new System.Windows.Forms.ListView();
            this.columnHeaderResultatRechercheCoordonnees = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderResultatRechercheNom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderResultatRechercheAlliance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderResultatRecherchePresenceLune = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxNomARechercher = new System.Windows.Forms.TextBox();
            this.radioButtonChercheJoueur = new System.Windows.Forms.RadioButton();
            this.radioButtonChercheAlliance = new System.Windows.Forms.RadioButton();
            this.buttonLancerLaRecherche = new System.Windows.Forms.Button();
            this.groupBoxUnivers = new System.Windows.Forms.GroupBox();
            this.listViewUnivers = new System.Windows.Forms.ListView();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tabControlUnivers = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.groupBoxVueSysteme = new System.Windows.Forms.GroupBox();
            this.listViewSysteme = new System.Windows.Forms.ListView();
            this.Position = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Lune = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rapport = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Joueur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Alliance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripSysteme = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.simulerUnCombatToolStripMenuSystemeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherLeRapportToolStripMenuSystemeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageClassement = new System.Windows.Forms.TabPage();
            this.label38 = new System.Windows.Forms.Label();
            this.tabPageParametres = new System.Windows.Forms.TabPage();
            this.groupBoxMiseAJour = new System.Windows.Forms.GroupBox();
            this.buttonVerifierPresenceMiseAJour = new System.Windows.Forms.Button();
            this.buttonLancerMiseAJour = new System.Windows.Forms.Button();
            this.checkBoxMiseAJourAutomatique = new System.Windows.Forms.CheckBox();
            this.checkBoxEnregistrerEnQuittant = new System.Windows.Forms.CheckBox();
            this.groupBoxServeur = new System.Windows.Forms.GroupBox();
            this.ButtonInfoserver = new System.Windows.Forms.Button();
            this.buttonGereLesComptesOGSpy = new System.Windows.Forms.Button();
            this.checkedListBoxSelectionGalaxies = new System.Windows.Forms.CheckedListBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.buttonEnvoyerClassements = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.buttonRecupererClassements = new System.Windows.Forms.Button();
            this.checkBoxClassementAllianceRecherches = new System.Windows.Forms.CheckBox();
            this.checkBoxClassementAllianceVaisseaux = new System.Windows.Forms.CheckBox();
            this.checkBoxClassementAlliancePoints = new System.Windows.Forms.CheckBox();
            this.checkBoxClassementJoueurRecherches = new System.Windows.Forms.CheckBox();
            this.checkBoxClassementJoueurVaisseaux = new System.Windows.Forms.CheckBox();
            this.checkBoxClassementJoueurPoints = new System.Windows.Forms.CheckBox();
            this.label28 = new System.Windows.Forms.Label();
            this.buttonEnvoyerRapports = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePickerRecuperationRapports = new System.Windows.Forms.DateTimePicker();
            this.label32 = new System.Windows.Forms.Label();
            this.buttonRecupererRapports = new System.Windows.Forms.Button();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.checkBoxGardeMDP = new System.Windows.Forms.CheckBox();
            this.buttonConnecter = new System.Windows.Forms.Button();
            this.buttonExporter = new System.Windows.Forms.Button();
            this.buttonImporter = new System.Windows.Forms.Button();
            this.labelURL = new System.Windows.Forms.Label();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.textBoxPasse = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.groupBoxParamsSimuEnMasse = new System.Windows.Forms.GroupBox();
            this.textBoxParamsSimuEnMasseNombreDeSimulations = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBoxAmis = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.buttonAjoutJoueurAmi = new System.Windows.Forms.Button();
            this.buttonAjoutAllianceAmie = new System.Windows.Forms.Button();
            this.listBoxCoordonneesAmies = new System.Windows.Forms.ListBox();
            this.listBoxJoueursAmis = new System.Windows.Forms.ListBox();
            this.buttonAjoutCoordonneesAmies = new System.Windows.Forms.Button();
            this.textBoxAjoutAmi = new System.Windows.Forms.TextBox();
            this.listBoxAlliancesAmies = new System.Windows.Forms.ListBox();
            this.groupBoxColonnesAffichees = new System.Windows.Forms.GroupBox();
            this.label37 = new System.Windows.Forms.Label();
            this.buttonReinitialiserColonneRapports = new System.Windows.Forms.Button();
            this.ColonnesAfficheesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.tabPageNavigateur = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.textBoxBarreDAdresse = new System.Windows.Forms.TextBox();
            this.buttonGO = new System.Windows.Forms.Button();
            this.buttonActualiser = new System.Windows.Forms.Button();
            this.buttonArreter = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonSuivant = new System.Windows.Forms.Button();
            this.buttonPrecedant = new System.Windows.Forms.Button();
            this.contextMenuStripTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripTrayMenuItemQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorkerTesterMiseAJour = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStripMenuListView.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tabControlPrincipal.SuspendLayout();
            this.tabPageRapports.SuspendLayout();
            this.tabPageAttaquant.SuspendLayout();
            this.groupBoxEmpire.SuspendLayout();
            this.groupBoxTechnologie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceParametresTechnologieAttaquant)).BeginInit();
            this.groupBoxFlotte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceParametresFlotteAttaquante)).BeginInit();
            this.tabPageUnivers.SuspendLayout();
            this.groupBoxRecherche.SuspendLayout();
            this.groupBoxUnivers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tabControlUnivers.SuspendLayout();
            this.groupBoxVueSysteme.SuspendLayout();
            this.contextMenuStripSysteme.SuspendLayout();
            this.tabPageClassement.SuspendLayout();
            this.tabPageParametres.SuspendLayout();
            this.groupBoxMiseAJour.SuspendLayout();
            this.groupBoxServeur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxParamsSimuEnMasse.SuspendLayout();
            this.groupBoxAmis.SuspendLayout();
            this.groupBoxColonnesAffichees.SuspendLayout();
            this.tabPageNavigateur.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStripTray.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1125, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // listViewResultats
            // 
            this.listViewResultats.AllowColumnReorder = true;
            this.listViewResultats.ContextMenuStrip = this.contextMenuStripMenuListView;
            this.listViewResultats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewResultats.FullRowSelect = true;
            this.listViewResultats.HideSelection = false;
            this.listViewResultats.Location = new System.Drawing.Point(3, 3);
            this.listViewResultats.Margin = new System.Windows.Forms.Padding(2);
            this.listViewResultats.Name = "listViewResultats";
            this.listViewResultats.Size = new System.Drawing.Size(1107, 628);
            this.listViewResultats.TabIndex = 3;
            this.listViewResultats.UseCompatibleStateImageBehavior = false;
            this.listViewResultats.View = System.Windows.Forms.View.Details;
            this.listViewResultats.VirtualMode = true;
            this.listViewResultats.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewResultats_ColumnClick);
            this.listViewResultats.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewResultats_ItemSelectionChanged);
            this.listViewResultats.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.listViewResultats_RetrieveVirtualItem);
            this.listViewResultats.VirtualItemsSelectionRangeChanged += new System.Windows.Forms.ListViewVirtualItemsSelectionRangeChangedEventHandler(this.listViewResultats_VirtualItemsSelectionRangeChanged);
            this.listViewResultats.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewResultats_KeyDown);
            this.listViewResultats.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewResultats_MouseDoubleClick);
            // 
            // contextMenuStripMenuListView
            // 
            this.contextMenuStripMenuListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simulerUnCombatToolStripMenuItem,
            this.lancerLaSimulationMassiveToolStripMenuItem,
            this.toolStripSeparator2,
            this.EnvoyerEnHautToolStripMenuItem,
            this.envoyerALaFinDeLaListeToolStripMenuItem,
            this.toolStripMenuItemSupprimerLesRapportsSelectionnes,
            this.toolStripSeparator3,
            this.AfficherLeRapportToolStripMenuItem,
            this.copierLeRapportNormalToolStripMenuItem,
            this.copierLeRapportToolStripMenuItem,
            this.copierLeRapportsansfontToolStripMenuItem,
            this.toolStripSeparator4,
            this.envoyerLesRapportsAuServeurToolStripMenuItem,
            this.exporterToolStripMenuItem,
            this.importerToolStripMenuItem,
            this.toolStripSeparator5,
            this.toolStripMenuItemCommentaires});
            this.contextMenuStripMenuListView.Name = "contextMenuStripMenuListView";
            this.contextMenuStripMenuListView.Size = new System.Drawing.Size(231, 314);
            // 
            // simulerUnCombatToolStripMenuItem
            // 
            this.simulerUnCombatToolStripMenuItem.Image = global::OgameFarmingInterface.Properties.Resources.Engrenage16;
            this.simulerUnCombatToolStripMenuItem.Name = "simulerUnCombatToolStripMenuItem";
            this.simulerUnCombatToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.simulerUnCombatToolStripMenuItem.Text = "Simuler un combat";
            this.simulerUnCombatToolStripMenuItem.Click += new System.EventHandler(this.simulerUnCombatToolStripMenuItem_Click);
            // 
            // lancerLaSimulationMassiveToolStripMenuItem
            // 
            this.lancerLaSimulationMassiveToolStripMenuItem.Image = global::OgameFarmingInterface.Properties.Resources.EngrenageMultiple16;
            this.lancerLaSimulationMassiveToolStripMenuItem.Name = "lancerLaSimulationMassiveToolStripMenuItem";
            this.lancerLaSimulationMassiveToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.lancerLaSimulationMassiveToolStripMenuItem.Text = "Lancer la simulation massive";
            this.lancerLaSimulationMassiveToolStripMenuItem.Click += new System.EventHandler(this.lancerLaSimulationMassiveToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(227, 6);
            // 
            // EnvoyerEnHautToolStripMenuItem
            // 
            this.EnvoyerEnHautToolStripMenuItem.Name = "EnvoyerEnHautToolStripMenuItem";
            this.EnvoyerEnHautToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.EnvoyerEnHautToolStripMenuItem.Text = "Envoyer au début de la liste";
            this.EnvoyerEnHautToolStripMenuItem.Click += new System.EventHandler(this.EnvoyerEnHautToolStripMenuItem_Click);
            // 
            // envoyerALaFinDeLaListeToolStripMenuItem
            // 
            this.envoyerALaFinDeLaListeToolStripMenuItem.Name = "envoyerALaFinDeLaListeToolStripMenuItem";
            this.envoyerALaFinDeLaListeToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.envoyerALaFinDeLaListeToolStripMenuItem.Text = "Envoyer à la fin de la liste";
            this.envoyerALaFinDeLaListeToolStripMenuItem.Click += new System.EventHandler(this.envoyerALaFinDeLaListeToolStripMenuItem_Click);
            // 
            // toolStripMenuItemSupprimerLesRapportsSelectionnes
            // 
            this.toolStripMenuItemSupprimerLesRapportsSelectionnes.Image = global::OgameFarmingInterface.Properties.Resources.Supprimer;
            this.toolStripMenuItemSupprimerLesRapportsSelectionnes.ImageTransparentColor = System.Drawing.Color.Black;
            this.toolStripMenuItemSupprimerLesRapportsSelectionnes.Name = "toolStripMenuItemSupprimerLesRapportsSelectionnes";
            this.toolStripMenuItemSupprimerLesRapportsSelectionnes.Size = new System.Drawing.Size(230, 22);
            this.toolStripMenuItemSupprimerLesRapportsSelectionnes.Text = "Supprimer les rapports";
            this.toolStripMenuItemSupprimerLesRapportsSelectionnes.Click += new System.EventHandler(this.toolStripMenuItemSupprimerLesRapportsSelectionnes_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(227, 6);
            // 
            // AfficherLeRapportToolStripMenuItem
            // 
            this.AfficherLeRapportToolStripMenuItem.Image = global::OgameFarmingInterface.Properties.Resources.Loupe;
            this.AfficherLeRapportToolStripMenuItem.Name = "AfficherLeRapportToolStripMenuItem";
            this.AfficherLeRapportToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.AfficherLeRapportToolStripMenuItem.Text = "Afficher le rapport";
            this.AfficherLeRapportToolStripMenuItem.Click += new System.EventHandler(this.AfficherLeRapportToolStripMenuItem_Click);
            // 
            // copierLeRapportNormalToolStripMenuItem
            // 
            this.copierLeRapportNormalToolStripMenuItem.Image = global::OgameFarmingInterface.Properties.Resources.Copier;
            this.copierLeRapportNormalToolStripMenuItem.Name = "copierLeRapportNormalToolStripMenuItem";
            this.copierLeRapportNormalToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.copierLeRapportNormalToolStripMenuItem.Text = "Copier le rapport";
            this.copierLeRapportNormalToolStripMenuItem.Click += new System.EventHandler(this.copierLeRapportNormalToolStripMenuItem_Click);
            // 
            // copierLeRapportToolStripMenuItem
            // 
            this.copierLeRapportToolStripMenuItem.Image = global::OgameFarmingInterface.Properties.Resources.CopierIE;
            this.copierLeRapportToolStripMenuItem.Name = "copierLeRapportToolStripMenuItem";
            this.copierLeRapportToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.copierLeRapportToolStripMenuItem.Text = "Copier le rapport (forum)";
            this.copierLeRapportToolStripMenuItem.Click += new System.EventHandler(this.copierLeRapportToolStripMenuItem_Click);
            // 
            // copierLeRapportsansfontToolStripMenuItem
            // 
            this.copierLeRapportsansfontToolStripMenuItem.Image = global::OgameFarmingInterface.Properties.Resources.CopierIE;
            this.copierLeRapportsansfontToolStripMenuItem.Name = "copierLeRapportsansfontToolStripMenuItem";
            this.copierLeRapportsansfontToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.copierLeRapportsansfontToolStripMenuItem.Text = "Copier le rapport (sans [font])";
            this.copierLeRapportsansfontToolStripMenuItem.Click += new System.EventHandler(this.copierLeRapportsansfontToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(227, 6);
            // 
            // envoyerLesRapportsAuServeurToolStripMenuItem
            // 
            this.envoyerLesRapportsAuServeurToolStripMenuItem.Image = global::OgameFarmingInterface.Properties.Resources.ExporterVersBDD;
            this.envoyerLesRapportsAuServeurToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.envoyerLesRapportsAuServeurToolStripMenuItem.Name = "envoyerLesRapportsAuServeurToolStripMenuItem";
            this.envoyerLesRapportsAuServeurToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.envoyerLesRapportsAuServeurToolStripMenuItem.Text = "Envoyer les rapports (OGSpy)";
            this.envoyerLesRapportsAuServeurToolStripMenuItem.Click += new System.EventHandler(this.envoyerLesRapportsAuServeurToolStripMenuItem_Click);
            // 
            // exporterToolStripMenuItem
            // 
            this.exporterToolStripMenuItem.Image = global::OgameFarmingInterface.Properties.Resources.Exporter;
            this.exporterToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.exporterToolStripMenuItem.Name = "exporterToolStripMenuItem";
            this.exporterToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.exporterToolStripMenuItem.Text = "Exporter les rapports (fichier)";
            this.exporterToolStripMenuItem.Click += new System.EventHandler(this.exporterToolStripMenuItem_Click);
            // 
            // importerToolStripMenuItem
            // 
            this.importerToolStripMenuItem.Image = global::OgameFarmingInterface.Properties.Resources.Importer;
            this.importerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.importerToolStripMenuItem.Name = "importerToolStripMenuItem";
            this.importerToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.importerToolStripMenuItem.Text = "Importer les rapports (fichier)";
            this.importerToolStripMenuItem.Click += new System.EventHandler(this.importerToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(227, 6);
            // 
            // toolStripMenuItemCommentaires
            // 
            this.toolStripMenuItemCommentaires.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxCommentaire,
            this.toolStripMenuItemValideCommentaires,
            this.toolStripSeparator6,
            this.toolStripMenuItemCommentairePredefiniPasRentable,
            this.toolStripMenuItemCommentairePredefiniCoffre,
            this.toolStripMenuItemCommentairePredefiniTropPetit,
            this.toolStripMenuItemCommentairePredefiniFlotteAQuai,
            this.toolStripMenuItemCommentairePredefiniPille});
            this.toolStripMenuItemCommentaires.Image = global::OgameFarmingInterface.Properties.Resources.Checked;
            this.toolStripMenuItemCommentaires.Name = "toolStripMenuItemCommentaires";
            this.toolStripMenuItemCommentaires.Size = new System.Drawing.Size(230, 22);
            this.toolStripMenuItemCommentaires.Text = "Commentaires";
            this.toolStripMenuItemCommentaires.DropDownOpened += new System.EventHandler(this.toolStripMenuItemCommentaires_DropDownOpened);
            // 
            // toolStripTextBoxCommentaire
            // 
            this.toolStripTextBoxCommentaire.Name = "toolStripTextBoxCommentaire";
            this.toolStripTextBoxCommentaire.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBoxCommentaire.TextChanged += new System.EventHandler(this.toolStripTextBoxCommentaire_TextChanged);
            // 
            // toolStripMenuItemValideCommentaires
            // 
            this.toolStripMenuItemValideCommentaires.Name = "toolStripMenuItemValideCommentaires";
            this.toolStripMenuItemValideCommentaires.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItemValideCommentaires.Text = "Valide";
            this.toolStripMenuItemValideCommentaires.Click += new System.EventHandler(this.toolStripMenuItemValideCommentaires_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(157, 6);
            // 
            // toolStripMenuItemCommentairePredefiniPasRentable
            // 
            this.toolStripMenuItemCommentairePredefiniPasRentable.Name = "toolStripMenuItemCommentairePredefiniPasRentable";
            this.toolStripMenuItemCommentairePredefiniPasRentable.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItemCommentairePredefiniPasRentable.Text = "Pas rentable";
            this.toolStripMenuItemCommentairePredefiniPasRentable.Click += new System.EventHandler(this.toolStripMenuItemCommentairePredefiniPasRentable_Click);
            // 
            // toolStripMenuItemCommentairePredefiniCoffre
            // 
            this.toolStripMenuItemCommentairePredefiniCoffre.Name = "toolStripMenuItemCommentairePredefiniCoffre";
            this.toolStripMenuItemCommentairePredefiniCoffre.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItemCommentairePredefiniCoffre.Text = "Coffre fort";
            this.toolStripMenuItemCommentairePredefiniCoffre.Click += new System.EventHandler(this.toolStripMenuItemCommentairePredefiniCoffre_Click);
            // 
            // toolStripMenuItemCommentairePredefiniTropPetit
            // 
            this.toolStripMenuItemCommentairePredefiniTropPetit.Name = "toolStripMenuItemCommentairePredefiniTropPetit";
            this.toolStripMenuItemCommentairePredefiniTropPetit.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItemCommentairePredefiniTropPetit.Text = "Trop petit";
            this.toolStripMenuItemCommentairePredefiniTropPetit.Click += new System.EventHandler(this.toolStripMenuItemCommentairePredefiniTropPetit_Click);
            // 
            // toolStripMenuItemCommentairePredefiniFlotteAQuai
            // 
            this.toolStripMenuItemCommentairePredefiniFlotteAQuai.Name = "toolStripMenuItemCommentairePredefiniFlotteAQuai";
            this.toolStripMenuItemCommentairePredefiniFlotteAQuai.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItemCommentairePredefiniFlotteAQuai.Text = "Flotte à quai";
            this.toolStripMenuItemCommentairePredefiniFlotteAQuai.Click += new System.EventHandler(this.toolStripMenuItemCommentairePredefiniFlotteAQuai_Click);
            // 
            // toolStripMenuItemCommentairePredefiniPille
            // 
            this.toolStripMenuItemCommentairePredefiniPille.Name = "toolStripMenuItemCommentairePredefiniPille";
            this.toolStripMenuItemCommentairePredefiniPille.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItemCommentairePredefiniPille.Text = "Pillé";
            this.toolStripMenuItemCommentairePredefiniPille.Click += new System.EventHandler(this.toolStripMenuItemCommentairePredefiniPille_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripButton,
            this.ouvrirToolStripButton,
            this.enregistrerToolStripButton,
            this.enregistrerSousToolStripButton,
            this.imprimerToolStripButton,
            this.toolStripSeparator,
            this.couperToolStripButton,
            this.copierToolStripButton,
            this.collerToolStripButton,
            this.toolStripSeparator1,
            this.ToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(222, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // nouveauToolStripButton
            // 
            this.nouveauToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nouveauToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("nouveauToolStripButton.Image")));
            this.nouveauToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nouveauToolStripButton.Name = "nouveauToolStripButton";
            this.nouveauToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.nouveauToolStripButton.Text = "&Nouveau";
            this.nouveauToolStripButton.Click += new System.EventHandler(this.nouveauToolStripButton_Click);
            // 
            // ouvrirToolStripButton
            // 
            this.ouvrirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ouvrirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ouvrirToolStripButton.Image")));
            this.ouvrirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ouvrirToolStripButton.Name = "ouvrirToolStripButton";
            this.ouvrirToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ouvrirToolStripButton.Text = "&Ouvrir";
            this.ouvrirToolStripButton.Click += new System.EventHandler(this.ouvrirToolStripButton_Click);
            // 
            // enregistrerToolStripButton
            // 
            this.enregistrerToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.enregistrerToolStripButton.Enabled = false;
            this.enregistrerToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("enregistrerToolStripButton.Image")));
            this.enregistrerToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.enregistrerToolStripButton.Name = "enregistrerToolStripButton";
            this.enregistrerToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.enregistrerToolStripButton.Text = "&Enregistrer";
            this.enregistrerToolStripButton.Click += new System.EventHandler(this.enregistrerToolStripButton_Click);
            // 
            // enregistrerSousToolStripButton
            // 
            this.enregistrerSousToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.enregistrerSousToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("enregistrerSousToolStripButton.Image")));
            this.enregistrerSousToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.enregistrerSousToolStripButton.Name = "enregistrerSousToolStripButton";
            this.enregistrerSousToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.enregistrerSousToolStripButton.Text = "&Enregistrer sous...";
            this.enregistrerSousToolStripButton.Click += new System.EventHandler(this.enregistrerSousToolStripButton_Click);
            // 
            // imprimerToolStripButton
            // 
            this.imprimerToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.imprimerToolStripButton.Enabled = false;
            this.imprimerToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("imprimerToolStripButton.Image")));
            this.imprimerToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imprimerToolStripButton.Name = "imprimerToolStripButton";
            this.imprimerToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.imprimerToolStripButton.Text = "&Imprimer";
            this.imprimerToolStripButton.Click += new System.EventHandler(this.imprimerToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // couperToolStripButton
            // 
            this.couperToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.couperToolStripButton.Enabled = false;
            this.couperToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("couperToolStripButton.Image")));
            this.couperToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.couperToolStripButton.Name = "couperToolStripButton";
            this.couperToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.couperToolStripButton.Text = "C&ouper";
            this.couperToolStripButton.Click += new System.EventHandler(this.couperToolStripButton_Click);
            // 
            // copierToolStripButton
            // 
            this.copierToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copierToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copierToolStripButton.Image")));
            this.copierToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copierToolStripButton.Name = "copierToolStripButton";
            this.copierToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copierToolStripButton.Text = "Co&pier";
            this.copierToolStripButton.Click += new System.EventHandler(this.copierToolStripButton_Click);
            // 
            // collerToolStripButton
            // 
            this.collerToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.collerToolStripButton.Enabled = false;
            this.collerToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("collerToolStripButton.Image")));
            this.collerToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.collerToolStripButton.Name = "collerToolStripButton";
            this.collerToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.collerToolStripButton.Text = "Co&ller";
            this.collerToolStripButton.Click += new System.EventHandler(this.collerToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripButton
            // 
            this.ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton.Image")));
            this.ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton.Name = "ToolStripButton";
            this.ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton.Text = "&?";
            this.ToolStripButton.Click += new System.EventHandler(this.ToolStripButton_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tabControlPrincipal);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1125, 669);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1125, 716);
            this.toolStripContainer1.TabIndex = 5;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // tabControlPrincipal
            // 
            this.tabControlPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlPrincipal.Controls.Add(this.tabPageRapports);
            this.tabControlPrincipal.Controls.Add(this.tabPageAttaquant);
            this.tabControlPrincipal.Controls.Add(this.tabPageUnivers);
            this.tabControlPrincipal.Controls.Add(this.tabPageClassement);
            this.tabControlPrincipal.Controls.Add(this.tabPageParametres);
            this.tabControlPrincipal.Controls.Add(this.tabPageNavigateur);
            this.tabControlPrincipal.Location = new System.Drawing.Point(3, 3);
            this.tabControlPrincipal.Margin = new System.Windows.Forms.Padding(3, 3, 1, 1);
            this.tabControlPrincipal.Name = "tabControlPrincipal";
            this.tabControlPrincipal.SelectedIndex = 0;
            this.tabControlPrincipal.Size = new System.Drawing.Size(1121, 660);
            this.tabControlPrincipal.TabIndex = 4;
            // 
            // tabPageRapports
            // 
            this.tabPageRapports.Controls.Add(this.listViewResultats);
            this.tabPageRapports.Location = new System.Drawing.Point(4, 22);
            this.tabPageRapports.Name = "tabPageRapports";
            this.tabPageRapports.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRapports.Size = new System.Drawing.Size(1113, 634);
            this.tabPageRapports.TabIndex = 0;
            this.tabPageRapports.Text = "Rapports d\'espionnage";
            this.tabPageRapports.UseVisualStyleBackColor = true;
            // 
            // tabPageAttaquant
            // 
            this.tabPageAttaquant.AutoScroll = true;
            this.tabPageAttaquant.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.tabPageAttaquant.Controls.Add(this.buttonDescendreFlottePersonnalisee);
            this.tabPageAttaquant.Controls.Add(this.buttonSupprimerFlottePersonnalisee);
            this.tabPageAttaquant.Controls.Add(this.buttonMonterFlottePersonnalisee);
            this.tabPageAttaquant.Controls.Add(this.buttonChargerFlottePersonnalisee);
            this.tabPageAttaquant.Controls.Add(this.buttonAjouterFlottePersonnalisee);
            this.tabPageAttaquant.Controls.Add(this.listViewFlottesPersonnalisées);
            this.tabPageAttaquant.Controls.Add(this.groupBoxEmpire);
            this.tabPageAttaquant.Controls.Add(this.groupBoxTechnologie);
            this.tabPageAttaquant.Controls.Add(this.groupBoxFlotte);
            this.tabPageAttaquant.Location = new System.Drawing.Point(4, 22);
            this.tabPageAttaquant.Name = "tabPageAttaquant";
            this.tabPageAttaquant.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAttaquant.Size = new System.Drawing.Size(1113, 634);
            this.tabPageAttaquant.TabIndex = 1;
            this.tabPageAttaquant.Text = "Paramétrage attaquant";
            this.tabPageAttaquant.UseVisualStyleBackColor = true;
            // 
            // buttonDescendreFlottePersonnalisee
            // 
            this.buttonDescendreFlottePersonnalisee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDescendreFlottePersonnalisee.Location = new System.Drawing.Point(968, 465);
            this.buttonDescendreFlottePersonnalisee.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDescendreFlottePersonnalisee.Name = "buttonDescendreFlottePersonnalisee";
            this.buttonDescendreFlottePersonnalisee.Size = new System.Drawing.Size(106, 25);
            this.buttonDescendreFlottePersonnalisee.TabIndex = 15;
            this.buttonDescendreFlottePersonnalisee.Text = "Descendre";
            this.buttonDescendreFlottePersonnalisee.UseVisualStyleBackColor = true;
            this.buttonDescendreFlottePersonnalisee.Click += new System.EventHandler(this.buttonDescendreFlottePersonnalisee_Click);
            // 
            // buttonSupprimerFlottePersonnalisee
            // 
            this.buttonSupprimerFlottePersonnalisee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSupprimerFlottePersonnalisee.Location = new System.Drawing.Point(968, 437);
            this.buttonSupprimerFlottePersonnalisee.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSupprimerFlottePersonnalisee.Name = "buttonSupprimerFlottePersonnalisee";
            this.buttonSupprimerFlottePersonnalisee.Size = new System.Drawing.Size(106, 25);
            this.buttonSupprimerFlottePersonnalisee.TabIndex = 16;
            this.buttonSupprimerFlottePersonnalisee.Text = "Supprimer";
            this.buttonSupprimerFlottePersonnalisee.UseVisualStyleBackColor = true;
            this.buttonSupprimerFlottePersonnalisee.Click += new System.EventHandler(this.buttonSupprimerFlottePersonnalisee_Click);
            // 
            // buttonMonterFlottePersonnalisee
            // 
            this.buttonMonterFlottePersonnalisee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMonterFlottePersonnalisee.Location = new System.Drawing.Point(968, 408);
            this.buttonMonterFlottePersonnalisee.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMonterFlottePersonnalisee.Name = "buttonMonterFlottePersonnalisee";
            this.buttonMonterFlottePersonnalisee.Size = new System.Drawing.Size(106, 25);
            this.buttonMonterFlottePersonnalisee.TabIndex = 15;
            this.buttonMonterFlottePersonnalisee.Text = "Monter";
            this.buttonMonterFlottePersonnalisee.UseVisualStyleBackColor = true;
            this.buttonMonterFlottePersonnalisee.Click += new System.EventHandler(this.buttonMonterFlottePersonnalisee_Click);
            // 
            // buttonChargerFlottePersonnalisee
            // 
            this.buttonChargerFlottePersonnalisee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChargerFlottePersonnalisee.Location = new System.Drawing.Point(968, 380);
            this.buttonChargerFlottePersonnalisee.Margin = new System.Windows.Forms.Padding(2);
            this.buttonChargerFlottePersonnalisee.Name = "buttonChargerFlottePersonnalisee";
            this.buttonChargerFlottePersonnalisee.Size = new System.Drawing.Size(106, 25);
            this.buttonChargerFlottePersonnalisee.TabIndex = 14;
            this.buttonChargerFlottePersonnalisee.Text = "Charger";
            this.buttonChargerFlottePersonnalisee.UseVisualStyleBackColor = true;
            this.buttonChargerFlottePersonnalisee.Click += new System.EventHandler(this.buttonChargerFlottePersonnalisee_Click);
            // 
            // buttonAjouterFlottePersonnalisee
            // 
            this.buttonAjouterFlottePersonnalisee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAjouterFlottePersonnalisee.Location = new System.Drawing.Point(968, 351);
            this.buttonAjouterFlottePersonnalisee.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAjouterFlottePersonnalisee.Name = "buttonAjouterFlottePersonnalisee";
            this.buttonAjouterFlottePersonnalisee.Size = new System.Drawing.Size(106, 25);
            this.buttonAjouterFlottePersonnalisee.TabIndex = 13;
            this.buttonAjouterFlottePersonnalisee.Text = "Ajouter";
            this.buttonAjouterFlottePersonnalisee.UseVisualStyleBackColor = true;
            this.buttonAjouterFlottePersonnalisee.Click += new System.EventHandler(this.buttonAjouterFlottePersonnalisee_Click);
            // 
            // listViewFlottesPersonnalisées
            // 
            this.listViewFlottesPersonnalisées.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewFlottesPersonnalisées.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderFP_COOR,
            this.columnHeaderFP_PT,
            this.columnHeaderFP_GT,
            this.columnHeaderFP_CLE,
            this.columnHeaderFP_CLO,
            this.columnHeaderFP_CR,
            this.columnHeaderFP_VB,
            this.columnHeaderFP_VC,
            this.columnHeaderFP_RC,
            this.columnHeaderFP_SE,
            this.columnHeaderFP_BB,
            this.columnHeaderFP_DS,
            this.columnHeaderFP_EM,
            this.columnHeaderFP_TR,
            this.columnHeaderRatioVitesse,
            this.columnHeaderTP_A,
            this.columnHeaderTP_B,
            this.columnHeaderTP_P,
            this.columnHeaderTP_C,
            this.columnHeaderTP_I,
            this.columnHeaderTP_H});
            this.listViewFlottesPersonnalisées.FullRowSelect = true;
            this.listViewFlottesPersonnalisées.HideSelection = false;
            this.listViewFlottesPersonnalisées.Location = new System.Drawing.Point(3, 351);
            this.listViewFlottesPersonnalisées.Margin = new System.Windows.Forms.Padding(2);
            this.listViewFlottesPersonnalisées.MultiSelect = false;
            this.listViewFlottesPersonnalisées.Name = "listViewFlottesPersonnalisées";
            this.listViewFlottesPersonnalisées.Size = new System.Drawing.Size(961, 276);
            this.listViewFlottesPersonnalisées.TabIndex = 12;
            this.listViewFlottesPersonnalisées.UseCompatibleStateImageBehavior = false;
            this.listViewFlottesPersonnalisées.View = System.Windows.Forms.View.Details;
            this.listViewFlottesPersonnalisées.VirtualMode = true;
            this.listViewFlottesPersonnalisées.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewFlottesPersonnalisées_ItemSelectionChanged);
            this.listViewFlottesPersonnalisées.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.listViewFlottesPersonnalisées_RetrieveVirtualItem);
            this.listViewFlottesPersonnalisées.VirtualItemsSelectionRangeChanged += new System.Windows.Forms.ListViewVirtualItemsSelectionRangeChangedEventHandler(this.listViewFlottesPersonnalisées_VirtualItemsSelectionRangeChanged);
            this.listViewFlottesPersonnalisées.DoubleClick += new System.EventHandler(this.listViewFlottesPersonnalisées_DoubleClick);
            this.listViewFlottesPersonnalisées.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewFlottesPersonnalisées_KeyDown);
            // 
            // columnHeaderFP_COOR
            // 
            this.columnHeaderFP_COOR.Text = "Coord.";
            this.columnHeaderFP_COOR.Width = 80;
            // 
            // columnHeaderFP_PT
            // 
            this.columnHeaderFP_PT.Text = "Petit Tr.";
            this.columnHeaderFP_PT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderFP_PT.Width = 90;
            // 
            // columnHeaderFP_GT
            // 
            this.columnHeaderFP_GT.Text = "Grand Tr.";
            this.columnHeaderFP_GT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderFP_GT.Width = 90;
            // 
            // columnHeaderFP_CLE
            // 
            this.columnHeaderFP_CLE.Text = "Ch. léger";
            this.columnHeaderFP_CLE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderFP_CLE.Width = 90;
            // 
            // columnHeaderFP_CLO
            // 
            this.columnHeaderFP_CLO.Text = "Ch. Lourd";
            this.columnHeaderFP_CLO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderFP_CLO.Width = 90;
            // 
            // columnHeaderFP_CR
            // 
            this.columnHeaderFP_CR.Text = "Croiseur";
            this.columnHeaderFP_CR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderFP_CR.Width = 90;
            // 
            // columnHeaderFP_VB
            // 
            this.columnHeaderFP_VB.Text = "V. Bataille";
            this.columnHeaderFP_VB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderFP_VB.Width = 90;
            // 
            // columnHeaderFP_VC
            // 
            this.columnHeaderFP_VC.Text = "V. Colon.";
            this.columnHeaderFP_VC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderFP_VC.Width = 90;
            // 
            // columnHeaderFP_RC
            // 
            this.columnHeaderFP_RC.Text = "Recycleur";
            this.columnHeaderFP_RC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderFP_RC.Width = 90;
            // 
            // columnHeaderFP_SE
            // 
            this.columnHeaderFP_SE.Text = "Sonde E.";
            this.columnHeaderFP_SE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderFP_SE.Width = 90;
            // 
            // columnHeaderFP_BB
            // 
            this.columnHeaderFP_BB.Text = "Bomb.";
            this.columnHeaderFP_BB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderFP_BB.Width = 90;
            // 
            // columnHeaderFP_DS
            // 
            this.columnHeaderFP_DS.Text = "Destr.";
            this.columnHeaderFP_DS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderFP_DS.Width = 90;
            // 
            // columnHeaderFP_EM
            // 
            this.columnHeaderFP_EM.Text = "Etoile M.";
            this.columnHeaderFP_EM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderFP_EM.Width = 90;
            // 
            // columnHeaderFP_TR
            // 
            this.columnHeaderFP_TR.Text = "Traqueur";
            this.columnHeaderFP_TR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderFP_TR.Width = 90;
            // 
            // columnHeaderRatioVitesse
            // 
            this.columnHeaderRatioVitesse.Text = "% vit.";
            // 
            // columnHeaderTP_A
            // 
            this.columnHeaderTP_A.Text = "Att.";
            this.columnHeaderTP_A.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderTP_A.Width = 50;
            // 
            // columnHeaderTP_B
            // 
            this.columnHeaderTP_B.Text = "Bou.";
            this.columnHeaderTP_B.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderTP_B.Width = 50;
            // 
            // columnHeaderTP_P
            // 
            this.columnHeaderTP_P.Text = "Prot.";
            this.columnHeaderTP_P.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderTP_P.Width = 50;
            // 
            // columnHeaderTP_C
            // 
            this.columnHeaderTP_C.Text = "Co.";
            this.columnHeaderTP_C.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderTP_C.Width = 50;
            // 
            // columnHeaderTP_I
            // 
            this.columnHeaderTP_I.Text = "Imp.";
            this.columnHeaderTP_I.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderTP_I.Width = 50;
            // 
            // columnHeaderTP_H
            // 
            this.columnHeaderTP_H.Text = "Hyp.";
            this.columnHeaderTP_H.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderTP_H.Width = 50;
            // 
            // groupBoxEmpire
            // 
            this.groupBoxEmpire.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxEmpire.Controls.Add(this.listViewEmpire);
            this.groupBoxEmpire.Location = new System.Drawing.Point(3, 6);
            this.groupBoxEmpire.Name = "groupBoxEmpire";
            this.groupBoxEmpire.Size = new System.Drawing.Size(904, 281);
            this.groupBoxEmpire.TabIndex = 11;
            this.groupBoxEmpire.TabStop = false;
            this.groupBoxEmpire.Text = "Empire : flottes";
            // 
            // listViewEmpire
            // 
            this.listViewEmpire.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewEmpire.FullRowSelect = true;
            this.listViewEmpire.HideSelection = false;
            this.listViewEmpire.Location = new System.Drawing.Point(6, 19);
            this.listViewEmpire.Name = "listViewEmpire";
            this.listViewEmpire.Size = new System.Drawing.Size(892, 256);
            this.listViewEmpire.TabIndex = 0;
            this.listViewEmpire.UseCompatibleStateImageBehavior = false;
            this.listViewEmpire.View = System.Windows.Forms.View.Details;
            this.listViewEmpire.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewEmpire_ColumnClick);
            // 
            // groupBoxTechnologie
            // 
            this.groupBoxTechnologie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTechnologie.Controls.Add(this.label20);
            this.groupBoxTechnologie.Controls.Add(this.label19);
            this.groupBoxTechnologie.Controls.Add(this.label18);
            this.groupBoxTechnologie.Controls.Add(this.label17);
            this.groupBoxTechnologie.Controls.Add(this.label16);
            this.groupBoxTechnologie.Controls.Add(this.label15);
            this.groupBoxTechnologie.Controls.Add(this.textBoxFlotteAttaquanteTechHyperespace);
            this.groupBoxTechnologie.Controls.Add(this.textBoxFlotteAttaquanteTechImpulsion);
            this.groupBoxTechnologie.Controls.Add(this.textBoxFlotteAttaquanteTechCombustion);
            this.groupBoxTechnologie.Controls.Add(this.textBoxFlotteAttaquanteTechProtections);
            this.groupBoxTechnologie.Controls.Add(this.textBoxFlotteAttaquanteTechBoucliers);
            this.groupBoxTechnologie.Controls.Add(this.textBoxFlotteAttaquanteTechArmes);
            this.groupBoxTechnologie.Location = new System.Drawing.Point(3, 294);
            this.groupBoxTechnologie.Name = "groupBoxTechnologie";
            this.groupBoxTechnologie.Size = new System.Drawing.Size(904, 52);
            this.groupBoxTechnologie.TabIndex = 10;
            this.groupBoxTechnologie.TabStop = false;
            this.groupBoxTechnologie.Text = "Flotte attaquante : Technologies";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(647, 26);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(70, 13);
            this.label20.TabIndex = 20;
            this.label20.Text = "Hyperespace";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(533, 26);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(51, 13);
            this.label19.TabIndex = 19;
            this.label19.Text = "Impulsion";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(390, 26);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 13);
            this.label18.TabIndex = 18;
            this.label18.Text = "Combustion";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(262, 26);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 13);
            this.label17.TabIndex = 17;
            this.label17.Text = "Protections";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(141, 26);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "Boucliers";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 26);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Armes";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxFlotteAttaquanteTechHyperespace
            // 
            this.textBoxFlotteAttaquanteTechHyperespace.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceParametresTechnologieAttaquant, "PropulsionHyperespace", true));
            this.textBoxFlotteAttaquanteTechHyperespace.Location = new System.Drawing.Point(719, 24);
            this.textBoxFlotteAttaquanteTechHyperespace.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textBoxFlotteAttaquanteTechHyperespace.Name = "textBoxFlotteAttaquanteTechHyperespace";
            this.textBoxFlotteAttaquanteTechHyperespace.Size = new System.Drawing.Size(50, 20);
            this.textBoxFlotteAttaquanteTechHyperespace.TabIndex = 6;
            this.textBoxFlotteAttaquanteTechHyperespace.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // bindingSourceParametresTechnologieAttaquant
            // 
            this.bindingSourceParametresTechnologieAttaquant.DataSource = typeof(Ogame.Technologie);
            // 
            // textBoxFlotteAttaquanteTechImpulsion
            // 
            this.textBoxFlotteAttaquanteTechImpulsion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceParametresTechnologieAttaquant, "ReacteurAImpulsion", true));
            this.textBoxFlotteAttaquanteTechImpulsion.Location = new System.Drawing.Point(588, 24);
            this.textBoxFlotteAttaquanteTechImpulsion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textBoxFlotteAttaquanteTechImpulsion.Name = "textBoxFlotteAttaquanteTechImpulsion";
            this.textBoxFlotteAttaquanteTechImpulsion.Size = new System.Drawing.Size(50, 20);
            this.textBoxFlotteAttaquanteTechImpulsion.TabIndex = 5;
            this.textBoxFlotteAttaquanteTechImpulsion.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // textBoxFlotteAttaquanteTechCombustion
            // 
            this.textBoxFlotteAttaquanteTechCombustion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceParametresTechnologieAttaquant, "ReacteurACombustion", true));
            this.textBoxFlotteAttaquanteTechCombustion.Location = new System.Drawing.Point(457, 24);
            this.textBoxFlotteAttaquanteTechCombustion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textBoxFlotteAttaquanteTechCombustion.Name = "textBoxFlotteAttaquanteTechCombustion";
            this.textBoxFlotteAttaquanteTechCombustion.Size = new System.Drawing.Size(50, 20);
            this.textBoxFlotteAttaquanteTechCombustion.TabIndex = 4;
            this.textBoxFlotteAttaquanteTechCombustion.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // textBoxFlotteAttaquanteTechProtections
            // 
            this.textBoxFlotteAttaquanteTechProtections.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceParametresTechnologieAttaquant, "ProtectionDesVaisseauxSpatiaux", true));
            this.textBoxFlotteAttaquanteTechProtections.Location = new System.Drawing.Point(325, 24);
            this.textBoxFlotteAttaquanteTechProtections.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textBoxFlotteAttaquanteTechProtections.Name = "textBoxFlotteAttaquanteTechProtections";
            this.textBoxFlotteAttaquanteTechProtections.Size = new System.Drawing.Size(50, 20);
            this.textBoxFlotteAttaquanteTechProtections.TabIndex = 3;
            this.textBoxFlotteAttaquanteTechProtections.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // textBoxFlotteAttaquanteTechBoucliers
            // 
            this.textBoxFlotteAttaquanteTechBoucliers.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceParametresTechnologieAttaquant, "Bouclier", true));
            this.textBoxFlotteAttaquanteTechBoucliers.Location = new System.Drawing.Point(194, 24);
            this.textBoxFlotteAttaquanteTechBoucliers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textBoxFlotteAttaquanteTechBoucliers.Name = "textBoxFlotteAttaquanteTechBoucliers";
            this.textBoxFlotteAttaquanteTechBoucliers.Size = new System.Drawing.Size(50, 20);
            this.textBoxFlotteAttaquanteTechBoucliers.TabIndex = 2;
            this.textBoxFlotteAttaquanteTechBoucliers.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // textBoxFlotteAttaquanteTechArmes
            // 
            this.textBoxFlotteAttaquanteTechArmes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceParametresTechnologieAttaquant, "Armes", true));
            this.textBoxFlotteAttaquanteTechArmes.Location = new System.Drawing.Point(63, 24);
            this.textBoxFlotteAttaquanteTechArmes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textBoxFlotteAttaquanteTechArmes.Name = "textBoxFlotteAttaquanteTechArmes";
            this.textBoxFlotteAttaquanteTechArmes.Size = new System.Drawing.Size(50, 20);
            this.textBoxFlotteAttaquanteTechArmes.TabIndex = 1;
            this.textBoxFlotteAttaquanteTechArmes.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // groupBoxFlotte
            // 
            this.groupBoxFlotte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFlotte.Controls.Add(this.comboBoxVitesse);
            this.groupBoxFlotte.Controls.Add(this.label33);
            this.groupBoxFlotte.Controls.Add(this.label34);
            this.groupBoxFlotte.Controls.Add(this.textBoxFlotteAttaquanteTraqueur);
            this.groupBoxFlotte.Controls.Add(this.label14);
            this.groupBoxFlotte.Controls.Add(this.label13);
            this.groupBoxFlotte.Controls.Add(this.label11);
            this.groupBoxFlotte.Controls.Add(this.label10);
            this.groupBoxFlotte.Controls.Add(this.label9);
            this.groupBoxFlotte.Controls.Add(this.label8);
            this.groupBoxFlotte.Controls.Add(this.label7);
            this.groupBoxFlotte.Controls.Add(this.label6);
            this.groupBoxFlotte.Controls.Add(this.label5);
            this.groupBoxFlotte.Controls.Add(this.label4);
            this.groupBoxFlotte.Controls.Add(this.label3);
            this.groupBoxFlotte.Controls.Add(this.label2);
            this.groupBoxFlotte.Controls.Add(this.label1);
            this.groupBoxFlotte.Controls.Add(this.textBoxFlotteAttaquanteCoordonnees);
            this.groupBoxFlotte.Controls.Add(this.textBoxFlotteAttaquanteEDLM);
            this.groupBoxFlotte.Controls.Add(this.textBoxFlotteAttaquanteDES);
            this.groupBoxFlotte.Controls.Add(this.textBoxFlotteAttaquanteB);
            this.groupBoxFlotte.Controls.Add(this.textBoxFlotteAttaquanteSondes);
            this.groupBoxFlotte.Controls.Add(this.textBoxFlotteAttaquanteRC);
            this.groupBoxFlotte.Controls.Add(this.textBoxFlotteAttaquanteVC);
            this.groupBoxFlotte.Controls.Add(this.textBoxFlotteAttaquanteVB);
            this.groupBoxFlotte.Controls.Add(this.textBoxFlotteAttaquanteCR);
            this.groupBoxFlotte.Controls.Add(this.textBoxFlotteAttaquanteCL);
            this.groupBoxFlotte.Controls.Add(this.textBoxFlotteAttaquanteCle);
            this.groupBoxFlotte.Controls.Add(this.textBoxFlotteAttaquanteGT);
            this.groupBoxFlotte.Controls.Add(this.textBoxFlotteAttaquantePT);
            this.groupBoxFlotte.Location = new System.Drawing.Point(913, 6);
            this.groupBoxFlotte.Name = "groupBoxFlotte";
            this.groupBoxFlotte.Size = new System.Drawing.Size(193, 340);
            this.groupBoxFlotte.TabIndex = 9;
            this.groupBoxFlotte.TabStop = false;
            this.groupBoxFlotte.Text = "Flotte attaquante";
            // 
            // comboBoxVitesse
            // 
            this.comboBoxVitesse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVitesse.FormattingEnabled = true;
            this.comboBoxVitesse.ItemHeight = 13;
            this.comboBoxVitesse.Items.AddRange(new object[] {
            "100%",
            "90%",
            "80%",
            "70%",
            "60%",
            "50%",
            "40%",
            "30%",
            "20%",
            "10%"});
            this.comboBoxVitesse.Location = new System.Drawing.Point(115, 13);
            this.comboBoxVitesse.MaxDropDownItems = 10;
            this.comboBoxVitesse.Name = "comboBoxVitesse";
            this.comboBoxVitesse.Size = new System.Drawing.Size(68, 21);
            this.comboBoxVitesse.TabIndex = 18;
            this.comboBoxVitesse.TextChanged += new System.EventHandler(this.comboBoxVitesse_TextChanged);
            // 
            // label33
            // 
            this.label33.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(79, 314);
            this.label33.Margin = new System.Windows.Forms.Padding(2);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(50, 13);
            this.label33.TabIndex = 29;
            this.label33.Text = "Traqueur";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(67, 16);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(41, 13);
            this.label34.TabIndex = 17;
            this.label34.Text = "Vitesse";
            // 
            // textBoxFlotteAttaquanteTraqueur
            // 
            this.textBoxFlotteAttaquanteTraqueur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFlotteAttaquanteTraqueur.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceParametresFlotteAttaquante, "Battlecruiser", true));
            this.textBoxFlotteAttaquanteTraqueur.Location = new System.Drawing.Point(133, 312);
            this.textBoxFlotteAttaquanteTraqueur.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFlotteAttaquanteTraqueur.Name = "textBoxFlotteAttaquanteTraqueur";
            this.textBoxFlotteAttaquanteTraqueur.Size = new System.Drawing.Size(50, 20);
            this.textBoxFlotteAttaquanteTraqueur.TabIndex = 28;
            // 
            // bindingSourceParametresFlotteAttaquante
            // 
            this.bindingSourceParametresFlotteAttaquante.DataSource = typeof(Ogame.Flotte);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(47, 292);
            this.label14.Margin = new System.Windows.Forms.Padding(2);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Etoile de la Mort";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(67, 272);
            this.label13.Margin = new System.Windows.Forms.Padding(2);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Destructeur";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(67, 252);
            this.label11.Margin = new System.Windows.Forms.Padding(2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Bombardier";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 230);
            this.label10.Margin = new System.Windows.Forms.Padding(2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Sonde d\'espionnage";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(75, 209);
            this.label9.Margin = new System.Windows.Forms.Padding(2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Recycleur";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 189);
            this.label8.Margin = new System.Windows.Forms.Padding(2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Vaisseau de colonisation";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 168);
            this.label7.Margin = new System.Windows.Forms.Padding(2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Vaisseau de bataille";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 147);
            this.label6.Margin = new System.Windows.Forms.Padding(2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Croiseur";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Chasseur lourd";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Chasseur léger";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Grand transporteur";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Petit transporteur";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Coordonnées";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxFlotteAttaquanteCoordonnees
            // 
            this.textBoxFlotteAttaquanteCoordonnees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFlotteAttaquanteCoordonnees.Location = new System.Drawing.Point(133, 39);
            this.textBoxFlotteAttaquanteCoordonnees.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFlotteAttaquanteCoordonnees.Name = "textBoxFlotteAttaquanteCoordonnees";
            this.textBoxFlotteAttaquanteCoordonnees.Size = new System.Drawing.Size(50, 20);
            this.textBoxFlotteAttaquanteCoordonnees.TabIndex = 13;
            // 
            // textBoxFlotteAttaquanteEDLM
            // 
            this.textBoxFlotteAttaquanteEDLM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFlotteAttaquanteEDLM.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceParametresFlotteAttaquante, "EtoilesDeLaMort", true));
            this.textBoxFlotteAttaquanteEDLM.Location = new System.Drawing.Point(133, 291);
            this.textBoxFlotteAttaquanteEDLM.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFlotteAttaquanteEDLM.Name = "textBoxFlotteAttaquanteEDLM";
            this.textBoxFlotteAttaquanteEDLM.Size = new System.Drawing.Size(50, 20);
            this.textBoxFlotteAttaquanteEDLM.TabIndex = 12;
            this.textBoxFlotteAttaquanteEDLM.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // textBoxFlotteAttaquanteDES
            // 
            this.textBoxFlotteAttaquanteDES.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFlotteAttaquanteDES.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceParametresFlotteAttaquante, "Destructeurs", true));
            this.textBoxFlotteAttaquanteDES.Location = new System.Drawing.Point(133, 270);
            this.textBoxFlotteAttaquanteDES.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFlotteAttaquanteDES.Name = "textBoxFlotteAttaquanteDES";
            this.textBoxFlotteAttaquanteDES.Size = new System.Drawing.Size(50, 20);
            this.textBoxFlotteAttaquanteDES.TabIndex = 11;
            this.textBoxFlotteAttaquanteDES.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // textBoxFlotteAttaquanteB
            // 
            this.textBoxFlotteAttaquanteB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFlotteAttaquanteB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceParametresFlotteAttaquante, "Bombardiers", true));
            this.textBoxFlotteAttaquanteB.Location = new System.Drawing.Point(133, 249);
            this.textBoxFlotteAttaquanteB.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFlotteAttaquanteB.Name = "textBoxFlotteAttaquanteB";
            this.textBoxFlotteAttaquanteB.Size = new System.Drawing.Size(50, 20);
            this.textBoxFlotteAttaquanteB.TabIndex = 9;
            this.textBoxFlotteAttaquanteB.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // textBoxFlotteAttaquanteSondes
            // 
            this.textBoxFlotteAttaquanteSondes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFlotteAttaquanteSondes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceParametresFlotteAttaquante, "SondesDEspionnage", true));
            this.textBoxFlotteAttaquanteSondes.Location = new System.Drawing.Point(133, 228);
            this.textBoxFlotteAttaquanteSondes.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFlotteAttaquanteSondes.Name = "textBoxFlotteAttaquanteSondes";
            this.textBoxFlotteAttaquanteSondes.Size = new System.Drawing.Size(50, 20);
            this.textBoxFlotteAttaquanteSondes.TabIndex = 8;
            this.textBoxFlotteAttaquanteSondes.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // textBoxFlotteAttaquanteRC
            // 
            this.textBoxFlotteAttaquanteRC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFlotteAttaquanteRC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceParametresFlotteAttaquante, "Recycleurs", true));
            this.textBoxFlotteAttaquanteRC.Location = new System.Drawing.Point(133, 207);
            this.textBoxFlotteAttaquanteRC.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFlotteAttaquanteRC.Name = "textBoxFlotteAttaquanteRC";
            this.textBoxFlotteAttaquanteRC.Size = new System.Drawing.Size(50, 20);
            this.textBoxFlotteAttaquanteRC.TabIndex = 7;
            this.textBoxFlotteAttaquanteRC.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // textBoxFlotteAttaquanteVC
            // 
            this.textBoxFlotteAttaquanteVC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFlotteAttaquanteVC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceParametresFlotteAttaquante, "VaisseauxDeColonisation", true));
            this.textBoxFlotteAttaquanteVC.Location = new System.Drawing.Point(133, 187);
            this.textBoxFlotteAttaquanteVC.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFlotteAttaquanteVC.Name = "textBoxFlotteAttaquanteVC";
            this.textBoxFlotteAttaquanteVC.Size = new System.Drawing.Size(50, 20);
            this.textBoxFlotteAttaquanteVC.TabIndex = 6;
            this.textBoxFlotteAttaquanteVC.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // textBoxFlotteAttaquanteVB
            // 
            this.textBoxFlotteAttaquanteVB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFlotteAttaquanteVB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceParametresFlotteAttaquante, "VaisseauxDeBataille", true));
            this.textBoxFlotteAttaquanteVB.Location = new System.Drawing.Point(133, 166);
            this.textBoxFlotteAttaquanteVB.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFlotteAttaquanteVB.Name = "textBoxFlotteAttaquanteVB";
            this.textBoxFlotteAttaquanteVB.Size = new System.Drawing.Size(50, 20);
            this.textBoxFlotteAttaquanteVB.TabIndex = 5;
            this.textBoxFlotteAttaquanteVB.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // textBoxFlotteAttaquanteCR
            // 
            this.textBoxFlotteAttaquanteCR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFlotteAttaquanteCR.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceParametresFlotteAttaquante, "Croiseurs", true));
            this.textBoxFlotteAttaquanteCR.Location = new System.Drawing.Point(133, 145);
            this.textBoxFlotteAttaquanteCR.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFlotteAttaquanteCR.Name = "textBoxFlotteAttaquanteCR";
            this.textBoxFlotteAttaquanteCR.Size = new System.Drawing.Size(50, 20);
            this.textBoxFlotteAttaquanteCR.TabIndex = 4;
            this.textBoxFlotteAttaquanteCR.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // textBoxFlotteAttaquanteCL
            // 
            this.textBoxFlotteAttaquanteCL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFlotteAttaquanteCL.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceParametresFlotteAttaquante, "ChasseursLourds", true));
            this.textBoxFlotteAttaquanteCL.Location = new System.Drawing.Point(133, 124);
            this.textBoxFlotteAttaquanteCL.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFlotteAttaquanteCL.Name = "textBoxFlotteAttaquanteCL";
            this.textBoxFlotteAttaquanteCL.Size = new System.Drawing.Size(50, 20);
            this.textBoxFlotteAttaquanteCL.TabIndex = 3;
            this.textBoxFlotteAttaquanteCL.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // textBoxFlotteAttaquanteCle
            // 
            this.textBoxFlotteAttaquanteCle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFlotteAttaquanteCle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceParametresFlotteAttaquante, "ChasseursLegers", true));
            this.textBoxFlotteAttaquanteCle.Location = new System.Drawing.Point(133, 103);
            this.textBoxFlotteAttaquanteCle.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFlotteAttaquanteCle.Name = "textBoxFlotteAttaquanteCle";
            this.textBoxFlotteAttaquanteCle.Size = new System.Drawing.Size(50, 20);
            this.textBoxFlotteAttaquanteCle.TabIndex = 2;
            this.textBoxFlotteAttaquanteCle.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // textBoxFlotteAttaquanteGT
            // 
            this.textBoxFlotteAttaquanteGT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFlotteAttaquanteGT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceParametresFlotteAttaquante, "GrandTransporteurs", true));
            this.textBoxFlotteAttaquanteGT.Location = new System.Drawing.Point(133, 83);
            this.textBoxFlotteAttaquanteGT.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFlotteAttaquanteGT.Name = "textBoxFlotteAttaquanteGT";
            this.textBoxFlotteAttaquanteGT.Size = new System.Drawing.Size(50, 20);
            this.textBoxFlotteAttaquanteGT.TabIndex = 1;
            this.textBoxFlotteAttaquanteGT.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // textBoxFlotteAttaquantePT
            // 
            this.textBoxFlotteAttaquantePT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFlotteAttaquantePT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceParametresFlotteAttaquante, "PetitsTransporteurs", true));
            this.textBoxFlotteAttaquantePT.Location = new System.Drawing.Point(133, 62);
            this.textBoxFlotteAttaquantePT.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFlotteAttaquantePT.Name = "textBoxFlotteAttaquantePT";
            this.textBoxFlotteAttaquantePT.Size = new System.Drawing.Size(50, 20);
            this.textBoxFlotteAttaquantePT.TabIndex = 0;
            this.textBoxFlotteAttaquantePT.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // tabPageUnivers
            // 
            this.tabPageUnivers.Controls.Add(this.groupBoxRecherche);
            this.tabPageUnivers.Controls.Add(this.groupBoxUnivers);
            this.tabPageUnivers.Controls.Add(this.groupBoxVueSysteme);
            this.tabPageUnivers.Location = new System.Drawing.Point(4, 22);
            this.tabPageUnivers.Name = "tabPageUnivers";
            this.tabPageUnivers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUnivers.Size = new System.Drawing.Size(1113, 634);
            this.tabPageUnivers.TabIndex = 3;
            this.tabPageUnivers.Text = "Univers";
            this.tabPageUnivers.UseVisualStyleBackColor = true;
            // 
            // groupBoxRecherche
            // 
            this.groupBoxRecherche.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxRecherche.Controls.Add(this.buttonCopierResultatRecherche);
            this.groupBoxRecherche.Controls.Add(this.listViewResultatsDeRecherche);
            this.groupBoxRecherche.Controls.Add(this.textBoxNomARechercher);
            this.groupBoxRecherche.Controls.Add(this.radioButtonChercheJoueur);
            this.groupBoxRecherche.Controls.Add(this.radioButtonChercheAlliance);
            this.groupBoxRecherche.Controls.Add(this.buttonLancerLaRecherche);
            this.groupBoxRecherche.Location = new System.Drawing.Point(10, 271);
            this.groupBoxRecherche.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxRecherche.Name = "groupBoxRecherche";
            this.groupBoxRecherche.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxRecherche.Size = new System.Drawing.Size(429, 355);
            this.groupBoxRecherche.TabIndex = 4;
            this.groupBoxRecherche.TabStop = false;
            this.groupBoxRecherche.Text = "Recherches";
            // 
            // buttonCopierResultatRecherche
            // 
            this.buttonCopierResultatRecherche.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCopierResultatRecherche.Enabled = false;
            this.buttonCopierResultatRecherche.Location = new System.Drawing.Point(330, 322);
            this.buttonCopierResultatRecherche.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCopierResultatRecherche.Name = "buttonCopierResultatRecherche";
            this.buttonCopierResultatRecherche.Size = new System.Drawing.Size(86, 22);
            this.buttonCopierResultatRecherche.TabIndex = 5;
            this.buttonCopierResultatRecherche.Text = "Copier";
            this.buttonCopierResultatRecherche.UseVisualStyleBackColor = true;
            this.buttonCopierResultatRecherche.Click += new System.EventHandler(this.buttonCopierResultatRecherche_Click);
            // 
            // listViewResultatsDeRecherche
            // 
            this.listViewResultatsDeRecherche.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewResultatsDeRecherche.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderResultatRechercheCoordonnees,
            this.columnHeaderResultatRechercheNom,
            this.columnHeaderResultatRechercheAlliance,
            this.columnHeaderResultatRecherchePresenceLune});
            this.listViewResultatsDeRecherche.Location = new System.Drawing.Point(11, 53);
            this.listViewResultatsDeRecherche.Margin = new System.Windows.Forms.Padding(2);
            this.listViewResultatsDeRecherche.Name = "listViewResultatsDeRecherche";
            this.listViewResultatsDeRecherche.Size = new System.Drawing.Size(407, 266);
            this.listViewResultatsDeRecherche.TabIndex = 4;
            this.listViewResultatsDeRecherche.UseCompatibleStateImageBehavior = false;
            this.listViewResultatsDeRecherche.View = System.Windows.Forms.View.Details;
            this.listViewResultatsDeRecherche.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewResultatsDeRecherche_ColumnClick);
            this.listViewResultatsDeRecherche.SelectedIndexChanged += new System.EventHandler(this.listViewResultatsDeRecherche_SelectedIndexChanged);
            this.listViewResultatsDeRecherche.DoubleClick += new System.EventHandler(this.listViewResultatsDeRecherche_DoubleClick);
            // 
            // columnHeaderResultatRechercheCoordonnees
            // 
            this.columnHeaderResultatRechercheCoordonnees.Text = "Coordonnées";
            this.columnHeaderResultatRechercheCoordonnees.Width = 112;
            // 
            // columnHeaderResultatRechercheNom
            // 
            this.columnHeaderResultatRechercheNom.Text = "Nom";
            this.columnHeaderResultatRechercheNom.Width = 113;
            // 
            // columnHeaderResultatRechercheAlliance
            // 
            this.columnHeaderResultatRechercheAlliance.Text = "Alliance";
            this.columnHeaderResultatRechercheAlliance.Width = 95;
            // 
            // columnHeaderResultatRecherchePresenceLune
            // 
            this.columnHeaderResultatRecherchePresenceLune.Text = "Lune";
            // 
            // textBoxNomARechercher
            // 
            this.textBoxNomARechercher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNomARechercher.Location = new System.Drawing.Point(11, 21);
            this.textBoxNomARechercher.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNomARechercher.Name = "textBoxNomARechercher";
            this.textBoxNomARechercher.Size = new System.Drawing.Size(192, 20);
            this.textBoxNomARechercher.TabIndex = 3;
            this.textBoxNomARechercher.TextChanged += new System.EventHandler(this.textBoxNomARechercher_TextChanged);
            this.textBoxNomARechercher.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNomARechercher_KeyDown);
            // 
            // radioButtonChercheJoueur
            // 
            this.radioButtonChercheJoueur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonChercheJoueur.AutoSize = true;
            this.radioButtonChercheJoueur.Location = new System.Drawing.Point(268, 22);
            this.radioButtonChercheJoueur.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonChercheJoueur.Name = "radioButtonChercheJoueur";
            this.radioButtonChercheJoueur.Size = new System.Drawing.Size(57, 17);
            this.radioButtonChercheJoueur.TabIndex = 2;
            this.radioButtonChercheJoueur.Text = "Joueur";
            this.radioButtonChercheJoueur.UseVisualStyleBackColor = true;
            this.radioButtonChercheJoueur.CheckedChanged += new System.EventHandler(this.radioButtonChercheJoueur_CheckedChanged);
            // 
            // radioButtonChercheAlliance
            // 
            this.radioButtonChercheAlliance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonChercheAlliance.AutoSize = true;
            this.radioButtonChercheAlliance.Checked = true;
            this.radioButtonChercheAlliance.Location = new System.Drawing.Point(207, 22);
            this.radioButtonChercheAlliance.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonChercheAlliance.Name = "radioButtonChercheAlliance";
            this.radioButtonChercheAlliance.Size = new System.Drawing.Size(62, 17);
            this.radioButtonChercheAlliance.TabIndex = 1;
            this.radioButtonChercheAlliance.TabStop = true;
            this.radioButtonChercheAlliance.Text = "Alliance";
            this.radioButtonChercheAlliance.UseVisualStyleBackColor = true;
            this.radioButtonChercheAlliance.CheckedChanged += new System.EventHandler(this.radioButtonChercheAlliance_CheckedChanged);
            // 
            // buttonLancerLaRecherche
            // 
            this.buttonLancerLaRecherche.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLancerLaRecherche.Location = new System.Drawing.Point(330, 19);
            this.buttonLancerLaRecherche.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLancerLaRecherche.Name = "buttonLancerLaRecherche";
            this.buttonLancerLaRecherche.Size = new System.Drawing.Size(86, 22);
            this.buttonLancerLaRecherche.TabIndex = 0;
            this.buttonLancerLaRecherche.Text = "Cherche";
            this.buttonLancerLaRecherche.UseVisualStyleBackColor = true;
            this.buttonLancerLaRecherche.Click += new System.EventHandler(this.buttonLancerLaRecherche_Click);
            // 
            // groupBoxUnivers
            // 
            this.groupBoxUnivers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxUnivers.Controls.Add(this.listViewUnivers);
            this.groupBoxUnivers.Controls.Add(this.pictureBox4);
            this.groupBoxUnivers.Controls.Add(this.tabControlUnivers);
            this.groupBoxUnivers.Location = new System.Drawing.Point(451, 6);
            this.groupBoxUnivers.Name = "groupBoxUnivers";
            this.groupBoxUnivers.Size = new System.Drawing.Size(652, 621);
            this.groupBoxUnivers.TabIndex = 3;
            this.groupBoxUnivers.TabStop = false;
            this.groupBoxUnivers.Text = "Univers";
            // 
            // listViewUnivers
            // 
            this.listViewUnivers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewUnivers.FullRowSelect = true;
            this.listViewUnivers.Location = new System.Drawing.Point(11, 39);
            this.listViewUnivers.MultiSelect = false;
            this.listViewUnivers.Name = "listViewUnivers";
            this.listViewUnivers.Size = new System.Drawing.Size(629, 571);
            this.listViewUnivers.TabIndex = 2;
            this.listViewUnivers.UseCompatibleStateImageBehavior = false;
            this.listViewUnivers.View = System.Windows.Forms.View.List;
            this.listViewUnivers.VirtualListSize = 499;
            this.listViewUnivers.VirtualMode = true;
            this.listViewUnivers.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.listViewUnivers_RetrieveVirtualItem);
            this.listViewUnivers.SelectedIndexChanged += new System.EventHandler(this.listViewUnivers_SelectedIndexChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::OgameFarmingInterface.Properties.Resources.Galaxie32;
            this.pictureBox4.Location = new System.Drawing.Point(11, 18);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(19, 18);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // tabControlUnivers
            // 
            this.tabControlUnivers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlUnivers.Controls.Add(this.tabPage1);
            this.tabControlUnivers.Controls.Add(this.tabPage2);
            this.tabControlUnivers.Controls.Add(this.tabPage3);
            this.tabControlUnivers.Controls.Add(this.tabPage4);
            this.tabControlUnivers.Controls.Add(this.tabPage5);
            this.tabControlUnivers.Controls.Add(this.tabPage6);
            this.tabControlUnivers.Controls.Add(this.tabPage7);
            this.tabControlUnivers.Controls.Add(this.tabPage8);
            this.tabControlUnivers.Controls.Add(this.tabPage9);
            this.tabControlUnivers.Location = new System.Drawing.Point(34, 21);
            this.tabControlUnivers.Name = "tabControlUnivers";
            this.tabControlUnivers.SelectedIndex = 0;
            this.tabControlUnivers.Size = new System.Drawing.Size(606, 18);
            this.tabControlUnivers.TabIndex = 0;
            this.tabControlUnivers.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControlUnivers_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(598, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Galaxie 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(598, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Galaxie 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(598, 0);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Galaxie 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(598, 0);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Galaxie 4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(598, 0);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Galaxie 5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(598, 0);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Galaxie 6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(598, 0);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Galaxie 7";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(598, 0);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Galaxie 8";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabPage9
            // 
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(598, 0);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "Galaxie 9";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // groupBoxVueSysteme
            // 
            this.groupBoxVueSysteme.Controls.Add(this.listViewSysteme);
            this.groupBoxVueSysteme.Location = new System.Drawing.Point(10, 6);
            this.groupBoxVueSysteme.Name = "groupBoxVueSysteme";
            this.groupBoxVueSysteme.Size = new System.Drawing.Size(429, 260);
            this.groupBoxVueSysteme.TabIndex = 1;
            this.groupBoxVueSysteme.TabStop = false;
            this.groupBoxVueSysteme.Text = "Système";
            // 
            // listViewSysteme
            // 
            this.listViewSysteme.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewSysteme.BackColor = System.Drawing.SystemColors.Window;
            this.listViewSysteme.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Position,
            this.Lune,
            this.Rapport,
            this.Date,
            this.Nom,
            this.Joueur,
            this.Alliance});
            this.listViewSysteme.ContextMenuStrip = this.contextMenuStripSysteme;
            this.listViewSysteme.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listViewSysteme.FullRowSelect = true;
            this.listViewSysteme.Location = new System.Drawing.Point(11, 19);
            this.listViewSysteme.Name = "listViewSysteme";
            this.listViewSysteme.Size = new System.Drawing.Size(407, 229);
            this.listViewSysteme.TabIndex = 0;
            this.listViewSysteme.UseCompatibleStateImageBehavior = false;
            this.listViewSysteme.View = System.Windows.Forms.View.Details;
            this.listViewSysteme.VirtualListSize = 15;
            this.listViewSysteme.VirtualMode = true;
            this.listViewSysteme.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.listViewSysteme_RetrieveVirtualItem);
            this.listViewSysteme.SelectedIndexChanged += new System.EventHandler(this.listViewSysteme_SelectedIndexChanged);
            this.listViewSysteme.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewSysteme_MouseDoubleClick);
            // 
            // Position
            // 
            this.Position.Text = "Position";
            this.Position.Width = 23;
            // 
            // Lune
            // 
            this.Lune.Text = "L";
            this.Lune.Width = 18;
            // 
            // Rapport
            // 
            this.Rapport.Text = "R";
            this.Rapport.Width = 36;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 64;
            // 
            // Nom
            // 
            this.Nom.Text = "Nom";
            this.Nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nom.Width = 105;
            // 
            // Joueur
            // 
            this.Joueur.Text = "Joueur";
            this.Joueur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Joueur.Width = 87;
            // 
            // Alliance
            // 
            this.Alliance.Text = "Alliance";
            this.Alliance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Alliance.Width = 69;
            // 
            // contextMenuStripSysteme
            // 
            this.contextMenuStripSysteme.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simulerUnCombatToolStripMenuSystemeItem,
            this.afficherLeRapportToolStripMenuSystemeItem});
            this.contextMenuStripSysteme.Name = "contextMenuStripSysteme";
            this.contextMenuStripSysteme.Size = new System.Drawing.Size(176, 48);
            // 
            // simulerUnCombatToolStripMenuSystemeItem
            // 
            this.simulerUnCombatToolStripMenuSystemeItem.Image = global::OgameFarmingInterface.Properties.Resources.Engrenage16;
            this.simulerUnCombatToolStripMenuSystemeItem.Name = "simulerUnCombatToolStripMenuSystemeItem";
            this.simulerUnCombatToolStripMenuSystemeItem.Size = new System.Drawing.Size(175, 22);
            this.simulerUnCombatToolStripMenuSystemeItem.Text = "Simuler un combat";
            this.simulerUnCombatToolStripMenuSystemeItem.Click += new System.EventHandler(this.simulerUnCombatToolStripMenuSystemeItem_Click);
            // 
            // afficherLeRapportToolStripMenuSystemeItem
            // 
            this.afficherLeRapportToolStripMenuSystemeItem.Image = global::OgameFarmingInterface.Properties.Resources.Loupe;
            this.afficherLeRapportToolStripMenuSystemeItem.Name = "afficherLeRapportToolStripMenuSystemeItem";
            this.afficherLeRapportToolStripMenuSystemeItem.Size = new System.Drawing.Size(175, 22);
            this.afficherLeRapportToolStripMenuSystemeItem.Text = "Afficher le rapport";
            this.afficherLeRapportToolStripMenuSystemeItem.Click += new System.EventHandler(this.afficherLeRapportToolStripMenuSystemeItem_Click);
            // 
            // tabPageClassement
            // 
            this.tabPageClassement.Controls.Add(this.label38);
            this.tabPageClassement.Location = new System.Drawing.Point(4, 22);
            this.tabPageClassement.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageClassement.Name = "tabPageClassement";
            this.tabPageClassement.Size = new System.Drawing.Size(1113, 634);
            this.tabPageClassement.TabIndex = 5;
            this.tabPageClassement.Text = "Classement";
            this.tabPageClassement.UseVisualStyleBackColor = true;
            // 
            // label38
            // 
            this.label38.Location = new System.Drawing.Point(40, 23);
            this.label38.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(343, 67);
            this.label38.TabIndex = 0;
            this.label38.Text = "Et non, pas de bol, ce n\'est pas encore implémenté :P !";
            // 
            // tabPageParametres
            // 
            this.tabPageParametres.Controls.Add(this.groupBoxMiseAJour);
            this.tabPageParametres.Controls.Add(this.checkBoxEnregistrerEnQuittant);
            this.tabPageParametres.Controls.Add(this.groupBoxServeur);
            this.tabPageParametres.Controls.Add(this.groupBoxParamsSimuEnMasse);
            this.tabPageParametres.Controls.Add(this.groupBoxAmis);
            this.tabPageParametres.Controls.Add(this.groupBoxColonnesAffichees);
            this.tabPageParametres.Location = new System.Drawing.Point(4, 22);
            this.tabPageParametres.Name = "tabPageParametres";
            this.tabPageParametres.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageParametres.Size = new System.Drawing.Size(1113, 634);
            this.tabPageParametres.TabIndex = 4;
            this.tabPageParametres.Text = "Paramètres";
            this.tabPageParametres.UseVisualStyleBackColor = true;
            // 
            // groupBoxMiseAJour
            // 
            this.groupBoxMiseAJour.Controls.Add(this.buttonVerifierPresenceMiseAJour);
            this.groupBoxMiseAJour.Controls.Add(this.buttonLancerMiseAJour);
            this.groupBoxMiseAJour.Controls.Add(this.checkBoxMiseAJourAutomatique);
            this.groupBoxMiseAJour.Location = new System.Drawing.Point(326, 93);
            this.groupBoxMiseAJour.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxMiseAJour.Name = "groupBoxMiseAJour";
            this.groupBoxMiseAJour.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxMiseAJour.Size = new System.Drawing.Size(371, 88);
            this.groupBoxMiseAJour.TabIndex = 6;
            this.groupBoxMiseAJour.TabStop = false;
            this.groupBoxMiseAJour.Text = "Mise à jour";
            // 
            // buttonVerifierPresenceMiseAJour
            // 
            this.buttonVerifierPresenceMiseAJour.Location = new System.Drawing.Point(188, 20);
            this.buttonVerifierPresenceMiseAJour.Name = "buttonVerifierPresenceMiseAJour";
            this.buttonVerifierPresenceMiseAJour.Size = new System.Drawing.Size(161, 22);
            this.buttonVerifierPresenceMiseAJour.TabIndex = 7;
            this.buttonVerifierPresenceMiseAJour.Text = "Vérifier la version";
            this.buttonVerifierPresenceMiseAJour.UseVisualStyleBackColor = true;
            this.buttonVerifierPresenceMiseAJour.Click += new System.EventHandler(this.buttonVerifierPresenceMiseAJour_Click);
            // 
            // buttonLancerMiseAJour
            // 
            this.buttonLancerMiseAJour.Location = new System.Drawing.Point(188, 51);
            this.buttonLancerMiseAJour.Name = "buttonLancerMiseAJour";
            this.buttonLancerMiseAJour.Size = new System.Drawing.Size(161, 22);
            this.buttonLancerMiseAJour.TabIndex = 6;
            this.buttonLancerMiseAJour.Text = "Mettre à jour maintenant";
            this.buttonLancerMiseAJour.UseVisualStyleBackColor = true;
            this.buttonLancerMiseAJour.Click += new System.EventHandler(this.buttonLancerMiseAJour_Click);
            // 
            // checkBoxMiseAJourAutomatique
            // 
            this.checkBoxMiseAJourAutomatique.AutoSize = true;
            this.checkBoxMiseAJourAutomatique.Location = new System.Drawing.Point(16, 24);
            this.checkBoxMiseAJourAutomatique.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxMiseAJourAutomatique.Name = "checkBoxMiseAJourAutomatique";
            this.checkBoxMiseAJourAutomatique.Size = new System.Drawing.Size(142, 17);
            this.checkBoxMiseAJourAutomatique.TabIndex = 0;
            this.checkBoxMiseAJourAutomatique.Text = "Vérifier automatiquement";
            this.checkBoxMiseAJourAutomatique.UseVisualStyleBackColor = true;
            this.checkBoxMiseAJourAutomatique.CheckedChanged += new System.EventHandler(this.checkBoxMiseAJourAutomatique_CheckedChanged);
            // 
            // checkBoxEnregistrerEnQuittant
            // 
            this.checkBoxEnregistrerEnQuittant.AutoSize = true;
            this.checkBoxEnregistrerEnQuittant.Location = new System.Drawing.Point(326, 11);
            this.checkBoxEnregistrerEnQuittant.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxEnregistrerEnQuittant.Name = "checkBoxEnregistrerEnQuittant";
            this.checkBoxEnregistrerEnQuittant.Size = new System.Drawing.Size(213, 17);
            this.checkBoxEnregistrerEnQuittant.TabIndex = 5;
            this.checkBoxEnregistrerEnQuittant.Text = "Enregistrer automatiquement en quittant";
            this.checkBoxEnregistrerEnQuittant.UseVisualStyleBackColor = true;
            // 
            // groupBoxServeur
            // 
            this.groupBoxServeur.Controls.Add(this.ButtonInfoserver);
            this.groupBoxServeur.Controls.Add(this.buttonGereLesComptesOGSpy);
            this.groupBoxServeur.Controls.Add(this.checkedListBoxSelectionGalaxies);
            this.groupBoxServeur.Controls.Add(this.label36);
            this.groupBoxServeur.Controls.Add(this.label35);
            this.groupBoxServeur.Controls.Add(this.buttonEnvoyerClassements);
            this.groupBoxServeur.Controls.Add(this.pictureBox5);
            this.groupBoxServeur.Controls.Add(this.buttonRecupererClassements);
            this.groupBoxServeur.Controls.Add(this.checkBoxClassementAllianceRecherches);
            this.groupBoxServeur.Controls.Add(this.checkBoxClassementAllianceVaisseaux);
            this.groupBoxServeur.Controls.Add(this.checkBoxClassementAlliancePoints);
            this.groupBoxServeur.Controls.Add(this.checkBoxClassementJoueurRecherches);
            this.groupBoxServeur.Controls.Add(this.checkBoxClassementJoueurVaisseaux);
            this.groupBoxServeur.Controls.Add(this.checkBoxClassementJoueurPoints);
            this.groupBoxServeur.Controls.Add(this.label28);
            this.groupBoxServeur.Controls.Add(this.buttonEnvoyerRapports);
            this.groupBoxServeur.Controls.Add(this.pictureBox3);
            this.groupBoxServeur.Controls.Add(this.pictureBox2);
            this.groupBoxServeur.Controls.Add(this.pictureBox1);
            this.groupBoxServeur.Controls.Add(this.dateTimePickerRecuperationRapports);
            this.groupBoxServeur.Controls.Add(this.label32);
            this.groupBoxServeur.Controls.Add(this.buttonRecupererRapports);
            this.groupBoxServeur.Controls.Add(this.label31);
            this.groupBoxServeur.Controls.Add(this.label30);
            this.groupBoxServeur.Controls.Add(this.label29);
            this.groupBoxServeur.Controls.Add(this.checkBoxGardeMDP);
            this.groupBoxServeur.Controls.Add(this.buttonConnecter);
            this.groupBoxServeur.Controls.Add(this.buttonExporter);
            this.groupBoxServeur.Controls.Add(this.buttonImporter);
            this.groupBoxServeur.Controls.Add(this.labelURL);
            this.groupBoxServeur.Controls.Add(this.textBoxURL);
            this.groupBoxServeur.Controls.Add(this.textBoxPasse);
            this.groupBoxServeur.Controls.Add(this.textBoxLogin);
            this.groupBoxServeur.Controls.Add(this.label27);
            this.groupBoxServeur.Controls.Add(this.label26);
            this.groupBoxServeur.Location = new System.Drawing.Point(712, 9);
            this.groupBoxServeur.Name = "groupBoxServeur";
            this.groupBoxServeur.Size = new System.Drawing.Size(311, 536);
            this.groupBoxServeur.TabIndex = 4;
            this.groupBoxServeur.TabStop = false;
            this.groupBoxServeur.Text = "Serveur";
            // 
            // ButtonInfoserver
            // 
            this.ButtonInfoserver.Location = new System.Drawing.Point(109, 164);
            this.ButtonInfoserver.Name = "ButtonInfoserver";
            this.ButtonInfoserver.Size = new System.Drawing.Size(184, 23);
            this.ButtonInfoserver.TabIndex = 44;
            this.ButtonInfoserver.Text = "Info Server";
            this.ButtonInfoserver.UseVisualStyleBackColor = true;
            this.ButtonInfoserver.Click += new System.EventHandler(this.ButtonInfoserver_Click);
            // 
            // buttonGereLesComptesOGSpy
            // 
            this.buttonGereLesComptesOGSpy.Location = new System.Drawing.Point(51, 42);
            this.buttonGereLesComptesOGSpy.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGereLesComptesOGSpy.Name = "buttonGereLesComptesOGSpy";
            this.buttonGereLesComptesOGSpy.Size = new System.Drawing.Size(23, 19);
            this.buttonGereLesComptesOGSpy.TabIndex = 43;
            this.buttonGereLesComptesOGSpy.Text = "...";
            this.buttonGereLesComptesOGSpy.UseVisualStyleBackColor = true;
            this.buttonGereLesComptesOGSpy.Click += new System.EventHandler(this.buttonGereLesComptesOGSpy_Click);
            // 
            // checkedListBoxSelectionGalaxies
            // 
            this.checkedListBoxSelectionGalaxies.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkedListBoxSelectionGalaxies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxSelectionGalaxies.CheckOnClick = true;
            this.checkedListBoxSelectionGalaxies.ColumnWidth = 50;
            this.checkedListBoxSelectionGalaxies.FormattingEnabled = true;
            this.checkedListBoxSelectionGalaxies.HorizontalScrollbar = true;
            this.checkedListBoxSelectionGalaxies.IntegralHeight = false;
            this.checkedListBoxSelectionGalaxies.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.checkedListBoxSelectionGalaxies.Location = new System.Drawing.Point(5, 221);
            this.checkedListBoxSelectionGalaxies.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBoxSelectionGalaxies.MultiColumn = true;
            this.checkedListBoxSelectionGalaxies.Name = "checkedListBoxSelectionGalaxies";
            this.checkedListBoxSelectionGalaxies.ScrollAlwaysVisible = true;
            this.checkedListBoxSelectionGalaxies.Size = new System.Drawing.Size(301, 31);
            this.checkedListBoxSelectionGalaxies.TabIndex = 42;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(5, 464);
            this.label36.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(55, 13);
            this.label36.TabIndex = 41;
            this.label36.Text = "Alliances :";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(5, 448);
            this.label35.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(50, 13);
            this.label35.TabIndex = 40;
            this.label35.Text = "Joueurs :";
            // 
            // buttonEnvoyerClassements
            // 
            this.buttonEnvoyerClassements.Enabled = false;
            this.buttonEnvoyerClassements.Location = new System.Drawing.Point(55, 491);
            this.buttonEnvoyerClassements.Name = "buttonEnvoyerClassements";
            this.buttonEnvoyerClassements.Size = new System.Drawing.Size(116, 23);
            this.buttonEnvoyerClassements.TabIndex = 39;
            this.buttonEnvoyerClassements.Text = "Envoyer au serveur";
            this.buttonEnvoyerClassements.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::OgameFarmingInterface.Properties.Resources.Rapport48;
            this.pictureBox5.Location = new System.Drawing.Point(5, 482);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(46, 42);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 38;
            this.pictureBox5.TabStop = false;
            // 
            // buttonRecupererClassements
            // 
            this.buttonRecupererClassements.Enabled = false;
            this.buttonRecupererClassements.Location = new System.Drawing.Point(176, 491);
            this.buttonRecupererClassements.Name = "buttonRecupererClassements";
            this.buttonRecupererClassements.Size = new System.Drawing.Size(117, 23);
            this.buttonRecupererClassements.TabIndex = 37;
            this.buttonRecupererClassements.Text = "Récupérer du serveur";
            this.buttonRecupererClassements.UseVisualStyleBackColor = true;
            // 
            // checkBoxClassementAllianceRecherches
            // 
            this.checkBoxClassementAllianceRecherches.AutoSize = true;
            this.checkBoxClassementAllianceRecherches.Enabled = false;
            this.checkBoxClassementAllianceRecherches.Location = new System.Drawing.Point(228, 464);
            this.checkBoxClassementAllianceRecherches.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxClassementAllianceRecherches.Name = "checkBoxClassementAllianceRecherches";
            this.checkBoxClassementAllianceRecherches.Size = new System.Drawing.Size(84, 17);
            this.checkBoxClassementAllianceRecherches.TabIndex = 36;
            this.checkBoxClassementAllianceRecherches.Text = "Recherches";
            this.checkBoxClassementAllianceRecherches.UseVisualStyleBackColor = true;
            // 
            // checkBoxClassementAllianceVaisseaux
            // 
            this.checkBoxClassementAllianceVaisseaux.AutoSize = true;
            this.checkBoxClassementAllianceVaisseaux.Enabled = false;
            this.checkBoxClassementAllianceVaisseaux.Location = new System.Drawing.Point(150, 464);
            this.checkBoxClassementAllianceVaisseaux.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxClassementAllianceVaisseaux.Name = "checkBoxClassementAllianceVaisseaux";
            this.checkBoxClassementAllianceVaisseaux.Size = new System.Drawing.Size(74, 17);
            this.checkBoxClassementAllianceVaisseaux.TabIndex = 35;
            this.checkBoxClassementAllianceVaisseaux.Text = "Vaisseaux";
            this.checkBoxClassementAllianceVaisseaux.UseVisualStyleBackColor = true;
            // 
            // checkBoxClassementAlliancePoints
            // 
            this.checkBoxClassementAlliancePoints.AutoSize = true;
            this.checkBoxClassementAlliancePoints.Enabled = false;
            this.checkBoxClassementAlliancePoints.Location = new System.Drawing.Point(77, 464);
            this.checkBoxClassementAlliancePoints.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxClassementAlliancePoints.Name = "checkBoxClassementAlliancePoints";
            this.checkBoxClassementAlliancePoints.Size = new System.Drawing.Size(55, 17);
            this.checkBoxClassementAlliancePoints.TabIndex = 34;
            this.checkBoxClassementAlliancePoints.Text = "Points";
            this.checkBoxClassementAlliancePoints.UseVisualStyleBackColor = true;
            // 
            // checkBoxClassementJoueurRecherches
            // 
            this.checkBoxClassementJoueurRecherches.AutoSize = true;
            this.checkBoxClassementJoueurRecherches.Enabled = false;
            this.checkBoxClassementJoueurRecherches.Location = new System.Drawing.Point(228, 448);
            this.checkBoxClassementJoueurRecherches.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxClassementJoueurRecherches.Name = "checkBoxClassementJoueurRecherches";
            this.checkBoxClassementJoueurRecherches.Size = new System.Drawing.Size(84, 17);
            this.checkBoxClassementJoueurRecherches.TabIndex = 33;
            this.checkBoxClassementJoueurRecherches.Text = "Recherches";
            this.checkBoxClassementJoueurRecherches.UseVisualStyleBackColor = true;
            // 
            // checkBoxClassementJoueurVaisseaux
            // 
            this.checkBoxClassementJoueurVaisseaux.AutoSize = true;
            this.checkBoxClassementJoueurVaisseaux.Enabled = false;
            this.checkBoxClassementJoueurVaisseaux.Location = new System.Drawing.Point(150, 448);
            this.checkBoxClassementJoueurVaisseaux.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxClassementJoueurVaisseaux.Name = "checkBoxClassementJoueurVaisseaux";
            this.checkBoxClassementJoueurVaisseaux.Size = new System.Drawing.Size(74, 17);
            this.checkBoxClassementJoueurVaisseaux.TabIndex = 32;
            this.checkBoxClassementJoueurVaisseaux.Text = "Vaisseaux";
            this.checkBoxClassementJoueurVaisseaux.UseVisualStyleBackColor = true;
            // 
            // checkBoxClassementJoueurPoints
            // 
            this.checkBoxClassementJoueurPoints.AutoSize = true;
            this.checkBoxClassementJoueurPoints.Enabled = false;
            this.checkBoxClassementJoueurPoints.Location = new System.Drawing.Point(77, 448);
            this.checkBoxClassementJoueurPoints.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxClassementJoueurPoints.Name = "checkBoxClassementJoueurPoints";
            this.checkBoxClassementJoueurPoints.Size = new System.Drawing.Size(55, 17);
            this.checkBoxClassementJoueurPoints.TabIndex = 31;
            this.checkBoxClassementJoueurPoints.Text = "Points";
            this.checkBoxClassementJoueurPoints.UseVisualStyleBackColor = true;
            // 
            // label28
            // 
            this.label28.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label28.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label28.Location = new System.Drawing.Point(5, 428);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(302, 13);
            this.label28.TabIndex = 30;
            this.label28.Text = "Classements";
            // 
            // buttonEnvoyerRapports
            // 
            this.buttonEnvoyerRapports.Enabled = false;
            this.buttonEnvoyerRapports.Location = new System.Drawing.Point(55, 372);
            this.buttonEnvoyerRapports.Name = "buttonEnvoyerRapports";
            this.buttonEnvoyerRapports.Size = new System.Drawing.Size(116, 23);
            this.buttonEnvoyerRapports.TabIndex = 29;
            this.buttonEnvoyerRapports.Text = "Envoyer au serveur";
            this.buttonEnvoyerRapports.UseVisualStyleBackColor = true;
            this.buttonEnvoyerRapports.Click += new System.EventHandler(this.buttonEnvoyerRapports_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::OgameFarmingInterface.Properties.Resources.Rapport48;
            this.pictureBox3.Location = new System.Drawing.Point(5, 363);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::OgameFarmingInterface.Properties.Resources.Galaxie48;
            this.pictureBox2.Location = new System.Drawing.Point(5, 253);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OgameFarmingInterface.Properties.Resources.Cadenas48;
            this.pictureBox1.Location = new System.Drawing.Point(5, 116);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePickerRecuperationRapports
            // 
            this.dateTimePickerRecuperationRapports.Location = new System.Drawing.Point(55, 341);
            this.dateTimePickerRecuperationRapports.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerRecuperationRapports.Name = "dateTimePickerRecuperationRapports";
            this.dateTimePickerRecuperationRapports.Size = new System.Drawing.Size(179, 20);
            this.dateTimePickerRecuperationRapports.TabIndex = 24;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(5, 343);
            this.label32.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(51, 13);
            this.label32.TabIndex = 23;
            this.label32.Text = "Depuis le";
            // 
            // buttonRecupererRapports
            // 
            this.buttonRecupererRapports.Enabled = false;
            this.buttonRecupererRapports.Location = new System.Drawing.Point(176, 372);
            this.buttonRecupererRapports.Name = "buttonRecupererRapports";
            this.buttonRecupererRapports.Size = new System.Drawing.Size(117, 23);
            this.buttonRecupererRapports.TabIndex = 22;
            this.buttonRecupererRapports.Text = "Récupérer du serveur";
            this.buttonRecupererRapports.UseVisualStyleBackColor = true;
            this.buttonRecupererRapports.Click += new System.EventHandler(this.buttonRecupererRapports_Click);
            // 
            // label31
            // 
            this.label31.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label31.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label31.Location = new System.Drawing.Point(5, 321);
            this.label31.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(302, 13);
            this.label31.TabIndex = 21;
            this.label31.Text = "Rapports";
            // 
            // label30
            // 
            this.label30.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label30.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label30.Location = new System.Drawing.Point(5, 21);
            this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(302, 13);
            this.label30.TabIndex = 20;
            this.label30.Text = "Paramètres de connexion";
            // 
            // label29
            // 
            this.label29.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label29.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label29.Location = new System.Drawing.Point(5, 200);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(302, 13);
            this.label29.TabIndex = 19;
            this.label29.Text = "Galaxies";
            // 
            // checkBoxGardeMDP
            // 
            this.checkBoxGardeMDP.AutoSize = true;
            this.checkBoxGardeMDP.Location = new System.Drawing.Point(115, 116);
            this.checkBoxGardeMDP.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxGardeMDP.Name = "checkBoxGardeMDP";
            this.checkBoxGardeMDP.Size = new System.Drawing.Size(163, 17);
            this.checkBoxGardeMDP.TabIndex = 18;
            this.checkBoxGardeMDP.Text = "Se souvenir du mot de passe";
            this.checkBoxGardeMDP.UseVisualStyleBackColor = true;
            // 
            // buttonConnecter
            // 
            this.buttonConnecter.Location = new System.Drawing.Point(109, 135);
            this.buttonConnecter.Name = "buttonConnecter";
            this.buttonConnecter.Size = new System.Drawing.Size(184, 23);
            this.buttonConnecter.TabIndex = 8;
            this.buttonConnecter.Text = "Connecter";
            this.buttonConnecter.UseVisualStyleBackColor = true;
            this.buttonConnecter.Click += new System.EventHandler(this.buttonConnecter_Click);
            // 
            // buttonExporter
            // 
            this.buttonExporter.Enabled = false;
            this.buttonExporter.Location = new System.Drawing.Point(176, 261);
            this.buttonExporter.Name = "buttonExporter";
            this.buttonExporter.Size = new System.Drawing.Size(117, 23);
            this.buttonExporter.TabIndex = 7;
            this.buttonExporter.Text = "Récupérer du serveur";
            this.buttonExporter.UseVisualStyleBackColor = true;
            this.buttonExporter.Click += new System.EventHandler(this.buttonExporter_Click);
            // 
            // buttonImporter
            // 
            this.buttonImporter.Enabled = false;
            this.buttonImporter.Location = new System.Drawing.Point(55, 261);
            this.buttonImporter.Name = "buttonImporter";
            this.buttonImporter.Size = new System.Drawing.Size(116, 23);
            this.buttonImporter.TabIndex = 6;
            this.buttonImporter.Text = "Envoyer au serveur";
            this.buttonImporter.UseVisualStyleBackColor = true;
            this.buttonImporter.Click += new System.EventHandler(this.buttonImporter_Click);
            // 
            // labelURL
            // 
            this.labelURL.AutoSize = true;
            this.labelURL.Location = new System.Drawing.Point(29, 97);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(82, 13);
            this.labelURL.TabIndex = 5;
            this.labelURL.Text = "URL du serveur";
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(115, 94);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(180, 20);
            this.textBoxURL.TabIndex = 4;
            // 
            // textBoxPasse
            // 
            this.textBoxPasse.Location = new System.Drawing.Point(115, 68);
            this.textBoxPasse.Name = "textBoxPasse";
            this.textBoxPasse.PasswordChar = '*';
            this.textBoxPasse.Size = new System.Drawing.Size(180, 20);
            this.textBoxPasse.TabIndex = 3;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(115, 42);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(180, 20);
            this.textBoxLogin.TabIndex = 2;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(41, 71);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(71, 13);
            this.label27.TabIndex = 1;
            this.label27.Text = "Mot de passe";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(79, 45);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(33, 13);
            this.label26.TabIndex = 0;
            this.label26.Text = "Login";
            // 
            // groupBoxParamsSimuEnMasse
            // 
            this.groupBoxParamsSimuEnMasse.Controls.Add(this.textBoxParamsSimuEnMasseNombreDeSimulations);
            this.groupBoxParamsSimuEnMasse.Controls.Add(this.label25);
            this.groupBoxParamsSimuEnMasse.Location = new System.Drawing.Point(326, 32);
            this.groupBoxParamsSimuEnMasse.Name = "groupBoxParamsSimuEnMasse";
            this.groupBoxParamsSimuEnMasse.Size = new System.Drawing.Size(371, 56);
            this.groupBoxParamsSimuEnMasse.TabIndex = 3;
            this.groupBoxParamsSimuEnMasse.TabStop = false;
            this.groupBoxParamsSimuEnMasse.Text = "Paramétrage des simulations de masse";
            // 
            // textBoxParamsSimuEnMasseNombreDeSimulations
            // 
            this.textBoxParamsSimuEnMasseNombreDeSimulations.Location = new System.Drawing.Point(139, 24);
            this.textBoxParamsSimuEnMasseNombreDeSimulations.MaxLength = 5;
            this.textBoxParamsSimuEnMasseNombreDeSimulations.Name = "textBoxParamsSimuEnMasseNombreDeSimulations";
            this.textBoxParamsSimuEnMasseNombreDeSimulations.Size = new System.Drawing.Size(51, 20);
            this.textBoxParamsSimuEnMasseNombreDeSimulations.TabIndex = 1;
            this.textBoxParamsSimuEnMasseNombreDeSimulations.Text = "10";
            this.textBoxParamsSimuEnMasseNombreDeSimulations.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxParamsSimuEnMasseNombreDeSimulations.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(20, 27);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(113, 13);
            this.label25.TabIndex = 0;
            this.label25.Text = "Nombre de simulations";
            // 
            // groupBoxAmis
            // 
            this.groupBoxAmis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxAmis.Controls.Add(this.label24);
            this.groupBoxAmis.Controls.Add(this.label23);
            this.groupBoxAmis.Controls.Add(this.label22);
            this.groupBoxAmis.Controls.Add(this.buttonAjoutJoueurAmi);
            this.groupBoxAmis.Controls.Add(this.buttonAjoutAllianceAmie);
            this.groupBoxAmis.Controls.Add(this.listBoxCoordonneesAmies);
            this.groupBoxAmis.Controls.Add(this.listBoxJoueursAmis);
            this.groupBoxAmis.Controls.Add(this.buttonAjoutCoordonneesAmies);
            this.groupBoxAmis.Controls.Add(this.textBoxAjoutAmi);
            this.groupBoxAmis.Controls.Add(this.listBoxAlliancesAmies);
            this.groupBoxAmis.Location = new System.Drawing.Point(326, 186);
            this.groupBoxAmis.Name = "groupBoxAmis";
            this.groupBoxAmis.Size = new System.Drawing.Size(371, 430);
            this.groupBoxAmis.TabIndex = 2;
            this.groupBoxAmis.TabStop = false;
            this.groupBoxAmis.Text = "Amis";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(19, 256);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(70, 13);
            this.label24.TabIndex = 9;
            this.label24.Text = "Coordonnees";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(19, 168);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(44, 13);
            this.label23.TabIndex = 8;
            this.label23.Text = "Joueurs";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(19, 80);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(49, 13);
            this.label22.TabIndex = 7;
            this.label22.Text = "Alliances";
            // 
            // buttonAjoutJoueurAmi
            // 
            this.buttonAjoutJoueurAmi.Location = new System.Drawing.Point(272, 47);
            this.buttonAjoutJoueurAmi.Name = "buttonAjoutJoueurAmi";
            this.buttonAjoutJoueurAmi.Size = new System.Drawing.Size(78, 22);
            this.buttonAjoutJoueurAmi.TabIndex = 6;
            this.buttonAjoutJoueurAmi.Text = "Joueur";
            this.buttonAjoutJoueurAmi.UseVisualStyleBackColor = true;
            this.buttonAjoutJoueurAmi.Click += new System.EventHandler(this.buttonAjoutJoueurAmi_Click);
            // 
            // buttonAjoutAllianceAmie
            // 
            this.buttonAjoutAllianceAmie.Location = new System.Drawing.Point(188, 47);
            this.buttonAjoutAllianceAmie.Name = "buttonAjoutAllianceAmie";
            this.buttonAjoutAllianceAmie.Size = new System.Drawing.Size(78, 22);
            this.buttonAjoutAllianceAmie.TabIndex = 5;
            this.buttonAjoutAllianceAmie.Text = "Alliance";
            this.buttonAjoutAllianceAmie.UseVisualStyleBackColor = true;
            this.buttonAjoutAllianceAmie.Click += new System.EventHandler(this.buttonAjoutAllianceAmie_Click);
            // 
            // listBoxCoordonneesAmies
            // 
            this.listBoxCoordonneesAmies.FormattingEnabled = true;
            this.listBoxCoordonneesAmies.Location = new System.Drawing.Point(22, 272);
            this.listBoxCoordonneesAmies.Name = "listBoxCoordonneesAmies";
            this.listBoxCoordonneesAmies.Size = new System.Drawing.Size(328, 69);
            this.listBoxCoordonneesAmies.TabIndex = 4;
            this.listBoxCoordonneesAmies.DoubleClick += new System.EventHandler(this.listBoxesAlliance_DoubleClick);
            // 
            // listBoxJoueursAmis
            // 
            this.listBoxJoueursAmis.FormattingEnabled = true;
            this.listBoxJoueursAmis.Location = new System.Drawing.Point(22, 184);
            this.listBoxJoueursAmis.Name = "listBoxJoueursAmis";
            this.listBoxJoueursAmis.Size = new System.Drawing.Size(328, 69);
            this.listBoxJoueursAmis.TabIndex = 3;
            this.listBoxJoueursAmis.DoubleClick += new System.EventHandler(this.listBoxesAlliance_DoubleClick);
            // 
            // buttonAjoutCoordonneesAmies
            // 
            this.buttonAjoutCoordonneesAmies.Location = new System.Drawing.Point(104, 47);
            this.buttonAjoutCoordonneesAmies.Name = "buttonAjoutCoordonneesAmies";
            this.buttonAjoutCoordonneesAmies.Size = new System.Drawing.Size(78, 22);
            this.buttonAjoutCoordonneesAmies.TabIndex = 2;
            this.buttonAjoutCoordonneesAmies.Text = "Coordonnees";
            this.buttonAjoutCoordonneesAmies.UseVisualStyleBackColor = true;
            this.buttonAjoutCoordonneesAmies.Click += new System.EventHandler(this.buttonAjoutCoordonneesAmies_Click);
            // 
            // textBoxAjoutAmi
            // 
            this.textBoxAjoutAmi.Location = new System.Drawing.Point(22, 23);
            this.textBoxAjoutAmi.Name = "textBoxAjoutAmi";
            this.textBoxAjoutAmi.Size = new System.Drawing.Size(328, 20);
            this.textBoxAjoutAmi.TabIndex = 1;
            // 
            // listBoxAlliancesAmies
            // 
            this.listBoxAlliancesAmies.FormattingEnabled = true;
            this.listBoxAlliancesAmies.Location = new System.Drawing.Point(22, 96);
            this.listBoxAlliancesAmies.Name = "listBoxAlliancesAmies";
            this.listBoxAlliancesAmies.Size = new System.Drawing.Size(328, 69);
            this.listBoxAlliancesAmies.TabIndex = 0;
            this.listBoxAlliancesAmies.DoubleClick += new System.EventHandler(this.listBoxesAlliance_DoubleClick);
            // 
            // groupBoxColonnesAffichees
            // 
            this.groupBoxColonnesAffichees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxColonnesAffichees.Controls.Add(this.label37);
            this.groupBoxColonnesAffichees.Controls.Add(this.buttonReinitialiserColonneRapports);
            this.groupBoxColonnesAffichees.Controls.Add(this.ColonnesAfficheesCheckedListBox);
            this.groupBoxColonnesAffichees.Location = new System.Drawing.Point(14, 9);
            this.groupBoxColonnesAffichees.Name = "groupBoxColonnesAffichees";
            this.groupBoxColonnesAffichees.Size = new System.Drawing.Size(297, 606);
            this.groupBoxColonnesAffichees.TabIndex = 1;
            this.groupBoxColonnesAffichees.TabStop = false;
            this.groupBoxColonnesAffichees.Text = "Colonnes de la vue Rapports d\'espionnage";
            // 
            // label37
            // 
            this.label37.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label37.Location = new System.Drawing.Point(16, 564);
            this.label37.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(261, 32);
            this.label37.TabIndex = 2;
            this.label37.Text = "Les colonnes marquées [S] sont des colonnes de résultat de simulation massive.";
            // 
            // buttonReinitialiserColonneRapports
            // 
            this.buttonReinitialiserColonneRapports.Location = new System.Drawing.Point(19, 33);
            this.buttonReinitialiserColonneRapports.Name = "buttonReinitialiserColonneRapports";
            this.buttonReinitialiserColonneRapports.Size = new System.Drawing.Size(198, 40);
            this.buttonReinitialiserColonneRapports.TabIndex = 0;
            this.buttonReinitialiserColonneRapports.Text = "Réinitialiser l\'organisation des colonnes des rapports d\'espionnage";
            this.buttonReinitialiserColonneRapports.UseVisualStyleBackColor = true;
            this.buttonReinitialiserColonneRapports.Click += new System.EventHandler(this.buttonReinitialiserColonneRapports_Click);
            // 
            // ColonnesAfficheesCheckedListBox
            // 
            this.ColonnesAfficheesCheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ColonnesAfficheesCheckedListBox.FormattingEnabled = true;
            this.ColonnesAfficheesCheckedListBox.HorizontalScrollbar = true;
            this.ColonnesAfficheesCheckedListBox.Location = new System.Drawing.Point(19, 79);
            this.ColonnesAfficheesCheckedListBox.Name = "ColonnesAfficheesCheckedListBox";
            this.ColonnesAfficheesCheckedListBox.Size = new System.Drawing.Size(260, 469);
            this.ColonnesAfficheesCheckedListBox.TabIndex = 1;
            this.ColonnesAfficheesCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ColonnesAfficheesCheckedListBox_ItemCheck);
            // 
            // tabPageNavigateur
            // 
            this.tabPageNavigateur.Controls.Add(this.panel1);
            this.tabPageNavigateur.Controls.Add(this.textBoxBarreDAdresse);
            this.tabPageNavigateur.Controls.Add(this.buttonGO);
            this.tabPageNavigateur.Controls.Add(this.buttonActualiser);
            this.tabPageNavigateur.Controls.Add(this.buttonArreter);
            this.tabPageNavigateur.Controls.Add(this.buttonHome);
            this.tabPageNavigateur.Controls.Add(this.buttonSuivant);
            this.tabPageNavigateur.Controls.Add(this.buttonPrecedant);
            this.tabPageNavigateur.Location = new System.Drawing.Point(4, 22);
            this.tabPageNavigateur.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageNavigateur.Name = "tabPageNavigateur";
            this.tabPageNavigateur.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageNavigateur.Size = new System.Drawing.Size(1113, 634);
            this.tabPageNavigateur.TabIndex = 6;
            this.tabPageNavigateur.Text = "Navigateur";
            this.tabPageNavigateur.UseVisualStyleBackColor = true;
            this.tabPageNavigateur.Click += new System.EventHandler(this.tabPageNavigateur_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.webBrowser);
            this.panel1.Location = new System.Drawing.Point(4, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1109, 606);
            this.panel1.TabIndex = 8;
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.Margin = new System.Windows.Forms.Padding(2);
            this.webBrowser.MinimumSize = new System.Drawing.Size(13, 13);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1105, 602);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser_Navigated);
            // 
            // textBoxBarreDAdresse
            // 
            this.textBoxBarreDAdresse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBarreDAdresse.Location = new System.Drawing.Point(174, 8);
            this.textBoxBarreDAdresse.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBarreDAdresse.Name = "textBoxBarreDAdresse";
            this.textBoxBarreDAdresse.Size = new System.Drawing.Size(905, 20);
            this.textBoxBarreDAdresse.TabIndex = 7;
            this.textBoxBarreDAdresse.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxBarreDAdresse_KeyDown);
            // 
            // buttonGO
            // 
            this.buttonGO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGO.Image = global::OgameFarmingInterface.Properties.Resources.GO;
            this.buttonGO.Location = new System.Drawing.Point(1081, 4);
            this.buttonGO.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGO.Name = "buttonGO";
            this.buttonGO.Size = new System.Drawing.Size(30, 26);
            this.buttonGO.TabIndex = 6;
            this.buttonGO.UseVisualStyleBackColor = true;
            this.buttonGO.Click += new System.EventHandler(this.buttonGO_Click);
            // 
            // buttonActualiser
            // 
            this.buttonActualiser.Image = global::OgameFarmingInterface.Properties.Resources.Actualiser;
            this.buttonActualiser.Location = new System.Drawing.Point(140, 4);
            this.buttonActualiser.Margin = new System.Windows.Forms.Padding(2);
            this.buttonActualiser.Name = "buttonActualiser";
            this.buttonActualiser.Size = new System.Drawing.Size(30, 26);
            this.buttonActualiser.TabIndex = 5;
            this.buttonActualiser.UseVisualStyleBackColor = true;
            this.buttonActualiser.Click += new System.EventHandler(this.buttonActualiser_Click);
            // 
            // buttonArreter
            // 
            this.buttonArreter.Image = global::OgameFarmingInterface.Properties.Resources.Arreter;
            this.buttonArreter.Location = new System.Drawing.Point(106, 4);
            this.buttonArreter.Margin = new System.Windows.Forms.Padding(2);
            this.buttonArreter.Name = "buttonArreter";
            this.buttonArreter.Size = new System.Drawing.Size(30, 26);
            this.buttonArreter.TabIndex = 4;
            this.buttonArreter.UseVisualStyleBackColor = true;
            this.buttonArreter.Click += new System.EventHandler(this.buttonArreter_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.Image = global::OgameFarmingInterface.Properties.Resources.Home;
            this.buttonHome.Location = new System.Drawing.Point(72, 4);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(30, 26);
            this.buttonHome.TabIndex = 3;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonSuivant
            // 
            this.buttonSuivant.Image = global::OgameFarmingInterface.Properties.Resources.Suivant;
            this.buttonSuivant.Location = new System.Drawing.Point(38, 4);
            this.buttonSuivant.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSuivant.Name = "buttonSuivant";
            this.buttonSuivant.Size = new System.Drawing.Size(30, 26);
            this.buttonSuivant.TabIndex = 2;
            this.buttonSuivant.UseVisualStyleBackColor = true;
            this.buttonSuivant.Click += new System.EventHandler(this.buttonSuivant_Click);
            // 
            // buttonPrecedant
            // 
            this.buttonPrecedant.Image = global::OgameFarmingInterface.Properties.Resources.Precedant;
            this.buttonPrecedant.Location = new System.Drawing.Point(4, 4);
            this.buttonPrecedant.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPrecedant.Name = "buttonPrecedant";
            this.buttonPrecedant.Size = new System.Drawing.Size(30, 26);
            this.buttonPrecedant.TabIndex = 1;
            this.buttonPrecedant.UseVisualStyleBackColor = true;
            this.buttonPrecedant.Click += new System.EventHandler(this.buttonPrecedant_Click);
            // 
            // contextMenuStripTray
            // 
            this.contextMenuStripTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTrayMenuItemQuitter});
            this.contextMenuStripTray.Name = "contextMenuStripTray";
            this.contextMenuStripTray.Size = new System.Drawing.Size(112, 26);
            // 
            // toolStripTrayMenuItemQuitter
            // 
            this.toolStripTrayMenuItemQuitter.Name = "toolStripTrayMenuItemQuitter";
            this.toolStripTrayMenuItemQuitter.Size = new System.Drawing.Size(111, 22);
            this.toolStripTrayMenuItemQuitter.Text = "Quitter";
            // 
            // backgroundWorkerTesterMiseAJour
            // 
            this.backgroundWorkerTesterMiseAJour.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerTesterMiseAJour_DoWork);
            this.backgroundWorkerTesterMiseAJour.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerTesterMiseAJour_RunWorkerCompleted);
            // 
            // FormPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1125, 716);
            this.Controls.Add(this.toolStripContainer1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(205, 143);
            this.Name = "FormPrincipale";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Aide au pillage - Mackila";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipale_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPrincipale_FormClosed);
            this.Load += new System.EventHandler(this.FormPrincipale_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStripMenuListView.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tabControlPrincipal.ResumeLayout(false);
            this.tabPageRapports.ResumeLayout(false);
            this.tabPageAttaquant.ResumeLayout(false);
            this.groupBoxEmpire.ResumeLayout(false);
            this.groupBoxTechnologie.ResumeLayout(false);
            this.groupBoxTechnologie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceParametresTechnologieAttaquant)).EndInit();
            this.groupBoxFlotte.ResumeLayout(false);
            this.groupBoxFlotte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceParametresFlotteAttaquante)).EndInit();
            this.tabPageUnivers.ResumeLayout(false);
            this.groupBoxRecherche.ResumeLayout(false);
            this.groupBoxRecherche.PerformLayout();
            this.groupBoxUnivers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tabControlUnivers.ResumeLayout(false);
            this.groupBoxVueSysteme.ResumeLayout(false);
            this.contextMenuStripSysteme.ResumeLayout(false);
            this.tabPageClassement.ResumeLayout(false);
            this.tabPageParametres.ResumeLayout(false);
            this.tabPageParametres.PerformLayout();
            this.groupBoxMiseAJour.ResumeLayout(false);
            this.groupBoxMiseAJour.PerformLayout();
            this.groupBoxServeur.ResumeLayout(false);
            this.groupBoxServeur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxParamsSimuEnMasse.ResumeLayout(false);
            this.groupBoxParamsSimuEnMasse.PerformLayout();
            this.groupBoxAmis.ResumeLayout(false);
            this.groupBoxAmis.PerformLayout();
            this.groupBoxColonnesAffichees.ResumeLayout(false);
            this.tabPageNavigateur.ResumeLayout(false);
            this.tabPageNavigateur.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.contextMenuStripTray.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMenuListView;
        private System.Windows.Forms.ToolStripButton nouveauToolStripButton;
        private System.Windows.Forms.ToolStripButton ouvrirToolStripButton;
        private System.Windows.Forms.ToolStripButton enregistrerToolStripButton;
        private System.Windows.Forms.ToolStripButton imprimerToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton couperToolStripButton;
        private System.Windows.Forms.ToolStripButton copierToolStripButton;
        private System.Windows.Forms.ToolStripButton collerToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ToolStripButton;
        private System.Windows.Forms.TabControl tabControlPrincipal;
        private System.Windows.Forms.TabPage tabPageRapports;
        private System.Windows.Forms.TabPage tabPageAttaquant;
        private System.Windows.Forms.GroupBox groupBoxFlotte;
        private System.Windows.Forms.GroupBox groupBoxEmpire;
        private System.Windows.Forms.GroupBox groupBoxTechnologie;
        private System.Windows.Forms.ListView listViewEmpire;
        private System.Windows.Forms.ToolStripMenuItem simulerUnCombatToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxFlotteAttaquantePT;
        private System.Windows.Forms.TextBox textBoxFlotteAttaquanteTechHyperespace;
        private System.Windows.Forms.TextBox textBoxFlotteAttaquanteTechImpulsion;
        private System.Windows.Forms.TextBox textBoxFlotteAttaquanteTechCombustion;
        private System.Windows.Forms.TextBox textBoxFlotteAttaquanteTechProtections;
        private System.Windows.Forms.TextBox textBoxFlotteAttaquanteTechBoucliers;
        private System.Windows.Forms.TextBox textBoxFlotteAttaquanteTechArmes;
        private System.Windows.Forms.TextBox textBoxFlotteAttaquanteCoordonnees;
        private System.Windows.Forms.TextBox textBoxFlotteAttaquanteEDLM;
        private System.Windows.Forms.TextBox textBoxFlotteAttaquanteDES;
        private System.Windows.Forms.TextBox textBoxFlotteAttaquanteB;
        private System.Windows.Forms.TextBox textBoxFlotteAttaquanteSondes;
        private System.Windows.Forms.TextBox textBoxFlotteAttaquanteRC;
        private System.Windows.Forms.TextBox textBoxFlotteAttaquanteVC;
        private System.Windows.Forms.TextBox textBoxFlotteAttaquanteVB;
        private System.Windows.Forms.TextBox textBoxFlotteAttaquanteCR;
        private System.Windows.Forms.TextBox textBoxFlotteAttaquanteCL;
        private System.Windows.Forms.TextBox textBoxFlotteAttaquanteCle;
        private System.Windows.Forms.TextBox textBoxFlotteAttaquanteGT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTray;
        private System.Windows.Forms.ToolStripMenuItem toolStripTrayMenuItemQuitter;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSupprimerLesRapportsSelectionnes;
        private System.Windows.Forms.BindingSource bindingSourceParametresFlotteAttaquante;
        private System.Windows.Forms.BindingSource bindingSourceParametresTechnologieAttaquant;
        private System.Windows.Forms.TabPage tabPageUnivers;
        private System.Windows.Forms.TabControl tabControlUnivers;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBoxVueSysteme;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.ListView listViewUnivers;
        private System.Windows.Forms.GroupBox groupBoxUnivers;
        private System.Windows.Forms.ListView listViewSysteme;
        private System.Windows.Forms.ColumnHeader Position;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ColumnHeader Joueur;
        private System.Windows.Forms.ColumnHeader Alliance;
        private System.Windows.Forms.ColumnHeader Rapport;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripSysteme;
        private System.Windows.Forms.ToolStripMenuItem simulerUnCombatToolStripMenuSystemeItem;
        private System.Windows.Forms.ToolStripMenuItem afficherLeRapportToolStripMenuSystemeItem;
        private System.Windows.Forms.TabPage tabPageParametres;
        private System.Windows.Forms.Button buttonReinitialiserColonneRapports;
        private System.Windows.Forms.GroupBox groupBoxColonnesAffichees;
        private System.Windows.Forms.ToolStripMenuItem AfficherLeRapportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EnvoyerEnHautToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envoyerALaFinDeLaListeToolStripMenuItem;
        private System.Windows.Forms.CheckedListBox ColonnesAfficheesCheckedListBox;
        private System.Windows.Forms.GroupBox groupBoxAmis;
        private System.Windows.Forms.Button buttonAjoutCoordonneesAmies;
        private System.Windows.Forms.TextBox textBoxAjoutAmi;
        private System.Windows.Forms.ListBox listBoxAlliancesAmies;
        private System.Windows.Forms.Button buttonAjoutJoueurAmi;
        private System.Windows.Forms.Button buttonAjoutAllianceAmie;
        private System.Windows.Forms.ListBox listBoxCoordonneesAmies;
        private System.Windows.Forms.ListBox listBoxJoueursAmis;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ToolStripMenuItem lancerLaSimulationMassiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.GroupBox groupBoxParamsSimuEnMasse;
        private System.Windows.Forms.TextBox textBoxParamsSimuEnMasseNombreDeSimulations;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.GroupBox groupBoxRecherche;
        private System.Windows.Forms.Button buttonLancerLaRecherche;
        private System.Windows.Forms.ListView listViewResultatsDeRecherche;
        private System.Windows.Forms.TextBox textBoxNomARechercher;
        private System.Windows.Forms.RadioButton radioButtonChercheJoueur;
        private System.Windows.Forms.RadioButton radioButtonChercheAlliance;
        private System.Windows.Forms.ColumnHeader columnHeaderResultatRechercheCoordonnees;
        private System.Windows.Forms.ColumnHeader columnHeaderResultatRechercheNom;
        private System.Windows.Forms.ColumnHeader columnHeaderResultatRechercheAlliance;
        private System.Windows.Forms.GroupBox groupBoxServeur;
        private System.Windows.Forms.Button buttonImporter;
        private System.Windows.Forms.Label labelURL;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button buttonExporter;
        public System.Windows.Forms.ListView listViewResultats;
        private System.Windows.Forms.ToolStripMenuItem copierLeRapportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copierLeRapportsansfontToolStripMenuItem;
        private System.Windows.Forms.Button buttonConnecter;
        private System.Windows.Forms.ColumnHeader Lune;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.CheckBox checkBoxGardeMDP;
        private System.Windows.Forms.DateTimePicker dateTimePickerRecuperationRapports;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Button buttonRecupererRapports;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ToolStripButton enregistrerSousToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem envoyerLesRapportsAuServeurToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCommentaires;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxCommentaire;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemValideCommentaires;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCommentairePredefiniPasRentable;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCommentairePredefiniCoffre;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCommentairePredefiniTropPetit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCommentairePredefiniFlotteAQuai;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCommentairePredefiniPille;
        private System.Windows.Forms.CheckBox checkBoxEnregistrerEnQuittant;
        private System.Windows.Forms.ToolStripMenuItem copierLeRapportNormalToolStripMenuItem;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox textBoxFlotteAttaquanteTraqueur;
        private System.Windows.Forms.Button buttonChargerFlottePersonnalisee;
        private System.Windows.Forms.Button buttonAjouterFlottePersonnalisee;
        private System.Windows.Forms.ListView listViewFlottesPersonnalisées;
        private System.Windows.Forms.ColumnHeader columnHeaderFP_PT;
        private System.Windows.Forms.ColumnHeader columnHeaderFP_GT;
        private System.Windows.Forms.ColumnHeader columnHeaderFP_CLE;
        private System.Windows.Forms.ColumnHeader columnHeaderFP_CLO;
        private System.Windows.Forms.ColumnHeader columnHeaderFP_CR;
        private System.Windows.Forms.ColumnHeader columnHeaderFP_VB;
        private System.Windows.Forms.ColumnHeader columnHeaderFP_VC;
        private System.Windows.Forms.ColumnHeader columnHeaderFP_RC;
        private System.Windows.Forms.ColumnHeader columnHeaderFP_SE;
        private System.Windows.Forms.ColumnHeader columnHeaderFP_BB;
        private System.Windows.Forms.ColumnHeader columnHeaderFP_DS;
        private System.Windows.Forms.ColumnHeader columnHeaderFP_EM;
        private System.Windows.Forms.ColumnHeader columnHeaderFP_TR;
        private System.Windows.Forms.ColumnHeader columnHeaderFP_COOR;
        private System.Windows.Forms.ColumnHeader columnHeaderTP_A;
        private System.Windows.Forms.ColumnHeader columnHeaderTP_B;
        private System.Windows.Forms.ColumnHeader columnHeaderTP_P;
        private System.Windows.Forms.ColumnHeader columnHeaderTP_C;
        private System.Windows.Forms.ColumnHeader columnHeaderTP_I;
        private System.Windows.Forms.ColumnHeader columnHeaderTP_H;
        private System.Windows.Forms.Button buttonDescendreFlottePersonnalisee;
        private System.Windows.Forms.Button buttonSupprimerFlottePersonnalisee;
        private System.Windows.Forms.Button buttonMonterFlottePersonnalisee;
        private System.Windows.Forms.ComboBox comboBoxVitesse;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.ColumnHeader columnHeaderRatioVitesse;
        private System.Windows.Forms.ToolStripMenuItem exporterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importerToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonEnvoyerRapports;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TabPage tabPageClassement;
        public System.Windows.Forms.CheckBox checkBoxClassementJoueurVaisseaux;
        public System.Windows.Forms.CheckBox checkBoxClassementJoueurPoints;
        private System.Windows.Forms.Label label28;
        public System.Windows.Forms.CheckBox checkBoxClassementJoueurRecherches;
        private System.Windows.Forms.Button buttonEnvoyerClassements;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button buttonRecupererClassements;
        public System.Windows.Forms.CheckBox checkBoxClassementAllianceRecherches;
        public System.Windows.Forms.CheckBox checkBoxClassementAllianceVaisseaux;
        public System.Windows.Forms.CheckBox checkBoxClassementAlliancePoints;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.CheckedListBox checkedListBoxSelectionGalaxies;
        private System.Windows.Forms.TabPage tabPageNavigateur;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button buttonGO;
        private System.Windows.Forms.Button buttonActualiser;
        private System.Windows.Forms.Button buttonArreter;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonSuivant;
        private System.Windows.Forms.Button buttonPrecedant;
        private System.Windows.Forms.TextBox textBoxBarreDAdresse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.GroupBox groupBoxMiseAJour;
        private System.Windows.Forms.Button buttonLancerMiseAJour;
        private System.Windows.Forms.CheckBox checkBoxMiseAJourAutomatique;
        private System.Windows.Forms.Button buttonVerifierPresenceMiseAJour;
        private System.ComponentModel.BackgroundWorker backgroundWorkerTesterMiseAJour;
        private System.Windows.Forms.Button buttonCopierResultatRecherche;
        private System.Windows.Forms.Button buttonGereLesComptesOGSpy;
        public System.Windows.Forms.TextBox textBoxURL;
        public System.Windows.Forms.TextBox textBoxPasse;
        public System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.ColumnHeader columnHeaderResultatRecherchePresenceLune;
        private System.Windows.Forms.Button ButtonInfoserver;
    }
}

