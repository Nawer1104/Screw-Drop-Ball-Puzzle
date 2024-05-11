using UnityEngine;
using DG.Tweening;

public class Stick : MonoBehaviour
{
    private new PolygonCollider2D collider2D;

    public GameObject stick_1;
    public GameObject stick_2;
    public GameObject X;

    private void Awake()
    {
        collider2D = GetComponent<PolygonCollider2D>();
    }

    private void OnMouseDown()
    {
        collider2D.enabled = false;

        X.SetActive(false);

        stick_1.transform.DORotate(Vector3.zero, 1f);
        stick_2.transform.DORotate(Vector3.zero, 1f);
    }
}
