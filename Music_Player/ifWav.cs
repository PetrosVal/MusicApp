using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Music_Player
{
    class ifWav
    {
      public ifWav() {
            
      }

      public void wavFile(string path) {
            MessageBox.Show("The file" + path + "is an .wav file, we recommend you to convert it to to .mp3 because .wav files arent full compatible with this programm");
      }


    }
}
