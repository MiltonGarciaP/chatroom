namespace RemotingClient
{
    partial class frmLogin
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnJoin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServerAdd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(168, 34);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(288, 22);
            this.txtName.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tu Usuario:";
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(464, 34);
            this.btnJoin.Margin = new System.Windows.Forms.Padding(4);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(100, 28);
            this.btnJoin.TabIndex = 12;
            this.btnJoin.Text = "Unirse";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Direcci?n del Servidor";
            // 
            // txtServerAdd
            // 
            this.txtServerAdd.Location = new System.Drawing.Point(168, 83);
            this.txtServerAdd.Margin = new System.Windows.Forms.Padding(4);
            this.txtServerAdd.Name = "txtServerAdd";
            this.txtServerAdd.Size = new System.Drawing.Size(396, 22);
            this.txtServerAdd.TabIndex = 13;
            this.txtServerAdd.Text = "tcp://localhost:8080/ChatRoom";
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnJoin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 146);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtServerAdd);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLogin";
            this.Text = "Sala de Chat LM2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServerAdd;
    }
}