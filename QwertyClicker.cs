using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Net;
using System.Reflection;
using Siticone.Desktop.UI.WinForms;
using YamlDotNet.Core.Tokens;
using System.IO.Compression;
using System;

namespace QwertyClicker
{
    public partial class QwertyClicker : Form
    {
        public bool soundClicks = false;
        public Discord? RPC;

        public QwertyClicker()
        {
            InitializeComponent();
            Logger.info("Initilized all components!");
            this.StartDiscordRPC();
        }

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.Dll", EntryPoint = "PostMessageA")]
        private static extern bool PostMessage(IntPtr hWnd, uint msg, int wParam, int lParam);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        private void moveWindow(object sender, MouseEventArgs ev)
        {
            if (ev.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        private void updateCPS(object sender, EventArgs ev)
        {
            CPSValue.Text = CPSTrackbar.Value + " CPS";
            if (CPSTrackbar.Value > 19)
            {
                ClickSoundsSwitch.Enabled = false;
                if (SoundClickVolumeTrackbar.Enabled) SoundClickVolumeTrackbar.Enabled = false;
            } else
            {
                ClickSoundsSwitch.Enabled = true;
                if (ClickSoundsSwitch.Checked) SoundClickVolumeTrackbar.Enabled = true;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.StopDiscordRPC();
            Application.Exit();
            Logger.notice("Exiting...");
        }

        private void DiscordLink_Open(object sender, EventArgs ev) => Process.Start("https://discord.gg/9QApUXEvpJ");
        private void GithubLink_Open(object sender, EventArgs ev) => Process.Start("https://github.com/QwertyDevelopment");
        private void WebsiteLink_Open(object sender, EventArgs ev) => Process.Start("https://qwertydev.tk/");

        private void DownloadSoundClicks(object sender, EventArgs ev)
        {
            if (ClickSoundsSwitch.Checked)
            {
                if (!File.Exists(Path.GetTempPath() + "\\Clicks.wav"))
                {
                    try
                    {
                        var WebClient = new WebClient(); // I know this method is obsolete but its better than HttpClient
                        WebClient.DownloadFileAsync(new Uri("https://raw.githubusercontent.com/QwertyDevelopment/QwertyClicker/blob/main/Clicks.wav"), Path.GetTempPath() + "\\Clicks.wav");
                        LoggerLabel.Text = "Downloading: 0%";
                        WebClient.DownloadProgressChanged += (s, e) =>
                        {
                            LoggerLabel.Text = "Downloading: " + e.ProgressPercentage;
                            Logger.info("Downloading Sound Clicks: " + e.ProgressPercentage);
                        };
                        WebClient.DownloadFileCompleted += (s, e) =>
                        {
                            LoggerLabel.Text = "Downloaded Sound Clicks!";
                            Logger.notice("Downloaded Sound Clicks!");
                        };
                    }
                    catch (WebException error)
                    {
                        LoggerLabel.Text = "Download Failed.";
                        Logger.error("Download Failed: " + error.Message);
                        Logger.error("Unable to download required files...");
                        ErrorDownloading.Show();
                        ClickSoundsSwitch.Checked = false;
                    };
                }
                else
                {
                    LoggerLabel.Text = "Enabled Sound Clicks!";
                    this.soundClicks = true;
                    Logger.notice("Enabled Sound Clicks!");
                    SoundClickVolumeTrackbar.Enabled = true;
                }
            } else
            {
                Logger.notice("Disabled Sound Clicks!");
                LoggerLabel.Text = "Disabled Sound Clicks!";
                this.soundClicks = false;
                SoundClickVolumeTrackbar.Enabled = false;
            }
        }

        private void CheckUpdates()
        {
            var WebClient = new WebClient { Encoding = System.Text.Encoding.UTF8 };
            try
            {
                if (Version.Parse(WebClient.DownloadString("https://raw.githubusercontent.com/QwertyDevelopment/QwertyClicker/blob/main/version.txt")) > Version.Parse(Assembly.GetEntryAssembly().GetName().Version.ToString()))
                {
                    if (NewUpdateDialog.Show() == DialogResult.Yes)
                    {
                        this.UpdateSoftware();
                    }
                }
            }
            catch
            {
                Logger.error("Unable to download required files to update!");
                ErrorDownloading.Show();
                return;
            }
        }

        private void UpdateSoftware()
        {
            var WebClient = new WebClient();

            try
            {
                WebClient.DownloadDataAsync(new Uri("https://raw.githubusercontent.com/QwertyDevelopment/QwertyClicker/releases/latest/QwertyClicker.zip"), Path.GetTempPath() + "\\QwertyClicker.zip");
                WebClient.DownloadProgressChanged += (s, e) =>
                {
                    LoggerLabel.Text = "Downloading: " + e.ProgressPercentage;
                    Logger.info("Downloading Latest Version: " + e.ProgressPercentage);
                };
                WebClient.DownloadFileCompleted += (s, e) =>
                {
                    LoggerLabel.Text = "Downloaded Latest Version!";
                    Logger.notice("Downloaded Latest Version!");
                    this.RunNewUpdate();
                };
            } catch (WebException error)
            {
                LoggerLabel.Text = "Download Failed.";
                Logger.error("Download Failed: " + error.Message);
                Logger.error("Unable to download required files...");
                ErrorDownloading.Show();
            }
        }

        private void RunNewUpdate()
        {
            try
            {
                Logger.notice("Initilizing new update..");
                File.Move(Path.GetTempPath() + "\\QwertyClicker.zip", Directory.GetCurrentDirectory() + "\\QwertyClicker.zip");
                Directory.Delete(Directory.GetCurrentDirectory());
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\QwertyClicker_New");
                ZipFile.ExtractToDirectory(Directory.GetCurrentDirectory() + "\\QwertyClicker.zip", Directory.GetCurrentDirectory() + "\\QwertyClicker_New");
                Process.Start(Directory.GetCurrentDirectory() + "\\QwertyzClicker_New\\QwertyClicker.exe");
                Logger.notice("Initilized!");
                Logger.notice("Exiting...");
                Application.Exit();
            } catch
            {
                RunUpdateError.Show();
            }
        }

        private IntPtr hWnd;

        private void StartAutoClicker()
        {
            Logger.notice("Autoclicking Timer has started.");
            Timer.Start();
        }

        public async void AutoClickerTask(object sender, EventArgs ev)
        {
            if (OnlyMinecraftSwitch.Checked)
            {
                Process[] processes = Process.GetProcesses();
                foreach (Process clsProcess in processes)
                {
                    if (GetForegroundWindow() == clsProcess.MainWindowHandle)
                    {
                        this.hWnd = FindWindow(null, clsProcess.ProcessName);
                    }
                }

                string? CurrentWindow = this.getActiveWindowName();
                if (CurrentWindow == null)
                {
                    return;
                }

                if (CurrentWindow.Contains("javaw") || CurrentWindow.Contains("minecraft.windows")) // support bedrock and java
                {
                    if (LeftClickCheckbox.Checked)
                    {
                        if (MouseButtons == MouseButtons.Left)
                        {
                            PostMessage(hWnd, 0x0201, 0, 0);
                            await Task.Delay(30);
                            PostMessage(hWnd, 0x0202, 0, 0);
                        }
                    }
                    else if (RightClickCheckbox.Checked)
                    {
                        if (MouseButtons == MouseButtons.Right)
                        {
                            PostMessage(hWnd, 0x0204, 0, 0);
                            await Task.Delay(30);
                            PostMessage(hWnd, 0x0205, 0, 0);
                        }
                    }
                }
            }
            else
            {
                Process[] processes = Process.GetProcesses();
                foreach (Process clsProcess in processes)
                {
                    if (GetForegroundWindow() == clsProcess.MainWindowHandle)
                    {
                        this.hWnd = FindWindow(null, clsProcess.ProcessName);
                    }
                }

                string? currentwindow = this.getActiveWindowName();
                if (LeftClickCheckbox.Checked)
                {
                    if (MouseButtons == MouseButtons.Left)
                    {
                        PostMessage(hWnd, 0x0201, 0, 0);
                        await Task.Delay(30);
                        PostMessage(hWnd, 0x0202, 0, 0);
                    }
                }
                else if (RightClickCheckbox.Checked)
                {
                    if (MouseButtons == MouseButtons.Right)
                    {
                        PostMessage(hWnd, 0x0204, 0, 0);
                        await Task.Delay(30);
                        PostMessage(hWnd, 0x0205, 0, 0);
                    }
                }
            }
        }

        public string ?getActiveWindowName()
        {
            try
            {
                var activateHandle = GetForegroundWindow();

                Process[] processes = Process.GetProcesses();
                foreach (Process clsProcess in processes)
                {
                    if (activateHandle == clsProcess.MainWindowHandle)
                    {
                        string processName = clsProcess.ProcessName;
                        return processName;
                    }
                }
            }
            catch { }
            return null;
        }

        public void StopAutoClicker()
        {
            Logger.notice("Autoclicking Timer has stopped.");
            Timer.Stop();
        }

        public void StartDiscordRPC()
        {
            Logger.info("Starting discord rich presence...");
            this.RPC = new Discord("1057226850524479529");
            this.RPC.Start();
        }

        public void StopDiscordRPC()
        {
            Logger.info("Stopping discord rich presence...");
            if(this.RPC != null)
            {
                this.RPC.Stop();
            } else
            {
                Logger.error("Rich presence is not started yet...");
            }
        }

        private void Minimize_Click(object sender, EventArgs ev) => Logger.notice("Minimizing...");

        private void MenuPrompt(object sender, MouseEventArgs ev)
        {
            if (ev.Button == MouseButtons.Right)
            {
                Menu.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e) => this.CheckUpdates();

        private void UpdateMenu_Click(object sender, EventArgs e) => this.CheckUpdates();

        private void ChangeSoundClicksVolume(object sender, EventArgs e)
        {
            ClicksVolumeLabel.Text = "Sound Clicks Volume: " + SoundClickVolumeTrackbar.Value + "%";
        }

        private void RPCSwitch_Toggle(object sender, EventArgs e)
        {
            if (RPCSwitch.Checked)
            {
                this.StartDiscordRPC();
                LoggerLabel.Text = "Enabled Discord RPC!";
            } else
            {
                this.StopDiscordRPC();
                LoggerLabel.Text = "Disabled Discord RPC!";
            }
        }

        private void Toggle_Click(object sender, EventArgs e)
        {
            if(Toggle.Text == "Enable")
            {
                Toggle.Text = "Disable";
                this.StartAutoClicker();
            } else
            {
                Toggle.Text = "Enable";
                this.StopAutoClicker();
            }
        }

        private void LeftClickCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (RightClickCheckbox.Enabled)
            {
                RightClickCheckbox.Enabled = false;
            } else
            {
                RightClickCheckbox.Enabled = true;
            }
        }

        private void RightClickCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (LeftClickCheckbox.Enabled)
            {
                LeftClickCheckbox.Enabled = false;
            }
            else
            {
                LeftClickCheckbox.Enabled = true;
            }
        }
    }
}