using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_Convert_Parse_ToString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ToString Kullanımı
            int sayi1 = 0;
            sayi1.ToString(); // Sayısal ve boolen değerlerini metinsel ifadeye çevirmek için kulanılır.

            // Convert Kullanımı
            string sayi2 = "0";
            Convert.ToInt32(sayi2); // bir nesnenin text özelliğinden gelen değer string tipindedir ve Convert yapısı ile sayısal tipe çevrilebilir.

            // Parse Kullanımı
            string sayi3 = "0";
            int.Parse(sayi3); // bir nesnenin text özelliğinden gelen değer string tipindedir ve Parse yapısı ile sayısal tipe çevrilebilir.

        }
    }
}
