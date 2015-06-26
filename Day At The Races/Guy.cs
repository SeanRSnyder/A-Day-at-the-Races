using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Races
{
    public class Guy : Bet
    {
        public Bet MyBet;
        public decimal Cash;
        public int[] GuyArray;

        public RadioButton MyRadioButton;
        public Label MyLabel;
        public Label MyLabel2;

     

        public void UpdateLabels()
        {
            MyRadioButton.Text = Name + " has $" + Cash;   
        }

        public void ClearBet()
        {
            MyBet = null;
            MyLabel2.Text = Name + " hasn't placed a bet";
        }

        public bool PlaceBet(int BetAmount, string DogToWin, decimal Test)
        {
            this.MyBet = new Bet() { Amount = BetAmount, Dog = DogToWin, Bettor = this, odds = Test};
            if (BetAmount <= Cash)
            {
                 MyLabel2.Text = this.Name + " bets " + BetAmount + " dollars on " + DogToWin;
                  this.UpdateLabels();
                   return true;
            }
            else
            {
                  MessageBox.Show(Name + " does not have enough to cover that bet ");
                  this.MyBet = null;
                 return false;
            }
        }

        public void Collect(string Winner)
        {
            if (MyBet != null) 
                Cash = Cash + MyBet.PayOut(Winner);
            ClearBet();
            UpdateLabels();
        }
    }
}
