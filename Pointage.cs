using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI​; // utilisation de la bibliothèque de UI

public class Pointage : MonoBehaviour {


    public float pointText = 0f;
    public Transform joueur;


    void Update()
    {
        pointText = Mathf.Floor(joueur.position.z);
        GetComponent<Text>().text = pointText.ToString();
    }


}
