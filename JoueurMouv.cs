using UnityEngine;

public class JoueurMouv : MonoBehaviour
{

    public Rigidbody rb; // Le rigidBody du joueur
    public float forwardForce = 1000f; // Force pour avancer
    public float CoteForce = 750f; // Force pour aller vers la droite ou la gauche




    // LA PHYSIQUE ---------------------------------------------------------------
    void FixedUpdate()
    {

        // Ajouter une force en Z
        rb.AddForce(0 , 0 , forwardForce * Time.deltaTime);


        // Tourner vers la droite si on appuie "d"
        if (Input.GetKey("d"))
        {
            rb.AddForce(CoteForce * Time.deltaTime , 0 , 0 , ForceMode.VelocityChange);
        }

        // Tourner vers la droite si on appuie "a"
        if (Input.GetKey("a"))
        {
            rb.AddForce(-CoteForce * Time.deltaTime , 0 , 0 , ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GestionnaireJeu>().FinJeu();
        }

    }

}
