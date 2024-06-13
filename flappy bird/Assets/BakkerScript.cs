using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class BakkerScript : MonoBehaviour
{
    public GameObject Friekandelbroodje;
    public float SpawnRate = 2;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        SpawnFriekandelbroodje();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < SpawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            SpawnFriekandelbroodje();
            timer = 0;
        }
    }
    void SpawnFriekandelbroodje()
    {
        Instantiate(Friekandelbroodje, transform.position, transform.rotation);
    }
}
