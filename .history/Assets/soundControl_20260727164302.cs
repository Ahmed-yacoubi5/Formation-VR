using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class SoundControl : MonoBehaviour
{
    [SerializeField] private VideoPlayer videoPlayer;
    private Slider volumeSlider;
    private bool isPlaying = false;
    void Start()
    {
        volumeSlider = GetComponent<Slider>();
        StopVideo();
        // Valeur du slider entre 0 et 1
        volumeSlider.minValue = 0f;
        volumeSlider.maxValue = 1f;
        volumeSlider.value = 1f;

        volumeSlider.onValueChanged.AddListener(ChangeVolume);

        ChangeVolume(volumeSlider.value);
    }

    void ChangeVolume(float volume)
    {
        // Track audio 0
        videoPlayer.SetDirectAudioVolume(0, volume);
    }

    private void OnDestroy()
    {
        if (volumeSlider != null)
            volumeSlider.onValueChanged.RemoveListener(ChangeVolume);
    }

    public void PlayVideo()
    {
        videoPlayer.Play();
    }
    public void StopVideo()
    {
        videoPlayer.Stop();
    }
}