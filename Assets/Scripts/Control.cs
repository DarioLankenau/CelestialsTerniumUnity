using UnityEngine;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{
    public void EscenaJuego()
    {
        SceneManager.LoadScene("Juego");
    }

    public void EscenaMenuP()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }

    public void EscenaMenuF()
    {
        SceneManager.LoadScene("MenuFinal");
    }
}
