using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Hippo: MonoBehaviour 
{
	 public int number;

	 public int bite_capicity = 25;
 
	 public int current_storage = 0;

	 public float percantage_bite = 0.5f;

	 public Planet hippo_planet;

	public TMP_Text name_text;

	public TMP_Text storage_text;

    private void Start()
    {
		name_text.text = "Hippo " + number;
		updateUI();
    }

    public Hippo (Planet a_planet) 
	 {
	   hippo_planet = a_planet;
	 }

	 public void try_bite()
	 {
	  if(hippo_planet.is_active)
	  {
		  if (Random.value < percantage_bite)
		   {
			hippo_planet.handle_bite(this);
		   }
	  }
	  
	 }

    public void updateUI ()
    {
		storage_text.text = current_storage.ToString();
    }

    public void reset_hippo()
    {
		current_storage = 0;
		updateUI();
    }

}
