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
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.BackColor = Color.WhiteSmoke;
            lblAppName.BorderStyle = BorderStyle.FixedSingle;
            lblAppName.Font = new Font("함초롬돋움", 35.9999962F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 129);
            lblAppName.Location = new Point(-1, -4);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(587, 64);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "    Login                           ";
            lblAppName.Click += lblLogin_Click;
            // 
            // txtID
            // 
            txtID.Font = new Font("맑은 고딕", 18F, FontStyle.Bold);
            txtID.ForeColor = SystemColors.ScrollBar;
            txtID.Location = new Point(69, 126);
            txtID.Name = "txtID";
            txtID.Size = new Size(372, 39);
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
            txtPW.Location = new Point(70, 196);
            txtPW.Name = "txtPW";
            txtPW.Size = new Size(372, 39);
            txtPW.TabIndex = 2;
            txtPW.Text = "비밀번호";
            
            txtPW.Enter += txtPW_Enter;
            txtPW.Leave += txtPW_Leave;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ActiveCaption;
            btnLogin.Font = new Font("굴림", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnLogin.Location = new Point(73, 282);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(359, 54);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblErrorMsg
            // 
            lblErrorMsg.AutoSize = true;
            lblErrorMsg.ForeColor = Color.Red;
            lblErrorMsg.Location = new Point(72, 253);
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
            lblID.Location = new Point(69, 108);
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
            lblPW.Location = new Point(68, 178);
            lblPW.Name = "lblPW";
            lblPW.Size = new Size(25, 15);
            lblPW.TabIndex = 6;
            lblPW.Text = "PW";
            lblPW.Click += lblPW_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(534, 413);
            Controls.Add(lblPW);
            Controls.Add(lblID);
            Controls.Add(lblErrorMsg);
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
        private Label lblErrorMsg;
        private Label lblID;
        private Label lblPW;
    }
}
