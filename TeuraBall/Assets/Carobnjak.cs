using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Carobnjak : MonoBehaviour {

    int max;
    int min;
    int Pokusaj;
    int MaxBrojPokusaja = 11;

    public Text text;
    
    void Start () {
        StartGame();
	}
	
    void StartGame() {
        max = 1000;
        min = 1;
        NextPokusaj();
    }
	
	public void pokusajLower () {
        max = Pokusaj;
        NextPokusaj();
	}

    public void pokusajHigher()
    {
        min = Pokusaj;
        NextPokusaj();
    }

    void NextPokusaj () {
        Pokusaj = Random.Range(min, max);
        text.text = Pokusaj.ToString();
        MaxBrojPokusaja = MaxBrojPokusaja - 1;
        if (MaxBrojPokusaja < 0)
        {
            Application.LoadLevel("Win");
        }
    }
}
