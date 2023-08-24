using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{

    public Material skyboxMat;
    private RenderTexture texture;
    private VideoPlayer videoPlayer;

    // Start is called before the first frame update
    void Awake()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        texture = new RenderTexture(4096,2160,32, RenderTextureFormat.ARGB32);
        videoPlayer.targetTexture = texture;
        skyboxMat.mainTexture = texture;
        

    }

}
