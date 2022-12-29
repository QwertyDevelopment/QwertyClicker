namespace QwertyClicker
{
    partial class QwertyClicker
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QwertyClicker));
            this.AnimateWindow = new Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow(this.components);
            this.TitleBar = new System.Windows.Forms.Label();
            this.Exit = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.Minimize = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.CPSTrackbar = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.CPSValue = new System.Windows.Forms.Label();
            this.LoggerLabel = new System.Windows.Forms.Label();
            this.Toggle = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.OnlyMinecraftSwitch = new Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
            this.ClickSoundsLabel = new System.Windows.Forms.Label();
            this.ClickSoundsSwitch = new Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
            this.OnlyMinecraftLabel = new System.Windows.Forms.Label();
            this.RPCSwitch = new Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
            this.SoundClickVolumeTrackbar = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.ClicksVolumeLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DiscordRPCLabel = new System.Windows.Forms.Label();
            this.Menu = new Siticone.Desktop.UI.WinForms.SiticoneContextMenuStrip();
            this.LinkMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DiscordLinkMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.GithubLinkMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.WebsiteLinkMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ErrorDownloading = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog();
            this.NewUpdateDialog = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog();
            this.RunUpdateError = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog();
            this.WindowShadow = new Siticone.Desktop.UI.WinForms.SiticoneShadowForm(this.components);
            this.LeftClickCheckbox = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.RightClickCheckbox = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleBar
            // 
            this.TitleBar.AutoSize = true;
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.TitleBar.Font = new System.Drawing.Font("Minecraft", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TitleBar.ForeColor = System.Drawing.Color.White;
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(838, 26);
            this.TitleBar.TabIndex = 0;
            this.TitleBar.Text = "QwertyClicker                                                                    " +
    "                                                               ";
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveWindow);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Exit.IconColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(590, 0);
            this.Exit.Name = "Exit";
            this.Exit.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Exit.Size = new System.Drawing.Size(45, 26);
            this.Exit.TabIndex = 1;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.Minimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Minimize.IconColor = System.Drawing.Color.White;
            this.Minimize.Location = new System.Drawing.Point(545, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Minimize.Size = new System.Drawing.Size(45, 26);
            this.Minimize.TabIndex = 2;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // CPSTrackbar
            // 
            this.CPSTrackbar.BackColor = System.Drawing.Color.Transparent;
            this.CPSTrackbar.Location = new System.Drawing.Point(145, 136);
            this.CPSTrackbar.Minimum = 1;
            this.CPSTrackbar.Name = "CPSTrackbar";
            this.CPSTrackbar.Size = new System.Drawing.Size(372, 29);
            this.CPSTrackbar.Style = Siticone.Desktop.UI.WinForms.Enums.TrackBarStyle.Metro;
            this.CPSTrackbar.TabIndex = 3;
            this.CPSTrackbar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.CPSTrackbar.Value = 1;
            this.CPSTrackbar.ValueChanged += new System.EventHandler(this.updateCPS);
            // 
            // CPSValue
            // 
            this.CPSValue.AutoSize = true;
            this.CPSValue.BackColor = System.Drawing.Color.Transparent;
            this.CPSValue.Font = new System.Drawing.Font("Minecraft", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CPSValue.ForeColor = System.Drawing.Color.White;
            this.CPSValue.Location = new System.Drawing.Point(523, 135);
            this.CPSValue.Name = "CPSValue";
            this.CPSValue.Size = new System.Drawing.Size(77, 26);
            this.CPSValue.TabIndex = 6;
            this.CPSValue.Text = "1 CPS";
            // 
            // LoggerLabel
            // 
            this.LoggerLabel.AutoSize = true;
            this.LoggerLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoggerLabel.Font = new System.Drawing.Font("Minecraft", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LoggerLabel.ForeColor = System.Drawing.Color.White;
            this.LoggerLabel.Location = new System.Drawing.Point(3, 301);
            this.LoggerLabel.Name = "LoggerLabel";
            this.LoggerLabel.Size = new System.Drawing.Size(167, 26);
            this.LoggerLabel.TabIndex = 8;
            this.LoggerLabel.Text = "Version 1.0.0";
            // 
            // Toggle
            // 
            this.Toggle.Animated = true;
            this.Toggle.BackColor = System.Drawing.Color.Transparent;
            this.Toggle.BorderRadius = 10;
            this.Toggle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Toggle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Toggle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Toggle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Toggle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Toggle.Font = new System.Drawing.Font("Minecraft", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Toggle.ForeColor = System.Drawing.Color.White;
            this.Toggle.Location = new System.Drawing.Point(50, 135);
            this.Toggle.Name = "Toggle";
            this.Toggle.Size = new System.Drawing.Size(84, 30);
            this.Toggle.TabIndex = 9;
            this.Toggle.Text = "Enable";
            this.Toggle.Click += new System.EventHandler(this.Toggle_Click);
            // 
            // OnlyMinecraftSwitch
            // 
            this.OnlyMinecraftSwitch.Animated = true;
            this.OnlyMinecraftSwitch.BackColor = System.Drawing.Color.Transparent;
            this.OnlyMinecraftSwitch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OnlyMinecraftSwitch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OnlyMinecraftSwitch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.OnlyMinecraftSwitch.CheckedState.InnerColor = System.Drawing.Color.White;
            this.OnlyMinecraftSwitch.Location = new System.Drawing.Point(215, 255);
            this.OnlyMinecraftSwitch.Name = "OnlyMinecraftSwitch";
            this.OnlyMinecraftSwitch.Size = new System.Drawing.Size(42, 24);
            this.OnlyMinecraftSwitch.TabIndex = 10;
            this.OnlyMinecraftSwitch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.OnlyMinecraftSwitch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.OnlyMinecraftSwitch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.OnlyMinecraftSwitch.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // ClickSoundsLabel
            // 
            this.ClickSoundsLabel.AutoSize = true;
            this.ClickSoundsLabel.BackColor = System.Drawing.Color.Transparent;
            this.ClickSoundsLabel.Font = new System.Drawing.Font("Minecraft", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClickSoundsLabel.ForeColor = System.Drawing.Color.White;
            this.ClickSoundsLabel.Location = new System.Drawing.Point(13, 225);
            this.ClickSoundsLabel.Name = "ClickSoundsLabel";
            this.ClickSoundsLabel.Size = new System.Drawing.Size(150, 22);
            this.ClickSoundsLabel.TabIndex = 12;
            this.ClickSoundsLabel.Text = "Click Sounds";
            // 
            // ClickSoundsSwitch
            // 
            this.ClickSoundsSwitch.Animated = true;
            this.ClickSoundsSwitch.BackColor = System.Drawing.Color.Transparent;
            this.ClickSoundsSwitch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ClickSoundsSwitch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ClickSoundsSwitch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ClickSoundsSwitch.CheckedState.InnerColor = System.Drawing.Color.White;
            this.ClickSoundsSwitch.Location = new System.Drawing.Point(169, 225);
            this.ClickSoundsSwitch.Name = "ClickSoundsSwitch";
            this.ClickSoundsSwitch.Size = new System.Drawing.Size(42, 24);
            this.ClickSoundsSwitch.TabIndex = 13;
            this.ClickSoundsSwitch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ClickSoundsSwitch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ClickSoundsSwitch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ClickSoundsSwitch.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.ClickSoundsSwitch.CheckedChanged += new System.EventHandler(this.DownloadSoundClicks);
            // 
            // OnlyMinecraftLabel
            // 
            this.OnlyMinecraftLabel.AutoSize = true;
            this.OnlyMinecraftLabel.BackColor = System.Drawing.Color.Transparent;
            this.OnlyMinecraftLabel.Font = new System.Drawing.Font("Minecraft", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OnlyMinecraftLabel.ForeColor = System.Drawing.Color.White;
            this.OnlyMinecraftLabel.Location = new System.Drawing.Point(13, 254);
            this.OnlyMinecraftLabel.Name = "OnlyMinecraftLabel";
            this.OnlyMinecraftLabel.Size = new System.Drawing.Size(197, 22);
            this.OnlyMinecraftLabel.TabIndex = 14;
            this.OnlyMinecraftLabel.Text = "Only in Minecraft";
            // 
            // RPCSwitch
            // 
            this.RPCSwitch.Animated = true;
            this.RPCSwitch.BackColor = System.Drawing.Color.Transparent;
            this.RPCSwitch.Checked = true;
            this.RPCSwitch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RPCSwitch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RPCSwitch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.RPCSwitch.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RPCSwitch.Location = new System.Drawing.Point(165, 193);
            this.RPCSwitch.Name = "RPCSwitch";
            this.RPCSwitch.Size = new System.Drawing.Size(42, 24);
            this.RPCSwitch.TabIndex = 15;
            this.RPCSwitch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RPCSwitch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RPCSwitch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.RPCSwitch.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.RPCSwitch.CheckedChanged += new System.EventHandler(this.RPCSwitch_Toggle);
            // 
            // SoundClickVolumeTrackbar
            // 
            this.SoundClickVolumeTrackbar.BackColor = System.Drawing.Color.Transparent;
            this.SoundClickVolumeTrackbar.Enabled = false;
            this.SoundClickVolumeTrackbar.Location = new System.Drawing.Point(303, 187);
            this.SoundClickVolumeTrackbar.Name = "SoundClickVolumeTrackbar";
            this.SoundClickVolumeTrackbar.Size = new System.Drawing.Size(293, 32);
            this.SoundClickVolumeTrackbar.TabIndex = 16;
            this.SoundClickVolumeTrackbar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.SoundClickVolumeTrackbar.Value = 100;
            this.SoundClickVolumeTrackbar.ValueChanged += new System.EventHandler(this.ChangeSoundClicksVolume);
            // 
            // ClicksVolumeLabel
            // 
            this.ClicksVolumeLabel.AutoSize = true;
            this.ClicksVolumeLabel.BackColor = System.Drawing.Color.Transparent;
            this.ClicksVolumeLabel.Font = new System.Drawing.Font("Minecraft", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClicksVolumeLabel.ForeColor = System.Drawing.Color.White;
            this.ClicksVolumeLabel.Location = new System.Drawing.Point(289, 219);
            this.ClicksVolumeLabel.Name = "ClicksVolumeLabel";
            this.ClicksVolumeLabel.Size = new System.Drawing.Size(321, 26);
            this.ClicksVolumeLabel.TabIndex = 17;
            this.ClicksVolumeLabel.Text = "Sound Clicks Volume: 100%";
            this.ClicksVolumeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("Minecraft", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(164, 37);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(243, 33);
            this.TitleLabel.TabIndex = 18;
            this.TitleLabel.Text = "QwertyClicker";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.BackColor = System.Drawing.Color.Transparent;
            this.VersionLabel.Font = new System.Drawing.Font("Minecraft", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VersionLabel.ForeColor = System.Drawing.Color.White;
            this.VersionLabel.Location = new System.Drawing.Point(400, 45);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(82, 26);
            this.VersionLabel.TabIndex = 19;
            this.VersionLabel.Text = "v1.0.0";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.DescriptionLabel.Font = new System.Drawing.Font("Minecraft", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescriptionLabel.ForeColor = System.Drawing.Color.White;
            this.DescriptionLabel.Location = new System.Drawing.Point(45, 86);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(555, 20);
            this.DescriptionLabel.TabIndex = 20;
            this.DescriptionLabel.Text = "A homemade autoclicker for Minecraft Bedrock and Java!";
            this.DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DiscordRPCLabel
            // 
            this.DiscordRPCLabel.AutoSize = true;
            this.DiscordRPCLabel.BackColor = System.Drawing.Color.Transparent;
            this.DiscordRPCLabel.Font = new System.Drawing.Font("Minecraft", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DiscordRPCLabel.ForeColor = System.Drawing.Color.White;
            this.DiscordRPCLabel.Location = new System.Drawing.Point(14, 196);
            this.DiscordRPCLabel.Name = "DiscordRPCLabel";
            this.DiscordRPCLabel.Size = new System.Drawing.Size(146, 22);
            this.DiscordRPCLabel.TabIndex = 22;
            this.DiscordRPCLabel.Text = "Discord RPC";
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Menu.Font = new System.Drawing.Font("Minecraft", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LinkMenu,
            this.UpdateMenu,
            this.ExitMenu});
            this.Menu.Name = "Menu";
            this.Menu.RenderStyle.ArrowColor = System.Drawing.Color.White;
            this.Menu.RenderStyle.BorderColor = System.Drawing.Color.White;
            this.Menu.RenderStyle.ColorTable = null;
            this.Menu.RenderStyle.RoundedEdges = true;
            this.Menu.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.Menu.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Menu.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.Menu.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.Menu.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.Menu.Size = new System.Drawing.Size(138, 76);
            // 
            // LinkMenu
            // 
            this.LinkMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DiscordLinkMenu,
            this.GithubLinkMenu,
            this.WebsiteLinkMenu});
            this.LinkMenu.ForeColor = System.Drawing.Color.White;
            this.LinkMenu.Name = "LinkMenu";
            this.LinkMenu.ShowShortcutKeys = false;
            this.LinkMenu.Size = new System.Drawing.Size(137, 24);
            this.LinkMenu.Text = "Links";
            // 
            // DiscordLinkMenu
            // 
            this.DiscordLinkMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.DiscordLinkMenu.ForeColor = System.Drawing.Color.White;
            this.DiscordLinkMenu.Name = "DiscordLinkMenu";
            this.DiscordLinkMenu.Size = new System.Drawing.Size(230, 24);
            this.DiscordLinkMenu.Text = "Discord Server";
            this.DiscordLinkMenu.Click += new System.EventHandler(this.DiscordLink_Open);
            // 
            // GithubLinkMenu
            // 
            this.GithubLinkMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.GithubLinkMenu.ForeColor = System.Drawing.Color.White;
            this.GithubLinkMenu.Name = "GithubLinkMenu";
            this.GithubLinkMenu.Size = new System.Drawing.Size(230, 24);
            this.GithubLinkMenu.Text = "Github";
            this.GithubLinkMenu.Click += new System.EventHandler(this.GithubLink_Open);
            // 
            // WebsiteLinkMenu
            // 
            this.WebsiteLinkMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.WebsiteLinkMenu.ForeColor = System.Drawing.Color.White;
            this.WebsiteLinkMenu.Name = "WebsiteLinkMenu";
            this.WebsiteLinkMenu.Size = new System.Drawing.Size(230, 24);
            this.WebsiteLinkMenu.Text = "Website";
            this.WebsiteLinkMenu.Click += new System.EventHandler(this.WebsiteLink_Open);
            // 
            // UpdateMenu
            // 
            this.UpdateMenu.ForeColor = System.Drawing.Color.White;
            this.UpdateMenu.Name = "UpdateMenu";
            this.UpdateMenu.ShowShortcutKeys = false;
            this.UpdateMenu.Size = new System.Drawing.Size(137, 24);
            this.UpdateMenu.Text = "Update";
            this.UpdateMenu.Click += new System.EventHandler(this.UpdateMenu_Click);
            // 
            // ExitMenu
            // 
            this.ExitMenu.ForeColor = System.Drawing.Color.White;
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.ShowShortcutKeys = false;
            this.ExitMenu.Size = new System.Drawing.Size(137, 24);
            this.ExitMenu.Text = "Exit";
            this.ExitMenu.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ErrorDownloading
            // 
            this.ErrorDownloading.Buttons = Siticone.Desktop.UI.WinForms.MessageDialogButtons.OK;
            this.ErrorDownloading.Caption = "Error";
            this.ErrorDownloading.Icon = Siticone.Desktop.UI.WinForms.MessageDialogIcon.Error;
            this.ErrorDownloading.Parent = null;
            this.ErrorDownloading.Style = Siticone.Desktop.UI.WinForms.MessageDialogStyle.Dark;
            this.ErrorDownloading.Text = "Unable to download files...";
            // 
            // NewUpdateDialog
            // 
            this.NewUpdateDialog.Buttons = Siticone.Desktop.UI.WinForms.MessageDialogButtons.YesNo;
            this.NewUpdateDialog.Caption = "New Update!";
            this.NewUpdateDialog.Icon = Siticone.Desktop.UI.WinForms.MessageDialogIcon.Information;
            this.NewUpdateDialog.Parent = null;
            this.NewUpdateDialog.Style = Siticone.Desktop.UI.WinForms.MessageDialogStyle.Dark;
            this.NewUpdateDialog.Text = "New update is available to download! Do you want to update now?";
            // 
            // RunUpdateError
            // 
            this.RunUpdateError.Buttons = Siticone.Desktop.UI.WinForms.MessageDialogButtons.OK;
            this.RunUpdateError.Caption = "Error!";
            this.RunUpdateError.Icon = Siticone.Desktop.UI.WinForms.MessageDialogIcon.Error;
            this.RunUpdateError.Parent = null;
            this.RunUpdateError.Style = Siticone.Desktop.UI.WinForms.MessageDialogStyle.Dark;
            this.RunUpdateError.Text = "Unable to run the new update. Possible no permission to current directory, Try ru" +
    "nning the program as administrator?";
            // 
            // WindowShadow
            // 
            this.WindowShadow.TargetForm = this;
            // 
            // LeftClickCheckbox
            // 
            this.LeftClickCheckbox.Animated = true;
            this.LeftClickCheckbox.AutoSize = true;
            this.LeftClickCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.LeftClickCheckbox.Checked = true;
            this.LeftClickCheckbox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LeftClickCheckbox.CheckedState.BorderRadius = 0;
            this.LeftClickCheckbox.CheckedState.BorderThickness = 0;
            this.LeftClickCheckbox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LeftClickCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LeftClickCheckbox.Font = new System.Drawing.Font("Minecraft", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LeftClickCheckbox.ForeColor = System.Drawing.Color.White;
            this.LeftClickCheckbox.Location = new System.Drawing.Point(293, 256);
            this.LeftClickCheckbox.Name = "LeftClickCheckbox";
            this.LeftClickCheckbox.Size = new System.Drawing.Size(109, 22);
            this.LeftClickCheckbox.TabIndex = 23;
            this.LeftClickCheckbox.Text = "Left Click";
            this.LeftClickCheckbox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.LeftClickCheckbox.UncheckedState.BorderRadius = 0;
            this.LeftClickCheckbox.UncheckedState.BorderThickness = 0;
            this.LeftClickCheckbox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.LeftClickCheckbox.UseVisualStyleBackColor = false;
            this.LeftClickCheckbox.CheckedChanged += new System.EventHandler(this.LeftClickCheckbox_CheckedChanged);
            // 
            // RightClickCheckbox
            // 
            this.RightClickCheckbox.Animated = true;
            this.RightClickCheckbox.AutoSize = true;
            this.RightClickCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.RightClickCheckbox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RightClickCheckbox.CheckedState.BorderRadius = 0;
            this.RightClickCheckbox.CheckedState.BorderThickness = 0;
            this.RightClickCheckbox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RightClickCheckbox.Enabled = false;
            this.RightClickCheckbox.Font = new System.Drawing.Font("Minecraft", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RightClickCheckbox.ForeColor = System.Drawing.Color.White;
            this.RightClickCheckbox.Location = new System.Drawing.Point(495, 255);
            this.RightClickCheckbox.Name = "RightClickCheckbox";
            this.RightClickCheckbox.Size = new System.Drawing.Size(115, 22);
            this.RightClickCheckbox.TabIndex = 24;
            this.RightClickCheckbox.Text = "Right Click";
            this.RightClickCheckbox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RightClickCheckbox.UncheckedState.BorderRadius = 0;
            this.RightClickCheckbox.UncheckedState.BorderThickness = 0;
            this.RightClickCheckbox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RightClickCheckbox.UseVisualStyleBackColor = false;
            this.RightClickCheckbox.CheckedChanged += new System.EventHandler(this.RightClickCheckbox_CheckedChanged);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 150;
            this.Timer.Tick += new System.EventHandler(this.AutoClickerTask);
            // 
            // QwertyClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QwertyClicker.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(635, 330);
            this.ControlBox = false;
            this.Controls.Add(this.RightClickCheckbox);
            this.Controls.Add(this.LeftClickCheckbox);
            this.Controls.Add(this.DiscordRPCLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.ClicksVolumeLabel);
            this.Controls.Add(this.SoundClickVolumeTrackbar);
            this.Controls.Add(this.RPCSwitch);
            this.Controls.Add(this.OnlyMinecraftLabel);
            this.Controls.Add(this.ClickSoundsSwitch);
            this.Controls.Add(this.ClickSoundsLabel);
            this.Controls.Add(this.OnlyMinecraftSwitch);
            this.Controls.Add(this.Toggle);
            this.Controls.Add(this.LoggerLabel);
            this.Controls.Add(this.CPSValue);
            this.Controls.Add(this.CPSTrackbar);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QwertyClicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QwertyClicker";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MenuPrompt);
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label TitleBar;
        private Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow AnimateWindow;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox Minimize;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox Exit;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar CPSTrackbar;
        private Label CPSValue;
        private Label LoggerLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton Toggle;
        private Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch OnlyMinecraftSwitch;
        private Label ClickSoundsLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch ClickSoundsSwitch;
        private Label OnlyMinecraftLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch RPCSwitch;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar SoundClickVolumeTrackbar;
        private Label ClicksVolumeLabel;
        private Label TitleLabel;
        private Label VersionLabel;
        private Label DescriptionLabel;
        private Label DiscordRPCLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneContextMenuStrip Menu;
        private ToolStripMenuItem LinkMenu;
        private ToolStripMenuItem DiscordLinkMenu;
        private ToolStripMenuItem GithubLinkMenu;
        private ToolStripMenuItem WebsiteLinkMenu;
        private ToolStripMenuItem UpdateMenu;
        private ToolStripMenuItem ExitMenu;
        private Siticone.Desktop.UI.WinForms.SiticoneMessageDialog ErrorDownloading;
        private Siticone.Desktop.UI.WinForms.SiticoneMessageDialog NewUpdateDialog;
        private Siticone.Desktop.UI.WinForms.SiticoneMessageDialog RunUpdateError;
        private Siticone.Desktop.UI.WinForms.SiticoneShadowForm WindowShadow;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox LeftClickCheckbox;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox RightClickCheckbox;
        private System.Windows.Forms.Timer Timer;
    }
}