using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Creator : MonoBehaviour
{
    public Transform shortOb, tallOb, longOb;   //24, 46, 68, -12.5
    Random rnd = new Random();
    int shortPos, tallPos, longPos, holder, points = 0, counter = 0;
    public Text scoreText;
    public void Start()
    {
        points = 0;
        scoreText.text = "Points: " + points;
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
        shortOb.transform.Translate((shortOb.transform.position.x * -1) + shortPos * 24, 0, 0);
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
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            Start();
        }
    }
    private void FixedUpdate()
    {
        counter++;
        if (counter == 150)
        {
            counter = 0;
            points++;
            scoreText.text = "Points: " + points;
        }
    }
}
