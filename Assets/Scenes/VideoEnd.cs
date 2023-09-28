using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VideoEnd : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    //ulong numberFramesInVideo; //���������� ������ � ����� (��� ulong ������� ��������)

    //void Start()
    //{
    //    numberFramesInVideo = videoPlayer.frameCount;
    //    //Debug.Log("FramesInVideo:" + numberFramesInVideo + "Frame" + videoPlayer.frame);
    //}

    //public void Update()
    //{
    //    if ((ulong)videoPlayer.frame >= numberFramesInVideo) SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    //    Debug.Log("FramesInVideo:" + numberFramesInVideo + "Frame" + videoPlayer.frame);
    //}


    void OnEnable() //������� ����������� ���� ������� �� ������� ����� �����
    {
        videoPlayer.loopPointReached += OnVideoEnd;
    }

    void OnDisable() //���������� ��� �������������� ������ ������
    {
        videoPlayer.loopPointReached -= OnVideoEnd;
    }

    void OnVideoEnd(UnityEngine.Video.VideoPlayer causedVideoPlayer)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }








}




