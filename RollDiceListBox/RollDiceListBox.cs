namespace RollDiceListBox
{
    //Micah Spencer
    //RCET2265
    //Fall 2025
    //Roll of The Dice List Box Program
    //https://github.com/micahspencer-png/RollDiceListBox.git
    public partial class RollDiceListBox : Form
    {
        public RollDiceListBox()
        {
            InitializeComponent();
            DisplayResults();
        }
        //Program Logic-------------------------------------------------------------------------------------------------------------------

        private static int[] dice = new int[11];
        static void Roll()
        {
            //sets up variables to roll dice randomly
            Random Dice1 = new Random();
            Random Dice2 = new Random();
            for (int i = 0; i < 11; i++)
            {
                dice[i] = 0;
            }
            
            //rolls and counts dice 1000 times
            for (int i = 0; i < 1000; i++)
            {
                int roll1 = Dice1.Next(1, 7);
                int roll2 = Dice2.Next(1, 7);
                int total = roll1 + roll2;


                //totals up each roll and adds a count to the global variable
                switch (total)
                {
                    case 2:
                        dice[0]++;
                        break;

                    case 3:
                        dice[1]++;
                        break;

                    case 4:
                        dice[2]++;
                        break;

                    case 5:
                        dice[3]++;
                        break;

                    case 6:
                        dice[4]++;
                        break;

                    case 7:
                        dice[5]++;
                        break;

                    case 8:
                        dice[6]++;
                        break;

                    case 9:
                        dice[7]++;
                        break;

                    case 10:
                        dice[8]++;
                        break;

                    case 11:
                        dice[9]++;
                        break;

                    case 12:
                        dice[10]++;
                        break;

                    default:
                        
                        break;

                }
            }
        }
        static string text = "test didn't work";
        static void DisplayResults()
        {
            Roll();
            //sets up the display variables
            string[] header = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
            string vDivide = "|";
            int pad = 4;
            int totalWidth = 11 * (pad + vDivide.Length);
            string hDivide = new string('-', totalWidth);
            string diceresult = "";

            //sets top of display up
            diceresult += "                     Roll of the Dice\n";
            
            diceresult += hDivide +"\n" ;

            //sets the header for each variable
            foreach (string letter in header)
            {
                diceresult += letter.PadLeft(pad + 1) + vDivide;
            }
            diceresult += "\n";
            
            diceresult += hDivide + "\n";

            //displays the results of the rolls
            for (int count = 0; count < 11; count++)
            {
                //converts int data from table to string
                string total = Convert.ToString(dice[count]);

                //sets the data to match up with it's header
                diceresult += total.PadLeft(pad) + vDivide;
            }
            
            diceresult += "\n" + hDivide;
            text = diceresult;
        }

    


        //Event Handlers------------------------------------------------------------------------------------------------------------------
        private void RollButton_Click(object sender, EventArgs e)
        {
            
            DisplayListBox.Items.Clear();
            DisplayResults();
            foreach (string line in text.Split("\n")) 
            {
                DisplayListBox.Items.Add(line); 
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DisplayListBox.Items.Clear();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
