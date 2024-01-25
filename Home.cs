using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace EApp
{
    public partial class Home : Form
    {
        float UserUnit; //To Take Unit as an input
        double Measure; //To Measure unit with Rs

        public Home()
        {
            InitializeComponent();
        }


        private void UnitEntry_TextChanged(object sender, EventArgs e)
        {
            // Try to convert the text to an integer
        bool success = float.TryParse(UnitEntry.Text, out UserUnit); //This thing needed to be understand
            // If the conversion failed, show an error message
            if (!success)
            {
                MessageBox.Show("Please enter a Unit in No.");
            }
        }

        private void UnitMeasuring_Click(object sender, EventArgs e)
        {
            // Check if the text is not null or empty
            if (!string.IsNullOrEmpty(UnitEntry.Text))
            {
                // Try to execute the logic
                try
                {
                    // Check if the user unit is less than 100
                    if (UserUnit < 100)
                    {
                        // Assign the text to the label
                        lblshow.Visible = true;
                        
                        Measure = UserUnit * 2.5;
                        lblshow.Text = Measure.ToString();
                        
                    }
                    else if (UserUnit >= 100 && UserUnit <= 200)
                    {
                        lblshow.Visible = true;
                        Measure = UserUnit * 4;
                        lblshow.Text = Measure.ToString();
                    }
                    else if (UserUnit >= 200 && UserUnit <= 500)
                    {
                        lblshow.Visible = true;
                        Measure = UserUnit * 5;
                        lblshow.Text = Measure.ToString();
                    }
                    else if (UserUnit > 500)
                    {
                        lblshow.Visible = true;
                        Measure = UserUnit * 7;
                        lblshow.Text = Measure.ToString();
                    };
                }

                catch (Exception ex)
                {
                    // Show the exception message
                    MessageBox.Show(ex.Message);
                }
            }
            
        }
    }
}
