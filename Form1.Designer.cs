namespace LoginScreen
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAppName = new Label();
            txtID = new TextBox();
            txtPW = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("휴먼둥근헤드라인", 36F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblAppName.Location = new Point(213, 57);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(181, 50);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Login";
            lblAppName.Click += lblLogin_Click;
            // 
            // txtID
            // 
            txtID.Font = new Font("맑은 고딕", 18F, FontStyle.Bold);
            txtID.ForeColor = SystemColors.ScrollBar;
            txtID.Location = new Point(113, 173);
            txtID.Name = "txtID";
            txtID.Size = new Size(373, 39);
            txtID.TabIndex = 1;
            txtID.Text = "아이디";
            txtID.TextChanged += textBox1_TextChanged;
            txtID.Enter += txtID_Enter;
            txtID.Leave += txtID_Leave;
            // 
            // txtPW
            // 
            txtPW.Font = new Font("맑은 고딕", 18F, FontStyle.Bold);
            txtPW.ForeColor = SystemColors.ScrollBar;
            txtPW.Location = new Point(113, 242);
            txtPW.Name = "txtPW";
            txtPW.Size = new Size(373, 39);
            txtPW.TabIndex = 2;
            txtPW.Text = "비밀번호";
            txtPW.Enter += txtPW_Enter;
            txtPW.Leave += txtPW_Leave;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ActiveCaption;
            btnLogin.Font = new Font("굴림", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnLogin.Location = new Point(240, 322);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(122, 54);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(614, 442);
            Controls.Add(btnLogin);
            Controls.Add(txtPW);
            Controls.Add(txtID);
            Controls.Add(lblAppName);
            ForeColor = SystemColors.ControlText;
            Name = "MainForm";
            Text = "Login Screen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private TextBox txtID;
        private TextBox txtPW;
        private Button btnLogin;
    }
}
