
namespace PCalculadora
{
    partial class PrettyCalc97
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrettyCalc97));
            this.btnsoma = new System.Windows.Forms.Button();
            this.btnsub = new System.Windows.Forms.Button();
            this.btnmult = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.btnclean = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.txtn1 = new System.Windows.Forms.TextBox();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtn2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsoma
            // 
            this.btnsoma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnsoma.Location = new System.Drawing.Point(270, 69);
            this.btnsoma.Name = "btnsoma";
            this.btnsoma.Size = new System.Drawing.Size(75, 23);
            this.btnsoma.TabIndex = 0;
            this.btnsoma.Text = "+";
            this.btnsoma.UseVisualStyleBackColor = true;
            this.btnsoma.Click += new System.EventHandler(this.btnsoma_Click);
            // 
            // btnsub
            // 
            this.btnsub.Location = new System.Drawing.Point(270, 122);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(75, 23);
            this.btnsub.TabIndex = 1;
            this.btnsub.Text = "-";
            this.btnsub.UseVisualStyleBackColor = true;
            this.btnsub.Click += new System.EventHandler(this.btnsub_Click);
            // 
            // btnmult
            // 
            this.btnmult.Location = new System.Drawing.Point(270, 177);
            this.btnmult.Name = "btnmult";
            this.btnmult.Size = new System.Drawing.Size(75, 23);
            this.btnmult.TabIndex = 2;
            this.btnmult.Text = "x";
            this.btnmult.UseVisualStyleBackColor = true;
            this.btnmult.Click += new System.EventHandler(this.btnmult_Click);
            // 
            // btndiv
            // 
            this.btndiv.Location = new System.Drawing.Point(270, 233);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(75, 23);
            this.btndiv.TabIndex = 3;
            this.btndiv.Text = "/";
            this.btndiv.UseVisualStyleBackColor = true;
            this.btndiv.Click += new System.EventHandler(this.btndiv_Click);
            // 
            // btnclean
            // 
            this.btnclean.Location = new System.Drawing.Point(604, 122);
            this.btnclean.Name = "btnclean";
            this.btnclean.Size = new System.Drawing.Size(75, 23);
            this.btnclean.TabIndex = 4;
            this.btnclean.Text = "Clear";
            this.btnclean.UseVisualStyleBackColor = true;
            this.btnclean.Click += new System.EventHandler(this.btnclean_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(690, 400);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // txtn1
            // 
            this.txtn1.Location = new System.Drawing.Point(109, 69);
            this.txtn1.Name = "txtn1";
            this.txtn1.Size = new System.Drawing.Size(100, 20);
            this.txtn1.TabIndex = 6;
            // 
            // txtR
            // 
            this.txtR.Enabled = false;
            this.txtR.Location = new System.Drawing.Point(588, 69);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(100, 20);
            this.txtR.TabIndex = 7;
            // 
            // txtn2
            // 
            this.txtn2.Location = new System.Drawing.Point(412, 69);
            this.txtn2.Name = "txtn2";
            this.txtn2.Size = new System.Drawing.Size(100, 20);
            this.txtn2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(131, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Number 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(435, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Number 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(622, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Result";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(-2, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(293, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "𝒞𝓇𝑒𝒶𝓉𝑒𝒹 𝒷𝓎 𝒜𝓁𝓉_𝒳𝒾𝓇𝒾𝓈𝓉𝒾𝒶𝓃 𝒶𝓁𝓁 𝓇𝒾𝑔𝒽𝓉𝓈 𝓇𝑒𝓈𝑒𝓇𝓋𝑒𝒹" +
    " ©";
            // 
            // PrettyCalc97
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtn2);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.txtn1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclean);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.btnmult);
            this.Controls.Add(this.btnsub);
            this.Controls.Add(this.btnsoma);
            this.Name = "PrettyCalc97";
            this.Text = "𝙋𝙧𝙚𝙩𝙩𝙮 𝘾𝙖𝙡𝙘𝙪𝙡𝙖𝙩𝙤𝙧 \'97 （ぴーみ）";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsoma;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.Button btnmult;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Button btnclean;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.TextBox txtn1;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.TextBox txtn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

