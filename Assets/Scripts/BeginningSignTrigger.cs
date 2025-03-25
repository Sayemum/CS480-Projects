using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class BeginningSignTrigger : MonoBehaviour
{
    public UnityEvent onEnter;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            onEnter.Invoke();
        }
    }
}
