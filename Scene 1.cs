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
   
    
    public partial class Scene_1 : Form
    {
        string str;
        string per;
        string intel;
        string luck;
        string gender;
        string name;
        public Scene_1()
        {
            InitializeComponent();
        }

        private void Scene_1_Load(object sender, EventArgs e)
        {
            lblStrength.Text = "Strength: " + str;
            lblPerception.Text = "Perception: " + per;
            lblIntelligence.Text = "Intelligence: " + intel;
            lblLuck.Text = "Luck: " + luck;
            //picture
            lblName.Text = "Name:" + name;
        }
    }
}
