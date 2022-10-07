using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using DiscordWebhook;
using System.Net;
using Ionic.Zip;
using System.Threading;

namespace POM22a_MC_Launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Webhook webhook = new Webhook("https://discord.com/api/webhooks/1027920194288496750/njUPcxaE4A3wKtEflWWERtZHluK7S0vAlFiSBlGJcTpAK9V9Pxpsu1OLmhymV03vcuf3");
        public static string configFolder = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\POM22a-MC-Launcher";
        public static string configFile = $@"{configFolder}\config.txt";
        public static string modsFolder = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\.minecraft\mods";
        public string MCPath = "?";
        public string Username = "?";
        public static int LocalVersion = 1;   
        public int GlobalVersion = 1;

        static void lineChanger(string newText, string fileName, int line_to_edit)
        {
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[line_to_edit - 1] = newText;
            File.WriteAllLines(fileName, arrLine);
        }

        public async void checkForUpdates(bool isFromStartup)
        {
            WebClient wc = new WebClient();
            string raw = wc.DownloadString("https://pastebin.com/raw/SbbfSzyA");
            string downloadLink = "?";
            File.WriteAllText($@"{configFolder}\raw.txt", raw);
            foreach (var line in File.ReadAllLines($@"{configFolder}\raw.txt"))
            {
                if (line.StartsWith("VERSION:"))
                {
                    GlobalVersion = Convert.ToInt32(line.Split(':')[1].ToString());
                }

                if (line.StartsWith("LINK:"))
                {
                    downloadLink = line.Split(':')[1].ToString() + ":" + line.Split(':')[2].ToString();
                }
            }

            if (GlobalVersion > LocalVersion && !isFromStartup)
            {
                MessageBox.Show("Update verfügbar!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //update available

                if (isFromStartup)
                {
                    pnlMods.BringToFront();
                    btnMods.Checked = true;
                }

                prgBar.Visible = true;

                wc.DownloadProgressChanged += (GlobalVersion, e) =>
                {
                    prgBar.Value = e.ProgressPercentage;
                };
                await wc.DownloadFileTaskAsync(downloadLink, $@"{modsFolder}\mods-version-{GlobalVersion}.zip");

                lineChanger($"VERSION:{GlobalVersion}", configFile, 5);

                var zip = ZipFile.Read($@"{modsFolder}\mods-version-{GlobalVersion}.zip");

                zip.ExtractAll(modsFolder, ExtractExistingFileAction.OverwriteSilently);
                zip.Dispose();

                File.Delete($@"{modsFolder}\mods-version-{GlobalVersion}.zip");

                UpdateModList();

                MessageBox.Show("Alle mods sind up-to-date!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                prgBar.Visible = false;
            }
            else
            {
                if (!isFromStartup)
                    MessageBox.Show("Keine Updates Verfügbar!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void UpdateModList()
        {
            dgvMods.Rows.Clear();
            DirectoryInfo di = new DirectoryInfo(modsFolder);
            FileInfo[] files = di.GetFiles();
            foreach (FileInfo file in files)
            {
                dgvMods.Rows.Add(file.Name);
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            if (!Directory.Exists(configFolder))
                Directory.CreateDirectory(configFolder);

            if (!File.Exists(configFile))
                File.WriteAllText(configFile, "Verändere hier bitte nichts!\nFIRST_STARTUP:1\nMINECRAFT_PATH:?\nUSERNAME:\nVERSION:1");

            foreach (var line in File.ReadAllLines(configFile))
            {
                if (line.StartsWith("FIRST_STARTUP:"))
                {
                    if (line.Split(':')[1].ToString() == "1")
                    {
                        MessageBox.Show("Bevor du den Launcher richtig nutzt, bitte ich dich ein paar Einstellungen vorzunehmen!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lineChanger("FIRST_STARTUP:0", configFile, 2);
                        btnSettings.Checked = true;
                        pnlSettings.BringToFront();
                    } 
                    else if (line.Split(':')[1].ToString() == "0")
                    {
                        pnlStart.BringToFront();
                        btnPlay.Checked = true;
                    }
                }

                if (line.StartsWith("MINECRAFT_PATH:"))
                {
                    try
                    {
                        MCPath = line.Split(':')[1].ToString() + ":" + line.Split(':')[2].ToString();
                        txtMCPath.Text = MCPath;
                    }
                    catch { }
                }

                if (line.StartsWith("USERNAME:"))
                {
                    Username = line.Split(':')[1].ToString();
                    txtUsername.Text = Username;
                }

                if (line.StartsWith("VERSION:"))
                {
                    LocalVersion = Convert.ToInt32(line.Split(':')[1].ToString());
                }
            }
            checkForUpdates(true);
            UpdateModList();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            pnlStart.BringToFront();
            pnlMods.SendToBack();
            pnlNews.SendToBack();
            pnlSettings.SendToBack();
        }

        private void btnMods_Click(object sender, EventArgs e)
        {
            pnlMods.BringToFront();
            pnlNews.SendToBack();
            pnlStart.SendToBack();
            pnlSettings.SendToBack();
        }

        private void btnNews_Click(object sender, EventArgs e)
        {
            pnlNews.BringToFront();
            pnlMods.SendToBack();
            pnlStart.SendToBack();
            pnlSettings.SendToBack();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlSettings.BringToFront();
            pnlStart.SendToBack();
            pnlNews.SendToBack();
            pnlMods.SendToBack();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(MCPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSelectMCPath_Click(object sender, EventArgs e)
        {
            if (ofdMCPath.ShowDialog() == DialogResult.OK)
            {
                txtMCPath.Text = ofdMCPath.FileName;
                lineChanger($@"MINECRAFT_PATH:{txtMCPath.Text}", configFile, 3);
                ofdMCPath.Dispose();

                foreach (var line in File.ReadAllLines(configFile))
                {
                    if (line.StartsWith("MINECRAFT_PATH:"))
                    {
                        MCPath = line.Split(':')[1].ToString() + ":" + line.Split(':')[2].ToString();
                    }
                }
            }
        }

        private void btnSuggestion_Click(object sender, EventArgs e)
        {
            pnlSuggestion.BringToFront();
            pnlChangelog.SendToBack();
        }

        private void btnChangelog_Click(object sender, EventArgs e)
        {
            pnlChangelog.BringToFront();
            pnlSuggestion.SendToBack();
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            Username = txtUsername.Text;
            lineChanger($"USERNAME:{Username}", configFile, 4);

            txtMCPath.Text = MCPath;
        }

        private void btnSendSuggestion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSuggestion.Text) || txtSuggestion.Text == "" && string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Du musst einen validen Nutzernamen in den Settings angeben und eine Nachricht schreiben, sonst kann ja nichts verschickt werden :=)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    WebhookObject obj = new WebhookObject()
                    {
                        username = "POM22a MC Launcher",
                        content = $"**{Username}** hat eine Empfehlung:\n{txtSuggestion.Text}"
                    };

                    webhook.PostData(obj);
                    MessageBox.Show("Deine Empfehlung wurde verschickt!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }           
        }

        private void btnCheckForUpdates_Click(object sender, EventArgs e)
        {
            checkForUpdates(false);
        }

        private void btnReloadMods_Click(object sender, EventArgs e)
        {
            UpdateModList();
        }
    }
}
