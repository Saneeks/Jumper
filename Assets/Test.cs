using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public Transform shortOb, tallOb, longOb;   //24, 46, 68, -12.5
    Random rnd = new Random();
    int shortPos, tallPos, longPos, holder;
    public void Start()
    {

        shortPos = Random.Range(1, 4);
        while (true)
        { 
            holder = Random.Range(1, 4);
            if (holder != shortPos)
            {
                tallPos = holder;
                break;
            }
        }
        while (true)
        {
            holder = Random.Range(1, 4);
            if (holder != shortPos && holder != tallPos)
            {
                longPos = holder;
                break;
            }
        }
        shortOb.transform.Translate((shortOb.transform.position.x * -1) + shortPos* 24, 0, 0);
        tallOb.transform.Translate((tallOb.transform.position.x * -1) + tallPos * 24, 0, 0);
        longOb.transform.Translate((longOb.transform.position.x * -1) + longPos * 24, 0, 0);
    }
    void Update()
    {
        if (shortOb.transform.position.x <= -12.5 && tallOb.transform.position.x <= -12.5 && longOb.transform.position.x <= -12.5)
        {
            shortPos = Random.Range(1, 4);
            while (true)
            {
                holder = Random.Range(1, 4);
                if (holder != shortPos)
                {
                    tallPos = holder;
                    break;
                }
            }
            while (true)
            {
                holder = Random.Range(1, 4);
                if (holder != shortPos && holder != tallPos)
                {
                    longPos = holder;
                    break;
                }
            }
            shortOb.transform.Translate((shortOb.transform.position.x * -1) + shortPos * 12.5f, 0, 0);
            tallOb.transform.Translate((tallOb.transform.position.x * -1) + tallPos * 12.5f, 0, 0);
            longOb.transform.Translate((longOb.transform.position.x * -1) + longPos * 12.5f, 0, 0);
        }
    }
}
