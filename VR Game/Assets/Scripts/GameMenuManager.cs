using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameMenuManager : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float spawnDistance = 2;
    [SerializeField] GameObject menu;
    [SerializeField] InputActionProperty showButton;

    void Update()
    {
        if (showButton.action.WasPerformedThisFrame())
        {
            menu.SetActive(!menu.activeSelf);
            menu.transform.position = player.position + new Vector3(player.forward.x, 0, player.forward.z).normalized * spawnDistance;
            //menu.transform.forward *= -1;
            menu.transform.LookAt(new Vector3(player.position.x, menu.transform.position.y, player.position.z));

            Debug.Log(player.position);
        }
        menu.transform.LookAt(new Vector3(player.position.x, menu.transform.position.y, player.position.z));
        menu.transform.forward *= -1;
    }
}
