using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionC : Enemy
{

    public override void Move()
    {
        Vector3 tempPos = pos;
        var ship = GameObject.Find("_Hero");

        if(tempPos.x >= ship.transform.position.x)
        {
            tempPos.x -= speed * Time.deltaTime;
        }else{
            tempPos.x += speed * Time.deltaTime;
        }
        if(tempPos.y >= ship.transform.position.y)
        {
            tempPos.y -= speed * Time.deltaTime;
        }else{
            tempPos.y += speed * Time.deltaTime;
        }

        pos = tempPos;
    }
}
