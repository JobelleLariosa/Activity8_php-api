
namespace CsharpApi
{
    partial class customers
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Location = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.txtpayment = new System.Windows.Forms.TextBox();
            this.txtlocation = new System.Windows.Forms.TextBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.txtCusNum = new System.Windows.Forms.TextBox();
            this.txtCusname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(155, 240);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 28);
            this.button1.TabIndex = 17;
            this.button1.Text = "CLEAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(121, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Insert Customers";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(115, 175);
            this.txtemail.Margin = new System.Windows.Forms.Padding(2);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(267, 20);
            this.txtemail.TabIndex = 15;
            this.txtemail.TextChanged += new System.EventHandler(this.txtIsActive_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(69, 178);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(57, 154);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Payment: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Location
            // 
            this.Location.AutoSize = true;
            this.Location.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Location.Location = new System.Drawing.Point(57, 127);
            this.Location.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(54, 13);
            this.Location.TabIndex = 11;
            this.Location.Text = "Location: ";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(20, 17);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(2);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(364, 211);
            this.txtOutput.TabIndex = 4;
            // 
            // btnGet
            // 
            this.btnGet.BackColor = System.Drawing.Color.DarkGreen;
            this.btnGet.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGet.Location = new System.Drawing.Point(20, 232);
            this.btnGet.Margin = new System.Windows.Forms.Padding(2);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(363, 46);
            this.btnGet.TabIndex = 3;
            this.btnGet.Text = "GET";
            this.btnGet.UseVisualStyleBackColor = false;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // txtpayment
            // 
            this.txtpayment.Location = new System.Drawing.Point(115, 151);
            this.txtpayment.Margin = new System.Windows.Forms.Padding(2);
            this.txtpayment.Name = "txtpayment";
            this.txtpayment.Size = new System.Drawing.Size(267, 20);
            this.txtpayment.TabIndex = 8;
            // 
            // txtlocation
            // 
            this.txtlocation.Location = new System.Drawing.Point(115, 124);
            this.txtlocation.Margin = new System.Windows.Forms.Padding(2);
            this.txtlocation.Name = "txtlocation";
            this.txtlocation.Size = new System.Drawing.Size(267, 20);
            this.txtlocation.TabIndex = 7;
            // 
            // btnPost
            // 
            this.btnPost.BackColor = System.Drawing.Color.Teal;
            this.btnPost.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPost.Location = new System.Drawing.Point(155, 208);
            this.btnPost.Margin = new System.Windows.Forms.Padding(2);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(174, 28);
            this.btnPost.TabIndex = 6;
            this.btnPost.Text = "POST";
            this.btnPost.UseVisualStyleBackColor = false;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // txtCusNum
            // 
            this.txtCusNum.Location = new System.Drawing.Point(115, 100);
            this.txtCusNum.Margin = new System.Windows.Forms.Padding(2);
            this.txtCusNum.Name = "txtCusNum";
            this.txtCusNum.Size = new System.Drawing.Size(267, 20);
            this.txtCusNum.TabIndex = 5;
            // 
            // txtCusname
            // 
            this.txtCusname.Location = new System.Drawing.Point(115, 72);
            this.txtCusname.Margin = new System.Windows.Forms.Padding(2);
            this.txtCusname.Name = "txtCusname";
            this.txtCusname.Size = new System.Drawing.Size(267, 20);
            this.txtCusname.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(17, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Customer Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(16, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Name: ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Teal;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtemail);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Location);
            this.groupBox2.Controls.Add(this.txtpayment);
            this.groupBox2.Controls.Add(this.txtlocation);
            this.groupBox2.Controls.Add(this.btnPost);
            this.groupBox2.Controls.Add(this.txtCusNum);
            this.groupBox2.Controls.Add(this.txtCusname);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(402, 1);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(402, 284);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.ForestGreen;
            this.groupBox1.Controls.Add(this.txtOutput);
            this.groupBox1.Controls.Add(this.btnGet);
            this.groupBox1.Location = new System.Drawing.Point(-5, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(403, 285);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.ForestGreen;
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(402, 295);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "CREDENTIALS";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(239, 296);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "CUSTOMERS";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 324);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "customers";
            this.Text = "customers";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Location;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.TextBox txtpayment;
        private System.Windows.Forms.TextBox txtlocation;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.TextBox txtCusNum;
        private System.Windows.Forms.TextBox txtCusname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}