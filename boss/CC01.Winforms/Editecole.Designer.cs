
namespace CC01.Winforms
{
    partial class Editecole
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textsearchecole = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oobservation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ecoleimage = new System.Windows.Forms.Button();
            this.ecolsupprim = new System.Windows.Forms.Button();
            this.ecolemodif = new System.Windows.Forms.Button();
            this.ecoleajout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(638, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 5);
            this.panel1.TabIndex = 19;
            // 
            // textsearchecole
            // 
            this.textsearchecole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textsearchecole.BackColor = System.Drawing.Color.Silver;
            this.textsearchecole.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textsearchecole.Location = new System.Drawing.Point(715, 105);
            this.textsearchecole.Name = "textsearchecole";
            this.textsearchecole.Size = new System.Drawing.Size(371, 34);
            this.textsearchecole.TabIndex = 18;
            this.textsearchecole.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.equipement,
            this.quantite,
            this.oobservation});
            this.dataGridView1.Location = new System.Drawing.Point(12, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1473, 455);
            this.dataGridView1.TabIndex = 16;
            // 
            // numero
            // 
            this.numero.HeaderText = "numero";
            this.numero.MinimumWidth = 6;
            this.numero.Name = "numero";
            this.numero.Width = 125;
            // 
            // equipement
            // 
            this.equipement.HeaderText = "materiels";
            this.equipement.MinimumWidth = 6;
            this.equipement.Name = "equipement";
            this.equipement.Width = 500;
            // 
            // quantite
            // 
            this.quantite.HeaderText = "quantite";
            this.quantite.MinimumWidth = 6;
            this.quantite.Name = "quantite";
            this.quantite.Width = 125;
            // 
            // oobservation
            // 
            this.oobservation.HeaderText = "observation";
            this.oobservation.MinimumWidth = 6;
            this.oobservation.Name = "oobservation";
            this.oobservation.Width = 700;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Blue;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(132, 162);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1211, 10);
            this.flowLayoutPanel2.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Blue;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(132, 63);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1211, 10);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // ecoleimage
            // 
            this.ecoleimage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ecoleimage.BackColor = System.Drawing.Color.Black;
            this.ecoleimage.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecoleimage.ForeColor = System.Drawing.Color.White;
            this.ecoleimage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ecoleimage.Location = new System.Drawing.Point(1054, 8);
            this.ecoleimage.Name = "ecoleimage";
            this.ecoleimage.Size = new System.Drawing.Size(244, 49);
            this.ecoleimage.TabIndex = 15;
            this.ecoleimage.Text = "Imprimer";
            this.ecoleimage.UseVisualStyleBackColor = false;
            // 
            // ecolsupprim
            // 
            this.ecolsupprim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ecolsupprim.BackColor = System.Drawing.Color.Black;
            this.ecolsupprim.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecolsupprim.ForeColor = System.Drawing.Color.White;
            this.ecolsupprim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ecolsupprim.Location = new System.Drawing.Point(773, 8);
            this.ecolsupprim.Name = "ecolsupprim";
            this.ecolsupprim.Size = new System.Drawing.Size(244, 49);
            this.ecolsupprim.TabIndex = 14;
            this.ecolsupprim.Text = "Supprimer";
            this.ecolsupprim.UseVisualStyleBackColor = false;
            // 
            // ecolemodif
            // 
            this.ecolemodif.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ecolemodif.BackColor = System.Drawing.Color.Black;
            this.ecolemodif.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecolemodif.ForeColor = System.Drawing.Color.White;
            this.ecolemodif.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ecolemodif.Location = new System.Drawing.Point(442, 8);
            this.ecolemodif.Name = "ecolemodif";
            this.ecolemodif.Size = new System.Drawing.Size(244, 49);
            this.ecolemodif.TabIndex = 13;
            this.ecolemodif.Text = "Modifier";
            this.ecolemodif.UseVisualStyleBackColor = false;
            // 
            // ecoleajout
            // 
            this.ecoleajout.BackColor = System.Drawing.Color.Black;
            this.ecoleajout.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecoleajout.ForeColor = System.Drawing.Color.White;
            this.ecoleajout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ecoleajout.Location = new System.Drawing.Point(132, 8);
            this.ecoleajout.Name = "ecoleajout";
            this.ecoleajout.Size = new System.Drawing.Size(244, 49);
            this.ecoleajout.TabIndex = 11;
            this.ecoleajout.Text = "Ajouter";
            this.ecoleajout.UseVisualStyleBackColor = false;
            this.ecoleajout.Click += new System.EventHandler(this.ecoleajout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(599, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "SEARCH";
            // 
            // Editecole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1497, 641);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textsearchecole);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ecoleimage);
            this.Controls.Add(this.ecolsupprim);
            this.Controls.Add(this.ecolemodif);
            this.Controls.Add(this.ecoleajout);
            this.Name = "Editecole";
            this.Text = "Editecole";
            this.Load += new System.EventHandler(this.Editecole_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textsearchecole;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipement;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn oobservation;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button ecoleimage;
        private System.Windows.Forms.Button ecolsupprim;
        private System.Windows.Forms.Button ecolemodif;
        private System.Windows.Forms.Button ecoleajout;
        private System.Windows.Forms.Label label1;
    }
}