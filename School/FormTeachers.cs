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
    public partial class FormTeachers : Form
    {
        public FormTeachers()
        {
            InitializeComponent();
            ShowTeatchrs();
            ShowSubjects();
        }

        void ShowSubjects()
        {
            comboBoxSub.Items.Clear();
            foreach (Subjects subjectsSet in Program.abc.Subjects)
            {
                string[] item = { subjectsSet.Id.ToString() + ".", subjectsSet.Name };
                comboBoxSub.Items.Add(string.Join(" ", item));
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxSub.SelectedItem != null && textBoxS.Text != "" && textBoxN.Text != "" && textBoxM.Text != "" && textBoxP.Text != "")
            {
                Teachers teachersSet = new Teachers();
                teachersSet.Surname = textBoxS.Text;
                teachersSet.Name = textBoxN.Text;
                teachersSet.Middlename = textBoxM.Text;
                teachersSet.Phone = textBoxP.Text;
                teachersSet.IdSub = Convert.ToInt32(comboBoxSub.SelectedItem.ToString().Split(':')[0]);
                Program.abc.Teachers.Add(teachersSet);
                Program.abc.SaveChanges();
                ShowTeatchrs();
            }
        }
        void ShowTeatchrs()
        {
            listViewTeach.Items.Clear();
            foreach (Teachers teachersSet in Program.abc.Teachers)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    teachersSet.Id.ToString(), teachersSet.Surname, teachersSet.Name, teachersSet.Middlename, teachersSet.Phone, teachersSet.Subjects.Name
                });
                item.Tag = teachersSet;
                listViewTeach.Items.Add(item);
                listViewTeach.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            
        }
    }
}
