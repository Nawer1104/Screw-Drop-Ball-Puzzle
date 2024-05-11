using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject vfxDestroy;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision != null && collision.gameObject.CompareTag("box"))
        {
            GameObject vfx = Instantiate(vfxDestroy, transform.position, Quaternion.identity) as GameObject;
            Destroy(vfx, 1f);

            gameObject.SetActive(false);

            GameManager.Instance.levels[GameManager.Instance.GetCurrentIndex()].gameObjects.Remove(gameObject);
            GameManager.Instance.CheckLevelUp();
        }
    }
}
