//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class FireBall : MonoBehaviour
//{
//    private GameObject Boss;
//    private Animator animator;
//    private Collider2D collider2d;

//    private Vector3 dir;

//    public float Speed;

//    public float Damge;

//    public float LifeTime;

//    public BossTime fireCentipede；

//    void Start()
//    {
//        Boss = GameObject.Find("Boss");
//        animator = GetComponent<Animator>();
//        collider2d = GetComponent<Collider2D>();

//        fireCentipede = GetComponent<FireCentipede>();

//        dir = transform.localScale;

//        Speed = 5;

//        Damge = 8f;

//        LifeTime = 7f;
//    }

//    void Update()
//    {
//        Move();
//        LifeTime -= Time.deltaTime;
//        if (LifeTime <= 0 || fireCentipede.isDead)
//        {
//            Destroy(gameObject);
//        }
//    }
//    public void Move()
//    {
//        if (Boss.transform.localScale.x < 0)
//        {
//            transform.localScale = new Vector3(dir.x, dir.y, dir.z);
//            transform.position += Speed * -transform.right * Time.deltaTime;
//        }
//        else if (Boss.transform.localScale.x > 0) 
//        {
//            transform.localScale = new Vector3(-dir.x, dir.y, dir.z);
//            transform.position += Speed * transform.right * Time.deltaTime;
//        }
//    }
//    public void CloseCollider() 
//    {
//        collider2d.enabled = false;
//    }





    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.CompareTag("Player"))
    //    {
    //        animator.Play("Hit");
    //        if (transform.position.x < collision.transform.position.x)
    //        {
    //            collision.GetComponent<Player>().BeHit(Vector2.right,Damge);
    //        }
    //        else if (transform.position.x >= collision.transform.position.x)
    //        {
    //            collision.GetComponent<Player>().BeHit(Vector2.left,Damge);
    //        }

    //    }
    //    else if (collision.CompareTag("Ground")) 
    //    {
    //        animator.Play("Hit");
    //    }
    // }
//}
