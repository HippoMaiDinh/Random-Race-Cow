using UnityEngine;

public class ObjectConllision : MonoBehaviour
{
    public bool  isWorking = false;

    private void OnTriggerEnter2D(Collider2D collider) 
    {
        isWorking = true;
        Debug.Log("đã chạm");
    }

} 