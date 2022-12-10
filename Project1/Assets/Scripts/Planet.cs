using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Planet : MonoBehaviour
{
public int number_of_balls = 100;

public int number_of_hippos = 4;

public bool is_active = true;

	public TMP_Text status_text;

    public List<Hippo> hippoList;


    private void Start()
    {
        update_UI();
    }

    public void handle_bite (Hippo Biter) 
    {
      int balls_to_give;
      if (number_of_balls >= Biter.bite_capicity) 
      {
		    balls_to_give = Biter.bite_capicity;
      }
      else 
      {
		    balls_to_give = number_of_balls;
      }

      number_of_balls -= balls_to_give;
      Biter.current_storage += balls_to_give;
      Debug.Log("Hippo " + Biter.number + " took " + balls_to_give + " balls! " + number_of_balls + " left!");
        Biter.updateUI();

      if (number_of_balls <= 0)
      {
        is_active = false;
      }

        update_UI();

    }

    public void update_UI ()
    {
        if (is_active)
        {
            status_text.text = "simulation active: " + is_active + ". the number of balls left is " + number_of_balls;
        }
        else
        {
            status_text.text = "hippo " + find_winner().number + " Wins! ";
        }
    }

    public void reset_sim()
    {
        number_of_balls = 100;
        is_active = true;
        update_UI();
    }

    public Hippo find_winner()
    {
        int high_score = 0;

        Hippo winner = null;

        for (int i = 0; i < hippoList.Count; i++)
        {
            Hippo current_hippo = hippoList[i];
            if (current_hippo.current_storage > high_score)
            {
                high_score = current_hippo.current_storage;
                winner = current_hippo;
            }
        }

        return winner;

    }


}
