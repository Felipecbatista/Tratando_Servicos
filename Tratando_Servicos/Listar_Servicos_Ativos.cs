using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Diagnostics;

namespace Tratando_Servicos
{
    public partial class Listar_Servicos_Ativos : Form
    {
        public Listar_Servicos_Ativos()
        {
            InitializeComponent();
        }

        private void btnListarServicos_Click(object sender, EventArgs e)
        {

            ManagementClass management = new ManagementClass("Win32_Process");
            ManagementObjectCollection mCollection = management.GetInstances();
            foreach (ManagementObject process in mCollection)
            {
                ListViewItem novoListViewItem = new ListViewItem();

                novoListViewItem.Text = (process["ProcessId"].ToString());
                novoListViewItem.SubItems.Add((string)process["Name"]);
                novoListViewItem.SubItems.Add((string)process["ExecutablePath"]);

                try
                {
                    FileVersionInfo info = FileVersionInfo.GetVersionInfo((string)process["ExecutablePath"]);
                    novoListViewItem.SubItems.Add(info.FileDescription);
                }
                catch
                {
                    novoListViewItem.SubItems.Add("Não Disponível");
                }

                lvServicosAtivos.Items.Add(novoListViewItem);
            }

        }
    }
}
