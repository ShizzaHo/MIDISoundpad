namespace MidiSoundpad
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
            this.MidiControllerBox = new System.Windows.Forms.ComboBox();
            this.log = new System.Windows.Forms.RichTextBox();
            this.MicrophoneBox = new System.Windows.Forms.ComboBox();
            this.About = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.midiKeyWaitText = new System.Windows.Forms.Label();
            this.bindDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bindMultiple = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bindVolume = new System.Windows.Forms.NumericUpDown();
            this.soundSelected = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.radioMacro = new System.Windows.Forms.RadioButton();
            this.radioEffect = new System.Windows.Forms.RadioButton();
            this.radioSound = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.bindMidiKey = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bindSave = new System.Windows.Forms.Button();
            this.bindName = new System.Windows.Forms.TextBox();
            this.bindsList = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label24 = new System.Windows.Forms.Label();
            this.monitoringVolumeFactor = new System.Windows.Forms.NumericUpDown();
            this.spMonitoringMode = new System.Windows.Forms.CheckBox();
            this.label23 = new System.Windows.Forms.Label();
            this.spMonitoringOutput = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.wasapiLatency = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lalal = new System.Windows.Forms.Label();
            this.latency = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.autorun = new System.Windows.Forms.CheckBox();
            this.trayMode = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.VirtualCableBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.launchTray = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.label14 = new System.Windows.Forms.Label();
            this.About.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindMidiKey)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monitoringVolumeFactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wasapiLatency)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MidiControllerBox
            // 
            this.MidiControllerBox.FormattingEnabled = true;
            this.MidiControllerBox.Location = new System.Drawing.Point(16, 25);
            this.MidiControllerBox.Name = "MidiControllerBox";
            this.MidiControllerBox.Size = new System.Drawing.Size(218, 21);
            this.MidiControllerBox.TabIndex = 0;
            this.MidiControllerBox.SelectedValueChanged += new System.EventHandler(this.MidiControllerBox_SelectedValueChanged);
            // 
            // log
            // 
            this.log.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.log.Location = new System.Drawing.Point(16, 389);
            this.log.Name = "log";
            this.log.ReadOnly = true;
            this.log.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.log.Size = new System.Drawing.Size(831, 127);
            this.log.TabIndex = 1;
            this.log.Text = "";
            // 
            // MicrophoneBox
            // 
            this.MicrophoneBox.FormattingEnabled = true;
            this.MicrophoneBox.Location = new System.Drawing.Point(240, 25);
            this.MicrophoneBox.Name = "MicrophoneBox";
            this.MicrophoneBox.Size = new System.Drawing.Size(218, 21);
            this.MicrophoneBox.TabIndex = 3;
            this.MicrophoneBox.SelectedIndexChanged += new System.EventHandler(this.MicrophoneBox_SelectedIndexChanged);
            // 
            // About
            // 
            this.About.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.About.Controls.Add(this.tabPage1);
            this.About.Controls.Add(this.tabPage2);
            this.About.Controls.Add(this.tabPage4);
            this.About.Controls.Add(this.tabPage3);
            this.About.Location = new System.Drawing.Point(16, 61);
            this.About.Name = "About";
            this.About.SelectedIndex = 0;
            this.About.Size = new System.Drawing.Size(839, 311);
            this.About.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.bindsList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage1.Size = new System.Drawing.Size(831, 285);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Sound pad";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button7.Location = new System.Drawing.Point(9, 250);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(239, 23);
            this.button7.TabIndex = 24;
            this.button7.Text = "New";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.midiKeyWaitText);
            this.groupBox1.Controls.Add(this.bindDelete);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.radioMacro);
            this.groupBox1.Controls.Add(this.radioEffect);
            this.groupBox1.Controls.Add(this.radioSound);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.bindMidiKey);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.bindSave);
            this.groupBox1.Controls.Add(this.bindName);
            this.groupBox1.Location = new System.Drawing.Point(254, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 264);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit";
            // 
            // midiKeyWaitText
            // 
            this.midiKeyWaitText.AutoSize = true;
            this.midiKeyWaitText.ForeColor = System.Drawing.Color.Red;
            this.midiKeyWaitText.Location = new System.Drawing.Point(339, 87);
            this.midiKeyWaitText.Name = "midiKeyWaitText";
            this.midiKeyWaitText.Size = new System.Drawing.Size(118, 13);
            this.midiKeyWaitText.TabIndex = 25;
            this.midiKeyWaitText.Text = "PRESS ANY MIDI KEY";
            this.midiKeyWaitText.Visible = false;
            // 
            // bindDelete
            // 
            this.bindDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bindDelete.Location = new System.Drawing.Point(425, 235);
            this.bindDelete.Name = "bindDelete";
            this.bindDelete.Size = new System.Drawing.Size(65, 23);
            this.bindDelete.TabIndex = 24;
            this.bindDelete.Text = "Delete";
            this.bindDelete.UseVisualStyleBackColor = true;
            this.bindDelete.Click += new System.EventHandler(this.bindDelete_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.bindMultiple);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.bindVolume);
            this.panel1.Controls.Add(this.soundSelected);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(13, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 76);
            this.panel1.TabIndex = 23;
            // 
            // bindMultiple
            // 
            this.bindMultiple.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bindMultiple.AutoSize = true;
            this.bindMultiple.Location = new System.Drawing.Point(419, 57);
            this.bindMultiple.Name = "bindMultiple";
            this.bindMultiple.Size = new System.Drawing.Size(135, 17);
            this.bindMultiple.TabIndex = 14;
            this.bindMultiple.Text = "Allow multiple playback";
            this.bindMultiple.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.Location = new System.Drawing.Point(167, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Volume";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bindVolume
            // 
            this.bindVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bindVolume.Location = new System.Drawing.Point(221, 55);
            this.bindVolume.Name = "bindVolume";
            this.bindVolume.Size = new System.Drawing.Size(41, 20);
            this.bindVolume.TabIndex = 27;
            // 
            // soundSelected
            // 
            this.soundSelected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.soundSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.soundSelected.Location = new System.Drawing.Point(167, 0);
            this.soundSelected.Name = "soundSelected";
            this.soundSelected.Size = new System.Drawing.Size(380, 16);
            this.soundSelected.TabIndex = 24;
            this.soundSelected.Text = "Selected sound:";
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button6.Location = new System.Drawing.Point(0, 53);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(161, 23);
            this.button6.TabIndex = 26;
            this.button6.Text = "Open the sound library";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button5.Location = new System.Drawing.Point(0, 27);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(161, 23);
            this.button5.TabIndex = 25;
            this.button5.Text = "Add a new sound to the library";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(161, 23);
            this.button4.TabIndex = 24;
            this.button4.Text = "Select a sound from the library";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // radioMacro
            // 
            this.radioMacro.AutoSize = true;
            this.radioMacro.Location = new System.Drawing.Point(221, 130);
            this.radioMacro.Name = "radioMacro";
            this.radioMacro.Size = new System.Drawing.Size(105, 17);
            this.radioMacro.TabIndex = 22;
            this.radioMacro.TabStop = true;
            this.radioMacro.Text = "Execute a macro";
            this.radioMacro.UseVisualStyleBackColor = true;
            // 
            // radioEffect
            // 
            this.radioEffect.AutoSize = true;
            this.radioEffect.Location = new System.Drawing.Point(105, 130);
            this.radioEffect.Name = "radioEffect";
            this.radioEffect.Size = new System.Drawing.Size(110, 17);
            this.radioEffect.TabIndex = 21;
            this.radioEffect.TabStop = true;
            this.radioEffect.Text = "Turn on the effect";
            this.radioEffect.UseVisualStyleBackColor = true;
            // 
            // radioSound
            // 
            this.radioSound.AutoSize = true;
            this.radioSound.Location = new System.Drawing.Point(13, 130);
            this.radioSound.Name = "radioSound";
            this.radioSound.Size = new System.Drawing.Size(86, 17);
            this.radioSound.TabIndex = 20;
            this.radioSound.TabStop = true;
            this.radioSound.Text = "Play a sound";
            this.radioSound.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Action";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(481, 83);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 20);
            this.button3.TabIndex = 15;
            this.button3.Text = "Define";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bindMidiKey
            // 
            this.bindMidiKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bindMidiKey.Location = new System.Drawing.Point(13, 83);
            this.bindMidiKey.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.bindMidiKey.Name = "bindMidiKey";
            this.bindMidiKey.Size = new System.Drawing.Size(462, 20);
            this.bindMidiKey.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Midi key";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Name";
            // 
            // bindSave
            // 
            this.bindSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bindSave.Location = new System.Drawing.Point(496, 235);
            this.bindSave.Name = "bindSave";
            this.bindSave.Size = new System.Drawing.Size(65, 23);
            this.bindSave.TabIndex = 1;
            this.bindSave.Text = "Save";
            this.bindSave.UseVisualStyleBackColor = true;
            this.bindSave.Click += new System.EventHandler(this.bindSave_Click);
            // 
            // bindName
            // 
            this.bindName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bindName.Location = new System.Drawing.Point(13, 37);
            this.bindName.Name = "bindName";
            this.bindName.Size = new System.Drawing.Size(547, 20);
            this.bindName.TabIndex = 2;
            // 
            // bindsList
            // 
            this.bindsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bindsList.FormattingEnabled = true;
            this.bindsList.Items.AddRange(new object[] {
            "Звук 1"});
            this.bindsList.Location = new System.Drawing.Point(9, 9);
            this.bindsList.Name = "bindsList";
            this.bindsList.Size = new System.Drawing.Size(239, 238);
            this.bindsList.TabIndex = 0;
            this.bindsList.SelectedIndexChanged += new System.EventHandler(this.bindsList_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(831, 285);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Audio effects";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "In future updates...";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label24);
            this.tabPage4.Controls.Add(this.monitoringVolumeFactor);
            this.tabPage4.Controls.Add(this.spMonitoringMode);
            this.tabPage4.Controls.Add(this.label23);
            this.tabPage4.Controls.Add(this.spMonitoringOutput);
            this.tabPage4.Controls.Add(this.label22);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.wasapiLatency);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.lalal);
            this.tabPage4.Controls.Add(this.latency);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(831, 285);
            this.tabPage4.TabIndex = 5;
            this.tabPage4.Text = "Equipment Settings";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            this.label24.Location = new System.Drawing.Point(365, 88);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(126, 21);
            this.label24.TabIndex = 18;
            this.label24.Text = "Monitoring volume factor";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // monitoringVolumeFactor
            // 
            this.monitoringVolumeFactor.Location = new System.Drawing.Point(495, 90);
            this.monitoringVolumeFactor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.monitoringVolumeFactor.Name = "monitoringVolumeFactor";
            this.monitoringVolumeFactor.Size = new System.Drawing.Size(59, 20);
            this.monitoringVolumeFactor.TabIndex = 17;
            this.monitoringVolumeFactor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // spMonitoringMode
            // 
            this.spMonitoringMode.AutoSize = true;
            this.spMonitoringMode.Location = new System.Drawing.Point(562, 92);
            this.spMonitoringMode.Name = "spMonitoringMode";
            this.spMonitoringMode.Size = new System.Drawing.Size(53, 17);
            this.spMonitoringMode.TabIndex = 15;
            this.spMonitoringMode.Text = "Mode";
            this.spMonitoringMode.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.ForeColor = System.Drawing.Color.Gray;
            this.label23.Location = new System.Drawing.Point(18, 112);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(463, 29);
            this.label23.TabIndex = 16;
            this.label23.Text = "It will play sounds on the selected device, but you will not hear your voice, thi" +
    "s is for understanding what sound you have turned on.";
            // 
            // spMonitoringOutput
            // 
            this.spMonitoringOutput.FormattingEnabled = true;
            this.spMonitoringOutput.Location = new System.Drawing.Point(141, 88);
            this.spMonitoringOutput.Name = "spMonitoringOutput";
            this.spMonitoringOutput.Size = new System.Drawing.Size(218, 21);
            this.spMonitoringOutput.TabIndex = 15;
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(17, 87);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(116, 20);
            this.label22.TabIndex = 6;
            this.label22.Text = "SoundPad Monitoring";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(734, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Save settings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // wasapiLatency
            // 
            this.wasapiLatency.Location = new System.Drawing.Point(117, 33);
            this.wasapiLatency.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.wasapiLatency.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.wasapiLatency.Name = "wasapiLatency";
            this.wasapiLatency.Size = new System.Drawing.Size(59, 20);
            this.wasapiLatency.TabIndex = 4;
            this.wasapiLatency.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(18, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(463, 31);
            this.label13.TabIndex = 3;
            this.label13.Text = resources.GetString("label13.Text");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(-532, -149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Wasapi latency";
            // 
            // lalal
            // 
            this.lalal.Location = new System.Drawing.Point(17, 31);
            this.lalal.Name = "lalal";
            this.lalal.Size = new System.Drawing.Size(97, 20);
            this.lalal.TabIndex = 1;
            this.lalal.Text = "Wasapi latency";
            this.lalal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // latency
            // 
            this.latency.AutoSize = true;
            this.latency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.latency.Location = new System.Drawing.Point(9, 9);
            this.latency.Name = "latency";
            this.latency.Size = new System.Drawing.Size(97, 16);
            this.latency.TabIndex = 0;
            this.latency.Text = "Audio setting";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pictureBox2);
            this.tabPage3.Controls.Add(this.label21);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(831, 285);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "About";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox2.Image = global::MidiSoundpad.Properties.Resources.TONQR;
            this.pictureBox2.Location = new System.Drawing.Point(705, 132);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(114, 118);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label21.AutoSize = true;
            this.label21.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(683, 253);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(136, 13);
            this.label21.TabIndex = 6;
            this.label21.Text = "Donation support (Toncoin)";
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label20.AutoSize = true;
            this.label20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label20.Location = new System.Drawing.Point(315, 253);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(166, 13);
            this.label20.TabIndex = 5;
            this.label20.Text = "Donation support (DonationAlerts)";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label19.AutoSize = true;
            this.label19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label19.Location = new System.Drawing.Point(152, 253);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(157, 13);
            this.label19.TabIndex = 4;
            this.label19.Text = "VB-CABLE Virtual Audio Device";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label18.AutoSize = true;
            this.label18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label18.Location = new System.Drawing.Point(27, 253);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(119, 13);
            this.label18.TabIndex = 3;
            this.label18.Text = "Source code on GitHub";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(27, 109);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(625, 36);
            this.label17.TabIndex = 2;
            this.label17.Text = "MIDISoundpad is a completely free and open source program that allows you to turn" +
    " your MIDI keyboard into a full—fledged soundpad.";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(190, 63);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 16);
            this.label16.TabIndex = 1;
            this.label16.Text = "By ShizzaHo";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(23, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(257, 39);
            this.label15.TabIndex = 0;
            this.label15.Text = "MIDISoundpad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "MIDI device";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Microphone";
            // 
            // autorun
            // 
            this.autorun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.autorun.AutoSize = true;
            this.autorun.Location = new System.Drawing.Point(706, 27);
            this.autorun.Name = "autorun";
            this.autorun.Size = new System.Drawing.Size(145, 17);
            this.autorun.TabIndex = 7;
            this.autorun.Text = "Autorun at system startup";
            this.autorun.UseVisualStyleBackColor = true;
            this.autorun.CheckedChanged += new System.EventHandler(this.autorun_CheckedChanged);
            // 
            // trayMode
            // 
            this.trayMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trayMode.AutoSize = true;
            this.trayMode.Location = new System.Drawing.Point(706, 48);
            this.trayMode.Name = "trayMode";
            this.trayMode.Size = new System.Drawing.Size(109, 17);
            this.trayMode.TabIndex = 8;
            this.trayMode.Text = "Close it in the tray";
            this.trayMode.UseVisualStyleBackColor = true;
            this.trayMode.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Log";
            // 
            // VirtualCableBox
            // 
            this.VirtualCableBox.FormattingEnabled = true;
            this.VirtualCableBox.Location = new System.Drawing.Point(464, 25);
            this.VirtualCableBox.Name = "VirtualCableBox";
            this.VirtualCableBox.Size = new System.Drawing.Size(218, 21);
            this.VirtualCableBox.TabIndex = 10;
            this.VirtualCableBox.SelectedIndexChanged += new System.EventHandler(this.VirtualCableBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Virtual Audio Cable (VB-Audio recommended)\r\n";
            // 
            // launchTray
            // 
            this.launchTray.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.launchTray.AutoSize = true;
            this.launchTray.Location = new System.Drawing.Point(706, 7);
            this.launchTray.Name = "launchTray";
            this.launchTray.Size = new System.Drawing.Size(134, 17);
            this.launchTray.TabIndex = 12;
            this.launchTray.Text = "Launching into the tray";
            this.launchTray.UseVisualStyleBackColor = true;
            this.launchTray.CheckedChanged += new System.EventHandler(this.launchTray_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(-1, 505);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(866, 23);
            this.panel2.TabIndex = 13;
            this.panel2.Visible = false;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.Location = new System.Drawing.Point(25, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(201, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "There are no sounds playing now";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.Image = global::MidiSoundpad.Properties.Resources.ListenOff;
            this.pictureBox1.Location = new System.Drawing.Point(8, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(12, 12);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.Location = new System.Drawing.Point(660, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(201, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Status of pressing the MIDI keys:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "MIDI Soundpad";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(69, 26);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(68, 22);
            this.toolStripMenuItem2.Text = "Exit";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(238, 5);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "It\'s not working yet";
            this.label14.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 528);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.launchTray);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.VirtualCableBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trayMode);
            this.Controls.Add(this.autorun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.About);
            this.Controls.Add(this.log);
            this.Controls.Add(this.MidiControllerBox);
            this.Controls.Add(this.MicrophoneBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MIDI Soundpad 1.0.0 | by ShizzaHo";
            this.About.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindMidiKey)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monitoringVolumeFactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wasapiLatency)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox MidiControllerBox;
        private System.Windows.Forms.RichTextBox log;
        private System.Windows.Forms.ComboBox MicrophoneBox;
        private System.Windows.Forms.TabControl About;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox autorun;
        private System.Windows.Forms.CheckBox trayMode;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox VirtualCableBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox bindsList;
        private System.Windows.Forms.Button bindSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bindName;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown bindMidiKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioEffect;
        private System.Windows.Forms.RadioButton radioSound;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioMacro;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label soundSelected;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button bindDelete;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox launchTray;
        private System.Windows.Forms.Label midiKeyWaitText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown bindVolume;
        private System.Windows.Forms.CheckBox bindMultiple;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lalal;
        private System.Windows.Forms.Label latency;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown wasapiLatency;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.CheckBox spMonitoringMode;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox spMonitoringOutput;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.NumericUpDown monitoringVolumeFactor;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label14;
    }
}

