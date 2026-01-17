using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace es
{
    internal class Ccuoco
    {
        public string nome;
        private SemaphoreSlim sem;
        List<(string nomepiatto, int tempodipreparazione)> piatti;

        public event EventHandler<string> notifica;

        public Ccuoco() 
        {
        
        }

        public Ccuoco(string nome, List<(string nomepiatto, int tempodipreparazione)> piatti, SemaphoreSlim sem)
        {
            this.nome = nome;
            this.piatti = piatti;
            this.sem = sem;
        }

        public async Task prendi_piano_cottura()
        {
            notifica?.Invoke(this, $"{nome} sta chiedendo il piano cottura");
            await sem.WaitAsync();
            notifica?.Invoke(this, $"{nome} ha ottenuto il piano cottura");
        }

        public async Task prepara_piatto()
        {
            notifica?.Invoke(this, $"{nome} sta preparando il piatto {piatti[0].nomepiatto}");
            await Task.Delay(piatti[0].tempodipreparazione);
            notifica?.Invoke(this, $"{nome} ha finito di preparare il piatto {piatti[0].nomepiatto} con tempo di preparazione di {piatti[0].tempodipreparazione}");
            piatti.RemoveAt(0);
        }

        private void libera_piano_cottura()
        {
            Thread.Sleep(1500);
            sem.Release();
            notifica?.Invoke(this, $"{nome} ha liberato il piano cottura");
        }

        public async Task cucina()
        {
            if(piatti.Count <= 0)
            {
                notifica?.Invoke(this, $"{nome} non ha piatti da preparare");
                return;
            }

            while (piatti.Count > 0)
            {
                await prendi_piano_cottura();
                await prepara_piatto();
                libera_piano_cottura();
            }
            return;
        }

        public override string ToString()
        {
            return nome;
        }

    }
}
