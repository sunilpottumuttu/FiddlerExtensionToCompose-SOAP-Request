namespace SOAPRequestComposer
{
    partial class SOAPRequestComposer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblURL = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.rtbRequest = new System.Windows.Forms.RichTextBox();
            this.rtbResponse = new System.Windows.Forms.RichTextBox();
            this.lblResponse = new System.Windows.Forms.Label();
            this.lblRequest = new System.Windows.Forms.Label();
            this.btnLoadSample = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblURL.Location = new System.Drawing.Point(5, 13);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(32, 13);
            this.lblURL.TabIndex = 0;
            this.lblURL.Text = "URL";
            // 
            // txtURL
            // 
            this.txtURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtURL.Location = new System.Drawing.Point(43, 13);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(831, 20);
            this.txtURL.TabIndex = 1;
            // 
            // btnExecute
            // 
            this.btnExecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecute.Location = new System.Drawing.Point(881, 13);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(122, 23);
            this.btnExecute.TabIndex = 2;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // rtbRequest
            // 
            this.rtbRequest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbRequest.Location = new System.Drawing.Point(8, 63);
            this.rtbRequest.Name = "rtbRequest";
            this.rtbRequest.Size = new System.Drawing.Size(995, 263);
            this.rtbRequest.TabIndex = 3;
            this.rtbRequest.Text = "";
            // 
            // rtbResponse
            // 
            this.rtbResponse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbResponse.Location = new System.Drawing.Point(8, 353);
            this.rtbResponse.Name = "rtbResponse";
            this.rtbResponse.Size = new System.Drawing.Size(995, 282);
            this.rtbResponse.TabIndex = 4;
            this.rtbResponse.Text = "";
            // 
            // lblResponse
            // 
            this.lblResponse.AutoSize = true;
            this.lblResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponse.Location = new System.Drawing.Point(5, 337);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(63, 13);
            this.lblResponse.TabIndex = 5;
            this.lblResponse.Text = "Response";
            // 
            // lblRequest
            // 
            this.lblRequest.AutoSize = true;
            this.lblRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequest.Location = new System.Drawing.Point(5, 39);
            this.lblRequest.Name = "lblRequest";
            this.lblRequest.Size = new System.Drawing.Size(54, 13);
            this.lblRequest.TabIndex = 6;
            this.lblRequest.Text = "Request";
            // 
            // btnLoadSample
            // 
            this.btnLoadSample.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadSample.Location = new System.Drawing.Point(860, 37);
            this.btnLoadSample.Name = "btnLoadSample";
            this.btnLoadSample.Size = new System.Drawing.Size(143, 23);
            this.btnLoadSample.TabIndex = 7;
            this.btnLoadSample.Text = "Load Sample Request";
            this.btnLoadSample.UseVisualStyleBackColor = true;
            this.btnLoadSample.Click += new System.EventHandler(this.btnLoadSample_Click);
            // 
            // SOAPRequestComposer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLoadSample);
            this.Controls.Add(this.lblRequest);
            this.Controls.Add(this.lblResponse);
            this.Controls.Add(this.rtbResponse);
            this.Controls.Add(this.rtbRequest);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.lblURL);
            this.Name = "SOAPRequestComposer";
            this.Size = new System.Drawing.Size(1015, 649);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.RichTextBox rtbRequest;
        private System.Windows.Forms.RichTextBox rtbResponse;
        private System.Windows.Forms.Label lblResponse;
        private System.Windows.Forms.Label lblRequest;
        private System.Windows.Forms.Button btnLoadSample;
    }
}
