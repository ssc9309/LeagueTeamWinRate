using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Net;

namespace LeagueTeamWinRate
{
    public struct Champion
    {
        public string name;
        public string winRate;

        public override string ToString()
        {
            return name + "," + winRate;
        }
    }


    

    public partial class Main : Form
    {

        private string exePath = (new FileInfo(System.Reflection.Assembly.GetEntryAssembly().Location)).Directory.ToString() + "\\";
        private List<Champion> championList = new List<Champion>();

        private string championDataMatch = "<div style=\"display: table-cell; vertical-align: middle; padding-top: 3px; padding-left: 5px;\"><a href=\"/champions/";

        public Main()
        {
            InitializeComponent();

            WebClient wc = new WebClient();
            //string s = wc.DownloadString("http://na.op.gg/statistics/champion/");
            string s = wc.DownloadString("http://www.lolking.net/champions/");

            StringReader sr = new StringReader(s);
            string line = sr.ReadLine();

            while (line != null)
            {
                if (line.IndexOf(championDataMatch) >= 0)
                {
                    string[] foo = line.Split('>');
                    string name = foo[2].Split('<')[0];

                    line = sr.ReadLine();
                    line = sr.ReadLine();
                    line = sr.ReadLine();
                    line = sr.ReadLine();
                    line = sr.ReadLine();

                    string winRate = line.Split('>')[1].Split('%')[0];

                    Champion tempChamp = new Champion();
                    tempChamp.name = name;
                    tempChamp.winRate = winRate;

                    championList.Add(tempChamp);
                }

                line = sr.ReadLine();
            }



            foreach (Champion champ in championList)
            {
                lbx_ListOfChamp.Items.Add(champ.name);
            }
            //RearrangeData();
        }



        private void tbx_SearchChamp_TextChanged(object sender, EventArgs e)
        {
            lbx_ListOfChamp.Items.Clear();

            if (tbx_SearchChamp.Text == "")
            {
                foreach (Champion champ in championList)
                {
                    lbx_ListOfChamp.Items.Add(champ.name);
                }
            }
            else
            {
                foreach (Champion champ in championList)
                {
                    
                    if (champ.name.ToUpper().IndexOf(tbx_SearchChamp.Text.ToUpper()) >= 0)
                    {
                        lbx_ListOfChamp.Items.Add(champ.name);
                    }
                }
            }
        }

        private void btn_Team1Add_Click(object sender, EventArgs e)
        {
            if (lbx_ListOfChamp.SelectedIndex >= 0 && lbx_Team1.Items.Count < 5)
            {
                bool isAlreadyAdded = false;
                foreach (string champName in lbx_Team1.Items)
                {
                    if (champName == lbx_ListOfChamp.Items[lbx_ListOfChamp.SelectedIndex])
                    {
                        isAlreadyAdded = true;
                    }
                }
                
                if (!isAlreadyAdded)
                {
                    lbx_Team1.Items.Add(lbx_ListOfChamp.Items[lbx_ListOfChamp.SelectedIndex]);
                }
            }

            if (lbx_Team1.Items.Count == 5)
            {
                double teamWinRate = 0;
                int count = 0;
                
                foreach (string t1ChampName in lbx_Team1.Items)
                {
                    foreach (Champion champ in championList)
                    {
                        if (t1ChampName == champ.name)
                        {
                            teamWinRate += Convert.ToDouble(champ.winRate);
                            count++;
                        }
                    }
                }

                if (count == 5)
                {
                    teamWinRate /= count;
                    lbl_Team1WinRate.Text = "Team1 Win Rate: " + teamWinRate;
                }
                else
                {
                    MessageBox.Show("Something wrong while calculating winrate");
                }
            }
        }

        private void btn_Team2Add_Click(object sender, EventArgs e)
        {
            if (lbx_ListOfChamp.SelectedIndex >= 0 && lbx_Team2.Items.Count < 5)
            {
                bool isAlreadyAdded = false;
                foreach (string champName in lbx_Team2.Items)
                {
                    if (champName == lbx_ListOfChamp.Items[lbx_ListOfChamp.SelectedIndex])
                    {
                        isAlreadyAdded = true;
                    }
                }

                if (!isAlreadyAdded)
                {
                    lbx_Team2.Items.Add(lbx_ListOfChamp.Items[lbx_ListOfChamp.SelectedIndex]);
                }
            }

            if (lbx_Team2.Items.Count == 5)
            {
                double teamWinRate = 0;
                int count = 0;

                foreach (string t2ChampName in lbx_Team2.Items)
                {
                    foreach (Champion champ in championList)
                    {
                        if (t2ChampName == champ.name)
                        {
                            teamWinRate += Convert.ToDouble(champ.winRate);
                            count++;
                        }
                    }
                }

                if (count == 5)
                {
                    teamWinRate /= count;
                    lbl_Team2WinRate.Text = "Team2 Win Rate: " + teamWinRate;
                }
                else
                {
                    MessageBox.Show("Something wrong while calculating winrate");
                }
            }
        }

        private void btn_Team1Remove_Click(object sender, EventArgs e)
        {
            if (lbx_Team1.SelectedIndex >= 0)
            {
                lbx_Team1.Items.RemoveAt(lbx_Team1.SelectedIndex);

            }
        }
        private void btn_Team2Remove_Click(object sender, EventArgs e)
        {
            if (lbx_Team2.SelectedIndex >= 0)
            {
                lbx_Team2.Items.RemoveAt(lbx_Team2.SelectedIndex);

            }
        }
    }
}
