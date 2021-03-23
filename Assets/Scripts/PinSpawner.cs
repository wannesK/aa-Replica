using UnityEngine;

public class PinSpawner : MonoBehaviour
{
    public GameObject pinPrefeb;

    private void Update()
    {       
        SpawnPin();        
    }
    private void SpawnPin()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(pinPrefeb, transform.position, transform.rotation);
        }        
    }
}
