namespace Market
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_puldaxiledin = new System.Windows.Forms.Label();
            this.btn_10q = new System.Windows.Forms.Button();
            this.btn_20q = new System.Windows.Forms.Button();
            this.btn_50q = new System.Windows.Forms.Button();
            this.btn_1m = new System.Windows.Forms.Button();
            this.btn_5m = new System.Windows.Forms.Button();
            this.btn_10m = new System.Windows.Forms.Button();
            this.lbl_money = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_qaliq = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_almaq = new System.Windows.Forms.Button();
            this.button_cola = new System.Windows.Forms.Button();
            this.button_pepsi = new System.Windows.Forms.Button();
            this.button_fanta = new System.Windows.Forms.Button();
            this.button_tutku = new System.Windows.Forms.Button();
            this.button_mars = new System.Windows.Forms.Button();
            this.button_bounty = new System.Windows.Forms.Button();
            this.button_icetea = new System.Windows.Forms.Button();
            this.button_snickers = new System.Windows.Forms.Button();
            this.button_albeni = new System.Windows.Forms.Button();
            this.uc_bounty = new Market.FoodUC();
            this.uc_albeni = new Market.FoodUC();
            this.uc_fanta = new Market.FoodUC();
            this.uc_mars = new Market.FoodUC();
            this.uc_snickers = new Market.FoodUC();
            this.uc_pepsi = new Market.FoodUC();
            this.uc_tutku = new Market.FoodUC();
            this.uc_icetea = new Market.FoodUC();
            this.uc_cola = new Market.FoodUC();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(852, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 27);
            this.label1.TabIndex = 8;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_puldaxiledin
            // 
            this.lbl_puldaxiledin.AutoSize = true;
            this.lbl_puldaxiledin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_puldaxiledin.Location = new System.Drawing.Point(973, 21);
            this.lbl_puldaxiledin.Name = "lbl_puldaxiledin";
            this.lbl_puldaxiledin.Size = new System.Drawing.Size(144, 27);
            this.lbl_puldaxiledin.TabIndex = 9;
            this.lbl_puldaxiledin.Text = "Pul daxil edin";
            this.lbl_puldaxiledin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_10q
            // 
            this.btn_10q.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_10q.Location = new System.Drawing.Point(879, 141);
            this.btn_10q.Name = "btn_10q";
            this.btn_10q.Size = new System.Drawing.Size(88, 84);
            this.btn_10q.TabIndex = 10;
            this.btn_10q.Text = "10 qəpik";
            this.btn_10q.UseVisualStyleBackColor = true;
            this.btn_10q.Click += new System.EventHandler(this.btn_pul_Click);
            // 
            // btn_20q
            // 
            this.btn_20q.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_20q.Location = new System.Drawing.Point(1003, 141);
            this.btn_20q.Name = "btn_20q";
            this.btn_20q.Size = new System.Drawing.Size(88, 84);
            this.btn_20q.TabIndex = 11;
            this.btn_20q.Text = "20 qəpik";
            this.btn_20q.UseVisualStyleBackColor = true;
            this.btn_20q.Click += new System.EventHandler(this.btn_pul_Click);
            // 
            // btn_50q
            // 
            this.btn_50q.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_50q.Location = new System.Drawing.Point(1120, 141);
            this.btn_50q.Name = "btn_50q";
            this.btn_50q.Size = new System.Drawing.Size(88, 84);
            this.btn_50q.TabIndex = 12;
            this.btn_50q.Text = "50 qəpik";
            this.btn_50q.UseVisualStyleBackColor = true;
            this.btn_50q.Click += new System.EventHandler(this.btn_pul_Click);
            // 
            // btn_1m
            // 
            this.btn_1m.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_1m.Location = new System.Drawing.Point(879, 233);
            this.btn_1m.Name = "btn_1m";
            this.btn_1m.Size = new System.Drawing.Size(88, 84);
            this.btn_1m.TabIndex = 13;
            this.btn_1m.Text = "1 manat";
            this.btn_1m.UseVisualStyleBackColor = true;
            this.btn_1m.Click += new System.EventHandler(this.btn_pul_Click);
            // 
            // btn_5m
            // 
            this.btn_5m.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_5m.Location = new System.Drawing.Point(1003, 233);
            this.btn_5m.Name = "btn_5m";
            this.btn_5m.Size = new System.Drawing.Size(88, 84);
            this.btn_5m.TabIndex = 14;
            this.btn_5m.Text = "5 manat";
            this.btn_5m.UseVisualStyleBackColor = true;
            this.btn_5m.Click += new System.EventHandler(this.btn_pul_Click);
            // 
            // btn_10m
            // 
            this.btn_10m.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_10m.Location = new System.Drawing.Point(1120, 233);
            this.btn_10m.Name = "btn_10m";
            this.btn_10m.Size = new System.Drawing.Size(88, 84);
            this.btn_10m.TabIndex = 15;
            this.btn_10m.Text = "10 manat";
            this.btn_10m.UseVisualStyleBackColor = true;
            this.btn_10m.Click += new System.EventHandler(this.btn_pul_Click);
            // 
            // lbl_money
            // 
            this.lbl_money.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_money.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_money.Location = new System.Drawing.Point(1089, 402);
            this.lbl_money.Name = "lbl_money";
            this.lbl_money.Size = new System.Drawing.Size(157, 39);
            this.lbl_money.TabIndex = 16;
            this.lbl_money.Text = "0";
            this.lbl_money.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_total
            // 
            this.lbl_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_total.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_total.Location = new System.Drawing.Point(1089, 454);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(157, 39);
            this.lbl_total.TabIndex = 17;
            this.lbl_total.Text = "0";
            this.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_qaliq
            // 
            this.lbl_qaliq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_qaliq.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_qaliq.Location = new System.Drawing.Point(1089, 504);
            this.lbl_qaliq.Name = "lbl_qaliq";
            this.lbl_qaliq.Size = new System.Drawing.Size(157, 39);
            this.lbl_qaliq.TabIndex = 18;
            this.lbl_qaliq.Text = "0";
            this.lbl_qaliq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(837, 504);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 39);
            this.label5.TabIndex = 19;
            this.label5.Text = "Qalıq məbləğ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(837, 454);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 39);
            this.label6.TabIndex = 20;
            this.label6.Text = "Yekun məbləğ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(787, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(255, 39);
            this.label7.TabIndex = 21;
            this.label7.Text = "Daxil olunmuş məbləğ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_almaq
            // 
            this.btn_almaq.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_almaq.Location = new System.Drawing.Point(927, 579);
            this.btn_almaq.Name = "btn_almaq";
            this.btn_almaq.Size = new System.Drawing.Size(148, 62);
            this.btn_almaq.TabIndex = 22;
            this.btn_almaq.Text = "Almaq";
            this.btn_almaq.UseVisualStyleBackColor = true;
            this.btn_almaq.Click += new System.EventHandler(this.btn_almaq_Click);
            // 
            // button_cola
            // 
            this.button_cola.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_cola.Location = new System.Drawing.Point(39, 180);
            this.button_cola.Name = "button_cola";
            this.button_cola.Size = new System.Drawing.Size(142, 47);
            this.button_cola.TabIndex = 26;
            this.button_cola.Text = "Seç";
            this.button_cola.UseVisualStyleBackColor = true;
            this.button_cola.Click += new System.EventHandler(this.seç_Click);
            // 
            // button_pepsi
            // 
            this.button_pepsi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_pepsi.Location = new System.Drawing.Point(240, 180);
            this.button_pepsi.Name = "button_pepsi";
            this.button_pepsi.Size = new System.Drawing.Size(142, 47);
            this.button_pepsi.TabIndex = 27;
            this.button_pepsi.Text = "Seç";
            this.button_pepsi.UseVisualStyleBackColor = true;
            this.button_pepsi.Click += new System.EventHandler(this.seç_Click);
            // 
            // button_fanta
            // 
            this.button_fanta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_fanta.Location = new System.Drawing.Point(445, 180);
            this.button_fanta.Name = "button_fanta";
            this.button_fanta.Size = new System.Drawing.Size(142, 47);
            this.button_fanta.TabIndex = 28;
            this.button_fanta.Text = "Seç";
            this.button_fanta.UseVisualStyleBackColor = true;
            this.button_fanta.Click += new System.EventHandler(this.seç_Click);
            // 
            // button_tutku
            // 
            this.button_tutku.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_tutku.Location = new System.Drawing.Point(39, 672);
            this.button_tutku.Name = "button_tutku";
            this.button_tutku.Size = new System.Drawing.Size(142, 47);
            this.button_tutku.TabIndex = 26;
            this.button_tutku.Text = "Seç";
            this.button_tutku.UseVisualStyleBackColor = true;
            this.button_tutku.Click += new System.EventHandler(this.seç_Click);
            // 
            // button_mars
            // 
            this.button_mars.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_mars.Location = new System.Drawing.Point(240, 672);
            this.button_mars.Name = "button_mars";
            this.button_mars.Size = new System.Drawing.Size(142, 47);
            this.button_mars.TabIndex = 27;
            this.button_mars.Text = "Seç";
            this.button_mars.UseVisualStyleBackColor = true;
            this.button_mars.Click += new System.EventHandler(this.seç_Click);
            // 
            // button_bounty
            // 
            this.button_bounty.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_bounty.Location = new System.Drawing.Point(445, 672);
            this.button_bounty.Name = "button_bounty";
            this.button_bounty.Size = new System.Drawing.Size(142, 47);
            this.button_bounty.TabIndex = 28;
            this.button_bounty.Text = "Seç";
            this.button_bounty.UseVisualStyleBackColor = true;
            this.button_bounty.Click += new System.EventHandler(this.seç_Click);
            // 
            // button_icetea
            // 
            this.button_icetea.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_icetea.Location = new System.Drawing.Point(39, 416);
            this.button_icetea.Name = "button_icetea";
            this.button_icetea.Size = new System.Drawing.Size(142, 47);
            this.button_icetea.TabIndex = 26;
            this.button_icetea.Text = "Seç";
            this.button_icetea.UseVisualStyleBackColor = true;
            this.button_icetea.Click += new System.EventHandler(this.seç_Click);
            // 
            // button_snickers
            // 
            this.button_snickers.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_snickers.Location = new System.Drawing.Point(240, 416);
            this.button_snickers.Name = "button_snickers";
            this.button_snickers.Size = new System.Drawing.Size(142, 47);
            this.button_snickers.TabIndex = 27;
            this.button_snickers.Text = "Seç";
            this.button_snickers.UseVisualStyleBackColor = true;
            this.button_snickers.Click += new System.EventHandler(this.seç_Click);
            // 
            // button_albeni
            // 
            this.button_albeni.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_albeni.Location = new System.Drawing.Point(445, 416);
            this.button_albeni.Name = "button_albeni";
            this.button_albeni.Size = new System.Drawing.Size(142, 47);
            this.button_albeni.TabIndex = 28;
            this.button_albeni.Text = "Seç";
            this.button_albeni.UseVisualStyleBackColor = true;
            this.button_albeni.Click += new System.EventHandler(this.seç_Click);
            // 
            // uc_bounty
            // 
            this.uc_bounty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_bounty.Location = new System.Drawing.Point(409, 504);
            this.uc_bounty.Name = "uc_bounty";
            this.uc_bounty.Size = new System.Drawing.Size(193, 162);
            this.uc_bounty.TabIndex = 25;
            // 
            // uc_albeni
            // 
            this.uc_albeni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_albeni.Location = new System.Drawing.Point(409, 248);
            this.uc_albeni.Name = "uc_albeni";
            this.uc_albeni.Size = new System.Drawing.Size(193, 162);
            this.uc_albeni.TabIndex = 25;
            // 
            // uc_fanta
            // 
            this.uc_fanta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_fanta.Location = new System.Drawing.Point(409, 12);
            this.uc_fanta.Name = "uc_fanta";
            this.uc_fanta.Size = new System.Drawing.Size(193, 162);
            this.uc_fanta.TabIndex = 25;
            // 
            // uc_mars
            // 
            this.uc_mars.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_mars.Location = new System.Drawing.Point(210, 504);
            this.uc_mars.Name = "uc_mars";
            this.uc_mars.Size = new System.Drawing.Size(193, 162);
            this.uc_mars.TabIndex = 24;
            // 
            // uc_snickers
            // 
            this.uc_snickers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_snickers.Location = new System.Drawing.Point(210, 248);
            this.uc_snickers.Name = "uc_snickers";
            this.uc_snickers.Size = new System.Drawing.Size(193, 162);
            this.uc_snickers.TabIndex = 24;
            // 
            // uc_pepsi
            // 
            this.uc_pepsi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_pepsi.Location = new System.Drawing.Point(210, 12);
            this.uc_pepsi.Name = "uc_pepsi";
            this.uc_pepsi.Size = new System.Drawing.Size(193, 162);
            this.uc_pepsi.TabIndex = 24;
            // 
            // uc_tutku
            // 
            this.uc_tutku.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_tutku.Location = new System.Drawing.Point(12, 504);
            this.uc_tutku.Name = "uc_tutku";
            this.uc_tutku.Size = new System.Drawing.Size(193, 162);
            this.uc_tutku.TabIndex = 23;
            // 
            // uc_icetea
            // 
            this.uc_icetea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_icetea.Location = new System.Drawing.Point(12, 248);
            this.uc_icetea.Name = "uc_icetea";
            this.uc_icetea.Size = new System.Drawing.Size(193, 162);
            this.uc_icetea.TabIndex = 23;
            // 
            // uc_cola
            // 
            this.uc_cola.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_cola.Location = new System.Drawing.Point(12, 12);
            this.uc_cola.Name = "uc_cola";
            this.uc_cola.Size = new System.Drawing.Size(193, 162);
            this.uc_cola.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 737);
            this.Controls.Add(this.button_albeni);
            this.Controls.Add(this.button_bounty);
            this.Controls.Add(this.button_fanta);
            this.Controls.Add(this.button_snickers);
            this.Controls.Add(this.button_mars);
            this.Controls.Add(this.button_pepsi);
            this.Controls.Add(this.button_icetea);
            this.Controls.Add(this.button_tutku);
            this.Controls.Add(this.button_cola);
            this.Controls.Add(this.uc_bounty);
            this.Controls.Add(this.uc_albeni);
            this.Controls.Add(this.uc_fanta);
            this.Controls.Add(this.uc_mars);
            this.Controls.Add(this.uc_snickers);
            this.Controls.Add(this.uc_pepsi);
            this.Controls.Add(this.uc_tutku);
            this.Controls.Add(this.uc_icetea);
            this.Controls.Add(this.uc_cola);
            this.Controls.Add(this.btn_almaq);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_qaliq);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_money);
            this.Controls.Add(this.btn_10m);
            this.Controls.Add(this.btn_5m);
            this.Controls.Add(this.btn_1m);
            this.Controls.Add(this.btn_50q);
            this.Controls.Add(this.btn_20q);
            this.Controls.Add(this.btn_10q);
            this.Controls.Add(this.lbl_puldaxiledin);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Seç";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_puldaxiledin;
        private System.Windows.Forms.Button btn_10q;
        private System.Windows.Forms.Button btn_20q;
        private System.Windows.Forms.Button btn_50q;
        private System.Windows.Forms.Button btn_1m;
        private System.Windows.Forms.Button btn_5m;
        private System.Windows.Forms.Button btn_10m;
        private System.Windows.Forms.Label lbl_money;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_qaliq;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_almaq;
        private FoodUC uc_cola;
        private FoodUC uc_pepsi;
        private FoodUC uc_fanta;
        private FoodUC uc_icetea;
        private FoodUC uc_snickers;
        private FoodUC uc_albeni;
        private FoodUC uc_tutku;
        private FoodUC uc_mars;
        private FoodUC uc_bounty;
        private System.Windows.Forms.Button button_cola;
        private System.Windows.Forms.Button button_pepsi;
        private System.Windows.Forms.Button button_fanta;
        private System.Windows.Forms.Button button_tutku;
        private System.Windows.Forms.Button button_mars;
        private System.Windows.Forms.Button button_bounty;
        private System.Windows.Forms.Button button_icetea;
        private System.Windows.Forms.Button button_snickers;
        private System.Windows.Forms.Button button_albeni;
    }
}

