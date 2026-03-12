using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFeel : MonoBehaviour
{

    public static GameFeel instance;
    public float cameraShakeTime = 0f;

    void Awake()
    {
        if (instance) Destroy(this);
        else instance = this;

    }

    public static void AddCameraShake(float Time)
    {
        if (instance)
        {
            instance.cameraShakeTime = Time;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (cameraShakeTime > 0f)
        {
            cameraShakeTime -= Time.deltaTime;
            Vector3 newCameraPosition = new Vector3();
            newCameraPosition.x = Random.Range(1.10f, 1.28f);
            newCameraPosition.y = Random.Range(2.77f, 2.90f);
            newCameraPosition.z = -10f;
            Camera.main.transform.position = newCameraPosition;

        }
    }
}
