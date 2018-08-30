using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Profile
{
    public partial class MainFormProfile : Form
    {
        private int tb_last_value_carbohydrates = 0;
        private int tb_last_value_fat = 0;
        private int tb_last_value_protein = 0;

        public MainFormProfile()
        {
            InitializeComponent();

            tb_last_value_carbohydrates = tb_carbohydrates.Value;
            tb_last_value_fat = tb_fat.Value;
            tb_last_value_protein = tb_proteins.Value;
        }

       

        private void MainFormProfile_Load(object sender, EventArgs e)
        {
            //Add trimesters to Stage of drop down
            cbo_stage_of_pregnancy.Items.Add("");
            cbo_stage_of_pregnancy.Items.Add("1st Trimester");
            cbo_stage_of_pregnancy.Items.Add("2nd Trimester");
            cbo_stage_of_pregnancy.Items.Add("3rd Trimester");
            cbo_stage_of_pregnancy.SelectedIndex = 0;

            //Add Physical Activity Level
            cbo_PAL.Items.Add("");
            cbo_PAL.Items.Add("sedentary lifestyle");
            cbo_PAL.Items.Add("moderate activity");
            cbo_PAL.Items.Add("very active");
            cbo_PAL.SelectedIndex = 0;

            cbo_sex.Items.Add("");
            cbo_sex.Items.Add("Female");
            cbo_sex.Items.Add("Male");

        }

        private void cbo_sex_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbo_sex.SelectedItem == "Female")
            {
                lbl_pregnant.Visible = true;
                lbl_breastfeeding.Visible = true;
                cbo_pregnant.Visible = true;
                cbo_breastfeeding.Visible = true;
            }
            else
            {
                lbl_pregnant.Visible = false;
                lbl_breastfeeding.Visible = false;
                lbl_stage_of_pregnancy.Visible = false;
                cbo_pregnant.Visible = false;
                cbo_breastfeeding.Visible = false;
                cbo_stage_of_pregnancy.Visible = false;
            }

        }

        private void cbo_pregnant_CheckedChanged(object sender, EventArgs e)
        {
            lbl_stage_of_pregnancy.Visible = cbo_pregnant.Checked;
            cbo_stage_of_pregnancy.Visible = cbo_pregnant.Checked;
        }

        
        public int maxMacroValue = 100;

        private void tb_carbohydrates_Scroll(object sender, EventArgs e)
        {
            if(tb_carbohydrates.Value < maxMacroValue && tb_carbohydrates.Value < tb_fat.Value)
            {
                tb_fat.Value = (maxMacroValue - tb_proteins.Value - tb_last_value_carbohydrates - tb_carbohydrates.Value);
                tb_last_value_carbohydrates = this.tb_carbohydrates.Value;
            }
            else if (tb_carbohydrates.Value == maxMacroValue)
            {
                tb_fat.Value = 0;
                tb_proteins.Value = 0;
                tb_last_value_carbohydrates = this.tb_carbohydrates.Value;
            }
            else 
            {
                tb_fat.Value += (tb_last_value_carbohydrates - tb_carbohydrates.Value);
                tb_last_value_carbohydrates = this.tb_carbohydrates.Value;
            }
            

        
        

        }
    }
}
