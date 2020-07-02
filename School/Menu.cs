using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonStud_Click(object sender, EventArgs e)
        {
            Form formStud = new FormStud();
            formStud.Show();
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            Form formSubjects = new FormSubjects();
            formSubjects.Show();
        }

        private void buttonTeatch_Click(object sender, EventArgs e)
        {
            Form formTeachers = new FormTeachers();
            formTeachers.Show();
        }
    }
}
