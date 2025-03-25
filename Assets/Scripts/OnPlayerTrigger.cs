using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class OnPlayerTrigger : MonoBehaviour
{
    public UnityEvent onEnter;
    public UnityEvent onExit;
    private int activeSceneIndex;

    void Start()
    {
        activeSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Load to next scene if we're not at the final one
            // Debug.Log("CURRENT SCENE: " + SceneManager.GetActiveScene().buildIndex);
            if (activeSceneIndex < 4)
            {
                SceneManager.LoadScene(activeSceneIndex + 1);
            }
            
            onEnter.Invoke();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            onExit.Invoke();
        }
    }

}
