using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace CHKGVoprosGenerator
{
    public partial class Form1 : Form
    {
        Stack<int> num = new Stack<int>();
        Random random = new Random();
        int[] numb = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32 };

        public Stack<int> Num
        {
            get { return num; }
        }

        public Form1()
        {
            InitializeComponent();
            int randomNumber = random.Next(1, 32);
            numb = ShuffleArray(numb);
            for (int y = 0; y < numb.Length; y++)
            {
                num.Push(numb[y]);
            }
        }


        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (num.Count != 0)
            {
                int number = num.Peek();
            foreach (Vopros vopr in ReadFromDatabase.VoprosFromDatabase(number))
            {
                txtNumber.Text = vopr.Number.ToString();
                txtVopros.Text = vopr.Vopross;
                string name = vopr.PicName;
                if (name != "")
                {
                    PictureBox picture = new PictureBox
                    {
                        Name = name,
                        Size = new Size(930, 288),
                        Image = Image.FromFile(System.IO.Path.GetFullPath("imgForGame/" + name + ".jpg")),
                        SizeMode = PictureBoxSizeMode.CenterImage
                    };
                    picBox.Controls.Clear();
                    picBox.Controls.Add(picture);
                }
                else{
                    PictureBox picture = new PictureBox
                    {
                    Name = "NoPicture",
                    Size = new Size(500, 288),
                    Image = Image.FromFile(System.IO.Path.GetFullPath("pics/noPic.jpg")),
                    SizeMode = PictureBoxSizeMode.CenterImage
                    };
                    picBox.Controls.Clear();
                    picBox.Controls.Add(picture);
                    }
               num.Pop();
               
               }
            }
                else{MessageBox.Show("no more questions");}
    
        }

        public int[] ShuffleArray(int[] array)
        {
            Random r = new Random();
            for (int i = array.Length; i > 0; i--)
            {
                int j = r.Next(i);
                int k = array[j];
                array[j] = array[i - 1];
                array[i - 1] = k;
            }
            return array;
        }
    }
}
