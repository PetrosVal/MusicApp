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

namespace Music_Player
{
    public partial class Form2 : Form
    {
        Form1 ParentForm = null;
        int index;
        public Form2()
        {
            InitializeComponent();     
        }

        public Form2(string Producer, string RealeaseYear, string Genre, string Language,int s_index, Form callingParentForm)
        {
            InitializeComponent();

            if(Producer == "Not Found")
            {
                textBoxProd.Text = "";
            }else
                textBoxProd.Text = Producer;

            if(RealeaseYear == "Not Found")
            {
                textBoxyear.Text = "";
            }else
                textBoxyear.Text = RealeaseYear;
            if(Genre == "Not Found")
            {
                textBoxGenre.Text = "";
            }else
                textBoxGenre.Text = Genre;

            if(Language == "Not Found")
            {
                textBoxLang.Text = "";
            }else
                textBoxLang.Text = Language;

            index = s_index;

            ParentForm = callingParentForm as Form1;
        }


        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void Save_Click(object sender, EventArgs e)
        {
            if (textBoxProd.Text == "" || textBoxyear.Text == "" || textBoxGenre.Text == "" || textBoxLang.Text == "")
            {
                MessageBox.Show("One or more textboxes arent filled");
            }
            else {
                ParentForm.songsInfo[index, 0] = textBoxProd.Text;
                ParentForm.songsInfo[index, 1] = textBoxyear.Text;
                ParentForm.songsInfo[index, 2] = textBoxGenre.Text;
                ParentForm.songsInfo[index, 3] = textBoxLang.Text;

                if (Path.GetExtension(ParentForm.fullFilePaths[index]) == ".mp3")
                {

                    DialogResult saveMain = MessageBox.Show("You will need to restart the application to apply the changes, but you will lost your current state", "Do you want to save the changes to the main file too?", MessageBoxButtons.YesNoCancel);

                    if (saveMain == DialogResult.Yes)
                    {
                        string curr = ParentForm.fullFilePaths[index];

                        //save into the file directly if its mp3

                        TagLib.File currFile = TagLib.File.Create(curr);

                        currFile.Tag.AlbumArtists[0] = textBoxProd.Text;

                        currFile.Tag.Year = Convert.ToUInt32(textBoxyear.Text, 2);

                        currFile.Tag.Genres[0] = textBoxGenre.Text;

                        currFile.Save();
                        
                        this.Close();
                    }
                    else if (saveMain == DialogResult.No)
                    {
                        this.Close();
                    }
                }
                else {
                    this.Close();
                }
            }
        }
    }
}
