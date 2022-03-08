using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataSource : MonoBehaviour
{
    [Range(0.0f, Mathf.PI/2)]
    public float PhaseSineWave1 = 0.0f;
    private float PhaseSineWave1SignChange = 1.0f;

    [Range(0.0f, Mathf.PI/2)]
    public float PhaseSineWave2 = Mathf.PI/2;

    public float Data1 {get; private set;}
    public float Data2 {get; private set;}

    void FixedUpdate()
    {
        Data1 = Mathf.Sin(PhaseSineWave1 + Time.realtimeSinceStartup);
        Data2 = Mathf.Sin(PhaseSineWave2 + Time.realtimeSinceStartup);

        PhaseSineWave1 += PhaseSineWave1SignChange * 0.003f;
        
        if(PhaseSineWave1 > Mathf.PI/2 || PhaseSineWave1 < 0.0f)
            PhaseSineWave1SignChange *= -1;
    }
}
