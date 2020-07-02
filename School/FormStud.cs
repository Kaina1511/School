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
    public partial class FormStud : Form
    {
        public FormStud()
        {
            InitializeComponent();
            ShowStudents();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Students studentsSet = new Students();
            studentsSet.Surname = textBoxS.Text;
            studentsSet.Name = textBoxN.Text;
            studentsSet.Middlename = textBoxM.Text;
            studentsSet.Class = textBoxC.Text;
            Program.abc.Students.Add(studentsSet);
            Program.abc.SaveChanges();
            ShowStudents();
        }
        void ShowStudents()
        {
            listViewStud.Items.Clear();
            foreach (Students studentsSet in Program.abc.Students)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    studentsSet.Id.ToString(), studentsSet.Surname, studentsSet.Name, studentsSet.Middlename, studentsSet.Class
                });
                item.Tag = studentsSet;
                listViewStud.Items.Add(item);
            }
            listViewStud.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewStud.SelectedItems.Count == 1)
            {
                Students studentsSet = listViewStud.SelectedItems[0].Tag as Students;
                studentsSet.Surname = textBoxS.Text;
                studentsSet.Name = textBoxN.Text;
                studentsSet.Middlename = textBoxM.Text;
                studentsSet.Class = textBoxC.Text;
                Program.abc.SaveChanges();
                ShowStudents();
            }
        }
        private void listViewStud_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewStud.SelectedItems.Count == 1)
            {
                Students studentsSet = listViewStud.SelectedItems[0].Tag as Students;
                textBoxS.Text = studentsSet.Surname;
                textBoxN.Text = studentsSet.Name;
                textBoxM.Text = studentsSet.Middlename;
                textBoxC.Text = studentsSet.Class;
            }
            else
            {
                textBoxS.Text = "";
                textBoxN.Text = "";
                textBoxM.Text = "";
                textBoxC.Text = "";
            }
        }
        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewStud.SelectedItems.Count == 1)
                {
                    Students studentsSet = listViewStud.SelectedItems[0].Tag as Students;
                    Program.abc.Students.Remove(studentsSet);
                    Program.abc.SaveChanges();
                    ShowStudents();
                }
                textBoxS.Text = "";
                textBoxN.Text = "";
                textBoxM.Text = "";
                textBoxC.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
