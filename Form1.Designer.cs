namespace Activity14
{
    partial class fruitForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fruitForm));
            this.fruitsListBox = new System.Windows.Forms.ListBox();
            this.fruitsLabel = new System.Windows.Forms.Label();
            this.pictureYesRadioButton = new System.Windows.Forms.RadioButton();
            this.pictureNoRadioButton = new System.Windows.Forms.RadioButton();
            this.pictureGroupBox = new System.Windows.Forms.GroupBox();
            this.infoGroupBox = new System.Windows.Forms.GroupBox();
            this.colorCheckBox = new System.Windows.Forms.CheckBox();
            this.typeCheckBox = new System.Windows.Forms.CheckBox();
            this.fruitPictureBox = new System.Windows.Forms.PictureBox();
            this.fruitPictureList = new System.Windows.Forms.ImageList(this.components);
            this.infoOutputLabel = new System.Windows.Forms.Label();
            this.showInfoButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.pictureGroupBox.SuspendLayout();
            this.infoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fruitPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // fruitsListBox
            // 
            this.fruitsListBox.FormattingEnabled = true;
            this.fruitsListBox.Items.AddRange(new object[] {
            "Apple",
            "Banana",
            "Grapes",
            "Orange",
            "Strawberry"});
            this.fruitsListBox.Location = new System.Drawing.Point(12, 38);
            this.fruitsListBox.Name = "fruitsListBox";
            this.fruitsListBox.Size = new System.Drawing.Size(139, 108);
            this.fruitsListBox.TabIndex = 0;
            // 
            // fruitsLabel
            // 
            this.fruitsLabel.AutoSize = true;
            this.fruitsLabel.Location = new System.Drawing.Point(12, 22);
            this.fruitsLabel.Name = "fruitsLabel";
            this.fruitsLabel.Size = new System.Drawing.Size(32, 13);
            this.fruitsLabel.TabIndex = 1;
            this.fruitsLabel.Text = "Fruits";
            // 
            // pictureYesRadioButton
            // 
            this.pictureYesRadioButton.AutoSize = true;
            this.pictureYesRadioButton.Location = new System.Drawing.Point(6, 19);
            this.pictureYesRadioButton.Name = "pictureYesRadioButton";
            this.pictureYesRadioButton.Size = new System.Drawing.Size(43, 17);
            this.pictureYesRadioButton.TabIndex = 2;
            this.pictureYesRadioButton.Text = "Yes";
            this.pictureYesRadioButton.UseVisualStyleBackColor = true;
            // 
            // pictureNoRadioButton
            // 
            this.pictureNoRadioButton.AutoSize = true;
            this.pictureNoRadioButton.Checked = true;
            this.pictureNoRadioButton.Location = new System.Drawing.Point(6, 42);
            this.pictureNoRadioButton.Name = "pictureNoRadioButton";
            this.pictureNoRadioButton.Size = new System.Drawing.Size(39, 17);
            this.pictureNoRadioButton.TabIndex = 3;
            this.pictureNoRadioButton.TabStop = true;
            this.pictureNoRadioButton.Text = "No";
            this.pictureNoRadioButton.UseVisualStyleBackColor = true;
            // 
            // pictureGroupBox
            // 
            this.pictureGroupBox.Controls.Add(this.pictureNoRadioButton);
            this.pictureGroupBox.Controls.Add(this.pictureYesRadioButton);
            this.pictureGroupBox.Location = new System.Drawing.Point(12, 161);
            this.pictureGroupBox.Name = "pictureGroupBox";
            this.pictureGroupBox.Size = new System.Drawing.Size(99, 69);
            this.pictureGroupBox.TabIndex = 4;
            this.pictureGroupBox.TabStop = false;
            this.pictureGroupBox.Text = "Show Picture";
            // 
            // infoGroupBox
            // 
            this.infoGroupBox.Controls.Add(this.typeCheckBox);
            this.infoGroupBox.Controls.Add(this.colorCheckBox);
            this.infoGroupBox.Location = new System.Drawing.Point(12, 241);
            this.infoGroupBox.Name = "infoGroupBox";
            this.infoGroupBox.Size = new System.Drawing.Size(99, 70);
            this.infoGroupBox.TabIndex = 5;
            this.infoGroupBox.TabStop = false;
            this.infoGroupBox.Text = "Information";
            // 
            // colorCheckBox
            // 
            this.colorCheckBox.AutoSize = true;
            this.colorCheckBox.Location = new System.Drawing.Point(6, 19);
            this.colorCheckBox.Name = "colorCheckBox";
            this.colorCheckBox.Size = new System.Drawing.Size(50, 17);
            this.colorCheckBox.TabIndex = 6;
            this.colorCheckBox.Text = "Color";
            this.colorCheckBox.UseVisualStyleBackColor = true;
            // 
            // typeCheckBox
            // 
            this.typeCheckBox.AutoSize = true;
            this.typeCheckBox.Location = new System.Drawing.Point(6, 42);
            this.typeCheckBox.Name = "typeCheckBox";
            this.typeCheckBox.Size = new System.Drawing.Size(50, 17);
            this.typeCheckBox.TabIndex = 7;
            this.typeCheckBox.Text = "Type";
            this.typeCheckBox.UseVisualStyleBackColor = true;
            // 
            // fruitPictureBox
            // 
            this.fruitPictureBox.Location = new System.Drawing.Point(187, 72);
            this.fruitPictureBox.Name = "fruitPictureBox";
            this.fruitPictureBox.Size = new System.Drawing.Size(128, 128);
            this.fruitPictureBox.TabIndex = 6;
            this.fruitPictureBox.TabStop = false;
            // 
            // fruitPictureList
            // 
            this.fruitPictureList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("fruitPictureList.ImageStream")));
            this.fruitPictureList.TransparentColor = System.Drawing.Color.Transparent;
            this.fruitPictureList.Images.SetKeyName(0, "Apple.bmp");
            this.fruitPictureList.Images.SetKeyName(1, "Banana.bmp");
            this.fruitPictureList.Images.SetKeyName(2, "Grapes.bmp");
            this.fruitPictureList.Images.SetKeyName(3, "Orange.bmp");
            this.fruitPictureList.Images.SetKeyName(4, "Strawberry.bmp");
            // 
            // infoOutputLabel
            // 
            this.infoOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.infoOutputLabel.Location = new System.Drawing.Point(201, 219);
            this.infoOutputLabel.Name = "infoOutputLabel";
            this.infoOutputLabel.Size = new System.Drawing.Size(100, 35);
            this.infoOutputLabel.TabIndex = 7;
            this.infoOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showInfoButton
            // 
            this.showInfoButton.Location = new System.Drawing.Point(172, 283);
            this.showInfoButton.Name = "showInfoButton";
            this.showInfoButton.Size = new System.Drawing.Size(75, 23);
            this.showInfoButton.TabIndex = 8;
            this.showInfoButton.Text = "Show Info";
            this.showInfoButton.UseVisualStyleBackColor = true;
            this.showInfoButton.Click += new System.EventHandler(this.showInfoButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(257, 283);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // fruitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 331);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.showInfoButton);
            this.Controls.Add(this.infoOutputLabel);
            this.Controls.Add(this.fruitPictureBox);
            this.Controls.Add(this.infoGroupBox);
            this.Controls.Add(this.pictureGroupBox);
            this.Controls.Add(this.fruitsLabel);
            this.Controls.Add(this.fruitsListBox);
            this.Name = "fruitForm";
            this.Text = "Fruit Info";
            this.pictureGroupBox.ResumeLayout(false);
            this.pictureGroupBox.PerformLayout();
            this.infoGroupBox.ResumeLayout(false);
            this.infoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fruitPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox fruitsListBox;
        private System.Windows.Forms.Label fruitsLabel;
        private System.Windows.Forms.RadioButton pictureYesRadioButton;
        private System.Windows.Forms.RadioButton pictureNoRadioButton;
        private System.Windows.Forms.GroupBox pictureGroupBox;
        private System.Windows.Forms.GroupBox infoGroupBox;
        private System.Windows.Forms.CheckBox typeCheckBox;
        private System.Windows.Forms.CheckBox colorCheckBox;
        private System.Windows.Forms.PictureBox fruitPictureBox;
        private System.Windows.Forms.ImageList fruitPictureList;
        private System.Windows.Forms.Label infoOutputLabel;
        private System.Windows.Forms.Button showInfoButton;
        private System.Windows.Forms.Button clearButton;
    }
}

