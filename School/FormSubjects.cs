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
    public partial class FormSubjects : Form
    {
        public FormSubjects()
        {
            InitializeComponent();
            ShowSubjects();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Subjects subjectsSet = new Subjects();
            subjectsSet.Name = textBoxN.Text;
            Program.abc.Subjects.Add(subjectsSet);
            Program.abc.SaveChanges();
            ShowSubjects();
        }
        void ShowSubjects()
        {
            listViewSub.Items.Clear();
            foreach (Subjects subjectsSet in Program.abc.Subjects)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    subjectsSet.Id.ToString(), subjectsSet.Name
                });
                item.Tag = subjectsSet;
                listViewSub.Items.Add(item);
            }
            listViewSub.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listViewSub_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSub.SelectedItems.Count == 1)
            {
                Subjects subjectsSet = listViewSub.SelectedItems[0].Tag as Subjects;
                textBoxN.Text = subjectsSet.Name;
            }
            else
            {
                textBoxN.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewSub.SelectedItems.Count == 1)
                {
                    Subjects subjectsSet = listViewSub.SelectedItems[0].Tag as Subjects;
                    Program.abc.Subjects.Remove(subjectsSet);
                    Program.abc.SaveChanges();
                    ShowSubjects();
                }
                textBoxN.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
    }

