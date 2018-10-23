namespace ReadersWriters
{
    partial class Form1
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
            this.wrtrtrck = new System.Windows.Forms.TrackBar();
            this.rdrtrck1 = new System.Windows.Forms.TrackBar();
            this.rdrtrck2 = new System.Windows.Forms.TrackBar();
            this.rdrtrck3 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.wrtrlbl = new System.Windows.Forms.Label();
            this.rdrlbl1 = new System.Windows.Forms.Label();
            this.rdrlbl2 = new System.Windows.Forms.Label();
            this.rdrlbl3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.wrtrstt = new System.Windows.Forms.Label();
            this.rdr1stt = new System.Windows.Forms.Label();
            this.rdr2stt = new System.Windows.Forms.Label();
            this.rdr3stt = new System.Windows.Forms.Label();
            this.logtxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wrtrtrck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdrtrck1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdrtrck2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdrtrck3)).BeginInit();
            this.SuspendLayout();
            // 
            // wrtrtrck
            // 
            this.wrtrtrck.Location = new System.Drawing.Point(42, 62);
            this.wrtrtrck.Minimum = 1;
            this.wrtrtrck.Name = "wrtrtrck";
            this.wrtrtrck.Size = new System.Drawing.Size(195, 56);
            this.wrtrtrck.TabIndex = 0;
            this.wrtrtrck.Value = 3;
            this.wrtrtrck.Scroll += new System.EventHandler(this.wrtrtrck_Scroll);
            // 
            // rdrtrck1
            // 
            this.rdrtrck1.Location = new System.Drawing.Point(570, 62);
            this.rdrtrck1.Minimum = 1;
            this.rdrtrck1.Name = "rdrtrck1";
            this.rdrtrck1.Size = new System.Drawing.Size(195, 56);
            this.rdrtrck1.TabIndex = 1;
            this.rdrtrck1.Value = 1;
            this.rdrtrck1.Scroll += new System.EventHandler(this.rdrtrck1_Scroll);
            // 
            // rdrtrck2
            // 
            this.rdrtrck2.Location = new System.Drawing.Point(42, 350);
            this.rdrtrck2.Minimum = 1;
            this.rdrtrck2.Name = "rdrtrck2";
            this.rdrtrck2.Size = new System.Drawing.Size(195, 56);
            this.rdrtrck2.TabIndex = 2;
            this.rdrtrck2.Value = 1;
            this.rdrtrck2.Scroll += new System.EventHandler(this.rdrtrck2_Scroll);
            // 
            // rdrtrck3
            // 
            this.rdrtrck3.Location = new System.Drawing.Point(570, 350);
            this.rdrtrck3.Minimum = 1;
            this.rdrtrck3.Name = "rdrtrck3";
            this.rdrtrck3.Size = new System.Drawing.Size(195, 56);
            this.rdrtrck3.TabIndex = 3;
            this.rdrtrck3.Value = 1;
            this.rdrtrck3.Scroll += new System.EventHandler(this.rdrtrck3_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Writer";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(647, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Reader 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Reader 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(647, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Reader 3";
            // 
            // wrtrlbl
            // 
            this.wrtrlbl.AutoSize = true;
            this.wrtrlbl.Location = new System.Drawing.Point(173, 109);
            this.wrtrlbl.Name = "wrtrlbl";
            this.wrtrlbl.Size = new System.Drawing.Size(16, 17);
            this.wrtrlbl.TabIndex = 8;
            this.wrtrlbl.Text = "0";
            this.wrtrlbl.Click += new System.EventHandler(this.label5_Click);
            // 
            // rdrlbl1
            // 
            this.rdrlbl1.AutoSize = true;
            this.rdrlbl1.Location = new System.Drawing.Point(698, 109);
            this.rdrlbl1.Name = "rdrlbl1";
            this.rdrlbl1.Size = new System.Drawing.Size(16, 17);
            this.rdrlbl1.TabIndex = 9;
            this.rdrlbl1.Text = "0";
            this.rdrlbl1.Click += new System.EventHandler(this.rdrlbl1_Click);
            // 
            // rdrlbl2
            // 
            this.rdrlbl2.AutoSize = true;
            this.rdrlbl2.Location = new System.Drawing.Point(162, 388);
            this.rdrlbl2.Name = "rdrlbl2";
            this.rdrlbl2.Size = new System.Drawing.Size(16, 17);
            this.rdrlbl2.TabIndex = 10;
            this.rdrlbl2.Text = "0";
            // 
            // rdrlbl3
            // 
            this.rdrlbl3.AutoSize = true;
            this.rdrlbl3.Location = new System.Drawing.Point(699, 388);
            this.rdrlbl3.Name = "rdrlbl3";
            this.rdrlbl3.Size = new System.Drawing.Size(16, 17);
            this.rdrlbl3.TabIndex = 11;
            this.rdrlbl3.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Written:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(647, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Read:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(110, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Read:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(647, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Read:";
            // 
            // wrtrstt
            // 
            this.wrtrstt.AutoSize = true;
            this.wrtrstt.Location = new System.Drawing.Point(121, 138);
            this.wrtrstt.Name = "wrtrstt";
            this.wrtrstt.Size = new System.Drawing.Size(41, 17);
            this.wrtrstt.TabIndex = 16;
            this.wrtrstt.Text = "State";
            // 
            // rdr1stt
            // 
            this.rdr1stt.AutoSize = true;
            this.rdr1stt.Location = new System.Drawing.Point(652, 138);
            this.rdr1stt.Name = "rdr1stt";
            this.rdr1stt.Size = new System.Drawing.Size(41, 17);
            this.rdr1stt.TabIndex = 17;
            this.rdr1stt.Text = "State";
            // 
            // rdr2stt
            // 
            this.rdr2stt.AutoSize = true;
            this.rdr2stt.Location = new System.Drawing.Point(121, 424);
            this.rdr2stt.Name = "rdr2stt";
            this.rdr2stt.Size = new System.Drawing.Size(41, 17);
            this.rdr2stt.TabIndex = 18;
            this.rdr2stt.Text = "State";
            // 
            // rdr3stt
            // 
            this.rdr3stt.AutoSize = true;
            this.rdr3stt.Location = new System.Drawing.Point(652, 424);
            this.rdr3stt.Name = "rdr3stt";
            this.rdr3stt.Size = new System.Drawing.Size(41, 17);
            this.rdr3stt.TabIndex = 19;
            this.rdr3stt.Text = "State";
            // 
            // logtxt
            // 
            this.logtxt.Location = new System.Drawing.Point(295, 233);
            this.logtxt.Multiline = true;
            this.logtxt.Name = "logtxt";
            this.logtxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logtxt.Size = new System.Drawing.Size(221, 208);
            this.logtxt.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(386, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Log";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.logtxt);
            this.Controls.Add(this.rdr3stt);
            this.Controls.Add(this.rdr2stt);
            this.Controls.Add(this.rdr1stt);
            this.Controls.Add(this.wrtrstt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rdrlbl3);
            this.Controls.Add(this.rdrlbl2);
            this.Controls.Add(this.rdrlbl1);
            this.Controls.Add(this.wrtrlbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdrtrck3);
            this.Controls.Add(this.rdrtrck2);
            this.Controls.Add(this.rdrtrck1);
            this.Controls.Add(this.wrtrtrck);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wrtrtrck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdrtrck1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdrtrck2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdrtrck3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar wrtrtrck;
        private System.Windows.Forms.TrackBar rdrtrck1;
        private System.Windows.Forms.TrackBar rdrtrck2;
        private System.Windows.Forms.TrackBar rdrtrck3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label wrtrlbl;
        private System.Windows.Forms.Label rdrlbl1;
        private System.Windows.Forms.Label rdrlbl2;
        private System.Windows.Forms.Label rdrlbl3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label wrtrstt;
        private System.Windows.Forms.Label rdr1stt;
        private System.Windows.Forms.Label rdr2stt;
        private System.Windows.Forms.Label rdr3stt;
        private System.Windows.Forms.TextBox logtxt;
        private System.Windows.Forms.Label label9;
    }
}

