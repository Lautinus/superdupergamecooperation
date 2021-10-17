using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]

public class BackgroundScale : MonoBehaviour
{
    public Camera Camera;
    public SpriteRenderer SpriteRender;

    // Start is called before the first frame update
    void Start()
    {
       float worldSpaceHeight = Camera.orthographicSize * 2;
       float worldSpaceWidth = worldSpaceHeight * Camera.aspect;

        SpriteRender.size = new Vector2(worldSpaceWidth, worldSpaceHeight);

    }

    // Update is called once per frame
    void Update()
    {
       float worldSpaceHeight = Camera.orthographicSize * 2;
       float worldSpaceWidth = worldSpaceHeight * Camera.aspect;

      SpriteRender.size = new Vector2(worldSpaceWidth, worldSpaceHeight);
    }
}
