using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
public class soundControl : MonoBehaviour
{
     public VideoPlayer videoPlayer;
    private Slider volumeSlider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        volumeSlider = GetComponent<Slider>;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
