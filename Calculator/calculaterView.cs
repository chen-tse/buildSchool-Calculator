using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    class CalculaterView
    {
        private int _maxWidth;
        private int _maxHeight;

        private Dictionary<string ,Button> _ButtonDict;

        public List<List<string>> SignList { get; set; }
        public Panel ButtonPanel { get; set; }

        public int MaxWidth { get { return _maxWidth; } }
        public int MaxHeight { get { return _maxHeight; } }

        public Dictionary<string ,Button> ButtonDict { get { return _ButtonDict; } }

        public CalculaterView()
        {
            createPanel();
        }

        private void createPanel()
        {
            _ButtonDict = new Dictionary<string ,Button>();
        }
        public void InitPanel()
        {
            ButtonPanel.Controls.Clear();
            for (int i = 0 ; i < SignList.Count ; i++)
            {
                for (int j = 0 ; j < SignList[i].Count ; j++)
                {
                    var b = CreateButton(SignList[i][j] ,i + j ,j ,i);
                    ButtonPanel.Controls.Add(b);
                    _ButtonDict[SignList[i][j]] = b;
                }
            }
            _maxWidth = SignList[0].Count * 90 + 10;
            _maxHeight = SignList.Count * 60 + 10;
        }
        private Button CreateButton(string text ,int no ,int x ,int y)
        {
            Button b = new Button();
            b.BackColor = System.Drawing.Color.Silver;
            b.FlatStyle = FlatStyle.Flat;
            b.Name = $"button{no}";
            b.Size = new System.Drawing.Size(80 ,50);
            b.Location = new System.Drawing.Point(10 + 90 * x ,10 + 60 * y);
            b.Text = text;

            return b;
        }
    }
}
