using UnityEngine;
using SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    void OnCollisionEnter (Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "Friendly":
            Debug.Log("Start!");
            break;

            case "Finish":
            Debug.Log("Congratulations!");
            break;

            case "Fuel":
            Debug.Log("Refueled!");
            break;

            default:
            Debug.Log("Crash and burn, man!");
            break;
        }
    }
}
