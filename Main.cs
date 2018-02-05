using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SundayRoast
{
    public partial class FrmMain : Form
    {
        // VARIABLES
        private int _selectedMeat;
        private int _selectedTime;
        private EnTime _timer;
        private TimeSpan _time = new TimeSpan(0, 0, 0);

        // ENUMERATIONS
        private enum EnTime
        {
            StartTime = 1,
            ReadyTime = 2
        }

        private enum EnMeat
        {
            Beef = 1,
            Chicken = 2,
            Duck = 3,
            Goose = 4,
            Lamb = 5,
            Pork = 6,
            Turkey = 7
        }

        // CONSTRUCTORS
        public FrmMain()
        {
            InitializeComponent();
        }

        // METHODS
        private void FrmMain_Load(object sender, EventArgs e)
        {
            _selectedMeat = Properties.Settings.Default.MeatSetting;
            _selectedTime = Properties.Settings.Default.TimeSetting;
        }

        private void TimeSelect(object sender, EventArgs e)
        {
            // string ctlName = ((Control)sender).Name;

            txtTimeH.Focus();
        }

        private void txtTimeM_Enter(object sender, EventArgs e)
        {
            
            txtTimeM.SelectAll();
        }

        private void txtTimeH_Enter(object sender, EventArgs e)
        {
            txtTimeH.SelectAll();
           
        }

        private void butCalculate_Click(object sender, EventArgs e)
        {
            _time = new TimeSpan(Convert.ToInt32(txtTimeH.Text), Convert.ToInt32(txtTimeM.Text), 0);

            if (chkRoast.Checked == true)
            {
                _time += new TimeSpan(0, 50, 0);
                lblRoast.Text = (_time.ToString());
            }
            else
            {
                lblRoast.Text = "00:00";
            }



            switch (_timer)
            {
                case EnTime.ReadyTime:

                    break;
                case EnTime.StartTime:

                    break;
            }
        }


        private void butStartNow_Click(object sender, EventArgs e)
        {
txtTimeH.Text = DateTime.Now.Hour.ToString();
            txtTimeM.Text = DateTime.Now.Minute.ToString();
        }


        // PROPERTIES

    }
}
