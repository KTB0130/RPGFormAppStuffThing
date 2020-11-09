using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGFormAppStuffThing
{
    public partial class CharacterCreation : Form
    {
        string str;
        string per;
        string intel;
        string luck;
        string gender;
        string name;
        
        public CharacterCreation()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void cmbStrength_SelectedIndexChanged(object sender, EventArgs e)
        {
            str = cmbStrength.Text;
            if (str == "1")
            {
                cmbPerception.Items.Remove(cmbStrength.SelectedItem);
                cmbIntelligence.Items.Remove(cmbStrength.SelectedItem);
                cmbLuck.Items.Remove(cmbStrength.SelectedItem);
            }
            else if (str == "2")
            {
                cmbPerception.Items.Remove(cmbStrength.SelectedItem);
                cmbIntelligence.Items.Remove(cmbStrength.SelectedItem);
                cmbLuck.Items.Remove(cmbStrength.SelectedItem);
            }
            else if (str == "3")
            {
                cmbPerception.Items.Remove(cmbStrength.SelectedItem);
                cmbIntelligence.Items.Remove(cmbStrength.SelectedItem);
                cmbLuck.Items.Remove(cmbStrength.SelectedItem);
            }
            else if (str == "4")
            {
                cmbPerception.Items.Remove(cmbStrength.SelectedItem);
                cmbIntelligence.Items.Remove(cmbStrength.SelectedItem);
                cmbLuck.Items.Remove(cmbStrength.SelectedItem);
            }
            //Reset thing here
        }//finish reset function

        private void cmbCharacter_SelectedIndexChanged(object sender, EventArgs e)
        {
            gender = cmbCharacter.Text;
            //if (gender == "Masculine")
        }//Add male/female pictures and enable

        private void cmbPerception_SelectedIndexChanged(object sender, EventArgs e)
        {
            per = cmbPerception.Text;
            if (per == "1")
            {
                cmbStrength.Items.Remove(cmbPerception.SelectedItem);
                cmbIntelligence.Items.Remove(cmbPerception.SelectedItem);
                cmbLuck.Items.Remove(cmbPerception.SelectedItem);
            }
            else if (per == "2")
            {
                cmbStrength.Items.Remove(cmbPerception.SelectedItem);
                cmbIntelligence.Items.Remove(cmbPerception.SelectedItem);
                cmbLuck.Items.Remove(cmbPerception.SelectedItem);
            }
            else if (per == "3")
            {
                cmbStrength.Items.Remove(cmbPerception.SelectedItem);
                cmbIntelligence.Items.Remove(cmbPerception.SelectedItem);
                cmbLuck.Items.Remove(cmbPerception.SelectedItem);
            }
            else
            {
                cmbStrength.Items.Remove(cmbPerception.SelectedItem);
                cmbIntelligence.Items.Remove(cmbPerception.SelectedItem);
                cmbLuck.Items.Remove(cmbPerception.SelectedItem);
            }
        }

        private void cmbIntelligence_SelectedIndexChanged(object sender, EventArgs e)
        {
            intel = cmbIntelligence.Text;
            if (intel == "1")
            {
                cmbStrength.Items.Remove(cmbIntelligence.SelectedItem);
                cmbPerception.Items.Remove(cmbIntelligence.SelectedItem);
                cmbLuck.Items.Remove(cmbIntelligence.SelectedItem);
            }
            else if (intel == "2")
            {
                cmbStrength.Items.Remove(cmbIntelligence.SelectedItem);
                cmbPerception.Items.Remove(cmbIntelligence.SelectedItem);
                cmbLuck.Items.Remove(cmbIntelligence.SelectedItem);
            }
            else if (intel == "3") 
            {
                cmbStrength.Items.Remove(cmbIntelligence.SelectedItem);
                cmbPerception.Items.Remove(cmbIntelligence.SelectedItem);
                cmbLuck.Items.Remove(cmbIntelligence.SelectedItem);
            }
            else
            {
                cmbStrength.Items.Remove(cmbIntelligence.SelectedItem);
                cmbPerception.Items.Remove(cmbIntelligence.SelectedItem);
                cmbLuck.Items.Remove(cmbIntelligence.SelectedItem);
            }
        }

        private void cmbLuck_SelectedIndexChanged(object sender, EventArgs e)
        {
            luck = cmbLuck.Text;
            if (luck == "1")
            {
                cmbStrength.Items.Remove(cmbLuck.SelectedItem);
                cmbPerception.Items.Remove(cmbLuck.SelectedItem);
                cmbIntelligence.Items.Remove(cmbLuck.SelectedItem);
            }
            else if (luck == "2") 
            {
                cmbStrength.Items.Remove(cmbLuck.SelectedItem);
                cmbPerception.Items.Remove(cmbLuck.SelectedItem);
                cmbIntelligence.Items.Remove(cmbLuck.SelectedItem);
            }
            else if (luck == "3")
            {
                cmbStrength.Items.Remove(cmbLuck.SelectedItem);
                cmbPerception.Items.Remove(cmbLuck.SelectedItem);
                cmbIntelligence.Items.Remove(cmbLuck.SelectedItem);
            }
            else
            {
                cmbStrength.Items.Remove(cmbLuck.SelectedItem);
                cmbPerception.Items.Remove(cmbLuck.SelectedItem);
                cmbIntelligence.Items.Remove(cmbLuck.SelectedItem);
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            name = txtName.Text;
        }

        private void btnConfirmCharacter_Click(object sender, EventArgs e)
        {
            Scene_1 n = new Scene_1();
            n.Show();
            this.Hide();
        }
    }
}
