namespace GlobalMacroRecorder
{
    partial class MacroForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MacroForm));
            this.recordStartButton = new System.Windows.Forms.Button();
            this.recordStopButton = new System.Windows.Forms.Button();
            this.playBackMacroButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PlayWorker = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Hidewindow = new System.Windows.Forms.CheckBox();
            this.stoponselect = new System.Windows.Forms.CheckBox();
            this.HotkeyActivated = new System.Windows.Forms.CheckBox();
            this.ForeverLoop = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // recordStartButton
            // 
            this.recordStartButton.Location = new System.Drawing.Point(108, 4);
            this.recordStartButton.Name = "recordStartButton";
            this.recordStartButton.Size = new System.Drawing.Size(96, 23);
            this.recordStartButton.TabIndex = 0;
            this.recordStartButton.Text = "Start";
            this.recordStartButton.UseVisualStyleBackColor = true;
            this.recordStartButton.Click += new System.EventHandler(this.recordStartButton_Click);
            // 
            // recordStopButton
            // 
            this.recordStopButton.Enabled = false;
            this.recordStopButton.Location = new System.Drawing.Point(207, 4);
            this.recordStopButton.Name = "recordStopButton";
            this.recordStopButton.Size = new System.Drawing.Size(102, 23);
            this.recordStopButton.TabIndex = 0;
            this.recordStopButton.Text = "Stop";
            this.recordStopButton.UseVisualStyleBackColor = true;
            this.recordStopButton.Click += new System.EventHandler(this.recordStopButton_Click);
            // 
            // playBackMacroButton
            // 
            this.playBackMacroButton.Location = new System.Drawing.Point(108, 33);
            this.playBackMacroButton.Name = "playBackMacroButton";
            this.playBackMacroButton.Size = new System.Drawing.Size(201, 25);
            this.playBackMacroButton.TabIndex = 1;
            this.playBackMacroButton.Text = "Play Back";
            this.playBackMacroButton.UseVisualStyleBackColor = true;
            this.playBackMacroButton.Click += new System.EventHandler(this.playBackMacroButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Record Macro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Playback Macro:";
            // 
            // PlayWorker
            // 
            this.PlayWorker.WorkerReportsProgress = true;
            this.PlayWorker.WorkerSupportsCancellation = true;
            this.PlayWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.PlayWorker_DoWork);
            this.PlayWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.PlayWorker_ProgressChanged);
            this.PlayWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.PlayWorker_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 125);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(326, 12);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Visible = false;
            // 
            // Hidewindow
            // 
            this.Hidewindow.AutoSize = true;
            this.Hidewindow.Location = new System.Drawing.Point(12, 64);
            this.Hidewindow.Name = "Hidewindow";
            this.Hidewindow.Size = new System.Drawing.Size(90, 17);
            this.Hidewindow.TabIndex = 4;
            this.Hidewindow.Text = "Hide Window";
            this.Hidewindow.UseVisualStyleBackColor = true;
            // 
            // stoponselect
            // 
            this.stoponselect.AutoSize = true;
            this.stoponselect.Location = new System.Drawing.Point(108, 64);
            this.stoponselect.Name = "stoponselect";
            this.stoponselect.Size = new System.Drawing.Size(96, 17);
            this.stoponselect.TabIndex = 5;
            this.stoponselect.Text = "Stop on Select";
            this.stoponselect.UseVisualStyleBackColor = true;
            // 
            // HotkeyActivated
            // 
            this.HotkeyActivated.AutoSize = true;
            this.HotkeyActivated.Location = new System.Drawing.Point(207, 64);
            this.HotkeyActivated.Name = "HotkeyActivated";
            this.HotkeyActivated.Size = new System.Drawing.Size(110, 17);
            this.HotkeyActivated.TabIndex = 7;
            this.HotkeyActivated.Text = "Hotkey Activation";
            this.HotkeyActivated.UseVisualStyleBackColor = true;
            this.HotkeyActivated.CheckedChanged += new System.EventHandler(this.HotkeyActivated_CheckedChanged);
            // 
            // ForeverLoop
            // 
            this.ForeverLoop.AutoSize = true;
            this.ForeverLoop.Location = new System.Drawing.Point(207, 87);
            this.ForeverLoop.Name = "ForeverLoop";
            this.ForeverLoop.Size = new System.Drawing.Size(89, 17);
            this.ForeverLoop.TabIndex = 8;
            this.ForeverLoop.Text = "Forever Loop";
            this.ForeverLoop.UseVisualStyleBackColor = true;
            this.ForeverLoop.Visible = false;
            this.ForeverLoop.CheckedChanged += new System.EventHandler(this.ForeverLoop_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 96);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // MacroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 137);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ForeverLoop);
            this.Controls.Add(this.HotkeyActivated);
            this.Controls.Add(this.stoponselect);
            this.Controls.Add(this.Hidewindow);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playBackMacroButton);
            this.Controls.Add(this.recordStopButton);
            this.Controls.Add(this.recordStartButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(355, 176);
            this.Name = "MacroForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Global Macro Recorder Example";
            this.Load += new System.EventHandler(this.MacroForm_Load);
            this.Click += new System.EventHandler(this.MacroForm_Click);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MacroForm_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button recordStartButton;
        private System.Windows.Forms.Button recordStopButton;
        private System.Windows.Forms.Button playBackMacroButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker PlayWorker;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox Hidewindow;
        private System.Windows.Forms.CheckBox stoponselect;
        private System.Windows.Forms.CheckBox HotkeyActivated;
        private System.Windows.Forms.CheckBox ForeverLoop;
        private System.Windows.Forms.Button btnSave;
    }
}

