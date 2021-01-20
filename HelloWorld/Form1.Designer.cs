
namespace HelloWorld
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnHelloWorld = new System.Windows.Forms.Button();
            this.lbDisplayInfo = new System.Windows.Forms.Label();
            this.btnMessage = new System.Windows.Forms.Button();
            this.btnGoodbye = new System.Windows.Forms.Button();
            this.picMack = new System.Windows.Forms.PictureBox();
            this.btnShowPic = new System.Windows.Forms.Button();
            this.btnHidePic = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picMack)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHelloWorld
            // 
            this.btnHelloWorld.Location = new System.Drawing.Point(161, 148);
            this.btnHelloWorld.Name = "btnHelloWorld";
            this.btnHelloWorld.Size = new System.Drawing.Size(111, 23);
            this.btnHelloWorld.TabIndex = 0;
            this.btnHelloWorld.Text = "Say Hello";
            this.btnHelloWorld.UseVisualStyleBackColor = true;
            this.btnHelloWorld.Click += new System.EventHandler(this.btnHelloWorld_Click);
            // 
            // lbDisplayInfo
            // 
            this.lbDisplayInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDisplayInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisplayInfo.Location = new System.Drawing.Point(161, 95);
            this.lbDisplayInfo.Name = "lbDisplayInfo";
            this.lbDisplayInfo.Size = new System.Drawing.Size(241, 23);
            this.lbDisplayInfo.TabIndex = 1;
            this.lbDisplayInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMessage
            // 
            this.btnMessage.Location = new System.Drawing.Point(291, 121);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(111, 23);
            this.btnMessage.TabIndex = 2;
            this.btnMessage.Text = "Display Message";
            this.btnMessage.UseVisualStyleBackColor = true;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // btnGoodbye
            // 
            this.btnGoodbye.Location = new System.Drawing.Point(161, 176);
            this.btnGoodbye.Name = "btnGoodbye";
            this.btnGoodbye.Size = new System.Drawing.Size(111, 23);
            this.btnGoodbye.TabIndex = 3;
            this.btnGoodbye.Text = "Say Goodbye";
            this.btnGoodbye.UseVisualStyleBackColor = true;
            this.btnGoodbye.Click += new System.EventHandler(this.btnGoodbye_Click);
            // 
            // picMack
            // 
            this.picMack.Image = ((System.Drawing.Image)(resources.GetObject("picMack.Image")));
            this.picMack.Location = new System.Drawing.Point(245, 12);
            this.picMack.Name = "picMack";
            this.picMack.Size = new System.Drawing.Size(81, 78);
            this.picMack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMack.TabIndex = 4;
            this.picMack.TabStop = false;
            this.picMack.Visible = false;
            this.picMack.Click += new System.EventHandler(this.picMack_Click);
            // 
            // btnShowPic
            // 
            this.btnShowPic.Location = new System.Drawing.Point(291, 148);
            this.btnShowPic.Name = "btnShowPic";
            this.btnShowPic.Size = new System.Drawing.Size(111, 23);
            this.btnShowPic.TabIndex = 5;
            this.btnShowPic.Text = "Show Pic";
            this.btnShowPic.UseVisualStyleBackColor = true;
            this.btnShowPic.Click += new System.EventHandler(this.btnShowPic_Click);
            // 
            // btnHidePic
            // 
            this.btnHidePic.Location = new System.Drawing.Point(161, 121);
            this.btnHidePic.Name = "btnHidePic";
            this.btnHidePic.Size = new System.Drawing.Size(111, 23);
            this.btnHidePic.TabIndex = 6;
            this.btnHidePic.Text = "Hide Pic";
            this.btnHidePic.UseVisualStyleBackColor = true;
            this.btnHidePic.Click += new System.EventHandler(this.btnHidePic_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(291, 176);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 223);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnHidePic);
            this.Controls.Add(this.btnShowPic);
            this.Controls.Add(this.picMack);
            this.Controls.Add(this.btnGoodbye);
            this.Controls.Add(this.btnMessage);
            this.Controls.Add(this.lbDisplayInfo);
            this.Controls.Add(this.btnHelloWorld);
            this.Name = "Form1";
            this.Text = "Hello World";
            ((System.ComponentModel.ISupportInitialize)(this.picMack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHelloWorld;
        private System.Windows.Forms.Label lbDisplayInfo;
        private System.Windows.Forms.Button btnMessage;
        private System.Windows.Forms.Button btnGoodbye;
        private System.Windows.Forms.PictureBox picMack;
        private System.Windows.Forms.Button btnShowPic;
        private System.Windows.Forms.Button btnHidePic;
        private System.Windows.Forms.Button btnClose;
    }
}

