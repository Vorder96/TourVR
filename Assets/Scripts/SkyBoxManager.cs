using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkyBoxManager : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
	public void SetSky(Material mat)
	{
		RenderSettings.skybox = mat;
	}

	public void SetScene(string sceneName)
	{
		SceneManager.LoadSceneAsync(sceneName);
	}
}
