using NAudio.Wave;
using NAudio.Lame;
using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
//using WaveFormRenderer;

namespace Rec_radio
{
    public partial class Form1 : Form
    {
        private static double audioValueMax = 0;
        private static double audioValueLast = 0;
        private static int audioCount = 0;
        
        
        public Form1()
        {
            InitializeComponent();
            Sound_Frequency();
            Save_init();
            MyQ();
            Start.Enabled = false;
            Stop.Enabled = false;
            label1.Visible = false;
            comboBox1.Enabled = false;
            trackBar1.Enabled = false;
            listView1.SmallImageList = imageList1;
            comboBox5.Enabled = false;
            comboBox6.Enabled = false;

            // устанавливаем обработчики событий для меню
            DelMenuItem.Click += DelMenuItem_Click;  

        }
        
        private System.Timers.Timer Timer;
        int selectedDevice = -1;
        int Check;
        int checkedRB;

        MyData data = new MyData();
       
        


        WasapiLoopbackCapture waveIn_out;
        LameMP3FileWriter stream_out;
        WaveInEvent waveIn;
        AudioFileReader audioFileReader;
        WaveOutEvent outputDevice;
        Queue<double> myQ;


        bool flag = false;


        private void MyQ()
        {
            int n = 4000;
            myQ = new Queue<double>(Enumerable.Repeat(0.0, n).ToList()); // fill myQ w/ zeros
            chart1.ChartAreas[0].AxisY.Minimum = -40000;
            chart1.ChartAreas[0].AxisY.Maximum = 40000;
            chart1.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            //chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;

            chart1.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
            chart1.ChartAreas[0].AxisY.LabelStyle.Enabled = false;

            //chart1.ChartAreas[0].AxisX.Interval = 1;
            //chart1.ChartAreas[0].AxisY.Interval = 1;

            //chart1.ChartAreas[0].AxisX.LineColor = Color.Black;
            //chart1.ChartAreas[0].AxisY.LineColor = Color.Black;
        }
        private void waveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (stream_out != null)
                stream_out.Write(e.Buffer, 0, e.BytesRecorded);
            //stream_out.Flush();

        }
        private void waveIn_char(object sender, WaveInEventArgs e)
        {
            for (int i = 0; i < e.BytesRecorded; i += 2)
            {
                myQ.Enqueue(BitConverter.ToInt16(e.Buffer, i));
                myQ.Dequeue();
            }
        }
        private void timer1_Tick(object sender, EventArgs e) // отображение часов
        {
            try
            {
                label4.Text = DateTime.Now.ToString();
                double frac = audioValueLast / audioValueMax;
                pictureBox_front.Width = (int)(frac * pictureBox_back.Width - 1);
                label1.Text = string.Format("{0:00.00}%", frac * 100.0, audioCount); // [count: {0}]
            
                chart1.Series["Series1"].Points.DataBindY(myQ);
                
            }
            catch
            {
                Console.WriteLine("No bytes recorded");
            }

        }
        private void waveIn_Data_Available(object sender, WaveInEventArgs args)
        {

            float max = 0;

            // interpret as 16 bit audio
            for (int index = 0; index < args.BytesRecorded; index += 2)
            {
                short sample = (short)((args.Buffer[index + 1] << 8) | args.Buffer[index + 0]);
                var sample32 = sample / 32768f; // to floating point
                if (sample32 < 0) sample32 = -sample32; // absolute value 
                if (sample32 > max) max = sample32; // is this the max value?
            }

            // calculate what fraction this peak is of previous peaks
            if (max > audioValueMax)
            {
                audioValueMax = (double)max;
            }
            audioValueLast = max;
            audioCount += 1;
        }
        //======================================================================
        // ТАЙМЕР ДЛЯ ЗАПИСИ С ИНТЕРВАЛОМ В ЧАС
        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            int time = DateTime.Now.Hour;//текущие минуты

            if (DateTimeOffset.Now.Hour == time && DateTimeOffset.Now.Minute == 00 && DateTimeOffset.Now.Second == 00)
            {
                // Работа таймера по времени 00-00-00
                switch (comboBox4.Text)
                {
                    case "WASAIP":
                        if (waveIn_out != null)//если запись идет то остановит
                        {
                            StopRecording();//Запись оставновленна
                            Thread.Sleep(200);
                            listBox1.Items.Add("AUTOSTART! - " + DateTime.Now);
                            StartRecords();

                        }; break;
                    case "LINE_IN":
                        if (waveIn != null)//если запись идет то остановит
                        {
                            StopRecording();//Запись оставновленна
                            Thread.Sleep(200);
                            listBox1.Items.Add("AUTOSTART! - " + DateTime.Now);
                            StartRecords();

                        }; break;

                }

                label3.Visible = true;
                Start.Enabled = false;
                

            }
        }
        private void init()
        {
            Timer = new System.Timers.Timer(1000);
            Timer.Elapsed += OnTimedEvent;
            Timer.AutoReset = true;
            Timer.Enabled = true;
        }
        //========================================================================
        // ВХОДНОЙ СИГНАЛ

        public void Team_Start()
        {
            Start.BackColor = Color.FromArgb(0, 255, 200, 200); //Идет запись цвет кнопки при нажатие 
            Start.Enabled = false;
            label3.Visible = true;
            label1.Visible = true;
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            DirectoryName.Enabled = false;
            //textBox2.Enabled = false;
            radioButtonMono.Enabled = false;
            radioButtonStereo.Enabled = false;
            buttonSaveSettings.Enabled = false;
        }
        private void StartRecords() // Начинаем запись - обработчик нажатия кнопки
        {
            init();
            Team_Start();
            try
            {
                data.GetDirName(DirectoryName.Text);
                string outputFilename = null;
 
                flag = true;
                
                outputFilename = data.GetName();
                //outputFilename = data.Filename = "Rario.mp3";

                int sampleRate = Convert.ToInt32(comboBox2.Text); // 8 kHz /Freqency Hz 8000, 11025, 16000, 22050, 24000, 32000, 44100, 48000
                int LamePreset = Convert.ToInt32(comboBox3.Text);
                int channels = Check; // mono/stereo количество каналов

                switch (comboBox4.Text)
                {
                    case "WASAIP":
                        waveIn_out = new WasapiLoopbackCapture();
                        //waveOut.DeviceNumber = selectedDevice; //Дефолтное устройство для записи (если оно имеется)
                        waveIn_out.DataAvailable += waveIn_Data_Available;
                        waveIn_out.DataAvailable += waveIn_char;
                        waveIn_out.DataAvailable += new EventHandler<WaveInEventArgs>(waveIn_DataAvailable); //Прикрепляем к событию DataAvailable обработчик, возникающий при наличии записываемых данных
                        waveIn_out.RecordingStopped += new EventHandler<StoppedEventArgs>(waveIn_RecordingStopped); // Прикрепляем обработчик завершения записи 
                        stream_out = new LameMP3FileWriter(outputFilename, WaveFormat.CreateIeeeFloatWaveFormat(sampleRate, channels), LamePreset);
                        waveIn_out.StartRecording(); // Начало записи; 
                        label9.Text = waveIn_out.WaveFormat.BitsPerSample + " bit PCM: " + sampleRate / 1000 + " kHz " + channels + " channels " + "_ " + outputFilename;
                        break;
                    case "LINE_IN":
                        waveIn = new WaveInEvent();
                        waveIn.DeviceNumber = selectedDevice; //Дефолтное устройство для записи (если оно имеется)
                        waveIn.DataAvailable += waveIn_Data_Available;
                        waveIn.DataAvailable += waveIn_char;
                        waveIn.DataAvailable += new EventHandler<WaveInEventArgs>(waveIn_DataAvailable);  //Прикрепляем к событию DataAvailable обработчик, возникающий при наличии записываемых данных
                        waveIn.RecordingStopped += new EventHandler<StoppedEventArgs>(waveIn_RecordingStopped);  // Прикрепляем обработчик завершения записи 
                        waveIn.WaveFormat = new WaveFormat(sampleRate, channels); // Формат wav-файла - принимает параметры - частоту дискретизации и количество каналов(здесь mono)
                        //writer = new WaveFileWriter(outputFilename, waveIn.WaveFormat);
                        stream_out = new LameMP3FileWriter(outputFilename, waveIn.WaveFormat, LamePreset); 
                        waveIn.StartRecording();
                        label9.Text = waveIn.WaveFormat.ToString() + "_ " + outputFilename;
                        ; break;

                }
                listBox1.ForeColor = Color.Black;
                listBox1.Items.Add("NEW " + outputFilename);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void StopRecording() // Завершаем запись
        {
            switch (comboBox4.Text)
            {
                case "WASAIP":
                    flag = false;
                    waveIn_out.StopRecording();
                    ; break;
                case "LINE_IN":
                    waveIn.StopRecording();
                    ; break;
            }

            Start.BackColor = Color.WhiteSmoke;
            //listBox1.Items.Add("STOP REC!");


        }
        private void waveIn_RecordingStopped(object sender, EventArgs e)  // Окончание записи
        {

            switch (comboBox4.Text)
            {
                case "WASAIP":
                    if (waveIn_out != null)
                    {
                        waveIn_out.Dispose();
                        waveIn_out = null;
                    }
                    ; break;
                case "LINE_IN":
                    if (waveIn != null)
                    {
                        waveIn.Dispose();
                        waveIn = null;
                    }; break;

            }

            if (stream_out != null)
            {
                stream_out.Close();
                stream_out.Dispose();
                data.Dispose();
                stream_out = null;
            }

            if (Timer != null)
            {
                Timer.Stop();
                Timer.Dispose();
                data.Dispose();
                Timer = null;
            }

        }
        //=====================================================================
        // REC Обработчик нажатия кнопки записи
        private void button1_Click_1(object sender, EventArgs e)
        {
            StartRecords();
            Stop.Enabled = true;
            FolderDir();
        }
        public void Team_Stop()
        {
            label3.Visible = false;
            label3.Visible = false;
            label1.Visible = false;
            Start.BackColor = Color.LightGray; //Запись оставновленна

            Start.Enabled = true;
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
            comboBox4.Enabled = true;
            DirectoryName.Enabled = true;  
            buttonSaveSettings.Enabled = true;
            radioButtonMono.Enabled = true;
            radioButtonStereo.Enabled = true;
            Stop.Enabled = false;
        }
        private void Stop_Click(object sender, EventArgs e)
        {

            switch (comboBox4.Text)
            {
                case "WASAIP":
                    if (waveIn_out != null)
                    {
                        StopRecording();
                    }
                     ; break;
                case "LINE_IN":
                    if (waveIn != null)
                    {
                        StopRecording();
                    }
                    ; break;

            }

            Team_Stop();

        }
        //=================================================================
        // иконка в трее
        private void Form1_Deactivate(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                Tree.Visible = true;
            }
        }
        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
                Tree.Visible = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                data.GetDirName(DirectoryName.Text);
                Properties.Settings.Default.checkedRB = checkedRB; //присваиваем значение параметра
                Properties.Settings.Default.Save(); // и сохраняем настройки

                string[] arr = { DirectoryName.Text, textBox1.Text, comboBox2.Text, comboBox3.Text, comboBox4.Text, comboBox5.Text, comboBox6.Text, Convert.ToString(Check)};
                File.WriteAllText("init.txt", string.Join("\n", arr));

                comboBox1.Items.Clear();
                comboBox1.Enabled = true;

                selectedDevice = comboBox1.SelectedIndex;
                if (selectedDevice == -1)
                {
                    Start.Enabled = false;
                    Stop.Enabled = false;
                }
                else
                {
                    Start.Enabled = true;

                }

                switch (comboBox4.Text)
                {
                    case "WASAIP": Device_OUT(); break;
                    case "LINE_IN": Device_IN(); break;

                }

                if (radioButtonMono.Checked)
                {
                    Check = 1;

                }
                else if (radioButtonStereo.Checked)
                {
                    Check = 2;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("No folder directory created," + "\n" + "Specify the path in the settings" + "\n" + "and enable recording !!!");
                listBox1.ForeColor = Color.Red;
                listBox1.Items.Add("NO! Folder directory created");
            }

        }
        private void Save_init()
        {
            try
            {
                string[] str;
                str = File.ReadAllLines("init.txt");
                DirectoryName.Text = str[0];
                textBox1.Text = str[1];
                comboBox2.Text = str[2];
                comboBox3.Text = str[3];
                comboBox4.Text = str[4];
                comboBox5.Text = str[5];
                comboBox6.Text = str[6];
                Check = Convert.ToInt32(str[7]);

            }
            catch (Exception)
            { }

        }
        void Sound_Frequency()
        {
            int[] s = { 8000, 11025, 16000, 22050, 24000, 32000, 44100, 48000/*, 96000, 192000 */};
            int[] a = { 8, 16, 24, 32, 40, 48, 56, 64, /*80, 88, 94, 96, 100, 112, 118, 124,*/ 128, /*130, 136, 142, 144, 148, 154, 160, 192, 224, 256,*/ 320 };
            for (int i = 0; i < s.Length; i++)
            {
                comboBox2.Items.Add(s[i]);
            }
            for (int i = 0; i < s.Length; i++)
            {
                comboBox5.Items.Add(s[i]);
            }
            for (int i = 0; i < a.Length; i++)
            {
                comboBox3.Items.Add(a[i]);
            }
            for (int i = 0; i < a.Length; i++)
            {
                comboBox6.Items.Add(a[i]);
            }

            string[] w = { "WASAIP", "LINE_IN" };
            comboBox4.Items.AddRange(w);

        }
        void Device_IN()
        {
            int waveInDevices = WaveIn.DeviceCount;
            for (int waveInDevice = 0; waveInDevice < waveInDevices; waveInDevice++)
            {
                WaveInCapabilities DeviceInfo = WaveIn.GetCapabilities(waveInDevice);
                comboBox1.Items.Add("Device IN " + (waveInDevice) + "  " + DeviceInfo.ProductName + " каналы " + waveInDevices);
               
            }

        }
        void Device_OUT()
        {

            comboBox1.Items.Add("Device OUT WASAIP (Default playback device)");
           
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            selectedDevice = comboBox1.SelectedIndex;
            if (selectedDevice == -1)
            {
                Start.Enabled = false;
                Stop.Enabled = false;
            }
            else
            {
                Start.Enabled = true;

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            checkedRB = Properties.Settings.Default.checkedRB; //читаем
            (new RadioButton[] { radioButtonMono, radioButtonStereo })[checkedRB].Checked = true; // чекаем нужный rb

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //if ((sender as RadioButton).Checked)
            //{
            //    checkedRB = int.Parse((sender as RadioButton).Tag.ToString()); //предварительно в свойства Tag радиобаттонов в окне свойств записываем значения от 0 до 4
            //}
            if (radioButtonMono.Checked)
            {
                checkedRB = Convert.ToInt32(radioButtonMono.Tag);
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //if ((sender as RadioButton).Checked)
            //{
            //    checkedRB = int.Parse((sender as RadioButton).Tag.ToString()); //предварительно в свойства Tag радиобаттонов в окне свойств записываем значения от 0 до 4
            //}
            if (radioButtonStereo.Checked)
            {
                checkedRB = Convert.ToInt32(radioButtonStereo.Tag);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                FolderDir();
                Process.Start(data.GetDirName(DirectoryName.Text));

            }
            catch (Exception)
            {
                //MessageBox.Show("No folder directory created!!!");
                listBox1.ForeColor = Color.Red;
                listBox1.Items.Add("NO! Folder directory created!");
            }


        }
        void FolderDir()
        {
            listView1.BeginUpdate();
            listView1.Items.Clear();
            try
            {

                //path = data.GetDirName(DirectoryName.Text);
                string[] files = Directory.GetFiles(data.GetDirName(DirectoryName.Text));
                DirectoryInfo dir = new DirectoryInfo(data.GetDirName(DirectoryName.Text));
                foreach (FileInfo file in dir.GetFiles())
                {

                    ListViewItem listViewItem = listView1.Items.Add(file.Name);
                    listViewItem.ImageIndex = 0;
                    listViewItem.SubItems.Add((file.Length / 1024f).ToString() + " Kb");
                    listViewItem.SubItems.Add(file.Extension);
                    listViewItem.SubItems.Add(file.DirectoryName);
                    listViewItem.Tag = file;
                }

            }
            catch (Exception)
            {
                //MessageBox.Show("No folder directory created," + "\n" + "Specify the path in the settings" + "\n" + "and enable recording !!!");
                
            }
            listView1.EndUpdate();

        }
        private void FilePlay()
        {
            //path = data.GetDirName(DirectoryName.Text);

            foreach (ListViewItem item in listView1.SelectedItems)
            {

                var playlist = Directory.GetFiles(data.GetDirName(DirectoryName.Text), item.Text);

                foreach (string i in playlist)
                {

                    if (audioFileReader == null)
                    {
                        audioFileReader = new AudioFileReader(i);
                        outputDevice = new WaveOutEvent();
                        outputDevice.Init(audioFileReader);
                        

                        //label12.Text = item.Text;
                        listBox1.Items.Add("PLAY >>>  " + item.Text);
                    }

                }

                MaxPeakProvider maxPeakProvider = new MaxPeakProvider();
                RmsPeakProvider rmsPeakProvider = new RmsPeakProvider(200); // e.g. 200
                SamplingPeakProvider samplingPeakProvider = new SamplingPeakProvider(200); // e.g. 200
                AveragePeakProvider averagePeakProvider = new AveragePeakProvider(2); // e.g. 4

                var topSpacerColor = Color.FromArgb(64, 83, 22, 3);
                var myRendererSettings = new SoundCloudBlockWaveFormSettings(Color.FromArgb(173, 56, 14),topSpacerColor, Color.FromArgb(222, 112, 44),Color.FromArgb(64, 79, 79, 79))
                {
                    TopSpacerGradientStartColor = topSpacerColor,
                    BackgroundColor = Color.Transparent
                };
                myRendererSettings.Width = 410;
                myRendererSettings.TopHeight = 30;
                myRendererSettings.BottomHeight = 30;
                myRendererSettings.BackgroundColor = Color.FromArgb(0, 120, 120, 120);



                WaveFormRenderer renderer = new WaveFormRenderer();
                Image image = renderer.Render(data.GetDirName(DirectoryName.Text) + item.Text, averagePeakProvider, myRendererSettings);
                AudioPogressBar.BackgroundImage = image;

            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
           
                FolderDir();
                       
        }
        private void DelMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                //path = data.GetDirName(DirectoryName.Text);//path = DirectoryName.Text + "\\" + textBox2.Text + "\\" + Year + "\\" + Data + "\\" + Day + "\\";

                DialogResult dialogResult = MessageBox.Show("You are about to delete \n the file from the directory?", "Delete list", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    foreach (ListViewItem item in listView1.SelectedItems)
                    {
                        listView1.Items.Remove(item);

                        string[] Del = Directory.GetFiles(data.GetDirName(DirectoryName.Text), item.Text);

                        foreach (string i in Del)
                        {
                            File.Delete(i);
                        }

                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }


            }
            catch (Exception)
            {
                MessageBox.Show("No file records");
                listBox1.ForeColor = Color.Red;
                listBox1.Items.Add("NO! Audio file records");
            }
        }
        private void PlayMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FilePlay();
                outputDevice.Play();
                trackBar1.Enabled = true;
                timer2.Enabled = true; // включаем timer (выключен для обработки исключений)
                //timer2.Interval = 1000;//(int)audioFileReader.TotalTime.TotalSeconds; // задаём интервал в 1000 милисек. = 1 сек.


            }
            catch (Exception)
            {
                //MessageBox.Show("Selected Play List");
            }
        }
        private void StopMenuitem_Click(object sender, EventArgs e)
        {
            stopList();

        }
        public void stopList()
        {
            try
            {
                outputDevice.Dispose();
                outputDevice = null;
                audioFileReader.Dispose();
                audioFileReader = null;

                label10.Text = "0:00:00";
                label11.Text = "0:00:00";
                trackBar1.Enabled = false;
                trackBar1.Value = 0;
                AudioPogressBar.Value = 0;
                timer2.Stop();
                timer2.Dispose();

            }

            catch (Exception)
            {
                //MessageBox.Show("Selected Play List");
            }
        }
        private void PlaylistPlayClick(object sender, EventArgs e)
        {
            stopList();
            try
            {
               
                FilePlay();
                outputDevice.Play();
                trackBar1.Enabled = true;
                timer2.Enabled = true; // включаем timer (выключен для обработки исключений)
                //timer2.Interval = 1000;//(int)audioFileReader.TotalTime.TotalSeconds; // задаём интервал в 1000 милисек. = 1 сек.


            }
            catch (Exception)
            {
                
            }

        }
        // таймер для ползунка 
        private void PauseMenuItem_Click(object sender, EventArgs e)
        {
            outputDevice?.Stop();
            timer2?.Stop();
        }

        // таймер для ползунка
        private void metroTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {

            if (outputDevice != null && audioFileReader != null)
            {
                audioFileReader.CurrentTime = TimeSpan.FromSeconds(audioFileReader.TotalTime.TotalSeconds * trackBar1.Value / 100f);
                label10.Text = String.Format("{00:D}:{1:D2}:{2:D2}", audioFileReader.CurrentTime.Hours, audioFileReader.CurrentTime.Minutes, audioFileReader.CurrentTime.Seconds);
                AudioPogressBar.Value = trackBar1.Value;
            }


        }

        //таймер для просчета записаного файла
        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                if (outputDevice != null && audioFileReader != null)
                {
                    TimeSpan currentTime = (outputDevice.PlaybackState == PlaybackState.Stopped) ? TimeSpan.Zero : audioFileReader.CurrentTime;
                    TimeSpan totalTime = (outputDevice.PlaybackState == PlaybackState.Stopped) ? TimeSpan.Zero : audioFileReader.TotalTime;
                    trackBar1.Value = Math.Min(trackBar1.Maximum, (int)(100 * currentTime.TotalSeconds / audioFileReader.TotalTime.TotalSeconds));
                    trackBar1.Minimum = 0;
                    label10.Text = String.Format("{00:D}:{1:D2}:{2:D2}", currentTime.Hours, currentTime.Minutes, currentTime.Seconds);
                    label11.Text = String.Format("{00:D}:{1:D2}:{2:D2}", totalTime.Hours, totalTime.Minutes, totalTime.Seconds);

                    trackBar1.Value++;

                    AudioPogressBar.Value = trackBar1.Value;

                }
                

            }
            catch
            {
                stopList();

            }
        }
 
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (waveIn_out != null)//если запись идет то остановит
            {
                StopRecording();//Запись оставновленна
                
            }
        }
        //=======================================================
        //================КОНВЕРТАЦИЯ АУДИО=====================
        //=======================================================
        public void Convert_audio()
        {
            
            foreach (String file in openFileDialog1.FileNames)
            {
                
                try
                {
                    int sampleRate = Convert.ToInt32(comboBox5.Text);
                    int LamePreset = Convert.ToInt32(comboBox6.Text);
                    var path_name = Path.GetFileNameWithoutExtension(file);
                    var path_ext = Path.GetExtension(openFileDialog1.FileName);
                    var dir = Path.GetDirectoryName(file);
                    var infile = dir + "\\" + path_name;
                    var outfile = DirectoryName.Text + "\\" + textBox1.Text + "\\";//@"C:\Users\Admin\Desktop\NEW\";
                    DirectoryInfo NewDir = new DirectoryInfo(outfile);
                    if (!NewDir.Exists)
                    {
                        NewDir.Create();
                    }

                    if (radioButton1.Checked)
                    {
                        ////MP3 TO WAV
                        //string newFileMP3 = Path.Combine(outfile, path_name + ".wav");//Во Что!!!!!!!!!
                        //using (var mp3Reader = new Mp3FileReader(infile + path_ext))//что???????????
                        //{
                        //    var wavFormat = new WaveFormat(sampleRate, 16, 2);
                        //    using (var wavStream = new WaveFormatConversionStream(wavFormat, mp3Reader))

                        //    {
                        //        WaveFileWriter.CreateWaveFile(newFileMP3, wavStream);
                        //        listBox1.ForeColor = Color.Black;
                        //        listBox1.Items.Add("OK! conversion MP3 >>>>>> WAV - " + path_name + "   " + sampleRate + "KHz");
                        //    }
                        //}
                        //OLD TO WAV
                        string FileOLD = Path.Combine(outfile, path_name + ".wav");//Во Что!!!!!!!!!
                        using (MediaFoundationReader Reader = new MediaFoundationReader(infile + path_ext))
                        {
                            var wavFormat = new WaveFormat(sampleRate, 16, 2);
                            using (var wavStream = new WaveFormatConversionStream(wavFormat, Reader))

                            {
                                WaveFileWriter.CreateWaveFile(FileOLD, wavStream);
                                listBox1.ForeColor = Color.Black;
                                listBox1.Items.Add("OK! conversion " + path_ext  + " =>> .wav  " + path_name);
                            }
                        }


                    }
                    else if (radioButton2.Checked)
                    {
                        //WAV TO MP3
                        string FileMP3 = Path.Combine(outfile, path_name + ".mp3");
                        using (var reader = new AudioFileReader(infile + path_ext))
                        {

                            using (var writer = new LameMP3FileWriter(FileMP3, reader.WaveFormat, LamePreset))

                            {
                                reader.CopyTo(writer);
                                listBox1.ForeColor = Color.Black;
                                listBox1.Items.Add("OK! conversion " + path_ext + " =>> .mp3  " + path_name);
                            }
                        }

                    }
                    else if (radioButton3.Checked)
                    {
                        //WAV TO AAC
                        string FileAAC = Path.Combine(outfile, path_name + ".aac");

                        using (MediaFoundationReader reader = new MediaFoundationReader(infile + path_ext))
                        {
                            MediaFoundationEncoder.EncodeToAac(reader, FileAAC);
                            listBox1.ForeColor = Color.Black;
                            listBox1.Items.Add("OK! conversion " + path_ext  + " =>> .aac  " + path_name);
                        }

                    }
                    else if (radioButton4.Checked)
                    {
                        //WAV TO WMA
                        string FileWMA = Path.Combine(outfile, path_name + ".wma");

                        using (MediaFoundationReader reader = new MediaFoundationReader(infile + path_ext))
                        {
                            MediaFoundationEncoder.EncodeToWma(reader, FileWMA);
                            listBox1.ForeColor = Color.Black;
                            listBox1.Items.Add("OK! conversion " + path_ext + " =>> .wma  " + path_name);
                        }

                    }
                    else
                    {
                        listBox1.ForeColor = Color.DarkBlue;
                        listBox1.Items.Add("SELECT! Format conversion!");
                    }
                    //Process.Start(outfile);
                    
                }

                catch (Exception ex)
                {
                    listBox1.ForeColor = Color.Red;
                    listBox1.Items.Add("EROOR! Audio conversion!");
                }
            }
         
        }
        // Открыть файловый менеджер для выбора аудио файла с расширением
        private void button7_Click(object sender, EventArgs e)
        {
           
            openFileDialog1.Filter = "Sound Files(*.mp3 *.aac *.wav *.mpeg *.mp4 *.ogg *.wma)|*.mp3;*.aac;*.wav;*.mpeg;*.mp4;*.ogg;*.wma | All files(*.*) | *.*";
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Convert_audio();
                
            }


            
        }
        // Выбор расширения для конвертации
        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            comboBox5.Enabled = false;
            comboBox6.Enabled = true;
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            comboBox6.Enabled = true;
            comboBox5.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            comboBox5.Enabled = false;
            comboBox6.Enabled = false;
        }
       
        //Открыть папку с конвертируемыми аудио файлами
        private void button8_Click_1(object sender, EventArgs e)
        {
            try
            {
                Process.Start(DirectoryName.Text + "\\" + textBox1.Text + "\\");
            }
            catch
            {
                listBox1.ForeColor = Color.Red;
                listBox1.Items.Add("NO! File directory");
            }
            
        }

        private void checkDataDir_CheckedChanged(object sender, EventArgs e)
        {
            if(checkDataDir.Checked == true)
            {
                data.Yes_no = true;
            }
            else
            {
                data.Yes_no = false;
            }
        }
    }


}


