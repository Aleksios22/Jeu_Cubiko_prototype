using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine;

public class joueurCollisions : MonoBehaviour
{

    public JoueurMouv mouvement;

    void OnCollisionEnter(Collision infoCollision) 
    {
        if (infoCollision.collider.tag == "obstacle")
        {
            mouvement.enabled = false;
            FindObjectOfType<GestionnaireJeu>().FinJeu();
        }
    }


}
