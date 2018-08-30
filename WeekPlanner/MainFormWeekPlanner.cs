using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeekPlanner
{
    public partial class MainFormWeekPlanner : Form
    {
        public MainFormWeekPlanner()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_mon_snakcs.Visible = cb_5_times_a_day.Checked;
            lbl_tue_snacks.Visible = cb_5_times_a_day.Checked;
            lbl_wen_snacks.Visible = cb_5_times_a_day.Checked;
            lbl_thu_snacks.Visible = cb_5_times_a_day.Checked;
            lbl_fri_snacks.Visible = cb_5_times_a_day.Checked;
            lbl_sat_snacks.Visible = cb_5_times_a_day.Checked;
            lbl_sun_snacks.Visible = cb_5_times_a_day.Checked;
            txt_mon_morning_snakcs.Visible = cb_5_times_a_day.Checked;
            txt_tue_morning_snacks.Visible = cb_5_times_a_day.Checked;
            txt_wen_morning_snacks.Visible = cb_5_times_a_day.Checked;
            txt_thu_morning_snacks.Visible = cb_5_times_a_day.Checked;
            txt_fri_morning_snacks.Visible = cb_5_times_a_day.Checked;
            txt_sat_morning_snacks.Visible = cb_5_times_a_day.Checked;
            txt_sun_morning_snacks.Visible = cb_5_times_a_day.Checked;
            txt_mon_late_snacks.Visible = cb_5_times_a_day.Checked;
            txt_tue_late_snacks.Visible = cb_5_times_a_day.Checked;
            txt_wen_late_snacks.Visible = cb_5_times_a_day.Checked;
            txt_thu_late_snacks.Visible = cb_5_times_a_day.Checked;
            txt_fri_late_snacks.Visible = cb_5_times_a_day.Checked;
            txt_sat_late_snacks.Visible = cb_5_times_a_day.Checked;
            txt_sun_late_snacks.Visible = cb_5_times_a_day.Checked;
            btn_mon_snakcs_edit.Visible = cb_5_times_a_day.Checked;

        }

        private void cb_5_times_a_day_CheckedChanged(object sender, EventArgs e)
        {
           
            lbl_mon_snakcs.Visible = cb_5_times_a_day.Checked;
            lbl_tue_snacks.Visible = cb_5_times_a_day.Checked;
            lbl_wen_snacks.Visible = cb_5_times_a_day.Checked;
            lbl_thu_snacks.Visible = cb_5_times_a_day.Checked;
            lbl_fri_snacks.Visible = cb_5_times_a_day.Checked;
            lbl_sat_snacks.Visible = cb_5_times_a_day.Checked;
            lbl_sun_snacks.Visible = cb_5_times_a_day.Checked;
            txt_mon_morning_snakcs.Visible = cb_5_times_a_day.Checked;
            txt_tue_morning_snacks.Visible = cb_5_times_a_day.Checked;
            txt_wen_morning_snacks.Visible = cb_5_times_a_day.Checked;
            txt_thu_morning_snacks.Visible = cb_5_times_a_day.Checked;
            txt_fri_morning_snacks.Visible = cb_5_times_a_day.Checked;
            txt_sat_morning_snacks.Visible = cb_5_times_a_day.Checked;
            txt_sun_morning_snacks.Visible = cb_5_times_a_day.Checked;
            txt_mon_late_snacks.Visible = cb_5_times_a_day.Checked;
            txt_tue_late_snacks.Visible = cb_5_times_a_day.Checked;
            txt_wen_late_snacks.Visible = cb_5_times_a_day.Checked;
            txt_thu_late_snacks.Visible = cb_5_times_a_day.Checked;
            txt_fri_late_snacks.Visible = cb_5_times_a_day.Checked;
            txt_sat_late_snacks.Visible = cb_5_times_a_day.Checked;
            txt_sun_late_snacks.Visible = cb_5_times_a_day.Checked;
            btn_mon_snakcs_edit.Visible = cb_5_times_a_day.Checked;
            
        }

        private void btn_mon_B_skip_Click(object sender, EventArgs e)
        {
            lbl_mon_B.Visible = false;
            txt_mon_B.Visible = false;
            btn_mon_B_edit.Visible = false;
            btn_mon_B_skip.Visible = false;
        }
    }
}
