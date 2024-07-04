using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9
{
    public delegate void AccountHandler(string message);

    internal class Account
    {
        private int sum;
        AccountHandler? taken;
        public Account(int s) => this.sum = s;
        public void RegisterHandler(AccountHandler del)
        {
            taken += del;
        }
        public void UnRegisterHandler(AccountHandler del)
        {
            taken -= del;
        }
        public void Add(int sum) { this.sum += sum;
            taken?.Invoke($"Добавлено {sum}.Баланс {this.sum} у.е.");
        }
        public void Take(int sum)
        {
            if (this.sum >= sum)
            {
                this.sum -= sum;
                //Console.WriteLine($"Со счета списано {sum} у.е.");
                taken?.Invoke($"Со счета списано {sum} у.е.Баланс {this.sum} у.е.");
            }
            else
            {
                taken?.Invoke($"Недостаточно средств.Баланс {this.sum} у.е.");
            }
        }
        
    }
}
