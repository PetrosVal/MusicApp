using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player
{
    class SortArray
    {
        Form1 ParentForm = null;

        public SortArray(Form1 callingForm)
        {
            ParentForm = callingForm as Form1;
        }

        public void SortIt(int[,]array)
        {
            for(int i = 0; i < 48; i++)
            {//sort Depends on how many times a song has been played
                if(array[i,1] < array[i + 1,1])
                {   int k1 = array[i + 1, 0];
                    int k2 = array[i + 1, 1];
                    int k3 = array[i + 1, 2];

                    int l1 = array[i, 0];
                    int l2 = array[i, 1];
                    int l3 = array[i, 2];

                    array[i, 0] = k1;
                    array[i, 1] = k2;
                    array[i, 2] = k3;

                    array[i + 1, 0] = l1;
                    array[i + 1, 1] = l2;
                    array[i + 1, 2] = l3;
                }
            }

            for (int i = 0; i < 48; i++)
            {//sort Depends on how many seconds a song has been played
                if (array[i, 0] < array[i + 1, 0])
                {
                    int k1 = array[i + 1, 0];
                    int k2 = array[i + 1, 1];
                    int k3 = array[i + 1, 2];

                    int l1 = array[i, 0];
                    int l2 = array[i, 1];
                    int l3 = array[i, 2];

                    array[i, 0] = k1;
                    array[i, 1] = k2;
                    array[i, 2] = k3;

                    array[i + 1, 0] = l1;
                    array[i + 1, 1] = l2;
                    array[i + 1, 2] = l3;
                }
            }

            for (int i = 0; i < 48; i++)
            { //send the info to the array that belongs to form1
                array[i, 0] = ParentForm.playedSecs_times[i, 0];
                array[i, 1] = ParentForm.playedSecs_times[i, 1];
                array[i, 2] = ParentForm.playedSecs_times[i, 2];
            }
        }
    }
}
