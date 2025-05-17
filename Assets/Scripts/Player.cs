using UnityEngine;

public class Player : MonoBehaviour
{

    private LayerMask mask;


    void Start()
    {
        mask = LayerMask.GetMask("Interactable");    
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 originPoint = Camera.main.transform.position;
        Vector3 direction = Camera.main.transform.forward;
        float maxDistance = 3f;

        //Debug.DrawLine(originPoint, originPoint + (direction * maxDistance), Color.green);
        Debug.DrawRay(originPoint, direction * maxDistance, Color.green);

        

        if (Input.GetMouseButtonDown(0))
            {
                RaycastHit hit;

                if (Physics.Raycast(originPoint, direction, out hit, maxDistance, mask))
                {
                    //Debug.Log("Hit: " + hit.collider.name);

                    IInteractable comp = hit.collider.GetComponent<IInteractable>();
                    if (comp != null)
                    {
                        comp.Interact();
                    }
                }
            }

        if (Input.GetKeyDown(KeyCode.I)) {

            GameManager.instance.ToggleInventoryPanel();
        }
    }
}
