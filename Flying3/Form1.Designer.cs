﻿namespace Flying3
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonDaisakusen = new System.Windows.Forms.Button();
            this.textBoxContents = new System.Windows.Forms.TextBox();
            this.textBoxPoint = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.textBoxSessionId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonGacha = new System.Windows.Forms.Button();
            this.buttonQuest = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPeronamin = new System.Windows.Forms.TextBox();
            this.radioButtonFull = new System.Windows.Forms.RadioButton();
            this.radioButtonHalf = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxRadar = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxRadar = new System.Windows.Forms.TextBox();
            this.buttonPerocolo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonPGacha = new System.Windows.Forms.RadioButton();
            this.radioButtonNGacha = new System.Windows.Forms.RadioButton();
            this.radioButtonRGacha = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCWins = new System.Windows.Forms.TextBox();
            this.buttonShinneitai = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxBiyakuLevel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxRank = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxHiyakuLevel = new System.Windows.Forms.TextBox();
            this.checkBoxNHiyaku = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxNBiyakuLevel = new System.Windows.Forms.TextBox();
            this.checkBoxSaveMode = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDaisakusen
            // 
            this.buttonDaisakusen.Location = new System.Drawing.Point(9, 40);
            this.buttonDaisakusen.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDaisakusen.Name = "buttonDaisakusen";
            this.buttonDaisakusen.Size = new System.Drawing.Size(117, 37);
            this.buttonDaisakusen.TabIndex = 0;
            this.buttonDaisakusen.Text = "daisakusen_start";
            this.buttonDaisakusen.UseVisualStyleBackColor = true;
            this.buttonDaisakusen.Click += new System.EventHandler(this.buttonDaisakusen_Click);
            // 
            // textBoxContents
            // 
            this.textBoxContents.Location = new System.Drawing.Point(9, 225);
            this.textBoxContents.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxContents.Multiline = true;
            this.textBoxContents.Name = "textBoxContents";
            this.textBoxContents.ReadOnly = true;
            this.textBoxContents.Size = new System.Drawing.Size(632, 410);
            this.textBoxContents.TabIndex = 1;
            // 
            // textBoxPoint
            // 
            this.textBoxPoint.Location = new System.Drawing.Point(394, 56);
            this.textBoxPoint.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPoint.Name = "textBoxPoint";
            this.textBoxPoint.ReadOnly = true;
            this.textBoxPoint.Size = new System.Drawing.Size(62, 19);
            this.textBoxPoint.TabIndex = 3;
            this.textBoxPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "point";
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(521, 177);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(117, 37);
            this.buttonStop.TabIndex = 5;
            this.buttonStop.Text = "stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // textBoxSessionId
            // 
            this.textBoxSessionId.Location = new System.Drawing.Point(68, 11);
            this.textBoxSessionId.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSessionId.Name = "textBoxSessionId";
            this.textBoxSessionId.Size = new System.Drawing.Size(183, 19);
            this.textBoxSessionId.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "session_id";
            // 
            // buttonGacha
            // 
            this.buttonGacha.Location = new System.Drawing.Point(9, 177);
            this.buttonGacha.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGacha.Name = "buttonGacha";
            this.buttonGacha.Size = new System.Drawing.Size(117, 37);
            this.buttonGacha.TabIndex = 10;
            this.buttonGacha.Text = "gacha_start";
            this.buttonGacha.UseVisualStyleBackColor = true;
            this.buttonGacha.Click += new System.EventHandler(this.buttonGacha_Click);
            // 
            // buttonQuest
            // 
            this.buttonQuest.Location = new System.Drawing.Point(521, 132);
            this.buttonQuest.Margin = new System.Windows.Forms.Padding(2);
            this.buttonQuest.Name = "buttonQuest";
            this.buttonQuest.Size = new System.Drawing.Size(117, 37);
            this.buttonQuest.TabIndex = 12;
            this.buttonQuest.Text = "quest_start";
            this.buttonQuest.UseVisualStyleBackColor = true;
            this.buttonQuest.Click += new System.EventHandler(this.buttonQuest_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(478, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "peronamin";
            // 
            // textBoxPeronamin
            // 
            this.textBoxPeronamin.Location = new System.Drawing.Point(481, 56);
            this.textBoxPeronamin.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPeronamin.Name = "textBoxPeronamin";
            this.textBoxPeronamin.ReadOnly = true;
            this.textBoxPeronamin.Size = new System.Drawing.Size(53, 19);
            this.textBoxPeronamin.TabIndex = 13;
            this.textBoxPeronamin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // radioButtonFull
            // 
            this.radioButtonFull.AutoSize = true;
            this.radioButtonFull.Location = new System.Drawing.Point(11, 18);
            this.radioButtonFull.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonFull.Name = "radioButtonFull";
            this.radioButtonFull.Size = new System.Drawing.Size(39, 16);
            this.radioButtonFull.TabIndex = 15;
            this.radioButtonFull.Text = "full";
            this.radioButtonFull.UseVisualStyleBackColor = true;
            // 
            // radioButtonHalf
            // 
            this.radioButtonHalf.AutoSize = true;
            this.radioButtonHalf.Checked = true;
            this.radioButtonHalf.Location = new System.Drawing.Point(51, 18);
            this.radioButtonHalf.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonHalf.Name = "radioButtonHalf";
            this.radioButtonHalf.Size = new System.Drawing.Size(42, 16);
            this.radioButtonHalf.TabIndex = 16;
            this.radioButtonHalf.TabStop = true;
            this.radioButtonHalf.Text = "half";
            this.radioButtonHalf.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonHalf);
            this.groupBox1.Controls.Add(this.radioButtonFull);
            this.groupBox1.Location = new System.Drawing.Point(133, 40);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(99, 37);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "peronamin type";
            // 
            // checkBoxRadar
            // 
            this.checkBoxRadar.AutoSize = true;
            this.checkBoxRadar.Location = new System.Drawing.Point(244, 58);
            this.checkBoxRadar.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxRadar.Name = "checkBoxRadar";
            this.checkBoxRadar.Size = new System.Drawing.Size(50, 16);
            this.checkBoxRadar.TabIndex = 19;
            this.checkBoxRadar.Text = "radar";
            this.checkBoxRadar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(557, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 12);
            this.label5.TabIndex = 21;
            this.label5.Text = "radar";
            // 
            // textBoxRadar
            // 
            this.textBoxRadar.Location = new System.Drawing.Point(560, 56);
            this.textBoxRadar.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRadar.Name = "textBoxRadar";
            this.textBoxRadar.ReadOnly = true;
            this.textBoxRadar.Size = new System.Drawing.Size(53, 19);
            this.textBoxRadar.TabIndex = 20;
            this.textBoxRadar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonPerocolo
            // 
            this.buttonPerocolo.Location = new System.Drawing.Point(9, 86);
            this.buttonPerocolo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPerocolo.Name = "buttonPerocolo";
            this.buttonPerocolo.Size = new System.Drawing.Size(117, 37);
            this.buttonPerocolo.TabIndex = 22;
            this.buttonPerocolo.Text = "perocolo_start";
            this.buttonPerocolo.UseVisualStyleBackColor = true;
            this.buttonPerocolo.Click += new System.EventHandler(this.buttonPerocolo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonPGacha);
            this.groupBox2.Controls.Add(this.radioButtonNGacha);
            this.groupBox2.Controls.Add(this.radioButtonRGacha);
            this.groupBox2.Location = new System.Drawing.Point(135, 177);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(197, 37);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "gacha type";
            // 
            // radioButtonPGacha
            // 
            this.radioButtonPGacha.AutoSize = true;
            this.radioButtonPGacha.Location = new System.Drawing.Point(122, 18);
            this.radioButtonPGacha.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonPGacha.Name = "radioButtonPGacha";
            this.radioButtonPGacha.Size = new System.Drawing.Size(66, 16);
            this.radioButtonPGacha.TabIndex = 17;
            this.radioButtonPGacha.Text = "perocolo";
            this.radioButtonPGacha.UseVisualStyleBackColor = true;
            // 
            // radioButtonNGacha
            // 
            this.radioButtonNGacha.AutoSize = true;
            this.radioButtonNGacha.Checked = true;
            this.radioButtonNGacha.Location = new System.Drawing.Point(14, 18);
            this.radioButtonNGacha.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonNGacha.Name = "radioButtonNGacha";
            this.radioButtonNGacha.Size = new System.Drawing.Size(57, 16);
            this.radioButtonNGacha.TabIndex = 16;
            this.radioButtonNGacha.TabStop = true;
            this.radioButtonNGacha.Text = "normal";
            this.radioButtonNGacha.UseVisualStyleBackColor = true;
            // 
            // radioButtonRGacha
            // 
            this.radioButtonRGacha.AutoSize = true;
            this.radioButtonRGacha.Location = new System.Drawing.Point(75, 18);
            this.radioButtonRGacha.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonRGacha.Name = "radioButtonRGacha";
            this.radioButtonRGacha.Size = new System.Drawing.Size(43, 16);
            this.radioButtonRGacha.TabIndex = 15;
            this.radioButtonRGacha.Text = "rare";
            this.radioButtonRGacha.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 12);
            this.label6.TabIndex = 25;
            this.label6.Text = "consecutiveWins";
            // 
            // textBoxCWins
            // 
            this.textBoxCWins.Location = new System.Drawing.Point(189, 104);
            this.textBoxCWins.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCWins.Name = "textBoxCWins";
            this.textBoxCWins.ReadOnly = true;
            this.textBoxCWins.Size = new System.Drawing.Size(62, 19);
            this.textBoxCWins.TabIndex = 24;
            this.textBoxCWins.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonShinneitai
            // 
            this.buttonShinneitai.Location = new System.Drawing.Point(9, 132);
            this.buttonShinneitai.Margin = new System.Windows.Forms.Padding(2);
            this.buttonShinneitai.Name = "buttonShinneitai";
            this.buttonShinneitai.Size = new System.Drawing.Size(117, 37);
            this.buttonShinneitai.TabIndex = 26;
            this.buttonShinneitai.Text = "shinneitai_start";
            this.buttonShinneitai.UseVisualStyleBackColor = true;
            this.buttonShinneitai.Click += new System.EventHandler(this.buttonShinneitai_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(300, 137);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 28;
            this.label7.Text = "biyakuLevel";
            // 
            // textBoxBiyakuLevel
            // 
            this.textBoxBiyakuLevel.Location = new System.Drawing.Point(301, 151);
            this.textBoxBiyakuLevel.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBiyakuLevel.Name = "textBoxBiyakuLevel";
            this.textBoxBiyakuLevel.Size = new System.Drawing.Size(43, 19);
            this.textBoxBiyakuLevel.TabIndex = 27;
            this.textBoxBiyakuLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(134, 91);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 12);
            this.label8.TabIndex = 30;
            this.label8.Text = "rank";
            // 
            // textBoxRank
            // 
            this.textBoxRank.Location = new System.Drawing.Point(136, 104);
            this.textBoxRank.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRank.Name = "textBoxRank";
            this.textBoxRank.Size = new System.Drawing.Size(40, 19);
            this.textBoxRank.TabIndex = 29;
            this.textBoxRank.Text = "1";
            this.textBoxRank.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(135, 136);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 32;
            this.label9.Text = "hiyakuLevel";
            // 
            // textBoxHiyakuLevel
            // 
            this.textBoxHiyakuLevel.Location = new System.Drawing.Point(136, 150);
            this.textBoxHiyakuLevel.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxHiyakuLevel.Name = "textBoxHiyakuLevel";
            this.textBoxHiyakuLevel.Size = new System.Drawing.Size(43, 19);
            this.textBoxHiyakuLevel.TabIndex = 31;
            this.textBoxHiyakuLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // checkBoxNHiyaku
            // 
            this.checkBoxNHiyaku.AutoSize = true;
            this.checkBoxNHiyaku.Location = new System.Drawing.Point(190, 153);
            this.checkBoxNHiyaku.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxNHiyaku.Name = "checkBoxNHiyaku";
            this.checkBoxNHiyaku.Size = new System.Drawing.Size(93, 16);
            this.checkBoxNHiyaku.TabIndex = 33;
            this.checkBoxNHiyaku.Text = "normalHiyaku";
            this.checkBoxNHiyaku.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(370, 137);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 12);
            this.label10.TabIndex = 35;
            this.label10.Text = "normalBiyakuLevel";
            // 
            // textBoxNBiyakuLevel
            // 
            this.textBoxNBiyakuLevel.Location = new System.Drawing.Point(371, 151);
            this.textBoxNBiyakuLevel.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNBiyakuLevel.Name = "textBoxNBiyakuLevel";
            this.textBoxNBiyakuLevel.Size = new System.Drawing.Size(43, 19);
            this.textBoxNBiyakuLevel.TabIndex = 34;
            this.textBoxNBiyakuLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // checkBoxSaveMode
            // 
            this.checkBoxSaveMode.AutoSize = true;
            this.checkBoxSaveMode.Location = new System.Drawing.Point(298, 58);
            this.checkBoxSaveMode.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxSaveMode.Name = "checkBoxSaveMode";
            this.checkBoxSaveMode.Size = new System.Drawing.Size(75, 16);
            this.checkBoxSaveMode.TabIndex = 36;
            this.checkBoxSaveMode.Text = "saveMode";
            this.checkBoxSaveMode.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 646);
            this.Controls.Add(this.checkBoxSaveMode);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxNBiyakuLevel);
            this.Controls.Add(this.checkBoxNHiyaku);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxHiyakuLevel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxRank);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxBiyakuLevel);
            this.Controls.Add(this.buttonShinneitai);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxCWins);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonPerocolo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxRadar);
            this.Controls.Add(this.checkBoxRadar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPeronamin);
            this.Controls.Add(this.buttonQuest);
            this.Controls.Add(this.buttonGacha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSessionId);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPoint);
            this.Controls.Add(this.textBoxContents);
            this.Controls.Add(this.buttonDaisakusen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "flying3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDaisakusen;
        private System.Windows.Forms.TextBox textBoxContents;
        private System.Windows.Forms.TextBox textBoxPoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.TextBox textBoxSessionId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonGacha;
        private System.Windows.Forms.Button buttonQuest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPeronamin;
        private System.Windows.Forms.RadioButton radioButtonFull;
        private System.Windows.Forms.RadioButton radioButtonHalf;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxRadar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxRadar;
        private System.Windows.Forms.Button buttonPerocolo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonPGacha;
        private System.Windows.Forms.RadioButton radioButtonNGacha;
        private System.Windows.Forms.RadioButton radioButtonRGacha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCWins;
        private System.Windows.Forms.Button buttonShinneitai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxBiyakuLevel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxRank;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxHiyakuLevel;
        private System.Windows.Forms.CheckBox checkBoxNHiyaku;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxNBiyakuLevel;
        private System.Windows.Forms.CheckBox checkBoxSaveMode;
    }
}

