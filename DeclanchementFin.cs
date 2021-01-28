using UnityEngine;

public class DeclanchementFin : MonoBehaviour
{

    public GestionnaireJeu gestionnaireJeu;

    void OnTriggerEnter () 
    {
        gestionnaireJeu.NiveauComplete();
    }


}
