
namespace MainForm
{
    partial class ChangeAccount
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserChange = new System.Windows.Forms.TextBox();
            this.txtPasswordChange = new System.Windows.Forms.TextBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Role:";
            // 
            // txtUserChange
            // 
            this.txtUserChange.Location = new System.Drawing.Point(155, 54);
            this.txtUserChange.Name = "txtUserChange";
            this.txtUserChange.Size = new System.Drawing.Size(262, 22);
            this.txtUserChange.TabIndex = 3;
            // 
            // txtPasswordChange
            // 
            this.txtPasswordChange.Location = new System.Drawing.Point(155, 132);
            this.txtPasswordChange.Name = "txtPasswordChange";
            this.txtPasswordChange.PasswordChar = '*';
            this.txtPasswordChange.Size = new System.Drawing.Size(262, 22);
            this.txtPasswordChange.TabIndex = 4;
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(155, 203);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(262, 22);
            this.txtRole.TabIndex = 5;
            // 
            // btnChange
            // 
            this.btnChange.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnChange.Location = new System.Drawing.Point(218, 274);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(122, 23);
            this.btnChange.TabIndex = 6;
            this.btnChange.Text = "ChangeAccount";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // ChangeAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.txtPasswordChange);
            this.Controls.Add(this.txtUserChange);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangeAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChangeAccount";
            this.Load += new System.EventHandler(this.ChangeAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserChange;
        private System.Windows.Forms.TextBox txtPasswordChange;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Button btnChange;
    }
}