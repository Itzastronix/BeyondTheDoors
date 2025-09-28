using System.Collections;
using UnityEngine;

public class MainMenuCameraAnimation : MonoBehaviour
{
    [SerializeField] private float cameraAnimSpeed = 0.3f;
    [SerializeField] private Vector3 targetPosition = new Vector3(1.09f, 4.09f, 11.12f);
    [SerializeField] private Canvas uiCanvas;

    void Start()
    {
        transform.position = new Vector3(1.09f, 4.09f, 32.45f);


        uiCanvas.enabled = false;


        StartCoroutine(Cam_UI_Initialization());
    }

    IEnumerator Cam_UI_Initialization()
    {

        while (Vector3.Distance(transform.position, targetPosition) > 0.05f)
        {
            transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * cameraAnimSpeed);
            yield return null;
        }


        transform.position = targetPosition;

                                                                                                                           
        uiCanvas.enabled = true;
    }
}
