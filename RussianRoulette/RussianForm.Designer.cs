namespace RussianRoulette
{
    partial class RussianRoulette
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
            this.btn_Load = new System.Windows.Forms.Button();
            this.btn_Spin = new System.Windows.Forms.Button();
            this.btn_Shoot = new System.Windows.Forms.Button();
            this.btn_ShootAway = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.PicBox_Gun = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Gun)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Load
            // 
            this.btn_Load.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_Load.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Load.FlatAppearance.BorderSize = 5;
            this.btn_Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Load.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Load.Location = new System.Drawing.Point(21, 105);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(136, 74);
            this.btn_Load.TabIndex = 0;
            this.btn_Load.Text = "Load Gun";
            this.btn_Load.UseVisualStyleBackColor = false;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // btn_Spin
            // 
            this.btn_Spin.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_Spin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Spin.FlatAppearance.BorderSize = 5;
            this.btn_Spin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Spin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Spin.Location = new System.Drawing.Point(21, 12);
            this.btn_Spin.Name = "btn_Spin";
            this.btn_Spin.Size = new System.Drawing.Size(136, 74);
            this.btn_Spin.TabIndex = 1;
            this.btn_Spin.Text = "Spin Chamber";
            this.btn_Spin.UseVisualStyleBackColor = false;
            this.btn_Spin.Click += new System.EventHandler(this.btn_Spin_Click);
            // 
            // btn_Shoot
            // 
            this.btn_Shoot.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_Shoot.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Shoot.FlatAppearance.BorderSize = 5;
            this.btn_Shoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Shoot.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Shoot.Location = new System.Drawing.Point(21, 205);
            this.btn_Shoot.Name = "btn_Shoot";
            this.btn_Shoot.Size = new System.Drawing.Size(136, 73);
            this.btn_Shoot.TabIndex = 2;
            this.btn_Shoot.Text = "Shoot Bullet";
            this.btn_Shoot.UseVisualStyleBackColor = false;
            this.btn_Shoot.Click += new System.EventHandler(this.btn_Shoot_Click);
            // 
            // btn_ShootAway
            // 
            this.btn_ShootAway.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_ShootAway.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_ShootAway.FlatAppearance.BorderSize = 5;
            this.btn_ShootAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ShootAway.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ShootAway.Location = new System.Drawing.Point(21, 301);
            this.btn_ShootAway.Name = "btn_ShootAway";
            this.btn_ShootAway.Size = new System.Drawing.Size(136, 73);
            this.btn_ShootAway.TabIndex = 3;
            this.btn_ShootAway.Text = "Shoot Away";
            this.btn_ShootAway.UseVisualStyleBackColor = false;
            this.btn_ShootAway.Click += new System.EventHandler(this.btn_ShootAway_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_Exit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Exit.FlatAppearance.BorderSize = 5;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Exit.Location = new System.Drawing.Point(225, 326);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(136, 73);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // PicBox_Gun
            // 
            this.PicBox_Gun.Location = new System.Drawing.Point(195, 12);
            this.PicBox_Gun.Name = "PicBox_Gun";
            this.PicBox_Gun.Size = new System.Drawing.Size(349, 299);
            this.PicBox_Gun.TabIndex = 6;
            this.PicBox_Gun.TabStop = false;
            // 
            // RussianRoulette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.PicBox_Gun);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_ShootAway);
            this.Controls.Add(this.btn_Shoot);
            this.Controls.Add(this.btn_Spin);
            this.Controls.Add(this.btn_Load);
            this.Name = "RussianRoulette";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Russian Roullete";
            this.Load += new System.EventHandler(this.RussianRoulette_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Gun)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Button btn_Spin;
        private System.Windows.Forms.Button btn_Shoot;
        private System.Windows.Forms.Button btn_ShootAway;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.PictureBox PicBox_Gun;
    }
}

