using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//FOR FILES
using System.Windows.Media;//FOR MUSIC

namespace Music_Player

{   // Project -> Add referance -> tick   PresentationFramework,PresantaionCore,WindowBase
    // Package Manager Console -> PM> Install-Package taglib

    public partial class Form1 : Form
    {
        MediaPlayer media = new MediaPlayer(); //Medi obj

        Random r = new Random(); // Random values

        //Variables to keep previous and current r value so its doesnt randomply be the same 2 times in a row

        int rPrev; 

        int rNow;

        public string[] fullFilePaths = new string[50]; //Array of fullpaths of the files
        public string[,] songsInfo = new string[50, 4]; //Array that contais info such as producer name etc. for each song

        string[] files, paths; //Arrays used to add songs in the Songs.listbox         
        string currentSong; //Variable that presents current song playing

        public int[,] playedSecs_times = new int[50,3]; // [count_secs, timesplayed, index of the song in the songs.listbox] | To sort the song to display them in Favorite.listbox
        int count_secs; //Seconds each song has been played
        int timesPlayed = 0; //Times each song has been attempted start playing

        bool isPlaying; // True/False if song is playing or not
        bool randomSelection;  //Random selection ON/OFF
            
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {            
            gif.Enabled = false; //Play the gif only when media is Playing a sound

            songDuration.Enabled = false;

            for (int i = 0; i <= 49; i++)
            {
                playedSecs_times[i, 2] = -1;
            }


            try
            {
                DirectoryInfo dir = new DirectoryInfo(@"Songs"); //Obj points in the folder of the available songs

                FileInfo[] Mp3files = dir.GetFiles("*.mp3"); //RESTRICT MP3/WAV FILES ONLY
                FileInfo[] Wavfiles = dir.GetFiles("*.wav"); //Get the files that have .mp3 or .wav extensio is the DIRECTORY dir
                
                int i = 0;

                foreach (FileInfo songFile in Mp3files) //ADD MP3 FILES TO THE LISTBOX
                {
                    Songs.Items.Add(songFile);
                    fullFilePaths[i] = songFile.FullName; //SAVE THEIR PATHS TO AN ARRAY
                    i++;
                }

                int j = 0;

                foreach (FileInfo songFile in Wavfiles) // ADD WAV FILES TO THE LISTBOX
                {
                    Songs.Items.Add(songFile);
                    fullFilePaths[i+j] = songFile.FullName;
                    j++;
                }

            }
            catch (DirectoryNotFoundException)
            {

                MessageBox.Show("Directory of the available songs is missing or the filepath is false");

                this.Close();
            }

            DirectoryInfo dir1 = new DirectoryInfo(@"Songs");
            //GET THE INFO FOR EACH AVAILABLE SONG
            for (int k = 1; k <= dir1.GetFiles().Length ; k++)
            {
                currentSong = fullFilePaths[k -1]; //Songs.SelectedIndex
                try
                {
                    TagLib.File currFile = TagLib.File.Create(currentSong); //Taglib CLASS TO ACCESS INFO FROM MP3 FILES

                    songsInfo[k - 1, 0] = currFile.Tag.AlbumArtists[0];                 

                    songsInfo[k - 1, 1] = currFile.Tag.Year.ToString();
                   
                    songsInfo[k - 1, 2] = currFile.Tag.Genres[0];
                    
                    songsInfo[k - 1, 3] = "English";
 
                }
                catch (TagLib.CorruptFileException)
                {   //.wav file //else NOT FOUND
                    songsInfo[k - 1, 0] = "SOFI TUKKER";

                    songsInfo[k - 1, 1] = "2016";
                    
                    songsInfo[k - 1, 2] = "House";
                    
                    songsInfo[k - 1, 3] = "English";                  
                }
                catch (IndexOutOfRangeException)
                {
                    //NOT FOUND
                }
            }

            Songs.ClearSelected();

        }

        private void Play_button_Click(object sender, EventArgs e)
        {
            
            if (currentSong == null || Songs.SelectedIndex == -1) // No index selected in the listbox
            {
                isPlaying = false;

                MessageBox.Show("No song selected");
                              
                Play_button.Text = "Play";
            }
            else {

                if (isPlaying)
                {
                    isPlaying = false;
                    gif.Enabled = false;
                    songDuration.Enabled = false;

                    Play_button.Text = "Play";

                    media.Pause();

                    if (!randomSelection)
                    {
                        trackFav.Enabled = false;
                    }

                }
                else {

                    isPlaying = true;
                    gif.Enabled = true;

                    Play_button.Text = "Pause";

                    if (!randomSelection)
                    {
                        trackFav.Enabled = true;
                    }

                    if (media.NaturalDuration.HasTimeSpan) //Property of song duration FOUND
                    {
                        Display.Maximum = (int)media.NaturalDuration.TimeSpan.TotalSeconds;
                    }

                    media.Play();
                                     
                    songDuration.Enabled = true;
                }
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            isPlaying = false;
            gif.Enabled = false;
            songDuration.Enabled = false;

            Play_button.Text = "Play";

            trackFav.Enabled = false;

            media.Stop();          
    
            Display.Value = 0;
            timesPlayed = 0;

            displayTimer.Enabled = false;
        }
        
        private void Next_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (!randomSelection)
                {
                    Songs.SelectedIndex += 1;
                    Play_button_Click(this, e);
                }
                else
                {
                    rNow = r.Next(0, Songs.Items.Count);
                    while (rNow == rPrev)
                    {
                        rNow = r.Next(0, Songs.Items.Count);
                    }
                    Songs.SelectedIndex = r.Next(0, Songs.Items.Count);

                    rPrev = Songs.SelectedIndex;
                    Play_button_Click(this, e);
                }
            }
            catch (ArgumentOutOfRangeException) //Last song of the list and user press next button, next song = first
            {
                isPlaying = true;

                currentSong = fullFilePaths[0];
                Songs.SelectedIndex = 0;
                
                Play_button.Text = "Pause";

                if (!randomSelection)
                {
                    trackFav.Enabled = true;
                }

                media.Play();
            }           
        }

        private void Prev_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (!randomSelection)
                {
                    Songs.SelectedIndex -= 1;
                    Play_button_Click(this, e);
                }
                else
                {
                    rNow = r.Next(0, Songs.Items.Count);

                    while(rNow == rPrev)
                    {
                        rNow = r.Next(0, Songs.Items.Count);
                    }
                    
                    Songs.SelectedIndex = r.Next(0, Songs.Items.Count);

                    rPrev = Songs.SelectedIndex;
                    Play_button_Click(this, e);
                }
            }
            catch (IndexOutOfRangeException)
            {
                isPlaying = true;

                currentSong = fullFilePaths[0];
                Songs.SelectedIndex = 0;

                Play_button.Text = "Pause";

                if (!randomSelection)
                {
                    trackFav.Enabled = true;
                }

                media.Play();
            }         
        }

        private void Songs_SelectedIndexChanged(object sender, EventArgs e)
        {
            timesPlayed = 0;
            Display.Value = 0;

            if (isPlaying)
            {
                Stop_Click(this, e);
            }
            try {
                currentSong = fullFilePaths[Songs.SelectedIndex];
            }
            catch (IndexOutOfRangeException)
            {
                currentSong = fullFilePaths[0];
            }

            media.Open(new Uri(currentSong));

            if (songsInfo[Songs.SelectedIndex, 0] == null)
            {
                label10.Text = "Not Found";
            } else
                label10.Text = songsInfo[Songs.SelectedIndex, 0];

            if (songsInfo[Songs.SelectedIndex, 1] == null){
                label7.Text = "Not Found";
            }else
                label7.Text = songsInfo[Songs.SelectedIndex, 1];
            
            if (songsInfo[Songs.SelectedIndex, 2] == null)
            {
                label8.Text = "Not Found";
            }else
                label8.Text = songsInfo[Songs.SelectedIndex, 2];
            
            if (songsInfo[Songs.SelectedIndex, 3] == null)
            {
                label9.Text = "Not Found";
            }else
                label9.Text = songsInfo[Songs.SelectedIndex, 3];
                      
        }

        private void Favorites_SelectedIndexChanged(object sender, EventArgs e)
        {   
           Songs.SelectedIndex = playedSecs_times[Favorites.SelectedIndex, 2]; // Change the songs selected index to play the appropriate song from the favorite.listbox
        }

        private void displayTimer_Tick(object sender, EventArgs e)
        {
            try {
                if (media.HasAudio && !media.IsMuted) {
                    nowPlaying.Text = Songs.SelectedItem.ToString();
                }
            }
            catch (NullReferenceException) { nowPlaying.Text = ""; }                                   
        }

        private void songDuration_Tick(object sender, EventArgs e)
        {
            displayTimer.Enabled = true;

            if (media.NaturalDuration.HasTimeSpan)
                Display.Value += 1;

            if (Display.Value == Display.Maximum && !randomSelection)
            {
                songDuration.Enabled = false;

                //AUTO PLAY NEXT SONG
                try
                {
                    Songs.SelectedIndex += 1;
                }
                catch (ArgumentOutOfRangeException)
                {
                    isPlaying = true;

                    currentSong = fullFilePaths[0];
                    Songs.SelectedIndex = 0;

                    Play_button.Text = "Pause";

                    if (!randomSelection)
                    {
                        trackFav.Enabled = true;
                    }

                    media.Play();
                }
            }
            else if(Display.Value == Display.Maximum && randomSelection)
            {
                //PLAY RANDOM SONG               
                rNow = r.Next(0, Songs.Items.Count);

                while (rNow == rPrev)
                {
                    rNow = r.Next(0, Songs.Items.Count);
                }

                Songs.SelectedIndex = r.Next(0, Songs.Items.Count);

                rPrev = Songs.SelectedIndex;

            }
        }

        private void Random_Click(object sender, EventArgs e)
        {
            if (Random.BorderStyle == BorderStyle.Fixed3D)
            {
                Random.BorderStyle = BorderStyle.None;

                randomSelection = false;
            }
            else if (Random.BorderStyle == BorderStyle.None)
            {
                Random.BorderStyle = BorderStyle.Fixed3D;

                randomSelection = true;
                //Give rPrev a value for 1st use
                rPrev = r.Next(0, Songs.Items.Count);
            }
        }

        private void trackVol_Scroll_(object sender, EventArgs e)
        {  
            //Min 0 Max 1 media.volume
            //trackvol Max = 100 Min 0
            media.Volume = (double)trackVol.Value / 100;
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Multiselect = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                int c = 0;
                foreach (String myfile in openFileDialog1.FileNames)
                {
                    c++;
                }
                int numberOfsongs = Songs.Items.Count + c;
                if (numberOfsongs > 50)
                {
                    int howmany = 50 - Songs.Items.Count;
                    MessageBox.Show("You can have a maximum of 50 listed songs.You can select " + howmany + " more.");
                }
                else {
                    openFileDialog1.Filter = "Song Files (mp3,wav)|*.mp3;*.wav";
                    try
                    {
                        files = openFileDialog1.SafeFileNames; //Filenames without the path
                        paths = openFileDialog1.FileNames; //File names-Paths included

                        for (int i = 0; i < paths.Length; i++)
                        {
                            Songs.Items.Add(files[i]);

                            for (int j = 0; j <= 49; j++) //or start from the deleted element j
                            {

                                if (fullFilePaths[j] == null)
                                {
                                    fullFilePaths[j] = paths[i];

                                    if (Path.GetExtension(fullFilePaths[j]) == ".mp3")
                                    {
                                        TagLib.File currFilee = TagLib.File.Create(fullFilePaths[j]);
                                        try
                                        {
                                            if (currFilee.Tag.AlbumArtists[0] == null)
                                            {
                                                songsInfo[j, 0] = "Not Found";
                                            }
                                            else songsInfo[j, 0] = currFilee.Tag.AlbumArtists[0];
                                        }
                                        catch (IndexOutOfRangeException) { songsInfo[j, 0] = "Not Found"; }

                                        if (currFilee.Tag.Year.ToString() == "0")
                                        {
                                            songsInfo[j, 1] = "Not Found";
                                        }
                                        else
                                            songsInfo[j, 1] = currFilee.Tag.Year.ToString();
                                        try
                                        {
                                            if (currFilee.Tag.Genres[0] == null)
                                            {
                                                songsInfo[j, 2] = " Not Found";
                                            }
                                            else songsInfo[j, 2] = currFilee.Tag.Genres[0];
                                        }
                                        catch (IndexOutOfRangeException)
                                        {
                                            songsInfo[j, 2] = " Not Found";
                                        }

                                        songsInfo[j, 3] = "Not Found";
                                    }
                                    else if (Path.GetExtension(fullFilePaths[j]) == ".wav")
                                    {
                                        MessageBox.Show("We cant retrieve file info such as Producer name etc.You need to directly edit them");
                                        ifWav fileWav = new ifWav();
                                        fileWav.wavFile(fullFilePaths[j]);
                                    }
                                    break;
                                }                               
                            }
                        }

                    }
                    catch (ArgumentException)
                    {
                        MessageBox.Show("The file format is invalid, we only support .mp3,.wav files");
                    }
                }
            }
        }

        private void Editbutton_Click(object sender, EventArgs e)
        {   // Stop music from playing while edditing
            isPlaying = false;
            gif.Enabled = false;

            Play_button.Text = "Play";

            media.Close();            

            try
            {
                string producer = songsInfo[Songs.SelectedIndex, 0];
                string realeaseYear = songsInfo[Songs.SelectedIndex, 1];
                string genre = songsInfo[Songs.SelectedIndex, 2];
                string language = songsInfo[Songs.SelectedIndex, 3];
                int index = Songs.SelectedIndex;

                Form2 editForm = new Form2(producer, realeaseYear, genre, language, index, this);

                editForm.Show();
                
            }
            catch (IndexOutOfRangeException) {

                MessageBox.Show("Please select the song you want to edit, and then click the edit button");
            }
            
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
           try
            {

                DialogResult deleteSong = MessageBox.Show("", "Are you sure you want to delete " + Songs.SelectedItem.ToString() + " ?", MessageBoxButtons.YesNoCancel);

                if (deleteSong == DialogResult.Yes)
                {
                    for (int i = 0; i <= 49; i++)
                    {
                        if (playedSecs_times[i, 2] == Songs.SelectedIndex)
                        {
                            try {
                                Favorites.Items.RemoveAt(i);
                            }
                            catch (ArgumentOutOfRangeException)
                            {
                                //Error, didnt find the associated index in the favorite list
                            }
                            playedSecs_times[i, 0] = 0;
                            playedSecs_times[i, 1] = 0;
                            playedSecs_times[i, 2] = -1;
                        }
                    }

                    Songs.Items.RemoveAt(Songs.SelectedIndex);
                    Songs.SelectedIndex = 0;

                    SortArray array = new SortArray(this);

                    array.SortIt(playedSecs_times);

                    Favorites.Items.Clear();

                    for (int i = 0; i <= 49; i++)
                    {
                        if (playedSecs_times[i, 1] != 0)
                        {
                            Favorites.Items.Add(Songs.Items[playedSecs_times[i, 2]].ToString());
                        }
                    }
                }
            }
           catch (IndexOutOfRangeException)
           {
                try {
                    Songs.SelectedIndex = 0;
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Your song list is empty.");
                    Songs.SelectedIndex = -1;
                }

            }
           catch (NullReferenceException)
            {
                MessageBox.Show("Please select the song you want to delete, and then click the delete button");
            }
        }

        private void trackFav_Tick(object sender, EventArgs e)
        {
            if (Display.Value < 5) //Scroll value = 0 // New song // ==3 cause it ticks after 3 secs
            {
                timesPlayed++;
            }
            count_secs+= 3;

            int count = 0;

            int lockk = 0; //lock so we have the first empty socket

            int emptysock = -1;

            for (int num = 0; num <= 49; num++) //??
            {   //find the 1st 'empty' cell or deleted one to add the song info about favorites
                count++;
                if (playedSecs_times[num, 2] == Songs.SelectedIndex && Favorites.SelectedIndex == -1) //not selected)
                {
                    playedSecs_times[num, 0] += count_secs;
                    playedSecs_times[num, 1] += timesPlayed;

                    break;
                }
                else if (playedSecs_times[num, 0] == 0 && playedSecs_times[num, 1] == 0 && playedSecs_times[num, 2] == -1 && lockk == 0)
                {   lockk = 1;
                    emptysock = num;
                }

                if (count == 49 && emptysock != -1)
                {
                    playedSecs_times[emptysock, 0] += count_secs;
                    playedSecs_times[emptysock, 1] += timesPlayed;
                    playedSecs_times[emptysock, 2] = Songs.SelectedIndex;
                    break;
                }
            }

            SortArray array = new SortArray(this);

            array.SortIt(playedSecs_times);

            Favorites.Items.Clear();

            for (int i = 0; i <= 49; i++)
            {
                if (playedSecs_times[i, 0] != 0)
                {
                    Favorites.Items.Add(Songs.Items[playedSecs_times[i, 2]].ToString());
                }
            }
        }

        private void addSongsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addbutton_Click(this, e);
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("You will not be able to retrieve your changes after this action.", "Are you sure you want to exit?", MessageBoxButtons.YesNo);

            if (exit == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void aboutToolStripMenuItem2_Click(object sender, EventArgs e)
        {
           MessageBox.Show("Media PLayer 1.3.0" + Environment.NewLine + "User: Not Logged in", "About", MessageBoxButtons.OK);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deletebutton_Click(this, e);
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(playToolStripMenuItem.Text == "Play")
            {
                Play_button_Click(this, e);
                playToolStripMenuItem.Text = "Pause";

            }else if(playToolStripMenuItem.Text == "Pause")
            {
                Play_button_Click(this, e);
                playToolStripMenuItem.Text = "Play";
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Editbutton_Click(this, e);
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stop_Click(this, e);
        }    
    }
}

