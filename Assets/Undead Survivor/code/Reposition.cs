using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reposition : MonoBehaviour
{

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!collision.CompareTag("Area"))
        {
            return;
        }
        Vector3 playerPos = GameManager.Instance.transform.position;
        Vector3 myPos = transform.position;

        float difX = Mathf.Abs(playerPos.x - myPos.x);
        float difY = Mathf.Abs(playerPos.y - myPos.y);

        Vector3 playerDir = GameManager.Instance.player.inputVec;
        float dirX = playerDir.x < 0 ? -1 : 1;
        float dirY = playerDir.y < 0 ? -1 : 1;


        switch (transform.tag) {
            case "Ground":
                // logic
                if (difX > difY) // 좌우 이동반경이 더 큼
                {
                    transform.Translate(Vector3.right * dirX * 40);
                }
                else if(difX < difY) // 상하 이동반경이 더 큼
                {
                    transform.Translate(Vector3.up * dirY * 40);
                }
                break;

            case "Enemy":
                // logic collision
                break;
        }

    }
}
