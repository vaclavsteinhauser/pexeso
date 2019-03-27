namespace pexeso
{
    partial class Dotaz
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.paircount = new System.Windows.Forms.NumericUpDown();
            this.ImgTypes = new System.Windows.Forms.NumericUpDown();
            this.done = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paircount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.paircount);
            this.groupBox1.Controls.Add(this.ImgTypes);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametry";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Počet párů každého obrázku";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Počet druhů obrázků";
            // 
            // paircount
            // 
            this.paircount.AutoSize = true;
            this.paircount.Location = new System.Drawing.Point(321, 57);
            this.paircount.Name = "paircount";
            this.paircount.Size = new System.Drawing.Size(120, 26);
            this.paircount.TabIndex = 1;
            this.paircount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ImgTypes
            // 
            this.ImgTypes.AutoSize = true;
            this.ImgTypes.Location = new System.Drawing.Point(321, 23);
            this.ImgTypes.Name = "ImgTypes";
            this.ImgTypes.Size = new System.Drawing.Size(120, 26);
            this.ImgTypes.TabIndex = 0;
            this.ImgTypes.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // done
            // 
            this.done.Location = new System.Drawing.Point(413, 106);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(75, 33);
            this.done.TabIndex = 1;
            this.done.Text = "Hotovo";
            this.done.UseVisualStyleBackColor = true;
            this.done.Click += new System.EventHandler(this.Done_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(321, 106);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 33);
            this.reset.TabIndex = 2;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // dotaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(501, 144);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.done);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "dotaz";
            this.Text = "Pexeso";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Dotaz_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paircount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgTypes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown paircount;
        private System.Windows.Forms.NumericUpDown ImgTypes;
        private System.Windows.Forms.Button done;
        private System.Windows.Forms.Button reset;
    }
}