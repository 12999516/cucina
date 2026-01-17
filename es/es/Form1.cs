using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es
{
    public partial class Form1 : Form
    {
        SemaphoreSlim sem;
        List<(string nome_piatto, int tempo_di_cottura)> piatti_cuoco_1;
        List<(string nome_piatto, int tempo_di_cottura)> piatti_cuoco_2;
        List<(string nome_piatto, int tempo_di_cottura)> piatti_cuoco_3;
        List<Ccuoco> cuochi;

        public Form1()
        {
            InitializeComponent();
            cuochi = new List<Ccuoco>();
            sem = new SemaphoreSlim(1, 1);
            piatti_cuoco_1 = new List<(string nome_piatto, int tempo_di_cottura)>();
            piatti_cuoco_2 = new List<(string nome_piatto, int tempo_di_cottura)>();
            piatti_cuoco_3 = new List<(string nome_piatto, int tempo_di_cottura)>();

            cuochi.Add(new Ccuoco("giacomo", piatti_cuoco_1, sem));
            cuochi.Add(new Ccuoco("alberto", piatti_cuoco_2, sem));
            cuochi.Add(new Ccuoco("luca", piatti_cuoco_3, sem));
            cuochi[0].notifica += onmostra;
            cuochi[1].notifica += onmostra;
            cuochi[2].notifica += onmostra;
            cmb_cuoco.DataSource = cuochi;
        }

        private void onmostra(object sender, string e)
        {
            lst_messaggi.Items.Add(e);
            lst_messaggi.TopIndex = lst_messaggi.Items.Count - 1;
        }

        private void btn_conferma_Click(object sender, EventArgs e)
        {
            string nome_piatto = txt_piatto.Text;
            int tempo_di_cottura = (int)nmr_secondi.Value * 1000;
            string nome_cuoco = cmb_cuoco.SelectedItem.ToString();

            switch(nome_cuoco)
            {
                case "giacomo":
                    piatti_cuoco_1.Add((nome_piatto, tempo_di_cottura));
                    break;
                case "alberto":
                    piatti_cuoco_2.Add((nome_piatto, tempo_di_cottura));
                    break;
                case "luca":
                    piatti_cuoco_3.Add((nome_piatto, tempo_di_cottura));
                    break;
            }
            txt_piatto.Clear();
            nmr_secondi.Value = 0;
        }

        private async void btn_prep_Click(object sender, EventArgs e)
        {
            Task[] task_cuochi = new Task[3];

            task_cuochi[0] = cuochi[0].cucina();
            task_cuochi[1] = cuochi[1].cucina();
            task_cuochi[2] = cuochi[2].cucina();

            await Task.WhenAll(task_cuochi);
            MessageBox.Show("Tutti i cuochi hanno finito di preparare i piatti");
        }
    }
}
