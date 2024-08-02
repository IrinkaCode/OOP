using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson23_DZ_События
{
    public class Keyboard
    {
        public event EventHandler<char> KeyPressed;
        public void SimulateKeyPress(char key)
        {
            OnKeyPressed(key);
        }
        protected virtual void OnKeyPressed(char key)
        {
            KeyPressed?.Invoke(this, key); 
        }
    }
}
