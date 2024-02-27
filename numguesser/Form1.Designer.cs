namespace numguesser
{
    partial class Form1
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
            lblMessage = new Label();
            btneasy = new RadioButton();
            btnmedium = new RadioButton();
            btnhard = new RadioButton();
            btnstart = new Button();
            txtguess = new TextBox();
            lblguess = new Label();
            btnguess = new Button();
            btnnew = new Button();
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(206, 9);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(254, 25);
            lblMessage.TabIndex = 0;
            lblMessage.Text = "select difficulty and start game";
            // 
            // btneasy
            // 
            btneasy.AutoSize = true;
            btneasy.Location = new Point(200, 64);
            btneasy.Name = "btneasy";
            btneasy.Size = new Size(72, 29);
            btneasy.TabIndex = 1;
            btneasy.TabStop = true;
            btneasy.Text = "easy";
            btneasy.UseVisualStyleBackColor = true;
            // 
            // btnmedium
            // 
            btnmedium.AutoSize = true;
            btnmedium.Location = new Point(278, 64);
            btnmedium.Name = "btnmedium";
            btnmedium.Size = new Size(103, 29);
            btnmedium.TabIndex = 2;
            btnmedium.TabStop = true;
            btnmedium.Text = "medium";
            btnmedium.UseVisualStyleBackColor = true;
            // 
            // btnhard
            // 
            btnhard.AutoSize = true;
            btnhard.Location = new Point(387, 64);
            btnhard.Name = "btnhard";
            btnhard.Size = new Size(73, 29);
            btnhard.TabIndex = 3;
            btnhard.TabStop = true;
            btnhard.Text = "hard";
            btnhard.UseVisualStyleBackColor = true;
            // 
            // btnstart
            // 
            btnstart.Location = new Point(278, 114);
            btnstart.Name = "btnstart";
            btnstart.Size = new Size(112, 34);
            btnstart.TabIndex = 4;
            btnstart.Text = "start game";
            btnstart.UseVisualStyleBackColor = true;
            btnstart.Click += btnstart_Click;
            // 
            // txtguess
            // 
            txtguess.Location = new Point(278, 228);
            txtguess.Name = "txtguess";
            txtguess.Size = new Size(150, 31);
            txtguess.TabIndex = 5;
            // 
            // lblguess
            // 
            lblguess.Location = new Point(278, 173);
            lblguess.Name = "lblguess";
            lblguess.Size = new Size(426, 38);
            lblguess.TabIndex = 6;
            lblguess.Text = "guess1";
            // 
            // btnguess
            // 
            btnguess.Location = new Point(278, 280);
            btnguess.Name = "btnguess";
            btnguess.Size = new Size(112, 34);
            btnguess.TabIndex = 7;
            btnguess.Text = "guess";
            btnguess.UseVisualStyleBackColor = true;
            btnguess.Click += btnguess_Click_1;
            // 
            // btnnew
            // 
            btnnew.Location = new Point(422, 280);
            btnnew.Name = "btnnew";
            btnnew.Size = new Size(112, 34);
            btnnew.TabIndex = 8;
            btnnew.Text = "new game";
            btnnew.UseVisualStyleBackColor = true;
            btnnew.Click += btnnew_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnnew);
            Controls.Add(btnguess);
            Controls.Add(lblguess);
            Controls.Add(txtguess);
            Controls.Add(btnstart);
            Controls.Add(btnhard);
            Controls.Add(btnmedium);
            Controls.Add(btneasy);
            Controls.Add(lblMessage);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMessage;
        private RadioButton btneasy;
        private RadioButton btnmedium;
        private RadioButton btnhard;
        private Button btnstart;
        private TextBox txtguess;
        private Label lblguess;
        private Button btnguess;
        private Button btnnew;
    }
}