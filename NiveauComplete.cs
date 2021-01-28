using UnityEngine;
using UnityEngine.SceneManagement;

public class NiveauComplete : MonoBehaviour
{
    public void ChargerNivSuiv ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        {

        }
    }
}
