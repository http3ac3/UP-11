using System;
using System.Windows.Forms;

namespace UP_11_GUI
{
    public partial class Form1 : Form
    {
        private int a;
        private int b;

        public Form1()
        {
            InitializeComponent();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(ASideBox.Text, out a) || a <= 0)
            {
                MessageBox.Show("Введите целое положительное число в поле а!", "Ошибка");
                return;
            }
            if (!int.TryParse(BSideBox.Text, out b) || b <= 0)
            {
                MessageBox.Show("Введите целое положительное число в поле b!", "Ошибка");
                return;
            }
            Rectangle rectangle = new Rectangle(a, b);

            rectangle.PrintSides(ASideLabel, BSideLabel);
            PerimeterLabel.Text = rectangle.Perimeter().ToString();
            SquareLabel.Text = rectangle.Square().ToString();
            IsSquareLabel.Text = (rectangle.IsSquare) ? "Да" : "Нет";


        }
    }
    class Rectangle
    {
        private int a;
        private int b;

        public int A
        {
            get => a;
            set => a = value;
        }
        public int B
        {
            get => b;
            set => b = value;
        }
        public bool IsSquare => a == b;

        public Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public void PrintSides(Label aside, Label bside)
        {
            aside.Text = $"{a}";
            bside.Text = $"{b}";
        }

        public int Perimeter() => a * 2 + b * 2;
        public int Square() => a * b;
    }
}
