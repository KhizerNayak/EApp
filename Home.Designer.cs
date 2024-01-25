namespace EApp
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            lblshow = new Label();
            lblResult = new Label();
            UnitEntry = new TextBox();
            UnitMeasure = new Label();
            UnitMeasuring = new Button();
            SuspendLayout();
            // 
            // lblshow
            // 
            lblshow.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblshow.BackColor = Color.LightSalmon;
            lblshow.BorderStyle = BorderStyle.FixedSingle;
            lblshow.Location = new Point(317, 380);
            lblshow.Name = "lblshow";
            lblshow.Padding = new Padding(2);
            lblshow.Size = new Size(339, 37);
            lblshow.TabIndex = 1;
            lblshow.TextAlign = ContentAlignment.MiddleCenter;
            lblshow.Visible = false;
            // 
            // lblResult
            // 
            lblResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblResult.BackColor = Color.LightSalmon;
            lblResult.BorderStyle = BorderStyle.FixedSingle;
            lblResult.Location = new Point(103, 380);
            lblResult.Name = "lblResult";
            lblResult.Padding = new Padding(2);
            lblResult.Size = new Size(128, 37);
            lblResult.TabIndex = 2;
            lblResult.Text = "Result :";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UnitEntry
            // 
            UnitEntry.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            UnitEntry.Location = new Point(317, 133);
            UnitEntry.Name = "UnitEntry";
            UnitEntry.PlaceholderText = "UNIT";
            UnitEntry.Size = new Size(339, 27);
            UnitEntry.TabIndex = 3;
            UnitEntry.TextAlign = HorizontalAlignment.Center;
            UnitEntry.TextChanged += UnitEntry_TextChanged;
            // 
            // UnitMeasure
            // 
            UnitMeasure.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UnitMeasure.BackColor = Color.LightSalmon;
            UnitMeasure.BorderStyle = BorderStyle.FixedSingle;
            UnitMeasure.Enabled = false;
            UnitMeasure.Location = new Point(103, 123);
            UnitMeasure.Name = "UnitMeasure";
            UnitMeasure.Padding = new Padding(2);
            UnitMeasure.Size = new Size(128, 37);
            UnitMeasure.TabIndex = 4;
            UnitMeasure.Text = "Unit :";
            UnitMeasure.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UnitMeasuring
            // 
            UnitMeasuring.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UnitMeasuring.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            UnitMeasuring.BackColor = Color.Coral;
            UnitMeasuring.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            UnitMeasuring.FlatAppearance.BorderSize = 3;
            UnitMeasuring.Location = new Point(391, 232);
            UnitMeasuring.Name = "UnitMeasuring";
            UnitMeasuring.Padding = new Padding(2);
            UnitMeasuring.Size = new Size(185, 44);
            UnitMeasuring.TabIndex = 5;
            UnitMeasuring.Text = "Measure Here !";
            UnitMeasuring.UseVisualStyleBackColor = false;
            UnitMeasuring.Click += UnitMeasuring_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(992, 465);
            Controls.Add(UnitMeasuring);
            Controls.Add(UnitMeasure);
            Controls.Add(UnitEntry);
            Controls.Add(lblResult);
            Controls.Add(lblshow);
            Name = "Home";
            Padding = new Padding(2);
            ShowIcon = false;
            Text = "Home";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Label lblshow;
        private Label lblResult;
        private TextBox UnitEntry;
        private Label UnitMeasure;
        private Button UnitMeasuring;
    }
}