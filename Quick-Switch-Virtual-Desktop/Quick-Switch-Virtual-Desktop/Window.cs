using System.IO;
using Microsoft.Win32;
using System.Runtime.CompilerServices;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using Windows.ApplicationModel.VoiceCommands;
using WindowsDesktop;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using System.Drawing.Imaging;
using System;
using System.Windows.Forms;

namespace Quick_Switch_Virtual_Desktop
{
    public partial class Window : Form
    {
        bool alternatSwitch = true;
        bool pinned = false;
        bool borderOn = false;

        bool windowSettingsRestoreTriggered = false;
        bool windowSettingsRestored = false;

        VirtualDesktop[] allDesktops;
        Color desktopdefaultBackColor;
        Color desktopHighlightBackColor;

        VirtualDesktop previousDesktop = null;
        int elapsedSeconds = 0;
        int currentDesktopNumber = 1;

        bool notesLoadedOnStart = false;
        bool settingsFileInitialized = false;
        bool settingsFileInitializeTriggered = false;

        public Window()
        {
            InitializeComponent();

            desktopdefaultBackColor = link1.BackColor;
            desktopHighlightBackColor = System.Drawing.SystemColors.ControlDark;

            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Elapsed += new ElapsedEventHandler(Timer_Elapsed);

            allDesktops = VirtualDesktop.GetDesktops();

            ShowInTaskbar = false;

            /* 
            //IMPORTANT NOTE : if debugging, change following properties manually in Window.Designer.cs
            FormBorderStyle = FormBorderStyle.FixedToolWindow; // set to "FormBorderStyle.None" in Window.Designer.cs - to make the window look small on load            
            menuStrip1.Visible = true; // set to "false" in Window.Designer.cs
            */


            LocationChanged += new EventHandler(Window_Moved);
        }

        void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            while (!this.IsHandleCreated)
                System.Threading.Thread.Sleep(100);

            switchBtn.Invoke((Action)delegate
            {
                regularUpdate();

            });
        }


        void regularUpdate()
        {
            //Copy default settings to application data folder manually, unless done by msi package            
            if(File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + "anancodes" + "\\" + "settings.txt"))
            {
                settingsFileInitializeTriggered = true;
                settingsFileInitialized = true;
            }

            if(!settingsFileInitializeTriggered)
            {
                settingsFileInitializeTriggered = true; // right now, this block is executed multiple times without this preventing variable
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + "anancodes");

                File.Copy("default\\settings.txt", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + "anancodes" + "\\" + "settings.txt");
                File.Copy("default\\1.txt", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + "anancodes" + "\\" + "1.txt");
                File.Copy("default\\2.txt", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + "anancodes" + "\\" + "2.txt");
                File.Copy("default\\3.txt", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + "anancodes" + "\\" + "3.txt");
                File.Copy("default\\4.txt", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + "anancodes" + "\\" + "4.txt");
                File.Copy("default\\5.txt", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + "anancodes" + "\\" + "5.txt");
                File.Copy("default\\6.txt", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + "anancodes" + "\\" + "6.txt");
                File.Copy("default\\7.txt", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + "anancodes" + "\\" + "7.txt");
                File.Copy("default\\8.txt", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + "anancodes" + "\\" + "8.txt");
                File.Copy("default\\9.txt", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + "anancodes" + "\\" + "9.txt");
                File.Copy("default\\10.txt", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + "anancodes" + "\\" + "10.txt");
                File.Copy("default\\11.txt", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + "anancodes" + "\\" + "11.txt");

                settingsFileInitialized = true;
            }

            //wait until settings files are copied
            if (!settingsFileInitialized)
                return;
            

            if (!pinned)
            {
                if (IsHandleCreated)
                {
                    TopMost = true;
                    MaximizeBox = false;
                    VirtualDesktop.PinWindow(Handle);

                    highlightDesktopNumber();

                    VirtualDesktop.CurrentChanged += (_, args) => desktopSwitched(args);

                    //moveToPreviousLocation();

                    pinned = true;
                }
            }

            if (pinned)
            {
                allDesktops = VirtualDesktop.GetDesktops();

                if (allDesktops.Length >= 1)
                {
                    link1.Show();
                }
                else
                {
                    link1.Hide();
                }
                if (allDesktops.Length >= 2)
                {
                    link2.Show();
                }
                else
                {
                    link2.Hide();
                }
                if (allDesktops.Length >= 3)
                {
                    link3.Show();
                }
                else
                {
                    link3.Hide();
                }
                if (allDesktops.Length >= 4)
                {
                    link4.Show();
                }
                else
                {
                    link4.Hide();
                }
                if (allDesktops.Length >= 5)
                {
                    link5.Show();
                }
                else
                {
                    link5.Hide();
                }
                if (allDesktops.Length >= 6)
                {
                    link6.Show();
                }
                else
                {
                    link6.Hide();
                }
                if (allDesktops.Length >= 7)
                {
                    link7.Show();
                }
                else
                {
                    link7.Hide();
                }
                if (allDesktops.Length >= 8)
                {
                    link8.Show();
                }
                else
                {
                    link8.Hide();
                }
                if (allDesktops.Length >= 9)
                {
                    link9.Show();
                }
                else
                {
                    link9.Hide();
                }
                if (allDesktops.Length >= 10)
                {
                    link10.Show();
                }
                else
                {
                    link10.Hide();
                }
                if (allDesktops.Length >= 11)
                {
                    link11.Show();
                }
                else
                {
                    link11.Hide();
                }

                displayTimer();
            }

            if (pinned && !windowSettingsRestoreTriggered)
            {
                windowSettingsRestoreTriggered = true;
                RestoreSettings();

                windowSettingsRestored = true;
            }
        }

        void displayTimer()
        {
            elapsedSeconds += 1;
            if (borderOn)
            {
                TimeSpan ts = TimeSpan.FromSeconds(elapsedSeconds);
                desktopTimeDisplay.Text = $"{ts.Hours}:{ts.Minutes}:{ts.Seconds}";
            }
        }

        void Window_Moved(object sender, EventArgs e)
        {
            if (windowSettingsRestored)
            {
                saveLocation(Location.X, Location.Y);
            }
        }

        void desktopSwitched(VirtualDesktopChangedEventArgs args)
        {
            if (args.OldDesktop != null)
            {
                previousDesktop = args.OldDesktop;
            }
            highlightDesktopNumber();
            elapsedSeconds = 0;
        }

        void RestoreSettings()
        {
            try
            {
                string dataFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\anancodes\\" + "settings.txt";
                string[] datalines = File.ReadAllLines(dataFile);

                string[] data;

                //Window Position
                data = datalines[0].Split(":");
                this.DesktopLocation = new System.Drawing.Point(Convert.ToInt32(data[1]), Convert.ToInt32(data[2]));

                //Window Transparency
                data = datalines[1].Split(":");
                int newT = Convert.ToInt32(Convert.ToDouble(data[1]) * 10);
                setWindowTransparency(newT);

                //Quick Switch Desktop numbers
                data = datalines[2].Split(":");
                decimal d1 = Convert.ToDecimal(data[1]);
                decimal d2 = Convert.ToDecimal(data[2]);
                desktop1.Value = d1;
                desktop2.Value = d2;

                //unknown issue, force the minimal settings on load through code, design settings does not reflect effectively on load
                FormBorderStyle = FormBorderStyle.None;
                menuStrip1.Visible = false;
                Size = new System.Drawing.Size(Size.Width, linksPanelHolder.Height + leftRightPanelHolder.Height);
                //Minimal Setting - On/Off (On load, by default, starts minimal)
                data = datalines[3].Split(":");
                if (data[1] == "1")
                {
                    ToggleMinimal();
                }

                //Run On Startup - restore checked status
                RegistryKey regKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                if (regKey != null)
                {
                    var startupEnabled = regKey.GetValue("Quick Switch Virtual Desktop");
                    if (startupEnabled != null)
                    {
                        runOnStartupToolStripMenuItem.Checked = true;
                    }
                }


                if (!notesLoadedOnStart)
                {
                    highlightDesktopNumber();
                }
            }
            catch (Exception ex)
            {
                double screen_width = SystemParameters.FullPrimaryScreenWidth;
                double screen_height = SystemParameters.FullPrimaryScreenHeight;

                //otherwise, move window to lower right corner of the screen
                int window_x = Convert.ToInt32(screen_width) - this.Width;
                int window_y = Convert.ToInt32(screen_height) - this.Height - 50;
                this.DesktopLocation = new System.Drawing.Point(window_x, window_y);
            }
        }



        private void switchBtn_Click(object sender, EventArgs e)
        {
            if (alternatSwitch)
            {
                switchTo(desktop1.Value);
            }
            else
            {
                switchTo(desktop2.Value);
            }

            alternatSwitch = !alternatSwitch;
        }

        void switchTo(decimal desktop_num)
        {
            int targetDesktopNumber = Convert.ToInt32(desktop_num - 1);
            if (targetDesktopNumber < allDesktops.Length)
            {
                allDesktops[targetDesktopNumber].Switch();
            }

        }


        static void saveLocation(int x, int y)
        {
            string w_x = x.ToString();
            string w_y = y.ToString();
            string dataFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\anancodes\\" + "settings.txt";

            string[] datalines = File.ReadAllLines(dataFile);

            datalines[0] = "windowPos:" + w_x + ":" + w_y;

            File.WriteAllLines(dataFile, datalines);
        }

        static void saveTransparency(double t)
        {
            string updatedValue = t.ToString();
            string dataFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\anancodes\\" + "settings.txt";

            string[] datalines = File.ReadAllLines(dataFile);

            datalines[1] = "T:" + updatedValue;

            File.WriteAllLines(dataFile, datalines);
        }

        void saveQuickSwitchDesktops()
        {
            string updatedDesktop1 = desktop1.Value.ToString();
            string updatedDesktop2 = desktop2.Value.ToString();
            string dataFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\anancodes\\" + "settings.txt";

            string[] datalines = File.ReadAllLines(dataFile);

            datalines[2] = "QS:" + updatedDesktop1 + ":" + updatedDesktop2;

            File.WriteAllLines(dataFile, datalines);
        }

        static void saveMinimalStatus(string m)
        {
            string dataFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\anancodes\\" + "settings.txt";

            string[] datalines = File.ReadAllLines(dataFile);

            datalines[3] = "M:" + m;

            File.WriteAllLines(dataFile, datalines);
        }

        private void switchToLeft_Click(object sender, EventArgs e)
        {
            if (VirtualDesktop.Current.GetLeft() != null)
                VirtualDesktop.Current.GetLeft().Switch();
        }

        private void switchToRight_Click(object sender, EventArgs e)
        {
            if (VirtualDesktop.Current.GetRight() != null)
                VirtualDesktop.Current.GetRight().Switch();
        }

        private void switchToPrevious_Click(object sender, EventArgs e)
        {
            if (previousDesktop != null)
            {
                previousDesktop.Switch();
            }
        }



        private void notesBox_TextChanged(object sender, EventArgs e)
        {
            var threadParameters = new System.Threading.ThreadStart(delegate { saveNotesSafe(); });
            var thread2 = new System.Threading.Thread(threadParameters);
            thread2.Start();

        }

        private void desktopTimeDisplay_Click(object sender, EventArgs e)
        {
        }

        private void desktopLinksHolder_Paint(object sender, PaintEventArgs e)
        {
        }

        private void desktop2_ValueChanged(object sender, EventArgs e)
        {
            saveQuickSwitchDesktops();
        }

        private void desktop1_ValueChanged(object sender, EventArgs e)
        {
            saveQuickSwitchDesktops();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        void ToggleMinimal()
        {
            if (borderOn)
            {
                FormBorderStyle = FormBorderStyle.None;
                minimalToolStripMenuItem.Checked = true;
                borderOn = false;
                menuStrip1.Hide();
                //leftRightPanelHolder.Hide();
                quickSwitchPanelHolder.Hide();
                notesPanelHolder.Hide();
                desktopTimeDisplayHolder.Hide();
                Size = new System.Drawing.Size(Size.Width, linksPanelHolder.Height + leftRightPanelHolder.Height);

                if (windowSettingsRestored) // do not save if restoring from file for the first time on load
                {
                    saveMinimalStatus("0");
                }

                //unknown issue, on minimal setting change, gets unpinned randomly, so force pin everytime
                VirtualDesktop.PinWindow(Handle);
            }
            else
            {
                FormBorderStyle = FormBorderStyle.FixedToolWindow;
                minimalToolStripMenuItem.Checked = false;
                borderOn = true;
                menuStrip1.Show();
                //leftRightPanelHolder.Show();
                quickSwitchPanelHolder.Show();
                notesPanelHolder.Show();
                desktopTimeDisplayHolder.Show();
                Size = new System.Drawing.Size(Size.Width, mainFlowLayout.Height + desktopTimeDisplayHolder.Height); // desktop time panel is not a flow layout panel, so adding manually makes sure the time display is not hidden

                //not reloaded when on minimal setting
                loadCurrentDesktopNotes();

                if (windowSettingsRestored)
                {
                    saveMinimalStatus("1");
                }

                VirtualDesktop.PinWindow(Handle);
            }
        }

        private void minimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleMinimal();
        }

        private void runOnStartupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!runOnStartupToolStripMenuItem.Checked)
            {
                RegistryKey regKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                regKey.SetValue("Quick Switch Virtual Desktop", System.Windows.Forms.Application.ExecutablePath.ToString());

                runOnStartupToolStripMenuItem.Checked = true;
            }
            else
            {
                RegistryKey regKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                if (regKey.GetValue("Quick Switch Virtual Desktop") != null)
                    regKey.DeleteValue("Quick Switch Virtual Desktop");

                runOnStartupToolStripMenuItem.Checked = false;
            }

        }

        private void minimalToggleBtn_Click(object sender, EventArgs e)
        {
            ToggleMinimal();
        }

        private void link1_Click(object sender, EventArgs e)
        {
            switchTo(1);
        }

        private void link2_Click(object sender, EventArgs e)
        {
            switchTo(2);
        }

        private void link3_Click(object sender, EventArgs e)
        {
            switchTo(3);
        }

        private void link4_Click(object sender, EventArgs e)
        {
            switchTo(4);
        }

        private void link5_Click(object sender, EventArgs e)
        {
            switchTo(5);
        }

        private void link6_Click(object sender, EventArgs e)
        {
            switchTo(6);
        }

        private void link7_Click(object sender, EventArgs e)
        {
            switchTo(7);
        }

        private void link8_Click(object sender, EventArgs e)
        {
            switchTo(8);
        }

        private void link9_Click(object sender, EventArgs e)
        {
            switchTo(9);
        }

        private void link10_Click(object sender, EventArgs e)
        {
            switchTo(10);
        }

        private void link11_Click(object sender, EventArgs e)
        {
            switchTo(11);
        }

        void clearHighlightDesktopNumbers()
        {
            link1.BackColor = desktopdefaultBackColor;
            link2.BackColor = desktopdefaultBackColor;
            link3.BackColor = desktopdefaultBackColor;
            link4.BackColor = desktopdefaultBackColor;
            link5.BackColor = desktopdefaultBackColor;
            link6.BackColor = desktopdefaultBackColor;
            link7.BackColor = desktopdefaultBackColor;
            link8.BackColor = desktopdefaultBackColor;
            link9.BackColor = desktopdefaultBackColor;
            link10.BackColor = desktopdefaultBackColor;
            link11.BackColor = desktopdefaultBackColor;
        }

        void loadCurrentDesktopNotes()
        {
            var threadParameters = new System.Threading.ThreadStart(delegate { loadNotesSafe(currentDesktopNumber); });
            var thread2 = new System.Threading.Thread(threadParameters);
            thread2.Start();
        }

        void highlightDesktopNumber()
        {
            notesLoadedOnStart = true;

            int desktopNumber = 0;
            for (int i = 0; i < allDesktops.Length; i++)
            {
                if (VirtualDesktop.Current.Id == allDesktops[i].Id)
                {
                    desktopNumber = i + 1;
                }
            }
            currentDesktopNumber = desktopNumber;

            if (borderOn)
            {
                loadCurrentDesktopNotes();
            }


            clearHighlightDesktopNumbers();

            switch (desktopNumber)
            {
                case 1: link1.BackColor = desktopHighlightBackColor; break;
                case 2: link2.BackColor = desktopHighlightBackColor; break;
                case 3: link3.BackColor = desktopHighlightBackColor; break;
                case 4: link4.BackColor = desktopHighlightBackColor; break;
                case 5: link5.BackColor = desktopHighlightBackColor; break;
                case 6: link6.BackColor = desktopHighlightBackColor; break;
                case 7: link7.BackColor = desktopHighlightBackColor; break;
                case 8: link8.BackColor = desktopHighlightBackColor; break;
                case 9: link9.BackColor = desktopHighlightBackColor; break;
                case 10: link10.BackColor = desktopHighlightBackColor; break;
                case 11: link11.BackColor = desktopHighlightBackColor; break;
                default: break;
            }
        }

        void saveNotes(bool clear = false)
        {
            string dataFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\anancodes\\" + currentDesktopNumber + ".txt";
            if (File.Exists(dataFile))
            {
                if (clear)
                {
                    notesBox.Text = "";
                    File.WriteAllText(dataFile, "");
                }
                else
                {
                    File.WriteAllText(dataFile, notesBox.Text);
                }
            }
        }

        private void clearNotesBtn_Click(object sender, EventArgs e)
        {
            var threadParameters = new System.Threading.ThreadStart(delegate { saveNotesSafe(true); });
            var thread2 = new System.Threading.Thread(threadParameters);
            thread2.Start();

        }

        void loadNotes(int dNum)
        {
            string dataFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\anancodes\\" + dNum + ".txt";
            if (File.Exists(dataFile))
            {
                string dataText = File.ReadAllText(dataFile);

                notesBox.Text = dataText;
            }

        }

        public void loadNotesSafe(int dNum)
        {
            if (notesBox.InvokeRequired)
            {
                Action safeWrite = delegate { loadNotesSafe(dNum); };
                notesBox.Invoke(safeWrite);
            }
            else
                loadNotes(dNum);
        }

        public void saveNotesSafe(bool clearFlag = false)
        {
            if (notesBox.InvokeRequired)
            {
                Action safeWrite = delegate { saveNotesSafe(clearFlag); };
                notesBox.Invoke(safeWrite);
            }
            else
                saveNotes(clearFlag);
        }

        void clearTicksForTransparentMenuItems()
        {
            toolStripMenuItem10T.Checked = false;
            toolStripMenuItem20T.Checked = false;
            toolStripMenuItem30T.Checked = false;
            toolStripMenuItem40T.Checked = false;
            toolStripMenuItem50T.Checked = false;
            toolStripMenuItem60T.Checked = false;
            toolStripMenuItem70T.Checked = false;
            toolStripMenuItem80T.Checked = false;
            toolStripMenuItem90T.Checked = false;
            opaqueToolStripMenuItem.Checked = false;
        }

        private void toolStripMenuItem10T_Click(object sender, EventArgs e)
        {
            setWindowTransparency(1);
            saveTransparency(0.1);
        }

        private void toolStripMenuItem20T_Click(object sender, EventArgs e)
        {
            setWindowTransparency(2);
            saveTransparency(0.2);
        }

        private void toolStripMenuItem30T_Click(object sender, EventArgs e)
        {
            setWindowTransparency(3);
            saveTransparency(0.3);
        }

        private void toolStripMenuItem40T_Click(object sender, EventArgs e)
        {
            setWindowTransparency(4);
            saveTransparency(0.4);
        }

        private void toolStripMenuItem50T_Click(object sender, EventArgs e)
        {
            setWindowTransparency(5);
            saveTransparency(0.5);
        }

        private void toolStripMenuItem60T_Click(object sender, EventArgs e)
        {
            setWindowTransparency(6);
            saveTransparency(0.6);
        }

        private void toolStripMenuItem70T_Click(object sender, EventArgs e)
        {
            setWindowTransparency(7);
            saveTransparency(0.7);
        }

        private void toolStripMenuItem80T_Click(object sender, EventArgs e)
        {
            setWindowTransparency(8);
            saveTransparency(0.8);
        }

        private void toolStripMenuItem90T_Click(object sender, EventArgs e)
        {
            setWindowTransparency(9);
            saveTransparency(0.9);
        }

        private void opaqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setWindowTransparency(10);
            saveTransparency(1);
        }

        void setWindowTransparency(int t)
        {
            clearTicksForTransparentMenuItems();
            switch (t)
            {
                case 1:
                    toolStripMenuItem10T.Checked = true;
                    Opacity = 0.1;
                    break;
                case 2:
                    toolStripMenuItem20T.Checked = true;
                    Opacity = 0.2;
                    break;
                case 3:
                    toolStripMenuItem30T.Checked = true;
                    Opacity = 0.3;
                    break;
                case 4:
                    toolStripMenuItem40T.Checked = true;
                    Opacity = 0.4;
                    break;
                case 5:
                    toolStripMenuItem50T.Checked = true;
                    Opacity = 0.5;
                    break;
                case 6:
                    toolStripMenuItem60T.Checked = true;
                    Opacity = 0.6;
                    break;
                case 7:
                    toolStripMenuItem70T.Checked = true;
                    Opacity = 0.7;
                    break;
                case 8:
                    toolStripMenuItem80T.Checked = true;
                    Opacity = 0.8;
                    break;
                case 9:
                    toolStripMenuItem90T.Checked = true;
                    Opacity = 0.9;
                    break;
                case 10:
                    opaqueToolStripMenuItem.Checked = true;
                    Opacity = 1;
                    break;

                default: break;
            }
        }
    }

}