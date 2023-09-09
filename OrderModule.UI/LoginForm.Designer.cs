namespace OrderModule.UI
{
    partial class LoginForm
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
            this.screenLogin1 = new LoginScreen.ScreenLogin();
            this.SuspendLayout();
            // 
            // screenLogin1
            // 
            this.screenLogin1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.screenLogin1.Location = new System.Drawing.Point(13, 13);
            this.screenLogin1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.screenLogin1.Name = "screenLogin1";
            this.screenLogin1.Size = new System.Drawing.Size(339, 209);
            this.screenLogin1.TabIndex = 0;
            this.screenLogin1.Title = null;
            this.screenLogin1.OnChangeLoginType += new LoginScreen.RxOnChangeLoginType(this.screenLogin1_OnChangeLoginType);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 242);
            this.Controls.Add(this.screenLogin1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);

        }

        #endregion

        private LoginScreen.ScreenLogin screenLogin1;
    }
}