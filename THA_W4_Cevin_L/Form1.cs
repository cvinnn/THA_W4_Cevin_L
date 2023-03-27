using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W4_Cevin_L
{
    public partial class Form1 : Form
    {
        List<string> countrylist = new List<string>();
        List<string> teamlist = new List<string>();
        List<string> playerlist = new List<string>();

        public Form1()
        {
            InitializeComponent();
            cmbChooseCountry.Items.Add("Germany");
            cmbChooseCountry.Items.Add("England");
            countrylist.Add("Germany");
            countrylist.Add("England");
            cbPlayerPosition.Items.Add("GK");
            cbPlayerPosition.Items.Add("DF");
            cbPlayerPosition.Items.Add("MF");
            cbPlayerPosition.Items.Add("FW");
        }

        
        private void cmbChooseCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstPlayer.Items.Clear();
            cmbChooseTeam.Items.Clear();
            cmbChooseTeam.Text = "";
            if (cmbChooseCountry.Text == "England")
            {
                if (!cmbChooseTeam.Items.Contains("England"))
                {
                    cmbChooseTeam.Items.Add("Manchester United");
                    cmbChooseTeam.Items.Add("Chelsea");
                }
            }

            if (cmbChooseCountry.Text == "Germany")
            {
                if (!cmbChooseTeam.Items.Contains("Bayern Munich"))
                {
                    cmbChooseTeam.Items.Add("Bayern Munich");
                }
            }

            string selectedcountry = cmbChooseCountry.SelectedItem.ToString();

            foreach (string team in teamlist)
            {
                string[] teamcountry = team.Split('|');
                if (teamcountry[1] == selectedcountry)
                {
                    cmbChooseTeam.Items.Add(teamcountry[0]);
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstPlayer.Items.Count <= 11)
            {
                MessageBox.Show("Player Must not be Less Than 11", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int index = lstPlayer.SelectedIndex;
                string removedplayer = lstPlayer.SelectedItem.ToString();
                lstPlayer.Items.RemoveAt(index);
                playerlist.Remove(removedplayer);
            }
        }
        
        private void cmbChooseTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstPlayer.Items.Clear();

            string selectedteamname = cmbChooseTeam.SelectedItem.ToString();
            int count = 0;

        readd:
            if (playerlist.Count != 0)
            {
                foreach (string player in playerlist)
                {
                    string[] addedplayer = player.Split('+');
                    if (addedplayer[1] == selectedteamname)
                    {
                        lstPlayer.Items.Add(addedplayer[0]);
                        count++;
                    }
                }
            }


            switch (cmbChooseTeam.Text)
            {
                case "Manchester United":
                    if (count == 0)
                    {
                        playerlist.Add("(01) David De Gea, GK+Manchester United");
                        playerlist.Add("(02) Victor Lindelof, DF+Manchester United");
                        playerlist.Add("(04) Phil Jones, DF+Manchester United");
                        playerlist.Add("(05) Harry Maguire, DF+Manchester United");
                        playerlist.Add("(06) Lisandro Martinez, DF+Manchester United");
                        playerlist.Add("(08) Bruno Fernandez, MF+Manchester United");
                        playerlist.Add("(09) Anthony Martial, FW+Manchester United");
                        playerlist.Add("(10) Marcus Rashford, FW+Manchester United");
                        playerlist.Add("(12) Tyrell Malacia, DF+Manchester United");
                        playerlist.Add("(14) Christian Eriksen, MF+Manchester United");
                        playerlist.Add("(18) Casemiro, MF+Manchester United");
                        goto readd;
                    }
                    break;

                case "Chelsea":
                    if (count == 0)
                    {
                        playerlist.Add("(01) Kepa Amzabalaga, GK+Chelsea");
                        playerlist.Add("(04) Benoit Badiashile, DF+Chelsea");
                        playerlist.Add("(05) Enzo Ferandez, MF+Chelsea");
                        playerlist.Add("(06) Thiago Silva, DF+Chelsea");
                        playerlist.Add("(07) Ngolo Kante, MF+Chelsea");
                        playerlist.Add("(08) Mateo Kofacic, MF+Chelsea");
                        playerlist.Add("(09) Pierre Emmerick Aubameyang, FW+Chelsea");
                        playerlist.Add("(10) Christian Pulisic, MF+Chelsea");
                        playerlist.Add("(11) Joao Felix, FW+Chelsea");
                        playerlist.Add("(12) Ruben Lovtus Cheek, MF+Chelsea");
                        playerlist.Add("(17) Rahaeem Sterling, MF+Chelsea");
                        goto readd;
                    }
                    break;

                case "Bayern Munich":
                    if (count == 0)
                    {
                        playerlist.Add("(01) Manuel Neuer, GK+Bayern Munich");
                        playerlist.Add("(02) Dayot Upamecano, DF+Bayern Munich");
                        playerlist.Add("(04) Matthijs Deligt, DF+Bayern Munich");
                        playerlist.Add("(05) Benjamin Pavard, DF+Bayern Munich");
                        playerlist.Add("(06) Joshua Kimmich, MF+Bayern Munich");
                        playerlist.Add("(07) Serge Gnarby, FW+Bayern Munich");
                        playerlist.Add("(08) Leon Goretzka, MF+Bayern Munich");
                        playerlist.Add("(10) Leroy Sane, FW+Bayern Munich");
                        playerlist.Add("(14) Paul Wanner, MF+Bayern Munich");
                        playerlist.Add("(21) Lucas Hernadez, DF+Bayern Munich");
                        playerlist.Add("(25) Thomas Muller, FW+Bayern Munich");
                        goto readd;
                    }
                    break;
            }
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            if (txtTeamName.Text == "" || txtTeamCountry.Text == "" || txtTeamCity.Text == "")
            {
                MessageBox.Show("Box Must not Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Team team = new Team();
                team.TeamName = txtTeamName.Text;
                team.TeamCountry = txtTeamCountry.Text;
                team.TeamCity = txtTeamCity.Text;

                if (!countrylist.Contains(team.TeamCountry.ToString()))
                {
                    countrylist.Add(team.TeamCountry);
                    cmbChooseCountry.Items.Add(team.TeamCountry);
                }

                if (!teamlist.Contains(team.TeamName.ToString()))
                {
                    teamlist.Add($"{team.TeamName}|{team.TeamCountry}");
                }
                else
                {
                    MessageBox.Show("Team Already Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtTeamName.Text = "";
                txtTeamCountry.Text = "";
                txtTeamCity.Text = "";
                cmbChooseCountry.Text = "";
                cmbChooseTeam.Text = "";
            }
        }

        private void btnAddPlayers_Click(object sender, EventArgs e)
        {
            if (txtPlayerName.Text == "" || txtPlayerNumber.Text == "" || cbPlayerPosition.Text == "" || cmbChooseTeam.Text == "")
            {
                MessageBox.Show("Box Must not Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Team team = new Team();
                Player player = new Player();
                player.PlayerName = txtPlayerName.Text;
                player.PlayerNum = txtPlayerNumber.Text;
                player.PlayerPos = cbPlayerPosition.SelectedItem.ToString();
                team.TeamName = cmbChooseTeam.Text;

                if (!playerlist.Contains($"({player.PlayerNum}) {player.PlayerName}, {player.PlayerPos}+{team.TeamName}"))
                {
                    playerlist.Add($"({player.PlayerNum}) {player.PlayerName}, {player.PlayerPos}+{team.TeamName}");
                    cmbChooseTeam_SelectedIndexChanged( sender, new EventArgs() );
                }
                else
                {
                    MessageBox.Show("Team Already Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtPlayerName.Text = "";
                txtPlayerNumber.Text = "";
                cbPlayerPosition.Text = "";
            }
        }
    }

    public class Team
    {
        private string teamName;
        public string TeamName { get; set; }

        private string teamCountry;
        public string TeamCountry { get; set; }

        private string teamCity;
        public string TeamCity { get; set; }

        private List<Team> teams;
        public List<Team> Teams { get {  return teams; } set { teams = value; } }
    }

    public class Player
    {
        private string playerName;
        public string PlayerName { get; set; }

        private string playerNum;
        public string PlayerNum { get; set; }

        private string playerPos;
        public string PlayerPos { get; set; }
    }
}
