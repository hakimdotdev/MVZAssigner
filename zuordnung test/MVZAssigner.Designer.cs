
namespace zuordnung_test
{
    partial class MVZAssigner
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            MaterialSkin.Controls.MaterialLabel materialLabel7;
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnAssign = new MaterialSkin.Controls.MaterialFlatButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.txtDest = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.name = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.htPassUnix = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.maid = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.htPassSmb = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.button5 = new System.Windows.Forms.Button();
            this.btnGen = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.button4 = new System.Windows.Forms.Button();
            this.txtRootPath = new MaterialSkin.Controls.MaterialSingleLineTextField();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            materialLabel7.Depth = 0;
            materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            materialLabel7.Location = new System.Drawing.Point(6, 83);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new System.Drawing.Size(144, 19);
            materialLabel7.TabIndex = 25;
            materialLabel7.Text = "Unix .htpasswd Pfad";
            // 
            // btnAssign
            // 
            this.btnAssign.AutoSize = true;
            this.btnAssign.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAssign.BackColor = System.Drawing.Color.White;
            this.btnAssign.Depth = 0;
            this.btnAssign.Location = new System.Drawing.Point(16, 454);
            this.btnAssign.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAssign.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Primary = false;
            this.btnAssign.Size = new System.Drawing.Size(83, 36);
            this.btnAssign.TabIndex = 36;
            this.btnAssign.Text = "Zuordnen";
            this.btnAssign.UseVisualStyleBackColor = false;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.txtDest);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(16, 388);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 57);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zuordnen";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.button6.BackgroundImage = global::zuordnung_test.Properties.Resources.search_worldwide;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(10, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(30, 23);
            this.button6.TabIndex = 7;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtDest
            // 
            this.txtDest.Depth = 0;
            this.txtDest.Hint = "";
            this.txtDest.Location = new System.Drawing.Point(46, 19);
            this.txtDest.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDest.Name = "txtDest";
            this.txtDest.PasswordChar = '\0';
            this.txtDest.SelectedText = "";
            this.txtDest.SelectionLength = 0;
            this.txtDest.SelectionStart = 0;
            this.txtDest.Size = new System.Drawing.Size(191, 23);
            this.txtDest.TabIndex = 8;
            this.txtDest.Text = "Quelle";
            this.txtDest.UseSystemPasswordChar = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(materialLabel7);
            this.groupBox1.Controls.Add(this.htPassUnix);
            this.groupBox1.Controls.Add(this.maid);
            this.groupBox1.Controls.Add(this.htPassSmb);
            this.groupBox1.Controls.Add(this.materialLabel6);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(16, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 209);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generieren";
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.White;
            this.name.Depth = 0;
            this.name.Hint = "";
            this.name.Location = new System.Drawing.Point(69, 164);
            this.name.MouseState = MaterialSkin.MouseState.HOVER;
            this.name.Name = "name";
            this.name.PasswordChar = '\0';
            this.name.SelectedText = "";
            this.name.SelectionLength = 0;
            this.name.SelectionStart = 0;
            this.name.Size = new System.Drawing.Size(162, 23);
            this.name.TabIndex = 11;
            this.name.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(62, 142);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(112, 19);
            this.materialLabel1.TabIndex = 15;
            this.materialLabel1.Text = "Nach, Vorname";
            // 
            // htPassUnix
            // 
            this.htPassUnix.BackColor = System.Drawing.Color.White;
            this.htPassUnix.Depth = 0;
            this.htPassUnix.Hint = "";
            this.htPassUnix.Location = new System.Drawing.Point(10, 105);
            this.htPassUnix.MouseState = MaterialSkin.MouseState.HOVER;
            this.htPassUnix.Name = "htPassUnix";
            this.htPassUnix.PasswordChar = '\0';
            this.htPassUnix.SelectedText = "";
            this.htPassUnix.SelectionLength = 0;
            this.htPassUnix.SelectionStart = 0;
            this.htPassUnix.Size = new System.Drawing.Size(221, 23);
            this.htPassUnix.TabIndex = 26;
            this.htPassUnix.Text = "/var/intranet/.htpasswd";
            this.htPassUnix.UseSystemPasswordChar = false;
            // 
            // maid
            // 
            this.maid.BackColor = System.Drawing.Color.White;
            this.maid.Depth = 0;
            this.maid.Hint = "";
            this.maid.Location = new System.Drawing.Point(10, 164);
            this.maid.MouseState = MaterialSkin.MouseState.HOVER;
            this.maid.Name = "maid";
            this.maid.PasswordChar = '\0';
            this.maid.SelectedText = "";
            this.maid.SelectionLength = 0;
            this.maid.SelectionStart = 0;
            this.maid.Size = new System.Drawing.Size(49, 23);
            this.maid.TabIndex = 12;
            this.maid.UseSystemPasswordChar = false;
            // 
            // htPassSmb
            // 
            this.htPassSmb.BackColor = System.Drawing.Color.White;
            this.htPassSmb.Depth = 0;
            this.htPassSmb.Hint = "";
            this.htPassSmb.Location = new System.Drawing.Point(46, 48);
            this.htPassSmb.MouseState = MaterialSkin.MouseState.HOVER;
            this.htPassSmb.Name = "htPassSmb";
            this.htPassSmb.PasswordChar = '\0';
            this.htPassSmb.SelectedText = "";
            this.htPassSmb.SelectionLength = 0;
            this.htPassSmb.SelectionStart = 0;
            this.htPassSmb.Size = new System.Drawing.Size(191, 23);
            this.htPassSmb.TabIndex = 24;
            this.htPassSmb.Text = "\\\\192.168.50.11\\intranet\\.htpasswd\"";
            this.htPassSmb.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(6, 26);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(111, 19);
            this.materialLabel6.TabIndex = 23;
            this.materialLabel6.Text = ".htpasswd Pfad";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(6, 142);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(50, 19);
            this.materialLabel3.TabIndex = 17;
            this.materialLabel3.Text = "MA-ID";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.button5.BackgroundImage = global::zuordnung_test.Properties.Resources.search_worldwide;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(10, 48);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(30, 23);
            this.button5.TabIndex = 22;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // btnGen
            // 
            this.btnGen.AutoSize = true;
            this.btnGen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGen.BackColor = System.Drawing.Color.White;
            this.btnGen.Depth = 0;
            this.btnGen.Location = new System.Drawing.Point(16, 343);
            this.btnGen.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGen.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGen.Name = "btnGen";
            this.btnGen.Primary = false;
            this.btnGen.Size = new System.Drawing.Size(93, 36);
            this.btnGen.TabIndex = 30;
            this.btnGen.Text = "Generieren";
            this.btnGen.UseVisualStyleBackColor = false;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(12, 74);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(157, 19);
            this.materialLabel5.TabIndex = 32;
            this.materialLabel5.Text = "Mitarbeiterverzeichnis";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.button4.BackgroundImage = global::zuordnung_test.Properties.Resources.search_worldwide;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(16, 96);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 23);
            this.button4.TabIndex = 31;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtRootPath
            // 
            this.txtRootPath.BackColor = System.Drawing.Color.White;
            this.txtRootPath.Cursor = System.Windows.Forms.Cursors.No;
            this.txtRootPath.Depth = 0;
            this.txtRootPath.Hint = "";
            this.txtRootPath.Location = new System.Drawing.Point(52, 96);
            this.txtRootPath.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRootPath.Name = "txtRootPath";
            this.txtRootPath.PasswordChar = '\0';
            this.txtRootPath.SelectedText = "";
            this.txtRootPath.SelectionLength = 0;
            this.txtRootPath.SelectionStart = 0;
            this.txtRootPath.Size = new System.Drawing.Size(191, 23);
            this.txtRootPath.TabIndex = 33;
            this.txtRootPath.UseSystemPasswordChar = false;
            // 
            // MVZAssigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 506);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtRootPath);
            this.Name = "MVZAssigner";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MVZAssigner";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private MaterialSkin.Controls.MaterialFlatButton btnAssign;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button6;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDest;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField name;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField htPassUnix;
        private MaterialSkin.Controls.MaterialSingleLineTextField maid;
        private MaterialSkin.Controls.MaterialSingleLineTextField htPassSmb;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.Button button5;
        private MaterialSkin.Controls.MaterialFlatButton btnGen;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.Button button4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRootPath;
    }
}

