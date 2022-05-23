using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceProcess;
using Microsoft.Win32;
using System.Security.Principal;
using System.Diagnostics;
using System.Reflection;

namespace Tratando_Servicos
{
    public partial class Tratando_Servicos : Form
    {
        public Tratando_Servicos()
        {
            InitializeComponent();
            rodarComoAdmin();
        }

        string nomeServico = "";

        private void btnExibir_Click(object sender, EventArgs e)
        {
            //Declarando a classe ServiceController e preenchendo um array com todos os serviços
            //do windows usando o método GetServices()
            ServiceController[] services = ServiceController.GetServices();
            //Criando o cabeçalho com o nome das colunas no ListView
            MontaColunasListView();

            //percorre a relação de serviços e exibe no listview
            foreach (ServiceController service in services)
            {
                try
                {   //cria instância do ListViewItem
                    ListViewItem novoListViewItem = new ListViewItem();

                    //obtendo nome e status do serviço
                    novoListViewItem.Text = service.ServiceName.ToString();
                    novoListViewItem.SubItems.Add(service.Status.ToString());

                    //obtendo detalhes do serviço
                    RegistryKey regKey1 = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\services\\" + service.ServiceName);
                    novoListViewItem.SubItems.Add(regKey1.GetValue("ImagePath").ToString());
                    novoListViewItem.SubItems.Add(regKey1.GetValue("Description").ToString());
                    regKey1.Close();
                    //exibindo as informações
                    lvServicos.Items.Add(novoListViewItem);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        //Monta Coluna no ListView
        private void MontaColunasListView()
        {
            lvServicos.Columns.Add("Nome", 250, HorizontalAlignment.Left);
            lvServicos.Columns.Add("Status", 100, HorizontalAlignment.Left);
            lvServicos.Columns.Add("Localização", 500, HorizontalAlignment.Left);
            lvServicos.Columns.Add("Descrição", 500, HorizontalAlignment.Left);
        }

        private void rodarComoAdmin()
        {
            WindowsPrincipal principal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            bool administrativeMode = principal.IsInRole(WindowsBuiltInRole.Administrator);
            if (!administrativeMode)
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.Verb = "runas";
                startInfo.FileName = Assembly.GetExecutingAssembly().CodeBase;
                try
                {
                    Process.Start(startInfo);
                    MessageBox.Show("Você esta executando o projeto com nível de Administrador !", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    throw new Exception("Não foi possível conceder acesso como Admin" + Environment.NewLine + "As operações realizadas poderão ter Acesso Negado !");
                }
            }
        }

        private void btnPararServico_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nomeServico))
            {
                MessageBox.Show("Informe o nome do serviço", "Nome do Servico", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    DialogResult resultado = MessageBox.Show("Deseja parar o serviço : " + nomeServico + " ?", "Parar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        ServicosWin.ServicosWin.StopService(nomeServico);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message + Environment.NewLine + ex.InnerException, "Parar Serviço", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nomeServico))
            {
                MessageBox.Show("Informe o nome do serviço", "Nome do Servico", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    DialogResult resultado = MessageBox.Show("Deseja iniciar o serviço : " + nomeServico + " ?", "Iniciar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        ServicosWin.ServicosWin.StartService(nomeServico);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message + Environment.NewLine + ex.InnerException, "Iniciar Serviço", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nomeServico))
            {
                MessageBox.Show("Informe o nome do serviço", "Nome do Servico", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    DialogResult resultado = MessageBox.Show("Deseja reiniciar o serviço : " + nomeServico + " ?", "Reiniciar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        ServicosWin.ServicosWin.RestartService(nomeServico);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message + Environment.NewLine + ex.InnerException, "Reiniciar Serviço", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lvServicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                nomeServico = lvServicos.SelectedItems[0].SubItems[0].Text;

            }
            catch
            {
                nomeServico = "";
            }
        }
    }
}
