using CatApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatApp.Forms
{
    public partial class CatFactsForm : Form
    {
        private API factsAPI = new API("https://meowfacts.herokuapp.com/?lang=por-br");
        public CatFactsForm()
        {
            InitializeComponent();

        }
        private void btnGetCatFacts_Click_1(object sender, EventArgs e)
        {
            richTextBoxCatFacts.Clear();
            factsAPI.apiGetString(richTextBoxCatFacts);
        }
    }
}
