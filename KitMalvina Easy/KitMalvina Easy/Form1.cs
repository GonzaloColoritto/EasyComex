using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceProcess;

namespace KitMalvina_Easy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Visible = false;

            //string path = "C:\\Archivos de programa (x86)\\KitMaria\\Kit Malvina.exe";
            //string path2 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\prueba.bat";


            //PRECONEXION
            string pathBat = Environment.CurrentDirectory + @"\Conexion.bat";

            Process programaBat = null;

            ProcessStartInfo infoBat = null;

            infoBat = new ProcessStartInfo(pathBat);

            programaBat = Process.Start(infoBat);

            
            //MARIA
            string path = @"C:\Program Files (x86)\KitMaria\Kit Malvina.exe";

            Process programa = null;

            ProcessStartInfo info = null;

            info = new ProcessStartInfo(path);

            programa = Process.Start(info);

            this.Close();
        }
    }
}
