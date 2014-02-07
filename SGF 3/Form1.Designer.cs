namespace SGF_3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pos1 = new System.Windows.Forms.Button();
            this.pos2 = new System.Windows.Forms.Button();
            this.pos3 = new System.Windows.Forms.Button();
            this.nombre1 = new System.Windows.Forms.Label();
            this.comp1 = new System.Windows.Forms.Label();
            this.chapa1 = new System.Windows.Forms.TableLayoutPanel();
            this.nombre2 = new System.Windows.Forms.Label();
            this.comp2 = new System.Windows.Forms.Label();
            this.chapa2 = new System.Windows.Forms.TableLayoutPanel();
            this.chapa1.SuspendLayout();
            this.chapa2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pos1
            // 
            this.pos1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pos1.FlatAppearance.BorderSize = 2;
            this.pos1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pos1.Location = new System.Drawing.Point(1102, 256);
            this.pos1.Name = "pos1";
            this.pos1.Size = new System.Drawing.Size(166, 50);
            this.pos1.TabIndex = 4;
            this.pos1.Text = "Sin Asignar";
            this.pos1.UseVisualStyleBackColor = false;
            this.pos1.Click += new System.EventHandler(this.pos1_Click);
            // 
            // pos2
            // 
            this.pos2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pos2.FlatAppearance.BorderSize = 2;
            this.pos2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pos2.Location = new System.Drawing.Point(1102, 355);
            this.pos2.Name = "pos2";
            this.pos2.Size = new System.Drawing.Size(166, 50);
            this.pos2.TabIndex = 6;
            this.pos2.Text = "Sin Asignar";
            this.pos2.UseVisualStyleBackColor = false;
            this.pos2.Click += new System.EventHandler(this.pos2_Click);
            // 
            // pos3
            // 
            this.pos3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pos3.FlatAppearance.BorderSize = 2;
            this.pos3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pos3.Location = new System.Drawing.Point(1102, 454);
            this.pos3.Name = "pos3";
            this.pos3.Size = new System.Drawing.Size(166, 50);
            this.pos3.TabIndex = 7;
            this.pos3.Text = "Sin Asignar";
            this.pos3.UseVisualStyleBackColor = false;
            this.pos3.Click += new System.EventHandler(this.pos3_Click);
            // 
            // nombre1
            // 
            this.nombre1.AutoSize = true;
            this.nombre1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nombre1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre1.Location = new System.Drawing.Point(3, 0);
            this.nombre1.Name = "nombre1";
            this.nombre1.Size = new System.Drawing.Size(160, 30);
            this.nombre1.TabIndex = 0;
            this.nombre1.Text = "nombre1";
            this.nombre1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nombre1.Click += new System.EventHandler(this.Chapa1_Click);
            // 
            // comp1
            // 
            this.comp1.AutoSize = true;
            this.comp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comp1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comp1.Location = new System.Drawing.Point(3, 30);
            this.comp1.Name = "comp1";
            this.comp1.Size = new System.Drawing.Size(160, 20);
            this.comp1.TabIndex = 1;
            this.comp1.Text = "label2";
            this.comp1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.comp1.Click += new System.EventHandler(this.Chapa1_Click);
            // 
            // chapa1
            // 
            this.chapa1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.chapa1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.chapa1.ColumnCount = 1;
            this.chapa1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.chapa1.Controls.Add(this.comp1, 0, 1);
            this.chapa1.Controls.Add(this.nombre1, 0, 0);
            this.chapa1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chapa1.Location = new System.Drawing.Point(1102, 68);
            this.chapa1.MinimumSize = new System.Drawing.Size(166, 50);
            this.chapa1.Name = "chapa1";
            this.chapa1.RowCount = 2;
            this.chapa1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.chapa1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.chapa1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.chapa1.Size = new System.Drawing.Size(166, 50);
            this.chapa1.TabIndex = 0;
            this.chapa1.Click += new System.EventHandler(this.Chapa1_Click);
            // 
            // nombre2
            // 
            this.nombre2.AutoSize = true;
            this.nombre2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nombre2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre2.Location = new System.Drawing.Point(3, 0);
            this.nombre2.Name = "nombre2";
            this.nombre2.Size = new System.Drawing.Size(160, 30);
            this.nombre2.TabIndex = 0;
            this.nombre2.Text = "label2";
            this.nombre2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nombre2.Click += new System.EventHandler(this.Chapa2_Click);
            // 
            // comp2
            // 
            this.comp2.AutoSize = true;
            this.comp2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comp2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comp2.Location = new System.Drawing.Point(3, 30);
            this.comp2.Name = "comp2";
            this.comp2.Size = new System.Drawing.Size(160, 20);
            this.comp2.TabIndex = 1;
            this.comp2.Text = "label2";
            this.comp2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.comp2.Click += new System.EventHandler(this.Chapa2_Click);
            // 
            // chapa2
            // 
            this.chapa2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.chapa2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.chapa2.ColumnCount = 1;
            this.chapa2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.chapa2.Controls.Add(this.comp2, 0, 1);
            this.chapa2.Controls.Add(this.nombre2, 0, 0);
            this.chapa2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chapa2.Location = new System.Drawing.Point(1102, 158);
            this.chapa2.MinimumSize = new System.Drawing.Size(166, 50);
            this.chapa2.Name = "chapa2";
            this.chapa2.RowCount = 2;
            this.chapa2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.chapa2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.chapa2.Size = new System.Drawing.Size(166, 50);
            this.chapa2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.chapa2);
            this.Controls.Add(this.chapa1);
            this.Controls.Add(this.pos3);
            this.Controls.Add(this.pos2);
            this.Controls.Add(this.pos1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1280, 768);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1280, 768);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGF V3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.chapa1.ResumeLayout(false);
            this.chapa1.PerformLayout();
            this.chapa2.ResumeLayout(false);
            this.chapa2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pos1;
        private System.Windows.Forms.Button pos2;
        private System.Windows.Forms.Button pos3;
        private System.Windows.Forms.Label nombre1;
        private System.Windows.Forms.Label comp1;
        public System.Windows.Forms.TableLayoutPanel chapa1;
        private System.Windows.Forms.Label nombre2;
        private System.Windows.Forms.Label comp2;
        public System.Windows.Forms.TableLayoutPanel chapa2;


    }
}

