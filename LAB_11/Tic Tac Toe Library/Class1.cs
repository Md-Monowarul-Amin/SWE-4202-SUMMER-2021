using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_Library
{   

    public class Tic_Tac_Toe_game
    {
        public Player player;
        public Computer computer;
        public List<Button> buttons;

        public void Button_Add()
        {
            
            for (int i = 1; i < 10; i++)
            {
                Button button = new Button();
                if(i <= 3)
                {
                    button.button_name = "A" + Convert.ToString(i);
                    button.button_sign = "!";
                }
                else if (i <= 6)
                {
                    button.button_name = "B" + Convert.ToString(i);
                    button.button_sign = "!";
                }
                else
                {
                    button.button_name= "C" + Convert.ToString(i);
                    button.button_sign = "!";
                }
                buttons.Add(button);
            }
        }

        public string Victory_calc(string A1, string A2, string A3,
                                   string B1, string B2, string B3,
                                   string C1, string C2, string C3)
        {
            string ok = "Draw";
            if ((A1 == player.player_sign && A2 == player.player_sign && A3 == player.player_sign) || (B1 == player.player_sign && B2 == player.player_sign && B3 == player.player_sign) || (C1 == player.player_sign && C2 == player.player_sign && C3 == player.player_sign))
            {
                ok = "Win";
                player.player_score += 1;
            }
            else if ((A1 == player.player_sign && B1 == player.player_sign && C1 == player.player_sign) || (A2 == player.player_sign && B2 == player.player_sign && C2 == player.player_sign) || (A3 == player.player_sign && B3 == player.player_sign && C3 == player.player_sign))
            {
                ok = "WIN";
                player.player_score += 1;
            }
            else if ((A1 == player.player_sign && B2 == player.player_sign && C3 == player.player_sign) || (A3 == player.player_sign && B2 == player.player_sign && C1 == player.player_sign))
            {
                ok = "WIN";
                player.player_score += 1;
            }


            else if ((A1 == computer.computer_sign && A2 == computer.computer_sign && A3 == computer.computer_sign) || (B1 == computer.computer_sign && B2 == computer.computer_sign && B3 == computer.computer_sign) || (C1 == computer.computer_sign && C2 == computer.computer_sign && C3 == computer.computer_sign))
            {
                ok = "Loose";
                computer.computer_score += 1;
            }
            else if ((A1 == computer.computer_sign && B1 == computer.computer_sign && C1 == computer.computer_sign) || (A2 == computer.computer_sign && B2 == computer.computer_sign && C2 == computer.computer_sign) || (A3 == computer.computer_sign && B3 == computer.computer_sign && C3 == computer.computer_sign))
            {
                ok = "Loose";
                computer.computer_score += 1;
            }

            else if ((A1 == computer.computer_sign && B2 == computer.computer_sign && C3 == computer.computer_sign) || (A3 == computer.computer_sign && B2 == computer.computer_sign && C1 == computer.computer_sign))
            {   
                ok = "Loose";
                computer.computer_score += 1;
            }

            return ok;
        }
            
    }

    public class Player
    {
        public string player_sign;
        public int player_score;

    }

    public class Computer
    {
        public string computer_sign;
        public int computer_score;


    }

    public class Button
    {
        public string button_name;
        public string button_sign;
    }






}   
