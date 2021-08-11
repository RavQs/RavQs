using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zmeika
{
    public partial class Form1 : Form
    {
       
        int _width = 900;
        int _Height = 800;
        int _sideofsizes = 40;
        public Form1()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(OKP);
            this.Height = _Height;
            this.Width = _width;
            _generatemap();
        }

    private void _generatemap()
        {
            for (int i = 0; i < _width/_sideofsizes;i++)
            {
                PictureBox pic = new PictureBox();
                pic.BackColor = Color.Black; // Цвет панели 
                pic.Location = new Point(0, _sideofsizes * i); // цикл разделения
                pic.Size = new Size(_width - 100, 1);
                this.Controls.Add(pic);
            }

            for (int i = 0; i < _width / _sideofsizes; i++)
            {
                PictureBox pic = new PictureBox();
                pic.BackColor = Color.Black; // Цвет панели 
                pic.Location = new Point(_sideofsizes * i, 0); // цикл разделения
                pic.Size = new Size(1,_width - 100);
                this.Controls.Add(pic);
            }

        } //Создание карты(сетки)
        private void OKP(object sender, KeyEventArgs e) //Класс  на управление кубом
        {
            switch(e.KeyCode.ToString())
            {
                case "D":
                case "Right":
                    cube.Location = new Point(cube.Location.X + _sideofsizes, cube.Location.Y);
                    break;
                case "A":
                case "Left":
                    cube.Location = new Point(cube.Location.X - _sideofsizes, cube.Location.Y);
                    break;
                case "S":
                case "Down":
                    cube.Location = new Point(cube.Location.X , cube.Location.Y + _sideofsizes);
                    break;
                case "W":
                case "Up":
                    cube.Location = new Point(cube.Location.X , cube.Location.Y - _sideofsizes);
                    break;

            }
        }

      
    }
}
