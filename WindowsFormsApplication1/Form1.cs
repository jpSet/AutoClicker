using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        //constantes Mouse Event
        const int MOUSEEVENTF_LEFTDOWN = 2;
        const int MOUSEEVENTF_LEFTUP = 4;
        const int MOUSEEVENTF_RIGHTDOWN = 8;
        const int MOUSEEVENTF_RIGHT_UP = 16;

        const int SISTEMAS = 499;
        const int GALAXIAS = 10;
        public int restoSistemas = 0;
        public int nClicks = 495;
        public int nGalaxias = 0;
        public int vGalaxias = 0;





        //input type constant
        const int INPUT_MOUSE = 0;

        [DllImport("User32.dll", SetLastError = true)]
        public static extern int SendInput(int nInputs, ref INPUT pInputs, int cbSize);

        Point clickLocationP1;
        Point clickLocationP2;
        Point clickLocationP3;
        Point clickLocationP4;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rb_Galaxia.Select();
            PopulateComboTempo();
            PopulateComboGalaxias();
        }

        private void btn_Pos1_Click(object sender, EventArgs e)
        {
            timerPoint1.Interval = 5000;
            timerPoint1.Start();
            
        }

        private void btn_Pos2_Click(object sender, EventArgs e)
        {
            timerPoint2.Interval = 5000;
            timerPoint2.Start();
        }

        private void timerPoint1_Tick(object sender, EventArgs e)
        {
            clickLocationP1 = Cursor.Position;
            lbl_avancaSS.Text = clickLocationP1.ToString();
            timerPoint1.Stop();
        }

        private void timerPoint2_Tick(object sender, EventArgs e)
        {
            clickLocationP2 = Cursor.Position;
            lbl_avancaGalax.Text = clickLocationP2.ToString();
            timerPoint2.Stop();
        }

        public struct MOUSEINPUT
        {
            public int dx;
            public int dy;
            public int mouseData;
            public int dwFlags;
            public int time;
            public IntPtr dwExtraInfo;
        }

        public struct INPUT
        {
            public uint type;
            public MOUSEINPUT mi;
        };

        private void btn_Start_Click(object sender, EventArgs e)
        {
            restoSistemas = 0;
            nClicks = 0;
            nGalaxias = cb_actualizaGalax.SelectedIndex + 1;

            int iInterval = RetornaComboTempo();
            if (rb_Galaxia.Checked == true)
            {

                if (btn_Start.Text == "AutoClick")
                {
                    btn_Start.Text = "STOP";
                    timerAvancaSS.Interval = iInterval;
                    timerAvancaSS.Start();
                }
                else
                {
                    
                    btn_Start.Text = "AutoClick";
                    timerAvancaSS.Stop();
                    timerRecuaSS.Stop();
                    timerAvancaGalaxia.Stop();
                }
            }
            else
            {
                if(btn_Start.Text == "AutoClick")
                {
                    timerAvancaSS.Interval = iInterval;
                    timerAvancaSS.Start();
                    btn_Start.Text = "STOP";

                    
                    
                }
                else
                {
                    btn_Start.Text = "AutoClick";
                    timerAvancaSS.Stop();
                    timerRecuaSS.Stop();
                    timerAvancaGalaxia.Stop();
                }
             }
        }

        

        

        private void btn_stop_Click(object sender, EventArgs e)
        {
            timerAvancaGalaxia.Stop();
            timerAvancaSS.Stop();
            timerRecuaSS.Stop();
        }

        private void rb_Galaxia_CheckedChanged(object sender, EventArgs e)
        {
            btn_Pos2.Enabled = false;
            btn_pos3.Enabled = false;
            btn_pos4.Enabled = false;
            lbl_avancaGalax.Enabled = false;
            lbl_posBtnVer.Enabled = false;
            lbl_recuaSS.Enabled = false;
            lbl_actualizaGalax.Enabled = false;
            cb_actualizaGalax.Enabled = false;
        }

        private void rb_Universo_CheckedChanged(object sender, EventArgs e)
        {
            btn_Pos2.Enabled = true;
            btn_pos3.Enabled = true;
            btn_pos4.Enabled = true;
            lbl_avancaGalax.Enabled = true;
            lbl_posBtnVer.Enabled = true;
            lbl_recuaSS.Enabled = true;
            lbl_actualizaGalax.Enabled = true;

            cb_actualizaGalax.Enabled = true;
        }

        // preencher combo segundos
        void PopulateComboTempo()
        {
            for (int n = 1; n < 11; n++)
            {
                cb_clickTempo.Items.Add(n + " Sec");
            }

            cb_clickTempo.SelectedIndex = 4;
        }

        void PopulateComboGalaxias()
        {
            for (int n = 1; n < 11; n++)
            {
                cb_actualizaGalax.Items.Add(n);
            }

            cb_actualizaGalax.SelectedIndex = 1;
        }

        // utiliza o índice da combo para calculo dos milisegundos
        int RetornaComboTempo()
        {
            int itemSelected = 0;

            itemSelected = ((int)cb_clickTempo.SelectedIndex + 1) * 1000;

            return itemSelected;
        }

        private void timePoint3_Tick(object sender, EventArgs e)
        {
            clickLocationP3 = Cursor.Position;
            lbl_posBtnVer.Text = clickLocationP3.ToString();
            timePoint3.Stop();
        }

        private void timerPoint4_Tick(object sender, EventArgs e)
        {
            clickLocationP4 = Cursor.Position;
            lbl_recuaSS.Text = clickLocationP4.ToString();
            timerPoint4.Stop();
        }

        private void cb_actualizaGalax_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_pos3_Click(object sender, EventArgs e)
        {
            timePoint3.Interval = 5000;
            timePoint3.Start();
        }

        private void btn_pos4_Click(object sender, EventArgs e)
        {
            timerPoint4.Interval = 5000;
            timerPoint4.Start();
        }

   
        private void timerAvancaSS_Tick(object sender, EventArgs e)
        {
            //set cursor position to memorized location
            Cursor.Position = clickLocationP1;
            //set up the INPUT struct and fill it for the mouse down
            INPUT i = new INPUT();
            i.type = INPUT_MOUSE;
            i.mi.dx = 0; //clickLocation.X;
            i.mi.dy = 0; // clickLocation.Y;
            i.mi.dwFlags = MOUSEEVENTF_LEFTDOWN;
            i.mi.dwExtraInfo = IntPtr.Zero;
            i.mi.mouseData = 0;
            i.mi.time = 0;
            //send the input
            SendInput(1, ref i, Marshal.SizeOf(i));
            //set the INPUT for mouse up and send
            i.mi.dwFlags = MOUSEEVENTF_LEFTUP;
            SendInput(1, ref i, Marshal.SizeOf(i));

            nClicks++;

            restoSistemas = SISTEMAS - nClicks;
            //lbl_P1.Text = restoSistemas.ToString();
            lbl_P1.Text = nClicks.ToString();

            if (nClicks == 499)
            {
                timerAvancaSS.Stop();
                int iInterval = RetornaComboTempo();
                timerAvancaGalaxia.Interval = iInterval;
                timerAvancaGalaxia.Start();

            }
        }

        private void timerRecuaSS_Tick(object sender, EventArgs e)
        {
            //set cursor position to memorized location
            Cursor.Position = clickLocationP4;
            //set up the INPUT struct and fill it for the mouse down
            INPUT i = new INPUT();
            i.type = INPUT_MOUSE;
            i.mi.dx = 0; //clickLocation.X;
            i.mi.dy = 0; // clickLocation.Y;
            i.mi.dwFlags = MOUSEEVENTF_LEFTDOWN;
            i.mi.dwExtraInfo = IntPtr.Zero;
            i.mi.mouseData = 0;
            i.mi.time = 0;
            //send the input
            SendInput(1, ref i, Marshal.SizeOf(i));
            //set the INPUT for mouse up and send
            i.mi.dwFlags = MOUSEEVENTF_LEFTUP;
            SendInput(1, ref i, Marshal.SizeOf(i));

            nClicks--;

            restoSistemas = -SISTEMAS + nClicks;
            lbl_P2.Text = nClicks.ToString();

            if (nClicks == 0)
            {
                timerRecuaSS.Stop();
                int iInterval = RetornaComboTempo();
                timerAvancaGalaxia.Interval = iInterval;
                timerAvancaGalaxia.Start();
            }

        }

        private void timerAvancaGalaxia_Tick(object sender, EventArgs e)
        {

            //set cursor position to memorized location
            Cursor.Position = clickLocationP2;
            //set up the INPUT struct and fill it for the mouse down
            INPUT i = new INPUT();
            i.type = INPUT_MOUSE;
            i.mi.dx = 0; //clickLocation.X;
            i.mi.dy = 0; // clickLocation.Y;
            i.mi.dwFlags = MOUSEEVENTF_LEFTDOWN;
            i.mi.dwExtraInfo = IntPtr.Zero;
            i.mi.mouseData = 0;
            i.mi.time = 0;
            //send the input
            SendInput(1, ref i, Marshal.SizeOf(i));
            //set the INPUT for mouse up and send
            i.mi.dwFlags = MOUSEEVENTF_LEFTUP;
            SendInput(1, ref i, Marshal.SizeOf(i));

            vGalaxias++;

           int iInterval = RetornaComboTempo();

            if (vGalaxias == nGalaxias)
            {
                timerAvancaGalaxia.Stop();
                MessageBox.Show("Parou!!!");
            }
            else if (vGalaxias % 2 != 0)
            {
                timerAvancaGalaxia.Stop();
                timerRecuaSS.Interval = iInterval;
                timerRecuaSS.Start();
            }
            else
            {
                timerAvancaGalaxia.Stop();
                timerAvancaSS.Interval = iInterval;
                timerAvancaSS.Start();
            }
        }




    }
}
