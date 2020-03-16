using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 :Form
    {
        CalculaterView _calculaterView;
        public Form1()
        {
            InitializeComponent();

            _calculaterView = new CalculaterView()
            {
                ButtonPanel = this.button_panel ,
                SignList = CreateSignList()
            };
            _calculaterView.InitPanel();

            this.button_panel.Width = _calculaterView.MaxWidth;
            this.button_panel.Height = _calculaterView.MaxHeight;
            this.display_textBox.Width = _calculaterView.MaxWidth;
            this.Width = _calculaterView.MaxWidth + 50;
            this.Height = _calculaterView.MaxHeight + 190;

            _calculaterView.ButtonDict["AC"].Click += Test_Click;
            _calculaterView.ButtonDict["+"].Click += add;
            _calculaterView.ButtonDict["-"].Click += less;
            _calculaterView.ButtonDict["x"].Click += mul;
            _calculaterView.ButtonDict["÷"].Click += div;
            _calculaterView.ButtonDict["%"].Click += remainder;
            CreateSimpleButton();
        }

        private void add(object sender, EventArgs e)
        {
            var c = new Class1()
            {
                 input1 = 10,
                 input2 = 17
            };
            
            this.display_textBox.Text = $"add: {c.add()}";
        }
        private void less(object sender, EventArgs e)
        {
            var c = new Class1()
            {
                input1 = 10,
                input2 = 17
            };

            this.display_textBox.Text = $"less: {c.less()}";
        }
        private void mul(object sender, EventArgs e)
        {
            var c = new Class1()
            {
                input1 = 10,
                input2 = 17
            };

            this.display_textBox.Text = $"mul: {c.mul()}";
        }
        private void div(object sender, EventArgs e)
        {
            var c = new Class1()
            {
                input1 = 10,
                input2 = 20
            };

            this.display_textBox.Text = $"div: {c.div()}";
        }
        private void remainder(object sender, EventArgs e)
        {
            var c = new Class1()
            {
                input1 = 10,
                input2 = 3
            };

            this.display_textBox.Text = $"remainder: {c.remainder()}";
        }

        private List<List<string>> CreateSignList()
        {
            List<List<string>> list = new List<List<string>>()
            {
                new List<string>(){"Rad" ,"Deg" ,"X!" ,"(" ,")" ,"%" ,"AC"},
                new List<string>(){"INV" ,"sin" ,"ln" ,"7" ,"8" ,"9" ,"÷"},
                new List<string>(){"PI" ,"cos" ,"log" ,"4" ,"5" ,"6" ,"x"},
                new List<string>(){"e" ,"tan" ,"√" ,"1" ,"2" ,"3" ,"-"},
                new List<string>(){"Ans" ,"EXP" ,"X^y" ,"0" ,"." ,"=" ,"+"}
            };
            return list;
        }
        private void CreateSimpleButton()
        {
            int t;
            foreach (var item in _calculaterView.ButtonDict)
            {
                if (int.TryParse(item.Key ,out t))
                {
                    item.Value.Click += Display_click;
                }
            }
        }


        private void Test_Click(object sender ,EventArgs e)
        {
            this.display_textBox.Text = "this is a tset!!!";
        }
        private void Display_click(object sender ,EventArgs e)
        {
            this.display_textBox.Text += $" {((Button)sender).Text} ";
        }
    }
}
