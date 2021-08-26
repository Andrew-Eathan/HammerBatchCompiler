using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HammerBatchCompiler
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Settings.Load();

            if (Settings.GetKey("vbsp") != null)
            {
                loadvbsp.Text = "vbsp.exe loaded!";
                vbspDialog.FileName = Settings.GetKey("vbsp");
            }

            if (Settings.GetKey("vvis") != null)
            {
                loadvvis.Text = "vvis.exe loaded!";
                vvisDialog.FileName = Settings.GetKey("vvis");
            }

            if (Settings.GetKey("vrad") != null)
            {
                loadvrad.Text = "vrad.exe loaded!";
                vradDialog.FileName = Settings.GetKey("vrad");
            }

            if (Settings.GetKey("game") != null)
            {
                loadgame.Text = "Game loaded!";
                gameDialog.FileName = Settings.GetKey("game");
            }

            if (Settings.GetKey("gamedir") != null)
            {
                loadgamedir.Text = "Game directory loaded!";
                gamedirDialog.SelectedPath = Settings.GetKey("gamedir");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mapDialog.ShowDialog();
        }

        private void loadvbsp_Click(object sender, EventArgs e)
        {
            vbspDialog.ShowDialog();
        }

        private void loadvvis_Click(object sender, EventArgs e)
        {
            vvisDialog.ShowDialog();
        }

        private void loadvrad_Click(object sender, EventArgs e)
        {
            vradDialog.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gameDialog.ShowDialog();
        }

        private void loadgamedir_Click(object sender, EventArgs e)
        {
            if (gamedirDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(gamedirDialog.SelectedPath))
            {
                loadgamedir.Text = "Game directory loaded!";
                Settings.SetKey("gamedir", gamedirDialog.SelectedPath);
                Settings.Save();
            }
        }

        private void mapDialog_FileOk(object sender, CancelEventArgs e)
        {
            loadmap.Text = "Map loaded!";
            compilebutton.Enabled = true;
        }

        private void vbspDialog_FileOk(object sender, CancelEventArgs e)
        {
            loadvbsp.Text = "vbsp.exe loaded!";
            Settings.SetKey("vbsp", vbspDialog.FileName);
            Settings.Save();
        }

        private void vvisDialog_FileOk(object sender, CancelEventArgs e)
        {
            loadvvis.Text = "vvis.exe loaded!";
            Settings.SetKey("vvis", vvisDialog.FileName);
            Settings.Save();
        }

        private void vradDialog_FileOk(object sender, CancelEventArgs e)
        {
            loadvrad.Text = "vrad.exe loaded!";
            Settings.SetKey("vrad", vradDialog.FileName);
            Settings.Save();
        }

        private void gameDialog_FileOk(object sender, CancelEventArgs e)
        {
            loadgame.Text = "Game loaded!";
            Settings.SetKey("game", gameDialog.FileName);
            Settings.Save();
        }

        DateTime compileStart = new DateTime();

        private void compilebutton_Click(object sender, EventArgs e)
        {
            if (vbsplist.SelectedIndex == 1 && vvislist.SelectedIndex == 1 && vradlist.SelectedIndex == 1)
            {
                textbox.Text = "How do you expect to compile a map without running any of the compiling tools?";
                return;
            }

            loadmap.Enabled = false;
            loadvbsp.Enabled = false;
            loadvvis.Enabled = false;
            loadvrad.Enabled = false;
            loadgame.Enabled = false;
            loadgamedir.Enabled = false;
            compilebutton.Enabled = false;

            stopbutton.Enabled = true;
            compileStart = DateTime.Now;

            textbox.Text = "";
            compiletime.Enabled = true;

            if (!compileworker.IsBusy)
                compileworker.RunWorkerAsync();
        }

        private void stopbutton_Click(object sender, EventArgs e)
        {
            loadmap.Enabled = true;
            loadvbsp.Enabled = true;
            loadvvis.Enabled = true;
            loadvrad.Enabled = true;
            loadgame.Enabled = true;
            loadgamedir.Enabled = true;
            compilebutton.Enabled = true;

            stopbutton.Enabled = false;
            
            textbox.Text += "Stopped compilation.\n";
            textbox.SelectionStart = textbox.Text.Length;
            textbox.ScrollToCaret();

            compileworker.CancelAsync();
            compiletime.Enabled = false;
        }

        private void compileworker_DoWork(object sender, DoWorkEventArgs e)
        {
            // nasty code ahead
            // but atleast it's still better than hammer's compiler

            Process vbsp = new Process();
            Process vvis = new Process();
            Process vrad = new Process();

            vbsp.StartInfo.FileName = vbspDialog.FileName;
            vvis.StartInfo.FileName = vvisDialog.FileName;
            vrad.StartInfo.FileName = vradDialog.FileName;

            int vbspOptions = 0;
            int vvisOptions = 0;
            int vradOptions = 0;
            int threadCount = 0;
            bool vradHDREnabled = false;

            // more cursed invoking
            vbsplist.Invoke((Action)delegate { vbspOptions = vbsplist.SelectedIndex; });
            vvislist.Invoke((Action)delegate { vvisOptions = vvislist.SelectedIndex; });
            vradlist.Invoke((Action)delegate { vradOptions = vradlist.SelectedIndex; });
            vradhdr.Invoke((Action)delegate { vradHDREnabled = vradhdr.Checked; });
            threads.Invoke((Action)delegate { threadCount = (int)threads.Value; });

            // god this code is horrid
            // shield your eyes

            ////////////// VBSP //////////////
            if (vbspOptions == 1)
            {
                textbox.Invoke((Action)delegate
                {
                    textbox.Text += "Skipping VBSP.\n";
                    textbox.SelectionStart = textbox.Text.Length;
                    textbox.ScrollToCaret();
                });
                goto vvisStart;
            }

            vbsp.StartInfo.UseShellExecute = false;
            vbsp.StartInfo.RedirectStandardOutput = true;
            vbsp.StartInfo.CreateNoWindow = true;
            vbsp.StartInfo.Arguments = "-game \"" + gamedirDialog.SelectedPath + "\""
                + (vbspOptions == 2 ? " -onlyents" : "")
                 + " -threads " + threadCount
                  + " \"" + mapDialog.FileName + "\"";

            textbox.Invoke((Action)delegate
            {
                textbox.Text += "Starting VBSP with options:\n" + vbsp.StartInfo.Arguments + "\n";
                textbox.SelectionStart = textbox.Text.Length;
                textbox.ScrollToCaret();
            });

            vbsp.OutputDataReceived += new DataReceivedEventHandler((sender1, e1) =>
            {
                // curse c#'s weird invoking system
                textbox.Invoke((Action)delegate
                {
                    textbox.Text += e1.Data + "\n";
                    textbox.SelectionStart = textbox.Text.Length;
                    textbox.ScrollToCaret();
                });
            });
            vbsp.Start();
            vbsp.BeginOutputReadLine();
            vbsp.WaitForExit();
            textbox.Invoke((Action)delegate
            {
                textbox.Text += "VBSP completed. (code " + vbsp.ExitCode + ")\n";
                textbox.SelectionStart = textbox.Text.Length;
                textbox.ScrollToCaret();
            });
            vbsp.Close();


        vvisStart:
            ////////////// VVIS //////////////
            if (vvisOptions == 1)
            {
                textbox.Invoke((Action)delegate
                {
                    textbox.Text += "Skipping VVIS.\n";
                    textbox.SelectionStart = textbox.Text.Length;
                    textbox.ScrollToCaret();
                });
                goto vradStart;
            }
            vvis.StartInfo.UseShellExecute = false;
            vvis.StartInfo.RedirectStandardOutput = true;
            vvis.StartInfo.CreateNoWindow = true;
            vvis.StartInfo.Arguments = "-game \"" + gamedirDialog.SelectedPath + "\""
                + (vvisOptions == 2 ? " -fast" : "")
                 + " -threads " + threadCount
                  + " \"" + mapDialog.FileName.Replace(".vmf", "") + "\"";

            textbox.Invoke((Action)delegate
            {
                textbox.Text += "Starting VVIS with options:\n" + vvis.StartInfo.Arguments + "\n";
                textbox.SelectionStart = textbox.Text.Length;
                textbox.ScrollToCaret();
            });

            vvis.OutputDataReceived += new DataReceivedEventHandler((sender1, e1) =>
            {
                textbox.Invoke((Action)delegate
                {
                    textbox.Text += e1.Data + "\n";
                    textbox.SelectionStart = textbox.Text.Length;
                    textbox.ScrollToCaret();
                });
            });
            vvis.Start();
            vvis.BeginOutputReadLine();
            vvis.WaitForExit();
            textbox.Invoke((Action)delegate
            {
                textbox.Text += "VVIS completed. (code " + vvis.ExitCode + ")\n";
                textbox.SelectionStart = textbox.Text.Length;
                textbox.ScrollToCaret();
            });
            vvis.Close();

        vradStart:
            ////////////// VRAD //////////////
            if (vradOptions == 1)
            {
                textbox.Invoke((Action)delegate
                {
                    textbox.Text += "Skipping VRAD.\n";
                    textbox.SelectionStart = textbox.Text.Length;
                    textbox.ScrollToCaret();
                });
                return;
            }
            vrad.StartInfo.UseShellExecute = false;
            vrad.StartInfo.RedirectStandardOutput = true;
            vrad.StartInfo.CreateNoWindow = true;
            vrad.StartInfo.Arguments = "-game \"" + gamedirDialog.SelectedPath + "\""
                + (vradHDREnabled ? " -both" : " -ldr")
                 + (vradOptions == 2 ? " -fast" : "")
                  + " -threads " + threadCount
                   + " \"" + mapDialog.FileName.Replace(".vmf", "") + "\"";

            textbox.Invoke((Action)delegate
            {
                textbox.Text += "Starting VRAD with options:\n" + vrad.StartInfo.Arguments + "\n";
                textbox.SelectionStart = textbox.Text.Length;
                textbox.ScrollToCaret();
            });

            vrad.OutputDataReceived += new DataReceivedEventHandler((sender1, e1) =>
            {
                textbox.Invoke((Action)delegate
                {
                    textbox.Text += e1.Data + "\n";
                    textbox.SelectionStart = textbox.Text.Length;
                    textbox.ScrollToCaret();
                });
            });
            vrad.Start();
            vrad.BeginOutputReadLine();
            vrad.WaitForExit();
            textbox.Invoke((Action)delegate
            {
                textbox.Text += "VRAD completed. (code " + vrad.ExitCode + ")\n";
                textbox.SelectionStart = textbox.Text.Length;
                textbox.ScrollToCaret();
            });
            vrad.Close();
        }

        private void compileworker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            loadmap.Enabled = true;
            loadvbsp.Enabled = true;
            loadvvis.Enabled = true;
            loadvrad.Enabled = true;
            loadgame.Enabled = true;
            loadgamedir.Enabled = true;
            compilebutton.Enabled = true;

            stopbutton.Enabled = false;
            compiletime.Enabled = false;

            textbox.Text += "Compilation completed!\n";
            textbox.Text += "TIP: Visit https://interlopers.net/errors to check if your map has any errors/warnings, and how to fix them.\n";
            textbox.SelectionStart = textbox.Text.Length;
            textbox.ScrollToCaret();

            if (gamelist.SelectedIndex == 1)
            {
                Process.Start(gameDialog.FileName, "+map \"" + mapDialog.FileName.Replace(".vmf", ".bsp") + "\" " + gameParams.Text);
            }
        }

        private void textbox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

        private void compiletime_Tick(object sender, EventArgs e)
        {
            TimeSpan difference = DateTime.Now.Subtract(compileStart);
            time.Text = "Time elapsed: " + Math.Floor(difference.TotalHours) + "h, " + Math.Floor(difference.TotalMinutes) + "m, " + Math.Floor(difference.TotalSeconds) + "s";
        }
    }
}
