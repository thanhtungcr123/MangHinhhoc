using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MangHinhHoc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HinhVuong[] hinhvuong = null;
        string[] HV = null;
        HinhTron[] hinhtron = null;
        string[] HT = null;
        /*List<HinhTron> hinhtron = null;
        List<string> HT = null;*/
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnHinhvuong_Click(object sender, RoutedEventArgs e)
        {
            lsbHinhvuong.Items.Add("STT" + "\t\t" + "Canh" + "\t\t" + "Chuvi" + "\t\t" + "Dientich");
            int[] Ca = { 3, 4, 5, 6, 7 };
            
            hinhvuong = new HinhVuong[5];
            for (int i = 0; i < hinhvuong.Length; i++)
                hinhvuong[i] = new HinhVuong(Ca[i]);
            HV = new string[5];
            for (int i = 0; i < HV.Length; i++)
                lsbHinhvuong.Items.Add((i + 1).ToString() + "\t\t" + hinhvuong[i].canh.ToString() + "\t\t" + hinhvuong[i].CV().ToString() + "\t\t" + hinhvuong[i].DT().ToString());
            /*HV[i]="\t"+(i+1).ToString()+"\t\t"+hinhvuong[i].canh.ToString()+"\t\t"+hinhvuong[i].CV().ToString()+"\t\t"+hinhvuong[i].DT().ToString();*/

        }

        private void BtnHinhtrong_Click(object sender, RoutedEventArgs e)
        {
            lsbHinhtron.Items.Add("STT" + "\t\t" + "Ban Kinh" + "\t\t" + "Chuvi" + "\t\t" + "Dientich");
            int[] BanKinh = { 4, 5, 6, 7, 8 };
            hinhtron = new HinhTron[5];
            for (int i = 0; i < hinhtron.Length; i++)
                hinhtron[i] = new HinhTron(BanKinh[i]);
            HT = new string[5];
            for (int i = 0; i < HT.Length; i++)
                lsbHinhtron.Items.Add((i + 1).ToString() + "\t\t" + hinhtron[i].bk.ToString() + "\t\t" + hinhtron[i].CV().ToString() + "\t\t" + hinhtron[i].DT().ToString());
            /*HT[i] = "\t" + (i + 1).ToString() + "\t\t" + hinhtron[i].bk.ToString() + "\t\t" + hinhtron[i].CV().ToString() + "\t\t" + hinhtron[i].DT().ToString();*/
            /*int[] BanKinh = { 4, 5, 6, 7, 8 };
            hinhtron = new List<HinhTron>();
            for(int i = 0; i < BanKinh.Length; i++)
            {
                hinhtron.Add(new HinhTron(BanKinh[i]));
            }
            HT = new List<string>();
            for (int i = 0; i < hinhtron.Count; i++) 
                HT.Add("\t" + (i + 1).ToString() + "\t\t" + hinhtron[i].bk.ToString() + "\t\t"  +hinhtron[i].CV().ToString() + "\t\t" + hinhtron[i].DT().ToString());
            lsbHinhtron.ItemsSource = HT;*/
            /*lsbHinhvuong.ItemsSource = HV;*/
            /* lsbHinhtron.ItemsSource = HT;*/
        }       
    }
}
