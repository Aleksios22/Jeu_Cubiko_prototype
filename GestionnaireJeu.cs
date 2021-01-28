using UnityEngine;
using UnityEngine.SceneManagement;

public class GestionnaireJeu : MonoBehaviour
{

    bool jeuTermine = false;
    public float delaiRejouer = 2f;
    public GameObject nivCompletUI;





    public void NiveauComplete()
    {
        nivCompletUI.SetActive(true);
    }



    public void FinJeu ()
    {
        if (jeuTermine == false)
        {
            jeuTermine = true;
            Debug.Log("fin du jeu");

            // Recommencer le jeu
            Invoke("Rejouer", delaiRejouer);
        }

        
    }




    void Rejouer()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }



}
