using UnityEngine;

public class Volume : MonoBehaviour
{

   
    private AudioSource Audio;


    private float musicVol = 1f;


    void Start()
    {

      
        Audio = GetComponent<AudioSource>();
    }


    void Update()
    {

      
        Audio.volume = musicVol;
    }

    public void SetVol(float vol)
    {
        musicVol = vol;
    }
}