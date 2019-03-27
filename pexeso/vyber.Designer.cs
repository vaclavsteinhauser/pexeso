namespace pexeso
{
    partial class Vyber
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
            this.OknoVyberuObrazku = new System.Windows.Forms.OpenFileDialog();
            this.tabulka = new System.Windows.Forms.TableLayoutPanel();
            this.OknoVyberuRubu = new System.Windows.Forms.OpenFileDialog();
            this.OknoVyberJeden = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // OknoVyberuObrazku
            // 
            this.OknoVyberuObrazku.FileName = "OknoVyberuObrazku";
            this.OknoVyberuObrazku.Multiselect = true;
            // 
            // tabulka
            // 
            this.tabulka.AutoSize = true;
            this.tabulka.ColumnCount = 2;
            this.tabulka.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tabulka.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tabulka.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tabulka.Location = new System.Drawing.Point(0, 0);
            this.tabulka.Name = "tabulka";
            this.tabulka.RowCount = 3;
            this.tabulka.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tabulka.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tabulka.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabulka.Size = new System.Drawing.Size(400, 350);
            this.tabulka.TabIndex = 0;
            // 
            // OknoVyberuRubu
            // 
            this.OknoVyberuRubu.FileName = "OknoVyberuRubu";
            // 
            // OknoVyberJeden
            // 
            this.OknoVyberJeden.FileName = "OknoVyberJeden";
            // 
            // Vyber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabulka);
            this.Name = "Vyber";
            this.Text = "vyber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OknoVyberuObrazku;
        private System.Windows.Forms.TableLayoutPanel tabulka;
        private System.Windows.Forms.OpenFileDialog OknoVyberuRubu;
        private System.Windows.Forms.OpenFileDialog OknoVyberJeden;
    }
}