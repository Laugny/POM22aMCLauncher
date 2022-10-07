namespace POM22a_MC_Launcher
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.btnStart = new Guna.UI.WinForms.GunaButton();
            this.pnlStart = new System.Windows.Forms.Panel();
            this.btnPlay = new Siticone.UI.WinForms.SiticoneButton();
            this.btnMods = new Siticone.UI.WinForms.SiticoneButton();
            this.btnNews = new Siticone.UI.WinForms.SiticoneButton();
            this.pnlMods = new System.Windows.Forms.Panel();
            this.pnlNews = new System.Windows.Forms.Panel();
            this.btnSettings = new Siticone.UI.WinForms.SiticoneButton();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMCPath = new Siticone.UI.WinForms.SiticoneTextBox();
            this.ofdMCPath = new System.Windows.Forms.OpenFileDialog();
            this.txtChangelog = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlChangelog = new System.Windows.Forms.Panel();
            this.pnlSuggestion = new System.Windows.Forms.Panel();
            this.btnSuggestion = new Siticone.UI.WinForms.SiticoneButton();
            this.btnChangelog = new Siticone.UI.WinForms.SiticoneButton();
            this.txtSuggestion = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSendSuggestion = new Siticone.UI.WinForms.SiticoneButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsername = new Siticone.UI.WinForms.SiticoneTextBox();
            this.btnSaveSettings = new Siticone.UI.WinForms.SiticoneButton();
            this.dgvMods = new Siticone.UI.WinForms.SiticoneDataGridView();
            this.mods = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCheckForUpdates = new Siticone.UI.WinForms.SiticoneButton();
            this.prgBar = new Siticone.UI.WinForms.SiticoneProgressBar();
            this.btnReloadMods = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneCirclePictureBox1 = new Siticone.UI.WinForms.SiticoneCirclePictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSelectMCPath = new System.Windows.Forms.PictureBox();
            this.pnlStart.SuspendLayout();
            this.pnlMods.SuspendLayout();
            this.pnlNews.SuspendLayout();
            this.pnlSettings.SuspendLayout();
            this.pnlChangelog.SuspendLayout();
            this.pnlSuggestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelectMCPath)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeveloper.ForeColor = System.Drawing.Color.Gray;
            this.lblDeveloper.Location = new System.Drawing.Point(643, 403);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(107, 13);
            this.lblDeveloper.TabIndex = 0;
            this.lblDeveloper.Text = "Developed by Laugny";
            // 
            // btnStart
            // 
            this.btnStart.Animated = true;
            this.btnStart.AnimationHoverSpeed = 0.03F;
            this.btnStart.AnimationSpeed = 0.03F;
            this.btnStart.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(150)))), ((int)(((byte)(79)))));
            this.btnStart.BorderColor = System.Drawing.Color.Black;
            this.btnStart.BorderSize = 2;
            this.btnStart.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnStart.FocusedColor = System.Drawing.Color.Empty;
            this.btnStart.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnStart.Image = null;
            this.btnStart.ImageSize = new System.Drawing.Size(20, 20);
            this.btnStart.Location = new System.Drawing.Point(235, 328);
            this.btnStart.Name = "btnStart";
            this.btnStart.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(150)))), ((int)(((byte)(79)))));
            this.btnStart.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnStart.OnHoverForeColor = System.Drawing.Color.White;
            this.btnStart.OnHoverImage = null;
            this.btnStart.OnPressedColor = System.Drawing.Color.Black;
            this.btnStart.Size = new System.Drawing.Size(160, 42);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pnlStart
            // 
            this.pnlStart.Controls.Add(this.btnStart);
            this.pnlStart.Controls.Add(this.pictureBox1);
            this.pnlStart.Location = new System.Drawing.Point(108, 12);
            this.pnlStart.Name = "pnlStart";
            this.pnlStart.Size = new System.Drawing.Size(631, 388);
            this.pnlStart.TabIndex = 2;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.btnPlay.ButtonMode = Siticone.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPlay.Checked = true;
            this.btnPlay.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(150)))), ((int)(((byte)(79)))));
            this.btnPlay.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.btnPlay.CheckedState.Parent = this.btnPlay;
            this.btnPlay.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnPlay.CustomBorderThickness = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnPlay.CustomImages.CheckedImage = global::POM22a_MC_Launcher.Properties.Resources.icons8_play_32;
            this.btnPlay.CustomImages.Image = global::POM22a_MC_Launcher.Properties.Resources.icons8_play_w_32;
            this.btnPlay.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPlay.CustomImages.Parent = this.btnPlay;
            this.btnPlay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.btnPlay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.HoveredState.Parent = this.btnPlay;
            this.btnPlay.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPlay.Location = new System.Drawing.Point(4, 12);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.btnPlay.PressedDepth = 0;
            this.btnPlay.ShadowDecoration.Parent = this.btnPlay;
            this.btnPlay.Size = new System.Drawing.Size(98, 28);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Play";
            this.btnPlay.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPlay.TextOffset = new System.Drawing.Point(25, 0);
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnMods
            // 
            this.btnMods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.btnMods.ButtonMode = Siticone.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.btnMods.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(150)))), ((int)(((byte)(79)))));
            this.btnMods.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.btnMods.CheckedState.Parent = this.btnMods;
            this.btnMods.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnMods.CustomBorderThickness = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnMods.CustomImages.CheckedImage = global::POM22a_MC_Launcher.Properties.Resources.icons8_services_32;
            this.btnMods.CustomImages.Image = global::POM22a_MC_Launcher.Properties.Resources.icons8_services_w_32;
            this.btnMods.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMods.CustomImages.Parent = this.btnMods;
            this.btnMods.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.btnMods.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMods.ForeColor = System.Drawing.Color.White;
            this.btnMods.HoveredState.Parent = this.btnMods;
            this.btnMods.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMods.Location = new System.Drawing.Point(4, 40);
            this.btnMods.Name = "btnMods";
            this.btnMods.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.btnMods.PressedDepth = 0;
            this.btnMods.ShadowDecoration.Parent = this.btnMods;
            this.btnMods.Size = new System.Drawing.Size(98, 28);
            this.btnMods.TabIndex = 4;
            this.btnMods.Text = "Mods";
            this.btnMods.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMods.TextOffset = new System.Drawing.Point(25, 0);
            this.btnMods.Click += new System.EventHandler(this.btnMods_Click);
            // 
            // btnNews
            // 
            this.btnNews.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.btnNews.ButtonMode = Siticone.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.btnNews.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(150)))), ((int)(((byte)(79)))));
            this.btnNews.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.btnNews.CheckedState.Parent = this.btnNews;
            this.btnNews.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnNews.CustomBorderThickness = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnNews.CustomImages.CheckedImage = global::POM22a_MC_Launcher.Properties.Resources.icons8_news_32;
            this.btnNews.CustomImages.Image = global::POM22a_MC_Launcher.Properties.Resources.icons8_news_w_32;
            this.btnNews.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNews.CustomImages.Parent = this.btnNews;
            this.btnNews.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.btnNews.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNews.ForeColor = System.Drawing.Color.White;
            this.btnNews.HoveredState.Parent = this.btnNews;
            this.btnNews.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNews.Location = new System.Drawing.Point(4, 68);
            this.btnNews.Name = "btnNews";
            this.btnNews.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.btnNews.PressedDepth = 0;
            this.btnNews.ShadowDecoration.Parent = this.btnNews;
            this.btnNews.Size = new System.Drawing.Size(98, 28);
            this.btnNews.TabIndex = 5;
            this.btnNews.Text = "News";
            this.btnNews.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNews.TextOffset = new System.Drawing.Point(25, 0);
            this.btnNews.Click += new System.EventHandler(this.btnNews_Click);
            // 
            // pnlMods
            // 
            this.pnlMods.Controls.Add(this.btnReloadMods);
            this.pnlMods.Controls.Add(this.prgBar);
            this.pnlMods.Controls.Add(this.btnCheckForUpdates);
            this.pnlMods.Controls.Add(this.dgvMods);
            this.pnlMods.Location = new System.Drawing.Point(108, 12);
            this.pnlMods.Name = "pnlMods";
            this.pnlMods.Size = new System.Drawing.Size(631, 388);
            this.pnlMods.TabIndex = 3;
            // 
            // pnlNews
            // 
            this.pnlNews.Controls.Add(this.btnSuggestion);
            this.pnlNews.Controls.Add(this.siticoneCirclePictureBox1);
            this.pnlNews.Controls.Add(this.btnChangelog);
            this.pnlNews.Controls.Add(this.pnlChangelog);
            this.pnlNews.Controls.Add(this.pnlSuggestion);
            this.pnlNews.Location = new System.Drawing.Point(105, 9);
            this.pnlNews.Name = "pnlNews";
            this.pnlNews.Size = new System.Drawing.Size(634, 391);
            this.pnlNews.TabIndex = 4;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.btnSettings.ButtonMode = Siticone.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSettings.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(150)))), ((int)(((byte)(79)))));
            this.btnSettings.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.btnSettings.CheckedState.Parent = this.btnSettings;
            this.btnSettings.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnSettings.CustomBorderThickness = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnSettings.CustomImages.CheckedImage = global::POM22a_MC_Launcher.Properties.Resources.icons8_tune_321;
            this.btnSettings.CustomImages.Image = global::POM22a_MC_Launcher.Properties.Resources.icons8_tune_w_32;
            this.btnSettings.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSettings.CustomImages.Parent = this.btnSettings;
            this.btnSettings.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.HoveredState.Parent = this.btnSettings;
            this.btnSettings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSettings.Location = new System.Drawing.Point(4, 372);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.btnSettings.PressedDepth = 0;
            this.btnSettings.ShadowDecoration.Parent = this.btnSettings;
            this.btnSettings.Size = new System.Drawing.Size(98, 28);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSettings.TextOffset = new System.Drawing.Point(25, 0);
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // pnlSettings
            // 
            this.pnlSettings.Controls.Add(this.btnSaveSettings);
            this.pnlSettings.Controls.Add(this.txtUsername);
            this.pnlSettings.Controls.Add(this.label4);
            this.pnlSettings.Controls.Add(this.btnSelectMCPath);
            this.pnlSettings.Controls.Add(this.txtMCPath);
            this.pnlSettings.Controls.Add(this.label1);
            this.pnlSettings.Location = new System.Drawing.Point(105, 9);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(634, 396);
            this.pnlSettings.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minecraft Launcher Pfad:";
            // 
            // txtMCPath
            // 
            this.txtMCPath.BorderRadius = 3;
            this.txtMCPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMCPath.DefaultText = "";
            this.txtMCPath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMCPath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMCPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMCPath.DisabledState.Parent = this.txtMCPath;
            this.txtMCPath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMCPath.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtMCPath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMCPath.FocusedState.Parent = this.txtMCPath;
            this.txtMCPath.ForeColor = System.Drawing.Color.Silver;
            this.txtMCPath.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMCPath.HoveredState.Parent = this.txtMCPath;
            this.txtMCPath.Location = new System.Drawing.Point(188, 11);
            this.txtMCPath.Name = "txtMCPath";
            this.txtMCPath.PasswordChar = '\0';
            this.txtMCPath.PlaceholderText = "";
            this.txtMCPath.ReadOnly = true;
            this.txtMCPath.SelectedText = "";
            this.txtMCPath.ShadowDecoration.Parent = this.txtMCPath;
            this.txtMCPath.Size = new System.Drawing.Size(410, 20);
            this.txtMCPath.TabIndex = 1;
            // 
            // ofdMCPath
            // 
            this.ofdMCPath.FileName = "MinecraftLauncher.exe";
            this.ofdMCPath.Filter = "Executable|*.exe";
            this.ofdMCPath.InitialDirectory = "C:\\Program Files (x86)\\Minecraft Launcher";
            this.ofdMCPath.Title = "MinecraftLauncher.exe auswählen";
            // 
            // txtChangelog
            // 
            this.txtChangelog.Location = new System.Drawing.Point(100, 24);
            this.txtChangelog.Name = "txtChangelog";
            this.txtChangelog.ReadOnly = true;
            this.txtChangelog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtChangelog.Size = new System.Drawing.Size(445, 222);
            this.txtChangelog.TabIndex = 0;
            this.txtChangelog.Text = resources.GetString("txtChangelog.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(150)))), ((int)(((byte)(79)))));
            this.label2.Location = new System.Drawing.Point(282, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Changelog";
            // 
            // pnlChangelog
            // 
            this.pnlChangelog.Controls.Add(this.txtChangelog);
            this.pnlChangelog.Controls.Add(this.label2);
            this.pnlChangelog.Location = new System.Drawing.Point(0, 137);
            this.pnlChangelog.Name = "pnlChangelog";
            this.pnlChangelog.Size = new System.Drawing.Size(631, 256);
            this.pnlChangelog.TabIndex = 3;
            // 
            // pnlSuggestion
            // 
            this.pnlSuggestion.Controls.Add(this.btnSendSuggestion);
            this.pnlSuggestion.Controls.Add(this.txtSuggestion);
            this.pnlSuggestion.Controls.Add(this.label3);
            this.pnlSuggestion.Location = new System.Drawing.Point(7, 137);
            this.pnlSuggestion.Name = "pnlSuggestion";
            this.pnlSuggestion.Size = new System.Drawing.Size(617, 254);
            this.pnlSuggestion.TabIndex = 4;
            // 
            // btnSuggestion
            // 
            this.btnSuggestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.btnSuggestion.ButtonMode = Siticone.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSuggestion.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(150)))), ((int)(((byte)(79)))));
            this.btnSuggestion.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.btnSuggestion.CheckedState.Parent = this.btnSuggestion;
            this.btnSuggestion.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnSuggestion.CustomBorderThickness = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnSuggestion.CustomImages.CheckedImage = global::POM22a_MC_Launcher.Properties.Resources.icons8_hint_32;
            this.btnSuggestion.CustomImages.Image = global::POM22a_MC_Launcher.Properties.Resources.icons8_hint_w_32;
            this.btnSuggestion.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSuggestion.CustomImages.Parent = this.btnSuggestion;
            this.btnSuggestion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.btnSuggestion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSuggestion.ForeColor = System.Drawing.Color.White;
            this.btnSuggestion.HoveredState.Parent = this.btnSuggestion;
            this.btnSuggestion.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSuggestion.Location = new System.Drawing.Point(393, 40);
            this.btnSuggestion.Name = "btnSuggestion";
            this.btnSuggestion.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.btnSuggestion.PressedDepth = 0;
            this.btnSuggestion.ShadowDecoration.Parent = this.btnSuggestion;
            this.btnSuggestion.Size = new System.Drawing.Size(113, 28);
            this.btnSuggestion.TabIndex = 8;
            this.btnSuggestion.Tag = "news";
            this.btnSuggestion.Text = "Suggestion";
            this.btnSuggestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSuggestion.TextOffset = new System.Drawing.Point(25, 0);
            this.btnSuggestion.Click += new System.EventHandler(this.btnSuggestion_Click);
            // 
            // btnChangelog
            // 
            this.btnChangelog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.btnChangelog.ButtonMode = Siticone.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.btnChangelog.Checked = true;
            this.btnChangelog.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(150)))), ((int)(((byte)(79)))));
            this.btnChangelog.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.btnChangelog.CheckedState.Parent = this.btnChangelog;
            this.btnChangelog.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnChangelog.CustomBorderThickness = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnChangelog.CustomImages.CheckedImage = global::POM22a_MC_Launcher.Properties.Resources.icons8_change_32;
            this.btnChangelog.CustomImages.Image = global::POM22a_MC_Launcher.Properties.Resources.icons8_change_w_32;
            this.btnChangelog.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnChangelog.CustomImages.Parent = this.btnChangelog;
            this.btnChangelog.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.btnChangelog.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChangelog.ForeColor = System.Drawing.Color.White;
            this.btnChangelog.HoveredState.Parent = this.btnChangelog;
            this.btnChangelog.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnChangelog.Location = new System.Drawing.Point(393, 12);
            this.btnChangelog.Name = "btnChangelog";
            this.btnChangelog.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.btnChangelog.PressedDepth = 0;
            this.btnChangelog.ShadowDecoration.Parent = this.btnChangelog;
            this.btnChangelog.Size = new System.Drawing.Size(113, 28);
            this.btnChangelog.TabIndex = 7;
            this.btnChangelog.Tag = "news";
            this.btnChangelog.Text = "Changelog";
            this.btnChangelog.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnChangelog.TextOffset = new System.Drawing.Point(25, 0);
            this.btnChangelog.Click += new System.EventHandler(this.btnChangelog_Click);
            // 
            // txtSuggestion
            // 
            this.txtSuggestion.Location = new System.Drawing.Point(93, 24);
            this.txtSuggestion.Name = "txtSuggestion";
            this.txtSuggestion.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtSuggestion.Size = new System.Drawing.Size(445, 164);
            this.txtSuggestion.TabIndex = 2;
            this.txtSuggestion.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(150)))), ((int)(((byte)(79)))));
            this.label3.Location = new System.Drawing.Point(227, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Suggestion / Empfehlung";
            // 
            // btnSendSuggestion
            // 
            this.btnSendSuggestion.CheckedState.Parent = this.btnSendSuggestion;
            this.btnSendSuggestion.CustomImages.Parent = this.btnSendSuggestion;
            this.btnSendSuggestion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(150)))), ((int)(((byte)(79)))));
            this.btnSendSuggestion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSendSuggestion.ForeColor = System.Drawing.Color.White;
            this.btnSendSuggestion.HoveredState.Parent = this.btnSendSuggestion;
            this.btnSendSuggestion.Location = new System.Drawing.Point(403, 202);
            this.btnSendSuggestion.Name = "btnSendSuggestion";
            this.btnSendSuggestion.ShadowDecoration.Parent = this.btnSendSuggestion;
            this.btnSendSuggestion.Size = new System.Drawing.Size(135, 34);
            this.btnSendSuggestion.TabIndex = 4;
            this.btnSendSuggestion.Text = "Abschicken";
            this.btnSendSuggestion.Click += new System.EventHandler(this.btnSendSuggestion_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderRadius = 3;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.Parent = this.txtUsername;
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.FocusedState.Parent = this.txtUsername;
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.HoveredState.Parent = this.txtUsername;
            this.txtUsername.Location = new System.Drawing.Point(188, 39);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderText = "";
            this.txtUsername.SelectedText = "";
            this.txtUsername.ShadowDecoration.Parent = this.txtUsername;
            this.txtUsername.Size = new System.Drawing.Size(410, 20);
            this.txtUsername.TabIndex = 4;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.BorderRadius = 3;
            this.btnSaveSettings.CheckedState.Parent = this.btnSaveSettings;
            this.btnSaveSettings.CustomImages.Parent = this.btnSaveSettings;
            this.btnSaveSettings.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(150)))), ((int)(((byte)(79)))));
            this.btnSaveSettings.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSaveSettings.ForeColor = System.Drawing.Color.White;
            this.btnSaveSettings.HoveredState.Parent = this.btnSaveSettings;
            this.btnSaveSettings.Location = new System.Drawing.Point(527, 360);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.ShadowDecoration.Parent = this.btnSaveSettings;
            this.btnSaveSettings.Size = new System.Drawing.Size(97, 25);
            this.btnSaveSettings.TabIndex = 5;
            this.btnSaveSettings.Text = "Speichern";
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // dgvMods
            // 
            this.dgvMods.AllowUserToAddRows = false;
            this.dgvMods.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.dgvMods.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvMods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMods.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvMods.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMods.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMods.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMods.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvMods.ColumnHeadersHeight = 21;
            this.dgvMods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mods});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(244)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(221)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMods.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvMods.EnableHeadersVisualStyles = false;
            this.dgvMods.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(238)))), ((int)(((byte)(208)))));
            this.dgvMods.Location = new System.Drawing.Point(7, 9);
            this.dgvMods.MultiSelect = false;
            this.dgvMods.Name = "dgvMods";
            this.dgvMods.ReadOnly = true;
            this.dgvMods.RowHeadersVisible = false;
            this.dgvMods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMods.Size = new System.Drawing.Size(618, 289);
            this.dgvMods.TabIndex = 0;
            this.dgvMods.Theme = Siticone.UI.WinForms.Enums.DataGridViewPresetThemes.Emerald;
            this.dgvMods.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.dgvMods.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMods.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMods.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMods.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMods.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvMods.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(238)))), ((int)(((byte)(208)))));
            this.dgvMods.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.dgvMods.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMods.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvMods.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMods.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMods.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvMods.ThemeStyle.ReadOnly = true;
            this.dgvMods.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(244)))), ((int)(((byte)(226)))));
            this.dgvMods.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMods.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvMods.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvMods.ThemeStyle.RowsStyle.Height = 22;
            this.dgvMods.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(221)))), ((int)(((byte)(160)))));
            this.dgvMods.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // mods
            // 
            this.mods.HeaderText = "Mods";
            this.mods.Name = "mods";
            this.mods.ReadOnly = true;
            // 
            // btnCheckForUpdates
            // 
            this.btnCheckForUpdates.BorderRadius = 3;
            this.btnCheckForUpdates.CheckedState.Parent = this.btnCheckForUpdates;
            this.btnCheckForUpdates.CustomImages.Parent = this.btnCheckForUpdates;
            this.btnCheckForUpdates.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(150)))), ((int)(((byte)(79)))));
            this.btnCheckForUpdates.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCheckForUpdates.ForeColor = System.Drawing.Color.White;
            this.btnCheckForUpdates.HoveredState.Parent = this.btnCheckForUpdates;
            this.btnCheckForUpdates.Location = new System.Drawing.Point(490, 304);
            this.btnCheckForUpdates.Name = "btnCheckForUpdates";
            this.btnCheckForUpdates.ShadowDecoration.Parent = this.btnCheckForUpdates;
            this.btnCheckForUpdates.Size = new System.Drawing.Size(135, 34);
            this.btnCheckForUpdates.TabIndex = 5;
            this.btnCheckForUpdates.Text = "Check For Updates";
            this.btnCheckForUpdates.Click += new System.EventHandler(this.btnCheckForUpdates_Click);
            // 
            // prgBar
            // 
            this.prgBar.BorderColor = System.Drawing.Color.White;
            this.prgBar.BorderRadius = 3;
            this.prgBar.BorderThickness = 2;
            this.prgBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.prgBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.prgBar.Location = new System.Drawing.Point(7, 304);
            this.prgBar.Name = "prgBar";
            this.prgBar.ProgressColor = System.Drawing.Color.Lime;
            this.prgBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.prgBar.ShadowDecoration.Parent = this.prgBar;
            this.prgBar.ShowPercentage = true;
            this.prgBar.Size = new System.Drawing.Size(477, 33);
            this.prgBar.TabIndex = 6;
            this.prgBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.prgBar.Visible = false;
            // 
            // btnReloadMods
            // 
            this.btnReloadMods.BorderRadius = 3;
            this.btnReloadMods.CheckedState.Parent = this.btnReloadMods;
            this.btnReloadMods.CustomImages.Parent = this.btnReloadMods;
            this.btnReloadMods.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(150)))), ((int)(((byte)(79)))));
            this.btnReloadMods.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnReloadMods.ForeColor = System.Drawing.Color.White;
            this.btnReloadMods.HoveredState.Parent = this.btnReloadMods;
            this.btnReloadMods.Location = new System.Drawing.Point(490, 343);
            this.btnReloadMods.Name = "btnReloadMods";
            this.btnReloadMods.ShadowDecoration.Parent = this.btnReloadMods;
            this.btnReloadMods.Size = new System.Drawing.Size(135, 34);
            this.btnReloadMods.TabIndex = 7;
            this.btnReloadMods.Text = "Reload Mods";
            this.btnReloadMods.Click += new System.EventHandler(this.btnReloadMods_Click);
            // 
            // siticoneCirclePictureBox1
            // 
            this.siticoneCirclePictureBox1.Image = global::POM22a_MC_Launcher.Properties.Resources.POM22a___Klasse_128x1281;
            this.siticoneCirclePictureBox1.Location = new System.Drawing.Point(259, 11);
            this.siticoneCirclePictureBox1.Name = "siticoneCirclePictureBox1";
            this.siticoneCirclePictureBox1.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
            this.siticoneCirclePictureBox1.ShadowDecoration.Parent = this.siticoneCirclePictureBox1;
            this.siticoneCirclePictureBox1.Size = new System.Drawing.Size(128, 128);
            this.siticoneCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.siticoneCirclePictureBox1.TabIndex = 2;
            this.siticoneCirclePictureBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POM22a_MC_Launcher.Properties.Resources.mcTitleScreen;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(625, 334);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnSelectMCPath
            // 
            this.btnSelectMCPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectMCPath.Image = global::POM22a_MC_Launcher.Properties.Resources.browse;
            this.btnSelectMCPath.Location = new System.Drawing.Point(604, 11);
            this.btnSelectMCPath.Name = "btnSelectMCPath";
            this.btnSelectMCPath.Size = new System.Drawing.Size(20, 20);
            this.btnSelectMCPath.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSelectMCPath.TabIndex = 2;
            this.btnSelectMCPath.TabStop = false;
            this.btnSelectMCPath.Click += new System.EventHandler(this.btnSelectMCPath_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(751, 417);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnNews);
            this.Controls.Add(this.btnMods);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblDeveloper);
            this.Controls.Add(this.pnlStart);
            this.Controls.Add(this.pnlSettings);
            this.Controls.Add(this.pnlNews);
            this.Controls.Add(this.pnlMods);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POM22a - Minecraft Launcher";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.pnlStart.ResumeLayout(false);
            this.pnlMods.ResumeLayout(false);
            this.pnlNews.ResumeLayout(false);
            this.pnlNews.PerformLayout();
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettings.PerformLayout();
            this.pnlChangelog.ResumeLayout(false);
            this.pnlChangelog.PerformLayout();
            this.pnlSuggestion.ResumeLayout(false);
            this.pnlSuggestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelectMCPath)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeveloper;
        private Guna.UI.WinForms.GunaButton btnStart;
        private System.Windows.Forms.Panel pnlStart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Siticone.UI.WinForms.SiticoneButton btnPlay;
        private Siticone.UI.WinForms.SiticoneButton btnMods;
        private Siticone.UI.WinForms.SiticoneButton btnNews;
        private System.Windows.Forms.Panel pnlMods;
        private System.Windows.Forms.Panel pnlNews;
        private Siticone.UI.WinForms.SiticoneButton btnSettings;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.Label label1;
        private Siticone.UI.WinForms.SiticoneTextBox txtMCPath;
        private System.Windows.Forms.PictureBox btnSelectMCPath;
        private System.Windows.Forms.OpenFileDialog ofdMCPath;
        private System.Windows.Forms.RichTextBox txtChangelog;
        private System.Windows.Forms.Label label2;
        private Siticone.UI.WinForms.SiticoneCirclePictureBox siticoneCirclePictureBox1;
        private System.Windows.Forms.Panel pnlChangelog;
        private System.Windows.Forms.Panel pnlSuggestion;
        private Siticone.UI.WinForms.SiticoneButton btnSuggestion;
        private Siticone.UI.WinForms.SiticoneButton btnChangelog;
        private System.Windows.Forms.RichTextBox txtSuggestion;
        private System.Windows.Forms.Label label3;
        private Siticone.UI.WinForms.SiticoneButton btnSendSuggestion;
        private System.Windows.Forms.Label label4;
        private Siticone.UI.WinForms.SiticoneTextBox txtUsername;
        private Siticone.UI.WinForms.SiticoneButton btnSaveSettings;
        private Siticone.UI.WinForms.SiticoneDataGridView dgvMods;
        private System.Windows.Forms.DataGridViewTextBoxColumn mods;
        private Siticone.UI.WinForms.SiticoneButton btnCheckForUpdates;
        private Siticone.UI.WinForms.SiticoneProgressBar prgBar;
        private Siticone.UI.WinForms.SiticoneButton btnReloadMods;
    }
}

