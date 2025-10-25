using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegmentGenerator : MonoBehaviour
{
    public GameObject segmentMap01;
    public GameObject segmentMap02;
    public GameObject segmentMap03;
    public GameObject segmentMap04;
    public GameObject segmentMap05;
    public GameObject segmentMap06;
    public GameObject segmentMap07;
    public GameObject segmentMap08;
    public GameObject segmentMap09;
    public GameObject segmentMap10;
    public GameObject segmentMap11;
    public GameObject segmentMap12;

    void Start()
    {
        StartCoroutine(SegmentGeneratorCoroutine());
    }

    IEnumerator SegmentGeneratorCoroutine()
    {
        yield return new WaitForSeconds(10);
        segmentMap02.SetActive(true);

        yield return new WaitForSeconds(10);
        segmentMap03.SetActive(true);
    }
}
