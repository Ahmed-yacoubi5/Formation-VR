using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
public class soundControl : MonoBehaviour
{
     public VideoPlayer videoPlayer;
    private SLider volumeSlider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        videoPlayer = GetComponent<videoPlayer>;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
