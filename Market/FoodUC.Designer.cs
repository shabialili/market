namespace Market
{
    partial class FoodUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_q = new System.Windows.Forms.Label();
            this.lbl_say = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_name.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_name.Location = new System.Drawing.Point(60, 15);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(48, 34);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "lbl";
            // 
            // lbl_q
            // 
            this.lbl_q.AutoSize = true;
            this.lbl_q.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_q.Location = new System.Drawing.Point(60, 112);
            this.lbl_q.Name = "lbl_q";
            this.lbl_q.Size = new System.Drawing.Size(53, 22);
            this.lbl_q.TabIndex = 1;
            this.lbl_q.Text = "label1";
            // 
            // lbl_say
            // 
            this.lbl_say.AutoSize = true;
            this.lbl_say.Location = new System.Drawing.Point(62, 67);
            this.lbl_say.Name = "lbl_say";
            this.lbl_say.Size = new System.Drawing.Size(51, 20);
            this.lbl_say.TabIndex = 2;
            this.lbl_say.Text = "label1";
            // 
            // FoodUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_say);
            this.Controls.Add(this.lbl_q);
            this.Controls.Add(this.lbl_name);
            this.Name = "FoodUC";
            this.Size = new System.Drawing.Size(178, 183);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_name;
        public System.Windows.Forms.Label lbl_q;
        public System.Windows.Forms.Label lbl_say;
    }
}
