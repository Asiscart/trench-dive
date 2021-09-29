
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform target;
    

    public Vector3 offset;

    private void LateUpdate()//LateUpdate sempre s'executa despres de l'update, aixi el moviment de la camera no s'encalla
    {
        transform.position = target.position + offset;
    }
}
