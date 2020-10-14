using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// This controls all the spooky non text game events and triggers the death system on 0% sanity
public class SpookyEvents : MonoBehaviour
{
    public int sanity = 100;
    public Text SanityHolder;

    public float SPOOK_MIN_TIME;
    public float SPOOK_MAX_TIME;

    private float curr_time;
    private float rand_time;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SanityHolder.text = sanity.ToString() + "%";
    }
}
