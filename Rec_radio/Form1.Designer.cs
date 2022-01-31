namespace Rec_radio
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Tree = new System.Windows.Forms.NotifyIcon(this.components);
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.delMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbpPlayer = new System.Windows.Forms.TabPage();
            this.prbAudioTrack = new Rec_radio.AudioProgressBar();
            this.trbAudio = new MetroFramework.Controls.MetroTrackBar();
            this.btnOpenDir = new System.Windows.Forms.Button();
            this.buttonStopAudio = new System.Windows.Forms.Button();
            this.listViewInfoTrack = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelTimeStop = new System.Windows.Forms.Label();
            this.labelTimeStart = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnPush = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rbtnStereo = new System.Windows.Forms.RadioButton();
            this.rbtnMono = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbDirectoryName = new System.Windows.Forms.TextBox();
            this.tbpRecord = new System.Windows.Forms.TabPage();
            this.btnFolderDir = new System.Windows.Forms.Button();
            this.chart_Animation = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnStartRec = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnStopRec = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbxCheck = new System.Windows.Forms.ComboBox();
            this.pbxFront = new System.Windows.Forms.PictureBox();
            this.lbState = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbxBack = new System.Windows.Forms.PictureBox();
            this.cmbxCapture = new System.Windows.Forms.ComboBox();
            this.cmbxKhz = new System.Windows.Forms.ComboBox();
            this.cmbxKbps = new System.Windows.Forms.ComboBox();
            this.tbcPanel = new System.Windows.Forms.TabControl();
            this.tbpSettings = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnWma = new System.Windows.Forms.RadioButton();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnRemote = new System.Windows.Forms.Button();
            this.rbtnAac = new System.Windows.Forms.RadioButton();
            this.cmbxLame = new System.Windows.Forms.ComboBox();
            this.cmbxSampleRate = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtbFileAudio = new System.Windows.Forms.TextBox();
            this.rbtnWav = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.rbtnMp3 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkDataDir = new System.Windows.Forms.CheckBox();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.listBoxInfo = new System.Windows.Forms.ListBox();
            this.contextMenuStrip.SuspendLayout();
            this.tbpPlayer.SuspendLayout();
            this.tbpRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Animation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFront)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).BeginInit();
            this.tbcPanel.SuspendLayout();
            this.tbpSettings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.TimerTick);
            // 
            // Tree
            // 
            this.Tree.Icon = ((System.Drawing.Icon)(resources.GetObject("Tree.Icon")));
            this.Tree.Text = "Rec sound";
            this.Tree.Visible = true;
            this.Tree.Click += new System.EventHandler(this.NotifyIconTree_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "note_item.png");
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip.Size = new System.Drawing.Size(129, 26);
            // 
            // delMenuItem
            // 
            this.delMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.delMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("delMenuItem.Image")));
            this.delMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delMenuItem.Name = "delMenuItem";
            this.delMenuItem.Size = new System.Drawing.Size(128, 22);
            this.delMenuItem.Text = "Delete List";
            this.delMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.delMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // tbpPlayer
            // 
            this.tbpPlayer.BackColor = System.Drawing.SystemColors.Window;
            this.tbpPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tbpPlayer.Controls.Add(this.prbAudioTrack);
            this.tbpPlayer.Controls.Add(this.trbAudio);
            this.tbpPlayer.Controls.Add(this.btnOpenDir);
            this.tbpPlayer.Controls.Add(this.buttonStopAudio);
            this.tbpPlayer.Controls.Add(this.listViewInfoTrack);
            this.tbpPlayer.Controls.Add(this.labelTimeStop);
            this.tbpPlayer.Controls.Add(this.labelTimeStart);
            this.tbpPlayer.Controls.Add(this.btnRefresh);
            this.tbpPlayer.Controls.Add(this.btnPush);
            this.tbpPlayer.Controls.Add(this.btnPause);
            this.tbpPlayer.Location = new System.Drawing.Point(4, 22);
            this.tbpPlayer.Name = "tbpPlayer";
            this.tbpPlayer.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPlayer.Size = new System.Drawing.Size(421, 273);
            this.tbpPlayer.TabIndex = 1;
            this.tbpPlayer.Text = "Player";
            // 
            // prbAudioTrack
            // 
            this.prbAudioTrack.BackColor = System.Drawing.Color.Transparent;
            this.prbAudioTrack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.prbAudioTrack.BorderColor = System.Drawing.Color.Empty;
            this.prbAudioTrack.BorderWidth = 120;
            this.prbAudioTrack.ForeColor = System.Drawing.Color.Black;
            this.prbAudioTrack.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.prbAudioTrack.Location = new System.Drawing.Point(6, 20);
            this.prbAudioTrack.MaxValue = 100;
            this.prbAudioTrack.MinValue = 0;
            this.prbAudioTrack.Name = "prbAudioTrack";
            this.prbAudioTrack.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.prbAudioTrack.ProgressTextType = Rec_radio.AudioProgressBar.AudioProgressTextType.Percent;
            this.prbAudioTrack.ShowProgressText = false;
            this.prbAudioTrack.Size = new System.Drawing.Size(410, 70);
            this.prbAudioTrack.TabIndex = 25;
            this.prbAudioTrack.Text = "AudioProgressBar";
            this.prbAudioTrack.Value = 0;
            // 
            // trbAudio
            // 
            this.trbAudio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.trbAudio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.trbAudio.Location = new System.Drawing.Point(6, 94);
            this.trbAudio.MouseWheelBarPartitions = 1;
            this.trbAudio.Name = "trbAudio";
            this.trbAudio.Size = new System.Drawing.Size(409, 10);
            this.trbAudio.TabIndex = 26;
            this.trbAudio.Text = "metroTrackBar1";
            this.trbAudio.Value = 0;
            this.trbAudio.Scroll += new System.Windows.Forms.ScrollEventHandler(this.metroTrackBar_Scroll);
            // 
            // btnOpenDir
            // 
            this.btnOpenDir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOpenDir.BackgroundImage = global::Rec_radio.Properties.Resources.folder_dir;
            this.btnOpenDir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOpenDir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenDir.FlatAppearance.BorderSize = 0;
            this.btnOpenDir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpenDir.ForeColor = System.Drawing.Color.Black;
            this.btnOpenDir.Location = new System.Drawing.Point(247, 109);
            this.btnOpenDir.Margin = new System.Windows.Forms.Padding(1);
            this.btnOpenDir.Name = "btnOpenDir";
            this.btnOpenDir.Size = new System.Drawing.Size(30, 30);
            this.btnOpenDir.TabIndex = 32;
            this.btnOpenDir.UseVisualStyleBackColor = false;
            this.btnOpenDir.Click += new System.EventHandler(this.btnClick_OpenDir);
            // 
            // buttonStopAudio
            // 
            this.buttonStopAudio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonStopAudio.BackgroundImage = global::Rec_radio.Properties.Resources.stop_list;
            this.buttonStopAudio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonStopAudio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStopAudio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStopAudio.ForeColor = System.Drawing.Color.Black;
            this.buttonStopAudio.Location = new System.Drawing.Point(183, 109);
            this.buttonStopAudio.Margin = new System.Windows.Forms.Padding(1);
            this.buttonStopAudio.Name = "buttonStopAudio";
            this.buttonStopAudio.Size = new System.Drawing.Size(30, 30);
            this.buttonStopAudio.TabIndex = 31;
            this.buttonStopAudio.UseVisualStyleBackColor = false;
            this.buttonStopAudio.Click += new System.EventHandler(this.stopMenuItem_Click);
            // 
            // listViewInfoTrack
            // 
            this.listViewInfoTrack.BackColor = System.Drawing.SystemColors.Window;
            this.listViewInfoTrack.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewInfoTrack.ContextMenuStrip = this.contextMenuStrip;
            this.listViewInfoTrack.FullRowSelect = true;
            this.listViewInfoTrack.HideSelection = false;
            this.listViewInfoTrack.LargeImageList = this.imageList;
            this.listViewInfoTrack.Location = new System.Drawing.Point(3, 143);
            this.listViewInfoTrack.Name = "listViewInfoTrack";
            this.listViewInfoTrack.Size = new System.Drawing.Size(415, 124);
            this.listViewInfoTrack.SmallImageList = this.imageList;
            this.listViewInfoTrack.TabIndex = 22;
            this.listViewInfoTrack.UseCompatibleStateImageBehavior = false;
            this.listViewInfoTrack.View = System.Windows.Forms.View.Details;
            this.listViewInfoTrack.DoubleClick += new System.EventHandler(this.playlistPlay_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 116;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Size";
            this.columnHeader2.Width = 77;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Title";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Derictory";
            this.columnHeader4.Width = 131;
            // 
            // labelTimeStop
            // 
            this.labelTimeStop.AutoSize = true;
            this.labelTimeStop.BackColor = System.Drawing.Color.Transparent;
            this.labelTimeStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimeStop.Location = new System.Drawing.Point(374, 4);
            this.labelTimeStop.Name = "labelTimeStop";
            this.labelTimeStop.Size = new System.Drawing.Size(43, 13);
            this.labelTimeStop.TabIndex = 25;
            this.labelTimeStop.Text = "0:00:00";
            // 
            // labelTimeStart
            // 
            this.labelTimeStart.AutoSize = true;
            this.labelTimeStart.BackColor = System.Drawing.Color.Transparent;
            this.labelTimeStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimeStart.Location = new System.Drawing.Point(3, 4);
            this.labelTimeStart.Name = "labelTimeStart";
            this.labelTimeStart.Size = new System.Drawing.Size(43, 13);
            this.labelTimeStart.TabIndex = 24;
            this.labelTimeStart.Text = "0:00:00";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRefresh.BackgroundImage = global::Rec_radio.Properties.Resources.updata;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(215, 109);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(1);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(30, 30);
            this.btnRefresh.TabIndex = 21;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnClick_Refresh);
            // 
            // btnPush
            // 
            this.btnPush.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPush.BackgroundImage = global::Rec_radio.Properties.Resources.play;
            this.btnPush.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPush.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPush.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPush.ForeColor = System.Drawing.Color.Black;
            this.btnPush.Location = new System.Drawing.Point(119, 109);
            this.btnPush.Margin = new System.Windows.Forms.Padding(1);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(30, 30);
            this.btnPush.TabIndex = 20;
            this.btnPush.UseVisualStyleBackColor = false;
            this.btnPush.Click += new System.EventHandler(this.playMenuItem_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPause.BackgroundImage = global::Rec_radio.Properties.Resources.pause_play;
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPause.ForeColor = System.Drawing.Color.Black;
            this.btnPause.Location = new System.Drawing.Point(151, 109);
            this.btnPause.Margin = new System.Windows.Forms.Padding(1);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(30, 30);
            this.btnPause.TabIndex = 30;
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.pauseMenuItem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Сapture";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(301, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "kbps";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(305, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "kHz";
            // 
            // rbtnStereo
            // 
            this.rbtnStereo.AutoSize = true;
            this.rbtnStereo.Location = new System.Drawing.Point(304, 87);
            this.rbtnStereo.Name = "rbtnStereo";
            this.rbtnStereo.Size = new System.Drawing.Size(56, 17);
            this.rbtnStereo.TabIndex = 20;
            this.rbtnStereo.TabStop = true;
            this.rbtnStereo.Tag = "1";
            this.rbtnStereo.Text = "Stereo";
            this.rbtnStereo.UseVisualStyleBackColor = true;
            this.rbtnStereo.CheckedChanged += new System.EventHandler(this.rbtnStereo_CheckedChanged);
            // 
            // rbtnMono
            // 
            this.rbtnMono.AutoSize = true;
            this.rbtnMono.Location = new System.Drawing.Point(246, 87);
            this.rbtnMono.Name = "rbtnMono";
            this.rbtnMono.Size = new System.Drawing.Size(52, 17);
            this.rbtnMono.TabIndex = 19;
            this.rbtnMono.TabStop = true;
            this.rbtnMono.Tag = "0";
            this.rbtnMono.Text = "Mono";
            this.rbtnMono.UseVisualStyleBackColor = true;
            this.rbtnMono.CheckedChanged += new System.EventHandler(this.rbtnMono_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Directory";
            // 
            // txtbDirectoryName
            // 
            this.txtbDirectoryName.Location = new System.Drawing.Point(62, 24);
            this.txtbDirectoryName.Name = "txtbDirectoryName";
            this.txtbDirectoryName.Size = new System.Drawing.Size(206, 20);
            this.txtbDirectoryName.TabIndex = 0;
            this.txtbDirectoryName.Text = "D:\\AUDIO\\";
            // 
            // tbpRecord
            // 
            this.tbpRecord.BackColor = System.Drawing.SystemColors.Window;
            this.tbpRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbpRecord.Controls.Add(this.btnFolderDir);
            this.tbpRecord.Controls.Add(this.chart_Animation);
            this.tbpRecord.Controls.Add(this.btnStartRec);
            this.tbpRecord.Controls.Add(this.label9);
            this.tbpRecord.Controls.Add(this.btnStopRec);
            this.tbpRecord.Controls.Add(this.label4);
            this.tbpRecord.Controls.Add(this.cmbxCheck);
            this.tbpRecord.Controls.Add(this.pbxFront);
            this.tbpRecord.Controls.Add(this.lbState);
            this.tbpRecord.Controls.Add(this.label3);
            this.tbpRecord.Controls.Add(this.pbxBack);
            this.tbpRecord.Location = new System.Drawing.Point(4, 22);
            this.tbpRecord.Name = "tbpRecord";
            this.tbpRecord.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRecord.Size = new System.Drawing.Size(421, 273);
            this.tbpRecord.TabIndex = 0;
            this.tbpRecord.Text = "Record";
            // 
            // btnFolderDir
            // 
            this.btnFolderDir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnFolderDir.BackgroundImage = global::Rec_radio.Properties.Resources.folder_dir;
            this.btnFolderDir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFolderDir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFolderDir.FlatAppearance.BorderSize = 0;
            this.btnFolderDir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFolderDir.ForeColor = System.Drawing.Color.Black;
            this.btnFolderDir.Location = new System.Drawing.Point(56, 44);
            this.btnFolderDir.Margin = new System.Windows.Forms.Padding(1);
            this.btnFolderDir.Name = "btnFolderDir";
            this.btnFolderDir.Size = new System.Drawing.Size(30, 30);
            this.btnFolderDir.TabIndex = 25;
            this.btnFolderDir.UseVisualStyleBackColor = false;
            this.btnFolderDir.Click += new System.EventHandler(this.btnClick_OpenDir);
            // 
            // chart_Animation
            // 
            this.chart_Animation.BackColor = System.Drawing.Color.Transparent;
            this.chart_Animation.BackSecondaryColor = System.Drawing.Color.Silver;
            chartArea2.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.None;
            chartArea2.AlignmentStyle = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.None;
            chartArea2.AxisY2.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.Straight;
            chartArea2.BackColor = System.Drawing.Color.White;
            chartArea2.BorderColor = System.Drawing.Color.White;
            chartArea2.Name = "ChartArea1";
            this.chart_Animation.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.HeaderSeparatorColor = System.Drawing.Color.Silver;
            legend2.ItemColumnSeparatorColor = System.Drawing.Color.Gainsboro;
            legend2.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend2.Name = "Legend1";
            legend2.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Wide;
            this.chart_Animation.Legends.Add(legend2);
            this.chart_Animation.Location = new System.Drawing.Point(3, 115);
            this.chart_Animation.Name = "chart_Animation";
            this.chart_Animation.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart_Animation.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.ForestGreen};
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Red;
            series2.LabelForeColor = System.Drawing.Color.Empty;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.YValuesPerPoint = 4;
            this.chart_Animation.Series.Add(series2);
            this.chart_Animation.Size = new System.Drawing.Size(417, 155);
            this.chart_Animation.TabIndex = 24;
            this.chart_Animation.Text = "chart1";
            // 
            // btnStartRec
            // 
            this.btnStartRec.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnStartRec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStartRec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartRec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStartRec.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.btnStartRec.ForeColor = System.Drawing.Color.Black;
            this.btnStartRec.Location = new System.Drawing.Point(48, 15);
            this.btnStartRec.Margin = new System.Windows.Forms.Padding(1);
            this.btnStartRec.Name = "btnStartRec";
            this.btnStartRec.Size = new System.Drawing.Size(38, 23);
            this.btnStartRec.TabIndex = 19;
            this.btnStartRec.Text = "REC";
            this.btnStartRec.UseVisualStyleBackColor = false;
            this.btnStartRec.Click += new System.EventHandler(this.btnClickStartRec);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "info track";
            // 
            // btnStopRec
            // 
            this.btnStopRec.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnStopRec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStopRec.BackgroundImage")));
            this.btnStopRec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStopRec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStopRec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStopRec.ForeColor = System.Drawing.Color.Black;
            this.btnStopRec.Location = new System.Drawing.Point(8, 15);
            this.btnStopRec.Margin = new System.Windows.Forms.Padding(1);
            this.btnStopRec.Name = "btnStopRec";
            this.btnStopRec.Size = new System.Drawing.Size(38, 23);
            this.btnStopRec.TabIndex = 12;
            this.btnStopRec.UseVisualStyleBackColor = false;
            this.btnStopRec.Click += new System.EventHandler(this.StopClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(207, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "labelDateTime";
            // 
            // cmbxCheck
            // 
            this.cmbxCheck.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxCheck.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbxCheck.FormattingEnabled = true;
            this.cmbxCheck.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbxCheck.Location = new System.Drawing.Point(90, 50);
            this.cmbxCheck.Name = "cmbxCheck";
            this.cmbxCheck.Size = new System.Drawing.Size(325, 21);
            this.cmbxCheck.TabIndex = 13;
            this.cmbxCheck.SelectedIndexChanged += new System.EventHandler(this.cmbx_SelectedIndexChanged);
            // 
            // pbxFront
            // 
            this.pbxFront.ErrorImage = null;
            this.pbxFront.Image = ((System.Drawing.Image)(resources.GetObject("pbxFront.Image")));
            this.pbxFront.Location = new System.Drawing.Point(91, 16);
            this.pbxFront.Name = "pbxFront";
            this.pbxFront.Size = new System.Drawing.Size(324, 14);
            this.pbxFront.TabIndex = 16;
            this.pbxFront.TabStop = false;
            // 
            // lbState
            // 
            this.lbState.AutoSize = true;
            this.lbState.BackColor = System.Drawing.Color.Transparent;
            this.lbState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbState.Location = new System.Drawing.Point(92, 34);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(36, 13);
            this.lbState.TabIndex = 15;
            this.lbState.Text = "0.00%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(345, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "RECORDING";
            this.label3.Visible = false;
            // 
            // pbxBack
            // 
            this.pbxBack.BackColor = System.Drawing.Color.LightGray;
            this.pbxBack.ErrorImage = null;
            this.pbxBack.Image = ((System.Drawing.Image)(resources.GetObject("pbxBack.Image")));
            this.pbxBack.Location = new System.Drawing.Point(90, 15);
            this.pbxBack.Name = "pbxBack";
            this.pbxBack.Size = new System.Drawing.Size(325, 17);
            this.pbxBack.TabIndex = 17;
            this.pbxBack.TabStop = false;
            // 
            // cmbxCapture
            // 
            this.cmbxCapture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxCapture.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbxCapture.FormattingEnabled = true;
            this.cmbxCapture.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbxCapture.Location = new System.Drawing.Point(62, 86);
            this.cmbxCapture.Name = "cmbxCapture";
            this.cmbxCapture.Size = new System.Drawing.Size(163, 21);
            this.cmbxCapture.TabIndex = 18;
            // 
            // cmbxKhz
            // 
            this.cmbxKhz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxKhz.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbxKhz.FormattingEnabled = true;
            this.cmbxKhz.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbxKhz.Location = new System.Drawing.Point(336, 22);
            this.cmbxKhz.Name = "cmbxKhz";
            this.cmbxKhz.Size = new System.Drawing.Size(61, 21);
            this.cmbxKhz.TabIndex = 14;
            // 
            // cmbxKbps
            // 
            this.cmbxKbps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxKbps.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbxKbps.FormattingEnabled = true;
            this.cmbxKbps.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbxKbps.Location = new System.Drawing.Point(337, 50);
            this.cmbxKbps.Name = "cmbxKbps";
            this.cmbxKbps.Size = new System.Drawing.Size(60, 21);
            this.cmbxKbps.TabIndex = 15;
            // 
            // tbcPanel
            // 
            this.tbcPanel.Controls.Add(this.tbpRecord);
            this.tbcPanel.Controls.Add(this.tbpPlayer);
            this.tbcPanel.Controls.Add(this.tbpSettings);
            this.tbcPanel.Location = new System.Drawing.Point(2, 3);
            this.tbcPanel.Multiline = true;
            this.tbcPanel.Name = "tbcPanel";
            this.tbcPanel.SelectedIndex = 0;
            this.tbcPanel.Size = new System.Drawing.Size(429, 299);
            this.tbcPanel.TabIndex = 18;
            // 
            // tbpSettings
            // 
            this.tbpSettings.Controls.Add(this.groupBox1);
            this.tbpSettings.Controls.Add(this.groupBox2);
            this.tbpSettings.Location = new System.Drawing.Point(4, 22);
            this.tbpSettings.Name = "tbpSettings";
            this.tbpSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSettings.Size = new System.Drawing.Size(421, 273);
            this.tbpSettings.TabIndex = 2;
            this.tbpSettings.Text = "Settings";
            this.tbpSettings.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnWma);
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Controls.Add(this.btnRemote);
            this.groupBox1.Controls.Add(this.rbtnAac);
            this.groupBox1.Controls.Add(this.cmbxLame);
            this.groupBox1.Controls.Add(this.cmbxSampleRate);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtbFileAudio);
            this.groupBox1.Controls.Add(this.rbtnWav);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.rbtnMp3);
            this.groupBox1.Location = new System.Drawing.Point(6, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 130);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conversion";
            // 
            // rbtnWma
            // 
            this.rbtnWma.AutoSize = true;
            this.rbtnWma.Location = new System.Drawing.Point(256, 88);
            this.rbtnWma.Name = "rbtnWma";
            this.rbtnWma.Size = new System.Drawing.Size(52, 17);
            this.rbtnWma.TabIndex = 28;
            this.rbtnWma.TabStop = true;
            this.rbtnWma.Tag = "1";
            this.rbtnWma.Text = "WMA";
            this.rbtnWma.UseVisualStyleBackColor = true;
            this.rbtnWma.CheckedChanged += new System.EventHandler(this.rbtnCheckedChanged_WmaAac);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpen.ForeColor = System.Drawing.Color.Black;
            this.btnOpen.ImageKey = "(отсутствует)";
            this.btnOpen.Location = new System.Drawing.Point(369, 42);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(28, 20);
            this.btnOpen.TabIndex = 26;
            this.btnOpen.Text = "...";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnClick_Dir);
            // 
            // btnRemote
            // 
            this.btnRemote.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRemote.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemote.BackgroundImage")));
            this.btnRemote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemote.FlatAppearance.BorderSize = 0;
            this.btnRemote.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemote.ForeColor = System.Drawing.Color.Black;
            this.btnRemote.ImageKey = "(отсутствует)";
            this.btnRemote.Location = new System.Drawing.Point(368, 92);
            this.btnRemote.Name = "btnRemote";
            this.btnRemote.Size = new System.Drawing.Size(30, 30);
            this.btnRemote.TabIndex = 16;
            this.btnRemote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemote.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnRemote.UseVisualStyleBackColor = false;
            this.btnRemote.Click += new System.EventHandler(this.btnClick_Remonte);
            // 
            // rbtnAac
            // 
            this.rbtnAac.AutoSize = true;
            this.rbtnAac.Location = new System.Drawing.Point(256, 65);
            this.rbtnAac.Name = "rbtnAac";
            this.rbtnAac.Size = new System.Drawing.Size(46, 17);
            this.rbtnAac.TabIndex = 27;
            this.rbtnAac.TabStop = true;
            this.rbtnAac.Tag = "1";
            this.rbtnAac.Text = "AAC";
            this.rbtnAac.UseVisualStyleBackColor = true;
            this.rbtnAac.CheckedChanged += new System.EventHandler(this.rbtnCheckedChanged_WmaAac);
            // 
            // cmbxLame
            // 
            this.cmbxLame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxLame.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbxLame.FormattingEnabled = true;
            this.cmbxLame.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbxLame.Location = new System.Drawing.Point(18, 84);
            this.cmbxLame.Name = "cmbxLame";
            this.cmbxLame.Size = new System.Drawing.Size(105, 21);
            this.cmbxLame.TabIndex = 18;
            // 
            // cmbxSampleRate
            // 
            this.cmbxSampleRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxSampleRate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbxSampleRate.FormattingEnabled = true;
            this.cmbxSampleRate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbxSampleRate.Location = new System.Drawing.Point(18, 42);
            this.cmbxSampleRate.Name = "cmbxSampleRate";
            this.cmbxSampleRate.Size = new System.Drawing.Size(105, 21);
            this.cmbxSampleRate.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(200, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 13);
            this.label16.TabIndex = 25;
            this.label16.Text = "Directory save";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Sample Rate";
            // 
            // txtbFileAudio
            // 
            this.txtbFileAudio.Location = new System.Drawing.Point(203, 42);
            this.txtbFileAudio.Name = "txtbFileAudio";
            this.txtbFileAudio.Size = new System.Drawing.Size(160, 20);
            this.txtbFileAudio.TabIndex = 24;
            // 
            // rbtnWav
            // 
            this.rbtnWav.AutoSize = true;
            this.rbtnWav.Location = new System.Drawing.Point(203, 65);
            this.rbtnWav.Name = "rbtnWav";
            this.rbtnWav.Size = new System.Drawing.Size(50, 17);
            this.rbtnWav.TabIndex = 21;
            this.rbtnWav.TabStop = true;
            this.rbtnWav.Tag = "1";
            this.rbtnWav.Text = "WAV";
            this.rbtnWav.UseVisualStyleBackColor = true;
            this.rbtnWav.CheckedChanged += new System.EventHandler(this.rbtnCheckedChanged_Wav);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Lame Presed";
            // 
            // rbtnMp3
            // 
            this.rbtnMp3.AutoSize = true;
            this.rbtnMp3.Location = new System.Drawing.Point(203, 88);
            this.rbtnMp3.Name = "rbtnMp3";
            this.rbtnMp3.Size = new System.Drawing.Size(47, 17);
            this.rbtnMp3.TabIndex = 22;
            this.rbtnMp3.TabStop = true;
            this.rbtnMp3.Tag = "1";
            this.rbtnMp3.Text = "MP3";
            this.rbtnMp3.UseVisualStyleBackColor = true;
            this.rbtnMp3.CheckedChanged += new System.EventHandler(this.rbtnCheckedChanged_Mp3);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkDataDir);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnSaveSettings);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtbDirectoryName);
            this.groupBox2.Controls.Add(this.cmbxCapture);
            this.groupBox2.Controls.Add(this.rbtnStereo);
            this.groupBox2.Controls.Add(this.rbtnMono);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmbxKbps);
            this.groupBox2.Controls.Add(this.cmbxKhz);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 117);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recoder";
            // 
            // checkDataDir
            // 
            this.checkDataDir.AutoSize = true;
            this.checkDataDir.Location = new System.Drawing.Point(62, 54);
            this.checkDataDir.Name = "checkDataDir";
            this.checkDataDir.Size = new System.Drawing.Size(146, 17);
            this.checkDataDir.TabIndex = 22;
            this.checkDataDir.Text = "Create data dir - YES/NO";
            this.checkDataDir.UseVisualStyleBackColor = true;
            this.checkDataDir.CheckedChanged += new System.EventHandler(this.checkDataDir_CheckedChanged);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSaveSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveSettings.BackgroundImage")));
            this.btnSaveSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSaveSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveSettings.FlatAppearance.BorderSize = 0;
            this.btnSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveSettings.ForeColor = System.Drawing.Color.Black;
            this.btnSaveSettings.ImageKey = "(отсутствует)";
            this.btnSaveSettings.Location = new System.Drawing.Point(368, 80);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(30, 30);
            this.btnSaveSettings.TabIndex = 1;
            this.btnSaveSettings.UseVisualStyleBackColor = false;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timerData_Tick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Audio.mp3";
            // 
            // listBoxInfo
            // 
            this.listBoxInfo.FormattingEnabled = true;
            this.listBoxInfo.Location = new System.Drawing.Point(6, 307);
            this.listBoxInfo.Name = "listBoxInfo";
            this.listBoxInfo.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxInfo.Size = new System.Drawing.Size(421, 95);
            this.listBoxInfo.TabIndex = 24;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.listBoxInfo);
            this.Controls.Add(this.tbcPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 450);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.Text = "Rec Radio";
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip.ResumeLayout(false);
            this.tbpPlayer.ResumeLayout(false);
            this.tbpPlayer.PerformLayout();
            this.tbpRecord.ResumeLayout(false);
            this.tbpRecord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Animation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFront)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).EndInit();
            this.tbcPanel.ResumeLayout(false);
            this.tbpSettings.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon Tree;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem delMenuItem;
        private System.Windows.Forms.TabPage tbpPlayer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbtnStereo;
        private System.Windows.Forms.RadioButton rbtnMono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbDirectoryName;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.TabPage tbpRecord;
        private System.Windows.Forms.Button btnStartRec;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnStopRec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbxFront;
        private System.Windows.Forms.Label lbState;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbxBack;
        private System.Windows.Forms.TabControl tbcPanel;
        private System.Windows.Forms.ListView listViewInfoTrack;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label labelTimeStart;
        private System.Windows.Forms.Label labelTimeStop;
        private MetroFramework.Controls.MetroTrackBar trbAudio;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button buttonStopAudio;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ComboBox cmbxCapture;
        private System.Windows.Forms.ComboBox cmbxKbps;
        private System.Windows.Forms.ComboBox cmbxKhz;
        private System.Windows.Forms.ComboBox cmbxCheck;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Animation;
        private System.Windows.Forms.TabPage tbpSettings;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnRemote;
        private System.Windows.Forms.ComboBox cmbxSampleRate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbxLame;
        private System.Windows.Forms.RadioButton rbtnMp3;
        private System.Windows.Forms.RadioButton rbtnWav;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox listBoxInfo;
        private System.Windows.Forms.TextBox txtbFileAudio;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnFolderDir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnAac;
        private System.Windows.Forms.RadioButton rbtnWma;
        private System.Windows.Forms.Button btnOpenDir;
        private AudioProgressBar prbAudioTrack;
        private System.Windows.Forms.CheckBox checkDataDir;
    }
}

