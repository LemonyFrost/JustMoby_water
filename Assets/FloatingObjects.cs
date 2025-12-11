using UnityEngine;

public class FloatingObjects : MonoBehaviour
{
    
    [SerializeField] private float _speed;
    
    void Update()
    {
        float newposX = transform.position.x + Time.deltaTime * _speed; 
        float newposZ = transform.position.z + Time.deltaTime * _speed;
                
        transform.position = new Vector3(newposX, transform.position.y, newposZ);
        
    }
}
