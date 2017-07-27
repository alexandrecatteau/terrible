namespace CultureDetente
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.cmbAuteurs = new Alex.Controls._ComboBox();
            this.cmbTitres = new Alex.Controls._ComboBox();
            this.dgvLivreInfos = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivreInfos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbAuteurs
            // 
            this.cmbAuteurs.FormattingEnabled = true;
            this.cmbAuteurs.Location = new System.Drawing.Point(13, 13);
            this.cmbAuteurs.Name = "cmbAuteurs";
            this.cmbAuteurs.Size = new System.Drawing.Size(299, 26);
            this.cmbAuteurs.TabIndex = 0;
            // 
            // cmbTitres
            // 
            this.cmbTitres.FormattingEnabled = true;
            this.cmbTitres.Location = new System.Drawing.Point(318, 13);
            this.cmbTitres.Name = "cmbTitres";
            this.cmbTitres.Size = new System.Drawing.Size(299, 26);
            this.cmbTitres.TabIndex = 0;
            // 
            // dgvLivreInfos
            // 
            this.dgvLivreInfos.AllowUserToAddRows = false;
            this.dgvLivreInfos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLivreInfos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivreInfos.Location = new System.Drawing.Point(13, 51);
            this.dgvLivreInfos.Name = "dgvLivreInfos";
            this.dgvLivreInfos.Size = new System.Drawing.Size(1045, 431);
            this.dgvLivreInfos.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::CultureDetente.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(623, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 40);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1070, 494);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvLivreInfos);
            this.Controls.Add(this.cmbTitres);
            this.Controls.Add(this.cmbAuteurs);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivreInfos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Alex.Controls._ComboBox cmbAuteurs;
        private Alex.Controls._ComboBox cmbTitres;
        private System.Windows.Forms.DataGridView dgvLivreInfos;
        private System.Windows.Forms.Button btnSearch;
    }
}