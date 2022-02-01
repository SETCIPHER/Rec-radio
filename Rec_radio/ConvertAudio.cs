using NAudio.Lame;
using NAudio.Wave;
using System;
using System.Drawing;
using System.IO;

namespace Rec_radio
{
    class ConvertAudio
    {
        public void Convert_Audio()
        {

            foreach (String file in Program.OLD.openFileDialog.FileNames)
            {

                try
                {
                    int sampleRate = Convert.ToInt32(Program.OLD.comboBoxSampleRate.Text);
                    int lamePreset = Convert.ToInt32(Program.OLD.comboBoxLame.Text);
                    var path_name = Path.GetFileNameWithoutExtension(file);
                    var path_ext = Path.GetExtension(Program.OLD.openFileDialog.FileName);
                    var dir = Path.GetDirectoryName(file);
                    var infile = dir + "\\" + path_name;
                    var outfile = Program.OLD.directoryName.Text + "\\" + Program.OLD.textBoxFileAudio.Text + "\\";
                    DirectoryInfo newDir = new DirectoryInfo(outfile);
                    if (!newDir.Exists)
                    {
                        newDir.Create();
                    }

                    if (Program.OLD.radioButtonWav.Checked)
                    {
                        
                        //Old TO WAV
                        string fileOld = Path.Combine(outfile, path_name + ".wav");//Во Что!!!!!!!!!
                        using (MediaFoundationReader Reader = new MediaFoundationReader(infile + path_ext))
                        {
                            var wavFormat = new WaveFormat(sampleRate, 16, 2);
                            using (var wavStream = new WaveFormatConversionStream(wavFormat, Reader))

                            {
                                WaveFileWriter.CreateWaveFile(fileOld, wavStream);
                                Program.OLD.listBoxInfo.ForeColor = Color.Black;
                                Program.OLD.listBoxInfo.Items.Add("OK! conversion " + path_ext + " =>> .wav  " + path_name);
                            }
                        }


                    }
                    else if (Program.OLD.radioButtonMp3.Checked)
                    {
                        //WAV TO MP3
                        string fileMP3 = Path.Combine(outfile, path_name + ".mp3");
                        using (var reader = new AudioFileReader(infile + path_ext))
                        {

                            using (var writer = new LameMP3FileWriter(fileMP3, reader.WaveFormat, lamePreset))

                            {
                                reader.CopyTo(writer);
                                Program.OLD.listBoxInfo.ForeColor = Color.Black;
                                Program.OLD.listBoxInfo.Items.Add("OK! conversion " + path_ext + " =>> .mp3  " + path_name);
                            }
                        }

                    }
                    else if (Program.OLD.radioButtonAac.Checked)
                    {
                        //WAV TO AAC
                        string fileAAC = Path.Combine(outfile, path_name + ".aac");

                        using (MediaFoundationReader reader = new MediaFoundationReader(infile + path_ext))
                        {
                            MediaFoundationEncoder.EncodeToAac(reader, fileAAC);
                            Program.OLD.listBoxInfo.ForeColor = Color.Black;
                            Program.OLD.listBoxInfo.Items.Add("OK! conversion " + path_ext + " =>> .aac  " + path_name);
                        }

                    }
                    else if (Program.OLD.radioButtonWma.Checked)
                    {
                        //WAV TO WMA
                        string fileWMA = Path.Combine(outfile, path_name + ".wma");

                        using (MediaFoundationReader reader = new MediaFoundationReader(infile + path_ext))
                        {
                            MediaFoundationEncoder.EncodeToWma(reader, fileWMA);
                            Program.OLD.listBoxInfo.ForeColor = Color.Black;
                            Program.OLD.listBoxInfo.Items.Add("OK! conversion " + path_ext + " =>> .wma  " + path_name);
                        }

                    }
                    else
                    {
                        Program.OLD.listBoxInfo.ForeColor = Color.DarkBlue;
                        Program.OLD.listBoxInfo.Items.Add("SELECT! Format conversion!");
                    }
                    //Process.Start(outfile);

                }

                catch (Exception ex)
                {
                    Program.OLD.listBoxInfo.ForeColor = Color.Red;
                    Program.OLD.listBoxInfo.Items.Add("EROOR! Audio conversion!");
                }
            }

        }
    }




}
