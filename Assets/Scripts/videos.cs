using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class videos : MonoBehaviour
{
    public VideoPlayer[] videosApagar;

    public void Apaga()
    {
        for(int i= 0;i< videosApagar.Length; i++)
        {
            videosApagar[i].Stop();
        }
    }
}
