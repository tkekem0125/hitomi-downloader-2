﻿namespace Hitomi_Copy_3
{
    partial class frmSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetting));
            this.tgWI = new MetroFramework.Controls.MetroToggle();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tbWT = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tgSJ = new MetroFramework.Controls.MetroToggle();
            this.tbRPS = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tbTMA = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.tgRNM = new MetroFramework.Controls.MetroToggle();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.tgRL = new MetroFramework.Controls.MetroToggle();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.tgRA = new MetroFramework.Controls.MetroToggle();
            this.bSave = new MetroFramework.Controls.MetroButton();
            this.tbInfo = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // tgWI
            // 
            this.tgWI.AutoSize = true;
            this.tgWI.Location = new System.Drawing.Point(222, 12);
            this.tgWI.Name = "tgWI";
            this.tgWI.Size = new System.Drawing.Size(80, 19);
            this.tgWI.Style = MetroFramework.MetroColorStyle.Pink;
            this.tgWI.TabIndex = 19;
            this.tgWI.Text = "Off";
            this.tgWI.UseSelectable = true;
            this.tgWI.MouseEnter += new System.EventHandler(this.tgWI_MouseEnter);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(158, 12);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(88, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroLabel4.TabIndex = 20;
            this.metroLabel4.Text = "Wait Infinite : ";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(148, 40);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(98, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroLabel1.TabIndex = 21;
            this.metroLabel1.Text = "Wait Timeout : ";
            // 
            // tbWT
            // 
            // 
            // 
            // 
            this.tbWT.CustomButton.Image = null;
            this.tbWT.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.tbWT.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbWT.CustomButton.Name = "";
            this.tbWT.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbWT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbWT.CustomButton.TabIndex = 1;
            this.tbWT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbWT.CustomButton.UseSelectable = true;
            this.tbWT.CustomButton.Visible = false;
            this.tbWT.Lines = new string[] {
        "recent:0-25"};
            this.tbWT.Location = new System.Drawing.Point(252, 37);
            this.tbWT.MaxLength = 32767;
            this.tbWT.Name = "tbWT";
            this.tbWT.PasswordChar = '\0';
            this.tbWT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbWT.SelectedText = "";
            this.tbWT.SelectionLength = 0;
            this.tbWT.SelectionStart = 0;
            this.tbWT.ShortcutsEnabled = true;
            this.tbWT.Size = new System.Drawing.Size(157, 23);
            this.tbWT.Style = MetroFramework.MetroColorStyle.Pink;
            this.tbWT.TabIndex = 22;
            this.tbWT.Text = "recent:0-25";
            this.tbWT.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbWT.UseSelectable = true;
            this.tbWT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbWT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbWT.Enter += new System.EventHandler(this.tbWT_MouseEnter);
            this.tbWT.MouseEnter += new System.EventHandler(this.tbWT_MouseEnter);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(92, 93);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(154, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroLabel2.TabIndex = 24;
            this.metroLabel2.Text = "Recommend Per Scroll : ";
            // 
            // tgSJ
            // 
            this.tgSJ.AutoSize = true;
            this.tgSJ.Location = new System.Drawing.Point(222, 66);
            this.tgSJ.Name = "tgSJ";
            this.tgSJ.Size = new System.Drawing.Size(80, 19);
            this.tgSJ.Style = MetroFramework.MetroColorStyle.Pink;
            this.tgSJ.TabIndex = 23;
            this.tgSJ.Text = "Off";
            this.tgSJ.UseSelectable = true;
            this.tgSJ.MouseEnter += new System.EventHandler(this.tgSJ_MouseEnter);
            // 
            // tbRPS
            // 
            // 
            // 
            // 
            this.tbRPS.CustomButton.Image = null;
            this.tbRPS.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.tbRPS.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRPS.CustomButton.Name = "";
            this.tbRPS.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbRPS.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbRPS.CustomButton.TabIndex = 1;
            this.tbRPS.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbRPS.CustomButton.UseSelectable = true;
            this.tbRPS.CustomButton.Visible = false;
            this.tbRPS.Lines = new string[] {
        "recent:0-25"};
            this.tbRPS.Location = new System.Drawing.Point(252, 91);
            this.tbRPS.MaxLength = 32767;
            this.tbRPS.Name = "tbRPS";
            this.tbRPS.PasswordChar = '\0';
            this.tbRPS.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbRPS.SelectedText = "";
            this.tbRPS.SelectionLength = 0;
            this.tbRPS.SelectionStart = 0;
            this.tbRPS.ShortcutsEnabled = true;
            this.tbRPS.Size = new System.Drawing.Size(157, 23);
            this.tbRPS.Style = MetroFramework.MetroColorStyle.Pink;
            this.tbRPS.TabIndex = 26;
            this.tbRPS.Text = "recent:0-25";
            this.tbRPS.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbRPS.UseSelectable = true;
            this.tbRPS.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbRPS.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbRPS.Enter += new System.EventHandler(this.tbRPS_MouseEnter);
            this.tbRPS.MouseEnter += new System.EventHandler(this.tbRPS_MouseEnter);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(170, 66);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(76, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroLabel3.TabIndex = 25;
            this.metroLabel3.Text = "Save Json : ";
            // 
            // tbTMA
            // 
            // 
            // 
            // 
            this.tbTMA.CustomButton.Image = null;
            this.tbTMA.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.tbTMA.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTMA.CustomButton.Name = "";
            this.tbTMA.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbTMA.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbTMA.CustomButton.TabIndex = 1;
            this.tbTMA.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbTMA.CustomButton.UseSelectable = true;
            this.tbTMA.CustomButton.Visible = false;
            this.tbTMA.Lines = new string[] {
        "recent:0-25"};
            this.tbTMA.Location = new System.Drawing.Point(252, 120);
            this.tbTMA.MaxLength = 32767;
            this.tbTMA.Name = "tbTMA";
            this.tbTMA.PasswordChar = '\0';
            this.tbTMA.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbTMA.SelectedText = "";
            this.tbTMA.SelectionLength = 0;
            this.tbTMA.SelectionStart = 0;
            this.tbTMA.ShortcutsEnabled = true;
            this.tbTMA.Size = new System.Drawing.Size(157, 23);
            this.tbTMA.Style = MetroFramework.MetroColorStyle.Pink;
            this.tbTMA.TabIndex = 28;
            this.tbTMA.Text = "recent:0-25";
            this.tbTMA.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbTMA.UseSelectable = true;
            this.tbTMA.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbTMA.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbTMA.Enter += new System.EventHandler(this.tbTMA_MouseEnter);
            this.tbTMA.MouseEnter += new System.EventHandler(this.tbTMA_MouseEnter);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(90, 122);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(156, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroLabel5.TabIndex = 27;
            this.metroLabel5.Text = "Text Matching Accuracy : ";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(16, 149);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(230, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroLabel6.TabIndex = 30;
            this.metroLabel6.Text = "Recommend NMultiple With Length : ";
            // 
            // tgRNM
            // 
            this.tgRNM.AutoSize = true;
            this.tgRNM.Location = new System.Drawing.Point(222, 149);
            this.tgRNM.Name = "tgRNM";
            this.tgRNM.Size = new System.Drawing.Size(80, 19);
            this.tgRNM.Style = MetroFramework.MetroColorStyle.Pink;
            this.tgRNM.TabIndex = 29;
            this.tgRNM.Text = "Off";
            this.tgRNM.UseSelectable = true;
            this.tgRNM.MouseEnter += new System.EventHandler(this.tgRNM_MouseEnter);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(65, 174);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(181, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroLabel7.TabIndex = 32;
            this.metroLabel7.Text = "Recommend Language ALL : ";
            // 
            // tgRL
            // 
            this.tgRL.AutoSize = true;
            this.tgRL.Location = new System.Drawing.Point(222, 174);
            this.tgRL.Name = "tgRL";
            this.tgRL.Size = new System.Drawing.Size(80, 19);
            this.tgRL.Style = MetroFramework.MetroColorStyle.Pink;
            this.tgRL.TabIndex = 31;
            this.tgRL.Text = "Off";
            this.tgRL.UseSelectable = true;
            this.tgRL.MouseEnter += new System.EventHandler(this.tgRL_MouseEnter);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(81, 199);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(165, 19);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroLabel8.TabIndex = 34;
            this.metroLabel8.Text = "Replace Artists With Title : ";
            // 
            // tgRA
            // 
            this.tgRA.AutoSize = true;
            this.tgRA.Location = new System.Drawing.Point(222, 199);
            this.tgRA.Name = "tgRA";
            this.tgRA.Size = new System.Drawing.Size(80, 19);
            this.tgRA.Style = MetroFramework.MetroColorStyle.Pink;
            this.tgRA.TabIndex = 33;
            this.tgRA.Text = "Off";
            this.tgRA.UseSelectable = true;
            this.tgRA.MouseEnter += new System.EventHandler(this.tgRA_MouseEnter);
            // 
            // bSave
            // 
            this.bSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSave.Location = new System.Drawing.Point(333, 224);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(105, 44);
            this.bSave.Style = MetroFramework.MetroColorStyle.Pink;
            this.bSave.TabIndex = 35;
            this.bSave.Text = "설정 저장";
            this.bSave.Theme = MetroFramework.MetroThemeStyle.Light;
            this.bSave.UseSelectable = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // tbInfo
            // 
            this.tbInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tbInfo.CustomButton.Image = null;
            this.tbInfo.CustomButton.Location = new System.Drawing.Point(277, 2);
            this.tbInfo.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbInfo.CustomButton.Name = "";
            this.tbInfo.CustomButton.Size = new System.Drawing.Size(39, 39);
            this.tbInfo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbInfo.CustomButton.TabIndex = 1;
            this.tbInfo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbInfo.CustomButton.UseSelectable = true;
            this.tbInfo.CustomButton.Visible = false;
            this.tbInfo.Lines = new string[0];
            this.tbInfo.Location = new System.Drawing.Point(8, 224);
            this.tbInfo.MaxLength = 32767;
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.PasswordChar = '\0';
            this.tbInfo.ReadOnly = true;
            this.tbInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbInfo.SelectedText = "";
            this.tbInfo.SelectionLength = 0;
            this.tbInfo.SelectionStart = 0;
            this.tbInfo.ShortcutsEnabled = true;
            this.tbInfo.Size = new System.Drawing.Size(319, 44);
            this.tbInfo.Style = MetroFramework.MetroColorStyle.Pink;
            this.tbInfo.TabIndex = 36;
            this.tbInfo.UseSelectable = true;
            this.tbInfo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbInfo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(450, 280);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.tgRA);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.tgRL);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.tgRNM);
            this.Controls.Add(this.tbTMA);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.tbRPS);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.tgSJ);
            this.Controls.Add(this.tbWT);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.tgWI);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "고급 설정";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroToggle tgWI;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbWT;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroToggle tgSJ;
        private MetroFramework.Controls.MetroTextBox tbRPS;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox tbTMA;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroToggle tgRNM;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroToggle tgRL;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroToggle tgRA;
        private MetroFramework.Controls.MetroButton bSave;
        private MetroFramework.Controls.MetroTextBox tbInfo;
    }
}