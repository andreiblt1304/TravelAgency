
namespace ProiectAgentieTurism_BaltariuAndrei
{
    partial class meniuClient
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
            this.lbRezultatOras = new System.Windows.Forms.ListBox();
            this.btRefresh = new System.Windows.Forms.Button();
            this.btArataTot = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.rdRating = new System.Windows.Forms.RadioButton();
            this.rdTipCladire = new System.Windows.Forms.RadioButton();
            this.btCautaOras = new System.Windows.Forms.Button();
            this.txCautaOras = new System.Windows.Forms.TextBox();
            this.lblCautaSpecific = new System.Windows.Forms.Label();
            this.rdAllInclusive = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lbRezultatOras
            // 
            this.lbRezultatOras.FormattingEnabled = true;
            this.lbRezultatOras.Location = new System.Drawing.Point(58, 137);
            this.lbRezultatOras.Name = "lbRezultatOras";
            this.lbRezultatOras.Size = new System.Drawing.Size(689, 264);
            this.lbRezultatOras.TabIndex = 3;
            this.lbRezultatOras.SelectedIndexChanged += new System.EventHandler(this.lbRezultatOras_SelectedIndexChanged);
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point(678, 63);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(105, 23);
            this.btRefresh.TabIndex = 8;
            this.btRefresh.Text = "Refresh Lista";
            this.btRefresh.UseVisualStyleBackColor = true;
            // 
            // btArataTot
            // 
            this.btArataTot.Location = new System.Drawing.Point(692, 12);
            this.btArataTot.Name = "btArataTot";
            this.btArataTot.Size = new System.Drawing.Size(75, 45);
            this.btArataTot.TabIndex = 7;
            this.btArataTot.Text = "Arata Tot";
            this.btArataTot.UseVisualStyleBackColor = true;
            this.btArataTot.Click += new System.EventHandler(this.btArataTot_Click_1);
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(698, 407);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(90, 31);
            this.btBack.TabIndex = 11;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click_1);
            // 
            // rdRating
            // 
            this.rdRating.AutoSize = true;
            this.rdRating.Location = new System.Drawing.Point(226, 31);
            this.rdRating.Name = "rdRating";
            this.rdRating.Size = new System.Drawing.Size(56, 17);
            this.rdRating.TabIndex = 16;
            this.rdRating.Text = "Rating";
            this.rdRating.UseVisualStyleBackColor = true;
            // 
            // rdTipCladire
            // 
            this.rdTipCladire.AutoSize = true;
            this.rdTipCladire.Location = new System.Drawing.Point(163, 31);
            this.rdTipCladire.Name = "rdTipCladire";
            this.rdTipCladire.Size = new System.Drawing.Size(57, 17);
            this.rdTipCladire.TabIndex = 15;
            this.rdTipCladire.Text = "Cladire";
            this.rdTipCladire.UseVisualStyleBackColor = true;
            // 
            // btCautaOras
            // 
            this.btCautaOras.Location = new System.Drawing.Point(58, 79);
            this.btCautaOras.Name = "btCautaOras";
            this.btCautaOras.Size = new System.Drawing.Size(75, 23);
            this.btCautaOras.TabIndex = 14;
            this.btCautaOras.Text = "Cauta";
            this.btCautaOras.UseVisualStyleBackColor = true;
            this.btCautaOras.Click += new System.EventHandler(this.btCautaOras_Click_1);
            // 
            // txCautaOras
            // 
            this.txCautaOras.Location = new System.Drawing.Point(57, 53);
            this.txCautaOras.Name = "txCautaOras";
            this.txCautaOras.Size = new System.Drawing.Size(100, 20);
            this.txCautaOras.TabIndex = 13;
            // 
            // lblCautaSpecific
            // 
            this.lblCautaSpecific.AutoSize = true;
            this.lblCautaSpecific.Location = new System.Drawing.Point(55, 33);
            this.lblCautaSpecific.Name = "lblCautaSpecific";
            this.lblCautaSpecific.Size = new System.Drawing.Size(102, 13);
            this.lblCautaSpecific.TabIndex = 12;
            this.lblCautaSpecific.Text = "Cauta in functie de :";
            // 
            // rdAllInclusive
            // 
            this.rdAllInclusive.AutoSize = true;
            this.rdAllInclusive.Location = new System.Drawing.Point(288, 31);
            this.rdAllInclusive.Name = "rdAllInclusive";
            this.rdAllInclusive.Size = new System.Drawing.Size(81, 17);
            this.rdAllInclusive.TabIndex = 17;
            this.rdAllInclusive.Text = "All Inclusive";
            this.rdAllInclusive.UseVisualStyleBackColor = true;
            // 
            // meniuClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdAllInclusive);
            this.Controls.Add(this.rdRating);
            this.Controls.Add(this.rdTipCladire);
            this.Controls.Add(this.btCautaOras);
            this.Controls.Add(this.txCautaOras);
            this.Controls.Add(this.lblCautaSpecific);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.btArataTot);
            this.Controls.Add(this.lbRezultatOras);
            this.Name = "meniuClient";
            this.Text = "meniulClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbRezultatOras;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Button btArataTot;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.RadioButton rdRating;
        private System.Windows.Forms.RadioButton rdTipCladire;
        private System.Windows.Forms.Button btCautaOras;
        private System.Windows.Forms.TextBox txCautaOras;
        private System.Windows.Forms.Label lblCautaSpecific;
        private System.Windows.Forms.RadioButton rdAllInclusive;
    }
}