using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRaycast : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;

    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (Input.GetMouseButtonDown(0))
                {
                    Debug.Log(hit.collider.name);
                    StartCoroutine(ChangeScene(hit.collider.GetComponent<HotSpot>().targetScene));
                }
            }
    }

    IEnumerator ChangeScene(string targetScene)
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene(targetScene);
    }
}