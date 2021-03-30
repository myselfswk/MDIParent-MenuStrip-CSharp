
namespace MDIParent_MenuStrip_CSharp
{
    partial class StopWatch
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
            this.components = new System.ComponentModel.Container();
            this.lblSetMinutes = new System.Windows.Forms.Label();
            this.lblSetHours = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.txtSetSeconds = new System.Windows.Forms.TextBox();
            this.txtSetMinutes = new System.Windows.Forms.TextBox();
            this.lblSetSeconds = new System.Windows.Forms.Label();
            this.setTimePanel = new System.Windows.Forms.Panel();
            this.btnApply = new System.Windows.Forms.Button();
            this.txtSetHours = new System.Windows.Forms.TextBox();
            this.btnSetTime = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblHours = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.setTimePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSetMinutes
            // 
            this.lblSetMinutes.AutoSize = true;
            this.lblSetMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetMinutes.Location = new System.Drawing.Point(3, 72);
            this.lblSetMinutes.Name = "lblSetMinutes";
            this.lblSetMinutes.Size = new System.Drawing.Size(149, 39);
            this.lblSetMinutes.TabIndex = 0;
            this.lblSetMinutes.Text = "Minutes:";
            // 
            // lblSetHours
            // 
            this.lblSetHours.AutoSize = true;
            this.lblSetHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetHours.Location = new System.Drawing.Point(3, 10);
            this.lblSetHours.Name = "lblSetHours";
            this.lblSetHours.Size = new System.Drawing.Size(120, 39);
            this.lblSetHours.TabIndex = 0;
            this.lblSetHours.Text = "Hours:";
            // 
            // btnStop
            // 
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.Enabled = false;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(385, 268);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(141, 66);
            this.btnStop.TabIndex = 11;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnPause
            // 
            this.btnPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPause.Enabled = false;
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(213, 268);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(141, 66);
            this.btnPause.TabIndex = 12;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(39, 268);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(141, 66);
            this.btnStart.TabIndex = 13;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeconds.Location = new System.Drawing.Point(418, 127);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(108, 75);
            this.lblSeconds.TabIndex = 6;
            this.lblSeconds.Text = "00";
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutes.Location = new System.Drawing.Point(227, 127);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(108, 75);
            this.lblMinutes.TabIndex = 7;
            this.lblMinutes.Text = "00";
            // 
            // txtSetSeconds
            // 
            this.txtSetSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSetSeconds.Location = new System.Drawing.Point(176, 132);
            this.txtSetSeconds.MaxLength = 2;
            this.txtSetSeconds.Name = "txtSetSeconds";
            this.txtSetSeconds.Size = new System.Drawing.Size(71, 47);
            this.txtSetSeconds.TabIndex = 1;
            // 
            // txtSetMinutes
            // 
            this.txtSetMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSetMinutes.Location = new System.Drawing.Point(176, 69);
            this.txtSetMinutes.MaxLength = 2;
            this.txtSetMinutes.Name = "txtSetMinutes";
            this.txtSetMinutes.Size = new System.Drawing.Size(71, 47);
            this.txtSetMinutes.TabIndex = 1;
            // 
            // lblSetSeconds
            // 
            this.lblSetSeconds.AutoSize = true;
            this.lblSetSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetSeconds.Location = new System.Drawing.Point(3, 135);
            this.lblSetSeconds.Name = "lblSetSeconds";
            this.lblSetSeconds.Size = new System.Drawing.Size(162, 39);
            this.lblSetSeconds.TabIndex = 0;
            this.lblSetSeconds.Text = "Seconds:";
            // 
            // setTimePanel
            // 
            this.setTimePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.setTimePanel.Controls.Add(this.btnApply);
            this.setTimePanel.Controls.Add(this.txtSetSeconds);
            this.setTimePanel.Controls.Add(this.txtSetMinutes);
            this.setTimePanel.Controls.Add(this.lblSetSeconds);
            this.setTimePanel.Controls.Add(this.lblSetMinutes);
            this.setTimePanel.Controls.Add(this.txtSetHours);
            this.setTimePanel.Controls.Add(this.lblSetHours);
            this.setTimePanel.Location = new System.Drawing.Point(612, 131);
            this.setTimePanel.Name = "setTimePanel";
            this.setTimePanel.Size = new System.Drawing.Size(254, 306);
            this.setTimePanel.TabIndex = 15;
            this.setTimePanel.Visible = false;
            // 
            // btnApply
            // 
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Location = new System.Drawing.Point(153, 205);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(94, 39);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // txtSetHours
            // 
            this.txtSetHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSetHours.Location = new System.Drawing.Point(176, 7);
            this.txtSetHours.MaxLength = 2;
            this.txtSetHours.Name = "txtSetHours";
            this.txtSetHours.Size = new System.Drawing.Size(71, 47);
            this.txtSetHours.TabIndex = 1;
            // 
            // btnSetTime
            // 
            this.btnSetTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetTime.Location = new System.Drawing.Point(612, 33);
            this.btnSetTime.Name = "btnSetTime";
            this.btnSetTime.Size = new System.Drawing.Size(254, 93);
            this.btnSetTime.TabIndex = 14;
            this.btnSetTime.Text = "Set Time";
            this.btnSetTime.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(341, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 73);
            this.label3.TabIndex = 8;
            this.label3.Text = "::";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 73);
            this.label2.TabIndex = 9;
            this.label2.Text = "::";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.Location = new System.Drawing.Point(39, 127);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(108, 75);
            this.lblHours.TabIndex = 10;
            this.lblHours.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "My Stop Watch";
            // 
            // StopWatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 510);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.setTimePanel);
            this.Controls.Add(this.btnSetTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.label1);
            this.Name = "StopWatch";
            this.Text = "StopWatch";
            this.setTimePanel.ResumeLayout(false);
            this.setTimePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSetMinutes;
        private System.Windows.Forms.Label lblSetHours;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.TextBox txtSetSeconds;
        private System.Windows.Forms.TextBox txtSetMinutes;
        private System.Windows.Forms.Label lblSetSeconds;
        private System.Windows.Forms.Panel setTimePanel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TextBox txtSetHours;
        private System.Windows.Forms.Button btnSetTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label label1;
    }
}