using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    [HideInInspector]
    public Rigidbody2D rb;

    [Space]
    [Header("����ֵ")]
    public float speed = 10;
    [Space]
    [Header("�������ֵ")]
    public float x;
    public float y;
    public float xRaw;
    public float yRaw;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        xRaw = Input.GetAxisRaw("Horizontal");
        yRaw = Input.GetAxisRaw("Vertical");

        //�˶��в��Ų�Ӱ��ʹ�ö����
        if (x != 0 || y != 0) 
        {
            ObjectPool.instance.GetOut("Shadow", transform.position);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(x * speed * Time.timeScale, y * speed * Time.timeScale);
    }
}
