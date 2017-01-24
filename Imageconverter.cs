using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Factorio_Image_Converter
{
    public partial class Imageconverter : Form
    {
        //-------------------------------------------- variables --------------------------------------------

        List<string> TileListName = new List<string>();
        List<string> TileGameName = new List<string>();
        List<string> TileGameColor = new List<string>();
        List<List<string>> TileCoords = new List<List<string>>();
        List<string> OtherCoords = new List<string>();
        
        //-------------------------------------------- end variables --------------------------------------------

        public Imageconverter()
        {
            InitializeComponent();
        }

        //-------------------------------------------- custom functions --------------------------------------------

        private string BuildTileCoords(string lname,string gname, string coords)
        {
            //return Environment.NewLine + "-- " + gname + Environment.NewLine + lname + " = {" + coords + "}"; //adding the comments broke console input
            return Environment.NewLine + lname + " = {" + coords + "}";
        }//BuildTileCoords

        private string BuildTileWhiles(string lname, string gname)
        {
            return
                  Environment.NewLine + "a=1;"
                + Environment.NewLine + "while(a<#" + lname + ") do"
                + Environment.NewLine + "  x=" + lname + "[a+0];"
                + Environment.NewLine + "  y=" + lname + "[a+1];"
                + Environment.NewLine + "  table.insert(tiles,{name=\"" + gname + "\",position={posx+x+xoffset,posy+y+yoffset}} );"
                + Environment.NewLine + "  a=a+2;"
                + Environment.NewLine + "end"
            ;
        }//BuildTileWhile

        private void BackgroundProcesing()
        {
            if (File.Exists(FilePath.Text))
            {
                Bitmap img = new Bitmap(FilePath.Text);
                Color Pixel = new Color();
                Color TestColor = new Color();
                int Found = 0;
                MethodInvoker l = new MethodInvoker(() => Progress.Maximum = img.Height);
                Progress.Invoke(l);

                for (int y = 0; y < img.Height; y++)
                {
                    MethodInvoker m = new MethodInvoker(() => Progress.Value = y + 1);
                    Progress.Invoke(m);
                    for (int x = 0; x < img.Width; x++)
                    {
                        Pixel = img.GetPixel(x, y);
                        Found = 0;
                        for (int i = 0; i < TileGameName.Count; i++)
                        {
                            TestColor = ColorTranslator.FromHtml(TileGameColor[i]);
                            if (Pixel == TestColor)
                            {
                                Found = 1;
                                TileCoords[i].Add(x + "," + y);
                                i = TileGameName.Count;
                            }
                        }//for
                        if (Found == 0)
                        {
                            OtherCoords.Add(x + "," + y);
                        }
                    }//y
                }//x

                int XOffset = img.Width / 2;
                int YOffset = img.Height / 2;

                string AllCoords = "";
                string AllWhiles = "";

                for (int i = 0; i < TileGameName.Count; i++)
                {
                    if (TileCoords[i].Count > 0)
                    {
                        AllCoords = AllCoords + BuildTileCoords(TileListName[i], TileGameName[i], string.Join(",", TileCoords[i].ToArray()));
                        AllWhiles = AllWhiles + BuildTileWhiles(TileListName[i], TileGameName[i]);
                    }
                }//for
                if (OtherCoords.Count > 0)
                {
                    if (ListUnmatched.Checked == true) AllCoords = AllCoords + BuildTileCoords("unmatched", "other tiles that didn't match", string.Join(",", OtherCoords.ToArray()));
                }
                MethodInvoker n = new MethodInvoker(() => Code.Text =
                    scriptpart1.Text
                    + Environment.NewLine + "xoffset = -" + XOffset + ";"
                    + Environment.NewLine + "yoffset = -" + YOffset + ";"
                    + AllCoords
                    + AllWhiles
                    + Environment.NewLine + scriptpart2.Text);
                Code.Invoke(n);

                MethodInvoker o = new MethodInvoker(() => Select.Enabled = true);
                Select.Invoke(o);
            }//exists
        }//BackgroundProcesing

        //-------------------------------------------- end custom functions --------------------------------------------

        private void Imageconverter_Load(object sender, EventArgs e)
        {
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "tilecolors.txt"))
            {
                //show loaded tiles
                DefaultTiles.Text = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "tilecolors.txt");
                Code.Text = "Factorio Tile Colors loaded from: "
                + Environment.NewLine
                + AppDomain.CurrentDomain.BaseDirectory + "tilecolors.txt"
                + Environment.NewLine
                + Environment.NewLine + DefaultTiles.Text;
            }//exists
            else
            {
                Code.Text = "====ERROR===="
                + Environment.NewLine
                + "Factorio Tile Colors NOT Found at"
                + Environment.NewLine
                + AppDomain.CurrentDomain.BaseDirectory + "tilecolors.txt"
                + Environment.NewLine
                + Environment.NewLine + "USING 0.14 DEFAULT TILES: "
                + Environment.NewLine
                + Environment.NewLine + DefaultTiles.Text;
            }//not exists

            //load tiles into useable format
            TileListName.Clear();
            TileGameName.Clear();
            TileGameColor.Clear();
            TileCoords.Clear();
            OtherCoords.Clear();
            string[] delimiters = { ",","\r\n","\n" };
            string[] words = DefaultTiles.Text.Split(delimiters, StringSplitOptions.None);
            for (int i = 0; i < words.Length; i += 2)
            {
                TileListName.Add("list" + words[i].Replace("-", ""));
                TileGameName.Add(words[i]);
                TileGameColor.Add(words[i + 1]);
                TileCoords.Add(new List<string>());
            }//for

            //Code.Text = Code.Text + BuildTileCoords(tilelistname[0], tilegamename[0], "0,0") + BuildTileWhile(tilelistname[0], tilegamename[0]);//debug

            //form load
        }

        private void Select_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Properties.Settings.Default.FilePath;
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            //Select_Click
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            FilePath.Text = openFileDialog1.FileName;
            Properties.Settings.Default.FilePath = Path.GetDirectoryName(FilePath.Text);
            Properties.Settings.Default.LastFile = Path.GetFileNameWithoutExtension(FilePath.Text);
            Properties.Settings.Default.Save();

            if (File.Exists(FilePath.Text))
            {
                //reset for new image
                for (int i = 0; i < TileCoords.Count; i++)
                {
                    TileCoords[i].Clear();
                }
                OtherCoords.Clear();

                Code.Text = "Processing Image, Please wait..";
                Select.Enabled = false;
                Thread th = new Thread(BackgroundProcesing);
                th.Start();
            }
            else
            {
                Code.Text = "File Not Found";
            }
            //openFileDialog1_FileOk
        }

        private void SaveScript_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = Properties.Settings.Default.FilePath;
            saveFileDialog1.FileName = Properties.Settings.Default.LastFile + ".txt";
            saveFileDialog1.ShowDialog();
            //SaveScript_Click
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string temp = Code.Text;
            temp = temp.Replace("\r", "");
            temp = temp.Replace("\n", Environment.NewLine);
            System.IO.File.WriteAllText(saveFileDialog1.FileName, temp);
            //saveFileDialog1_FileOk
        }
        
    }//imageconverter form
}//namespace
