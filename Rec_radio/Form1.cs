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
            Save_Init();
            Queue();

            buttonStartRec.Enabled = false;
            buttonStopRec.Enabled = false;
            labelState.Visible = false;
            comboBoxCheck.Enabled = false;
            trackBarAudio.Enabled = false;
            listViewInfoTrack.SmallImageList = imageList;
            comboBoxSampleRate.Enabled = false;
            comboBoxLame.Enabled = false;

            // устанавливаем обработчики событий для меню
            delMenuItem.Click += Del_Menu_Item_Click;  

        }
        
        private System.Timers.Timer Timer;
        int selectedDevice = -1;
        int check;
        int checkedRB;

        MyData data = new MyData();
       
        


        WasapiLoopbackCapture waveIn_out;
        LameMP3FileWriter stream_out;
        WaveInEvent waveIn;
        AudioFileReader audioFileReader;
        WaveOutEvent outputDevice;
        Queue<double> myQueue;


        bool flag = false;


        private void Queue()
        {
            int n = 4000;
            myQueue = new Queue<double>(Enumerable.Repeat(0.0, n).ToList()); // fill myQ w/ zeros
            chart_Animation.ChartAreas[0].AxisY.Minimum = -40000;
            chart_Animation.ChartAreas[0].AxisY.Maximum = 40000;
            chart_Animation.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            chart_Animation.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
            chart_Animation.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart_Animation.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            //chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;

            chart_Animation.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
            chart_Animation.ChartAreas[0].AxisY.LabelStyle.Enabled = false;

            //chart1.ChartAreas[0].AxisX.Interval = 1;
            //chart1.ChartAreas[0].AxisY.Interval = 1;

            //chart1.ChartAreas[0].AxisX.LineColor = Color.Black;
            //chart1.ChartAreas[0].AxisY.LineColor = Color.Black;
        }
        private void WaveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (stream_out != null)
                stream_out.Write(e.Buffer, 0, e.BytesRecorded);
            //stream_out.Flush();

        }
        private void WaveIn_DataAvailable_Float(object sender, WaveInEventArgs args)
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
        private void WaveIn_Char(object sender, WaveInEventArgs e)
        {
            for (int i = 0; i < e.BytesRecorded; i += 2)
            {
                myQueue.Enqueue(BitConverter.ToInt16(e.Buffer, i));
                myQueue.Dequeue();
            }
        }
        private void Timer_Tick(object sender, EventArgs e) // отображение часов
        {
            try
            {
                label4.Text = DateTime.Now.ToString();
                double frac = audioValueLast / audioValueMax;
                pictureBoxFront.Width = (int)(frac * pictureBoxBack.Width - 1);
                labelState.Text = string.Format("{0:00.00}%", frac * 100.0, audioCount); // [count: {0}]
            
                chart_Animation.Series["Series1"].Points.DataBindY(myQueue);
                
            }
            catch
            {
                Console.WriteLine("No bytes recorded");
            }

        }
       
        //======================================================================
        // ТАЙМЕР ДЛЯ ЗАПИСИ С ИНТЕРВАЛОМ В ЧАС
        private void Timed_Event(object sender, ElapsedEventArgs e)
        {
            int time = DateTime.Now.Hour;//текущие минуты

            if (DateTimeOffset.Now.Hour == time && DateTimeOffset.Now.Minute == 00 && DateTimeOffset.Now.Second == 00)
            {
                // Работа таймера по времени 00-00-00
                switch (comboBoxCapture.Text)
                {
                    case "WASAIP":
                        if (waveIn_out != null)//если запись идет то остановит
                        {
                            Stop_Recording();//Запись оставновленна
                            Thread.Sleep(200);
                            listBoxInfo.Items.Add("AUTOSTART! - " + DateTime.Now);
                            Start_Records();

                        }; break;
                    case "LINE_IN":
                        if (waveIn != null)//если запись идет то остановит
                        {
                            Stop_Recording();//Запись оставновленна
                            Thread.Sleep(200);
                            listBoxInfo.Items.Add("AUTOSTART! - " + DateTime.Now);
                            Start_Records();

                        }; break;

                }

                label3.Visible = true;
                buttonStartRec.Enabled = false;
                

            }
        }
        private void Init_Timer()
        {
            Timer = new System.Timers.Timer(1000);
            Timer.Elapsed += Timed_Event;
            Timer.AutoReset = true;
            Timer.Enabled = true;
        }
        //========================================================================
        // ВХОДНОЙ СИГНАЛ

        public void Team_Start()
        {
            buttonStartRec.BackColor = Color.FromArgb(0, 255, 200, 200); //Идет запись цвет кнопки при нажатие 
            buttonStartRec.Enabled = false;
            label3.Visible = true;
            labelState.Visible = true;
            comboBoxCheck.Enabled = false;
            comboBoxKhz.Enabled = false;
            comboBoxKbps.Enabled = false;
            comboBoxCapture.Enabled = false;
            directoryName.Enabled = false;
            //textBox2.Enabled = false;
            radioButtonMono.Enabled = false;
            radioButtonStereo.Enabled = false;
            buttonSaveSettings.Enabled = false;
        }
        private void Start_Records() // Начинаем запись - обработчик нажатия кнопки
        {
            Init_Timer();
            Team_Start();
            try
            {
                data.GetDirName(directoryName.Text);
                string outputFileName = null;
 
                flag = true;
                
                outputFileName = data.GetName();
                //outputFilename = data.Filename = "Rario.mp3";

                int sampleRate = Convert.ToInt32(comboBoxKhz.Text); // 8 kHz /Freqency Hz 8000, 11025, 16000, 22050, 24000, 32000, 44100, 48000
                int lamePreset = Convert.ToInt32(comboBoxKbps.Text);
                int channels = check; // mono/stereo количество каналов

                switch (comboBoxCapture.Text)
                {
                    case "WASAIP":
                        waveIn_out = new WasapiLoopbackCapture();
                        //waveOut.DeviceNumber = selectedDevice; //Дефолтное устройство для записи (если оно имеется)
                        waveIn_out.DataAvailable += WaveIn_DataAvailable_Float;
                        waveIn_out.DataAvailable += WaveIn_Char;
                        waveIn_out.DataAvailable += new EventHandler<WaveInEventArgs>(WaveIn_DataAvailable); //Прикрепляем к событию DataAvailable обработчик, возникающий при наличии записываемых данных
                        waveIn_out.RecordingStopped += new EventHandler<StoppedEventArgs>(WaveIn_RecordingStopped); // Прикрепляем обработчик завершения записи 
                        stream_out = new LameMP3FileWriter(outputFileName, WaveFormat.CreateIeeeFloatWaveFormat(sampleRate, channels), lamePreset);
                        waveIn_out.StartRecording(); // Начало записи; 
                        label9.Text = waveIn_out.WaveFormat.BitsPerSample + " bit PCM: " + sampleRate / 1000 + " kHz " + channels + " channels " + "_ " + outputFileName;
                        break;
                    case "LINE_IN":
                        waveIn = new WaveInEvent();
                        waveIn.DeviceNumber = selectedDevice; //Дефолтное устройство для записи (если оно имеется)
                        waveIn.DataAvailable += WaveIn_DataAvailable_Float;
                        waveIn.DataAvailable += WaveIn_Char;
                        waveIn.DataAvailable += new EventHandler<WaveInEventArgs>(WaveIn_DataAvailable);  //Прикрепляем к событию DataAvailable обработчик, возникающий при наличии записываемых данных
                        waveIn.RecordingStopped += new EventHandler<StoppedEventArgs>(WaveIn_RecordingStopped);  // Прикрепляем обработчик завершения записи 
                        waveIn.WaveFormat = new WaveFormat(sampleRate, channels); // Формат wav-файла - принимает параметры - частоту дискретизации и количество каналов(здесь mono)
                        //writer = new WaveFileWriter(outputFilename, waveIn.WaveFormat);
                        stream_out = new LameMP3FileWriter(outputFileName, waveIn.WaveFormat, lamePreset); 
                        waveIn.StartRecording();
                        label9.Text = waveIn.WaveFormat.ToString() + "_ " + outputFileName;
                        ; break;

                }
                listBoxInfo.ForeColor = Color.Black;
                listBoxInfo.Items.Add("NEW " + outputFileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void Stop_Recording() // Завершаем запись
        {
            switch (comboBoxCapture.Text)
            {
                case "WASAIP":
                    flag = false;
                    waveIn_out.StopRecording();
                    ; break;
                case "LINE_IN":
                    waveIn.StopRecording();
                    ; break;
            }

            buttonStartRec.BackColor = Color.WhiteSmoke;
            //listBox1.Items.Add("STOP REC!");


        }
        private void WaveIn_RecordingStopped(object sender, EventArgs e)  // Окончание записи
        {

            switch (comboBoxCapture.Text)
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
        private void Button_Click_StartRec(object sender, EventArgs e)
        {
            Start_Records();
            buttonStopRec.Enabled = true;
            Folder_Dir();
        }
        public void Team_Stop()
        {
            label3.Visible = false;
            label3.Visible = false;
            labelState.Visible = false;
            buttonStartRec.BackColor = Color.LightGray; //Запись оставновленна

            buttonStartRec.Enabled = true;
            comboBoxCheck.Enabled = true;
            comboBoxKhz.Enabled = true;
            comboBoxKbps.Enabled = true;
            comboBoxCapture.Enabled = true;
            directoryName.Enabled = true;  
            buttonSaveSettings.Enabled = true;
            radioButtonMono.Enabled = true;
            radioButtonStereo.Enabled = true;
            buttonStopRec.Enabled = false;
        }
        private void Stop_Click(object sender, EventArgs e)
        {

            switch (comboBoxCapture.Text)
            {
                case "WASAIP":
                    if (waveIn_out != null)
                    {
                        Stop_Recording();
                    }
                     ; break;
                case "LINE_IN":
                    if (waveIn != null)
                    {
                        Stop_Recording();
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
        private void NotifyIconTree_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
                Tree.Visible = false;
            }
        }
        private void ButtonSaveSettings_Click(object sender, EventArgs e)
        {
            try
            {
                data.GetDirName(directoryName.Text);
                Properties.Settings.Default.checkedRB = checkedRB; //присваиваем значение параметра
                Properties.Settings.Default.Save(); // и сохраняем настройки

                string[] arr = { directoryName.Text, textBoxFileAudio.Text, comboBoxKhz.Text, comboBoxKbps.Text, comboBoxCapture.Text, comboBoxSampleRate.Text, comboBoxLame.Text, Convert.ToString(check)};
                File.WriteAllText("init.txt", string.Join("\n", arr));

                comboBoxCheck.Items.Clear();
                comboBoxCheck.Enabled = true;

                selectedDevice = comboBoxCheck.SelectedIndex;
                if (selectedDevice == -1)
                {
                    buttonStartRec.Enabled = false;
                    buttonStopRec.Enabled = false;
                }
                else
                {
                    buttonStartRec.Enabled = true;

                }

                switch (comboBoxCapture.Text)
                {
                    case "WASAIP": Device_Out(); break;
                    case "LINE_IN": Device_In(); break;

                }

                if (radioButtonMono.Checked)
                {
                    check = 1;

                }
                else if (radioButtonStereo.Checked)
                {
                    check = 2;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("No folder directory created," + "\n" + "Specify the path in the settings" + "\n" + "and enable recording !!!");
                listBoxInfo.ForeColor = Color.Red;
                listBoxInfo.Items.Add("NO! Folder directory created");
            }

        }
        private void Save_Init()
        {
            try
            {
                string[] str;
                str = File.ReadAllLines("init.txt");
                directoryName.Text = str[0];
                textBoxFileAudio.Text = str[1];
                comboBoxKhz.Text = str[2];
                comboBoxKbps.Text = str[3];
                comboBoxCapture.Text = str[4];
                comboBoxSampleRate.Text = str[5];
                comboBoxLame.Text = str[6];
                check = Convert.ToInt32(str[7]);

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
                comboBoxKhz.Items.Add(s[i]);
            }
            for (int i = 0; i < s.Length; i++)
            {
                comboBoxSampleRate.Items.Add(s[i]);
            }
            for (int i = 0; i < a.Length; i++)
            {
                comboBoxKbps.Items.Add(a[i]);
            }
            for (int i = 0; i < a.Length; i++)
            {
                comboBoxLame.Items.Add(a[i]);
            }

            string[] w = { "WASAIP", "LINE_IN" };
            comboBoxCapture.Items.AddRange(w);

        }
        void Device_In()
        {
            int waveInDevices = WaveIn.DeviceCount;
            for (int waveInDevice = 0; waveInDevice < waveInDevices; waveInDevice++)
            {
                WaveInCapabilities DeviceInfo = WaveIn.GetCapabilities(waveInDevice);
                comboBoxCheck.Items.Add("Device IN " + (waveInDevice) + "  " + DeviceInfo.ProductName + " каналы " + waveInDevices);
               
            }

        }
        void Device_Out()
        {

            comboBoxCheck.Items.Add("Device OUT WASAIP (Default playback device)");
           
        }
        private void ComboBoxCheck_SelectedIndexChanged(object sender, EventArgs e)
        {

            selectedDevice = comboBoxCheck.SelectedIndex;
            if (selectedDevice == -1)
            {
                buttonStartRec.Enabled = false;
                buttonStopRec.Enabled = false;
            }
            else
            {
                buttonStartRec.Enabled = true;

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            checkedRB = Properties.Settings.Default.checkedRB; //читаем
            (new RadioButton[] { radioButtonMono, radioButtonStereo })[checkedRB].Checked = true; // чекаем нужный rb

        }
        private void RadioButtonMono_CheckedChanged(object sender, EventArgs e)
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
        private void RadioButtonStereo_CheckedChanged(object sender, EventArgs e)
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
        private void Button_Click_OpenDir(object sender, EventArgs e)
        {
            try
            {
                Folder_Dir();
                Process.Start(data.GetDirName(directoryName.Text));

            }
            catch (Exception)
            {
                //MessageBox.Show("No folder directory created!!!");
                listBoxInfo.ForeColor = Color.Red;
                listBoxInfo.Items.Add("NO! Folder directory created!");
            }


        }
        void Folder_Dir()
        {
            listViewInfoTrack.BeginUpdate();
            listViewInfoTrack.Items.Clear();
            try
            {

                //path = data.GetDirName(DirectoryName.Text);
                string[] files = Directory.GetFiles(data.GetDirName(directoryName.Text));
                DirectoryInfo dir = new DirectoryInfo(data.GetDirName(directoryName.Text));
                foreach (FileInfo file in dir.GetFiles())
                {

                    ListViewItem listViewItem = listViewInfoTrack.Items.Add(file.Name);
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
            listViewInfoTrack.EndUpdate();

        }
        private void File_Play()
        {
            //path = data.GetDirName(DirectoryName.Text);

            foreach (ListViewItem item in listViewInfoTrack.SelectedItems)
            {

                var playlist = Directory.GetFiles(data.GetDirName(directoryName.Text), item.Text);

                foreach (string i in playlist)
                {

                    if (audioFileReader == null)
                    {
                        audioFileReader = new AudioFileReader(i);
                        outputDevice = new WaveOutEvent();
                        outputDevice.Init(audioFileReader);
                        

                        //label12.Text = item.Text;
                        listBoxInfo.Items.Add("PLAY >>>  " + item.Text);
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
                Image image = renderer.Render(data.GetDirName(directoryName.Text) + item.Text, averagePeakProvider, myRendererSettings);
                audioPogressBar.BackgroundImage = image;

            }
        }
        private void Button_Click_Refresh(object sender, EventArgs e)
        {
           
                Folder_Dir();
                       
        }
        private void Del_Menu_Item_Click(object sender, EventArgs e)
        {
            try
            {

                //path = data.GetDirName(DirectoryName.Text);//path = DirectoryName.Text + "\\" + textBox2.Text + "\\" + Year + "\\" + Data + "\\" + Day + "\\";

                DialogResult dialogResult = MessageBox.Show("You are about to delete \n the file from the directory?", "Delete list", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    foreach (ListViewItem item in listViewInfoTrack.SelectedItems)
                    {
                        listViewInfoTrack.Items.Remove(item);

                        string[] Del = Directory.GetFiles(data.GetDirName(directoryName.Text), item.Text);

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
                listBoxInfo.ForeColor = Color.Red;
                listBoxInfo.Items.Add("NO! Audio file records");
            }
        }
        private void Play_Menu_Item_Click(object sender, EventArgs e)
        {
            try
            {
                File_Play();
                outputDevice.Play();
                trackBarAudio.Enabled = true;
                timer2.Enabled = true; // включаем timer (выключен для обработки исключений)
                //timer2.Interval = 1000;//(int)audioFileReader.TotalTime.TotalSeconds; // задаём интервал в 1000 милисек. = 1 сек.


            }
            catch (Exception)
            {
                //MessageBox.Show("Selected Play List");
            }
        }
        private void Stop_Menu_Item_Click(object sender, EventArgs e)
        {
            Stop_List();

        }
        public void Stop_List()
        {
            try
            {
                outputDevice.Dispose();
                outputDevice = null;
                audioFileReader.Dispose();
                audioFileReader = null;

                labelTimeStart.Text = "0:00:00";
                labelTimeStop.Text = "0:00:00";
                trackBarAudio.Enabled = false;
                trackBarAudio.Value = 0;
                audioPogressBar.Value = 0;
                timer2.Stop();
                timer2.Dispose();

            }

            catch (Exception)
            {
                //MessageBox.Show("Selected Play List");
            }
        }
        private void Playlist_Play_Click(object sender, EventArgs e)
        {
            Stop_List();
            try
            {
               
                File_Play();
                outputDevice.Play();
                trackBarAudio.Enabled = true;
                timer2.Enabled = true; // включаем timer (выключен для обработки исключений)
                //timer2.Interval = 1000;//(int)audioFileReader.TotalTime.TotalSeconds; // задаём интервал в 1000 милисек. = 1 сек.


            }
            catch (Exception)
            {
                
            }

        }
        // таймер для ползунка 
        private void Pause_Menu_Item_Click(object sender, EventArgs e)
        {
            outputDevice?.Stop();
            timer2?.Stop();
        }

        // таймер для ползунка
        private void MetroTrackBar_Scroll(object sender, ScrollEventArgs e)
        {

            if (outputDevice != null && audioFileReader != null)
            {
                audioFileReader.CurrentTime = TimeSpan.FromSeconds(audioFileReader.TotalTime.TotalSeconds * trackBarAudio.Value / 100f);
                labelTimeStart.Text = String.Format("{00:D}:{1:D2}:{2:D2}", audioFileReader.CurrentTime.Hours, audioFileReader.CurrentTime.Minutes, audioFileReader.CurrentTime.Seconds);
                audioPogressBar.Value = trackBarAudio.Value;
            }


        }

        //таймер для просчета записаного файла
        private void Timer_Data_Tick(object sender, EventArgs e)
        {
            try
            {
                if (outputDevice != null && audioFileReader != null)
                {
                    TimeSpan currentTime = (outputDevice.PlaybackState == PlaybackState.Stopped) ? TimeSpan.Zero : audioFileReader.CurrentTime;
                    TimeSpan totalTime = (outputDevice.PlaybackState == PlaybackState.Stopped) ? TimeSpan.Zero : audioFileReader.TotalTime;
                    trackBarAudio.Value = Math.Min(trackBarAudio.Maximum, (int)(100 * currentTime.TotalSeconds / audioFileReader.TotalTime.TotalSeconds));
                    trackBarAudio.Minimum = 0;
                    labelTimeStart.Text = String.Format("{00:D}:{1:D2}:{2:D2}", currentTime.Hours, currentTime.Minutes, currentTime.Seconds);
                    labelTimeStop.Text = String.Format("{00:D}:{1:D2}:{2:D2}", totalTime.Hours, totalTime.Minutes, totalTime.Seconds);

                    trackBarAudio.Value++;

                    audioPogressBar.Value = trackBarAudio.Value;

                }
                

            }
            catch
            {
                Stop_List();

            }
        }
 
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (waveIn_out != null)//если запись идет то остановит
            {
                Stop_Recording();//Запись оставновленна
                
            }
        }
        //=======================================================
        //================КОНВЕРТАЦИЯ АУДИО=====================
        //=======================================================
        public void Convert_Audio()
        {
            
            foreach (String file in openFileDialog.FileNames)
            {
                
                try
                {
                    int sampleRate = Convert.ToInt32(comboBoxSampleRate.Text);
                    int lamePreset = Convert.ToInt32(comboBoxLame.Text);
                    var path_name = Path.GetFileNameWithoutExtension(file);
                    var path_ext = Path.GetExtension(openFileDialog.FileName);
                    var dir = Path.GetDirectoryName(file);
                    var infile = dir + "\\" + path_name;
                    var outfile = directoryName.Text + "\\" + textBoxFileAudio.Text + "\\";
                    DirectoryInfo newDir = new DirectoryInfo(outfile);
                    if (!newDir.Exists)
                    {
                        newDir.Create();
                    }

                    if (radioButtonWav.Checked)
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
                        string fileOLD = Path.Combine(outfile, path_name + ".wav");//Во Что!!!!!!!!!
                        using (MediaFoundationReader Reader = new MediaFoundationReader(infile + path_ext))
                        {
                            var wavFormat = new WaveFormat(sampleRate, 16, 2);
                            using (var wavStream = new WaveFormatConversionStream(wavFormat, Reader))

                            {
                                WaveFileWriter.CreateWaveFile(fileOLD, wavStream);
                                listBoxInfo.ForeColor = Color.Black;
                                listBoxInfo.Items.Add("OK! conversion " + path_ext  + " =>> .wav  " + path_name);
                            }
                        }


                    }
                    else if (radioButtonMp3.Checked)
                    {
                        //WAV TO MP3
                        string fileMP3 = Path.Combine(outfile, path_name + ".mp3");
                        using (var reader = new AudioFileReader(infile + path_ext))
                        {

                            using (var writer = new LameMP3FileWriter(fileMP3, reader.WaveFormat, lamePreset))

                            {
                                reader.CopyTo(writer);
                                listBoxInfo.ForeColor = Color.Black;
                                listBoxInfo.Items.Add("OK! conversion " + path_ext + " =>> .mp3  " + path_name);
                            }
                        }

                    }
                    else if (radioButtonAac.Checked)
                    {
                        //WAV TO AAC
                        string fileAAC = Path.Combine(outfile, path_name + ".aac");

                        using (MediaFoundationReader reader = new MediaFoundationReader(infile + path_ext))
                        {
                            MediaFoundationEncoder.EncodeToAac(reader, fileAAC);
                            listBoxInfo.ForeColor = Color.Black;
                            listBoxInfo.Items.Add("OK! conversion " + path_ext  + " =>> .aac  " + path_name);
                        }

                    }
                    else if (radioButtonWma.Checked)
                    {
                        //WAV TO WMA
                        string fileWMA = Path.Combine(outfile, path_name + ".wma");

                        using (MediaFoundationReader reader = new MediaFoundationReader(infile + path_ext))
                        {
                            MediaFoundationEncoder.EncodeToWma(reader, fileWMA);
                            listBoxInfo.ForeColor = Color.Black;
                            listBoxInfo.Items.Add("OK! conversion " + path_ext + " =>> .wma  " + path_name);
                        }

                    }
                    else
                    {
                        listBoxInfo.ForeColor = Color.DarkBlue;
                        listBoxInfo.Items.Add("SELECT! Format conversion!");
                    }
                    //Process.Start(outfile);
                    
                }

                catch (Exception ex)
                {
                    listBoxInfo.ForeColor = Color.Red;
                    listBoxInfo.Items.Add("EROOR! Audio conversion!");
                }
            }
         
        }
        // Открыть файловый менеджер для выбора аудио файла с расширением
        private void Button_Click_Remonte(object sender, EventArgs e)
        {
           
            openFileDialog.Filter = "Sound Files(*.mp3 *.aac *.wav *.mpeg *.mp4 *.ogg *.wma)|*.mp3;*.aac;*.wav;*.mpeg;*.mp4;*.ogg;*.wma | All files(*.*) | *.*";
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Convert_Audio();
                
            }


            
        }
        // Выбор расширения для конвертации
        private void RadioButton_CheckedChanged_Mp3(object sender, EventArgs e)
        {
            comboBoxSampleRate.Enabled = false;
            comboBoxLame.Enabled = true;
        }

        private void RadioButton_CheckedChanged_Wav(object sender, EventArgs e)
        {
            comboBoxLame.Enabled = true;
            comboBoxSampleRate.Enabled = true;
        }

        private void RadioButton_CheckedChanged_Wma_Aac(object sender, EventArgs e)
        {
            comboBoxSampleRate.Enabled = false;
            comboBoxLame.Enabled = false;
        }
       
        //Открыть папку с конвертируемыми аудио файлами
        private void Button_Click_Open_Dir(object sender, EventArgs e)
        {
            try
            {
                Process.Start(directoryName.Text + "\\" + textBoxFileAudio.Text + "\\");
            }
            catch
            {
                listBoxInfo.ForeColor = Color.Red;
                listBoxInfo.Items.Add("NO! File directory");
            }
            
        }

        private void Check_DataDir_CheckedChanged(object sender, EventArgs e)
        {
            if(checkDataDir.Checked == true)
            {
                data.yes_no = true;
            }
            else
            {
                data.yes_no = false;
            }
        }
    }


}


