using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APS5
{
    abstract class Abstraction
    {
        protected IImplementation _implementation;
        public IImplementation IImplementation
        {
            set { _implementation = value; }
        }
        public Abstraction(IImplementation implementation)
        {
            this._implementation = implementation;
        }
        public virtual void CreateButton(Form1 form, string text)
        {
            _implementation.CreateButtonImp(form, text);
        }
        public virtual void CreateWindow(Form1 form, string text)
        {
            _implementation.CreateWindowImp(form, text);
        }
    }
    public interface IImplementation
    {
        void CreateWindowImp(Form1 form, string text);
        void CreateButtonImp(Form1 form, string text);
        
    }
    class RefinedAbstraction : Abstraction
    {
        public RefinedAbstraction(IImplementation imp): base(imp){}       
    }

    class ConcreteImplementorWindows : IImplementation
    {
        private void ButtonOnClick(object sender, EventArgs eventArgs)
        {
            var button = (Button)sender;
            if (button != null)
            {
                MessageBox.Show("Прощай " + button.Name);
                button.Dispose();
            }
        }
        private Point mouseOffset;
        private bool isMouseDown = false;

        private void _MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset;
            int yOffset;

            if (e.Button == MouseButtons.Left)
            {
                xOffset =- e.X - Control.MousePosition.X+60;

                yOffset =- e.Y - Control.MousePosition.Y+70;

                mouseOffset = new Point(xOffset, yOffset);
                isMouseDown = true;
            }
        }

        private void _MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                (sender as Control).Location = mousePos;
            }
        }

        private void _MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }
        public void CreateWindowImp(Form1 form, string text)
        {
            var box = form.group1;

            int top = 10;
            int left = 10;
            int i = box.Controls.Count + 1;

            Label label = new Label();
            label.Left = left;
            label.Top = top + (label.Height * i);
            label.Name = "Надпись" + i;
            if (text == "")
            {
                text = "Пусто";
            }
            label.Text = text;
            box.Controls.Add(label);
        }
        public void CreateButtonImp(Form1 form, string text)
        {

            var box = form.group1;

            int top = 10;
            int left = 10;
            int i = box.Controls.Count+1;

            Button button = new Button();
            button.Left = left;
            button.Top = top + (button.Height * i);
            button.Name = "Кнопка"+i;
            if (text == "")
            {
                text = "Пусто";
            }
            button.Text = text;
            button.BackColor = Color.FromArgb(255, 63, 108);
            button.Click += ButtonOnClick;
            button.MouseDown += _MouseDown;
            button.MouseMove += _MouseMove;
            button.MouseUp += _MouseUp;
            box.Controls.Add(button);
        }
    }
    class ConcreteImplementorLinux : IImplementation
    {
        private void ButtonOnClick(object sender, EventArgs eventArgs)
        {
            var button = (Button)sender;
            if (button != null)
            {
                MessageBox.Show("Прощай " + button.Name);
                button.Dispose();
            }
        }
        private Point mouseOffset;
        private bool isMouseDown = false;

        private void _MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset;
            int yOffset;

            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X - Control.MousePosition.X + 60;

                yOffset = -e.Y - Control.MousePosition.Y + 70;

                mouseOffset = new Point(xOffset, yOffset);
                isMouseDown = true;
            }
        }

        private void _MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                (sender as Control).Location = mousePos;
            }
        }

        private void _MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }
        public void CreateWindowImp(Form1 form, string text)
        {
            var box = form.group2;

            int top = 10;
            int left = 10;
            int i = box.Controls.Count + 1;

            Label label = new Label();
            label.Left = left;
            label.Top = top + (label.Height * i);
            label.Name = "Надпись" + i;
            if (text == "")
            {
                text = "Пусто";
            }
            label.Text = text;
            box.Controls.Add(label);
        }
        public void CreateButtonImp(Form1 form, string text)
        {

            var box = form.group2;

            int top = 10;
            int left = 10;
            int i = box.Controls.Count + 1;

            Button button = new Button();
            button.Left = left;
            button.Top = top + (button.Height * i);
            button.Name = "Кнопка" + i;
            if (text == "")
            {
                text = "Пусто";
            }
            button.Text = text;
            button.BackColor = Color.FromArgb(255, 63, 108);
            button.Click += ButtonOnClick;
            button.MouseDown += _MouseDown;
            button.MouseMove += _MouseMove;
            button.MouseUp += _MouseUp;
            box.Controls.Add(button);
        }
    }
    class ConcreteImplementorAndroid : IImplementation
    {
        private void ButtonOnClick(object sender, EventArgs eventArgs)
        {
            var button = (Button)sender;
            if (button != null)
            {
                MessageBox.Show("Прощай " + button.Name);
                button.Dispose();
            }
        }
        private Point mouseOffset;
        private bool isMouseDown = false;

        private void _MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset;
            int yOffset;

            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X - Control.MousePosition.X + 60;

                yOffset = -e.Y - Control.MousePosition.Y + 70;

                mouseOffset = new Point(xOffset, yOffset);
                isMouseDown = true;
            }
        }

        private void _MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                (sender as Control).Location = mousePos;
            }
        }

        private void _MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }
        public void CreateWindowImp(Form1 form, string text)
        {
            var box = form.group3;

            int top = 10;
            int left = 10;
            int i = box.Controls.Count + 1;

            Label label = new Label();
            label.Left = left;
            label.Top = top + (label.Height * i);
            label.Name = "Надпись" + i;
            if (text == "")
            {
                text = "Пусто";
            }
            label.Text = text;
            box.Controls.Add(label);
        }
        public void CreateButtonImp(Form1 form, string text)
        {
            var box = form.group3;

            int top = 10;
            int left = 10;
            int i = box.Controls.Count + 1;

            Button button = new Button();
            button.Left = left;
            button.Top = top + (button.Height * i);
            button.Name = "Кнопка" + i;
            if (text == "")
            {
                text = "Пусто";
            }
            button.Text = text;
            button.BackColor = Color.FromArgb(255, 63, 108);
            button.Click += ButtonOnClick;
            button.MouseDown += _MouseDown;
            button.MouseMove += _MouseMove;
            button.MouseUp += _MouseUp;
            box.Controls.Add(button);
        }
    }
}
