using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hat : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            this.gameObject.SetActive(false);
            GameManager.instance.photonView.RPC("GiveHat", RpcTarget.All, GameManager.instance.GetPlayer(other.gameObject).id, true);
        }
    }
}
