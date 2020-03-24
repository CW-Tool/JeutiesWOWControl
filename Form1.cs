// Decompiled with JetBrains decompiler
// Type: JeutieControl.Form1
// Assembly: JeutiesRepackControl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2E5953BA-597D-45EC-BE8D-6CBCB16A2C42
// Assembly location: C:\Users\hands\Desktop\FOX3.2控制器.exe

using JeutieControl.Properties;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace JeutieControl
{
  public class Form1 : Form
  {
    public const string version = "1.1";
    private IContainer components;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem fileToolStripMenuItem;
    private ToolStripMenuItem exitToolStripMenuItem;
    private ToolStripMenuItem optionsToolStripMenuItem;
    private ToolStripMenuItem KeepOnTop;
    private ToolStripMenuItem transparencyToolStripMenuItem;
    private ToolStripMenuItem Opacity100;
    private ToolStripMenuItem Opacity90;
    private ToolStripMenuItem Opacity80;
    private ToolStripMenuItem Opacity70;
    private ToolStripMenuItem Opacity60;
    private ToolStripMenuItem Opacity50;
    private TextBox MySQLPath;
    private TextBox ServerPath;
    private CheckBox AutoRestart;
    private Button startWorld;
    private Button startAuth;
    private PictureBox pictureBox1;
    private PictureBox pictureBox2;
    private Button stopWorld;
    private Button stopAuth;
    private FolderBrowserDialog ServerFolderBrowser;
    private Button ServerPathButton;
    private Button MySQLPathButton;
    private Button ApachePathButton;
    private FolderBrowserDialog SqlFolderBrowser;
    private FolderBrowserDialog ApacheFolderBrowser;
    private PictureBox pictureBox3;
    private PictureBox pictureBox4;
    private Button startMySQL;
    private Button startApache;
    private Button stopMySQL;
    private Button stopApache;
    private ToolStripMenuItem helpToolStripMenuItem;
    private ToolStripMenuItem openWorldserverConfigToolStripMenuItem;
    private ToolStripMenuItem openAuthserverConfigToolStripMenuItem;
    private ToolStripSeparator breakToolStripMenuItem;
    private RichTextBox log;
    private TextBox ApachePath;
    private ToolStripMenuItem currentOpacitySetting;
    private bool isServerPathCorrect;
    private bool isMysqlPathCorrect;
    private bool isApachePathCorrect;
    private Process authServer;
    private Process worldServer;
    private Process mySQL;
    private Process apache;
    private ProcessStartInfo authServerInfo;
    private ProcessStartInfo worldServerInfo;
    private ProcessStartInfo mySQLInfo;
    private ProcessStartInfo apacheInfo;
    private uint authServerRestartCount;

        private uint worldServerRestartCount;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWorldserverConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAuthserverConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.breakToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KeepOnTop = new System.Windows.Forms.ToolStripMenuItem();
            this.transparencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Opacity100 = new System.Windows.Forms.ToolStripMenuItem();
            this.Opacity90 = new System.Windows.Forms.ToolStripMenuItem();
            this.Opacity80 = new System.Windows.Forms.ToolStripMenuItem();
            this.Opacity70 = new System.Windows.Forms.ToolStripMenuItem();
            this.Opacity60 = new System.Windows.Forms.ToolStripMenuItem();
            this.Opacity50 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MySQLPath = new System.Windows.Forms.TextBox();
            this.ServerPath = new System.Windows.Forms.TextBox();
            this.AutoRestart = new System.Windows.Forms.CheckBox();
            this.startWorld = new System.Windows.Forms.Button();
            this.startAuth = new System.Windows.Forms.Button();
            this.stopWorld = new System.Windows.Forms.Button();
            this.stopAuth = new System.Windows.Forms.Button();
            this.ServerFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.ServerPathButton = new System.Windows.Forms.Button();
            this.MySQLPathButton = new System.Windows.Forms.Button();
            this.ApachePathButton = new System.Windows.Forms.Button();
            this.SqlFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.ApacheFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.startMySQL = new System.Windows.Forms.Button();
            this.startApache = new System.Windows.Forms.Button();
            this.stopMySQL = new System.Windows.Forms.Button();
            this.stopApache = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.log = new System.Windows.Forms.RichTextBox();
            this.ApachePath = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openWorldserverConfigToolStripMenuItem,
            this.openAuthserverConfigToolStripMenuItem,
            this.breakToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // openWorldserverConfigToolStripMenuItem
            // 
            this.openWorldserverConfigToolStripMenuItem.Name = "openWorldserverConfigToolStripMenuItem";
            resources.ApplyResources(this.openWorldserverConfigToolStripMenuItem, "openWorldserverConfigToolStripMenuItem");
            this.openWorldserverConfigToolStripMenuItem.Click += new System.EventHandler(this.openWorldserverConfigToolStripMenuItem_Click);
            // 
            // openAuthserverConfigToolStripMenuItem
            // 
            this.openAuthserverConfigToolStripMenuItem.Name = "openAuthserverConfigToolStripMenuItem";
            resources.ApplyResources(this.openAuthserverConfigToolStripMenuItem, "openAuthserverConfigToolStripMenuItem");
            this.openAuthserverConfigToolStripMenuItem.Click += new System.EventHandler(this.openAuthserverConfigToolStripMenuItem_Click);
            // 
            // breakToolStripMenuItem
            // 
            this.breakToolStripMenuItem.Name = "breakToolStripMenuItem";
            resources.ApplyResources(this.breakToolStripMenuItem, "breakToolStripMenuItem");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.KeepOnTop,
            this.transparencyToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            resources.ApplyResources(this.optionsToolStripMenuItem, "optionsToolStripMenuItem");
            // 
            // KeepOnTop
            // 
            this.KeepOnTop.CheckOnClick = true;
            this.KeepOnTop.Name = "KeepOnTop";
            resources.ApplyResources(this.KeepOnTop, "KeepOnTop");
            this.KeepOnTop.Click += new System.EventHandler(this.KeepOnTop_Click);
            // 
            // transparencyToolStripMenuItem
            // 
            this.transparencyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Opacity100,
            this.Opacity90,
            this.Opacity80,
            this.Opacity70,
            this.Opacity60,
            this.Opacity50});
            this.transparencyToolStripMenuItem.Name = "transparencyToolStripMenuItem";
            resources.ApplyResources(this.transparencyToolStripMenuItem, "transparencyToolStripMenuItem");
            // 
            // Opacity100
            // 
            this.Opacity100.Checked = true;
            this.Opacity100.CheckOnClick = true;
            this.Opacity100.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Opacity100.Name = "Opacity100";
            resources.ApplyResources(this.Opacity100, "Opacity100");
            this.Opacity100.Click += new System.EventHandler(this.Opacity100_Click);
            // 
            // Opacity90
            // 
            this.Opacity90.CheckOnClick = true;
            this.Opacity90.Name = "Opacity90";
            resources.ApplyResources(this.Opacity90, "Opacity90");
            this.Opacity90.Click += new System.EventHandler(this.Opacity90_Click);
            // 
            // Opacity80
            // 
            this.Opacity80.CheckOnClick = true;
            this.Opacity80.Name = "Opacity80";
            resources.ApplyResources(this.Opacity80, "Opacity80");
            this.Opacity80.Click += new System.EventHandler(this.Opacity80_Click);
            // 
            // Opacity70
            // 
            this.Opacity70.CheckOnClick = true;
            this.Opacity70.Name = "Opacity70";
            resources.ApplyResources(this.Opacity70, "Opacity70");
            this.Opacity70.Click += new System.EventHandler(this.Opacity70_Click);
            // 
            // Opacity60
            // 
            this.Opacity60.CheckOnClick = true;
            this.Opacity60.Name = "Opacity60";
            resources.ApplyResources(this.Opacity60, "Opacity60");
            this.Opacity60.Click += new System.EventHandler(this.Opacity60_Click);
            // 
            // Opacity50
            // 
            this.Opacity50.CheckOnClick = true;
            this.Opacity50.Name = "Opacity50";
            resources.ApplyResources(this.Opacity50, "Opacity50");
            this.Opacity50.Click += new System.EventHandler(this.Opacity50_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // MySQLPath
            // 
            this.MySQLPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.MySQLPath, "MySQLPath");
            this.MySQLPath.Name = "MySQLPath";
            this.MySQLPath.ReadOnly = true;
            // 
            // ServerPath
            // 
            this.ServerPath.AllowDrop = true;
            this.ServerPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.ServerPath, "ServerPath");
            this.ServerPath.Name = "ServerPath";
            this.ServerPath.ReadOnly = true;
            // 
            // AutoRestart
            // 
            resources.ApplyResources(this.AutoRestart, "AutoRestart");
            this.AutoRestart.Name = "AutoRestart";
            this.AutoRestart.UseVisualStyleBackColor = true;
            // 
            // startWorld
            // 
            this.startWorld.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.startWorld, "startWorld");
            this.startWorld.Name = "startWorld";
            this.startWorld.UseVisualStyleBackColor = false;
            this.startWorld.Click += new System.EventHandler(this.startWorld_Click);
            // 
            // startAuth
            // 
            this.startAuth.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.startAuth, "startAuth");
            this.startAuth.Name = "startAuth";
            this.startAuth.UseVisualStyleBackColor = false;
            this.startAuth.Click += new System.EventHandler(this.startAuth_Click);
            // 
            // stopWorld
            // 
            this.stopWorld.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.stopWorld, "stopWorld");
            this.stopWorld.Name = "stopWorld";
            this.stopWorld.UseVisualStyleBackColor = false;
            this.stopWorld.Click += new System.EventHandler(this.stopWorld_Click);
            // 
            // stopAuth
            // 
            this.stopAuth.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.stopAuth, "stopAuth");
            this.stopAuth.Name = "stopAuth";
            this.stopAuth.UseVisualStyleBackColor = false;
            this.stopAuth.Click += new System.EventHandler(this.stopAuth_Click);
            // 
            // ServerPathButton
            // 
            resources.ApplyResources(this.ServerPathButton, "ServerPathButton");
            this.ServerPathButton.Name = "ServerPathButton";
            this.ServerPathButton.UseVisualStyleBackColor = true;
            this.ServerPathButton.Click += new System.EventHandler(this.ServerPathButton_Click);
            // 
            // MySQLPathButton
            // 
            resources.ApplyResources(this.MySQLPathButton, "MySQLPathButton");
            this.MySQLPathButton.Name = "MySQLPathButton";
            this.MySQLPathButton.UseVisualStyleBackColor = true;
            this.MySQLPathButton.Click += new System.EventHandler(this.MySQLPathButton_Click);
            // 
            // ApachePathButton
            // 
            resources.ApplyResources(this.ApachePathButton, "ApachePathButton");
            this.ApachePathButton.Name = "ApachePathButton";
            this.ApachePathButton.UseVisualStyleBackColor = true;
            this.ApachePathButton.Click += new System.EventHandler(this.ApachePathButton_Click);
            // 
            // startMySQL
            // 
            resources.ApplyResources(this.startMySQL, "startMySQL");
            this.startMySQL.Name = "startMySQL";
            this.startMySQL.UseVisualStyleBackColor = true;
            this.startMySQL.Click += new System.EventHandler(this.startMySQL_Click);
            // 
            // startApache
            // 
            resources.ApplyResources(this.startApache, "startApache");
            this.startApache.Name = "startApache";
            this.startApache.UseVisualStyleBackColor = true;
            this.startApache.Click += new System.EventHandler(this.startApache_Click);
            // 
            // stopMySQL
            // 
            resources.ApplyResources(this.stopMySQL, "stopMySQL");
            this.stopMySQL.Name = "stopMySQL";
            this.stopMySQL.UseVisualStyleBackColor = true;
            this.stopMySQL.Click += new System.EventHandler(this.stopMySQL_Click);
            // 
            // stopApache
            // 
            resources.ApplyResources(this.stopApache, "stopApache");
            this.stopApache.Name = "stopApache";
            this.stopApache.UseVisualStyleBackColor = true;
            this.stopApache.Click += new System.EventHandler(this.stopApache_Click);
            // 
            // pictureBox4
            // 
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.SystemColors.Info;
            this.log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.log, "log");
            this.log.Name = "log";
            this.log.ReadOnly = true;
            // 
            // ApachePath
            // 
            this.ApachePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.ApachePath, "ApachePath");
            this.ApachePath.Name = "ApachePath";
            this.ApachePath.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.ServerPathButton);
            this.Controls.Add(this.ApachePath);
            this.Controls.Add(this.log);
            this.Controls.Add(this.MySQLPath);
            this.Controls.Add(this.stopApache);
            this.Controls.Add(this.stopMySQL);
            this.Controls.Add(this.ApachePathButton);
            this.Controls.Add(this.ServerPath);
            this.Controls.Add(this.MySQLPathButton);
            this.Controls.Add(this.startApache);
            this.Controls.Add(this.startMySQL);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.stopAuth);
            this.Controls.Add(this.stopWorld);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.startAuth);
            this.Controls.Add(this.startWorld);
            this.Controls.Add(this.AutoRestart);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    public Form1()
    {
      this.InitializeComponent();
      this.currentOpacitySetting = this.Opacity100;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this.log.Text = "Welcome to Jeutie's Blizzlike Repack Control Panel v1.1!";
      this.CheckForNewMachine();
      this.ServerPath.Text = Settings.Default.ServerPath;
      this.ApachePath.Text = Settings.Default.ApachePath;
      this.MySQLPath.Text = Settings.Default.MySQLPath;
      this.KeepOnTop.Checked = Settings.Default.KeepOnTop;
      this.authServerRestartCount = 0U;
      this.worldServerRestartCount = 0U;
      this.authServerInfo = new ProcessStartInfo("authserver.exe");
      this.worldServerInfo = new ProcessStartInfo("worldserver.exe");
      this.mySQLInfo = new ProcessStartInfo("mysqld.exe");
      this.apacheInfo = new ProcessStartInfo("httpd.exe");
      this.mySQLInfo.Arguments = "--defaults-file=my.ini";
      this.worldServer = new Process();
      this.authServer = new Process();
      this.mySQL = new Process();
      this.apache = new Process();
      this.worldServer.StartInfo = this.worldServerInfo;
      this.authServer.StartInfo = this.authServerInfo;
      this.mySQL.StartInfo = this.mySQLInfo;
      this.apache.StartInfo = this.apacheInfo;
      this.apache.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
      this.mySQL.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
      this.worldServer.EnableRaisingEvents = true;
      this.worldServer.Exited += new EventHandler(this.autoRestartWorldServer);
      this.authServer.EnableRaisingEvents = true;
      this.authServer.Exited += new EventHandler(this.autoRestartAuthServer);
      this.CheckPaths();
    }

    private void CheckForNewMachine()
    {
      if (!(Settings.Default.MachineName != Environment.MachineName))
        return;
      Settings.Default.ServerPath = "Path has not been set yet!";
      Settings.Default.ApachePath = "Path has not been set yet!";
      Settings.Default.MySQLPath = "Path has not been set yet!";
      Settings.Default.KeepOnTop = false;
      Settings.Default.MachineName = Environment.MachineName;
      Settings.Default.Save();
    }

    private void autoRestartAuthServer(object sender, EventArgs e)
    {
      if (this.AutoRestart.Checked)
      {
        if (!this.isServerPathCorrect)
          return;
        this.authServer.Start();
        ++this.authServerRestartCount;
        this.Log("Stopped the Auth server.  Restarting...");
      }
      else
        this.Log("Stopped the Auth server.");
    }

    private void autoRestartWorldServer(object sender, EventArgs e)
    {
      if (this.AutoRestart.Checked)
      {
        if (!this.isServerPathCorrect)
          return;
        this.worldServer.Start();
        ++this.worldServerRestartCount;
        this.Log("Stopped the World server.  Restarting...");
      }
      else
        this.Log("Stopped the World server.");
    }

    private void ChangeOpacity(object menuSelection, double opacity)
    {
      this.Opacity = opacity;
      this.currentOpacitySetting.Checked = false;
      this.currentOpacitySetting = (ToolStripMenuItem) menuSelection;
      this.currentOpacitySetting.Checked = true;
    }

    private void Opacity100_Click(object sender, EventArgs e)
    {
      this.ChangeOpacity(sender, 1.0);
    }

    private void Opacity90_Click(object sender, EventArgs e)
    {
      this.ChangeOpacity(sender, 0.9);
    }

    private void Opacity80_Click(object sender, EventArgs e)
    {
      this.ChangeOpacity(sender, 0.8);
    }

    private void Opacity70_Click(object sender, EventArgs e)
    {
      this.ChangeOpacity(sender, 0.7);
    }

    private void Opacity60_Click(object sender, EventArgs e)
    {
      this.ChangeOpacity(sender, 0.6);
    }

    private void Opacity50_Click(object sender, EventArgs e)
    {
      this.ChangeOpacity(sender, 0.5);
    }

    private void KeepOnTop_Click(object sender, EventArgs e)
    {
      this.TopMost = ((ToolStripMenuItem) sender).Checked;
      Settings.Default.KeepOnTop = this.TopMost;
      Settings.Default.Save();
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void ServerPathButton_Click(object sender, EventArgs e)
    {
      int num = (int) this.ServerFolderBrowser.ShowDialog();
      if (this.ServerFolderBrowser.SelectedPath != "")
      {
        this.ServerPath.Text = this.ServerFolderBrowser.SelectedPath;
        Settings.Default.ServerPath = this.ServerFolderBrowser.SelectedPath;
        Settings.Default.Save();
      }
      this.CheckPaths();
    }

    private void MySQLPathButton_Click(object sender, EventArgs e)
    {
      int num = (int) this.SqlFolderBrowser.ShowDialog();
      if (this.SqlFolderBrowser.SelectedPath != "")
      {
        this.MySQLPath.Text = this.SqlFolderBrowser.SelectedPath;
        Settings.Default.MySQLPath = this.SqlFolderBrowser.SelectedPath;
        Settings.Default.Save();
      }
      this.CheckPaths();
    }

    private void ApachePathButton_Click(object sender, EventArgs e)
    {
      int num = (int) this.ApacheFolderBrowser.ShowDialog();
      if (this.ApacheFolderBrowser.SelectedPath != "")
      {
        this.ApachePath.Text = this.ApacheFolderBrowser.SelectedPath;
        Settings.Default.ApachePath = this.ApacheFolderBrowser.SelectedPath;
        Settings.Default.Save();
      }
      this.CheckPaths();
    }

    private void CheckPaths()
    {
      if (File.Exists(this.ServerPath.Text + "\\authserver.exe") && File.Exists(this.ServerPath.Text + "\\worldserver.exe"))
      {
        this.isServerPathCorrect = true;
        this.ServerPath.BackColor = Color.LightGreen;
        this.startWorld.Enabled = true;
        this.startAuth.Enabled = true;
        this.stopWorld.Enabled = true;
        this.stopAuth.Enabled = true;
        this.AutoRestart.Enabled = true;
        this.worldServerInfo.WorkingDirectory = this.ServerPath.Text;
        this.authServerInfo.WorkingDirectory = this.ServerPath.Text;
      }
      else
      {
        this.isServerPathCorrect = false;
        this.ServerPath.BackColor = Color.LightCoral;
        this.startWorld.Enabled = false;
        this.startAuth.Enabled = false;
        this.stopWorld.Enabled = false;
        this.stopAuth.Enabled = false;
        this.AutoRestart.Enabled = false;
      }
      if (File.Exists(this.MySQLPath.Text + "\\mysqld.exe"))
      {
        this.isMysqlPathCorrect = true;
        this.MySQLPath.BackColor = Color.LightGreen;
        this.startMySQL.Enabled = true;
        this.stopMySQL.Enabled = true;
        this.mySQLInfo.WorkingDirectory = this.MySQLPath.Text;
      }
      else
      {
        this.isMysqlPathCorrect = false;
        this.MySQLPath.BackColor = Color.LightCoral;
        this.startMySQL.Enabled = false;
        this.stopMySQL.Enabled = false;
      }
      if (File.Exists(this.ApachePath.Text + "\\httpd.exe"))
      {
        this.isApachePathCorrect = true;
        this.ApachePath.BackColor = Color.LightGreen;
        this.startApache.Enabled = true;
        this.stopApache.Enabled = true;
        this.apacheInfo.WorkingDirectory = this.ApachePath.Text;
      }
      else
      {
        this.isApachePathCorrect = false;
        this.ApachePath.BackColor = Color.LightCoral;
        this.startApache.Enabled = false;
        this.stopApache.Enabled = false;
      }
    }


    private void startWorld_Click(object sender, EventArgs e)
    {
      try
      {
        if (!this.worldServer.HasExited)
          return;
        this.CheckPaths();
        if (!this.isServerPathCorrect)
          return;
        this.worldServer.Start();
        this.Log("Started the World server.");
      }
      catch (InvalidOperationException ex)
      {
        this.worldServer.Start();
        this.Log("Started the World server.");
      }
    }

    private void stopWorld_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.worldServer.HasExited)
          return;
        this.worldServer.Kill();
      }
      catch (InvalidOperationException ex)
      {
      }
    }

    private void startAuth_Click(object sender, EventArgs e)
    {
      try
      {
        if (!this.authServer.HasExited)
          return;
        this.CheckPaths();
        if (!this.isServerPathCorrect)
          return;
        this.authServer.Start();
        this.Log("Started the Auth server.");
      }
      catch (InvalidOperationException ex)
      {
        this.authServer.Start();
        this.Log("Started the Auth server.");
      }
    }

    private void stopAuth_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.authServer.HasExited)
          return;
        this.authServer.Kill();
      }
      catch (InvalidOperationException ex)
      {
      }
    }

    private void startMySQL_Click(object sender, EventArgs e)
    {
      if (this.IsProcessRunning("mysqld"))
        return;
      this.mySQL.Start();
      this.Log("Started the MySQL server.");
    }

    private void stopMySQL_Click(object sender, EventArgs e)
    {
      if (!this.KillProcess("mysqld"))
        return;
      this.Log("Stopped the MySQL server.");
    }

    private void startApache_Click(object sender, EventArgs e)
    {
      try
      {
        if (!this.apache.HasExited)
          return;
        this.CheckPaths();
        if (!this.isApachePathCorrect)
          return;
        this.apache.Start();
        this.Log("Started the Apache server.");
      }
      catch (InvalidOperationException ex)
      {
        this.apache.Start();
        this.Log("Started the Apache server.");
      }
    }

    private void stopApache_Click(object sender, EventArgs e)
    {
      try
      {
        if (!this.apache.HasExited)
        {
          this.apache.Kill();
          this.Log("Stopped the Apache server.");
        }
      }
      catch (InvalidOperationException ex)
      {
      }
      this.KillProcess("httpd");
    }

    private bool IsProcessRunning(string processName)
    {
      return Process.GetProcessesByName(processName).Length != 0;
    }

    private bool KillProcess(string processName)
    {
      Process[] processesByName = Process.GetProcessesByName(processName);
      bool flag = false;
      foreach (Process process in processesByName)
      {
        try
        {
          process.Kill();
          flag = true;
        }
        catch (Win32Exception ex)
        {
        }
      }
      return flag;
    }

    private void helpToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int num = (int) new Help().ShowDialog();
    }

    private void openWorldserverConfigToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.isServerPathCorrect)
        Process.Start("notepad.exe", this.ServerPath.Text + "\\worldserver.conf");
      else
        this.Log("Error!  Can't open the config file, incorrect server path.");
    }

    private void openAuthserverConfigToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.isServerPathCorrect)
        Process.Start("notepad.exe", this.ServerPath.Text + "\\authserver.conf");
      else
        this.Log("Error!  Can't open the config file, incorrect server path.");
    }

    private void Log(string text)
    {
      if (this.log.InvokeRequired)
      {
        this.Invoke((Delegate) new Form1.SetLogCallback(this.Log), (object) text);
      }
      else
      {
        this.log.AppendText("\n[" + DateTime.Now.ToString("hh:mm:ss tt") + "] " + text);
        this.log.ScrollToCaret();
      }
    }

    private delegate void SetLogCallback(string text);
  }
}
