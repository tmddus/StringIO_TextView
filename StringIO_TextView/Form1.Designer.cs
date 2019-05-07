namespace StringIO_TextView
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtEdit = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(21, 58);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(297, 86);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "입력";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEdit
            // 
            this.txtEdit.AllowDrop = true;
            this.txtEdit.Location = new System.Drawing.Point(21, 12);
            this.txtEdit.Name = "txtEdit";
            this.txtEdit.Size = new System.Drawing.Size(297, 21);
            this.txtEdit.TabIndex = 1;
            this.txtEdit.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Gulim", 14F);
            this.lblResult.Location = new System.Drawing.Point(19, 162);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(65, 19);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "결과 : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 341);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtEdit);
            this.Controls.Add(this.btnEdit);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "문자입출력";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtEdit;
        private System.Windows.Forms.Label lblResult;
    }
}

