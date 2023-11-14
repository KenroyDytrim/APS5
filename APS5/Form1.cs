using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace APS5
{
    public partial class Form1 : Form
    {
        Abstraction abstraction;
        public Panel group1;
        public Panel group2;
        public Panel group3;
        public Form1()
        {
            InitializeComponent();
            group1 = panelW;
            group2 = panelL;
            group3 = panelA;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            abstraction = new RefinedAbstraction(new ConcreteImplementorWindows());
        }

        private void Create_Click(object sender, EventArgs e)
        {
            switch (Platform.SelectedIndex)
            {
                case 0:
                    abstraction.IImplementation = new ConcreteImplementorWindows();
                    break;
                case 1:
                    abstraction.IImplementation = new ConcreteImplementorLinux();
                    break;
                case 2:
                    abstraction.IImplementation = new ConcreteImplementorAndroid();
                    break;
            }
            switch (CopBox.SelectedItem)
            {
                case "Кнопка":
                    abstraction.CreateButton(this, textName.Text);
                    break;
                case "Надпись":
                    abstraction.CreateWindow(this, textName.Text);
                    break;
            }
        }

        private void panelW_DoubleClick(object sender, EventArgs e)
        {
            listObjects.Items.Clear();
            for(int i=0; i<panelW.Controls.Count; i++)
                listObjects.Items.Add(panelW.Controls[i].Name);
        }

        private void panelL_DoubleClick(object sender, EventArgs e)
        {
            listObjects.Items.Clear();
            for (int i = 0; i < panelL.Controls.Count; i++)
                listObjects.Items.Add(panelL.Controls[i].Name);
        }

        private void panelA_DoubleClick(object sender, EventArgs e)
        {
            listObjects.Items.Clear();
            for (int i = 0; i < panelA.Controls.Count; i++)
                listObjects.Items.Add(panelA.Controls[i].Name);
        }

        private void listObjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(Platform.Text)
            {
                case "Windows":
                    int index1 = panelW.Controls.IndexOfKey(listObjects.Text);
                    if (index1 != -1)
                    {
                        textD1.Text = panelW.Controls[index1].Name;
                        textD2.Text = panelW.Controls[index1].Text;
                        textD3.Text = panelW.Controls[index1].Location.X.ToString();
                        textD4.Text = panelW.Controls[index1].Location.Y.ToString();
                    }
                    break;
                case "Linux":
                    int index2 = panelL.Controls.IndexOfKey(listObjects.Text);
                    if (index2 != -1)
                    {
                        textD1.Text = panelL.Controls[index2].Name;
                        textD2.Text = panelL.Controls[index2].Text;
                        textD3.Text = panelL.Controls[index2].Location.X.ToString();
                        textD4.Text = panelL.Controls[index2].Location.Y.ToString();
                    }
                    break;
                case "Android":
                    int index3 = panelA.Controls.IndexOfKey(listObjects.Text);
                    if (index3 != -1)
                    {
                        textD1.Text = panelA.Controls[index3].Name;
                        textD2.Text = panelA.Controls[index3].Text;
                        textD3.Text = panelA.Controls[index3].Location.X.ToString();
                        textD4.Text = panelA.Controls[index3].Location.Y.ToString();
                    }
                    break;
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            switch (Platform.Text)
            {
                case "Windows":
                    int index1 = panelW.Controls.IndexOfKey(listObjects.Text);
                    if (index1 != -1)
                    {
                        panelW.Controls[index1].Name=textD1.Text;
                        panelW.Controls[index1].Text = textD2.Text;
                        panelW.Controls[index1].Location = new Point(Convert.ToInt32(textD3.Text), Convert.ToInt32(textD4.Text));
                    }
                    break;
                case "Linux":
                    int index2 = panelL.Controls.IndexOfKey(listObjects.Text);
                    if (index2 != -1)
                    {
                        panelL.Controls[index2].Name = textD1.Text;
                        panelL.Controls[index2].Text = textD2.Text;
                        panelL.Controls[index2].Location = new Point(Convert.ToInt32(textD3.Text), Convert.ToInt32(textD4.Text));
                    }
                    break;
                case "Android":
                    int index3 = panelA.Controls.IndexOfKey(listObjects.Text);
                    if (index3 != -1)
                    {
                        panelA.Controls[index3].Name = textD1.Text;
                        panelA.Controls[index3].Text = textD2.Text;
                        panelA.Controls[index3].Location = new Point(Convert.ToInt32(textD3.Text), Convert.ToInt32(textD4.Text));
                    }
                    break;
            }
        }
    }
}
