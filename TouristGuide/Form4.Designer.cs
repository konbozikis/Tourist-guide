﻿namespace TouristGuide
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.μενούtoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ιστορικόtoolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.καθαρισμόςΙστορικούtoolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.έξοδοςtoolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Πίσω";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.UseWaitCursor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(30, 588);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.UseWaitCursor = true;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.μενούtoolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(885, 24);
            this.menuStrip2.TabIndex = 22;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.UseWaitCursor = true;
            // 
            // μενούtoolStripMenuItem1
            // 
            this.μενούtoolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ιστορικόtoolStripMenuItem2,
            this.καθαρισμόςΙστορικούtoolStripMenuItem3,
            this.έξοδοςtoolStripMenuItem4});
            this.μενούtoolStripMenuItem1.Name = "μενούtoolStripMenuItem1";
            this.μενούtoolStripMenuItem1.Size = new System.Drawing.Size(55, 20);
            this.μενούtoolStripMenuItem1.Text = "Μενού";
            // 
            // ιστορικόtoolStripMenuItem2
            // 
            this.ιστορικόtoolStripMenuItem2.Name = "ιστορικόtoolStripMenuItem2";
            this.ιστορικόtoolStripMenuItem2.Size = new System.Drawing.Size(195, 22);
            this.ιστορικόtoolStripMenuItem2.Text = "Ιστορικό";
            // 
            // καθαρισμόςΙστορικούtoolStripMenuItem3
            // 
            this.καθαρισμόςΙστορικούtoolStripMenuItem3.Name = "καθαρισμόςΙστορικούtoolStripMenuItem3";
            this.καθαρισμόςΙστορικούtoolStripMenuItem3.Size = new System.Drawing.Size(195, 22);
            this.καθαρισμόςΙστορικούtoolStripMenuItem3.Text = "Καθαρισμός Ιστορικού";
            // 
            // έξοδοςtoolStripMenuItem4
            // 
            this.έξοδοςtoolStripMenuItem4.Name = "έξοδοςtoolStripMenuItem4";
            this.έξοδοςtoolStripMenuItem4.Size = new System.Drawing.Size(195, 22);
            this.έξοδοςtoolStripMenuItem4.Text = "Έξοδος";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.Window;
            this.monthCalendar1.Location = new System.Drawing.Point(353, 45);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 23;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(885, 612);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form4";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Ημερολόγιο Εκδηλώσεων";
            this.UseWaitCursor = true;
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem μενούtoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ιστορικόtoolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem καθαρισμόςΙστορικούtoolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem έξοδοςtoolStripMenuItem4;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}