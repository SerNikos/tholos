using System.Collections;
using UnityEngine;

public class SkyboxFade : MonoBehaviour
{
    public Material skybox1;
    public Material skybox2;

    void Start()
    {
        RenderSettings.skybox = skybox1;
        FadeToSkybox2();
    }

    public void FadeToSkybox2()
    {
        StartCoroutine(Fade(skybox2));
    }

    IEnumerator Fade(Material newSkybox)
    {
        float t = 0.0f;
        while (t < 3.0f)
        {
            t += Time.deltaTime;
            RenderSettings.skybox.Lerp(skybox1, newSkybox, t);
            yield return null;
        }
        RenderSettings.skybox = newSkybox;
    }
}