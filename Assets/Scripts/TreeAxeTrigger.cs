using UnityEngine;

public class TreeAxeTrigger : MonoBehaviour
{
    public AxeBehavior axeBehavior; // Reference to the AxeBehavior script

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            axeBehavior.SetIsNextToTree(true); // Notify the axe that the player is in range
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            axeBehavior.SetIsNextToTree(false); // Notify the axe that the player is out of range
        }
    }
}