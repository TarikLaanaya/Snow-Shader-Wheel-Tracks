using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelTracks : MonoBehaviour
{
    public Shader drawShader;

    private Material snowMaterial, drawMaterial; 

    private RenderTexture splatMap;

    [Range(0,2)]
    public float brushSize;

    [Range(0,1)]
    public float BrushStrength;

    public GameObject terrain;

    public Transform[] wheel;

    RaycastHit groundHit;

    int layerMask;

    // Start is called before the first frame update
    void Start()
    {
        layerMask = LayerMask.GetMask("Ground");

        drawMaterial = new Material(drawShader);

        snowMaterial = terrain.GetComponent<MeshRenderer>().material;
        splatMap = new RenderTexture(1024, 1024, 0, RenderTextureFormat.ARGBFloat);
        snowMaterial.SetTexture("_Splat", splatMap);
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < wheel.Length; i++)
        {
            if (Physics.Raycast(wheel[i].position, -Vector3.up, out groundHit))
            {
                drawMaterial.SetVector("_Coordinate", new Vector4(groundHit.textureCoord.x, groundHit.textureCoord.y, 1, layerMask));
                drawMaterial.SetFloat("_Strength", BrushStrength);
                drawMaterial.SetFloat("_Size", brushSize);
                RenderTexture temp = RenderTexture.GetTemporary(splatMap.width, splatMap.height, 0, RenderTextureFormat.ARGBFloat);
                Graphics.Blit(splatMap, temp);
                Graphics.Blit(temp, splatMap, drawMaterial);
                RenderTexture.ReleaseTemporary(temp);
            }
        }
    }
}
