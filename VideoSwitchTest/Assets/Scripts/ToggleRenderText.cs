using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class ToggleRenderText : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public RawImage rawImage;
    public RenderTexture rtLow;
    public RenderTexture rtHigh;

    private bool _Toggle;

    private void Start()
    {
        videoPlayer.targetTexture = rtLow;
        rawImage.texture = rtLow;

        Debug.Log("Press SPACE to toggle render textures...");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _Toggle = !_Toggle;

            if (_Toggle)
            {
                videoPlayer.targetTexture = rtHigh;
                rawImage.texture = rtHigh;
                Debug.Log("Set to HIGH");
            }
            else
            {
                videoPlayer.targetTexture = rtLow;
                rawImage.texture = rtLow;
                Debug.Log("Set to LOW");
            }
        }
    }
}
