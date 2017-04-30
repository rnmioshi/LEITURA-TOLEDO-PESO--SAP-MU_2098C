using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Configuration;

namespace WindowsFormsApplication1
{
    public partial class PESO : Form
    {

        string RxString;

		// Get a handle to an application window.
        [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(string lpClassName,string lpWindowName);

        // Activate an application window.
        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);        
        
        public PESO()
        {
            InitializeComponent();
            
            serialPort1.PortName = ConfigurationManager.AppSettings["PortaSerial"];  //"COM6";
            serialPort1.BaudRate = 4800;
            serialPort1.DataBits = 8;
            serialPort1.DtrEnable = true;
            serialPort1.StopBits =  StopBits.One;
            serialPort1.DataBits = 7;
            serialPort1.NewLine =  "vbCr";
            serialPort1.ReadTimeout = 500;
            serialPort1.WriteTimeout = 500;
        }


        private void Inicio_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            if (serialPort1.IsOpen)
            {
                Inicio.Enabled = false;
                Parar.Enabled = true;
                transferir.Enabled = true;
            }

        }

        private void Parar_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                
                Inicio.Enabled = true;
                Parar.Enabled = false;
                transferir.Enabled = false;
                RxString = "Sem Leitura";
        		this.Invoke(new EventHandler(DisplayText));
        		
            }
        }

        private void Saida_Tela_TextChanged(object sender, KeyPressEventArgs e)
        {

            if (!serialPort1.IsOpen) return;

            // If the port is Open, declare a char[] array with one element.
            char[] buff = new char[1];

            // Load element 0 with the key character.

            buff[0] = e.KeyChar;

            // Send the one character buffer.
            serialPort1.Write(buff, 0, 1);

            // Set the KeyPress event as handled so the character won't
            // display locally. If you want it to display, omit the next line.
            e.Handled = true;
  
        }

        private void serialPort1_DataReceived  (object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
			RxString = serialPort1.ReadExisting();
        	RxString = serialPort1.ReadTo("\x0D");
        	RxString = RxString.Replace("\x02","");
        	RxString = RxString.Replace("00.","0.");
        	RxString = RxString.Replace(".",",");
       		this.Invoke(new EventHandler(DisplayText));
        }

        private void DisplayText(object sender, EventArgs e)
        {
			Saida_Tela.Text = RxString; 
        }
        private void Fechar_Tela(object sender, FormClosedEventArgs e)
        {
        	if (serialPort1.IsOpen) {
        		serialPort1.Close();
        	}
        }

        
        void Button1Click(object sender, EventArgs e)
        {
        	Process currentProcess = Process.GetCurrentProcess();
			Process[] processes = Process.GetProcessesByName("saplogon");
			foreach (Process p in processes)
		    {
				IntPtr pFoundWindow = p.MainWindowHandle;
				SetForegroundWindow(pFoundWindow);
				SendKeys.SendWait(RxString);
			}
        }
        
        void PESOLoad(object sender, EventArgs e)
        {
        	if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                Inicio.Enabled = true;
                Parar.Enabled = false;
            }
        }
        
        void Saida_TelaClick(object sender, EventArgs e)
        {
        	if (serialPort1.IsOpen) {
        		serialPort1.Close();
       		
        	}
        }
    }
}
