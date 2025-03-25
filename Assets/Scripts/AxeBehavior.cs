using UnityEngine;

public class AxeBehavior : MonoBehaviour
{
    public GameObject tree;
    public GameObject choppedTree;
    public GameObject treeAxeTrigger;
    public GameObject visibleSign;
    public AudioSource treeFallingSFX;
    
    private bool isNextToTree;

    public void SetIsNextToTree(bool value)
    {
        isNextToTree = value;
    }

    private void ChopTree()
    {
        if (tree != null && choppedTree != null)
        {
            tree.SetActive(false);
            choppedTree.SetActive(true);
        }
    }

    public void ChopTreeIfInRange()
    {
        if (isNextToTree)
        {
            ChopTree();
            treeFallingSFX.Play();
            visibleSign.SetActive(true);
        }
    }
}
