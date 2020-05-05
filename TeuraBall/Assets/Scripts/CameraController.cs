using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
	//položaj kamere u odnosu na lopticu
    public GameObject player;

    private Vector3 offset;

    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}