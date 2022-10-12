
namespace Game
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
<<<<<<< Updated upstream
            this.components = new System.ComponentModel.Container();
            this.player = new System.Windows.Forms.PictureBox();
            this.player2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Ballpicture = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ballpicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.Image = global::Game.Properties.Resources.donut_circle;
            this.player.Location = new System.Drawing.Point(81, 59);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(100, 50);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // player2
            // 
            this.player2.Image = global::Game.Properties.Resources.froyo_circle;
            this.player2.Location = new System.Drawing.Point(350, 200);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(100, 50);
            this.player2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player2.TabIndex = 1;
            this.player2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.Location = new System.Drawing.Point(12, 291);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 11);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Ballpicture
            // 
            this.Ballpicture.BackColor = System.Drawing.Color.IndianRed;
            this.Ballpicture.Location = new System.Drawing.Point(617, 90);
            this.Ballpicture.Name = "Ballpicture";
            this.Ballpicture.Size = new System.Drawing.Size(19, 19);
            this.Ballpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ballpicture.TabIndex = 4;
            this.Ballpicture.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox2.Location = new System.Drawing.Point(12, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(700, 11);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox3.Location = new System.Drawing.Point(702, 29);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 266);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Ballpicture);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ballpicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

=======
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.Ballpicture3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.ballpicture2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Ballpicture = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.player2 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ballpicture3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballpicture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ballpicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 11);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(137, 18);
            this.progressBar1.TabIndex = 2;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Game.Properties.Resources.images;
            this.pictureBox5.Location = new System.Drawing.Point(995, 239);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(89, 64);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // Ballpicture3
            // 
            this.Ballpicture3.BackColor = System.Drawing.Color.IndianRed;
            this.Ballpicture3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Ballpicture3.Image = global::Game.Properties.Resources.download;
            this.Ballpicture3.Location = new System.Drawing.Point(794, 404);
            this.Ballpicture3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ballpicture3.Name = "Ballpicture3";
            this.Ballpicture3.Size = new System.Drawing.Size(24, 29);
            this.Ballpicture3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ballpicture3.TabIndex = 9;
            this.Ballpicture3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.DarkGreen;
            this.pictureBox4.Location = new System.Drawing.Point(0, 42);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(10, 425);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // ballpicture2
            // 
            this.ballpicture2.BackColor = System.Drawing.Color.IndianRed;
            this.ballpicture2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ballpicture2.Image = global::Game.Properties.Resources.download;
            this.ballpicture2.Location = new System.Drawing.Point(463, 189);
            this.ballpicture2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ballpicture2.Name = "ballpicture2";
            this.ballpicture2.Size = new System.Drawing.Size(24, 29);
            this.ballpicture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ballpicture2.TabIndex = 7;
            this.ballpicture2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DarkGreen;
            this.pictureBox3.Location = new System.Drawing.Point(1069, 42);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(15, 427);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkGreen;
            this.pictureBox2.Location = new System.Drawing.Point(0, 42);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1084, 12);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // Ballpicture
            // 
            this.Ballpicture.BackColor = System.Drawing.Color.IndianRed;
            this.Ballpicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Ballpicture.Image = global::Game.Properties.Resources.download;
            this.Ballpicture.Location = new System.Drawing.Point(775, 102);
            this.Ballpicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ballpicture.Name = "Ballpicture";
            this.Ballpicture.Size = new System.Drawing.Size(24, 29);
            this.Ballpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ballpicture.TabIndex = 4;
            this.Ballpicture.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGreen;
            this.pictureBox1.Location = new System.Drawing.Point(0, 459);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1084, 10);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // player2
            // 
            this.player2.Image = global::Game.Properties.Resources.Hankkk;
            this.player2.Location = new System.Drawing.Point(53, 299);
            this.player2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(85, 85);
            this.player2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player2.TabIndex = 1;
            this.player2.TabStop = false;
            // 
            // player
            // 
            this.player.Image = global::Game.Properties.Resources._62b46638bedf9aabc6b3c121_Walter_white;
            this.player.Location = new System.Drawing.Point(53, 120);
            this.player.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(85, 85);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 480);
            this.Controls.Add(this.Ballpicture3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.ballpicture2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Ballpicture);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pictureBox5);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Kanye Chase";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ballpicture3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballpicture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ballpicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);

>>>>>>> Stashed changes
        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox player2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Ballpicture;
        private System.Windows.Forms.PictureBox pictureBox2;
<<<<<<< Updated upstream
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
=======
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox ballpicture2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox Ballpicture3;
        private System.Windows.Forms.PictureBox pictureBox5;
>>>>>>> Stashed changes
    }
}

