﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapAnimation : MonoBehaviour
{
    private float timeout = 0.75f;

    public RawImage mySelf;

    public List<Texture> images = new List<Texture>();

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Animation());
    }

    private IEnumerator Animation() {
        foreach (Texture image in images)
        {
            mySelf.texture = image;
            yield return new WaitForSeconds(timeout);
        }

        yield return null;
    }
}