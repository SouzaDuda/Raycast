using UnityEngine;

public class raycast : MonoBehaviour
{
    RaycastHit rayhit;

    void Start()
    {
        Debug.Log("inicio");

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit rayhit;
        Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2));
        if (Physics.Raycast(ray, out rayhit, 1f))
        {
            if (rayhit.collider.tag == "object")
            {
                Debug.Log("Olhou");
                Destroy(rayhit.collider.gameObject);
            }
        }

    }
}