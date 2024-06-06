namespace Morphological_Analyzer
{
    partial class morph_frm
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
            this.in_txt = new System.Windows.Forms.RichTextBox();
            this.morph_btn = new System.Windows.Forms.Button();
            this.clr_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.morph_txt = new System.Windows.Forms.RichTextBox();
            this.outtxt = new System.Windows.Forms.RichTextBox();
            this.morphResult = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.copy_btn = new System.Windows.Forms.Button();
            this.key_btn = new System.Windows.Forms.Button();
            this.help_btn = new System.Windows.Forms.Button();
            this.Language = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // in_txt
            // 
            this.in_txt.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.in_txt.Location = new System.Drawing.Point(17, 50);
            this.in_txt.Name = "in_txt";
            this.in_txt.Size = new System.Drawing.Size(611, 248);
            this.in_txt.TabIndex = 0;
            this.in_txt.Text = "";
            // 
            // morph_btn
            // 
            this.morph_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.morph_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.morph_btn.ForeColor = System.Drawing.Color.Cyan;
            this.morph_btn.Location = new System.Drawing.Point(150, 300);
            this.morph_btn.Name = "morph_btn";
            this.morph_btn.Size = new System.Drawing.Size(349, 44);
            this.morph_btn.TabIndex = 1;
            this.morph_btn.Text = "Morphological Analyzer";
            this.morph_btn.UseVisualStyleBackColor = false;
            this.morph_btn.Click += new System.EventHandler(this.morph_btn_Click);
            // 
            // clr_btn
            // 
            this.clr_btn.BackColor = System.Drawing.Color.Cornsilk;
            this.clr_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clr_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clr_btn.Location = new System.Drawing.Point(181, 638);
            this.clr_btn.Name = "clr_btn";
            this.clr_btn.Size = new System.Drawing.Size(117, 36);
            this.clr_btn.TabIndex = 2;
            this.clr_btn.Text = "Clear";
            this.clr_btn.UseVisualStyleBackColor = false;
            this.clr_btn.Click += new System.EventHandler(this.clr_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.Cornsilk;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.ForeColor = System.Drawing.Color.Sienna;
            this.exit_btn.Location = new System.Drawing.Point(459, 640);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(117, 36);
            this.exit_btn.TabIndex = 3;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // morph_txt
            // 
            this.morph_txt.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.morph_txt.Location = new System.Drawing.Point(17, 346);
            this.morph_txt.Name = "morph_txt";
            this.morph_txt.Size = new System.Drawing.Size(611, 286);
            this.morph_txt.TabIndex = 4;
            this.morph_txt.Text = "";
            // 
            // outtxt
            // 
            this.outtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outtxt.Location = new System.Drawing.Point(1033, 50);
            this.outtxt.Name = "outtxt";
            this.outtxt.Size = new System.Drawing.Size(50, 49);
            this.outtxt.TabIndex = 5;
            this.outtxt.Text = "";
            this.outtxt.Visible = false;
            // 
            // morphResult
            // 
            this.morphResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.morphResult.Location = new System.Drawing.Point(1033, 116);
            this.morphResult.Name = "morphResult";
            this.morphResult.Size = new System.Drawing.Size(50, 65);
            this.morphResult.TabIndex = 6;
            this.morphResult.Text = "";
            this.morphResult.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(725, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(766, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(807, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(610, 835);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(326, 12);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(114, 32);
            this.btnBrowse.TabIndex = 11;
            this.btnBrowse.Text = "Browse File";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(17, 12);
            this.txtFile.Multiline = true;
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(303, 32);
            this.txtFile.TabIndex = 12;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(687, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // copy_btn
            // 
            this.copy_btn.BackColor = System.Drawing.Color.Cornsilk;
            this.copy_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.copy_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copy_btn.Location = new System.Drawing.Point(33, 637);
            this.copy_btn.Name = "copy_btn";
            this.copy_btn.Size = new System.Drawing.Size(124, 36);
            this.copy_btn.TabIndex = 14;
            this.copy_btn.Text = "Copy";
            this.copy_btn.UseVisualStyleBackColor = false;
            this.copy_btn.Click += new System.EventHandler(this.copy_btn_Click);
            // 
            // key_btn
            // 
            this.key_btn.BackColor = System.Drawing.Color.Wheat;
            this.key_btn.Location = new System.Drawing.Point(520, 17);
            this.key_btn.Name = "key_btn";
            this.key_btn.Size = new System.Drawing.Size(108, 23);
            this.key_btn.TabIndex = 15;
            this.key_btn.Text = "Tamil Keyboard";
            this.key_btn.UseVisualStyleBackColor = false;
            this.key_btn.Click += new System.EventHandler(this.key_btn_Click);
            // 
            // help_btn
            // 
            this.help_btn.BackColor = System.Drawing.Color.Cornsilk;
            this.help_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help_btn.Location = new System.Drawing.Point(331, 640);
            this.help_btn.Name = "help_btn";
            this.help_btn.Size = new System.Drawing.Size(106, 36);
            this.help_btn.TabIndex = 16;
            this.help_btn.Text = "Help";
            this.help_btn.UseVisualStyleBackColor = false;
            this.help_btn.Click += new System.EventHandler(this.help_btn_Click);
            // 
            // Language
            // 
            this.Language.BackColor = System.Drawing.Color.LemonChiffon;
            this.Language.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Language.Location = new System.Drawing.Point(443, 17);
            this.Language.Name = "Language";
            this.Language.Size = new System.Drawing.Size(75, 23);
            this.Language.TabIndex = 17;
            this.Language.Text = "Tamil";
            this.Language.UseVisualStyleBackColor = false;
            this.Language.Click += new System.EventHandler(this.button2_Click);
            // 
            // morph_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(643, 694);
            this.Controls.Add(this.Language);
            this.Controls.Add(this.help_btn);
            this.Controls.Add(this.key_btn);
            this.Controls.Add(this.copy_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.morphResult);
            this.Controls.Add(this.outtxt);
            this.Controls.Add(this.morph_txt);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.clr_btn);
            this.Controls.Add(this.morph_btn);
            this.Controls.Add(this.in_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "morph_frm";
            this.Text = "Morphological Analyzer for Classical Tamil";
            this.Load += new System.EventHandler(this.morph_frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox in_txt;
        private System.Windows.Forms.Button morph_btn;
        private System.Windows.Forms.Button clr_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.RichTextBox morph_txt;
        private System.Windows.Forms.RichTextBox outtxt;
        private System.Windows.Forms.RichTextBox morphResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button copy_btn;
        private System.Windows.Forms.Button key_btn;
        private System.Windows.Forms.Button help_btn;
        private System.Windows.Forms.Button Language;
    }
}

