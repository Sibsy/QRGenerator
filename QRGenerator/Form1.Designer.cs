namespace QRGenerator
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
            this.components = new System.ComponentModel.Container();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.grpBxIncImage = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLogoBGColor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownBorderWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLogoSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.pictureBoxImagePreview = new System.Windows.Forms.PictureBox();
            this.checkBoxIncludeImage = new System.Windows.Forms.CheckBox();
            this.grpBxConfig = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownDetail = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonLightColor = new System.Windows.Forms.Button();
            this.buttonDarkColor = new System.Windows.Forms.Button();
            this.checkBoxQuietZone = new System.Windows.Forms.CheckBox();
            this.colorDialogDarkColor = new System.Windows.Forms.ColorDialog();
            this.colorDialogLightColor = new System.Windows.Forms.ColorDialog();
            this.colorDialogLogoBGColor = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtBxPayload = new System.Windows.Forms.TextBox();
            this.gbWifi = new System.Windows.Forms.GroupBox();
            this.checkBoxHiddenSSID = new System.Windows.Forms.CheckBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblSSID = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.comboBoxWifiType = new System.Windows.Forms.ComboBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxSSID = new System.Windows.Forms.TextBox();
            this.checkBoxWifi = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.grpBxIncImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBorderWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLogoSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagePreview)).BeginInit();
            this.grpBxConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDetail)).BeginInit();
            this.gbWifi.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(498, 316);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 0;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(721, 316);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.Location = new System.Drawing.Point(498, 12);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(298, 298);
            this.pictureBoxPreview.TabIndex = 2;
            this.pictureBoxPreview.TabStop = false;
            // 
            // grpBxIncImage
            // 
            this.grpBxIncImage.Controls.Add(this.label5);
            this.grpBxIncImage.Controls.Add(this.btnLogoBGColor);
            this.grpBxIncImage.Controls.Add(this.label2);
            this.grpBxIncImage.Controls.Add(this.numericUpDownBorderWidth);
            this.grpBxIncImage.Controls.Add(this.numericUpDownLogoSize);
            this.grpBxIncImage.Controls.Add(this.label1);
            this.grpBxIncImage.Controls.Add(this.btnLoadImage);
            this.grpBxIncImage.Controls.Add(this.pictureBoxImagePreview);
            this.grpBxIncImage.Controls.Add(this.checkBoxIncludeImage);
            this.grpBxIncImage.Location = new System.Drawing.Point(12, 188);
            this.grpBxIncImage.Name = "grpBxIncImage";
            this.grpBxIncImage.Size = new System.Drawing.Size(274, 155);
            this.grpBxIncImage.TabIndex = 3;
            this.grpBxIncImage.TabStop = false;
            this.grpBxIncImage.Text = "Include Image";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Logo BG";
            // 
            // btnLogoBGColor
            // 
            this.btnLogoBGColor.Location = new System.Drawing.Point(6, 112);
            this.btnLogoBGColor.Name = "btnLogoBGColor";
            this.btnLogoBGColor.Size = new System.Drawing.Size(93, 23);
            this.btnLogoBGColor.TabIndex = 8;
            this.btnLogoBGColor.UseVisualStyleBackColor = true;
            this.btnLogoBGColor.Click += new System.EventHandler(this.btnLogoBGColor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Border(px)";
            // 
            // numericUpDownBorderWidth
            // 
            this.numericUpDownBorderWidth.Location = new System.Drawing.Point(6, 83);
            this.numericUpDownBorderWidth.Name = "numericUpDownBorderWidth";
            this.numericUpDownBorderWidth.Size = new System.Drawing.Size(93, 23);
            this.numericUpDownBorderWidth.TabIndex = 6;
            // 
            // numericUpDownLogoSize
            // 
            this.numericUpDownLogoSize.Location = new System.Drawing.Point(6, 48);
            this.numericUpDownLogoSize.Maximum = new decimal(new int[] {
            95,
            0,
            0,
            0});
            this.numericUpDownLogoSize.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownLogoSize.Name = "numericUpDownLogoSize";
            this.numericUpDownLogoSize.Size = new System.Drawing.Size(93, 23);
            this.numericUpDownLogoSize.TabIndex = 5;
            this.numericUpDownLogoSize.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Logo Size";
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Enabled = false;
            this.btnLoadImage.Location = new System.Drawing.Point(180, 128);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(75, 23);
            this.btnLoadImage.TabIndex = 2;
            this.btnLoadImage.Text = "Load Image";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // pictureBoxImagePreview
            // 
            this.pictureBoxImagePreview.Location = new System.Drawing.Point(168, 22);
            this.pictureBoxImagePreview.Name = "pictureBoxImagePreview";
            this.pictureBoxImagePreview.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxImagePreview.TabIndex = 1;
            this.pictureBoxImagePreview.TabStop = false;
            // 
            // checkBoxIncludeImage
            // 
            this.checkBoxIncludeImage.AutoSize = true;
            this.checkBoxIncludeImage.Location = new System.Drawing.Point(6, 22);
            this.checkBoxIncludeImage.Name = "checkBoxIncludeImage";
            this.checkBoxIncludeImage.Size = new System.Drawing.Size(101, 19);
            this.checkBoxIncludeImage.TabIndex = 0;
            this.checkBoxIncludeImage.Text = "Include Image";
            this.checkBoxIncludeImage.UseVisualStyleBackColor = true;
            this.checkBoxIncludeImage.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // grpBxConfig
            // 
            this.grpBxConfig.Controls.Add(this.label6);
            this.grpBxConfig.Controls.Add(this.numericUpDownDetail);
            this.grpBxConfig.Controls.Add(this.label4);
            this.grpBxConfig.Controls.Add(this.label3);
            this.grpBxConfig.Controls.Add(this.buttonLightColor);
            this.grpBxConfig.Controls.Add(this.buttonDarkColor);
            this.grpBxConfig.Controls.Add(this.checkBoxQuietZone);
            this.grpBxConfig.Location = new System.Drawing.Point(292, 187);
            this.grpBxConfig.Name = "grpBxConfig";
            this.grpBxConfig.Size = new System.Drawing.Size(200, 156);
            this.grpBxConfig.TabIndex = 6;
            this.grpBxConfig.TabStop = false;
            this.grpBxConfig.Text = "Config";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Detail Level";
            // 
            // numericUpDownDetail
            // 
            this.numericUpDownDetail.Location = new System.Drawing.Point(13, 111);
            this.numericUpDownDetail.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.numericUpDownDetail.Name = "numericUpDownDetail";
            this.numericUpDownDetail.Size = new System.Drawing.Size(75, 23);
            this.numericUpDownDetail.TabIndex = 5;
            this.numericUpDownDetail.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "QR Colour 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "QR Colour 1";
            // 
            // buttonLightColor
            // 
            this.buttonLightColor.Location = new System.Drawing.Point(13, 82);
            this.buttonLightColor.Name = "buttonLightColor";
            this.buttonLightColor.Size = new System.Drawing.Size(75, 23);
            this.buttonLightColor.TabIndex = 2;
            this.buttonLightColor.UseVisualStyleBackColor = true;
            this.buttonLightColor.Click += new System.EventHandler(this.buttonLightColor_Click);
            // 
            // buttonDarkColor
            // 
            this.buttonDarkColor.Location = new System.Drawing.Point(13, 53);
            this.buttonDarkColor.Name = "buttonDarkColor";
            this.buttonDarkColor.Size = new System.Drawing.Size(75, 23);
            this.buttonDarkColor.TabIndex = 1;
            this.buttonDarkColor.UseVisualStyleBackColor = true;
            this.buttonDarkColor.Click += new System.EventHandler(this.buttonDarkColor_Click);
            // 
            // checkBoxQuietZone
            // 
            this.checkBoxQuietZone.AutoSize = true;
            this.checkBoxQuietZone.Location = new System.Drawing.Point(17, 28);
            this.checkBoxQuietZone.Name = "checkBoxQuietZone";
            this.checkBoxQuietZone.Size = new System.Drawing.Size(115, 19);
            this.checkBoxQuietZone.TabIndex = 0;
            this.checkBoxQuietZone.Text = "Draw Quiet Zone";
            this.checkBoxQuietZone.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtBxPayload
            // 
            this.txtBxPayload.Location = new System.Drawing.Point(12, 12);
            this.txtBxPayload.Multiline = true;
            this.txtBxPayload.Name = "txtBxPayload";
            this.txtBxPayload.Size = new System.Drawing.Size(274, 170);
            this.txtBxPayload.TabIndex = 5;
            // 
            // gbWifi
            // 
            this.gbWifi.Controls.Add(this.checkBoxHiddenSSID);
            this.gbWifi.Controls.Add(this.lblPass);
            this.gbWifi.Controls.Add(this.lblSSID);
            this.gbWifi.Controls.Add(this.lblType);
            this.gbWifi.Controls.Add(this.comboBoxWifiType);
            this.gbWifi.Controls.Add(this.textBoxPass);
            this.gbWifi.Controls.Add(this.textBoxSSID);
            this.gbWifi.Controls.Add(this.checkBoxWifi);
            this.gbWifi.Location = new System.Drawing.Point(292, 12);
            this.gbWifi.Name = "gbWifi";
            this.gbWifi.Size = new System.Drawing.Size(200, 169);
            this.gbWifi.TabIndex = 8;
            this.gbWifi.TabStop = false;
            this.gbWifi.Text = "Wifi?";
            // 
            // checkBoxHiddenSSID
            // 
            this.checkBoxHiddenSSID.AutoSize = true;
            this.checkBoxHiddenSSID.Location = new System.Drawing.Point(10, 142);
            this.checkBoxHiddenSSID.Name = "checkBoxHiddenSSID";
            this.checkBoxHiddenSSID.Size = new System.Drawing.Size(91, 19);
            this.checkBoxHiddenSSID.TabIndex = 7;
            this.checkBoxHiddenSSID.Text = "Hidden SSID";
            this.checkBoxHiddenSSID.UseVisualStyleBackColor = true;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(6, 116);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(30, 15);
            this.lblPass.TabIndex = 6;
            this.lblPass.Text = "Pass";
            // 
            // lblSSID
            // 
            this.lblSSID.AutoSize = true;
            this.lblSSID.Location = new System.Drawing.Point(6, 90);
            this.lblSSID.Name = "lblSSID";
            this.lblSSID.Size = new System.Drawing.Size(30, 15);
            this.lblSSID.TabIndex = 5;
            this.lblSSID.Text = "SSID";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(6, 56);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 15);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Type";
            // 
            // comboBoxWifiType
            // 
            this.comboBoxWifiType.Enabled = false;
            this.comboBoxWifiType.FormattingEnabled = true;
            this.comboBoxWifiType.Location = new System.Drawing.Point(43, 53);
            this.comboBoxWifiType.Name = "comboBoxWifiType";
            this.comboBoxWifiType.Size = new System.Drawing.Size(151, 23);
            this.comboBoxWifiType.TabIndex = 3;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Enabled = false;
            this.textBoxPass.Location = new System.Drawing.Point(42, 113);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(152, 23);
            this.textBoxPass.TabIndex = 2;
            // 
            // textBoxSSID
            // 
            this.textBoxSSID.Enabled = false;
            this.textBoxSSID.Location = new System.Drawing.Point(42, 81);
            this.textBoxSSID.Name = "textBoxSSID";
            this.textBoxSSID.Size = new System.Drawing.Size(152, 23);
            this.textBoxSSID.TabIndex = 1;
            // 
            // checkBoxWifi
            // 
            this.checkBoxWifi.AutoSize = true;
            this.checkBoxWifi.Location = new System.Drawing.Point(8, 28);
            this.checkBoxWifi.Name = "checkBoxWifi";
            this.checkBoxWifi.Size = new System.Drawing.Size(134, 19);
            this.checkBoxWifi.TabIndex = 0;
            this.checkBoxWifi.Text = "Create Wifi QR Code";
            this.checkBoxWifi.UseVisualStyleBackColor = true;
            this.checkBoxWifi.CheckedChanged += new System.EventHandler(this.checkBoxWifi_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 350);
            this.Controls.Add(this.gbWifi);
            this.Controls.Add(this.grpBxConfig);
            this.Controls.Add(this.txtBxPayload);
            this.Controls.Add(this.grpBxIncImage);
            this.Controls.Add(this.pictureBoxPreview);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPreview);
            this.Name = "Form1";
            this.Text = "QR Code Generator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.grpBxIncImage.ResumeLayout(false);
            this.grpBxIncImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBorderWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLogoSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagePreview)).EndInit();
            this.grpBxConfig.ResumeLayout(false);
            this.grpBxConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDetail)).EndInit();
            this.gbWifi.ResumeLayout(false);
            this.gbWifi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnPreview;
        private Button btnSave;
        private PictureBox pictureBoxPreview;
        private GroupBox grpBxIncImage;
        private PictureBox pictureBoxImagePreview;
        private CheckBox checkBoxIncludeImage;
        private GroupBox grpBxConfig;
        private Button btnLoadImage;
        private Label label1;
        private NumericUpDown numericUpDownLogoSize;
        private Label label2;
        private NumericUpDown numericUpDownBorderWidth;
        private Button btnLogoBGColor;
        private ColorDialog colorDialogDarkColor;
        private Button buttonLightColor;
        private Button buttonDarkColor;
        private CheckBox checkBoxQuietZone;
        private ColorDialog colorDialogLightColor;
        private ColorDialog colorDialogLogoBGColor;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label6;
        private NumericUpDown numericUpDownDetail;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtBxPayload;
        private GroupBox gbWifi;
        private Label lblPass;
        private Label lblSSID;
        private Label lblType;
        private ComboBox comboBoxWifiType;
        private TextBox textBoxPass;
        private TextBox textBoxSSID;
        private CheckBox checkBoxWifi;
        private CheckBox checkBoxHiddenSSID;
    }
}