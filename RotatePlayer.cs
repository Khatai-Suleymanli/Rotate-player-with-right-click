using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlayer : MonoBehaviour
{
    public GameObject player;
    public float preciseness = 0.95f;
    public Vector3 direction;
    public Vector3 CamLookDirection;
    public Vector3 playerLookDirection;


    // Update is called once per frame




    private void OnDrawGizmos()
    {
        Vector3 playerPos = player.transform.position;
        playerLookDirection = player.transform.forward;
        CamLookDirection = transform.forward;

        Gizmos.color = Color.green;
        Gizmos.DrawLine(playerPos ,playerPos + playerLookDirection);
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(playerPos, playerPos + CamLookDirection);
    }

    void Update()
    {

        bool backPressed = Input.GetKey(KeyCode.S)?true:false;

        Vector3 playerLookDirection = player.transform.forward;
        Vector3 CamLookDirection = transform.forward;

        float DotProduct = Vector3.Dot(playerLookDirection, CamLookDirection);

        bool isLooking = DotProduct > preciseness;
       



        
        if (!isLooking && Input.GetKey(KeyCode.Mouse1))
        {
            //player.transform.rotation = Quaternion.Euler(player.transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, player.transform.rotation.eulerAngles.z);

            player.transform.rotation = Quaternion.Lerp(player.transform.rotation, Quaternion.Euler(player.transform.rotation.eulerAngles.x,
            transform.rotation.eulerAngles.y, player.transform.rotation.eulerAngles.z), Time.deltaTime * 15f);
        }

    }
}
