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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Tree = new System.Windows.Forms.NotifyIcon(this.components);
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.delMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.audioPogressBar = new Rec_radio.AudioProgressBar();
            this.trackBarAudio = new MetroFramework.Controls.MetroTrackBar();
            this.buttonOpenDir = new System.Windows.Forms.Button();
            this.buttonStopAudio = new System.Windows.Forms.Button();
            this.listViewInfoTrack = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelTimeStop = new System.Windows.Forms.Label();
            this.labelTimeStart = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonPush = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButtonStereo = new System.Windows.Forms.RadioButton();
            this.radioButtonMono = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.directoryName = new System.Windows.Forms.TextBox();
            this.Record = new System.Windows.Forms.TabPage();
            this.folderDir = new System.Windows.Forms.Button();
            this.chart_Animation = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonStartRec = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonStopRec = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCheck = new System.Windows.Forms.ComboBox();
            this.labelState = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxFront = new System.Windows.Forms.PictureBox();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.comboBoxCapture = new System.Windows.Forms.ComboBox();
            this.comboBoxKhz = new System.Windows.Forms.ComboBox();
            this.comboBoxKbps = new System.Windows.Forms.ComboBox();
            this.panelSettingPlayer = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonWma = new System.Windows.Forms.RadioButton();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonRemote = new System.Windows.Forms.Button();
            this.radioButtonAac = new System.Windows.Forms.RadioButton();
            this.comboBoxLame = new System.Windows.Forms.ComboBox();
            this.comboBoxSampleRate = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxFileAudio = new System.Windows.Forms.TextBox();
            this.radioButtonWav = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.radioButtonMp3 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkDataDir = new System.Windows.Forms.CheckBox();
            this.buttonSaveSettings = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.listBoxInfo = new System.Windows.Forms.ListBox();
            this.contextMenuStrip.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.Record.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Animation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFront)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.panelSettingPlayer.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer_Tick);
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
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage2.Controls.Add(this.audioPogressBar);
            this.tabPage2.Controls.Add(this.trackBarAudio);
            this.tabPage2.Controls.Add(this.buttonOpenDir);
            this.tabPage2.Controls.Add(this.buttonStopAudio);
            this.tabPage2.Controls.Add(this.listViewInfoTrack);
            this.tabPage2.Controls.Add(this.labelTimeStop);
            this.tabPage2.Controls.Add(this.labelTimeStart);
            this.tabPage2.Controls.Add(this.buttonRefresh);
            this.tabPage2.Controls.Add(this.buttonPush);
            this.tabPage2.Controls.Add(this.buttonPause);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(421, 273);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Player";
            // 
            // audioPogressBar
            // 
            this.audioPogressBar.BackColor = System.Drawing.Color.Transparent;
            this.audioPogressBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.audioPogressBar.BorderColor = System.Drawing.Color.Empty;
            this.audioPogressBar.BorderWidth = 120;
            this.audioPogressBar.ForeColor = System.Drawing.Color.Black;
            this.audioPogressBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.audioPogressBar.Location = new System.Drawing.Point(6, 20);
            this.audioPogressBar.MaxValue = 100;
            this.audioPogressBar.MinValue = 0;
            this.audioPogressBar.Name = "audioPogressBar";
            this.audioPogressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.audioPogressBar.ProgressTextType = Rec_radio.AudioProgressBar.AudioProgressTextType.Percent;
            this.audioPogressBar.ShowProgressText = false;
            this.audioPogressBar.Size = new System.Drawing.Size(409, 70);
            this.audioPogressBar.TabIndex = 25;
            this.audioPogressBar.Text = "AudioProgressBar";
            this.audioPogressBar.Value = 0;
            // 
            // trackBarAudio
            // 
            this.trackBarAudio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.trackBarAudio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.trackBarAudio.Location = new System.Drawing.Point(6, 94);
            this.trackBarAudio.MouseWheelBarPartitions = 1;
            this.trackBarAudio.Name = "trackBarAudio";
            this.trackBarAudio.Size = new System.Drawing.Size(409, 10);
            this.trackBarAudio.TabIndex = 26;
            this.trackBarAudio.Text = "metroTrackBar1";
            this.trackBarAudio.Value = 0;
            this.trackBarAudio.Scroll += new System.Windows.Forms.ScrollEventHandler(this.MetroTrackBar_Scroll);
            // 
            // buttonOpenDir
            // 
            this.buttonOpenDir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonOpenDir.BackgroundImage = global::Rec_radio.Properties.Resources.folder_dir;
            this.buttonOpenDir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonOpenDir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenDir.FlatAppearance.BorderSize = 0;
            this.buttonOpenDir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOpenDir.ForeColor = System.Drawing.Color.Black;
            this.buttonOpenDir.Location = new System.Drawing.Point(247, 109);
            this.buttonOpenDir.Margin = new System.Windows.Forms.Padding(1);
            this.buttonOpenDir.Name = "buttonOpenDir";
            this.buttonOpenDir.Size = new System.Drawing.Size(30, 30);
            this.buttonOpenDir.TabIndex = 32;
            this.buttonOpenDir.UseVisualStyleBackColor = false;
            this.buttonOpenDir.Click += new System.EventHandler(this.Button_Click_OpenDir);
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
            this.buttonStopAudio.Click += new System.EventHandler(this.Stop_Menu_Item_Click);
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
            this.listViewInfoTrack.DoubleClick += new System.EventHandler(this.Playlist_Play_Click);
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
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonRefresh.BackgroundImage = global::Rec_radio.Properties.Resources.updata;
            this.buttonRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRefresh.FlatAppearance.BorderSize = 0;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRefresh.ForeColor = System.Drawing.Color.Black;
            this.buttonRefresh.Location = new System.Drawing.Point(215, 109);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(1);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(30, 30);
            this.buttonRefresh.TabIndex = 21;
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.Button_Click_Refresh);
            // 
            // buttonPush
            // 
            this.buttonPush.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonPush.BackgroundImage = global::Rec_radio.Properties.Resources.play;
            this.buttonPush.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPush.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPush.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPush.ForeColor = System.Drawing.Color.Black;
            this.buttonPush.Location = new System.Drawing.Point(119, 109);
            this.buttonPush.Margin = new System.Windows.Forms.Padding(1);
            this.buttonPush.Name = "buttonPush";
            this.buttonPush.Size = new System.Drawing.Size(30, 30);
            this.buttonPush.TabIndex = 20;
            this.buttonPush.UseVisualStyleBackColor = false;
            this.buttonPush.Click += new System.EventHandler(this.Play_Menu_Item_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonPause.BackgroundImage = global::Rec_radio.Properties.Resources.pause_play;
            this.buttonPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPause.ForeColor = System.Drawing.Color.Black;
            this.buttonPause.Location = new System.Drawing.Point(151, 109);
            this.buttonPause.Margin = new System.Windows.Forms.Padding(1);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(30, 30);
            this.buttonPause.TabIndex = 30;
            this.buttonPause.UseVisualStyleBackColor = false;
            this.buttonPause.Click += new System.EventHandler(this.Pause_Menu_Item_Click);
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
            // radioButtonStereo
            // 
            this.radioButtonStereo.AutoSize = true;
            this.radioButtonStereo.Location = new System.Drawing.Point(304, 87);
            this.radioButtonStereo.Name = "radioButtonStereo";
            this.radioButtonStereo.Size = new System.Drawing.Size(56, 17);
            this.radioButtonStereo.TabIndex = 20;
            this.radioButtonStereo.TabStop = true;
            this.radioButtonStereo.Tag = "1";
            this.radioButtonStereo.Text = "Stereo";
            this.radioButtonStereo.UseVisualStyleBackColor = true;
            this.radioButtonStereo.CheckedChanged += new System.EventHandler(this.RadioButtonStereo_CheckedChanged);
            // 
            // radioButtonMono
            // 
            this.radioButtonMono.AutoSize = true;
            this.radioButtonMono.Location = new System.Drawing.Point(246, 87);
            this.radioButtonMono.Name = "radioButtonMono";
            this.radioButtonMono.Size = new System.Drawing.Size(52, 17);
            this.radioButtonMono.TabIndex = 19;
            this.radioButtonMono.TabStop = true;
            this.radioButtonMono.Tag = "0";
            this.radioButtonMono.Text = "Mono";
            this.radioButtonMono.UseVisualStyleBackColor = true;
            this.radioButtonMono.CheckedChanged += new System.EventHandler(this.RadioButtonMono_CheckedChanged);
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
            // directoryName
            // 
            this.directoryName.Location = new System.Drawing.Point(62, 24);
            this.directoryName.Name = "directoryName";
            this.directoryName.Size = new System.Drawing.Size(206, 20);
            this.directoryName.TabIndex = 0;
            this.directoryName.Text = "D:\\AUDIO\\";
            // 
            // Record
            // 
            this.Record.BackColor = System.Drawing.SystemColors.Window;
            this.Record.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Record.Controls.Add(this.folderDir);
            this.Record.Controls.Add(this.chart_Animation);
            this.Record.Controls.Add(this.buttonStartRec);
            this.Record.Controls.Add(this.label9);
            this.Record.Controls.Add(this.buttonStopRec);
            this.Record.Controls.Add(this.label4);
            this.Record.Controls.Add(this.comboBoxCheck);
            this.Record.Controls.Add(this.labelState);
            this.Record.Controls.Add(this.label3);
            this.Record.Controls.Add(this.pictureBoxFront);
            this.Record.Controls.Add(this.pictureBoxBack);
            this.Record.Location = new System.Drawing.Point(4, 22);
            this.Record.Name = "Record";
            this.Record.Padding = new System.Windows.Forms.Padding(3);
            this.Record.Size = new System.Drawing.Size(421, 273);
            this.Record.TabIndex = 0;
            this.Record.Text = "Record";
            // 
            // folderDir
            // 
            this.folderDir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.folderDir.BackgroundImage = global::Rec_radio.Properties.Resources.folder_dir;
            this.folderDir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.folderDir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.folderDir.FlatAppearance.BorderSize = 0;
            this.folderDir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.folderDir.ForeColor = System.Drawing.Color.Black;
            this.folderDir.Location = new System.Drawing.Point(56, 44);
            this.folderDir.Margin = new System.Windows.Forms.Padding(1);
            this.folderDir.Name = "folderDir";
            this.folderDir.Size = new System.Drawing.Size(30, 30);
            this.folderDir.TabIndex = 25;
            this.folderDir.UseVisualStyleBackColor = false;
            this.folderDir.Click += new System.EventHandler(this.Button_Click_OpenDir);
            // 
            // chart_Animation
            // 
            this.chart_Animation.BackColor = System.Drawing.Color.Transparent;
            this.chart_Animation.BackSecondaryColor = System.Drawing.Color.Silver;
            chartArea1.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.None;
            chartArea1.AlignmentStyle = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.None;
            chartArea1.AxisY2.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.Straight;
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chart_Animation.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.HeaderSeparatorColor = System.Drawing.Color.Silver;
            legend1.ItemColumnSeparatorColor = System.Drawing.Color.Gainsboro;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Legend1";
            legend1.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Wide;
            this.chart_Animation.Legends.Add(legend1);
            this.chart_Animation.Location = new System.Drawing.Point(3, 115);
            this.chart_Animation.Name = "chart_Animation";
            this.chart_Animation.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart_Animation.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.ForestGreen};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.LabelForeColor = System.Drawing.Color.Empty;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 4;
            this.chart_Animation.Series.Add(series1);
            this.chart_Animation.Size = new System.Drawing.Size(417, 155);
            this.chart_Animation.TabIndex = 24;
            this.chart_Animation.Text = "chart1";
            // 
            // buttonStartRec
            // 
            this.buttonStartRec.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonStartRec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonStartRec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStartRec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStartRec.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.buttonStartRec.ForeColor = System.Drawing.Color.Black;
            this.buttonStartRec.Location = new System.Drawing.Point(48, 15);
            this.buttonStartRec.Margin = new System.Windows.Forms.Padding(1);
            this.buttonStartRec.Name = "buttonStartRec";
            this.buttonStartRec.Size = new System.Drawing.Size(38, 23);
            this.buttonStartRec.TabIndex = 19;
            this.buttonStartRec.Text = "REC";
            this.buttonStartRec.UseVisualStyleBackColor = false;
            this.buttonStartRec.Click += new System.EventHandler(this.Button_Click_StartRec);
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
            // buttonStopRec
            // 
            this.buttonStopRec.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonStopRec.BackgroundImage = global::Rec_radio.Properties.Resources.pause_play;
            this.buttonStopRec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonStopRec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStopRec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStopRec.ForeColor = System.Drawing.Color.Black;
            this.buttonStopRec.Location = new System.Drawing.Point(8, 15);
            this.buttonStopRec.Margin = new System.Windows.Forms.Padding(1);
            this.buttonStopRec.Name = "buttonStopRec";
            this.buttonStopRec.Size = new System.Drawing.Size(38, 23);
            this.buttonStopRec.TabIndex = 12;
            this.buttonStopRec.UseVisualStyleBackColor = false;
            this.buttonStopRec.Click += new System.EventHandler(this.Stop_Click);
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
            // comboBoxCheck
            // 
            this.comboBoxCheck.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCheck.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxCheck.FormattingEnabled = true;
            this.comboBoxCheck.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxCheck.Location = new System.Drawing.Point(90, 50);
            this.comboBoxCheck.Name = "comboBoxCheck";
            this.comboBoxCheck.Size = new System.Drawing.Size(325, 21);
            this.comboBoxCheck.TabIndex = 13;
            this.comboBoxCheck.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCheck_SelectedIndexChanged);
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.BackColor = System.Drawing.Color.Transparent;
            this.labelState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelState.Location = new System.Drawing.Point(92, 34);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(36, 13);
            this.labelState.TabIndex = 15;
            this.labelState.Text = "0.00%";
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
            // pictureBoxFront
            // 
            this.pictureBoxFront.ErrorImage = null;
            this.pictureBoxFront.Image = global::Rec_radio.Properties.Resources.progres;
            this.pictureBoxFront.Location = new System.Drawing.Point(91, 17);
            this.pictureBoxFront.Name = "pictureBoxFront";
            this.pictureBoxFront.Size = new System.Drawing.Size(324, 13);
            this.pictureBoxFront.TabIndex = 16;
            this.pictureBoxFront.TabStop = false;
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.BackColor = System.Drawing.Color.LightGray;
            this.pictureBoxBack.ErrorImage = null;
            this.pictureBoxBack.Image = global::Rec_radio.Properties.Resources.progres_s;
            this.pictureBoxBack.Location = new System.Drawing.Point(90, 16);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(325, 15);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBack.TabIndex = 17;
            this.pictureBoxBack.TabStop = false;
            // 
            // comboBoxCapture
            // 
            this.comboBoxCapture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCapture.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxCapture.FormattingEnabled = true;
            this.comboBoxCapture.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxCapture.Location = new System.Drawing.Point(62, 86);
            this.comboBoxCapture.Name = "comboBoxCapture";
            this.comboBoxCapture.Size = new System.Drawing.Size(163, 21);
            this.comboBoxCapture.TabIndex = 18;
            // 
            // comboBoxKhz
            // 
            this.comboBoxKhz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKhz.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxKhz.FormattingEnabled = true;
            this.comboBoxKhz.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxKhz.Location = new System.Drawing.Point(336, 22);
            this.comboBoxKhz.Name = "comboBoxKhz";
            this.comboBoxKhz.Size = new System.Drawing.Size(61, 21);
            this.comboBoxKhz.TabIndex = 14;
            // 
            // comboBoxKbps
            // 
            this.comboBoxKbps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKbps.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxKbps.FormattingEnabled = true;
            this.comboBoxKbps.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxKbps.Location = new System.Drawing.Point(337, 50);
            this.comboBoxKbps.Name = "comboBoxKbps";
            this.comboBoxKbps.Size = new System.Drawing.Size(60, 21);
            this.comboBoxKbps.TabIndex = 15;
            // 
            // panelSettingPlayer
            // 
            this.panelSettingPlayer.Controls.Add(this.Record);
            this.panelSettingPlayer.Controls.Add(this.tabPage2);
            this.panelSettingPlayer.Controls.Add(this.tabPage1);
            this.panelSettingPlayer.Location = new System.Drawing.Point(2, 3);
            this.panelSettingPlayer.Multiline = true;
            this.panelSettingPlayer.Name = "panelSettingPlayer";
            this.panelSettingPlayer.SelectedIndex = 0;
            this.panelSettingPlayer.Size = new System.Drawing.Size(429, 299);
            this.panelSettingPlayer.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(421, 273);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonWma);
            this.groupBox1.Controls.Add(this.buttonOpen);
            this.groupBox1.Controls.Add(this.buttonRemote);
            this.groupBox1.Controls.Add(this.radioButtonAac);
            this.groupBox1.Controls.Add(this.comboBoxLame);
            this.groupBox1.Controls.Add(this.comboBoxSampleRate);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.textBoxFileAudio);
            this.groupBox1.Controls.Add(this.radioButtonWav);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.radioButtonMp3);
            this.groupBox1.Location = new System.Drawing.Point(6, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 130);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conversion";
            // 
            // radioButtonWma
            // 
            this.radioButtonWma.AutoSize = true;
            this.radioButtonWma.Location = new System.Drawing.Point(256, 88);
            this.radioButtonWma.Name = "radioButtonWma";
            this.radioButtonWma.Size = new System.Drawing.Size(52, 17);
            this.radioButtonWma.TabIndex = 28;
            this.radioButtonWma.TabStop = true;
            this.radioButtonWma.Tag = "1";
            this.radioButtonWma.Text = "WMA";
            this.radioButtonWma.UseVisualStyleBackColor = true;
            this.radioButtonWma.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged_Wma_Aac);
            // 
            // buttonOpen
            // 
            this.buttonOpen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpen.FlatAppearance.BorderSize = 0;
            this.buttonOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOpen.ForeColor = System.Drawing.Color.Black;
            this.buttonOpen.ImageKey = "(отсутствует)";
            this.buttonOpen.Location = new System.Drawing.Point(369, 42);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(28, 20);
            this.buttonOpen.TabIndex = 26;
            this.buttonOpen.Text = "...";
            this.buttonOpen.UseVisualStyleBackColor = false;
            this.buttonOpen.Click += new System.EventHandler(this.Button_Click_Open_Dir);
            // 
            // buttonRemote
            // 
            this.buttonRemote.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonRemote.BackgroundImage = global::Rec_radio.Properties.Resources.refrech;
            this.buttonRemote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRemote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemote.FlatAppearance.BorderSize = 0;
            this.buttonRemote.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRemote.ForeColor = System.Drawing.Color.Black;
            this.buttonRemote.ImageKey = "(отсутствует)";
            this.buttonRemote.Location = new System.Drawing.Point(368, 92);
            this.buttonRemote.Name = "buttonRemote";
            this.buttonRemote.Size = new System.Drawing.Size(30, 30);
            this.buttonRemote.TabIndex = 16;
            this.buttonRemote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRemote.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonRemote.UseVisualStyleBackColor = false;
            this.buttonRemote.Click += new System.EventHandler(this.Button_Click_Remonte);
            // 
            // radioButtonAac
            // 
            this.radioButtonAac.AutoSize = true;
            this.radioButtonAac.Location = new System.Drawing.Point(256, 65);
            this.radioButtonAac.Name = "radioButtonAac";
            this.radioButtonAac.Size = new System.Drawing.Size(46, 17);
            this.radioButtonAac.TabIndex = 27;
            this.radioButtonAac.TabStop = true;
            this.radioButtonAac.Tag = "1";
            this.radioButtonAac.Text = "AAC";
            this.radioButtonAac.UseVisualStyleBackColor = true;
            this.radioButtonAac.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged_Wma_Aac);
            // 
            // comboBoxLame
            // 
            this.comboBoxLame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLame.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxLame.FormattingEnabled = true;
            this.comboBoxLame.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxLame.Location = new System.Drawing.Point(18, 84);
            this.comboBoxLame.Name = "comboBoxLame";
            this.comboBoxLame.Size = new System.Drawing.Size(105, 21);
            this.comboBoxLame.TabIndex = 18;
            // 
            // comboBoxSampleRate
            // 
            this.comboBoxSampleRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSampleRate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxSampleRate.FormattingEnabled = true;
            this.comboBoxSampleRate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxSampleRate.Location = new System.Drawing.Point(18, 42);
            this.comboBoxSampleRate.Name = "comboBoxSampleRate";
            this.comboBoxSampleRate.Size = new System.Drawing.Size(105, 21);
            this.comboBoxSampleRate.TabIndex = 15;
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
            // textBoxFileAudio
            // 
            this.textBoxFileAudio.Location = new System.Drawing.Point(203, 42);
            this.textBoxFileAudio.Name = "textBoxFileAudio";
            this.textBoxFileAudio.Size = new System.Drawing.Size(160, 20);
            this.textBoxFileAudio.TabIndex = 24;
            // 
            // radioButtonWav
            // 
            this.radioButtonWav.AutoSize = true;
            this.radioButtonWav.Location = new System.Drawing.Point(203, 65);
            this.radioButtonWav.Name = "radioButtonWav";
            this.radioButtonWav.Size = new System.Drawing.Size(50, 17);
            this.radioButtonWav.TabIndex = 21;
            this.radioButtonWav.TabStop = true;
            this.radioButtonWav.Tag = "1";
            this.radioButtonWav.Text = "WAV";
            this.radioButtonWav.UseVisualStyleBackColor = true;
            this.radioButtonWav.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged_Wav);
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
            // radioButtonMp3
            // 
            this.radioButtonMp3.AutoSize = true;
            this.radioButtonMp3.Location = new System.Drawing.Point(203, 88);
            this.radioButtonMp3.Name = "radioButtonMp3";
            this.radioButtonMp3.Size = new System.Drawing.Size(47, 17);
            this.radioButtonMp3.TabIndex = 22;
            this.radioButtonMp3.TabStop = true;
            this.radioButtonMp3.Tag = "1";
            this.radioButtonMp3.Text = "MP3";
            this.radioButtonMp3.UseVisualStyleBackColor = true;
            this.radioButtonMp3.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged_Mp3);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkDataDir);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.buttonSaveSettings);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.directoryName);
            this.groupBox2.Controls.Add(this.comboBoxCapture);
            this.groupBox2.Controls.Add(this.radioButtonStereo);
            this.groupBox2.Controls.Add(this.radioButtonMono);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.comboBoxKbps);
            this.groupBox2.Controls.Add(this.comboBoxKhz);
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
            this.checkDataDir.CheckedChanged += new System.EventHandler(this.Check_DataDir_CheckedChanged);
            // 
            // buttonSaveSettings
            // 
            this.buttonSaveSettings.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSaveSettings.BackgroundImage = global::Rec_radio.Properties.Resources.save;
            this.buttonSaveSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSaveSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveSettings.FlatAppearance.BorderSize = 0;
            this.buttonSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSaveSettings.ForeColor = System.Drawing.Color.Black;
            this.buttonSaveSettings.ImageKey = "(отсутствует)";
            this.buttonSaveSettings.Location = new System.Drawing.Point(368, 80);
            this.buttonSaveSettings.Name = "buttonSaveSettings";
            this.buttonSaveSettings.Size = new System.Drawing.Size(30, 30);
            this.buttonSaveSettings.TabIndex = 1;
            this.buttonSaveSettings.UseVisualStyleBackColor = false;
            this.buttonSaveSettings.Click += new System.EventHandler(this.ButtonSaveSettings_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.Timer_Data_Tick);
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
            this.Controls.Add(this.panelSettingPlayer);
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
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.Record.ResumeLayout(false);
            this.Record.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Animation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFront)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.panelSettingPlayer.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButtonStereo;
        private System.Windows.Forms.RadioButton radioButtonMono;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox directoryName;
        private System.Windows.Forms.Button buttonSaveSettings;
        private System.Windows.Forms.TabPage Record;
        private System.Windows.Forms.Button buttonStartRec;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonStopRec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBoxFront;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.TabControl panelSettingPlayer;
        public System.Windows.Forms.ListView listViewInfoTrack;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label labelTimeStart;
        private System.Windows.Forms.Label labelTimeStop;
        private MetroFramework.Controls.MetroTrackBar trackBarAudio;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonPush;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonStopAudio;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ComboBox comboBoxCapture;
        private System.Windows.Forms.ComboBox comboBoxKbps;
        private System.Windows.Forms.ComboBox comboBoxKhz;
        private System.Windows.Forms.ComboBox comboBoxCheck;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Animation;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonRemote;
        public System.Windows.Forms.ComboBox comboBoxSampleRate;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.ComboBox comboBoxLame;
        public System.Windows.Forms.RadioButton radioButtonMp3;
        public System.Windows.Forms.RadioButton radioButtonWav;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.ListBox listBoxInfo;
        public System.Windows.Forms.TextBox textBoxFileAudio;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button folderDir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.RadioButton radioButtonAac;
        public System.Windows.Forms.RadioButton radioButtonWma;
        private System.Windows.Forms.Button buttonOpenDir;
        public AudioProgressBar audioPogressBar;
        private System.Windows.Forms.CheckBox checkDataDir;
    }
}

