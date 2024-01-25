namespace EApp
{
    partial class Electricity_App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Electricity_App));
            label1 = new Label();
            E_APP = new Label();
            Home = new Button();
            Commercial = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // E_APP
            // 
            E_APP.BackColor = Color.SandyBrown;
            E_APP.Dock = DockStyle.Top;
            E_APP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            E_APP.Location = new Point(2, 2);
            E_APP.Name = "E_APP";
            E_APP.Padding = new Padding(2);
            E_APP.Size = new Size(999, 42);
            E_APP.TabIndex = 1;
            E_APP.Text = "E-APP";
            E_APP.TextAlign = ContentAlignment.TopCenter;
            // 
            // Home
            // 
            Home.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Home.BackColor = Color.LightSalmon;
            Home.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Home.FlatAppearance.BorderSize = 2;
            Home.Location = new Point(248, 284);
            Home.Name = "Home";
            Home.Padding = new Padding(2);
            Home.Size = new Size(147, 45);
            Home.TabIndex = 2;
            Home.Text = "Home";
            Home.UseVisualStyleBackColor = false;
            Home.Click += Home_Click;
            // 
            // Commercial
            // 
            Commercial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Commercial.BackColor = Color.LightSalmon;
            Commercial.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Commercial.FlatAppearance.BorderSize = 2;
            Commercial.Location = new Point(563, 284);
            Commercial.Name = "Commercial";
            Commercial.Padding = new Padding(2);
            Commercial.Size = new Size(147, 45);
            Commercial.TabIndex = 3;
            Commercial.Text = "Commerical";
            Commercial.UseVisualStyleBackColor = false;
            Commercial.Click += Commercial_Click;
            // 
            // Electricity_App
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1003, 450);
            Controls.Add(Commercial);
            Controls.Add(Home);
            Controls.Add(E_APP);
            Controls.Add(label1);
            Name = "Electricity_App";
            Padding = new Padding(2);
            ShowIcon = false;
            Text = "Electricity App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label E_APP;
        private Button Home;
        private Button Commercial;
    }
}
