using UnityEngine;

public class DynamicCameraClipFix : MonoBehaviour
{
    void Start()
    {
        Renderer[] renderers = GetComponentsInChildren<Renderer>();
        foreach (Renderer rend in renderers)
        {
            Bounds newBounds = rend.bounds;
            newBounds.Expand(10f);
            rend.bounds.Encapsulate(newBounds.center + new Vector3(10f, 10f, 10f));
        }
    }
}
  //didnt fixed 