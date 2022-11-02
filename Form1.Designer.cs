namespace Лаба4
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
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.ref_down = new System.Windows.Forms.Button();
            this.ref_up = new System.Windows.Forms.Button();
            this.btn_move_y_d = new System.Windows.Forms.Button();
            this.btn_move_y_u = new System.Windows.Forms.Button();
            this.btn_move_x_l = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_move_x_r = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button9
            // 
            this.button9.Image = global::Лаба4.Properties.Resources.опоп;
            this.button9.Location = new System.Drawing.Point(737, 581);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(61, 58);
            this.button9.TabIndex = 8;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(737, 519);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(87, 56);
            this.button8.TabIndex = 7;
            this.button8.Text = "button_8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(737, 453);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(87, 60);
            this.button7.TabIndex = 6;
            this.button7.Text = "button_7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // ref_down
            // 
            this.ref_down.Image = global::Лаба4.Properties.Resources.внизз;
            this.ref_down.Location = new System.Drawing.Point(737, 373);
            this.ref_down.Name = "ref_down";
            this.ref_down.Size = new System.Drawing.Size(61, 74);
            this.ref_down.TabIndex = 5;
            this.ref_down.UseVisualStyleBackColor = true;
            this.ref_down.Click += new System.EventHandler(this.ref_down_Click);
            // 
            // ref_up
            // 
            this.ref_up.Image = global::Лаба4.Properties.Resources.вверх;
            this.ref_up.Location = new System.Drawing.Point(737, 296);
            this.ref_up.Name = "ref_up";
            this.ref_up.Size = new System.Drawing.Size(61, 71);
            this.ref_up.TabIndex = 4;
            this.ref_up.UseVisualStyleBackColor = true;
            this.ref_up.Click += new System.EventHandler(this.ref_up_Click);
            // 
            // btn_move_y_d
            // 
            this.btn_move_y_d.Image = global::Лаба4.Properties.Resources.вниз;
            this.btn_move_y_d.Location = new System.Drawing.Point(737, 232);
            this.btn_move_y_d.Name = "btn_move_y_d";
            this.btn_move_y_d.Size = new System.Drawing.Size(61, 58);
            this.btn_move_y_d.TabIndex = 3;
            this.btn_move_y_d.UseVisualStyleBackColor = true;
            this.btn_move_y_d.Click += new System.EventHandler(this.btn_down);
            // 
            // btn_move_y_u
            // 
            this.btn_move_y_u.Image = global::Лаба4.Properties.Resources.верх;
            this.btn_move_y_u.Location = new System.Drawing.Point(737, 164);
            this.btn_move_y_u.Name = "btn_move_y_u";
            this.btn_move_y_u.Size = new System.Drawing.Size(61, 62);
            this.btn_move_y_u.TabIndex = 2;
            this.btn_move_y_u.UseVisualStyleBackColor = true;
            this.btn_move_y_u.Click += new System.EventHandler(this.btn_up);
            // 
            // btn_move_x_l
            // 
            this.btn_move_x_l.Image = global::Лаба4.Properties.Resources.лево;
            this.btn_move_x_l.Location = new System.Drawing.Point(737, 97);
            this.btn_move_x_l.Name = "btn_move_x_l";
            this.btn_move_x_l.Size = new System.Drawing.Size(61, 61);
            this.btn_move_x_l.TabIndex = 1;
            this.btn_move_x_l.UseVisualStyleBackColor = true;
            this.btn_move_x_l.Click += new System.EventHandler(this.btn_left);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(30, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(649, 607);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // btn_move_x_r
            // 
            this.btn_move_x_r.Image = global::Лаба4.Properties.Resources.e97b5050a25455d87c59005fc706e21;
            this.btn_move_x_r.Location = new System.Drawing.Point(737, 30);
            this.btn_move_x_r.Name = "btn_move_x_r";
            this.btn_move_x_r.Size = new System.Drawing.Size(61, 61);
            this.btn_move_x_r.TabIndex = 10;
            this.btn_move_x_r.UseVisualStyleBackColor = true;
            this.btn_move_x_r.Click += new System.EventHandler(this.btn_right);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 650);
            this.Controls.Add(this.btn_move_x_r);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.ref_down);
            this.Controls.Add(this.ref_up);
            this.Controls.Add(this.btn_move_y_d);
            this.Controls.Add(this.btn_move_y_u);
            this.Controls.Add(this.btn_move_x_l);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_move_x_l;
        private System.Windows.Forms.Button btn_move_y_u;
        private System.Windows.Forms.Button btn_move_y_d;
        private System.Windows.Forms.Button ref_up;
        private System.Windows.Forms.Button ref_down;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_move_x_r;
    }
}

