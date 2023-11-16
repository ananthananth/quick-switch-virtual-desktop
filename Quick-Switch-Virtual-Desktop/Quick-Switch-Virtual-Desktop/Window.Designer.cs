namespace Quick_Switch_Virtual_Desktop
{
    partial class Window
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            switchBtn = new Button();
            desktop1 = new NumericUpDown();
            desktop2 = new NumericUpDown();
            link1 = new Button();
            desktopLinksHolder = new FlowLayoutPanel();
            link2 = new Button();
            link3 = new Button();
            link4 = new Button();
            link5 = new Button();
            link6 = new Button();
            link7 = new Button();
            link8 = new Button();
            link9 = new Button();
            link10 = new Button();
            link11 = new Button();
            minimalToggleBtn = new Button();
            desktopTimeDisplay = new Label();
            notesBox = new RichTextBox();
            switchToLeft = new Button();
            switchToRight = new Button();
            switchToPrevious = new Button();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            minimalToolStripMenuItem = new ToolStripMenuItem();
            runOnStartupToolStripMenuItem = new ToolStripMenuItem();
            transparencyToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem10T = new ToolStripMenuItem();
            toolStripMenuItem20T = new ToolStripMenuItem();
            toolStripMenuItem30T = new ToolStripMenuItem();
            toolStripMenuItem40T = new ToolStripMenuItem();
            toolStripMenuItem50T = new ToolStripMenuItem();
            toolStripMenuItem60T = new ToolStripMenuItem();
            toolStripMenuItem70T = new ToolStripMenuItem();
            toolStripMenuItem80T = new ToolStripMenuItem();
            toolStripMenuItem90T = new ToolStripMenuItem();
            opaqueToolStripMenuItem = new ToolStripMenuItem();
            mainFlowLayout = new FlowLayoutPanel();
            linksPanelHolder = new Panel();
            leftRightPanelHolder = new FlowLayoutPanel();
            quickSwitchPanelHolder = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            notesPanelHolder = new FlowLayoutPanel();
            clearNotesBtn = new Button();
            desktopTimeDisplayHolder = new Panel();
            ((System.ComponentModel.ISupportInitialize)desktop1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)desktop2).BeginInit();
            desktopLinksHolder.SuspendLayout();
            menuStrip1.SuspendLayout();
            mainFlowLayout.SuspendLayout();
            linksPanelHolder.SuspendLayout();
            leftRightPanelHolder.SuspendLayout();
            quickSwitchPanelHolder.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            notesPanelHolder.SuspendLayout();
            desktopTimeDisplayHolder.SuspendLayout();
            SuspendLayout();
            // 
            // switchBtn
            // 
            switchBtn.Location = new Point(0, 0);
            switchBtn.Margin = new Padding(0);
            switchBtn.Name = "switchBtn";
            switchBtn.Size = new Size(235, 55);
            switchBtn.TabIndex = 0;
            switchBtn.Text = "SWITCH";
            switchBtn.UseVisualStyleBackColor = true;
            switchBtn.Click += switchBtn_Click;
            // 
            // desktop1
            // 
            desktop1.Location = new Point(0, 3);
            desktop1.Margin = new Padding(0, 3, 0, 0);
            desktop1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            desktop1.Name = "desktop1";
            desktop1.Size = new Size(44, 23);
            desktop1.TabIndex = 1;
            desktop1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            desktop1.ValueChanged += desktop1_ValueChanged;
            // 
            // desktop2
            // 
            desktop2.Location = new Point(0, 29);
            desktop2.Margin = new Padding(0, 3, 0, 0);
            desktop2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            desktop2.Name = "desktop2";
            desktop2.Size = new Size(44, 23);
            desktop2.TabIndex = 2;
            desktop2.Value = new decimal(new int[] { 2, 0, 0, 0 });
            desktop2.ValueChanged += desktop2_ValueChanged;
            // 
            // link1
            // 
            link1.Location = new Point(0, 0);
            link1.Margin = new Padding(0);
            link1.Name = "link1";
            link1.Size = new Size(22, 26);
            link1.TabIndex = 5;
            link1.Text = "1";
            link1.UseVisualStyleBackColor = true;
            link1.Click += link1_Click;
            // 
            // desktopLinksHolder
            // 
            desktopLinksHolder.Controls.Add(link1);
            desktopLinksHolder.Controls.Add(link2);
            desktopLinksHolder.Controls.Add(link3);
            desktopLinksHolder.Controls.Add(link4);
            desktopLinksHolder.Controls.Add(link5);
            desktopLinksHolder.Controls.Add(link6);
            desktopLinksHolder.Controls.Add(link7);
            desktopLinksHolder.Controls.Add(link8);
            desktopLinksHolder.Controls.Add(link9);
            desktopLinksHolder.Controls.Add(link10);
            desktopLinksHolder.Controls.Add(link11);
            desktopLinksHolder.Location = new Point(0, 0);
            desktopLinksHolder.Margin = new Padding(0);
            desktopLinksHolder.Name = "desktopLinksHolder";
            desktopLinksHolder.Size = new Size(253, 28);
            desktopLinksHolder.TabIndex = 6;
            desktopLinksHolder.Paint += desktopLinksHolder_Paint;
            // 
            // link2
            // 
            link2.Location = new Point(22, 0);
            link2.Margin = new Padding(0);
            link2.Name = "link2";
            link2.Size = new Size(22, 26);
            link2.TabIndex = 6;
            link2.Text = "2";
            link2.UseVisualStyleBackColor = true;
            link2.Click += link2_Click;
            // 
            // link3
            // 
            link3.Location = new Point(44, 0);
            link3.Margin = new Padding(0);
            link3.Name = "link3";
            link3.Size = new Size(22, 26);
            link3.TabIndex = 7;
            link3.Text = "3";
            link3.UseVisualStyleBackColor = true;
            link3.Click += link3_Click;
            // 
            // link4
            // 
            link4.Location = new Point(66, 0);
            link4.Margin = new Padding(0);
            link4.Name = "link4";
            link4.Size = new Size(22, 26);
            link4.TabIndex = 8;
            link4.Text = "4";
            link4.UseVisualStyleBackColor = true;
            link4.Click += link4_Click;
            // 
            // link5
            // 
            link5.Location = new Point(88, 0);
            link5.Margin = new Padding(0);
            link5.Name = "link5";
            link5.Size = new Size(22, 26);
            link5.TabIndex = 9;
            link5.Text = "5";
            link5.UseVisualStyleBackColor = true;
            link5.Click += link5_Click;
            // 
            // link6
            // 
            link6.Location = new Point(110, 0);
            link6.Margin = new Padding(0);
            link6.Name = "link6";
            link6.Size = new Size(22, 26);
            link6.TabIndex = 10;
            link6.Text = "6";
            link6.UseVisualStyleBackColor = true;
            link6.Click += link6_Click;
            // 
            // link7
            // 
            link7.Location = new Point(132, 0);
            link7.Margin = new Padding(0);
            link7.Name = "link7";
            link7.Size = new Size(22, 26);
            link7.TabIndex = 11;
            link7.Text = "7";
            link7.UseVisualStyleBackColor = true;
            link7.Click += link7_Click;
            // 
            // link8
            // 
            link8.Location = new Point(154, 0);
            link8.Margin = new Padding(0);
            link8.Name = "link8";
            link8.Size = new Size(22, 26);
            link8.TabIndex = 12;
            link8.Text = "8";
            link8.UseVisualStyleBackColor = true;
            link8.Click += link8_Click;
            // 
            // link9
            // 
            link9.Location = new Point(176, 0);
            link9.Margin = new Padding(0);
            link9.Name = "link9";
            link9.Size = new Size(22, 26);
            link9.TabIndex = 13;
            link9.Text = "9";
            link9.UseVisualStyleBackColor = true;
            link9.Click += link9_Click;
            // 
            // link10
            // 
            link10.Location = new Point(198, 0);
            link10.Margin = new Padding(0);
            link10.Name = "link10";
            link10.Size = new Size(27, 26);
            link10.TabIndex = 14;
            link10.Text = "10";
            link10.UseVisualStyleBackColor = true;
            link10.Click += link10_Click;
            // 
            // link11
            // 
            link11.BackColor = SystemColors.ControlDark;
            link11.ForeColor = SystemColors.ControlText;
            link11.Location = new Point(225, 0);
            link11.Margin = new Padding(0);
            link11.Name = "link11";
            link11.Size = new Size(27, 26);
            link11.TabIndex = 15;
            link11.Text = "11";
            link11.UseVisualStyleBackColor = false;
            link11.Click += link11_Click;
            // 
            // minimalToggleBtn
            // 
            minimalToggleBtn.BackgroundImage = Properties.Resources.clip_line_icon;
            minimalToggleBtn.BackgroundImageLayout = ImageLayout.Stretch;
            minimalToggleBtn.Location = new Point(253, 1);
            minimalToggleBtn.Margin = new Padding(0);
            minimalToggleBtn.Name = "minimalToggleBtn";
            minimalToggleBtn.Size = new Size(26, 26);
            minimalToggleBtn.TabIndex = 20;
            minimalToggleBtn.UseVisualStyleBackColor = true;
            minimalToggleBtn.Click += minimalToggleBtn_Click;
            // 
            // desktopTimeDisplay
            // 
            desktopTimeDisplay.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            desktopTimeDisplay.Location = new Point(17, 0);
            desktopTimeDisplay.Name = "desktopTimeDisplay";
            desktopTimeDisplay.Size = new Size(241, 32);
            desktopTimeDisplay.TabIndex = 7;
            desktopTimeDisplay.Text = "00:00:00";
            desktopTimeDisplay.TextAlign = ContentAlignment.MiddleCenter;
            desktopTimeDisplay.Click += desktopTimeDisplay_Click;
            // 
            // notesBox
            // 
            notesBox.BorderStyle = BorderStyle.FixedSingle;
            notesBox.Location = new Point(0, 0);
            notesBox.Margin = new Padding(0);
            notesBox.Name = "notesBox";
            notesBox.Size = new Size(256, 49);
            notesBox.TabIndex = 8;
            notesBox.Text = "";
            notesBox.WordWrap = false;
            notesBox.TextChanged += notesBox_TextChanged;
            // 
            // switchToLeft
            // 
            switchToLeft.Location = new Point(0, 0);
            switchToLeft.Margin = new Padding(0);
            switchToLeft.Name = "switchToLeft";
            switchToLeft.Size = new Size(77, 26);
            switchToLeft.TabIndex = 15;
            switchToLeft.Text = "Left";
            switchToLeft.UseVisualStyleBackColor = true;
            switchToLeft.Click += switchToLeft_Click;
            // 
            // switchToRight
            // 
            switchToRight.Location = new Point(77, 0);
            switchToRight.Margin = new Padding(0);
            switchToRight.Name = "switchToRight";
            switchToRight.Size = new Size(77, 26);
            switchToRight.TabIndex = 16;
            switchToRight.Text = "Right";
            switchToRight.UseVisualStyleBackColor = true;
            switchToRight.Click += switchToRight_Click;
            // 
            // switchToPrevious
            // 
            switchToPrevious.Location = new Point(154, 0);
            switchToPrevious.Margin = new Padding(0);
            switchToPrevious.Name = "switchToPrevious";
            switchToPrevious.Size = new Size(125, 26);
            switchToPrevious.TabIndex = 17;
            switchToPrevious.Text = "Previous";
            switchToPrevious.UseVisualStyleBackColor = true;
            switchToPrevious.Click += switchToPrevious_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(189, 24);
            menuStrip1.TabIndex = 18;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.Visible = false;
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { minimalToolStripMenuItem, runOnStartupToolStripMenuItem, transparencyToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(61, 20);
            menuToolStripMenuItem.Text = "Settings";
            menuToolStripMenuItem.Click += menuToolStripMenuItem_Click;
            // 
            // minimalToolStripMenuItem
            // 
            minimalToolStripMenuItem.Name = "minimalToolStripMenuItem";
            minimalToolStripMenuItem.Size = new Size(153, 22);
            minimalToolStripMenuItem.Text = "Minimal";
            minimalToolStripMenuItem.Click += minimalToolStripMenuItem_Click;
            // 
            // runOnStartupToolStripMenuItem
            // 
            runOnStartupToolStripMenuItem.Name = "runOnStartupToolStripMenuItem";
            runOnStartupToolStripMenuItem.Size = new Size(153, 22);
            runOnStartupToolStripMenuItem.Text = "Run on Startup";
            runOnStartupToolStripMenuItem.Click += runOnStartupToolStripMenuItem_Click;
            // 
            // transparencyToolStripMenuItem
            // 
            transparencyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem10T, toolStripMenuItem20T, toolStripMenuItem30T, toolStripMenuItem40T, toolStripMenuItem50T, toolStripMenuItem60T, toolStripMenuItem70T, toolStripMenuItem80T, toolStripMenuItem90T, opaqueToolStripMenuItem });
            transparencyToolStripMenuItem.Name = "transparencyToolStripMenuItem";
            transparencyToolStripMenuItem.Size = new Size(153, 22);
            transparencyToolStripMenuItem.Text = "Transparency";
            // 
            // toolStripMenuItem10T
            // 
            toolStripMenuItem10T.Name = "toolStripMenuItem10T";
            toolStripMenuItem10T.Size = new Size(116, 22);
            toolStripMenuItem10T.Text = "10%";
            toolStripMenuItem10T.Click += toolStripMenuItem10T_Click;
            // 
            // toolStripMenuItem20T
            // 
            toolStripMenuItem20T.Name = "toolStripMenuItem20T";
            toolStripMenuItem20T.Size = new Size(116, 22);
            toolStripMenuItem20T.Text = "20%";
            toolStripMenuItem20T.Click += toolStripMenuItem20T_Click;
            // 
            // toolStripMenuItem30T
            // 
            toolStripMenuItem30T.Name = "toolStripMenuItem30T";
            toolStripMenuItem30T.Size = new Size(116, 22);
            toolStripMenuItem30T.Text = "30%";
            toolStripMenuItem30T.Click += toolStripMenuItem30T_Click;
            // 
            // toolStripMenuItem40T
            // 
            toolStripMenuItem40T.Name = "toolStripMenuItem40T";
            toolStripMenuItem40T.Size = new Size(116, 22);
            toolStripMenuItem40T.Text = "40%";
            toolStripMenuItem40T.Click += toolStripMenuItem40T_Click;
            // 
            // toolStripMenuItem50T
            // 
            toolStripMenuItem50T.Name = "toolStripMenuItem50T";
            toolStripMenuItem50T.Size = new Size(116, 22);
            toolStripMenuItem50T.Text = "50%";
            toolStripMenuItem50T.Click += toolStripMenuItem50T_Click;
            // 
            // toolStripMenuItem60T
            // 
            toolStripMenuItem60T.Name = "toolStripMenuItem60T";
            toolStripMenuItem60T.Size = new Size(116, 22);
            toolStripMenuItem60T.Text = "60%";
            toolStripMenuItem60T.Click += toolStripMenuItem60T_Click;
            // 
            // toolStripMenuItem70T
            // 
            toolStripMenuItem70T.Name = "toolStripMenuItem70T";
            toolStripMenuItem70T.Size = new Size(116, 22);
            toolStripMenuItem70T.Text = "70%";
            toolStripMenuItem70T.Click += toolStripMenuItem70T_Click;
            // 
            // toolStripMenuItem80T
            // 
            toolStripMenuItem80T.Name = "toolStripMenuItem80T";
            toolStripMenuItem80T.Size = new Size(116, 22);
            toolStripMenuItem80T.Text = "80%";
            toolStripMenuItem80T.Click += toolStripMenuItem80T_Click;
            // 
            // toolStripMenuItem90T
            // 
            toolStripMenuItem90T.Name = "toolStripMenuItem90T";
            toolStripMenuItem90T.Size = new Size(116, 22);
            toolStripMenuItem90T.Text = "90%";
            toolStripMenuItem90T.Click += toolStripMenuItem90T_Click;
            // 
            // opaqueToolStripMenuItem
            // 
            opaqueToolStripMenuItem.Name = "opaqueToolStripMenuItem";
            opaqueToolStripMenuItem.Size = new Size(116, 22);
            opaqueToolStripMenuItem.Text = "Opaque";
            opaqueToolStripMenuItem.Click += opaqueToolStripMenuItem_Click;
            // 
            // mainFlowLayout
            // 
            mainFlowLayout.Controls.Add(menuStrip1);
            mainFlowLayout.Controls.Add(linksPanelHolder);
            mainFlowLayout.Controls.Add(leftRightPanelHolder);
            mainFlowLayout.Controls.Add(quickSwitchPanelHolder);
            mainFlowLayout.Controls.Add(notesPanelHolder);
            mainFlowLayout.Controls.Add(desktopTimeDisplayHolder);
            mainFlowLayout.FlowDirection = FlowDirection.TopDown;
            mainFlowLayout.Location = new Point(0, 0);
            mainFlowLayout.Margin = new Padding(0);
            mainFlowLayout.Name = "mainFlowLayout";
            mainFlowLayout.Size = new Size(281, 228);
            mainFlowLayout.TabIndex = 19;
            // 
            // linksPanelHolder
            // 
            linksPanelHolder.Controls.Add(minimalToggleBtn);
            linksPanelHolder.Controls.Add(desktopLinksHolder);
            linksPanelHolder.Location = new Point(0, 0);
            linksPanelHolder.Margin = new Padding(0);
            linksPanelHolder.Name = "linksPanelHolder";
            linksPanelHolder.Size = new Size(281, 25);
            linksPanelHolder.TabIndex = 20;
            // 
            // leftRightPanelHolder
            // 
            leftRightPanelHolder.Controls.Add(switchToLeft);
            leftRightPanelHolder.Controls.Add(switchToRight);
            leftRightPanelHolder.Controls.Add(switchToPrevious);
            leftRightPanelHolder.Location = new Point(0, 25);
            leftRightPanelHolder.Margin = new Padding(0);
            leftRightPanelHolder.Name = "leftRightPanelHolder";
            leftRightPanelHolder.Size = new Size(281, 27);
            leftRightPanelHolder.TabIndex = 20;
            // 
            // quickSwitchPanelHolder
            // 
            quickSwitchPanelHolder.Controls.Add(switchBtn);
            quickSwitchPanelHolder.Controls.Add(flowLayoutPanel2);
            quickSwitchPanelHolder.Location = new Point(0, 52);
            quickSwitchPanelHolder.Margin = new Padding(0);
            quickSwitchPanelHolder.Name = "quickSwitchPanelHolder";
            quickSwitchPanelHolder.Size = new Size(281, 57);
            quickSwitchPanelHolder.TabIndex = 20;
            quickSwitchPanelHolder.Visible = false;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(desktop1);
            flowLayoutPanel2.Controls.Add(desktop2);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(235, 0);
            flowLayoutPanel2.Margin = new Padding(0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(44, 55);
            flowLayoutPanel2.TabIndex = 21;
            // 
            // notesPanelHolder
            // 
            notesPanelHolder.Controls.Add(notesBox);
            notesPanelHolder.Controls.Add(clearNotesBtn);
            notesPanelHolder.Location = new Point(0, 109);
            notesPanelHolder.Margin = new Padding(0);
            notesPanelHolder.Name = "notesPanelHolder";
            notesPanelHolder.Size = new Size(278, 49);
            notesPanelHolder.TabIndex = 20;
            notesPanelHolder.Visible = false;
            // 
            // clearNotesBtn
            // 
            clearNotesBtn.Location = new Point(256, 0);
            clearNotesBtn.Margin = new Padding(0);
            clearNotesBtn.Name = "clearNotesBtn";
            clearNotesBtn.Size = new Size(22, 49);
            clearNotesBtn.TabIndex = 21;
            clearNotesBtn.Text = "X";
            clearNotesBtn.UseVisualStyleBackColor = true;
            clearNotesBtn.Click += clearNotesBtn_Click;
            // 
            // desktopTimeDisplayHolder
            // 
            desktopTimeDisplayHolder.Controls.Add(desktopTimeDisplay);
            desktopTimeDisplayHolder.Location = new Point(3, 161);
            desktopTimeDisplayHolder.Name = "desktopTimeDisplayHolder";
            desktopTimeDisplayHolder.Size = new Size(275, 38);
            desktopTimeDisplayHolder.TabIndex = 20;
            desktopTimeDisplayHolder.Visible = false;
            // 
            // Window
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(281, 50);
            Controls.Add(mainFlowLayout);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(9, 9);
            MainMenuStrip = menuStrip1;
            Name = "Window";
            Text = "Quick Switch";
            ((System.ComponentModel.ISupportInitialize)desktop1).EndInit();
            ((System.ComponentModel.ISupportInitialize)desktop2).EndInit();
            desktopLinksHolder.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            mainFlowLayout.ResumeLayout(false);
            mainFlowLayout.PerformLayout();
            linksPanelHolder.ResumeLayout(false);
            leftRightPanelHolder.ResumeLayout(false);
            quickSwitchPanelHolder.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            notesPanelHolder.ResumeLayout(false);
            desktopTimeDisplayHolder.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button switchBtn;
        private NumericUpDown desktop1;
        private NumericUpDown desktop2;
        private Button settings;
        private Button link1;
        private FlowLayoutPanel desktopLinksHolder;
        private Button link2;
        private Button link3;
        private Button link4;
        private Button link5;
        private Button link6;
        private Button link7;
        private Button link8;
        private Button link9;
        private Button link10;
        private Label desktopTimeDisplay;
        private RichTextBox notesBox;
        private Button link11;
        private Button switchToLeft;
        private Button switchToRight;
        private Button switchToPrevious;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem minimalToolStripMenuItem;
        private FlowLayoutPanel mainFlowLayout;
        private FlowLayoutPanel quickSwitchPanelHolder;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel leftRightPanelHolder;
        private ToolStripMenuItem runOnStartupToolStripMenuItem;
        private Button minimalToggleBtn;
        private Panel linksPanelHolder;
        private FlowLayoutPanel notesPanelHolder;
        private Button clearNotesBtn;
        private ToolStripMenuItem transparencyToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem10T;
        private ToolStripMenuItem toolStripMenuItem20T;
        private ToolStripMenuItem toolStripMenuItem30T;
        private ToolStripMenuItem toolStripMenuItem40T;
        private ToolStripMenuItem toolStripMenuItem50T;
        private ToolStripMenuItem toolStripMenuItem60T;
        private ToolStripMenuItem toolStripMenuItem70T;
        private ToolStripMenuItem toolStripMenuItem80T;
        private ToolStripMenuItem toolStripMenuItem90T;
        private ToolStripMenuItem opaqueToolStripMenuItem;
        private Panel desktopTimeDisplayHolder;
    }
}