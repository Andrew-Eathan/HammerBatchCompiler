
namespace HammerBatchCompiler
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loadvbsp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dropvmf = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.loadmap = new System.Windows.Forms.Button();
            this.gamelist = new System.Windows.Forms.ComboBox();
            this.vradlist = new System.Windows.Forms.ComboBox();
            this.vvislist = new System.Windows.Forms.ComboBox();
            this.vbsplist = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gameParams = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.loadgame = new System.Windows.Forms.Button();
            this.vradhdr = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.loadvrad = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.loadvvis = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textbox = new System.Windows.Forms.RichTextBox();
            this.stopbutton = new System.Windows.Forms.Button();
            this.compilebutton = new System.Windows.Forms.Button();
            this.mapDialog = new System.Windows.Forms.OpenFileDialog();
            this.vbspDialog = new System.Windows.Forms.OpenFileDialog();
            this.vvisDialog = new System.Windows.Forms.OpenFileDialog();
            this.vradDialog = new System.Windows.Forms.OpenFileDialog();
            this.gameDialog = new System.Windows.Forms.OpenFileDialog();
            this.compileworker = new System.ComponentModel.BackgroundWorker();
            this.label10 = new System.Windows.Forms.Label();
            this.loadgamedir = new System.Windows.Forms.Button();
            this.gamedirDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.time = new System.Windows.Forms.Label();
            this.compiletime = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.threads = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threads)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hammer Batch Compiler v1.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(42, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "by AndrewEathan";
            // 
            // loadvbsp
            // 
            this.loadvbsp.Location = new System.Drawing.Point(57, 37);
            this.loadvbsp.Name = "loadvbsp";
            this.loadvbsp.Size = new System.Drawing.Size(97, 23);
            this.loadvbsp.TabIndex = 3;
            this.loadvbsp.Text = "Load vbsp.exe";
            this.loadvbsp.UseVisualStyleBackColor = true;
            this.loadvbsp.Click += new System.EventHandler(this.loadvbsp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "VBSP";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.loadgamedir);
            this.groupBox1.Controls.Add(this.dropvmf);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.loadmap);
            this.groupBox1.Controls.Add(this.gamelist);
            this.groupBox1.Controls.Add(this.vradlist);
            this.groupBox1.Controls.Add(this.vvislist);
            this.groupBox1.Controls.Add(this.vbsplist);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.gameParams);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.loadgame);
            this.groupBox1.Controls.Add(this.vradhdr);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.loadvrad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.loadvvis);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.loadvbsp);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 257);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuration";
            // 
            // dropvmf
            // 
            this.dropvmf.AutoSize = true;
            this.dropvmf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dropvmf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dropvmf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropvmf.ForeColor = System.Drawing.Color.White;
            this.dropvmf.Location = new System.Drawing.Point(158, 17);
            this.dropvmf.Name = "dropvmf";
            this.dropvmf.Size = new System.Drawing.Size(124, 15);
            this.dropvmf.TabIndex = 24;
            this.dropvmf.Text = "Or drop .vmf on this text!";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "MAP";
            // 
            // loadmap
            // 
            this.loadmap.Location = new System.Drawing.Point(57, 13);
            this.loadmap.Name = "loadmap";
            this.loadmap.Size = new System.Drawing.Size(97, 23);
            this.loadmap.TabIndex = 22;
            this.loadmap.Text = "Load your map";
            this.loadmap.UseVisualStyleBackColor = true;
            this.loadmap.Click += new System.EventHandler(this.button2_Click);
            // 
            // gamelist
            // 
            this.gamelist.FormattingEnabled = true;
            this.gamelist.Items.AddRange(new object[] {
            "Don\'t run when done",
            "Run when done"});
            this.gamelist.Location = new System.Drawing.Point(159, 180);
            this.gamelist.Name = "gamelist";
            this.gamelist.Size = new System.Drawing.Size(121, 21);
            this.gamelist.TabIndex = 21;
            this.gamelist.Text = "Don\'t run when done";
            // 
            // vradlist
            // 
            this.vradlist.FormattingEnabled = true;
            this.vradlist.Items.AddRange(new object[] {
            "Normal",
            "Don\'t run",
            "Fast"});
            this.vradlist.Location = new System.Drawing.Point(159, 90);
            this.vradlist.Name = "vradlist";
            this.vradlist.Size = new System.Drawing.Size(121, 21);
            this.vradlist.TabIndex = 20;
            this.vradlist.Text = "Normal";
            // 
            // vvislist
            // 
            this.vvislist.FormattingEnabled = true;
            this.vvislist.Items.AddRange(new object[] {
            "Normal",
            "Don\'t run",
            "Fast"});
            this.vvislist.Location = new System.Drawing.Point(159, 65);
            this.vvislist.Name = "vvislist";
            this.vvislist.Size = new System.Drawing.Size(121, 21);
            this.vvislist.TabIndex = 19;
            this.vvislist.Text = "Normal";
            // 
            // vbsplist
            // 
            this.vbsplist.FormattingEnabled = true;
            this.vbsplist.Items.AddRange(new object[] {
            "Normal",
            "Don\'t run",
            "Only entities"});
            this.vbsplist.Location = new System.Drawing.Point(159, 38);
            this.vbsplist.Name = "vbsplist";
            this.vbsplist.Size = new System.Drawing.Size(121, 21);
            this.vbsplist.TabIndex = 18;
            this.vbsplist.Text = "Normal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Additional game parameters:\r\n";
            // 
            // gameParams
            // 
            this.gameParams.Location = new System.Drawing.Point(9, 227);
            this.gameParams.Name = "gameParams";
            this.gameParams.Size = new System.Drawing.Size(271, 20);
            this.gameParams.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "GAME";
            // 
            // loadgame
            // 
            this.loadgame.Location = new System.Drawing.Point(59, 178);
            this.loadgame.Name = "loadgame";
            this.loadgame.Size = new System.Drawing.Size(95, 23);
            this.loadgame.TabIndex = 13;
            this.loadgame.Text = "Load .exe";
            this.loadgame.UseVisualStyleBackColor = true;
            this.loadgame.Click += new System.EventHandler(this.button1_Click);
            // 
            // vradhdr
            // 
            this.vradhdr.AutoSize = true;
            this.vradhdr.Checked = true;
            this.vradhdr.CheckState = System.Windows.Forms.CheckState.Checked;
            this.vradhdr.Location = new System.Drawing.Point(173, 117);
            this.vradhdr.Name = "vradhdr";
            this.vradhdr.Size = new System.Drawing.Size(86, 17);
            this.vradhdr.TabIndex = 12;
            this.vradhdr.Text = "Enable HDR";
            this.vradhdr.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "VRAD";
            // 
            // loadvrad
            // 
            this.loadvrad.Location = new System.Drawing.Point(57, 89);
            this.loadvrad.Name = "loadvrad";
            this.loadvrad.Size = new System.Drawing.Size(97, 23);
            this.loadvrad.TabIndex = 9;
            this.loadvrad.Text = "Load vrad.exe";
            this.loadvrad.UseVisualStyleBackColor = true;
            this.loadvrad.Click += new System.EventHandler(this.loadvrad_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "VVIS";
            // 
            // loadvvis
            // 
            this.loadvvis.Location = new System.Drawing.Point(57, 63);
            this.loadvvis.Name = "loadvvis";
            this.loadvvis.Size = new System.Drawing.Size(97, 23);
            this.loadvvis.TabIndex = 6;
            this.loadvvis.Text = "Load vvis.exe";
            this.loadvvis.UseVisualStyleBackColor = true;
            this.loadvvis.Click += new System.EventHandler(this.loadvvis_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.threads);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.time);
            this.groupBox2.Controls.Add(this.textbox);
            this.groupBox2.Controls.Add(this.stopbutton);
            this.groupBox2.Controls.Add(this.compilebutton);
            this.groupBox2.Location = new System.Drawing.Point(302, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 295);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Compilation";
            // 
            // textbox
            // 
            this.textbox.BackColor = System.Drawing.Color.Black;
            this.textbox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox.ForeColor = System.Drawing.Color.White;
            this.textbox.HideSelection = false;
            this.textbox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textbox.Location = new System.Drawing.Point(6, 75);
            this.textbox.Name = "textbox";
            this.textbox.ReadOnly = true;
            this.textbox.Size = new System.Drawing.Size(404, 212);
            this.textbox.TabIndex = 3;
            this.textbox.Text = "";
            this.textbox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.textbox_LinkClicked);
            // 
            // stopbutton
            // 
            this.stopbutton.Enabled = false;
            this.stopbutton.Location = new System.Drawing.Point(93, 46);
            this.stopbutton.Name = "stopbutton";
            this.stopbutton.Size = new System.Drawing.Size(126, 23);
            this.stopbutton.TabIndex = 2;
            this.stopbutton.Text = "Force-stop compiling";
            this.stopbutton.UseVisualStyleBackColor = true;
            this.stopbutton.Click += new System.EventHandler(this.stopbutton_Click);
            // 
            // compilebutton
            // 
            this.compilebutton.Enabled = false;
            this.compilebutton.Location = new System.Drawing.Point(6, 46);
            this.compilebutton.Name = "compilebutton";
            this.compilebutton.Size = new System.Drawing.Size(81, 23);
            this.compilebutton.TabIndex = 0;
            this.compilebutton.Text = "Compile!";
            this.compilebutton.UseVisualStyleBackColor = true;
            this.compilebutton.Click += new System.EventHandler(this.compilebutton_Click);
            // 
            // mapDialog
            // 
            this.mapDialog.DefaultExt = "vmf";
            this.mapDialog.Filter = "Valve Map Files|*.vmf";
            this.mapDialog.Title = "Load your map!";
            this.mapDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.mapDialog_FileOk);
            // 
            // vbspDialog
            // 
            this.vbspDialog.DefaultExt = "exe";
            this.vbspDialog.Filter = "VBSP|vbsp.exe";
            this.vbspDialog.Title = "Load vbsp.exe!";
            this.vbspDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.vbspDialog_FileOk);
            // 
            // vvisDialog
            // 
            this.vvisDialog.DefaultExt = "exe";
            this.vvisDialog.Filter = "VVIS|vvis.exe";
            this.vvisDialog.Title = "Load vvis.exe!";
            this.vvisDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.vvisDialog_FileOk);
            // 
            // vradDialog
            // 
            this.vradDialog.DefaultExt = "exe";
            this.vradDialog.Filter = "VRAD|vrad.exe";
            this.vradDialog.Title = "Load vrad.exe!";
            this.vradDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.vradDialog_FileOk);
            // 
            // gameDialog
            // 
            this.gameDialog.DefaultExt = "exe";
            this.gameDialog.Filter = "Source Game|*.exe";
            this.gameDialog.Title = "Load a Source game!";
            this.gameDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.gameDialog_FileOk);
            // 
            // compileworker
            // 
            this.compileworker.WorkerSupportsCancellation = true;
            this.compileworker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.compileworker_DoWork);
            this.compileworker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.compileworker_RunWorkerCompleted);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "GAME";
            // 
            // loadgamedir
            // 
            this.loadgamedir.Location = new System.Drawing.Point(59, 139);
            this.loadgamedir.Name = "loadgamedir";
            this.loadgamedir.Size = new System.Drawing.Size(221, 35);
            this.loadgamedir.TabIndex = 25;
            this.loadgamedir.Text = "Load game directory (ex. GarrysMod\\garrysmod)";
            this.loadgamedir.UseVisualStyleBackColor = true;
            this.loadgamedir.Click += new System.EventHandler(this.loadgamedir_Click);
            // 
            // gamedirDialog
            // 
            this.gamedirDialog.Description = "Load your game directory";
            this.gamedirDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.gamedirDialog.ShowNewFolderButton = false;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(225, 51);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(166, 13);
            this.time.TabIndex = 4;
            this.time.Text = "Time elapsed: None, compile first!";
            // 
            // compiletime
            // 
            this.compiletime.Interval = 1000;
            this.compiletime.Tick += new System.EventHandler(this.compiletime_Tick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "Threads:";
            // 
            // threads
            // 
            this.threads.Location = new System.Drawing.Point(93, 20);
            this.threads.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.threads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.threads.Name = "threads";
            this.threads.Size = new System.Drawing.Size(126, 20);
            this.threads.TabIndex = 29;
            this.threads.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 305);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Hammer Batch Compiler v1.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threads)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loadvbsp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button loadgame;
        private System.Windows.Forms.CheckBox vradhdr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button loadvrad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button loadvvis;
        private System.Windows.Forms.TextBox gameParams;
        private System.Windows.Forms.ComboBox gamelist;
        private System.Windows.Forms.ComboBox vradlist;
        private System.Windows.Forms.ComboBox vvislist;
        private System.Windows.Forms.ComboBox vbsplist;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label dropvmf;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button loadmap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox textbox;
        private System.Windows.Forms.Button stopbutton;
        private System.Windows.Forms.Button compilebutton;
        private System.Windows.Forms.OpenFileDialog mapDialog;
        private System.Windows.Forms.OpenFileDialog vbspDialog;
        private System.Windows.Forms.OpenFileDialog vvisDialog;
        private System.Windows.Forms.OpenFileDialog vradDialog;
        private System.Windows.Forms.OpenFileDialog gameDialog;
        private System.ComponentModel.BackgroundWorker compileworker;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button loadgamedir;
        private System.Windows.Forms.FolderBrowserDialog gamedirDialog;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer compiletime;
        private System.Windows.Forms.NumericUpDown threads;
        private System.Windows.Forms.Label label9;
    }
}

