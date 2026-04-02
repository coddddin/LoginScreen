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
            lblErrorMsg = new Label();
            lblID = new Label();
            lblPW = new Label();
            checkPW = new CheckBox();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.BackColor = Color.MintCream;
            lblAppName.Font = new Font("함초롬돋움", 48F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblAppName.Location = new Point(152, 22);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(199, 83);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Login";
            lblAppName.Click += lblLogin_Click;
            // 
            // txtID
            // 
            txtID.Font = new Font("맑은 고딕", 26.25F, FontStyle.Bold);
            txtID.ForeColor = Color.Silver;
            txtID.Location = new Point(64, 126);
            txtID.Name = "txtID";
            txtID.Size = new Size(372, 54);
            txtID.TabIndex = 2;
            txtID.Text = "아이디";
            txtID.TextChanged += textBox1_TextChanged;
            txtID.Enter += txtID_Enter;
            txtID.KeyDown += txtID_KeyDown;
            txtID.Leave += txtID_Leave;
            // 
            // txtPW
            // 
            txtPW.Font = new Font("맑은 고딕", 26.25F, FontStyle.Bold);
            txtPW.ForeColor = Color.Silver;
            txtPW.Location = new Point(64, 202);
            txtPW.Name = "txtPW";
            txtPW.Size = new Size(372, 54);
            txtPW.TabIndex = 3;
            txtPW.Text = "패스워드";
            txtPW.Enter += txtPW_Enter;
            txtPW.KeyDown += txtPW_KeyDown;
            txtPW.Leave += txtPW_Leave;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ActiveCaption;
            btnLogin.Font = new Font("굴림", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnLogin.Location = new Point(71, 309);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(359, 54);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblErrorMsg
            // 
            lblErrorMsg.AutoSize = true;
            lblErrorMsg.ForeColor = Color.Red;
            lblErrorMsg.Location = new Point(120, 284);
            lblErrorMsg.Name = "lblErrorMsg";
            lblErrorMsg.Size = new Size(254, 15);
            lblErrorMsg.TabIndex = 4;
            lblErrorMsg.Text = "아이디 또는 비밀번호가 잘못 입력되었습니다.";
            lblErrorMsg.Visible = false;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.ForeColor = Color.Gray;
            lblID.Location = new Point(65, 108);
            lblID.Name = "lblID";
            lblID.Size = new Size(19, 15);
            lblID.TabIndex = 5;
            lblID.Text = "ID\r\n";
            lblID.Click += lblID_Click;
            // 
            // lblPW
            // 
            lblPW.AutoSize = true;
            lblPW.ForeColor = Color.Gray;
            lblPW.Location = new Point(64, 184);
            lblPW.Name = "lblPW";
            lblPW.Size = new Size(25, 15);
            lblPW.TabIndex = 6;
            lblPW.Text = "PW";
            lblPW.Click += lblPW_Click;
            // 
            // checkPW
            // 
            checkPW.AutoSize = true;
            checkPW.Location = new Point(64, 262);
            checkPW.Name = "checkPW";
            checkPW.Size = new Size(183, 19);
            checkPW.TabIndex = 7;
            checkPW.Text = "숨겨진 비밀번호 보기/숨기기";
            checkPW.UseVisualStyleBackColor = true;
            checkPW.CheckedChanged += checkPW_CheckedChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(531, 413);
            Controls.Add(lblPW);
            Controls.Add(lblID);
            Controls.Add(lblErrorMsg);
            Controls.Add(btnLogin);
            Controls.Add(txtPW);
            Controls.Add(txtID);
            Controls.Add(lblAppName);
            Controls.Add(checkPW);
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
        private Label lblErrorMsg;
        private Label lblID;
        private Label lblPW;
        private CheckBox checkPW;
    }
}
