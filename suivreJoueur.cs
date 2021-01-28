
using UnityEngine;

public class suivreJoueur : MonoBehaviour
{
    public Transform joueur;
    public Vector3 distance;

    void Update()
    {
        transform.position = joueur.position + distance;
    }
}
