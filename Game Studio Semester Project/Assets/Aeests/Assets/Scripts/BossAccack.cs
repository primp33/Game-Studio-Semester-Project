//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class BossAccack : MonoBehaviour
//{
//    public AudioSource HitAudio;
//    public AudioSource AttackAudio;
//    public Animator EffectAni;//特效的播放
//    public GameObject Fireball;//火球的预制体
//    public GameObject FirePillar;//火柱的预制体
//    public GameObject Player;//获取到玩家的位置
//    public GameObject Pillar1;//平台一
//    public GameObject Pillar2;//平台二

//    public float FirePillarCd;
//    public float time;

//    public int FireBallAttackTime;
//    public int FirePillarAttackTime;

//    public bool isHit;
//    public bool isDead;

//    public enum BossState
//    {
//        FireBall,
//        FirePillar,
//        Dash,
//        Idle,
//        BeHit,
//        Death,
//    }

//    // Start is called before the first frame update
//    void Start()
//    {

//    }

//    // Update is called once per frame
//    void Update()
//    {

//    }

//    void awake()
//    {
//        C_tra = GetComponent<Transform>();
//        C_rig = GetComponent<Rigidbody2D>();
//        C_ani = GetComponent<Animator>();
//        FireBallAttackTime = 3;
//        FirePillarAttackTime = 7;

//        Initial = C_tra.localScale;
//    }
//    public void FireBallAttack() //吐火球
//    {
//        C_ani.Play("Attack");
//        FirePillarCd -= Time.deltaTime;
//        if (FireBallAttackTime <= 0 && !isDead)
//        {
//            state = BossState.Idle;
//        }
//        else if (isDead)
//        {
//            state = BossState.Death;
//        }
//    }
//    public void FireBallCreate() //生成火球(动画帧事件)
//    {
//        if (transform.position.localScale.x == Initial.x)
//        {
//            for (int i = -5; i < 2; i++)
//            {
//                GameObject fireball = Instantiate(Fireball, null);
//                Vector3 dir = Quaternion.Euler(0, i * 15, 0) * -transform.right;
//                fireball.transform.position = Mouth.position + dir * 1.0f;
//                fireball.transform.rotation = Quaternion.Euler(0, 0, i * 15);
//            }
//        }
//        else if (C_tra.localScale.x == -Initial.x)
//        {
//            for (int i = -1; i < 5; i++)
//            {
//                GameObject fireball = Instantiate(Fireball, null);
//                Vector3 dir = Quaternion.Euler(0, i * 15, 0) * transform.right;
//                fireball.transform.position = Mouth.position + dir * 1.0f;
//                fireball.transform.rotation = Quaternion.Euler(0, 0, i * 15);
//            }
//        }
//        FireBallAttackTime -= 1;
//    }
//    public void FirePillarAttack() //火柱攻击
//    {
//        C_ani.Play("OtherAttack");
//        background.isChange = true;
//        Pillar1.GetComponent<Collider2D>().enabled = false;
//        Pillar2.GetComponent<Collider2D>().enabled = false;
//        FirePillarCd = 20f;
//        if (FirePillarAttackTime <= 0 && !isDead)
//        {
//            time -= Time.deltaTime;
//            if (time <= 0)
//            {
//                state = BossState.Idle;
//                time = 1;
//            }
//        }
//        else if (isDead)
//        {
//            state = BossState.Death;
//        }
//    }
//    public void CreateFirePillar() //生成火柱（动画帧事件）
//    {
//        for (int i = 0; i < 5; i++)
//        {
//            int r = Random.Range(-14, 14);
//            GameObject firepillar = Instantiate(FirePillar, null);
//            firepillar.transform.position = new Vector3(r, 6, 0);
//        }
//        FirePillarAttackTime -= 1;
//    }
//}
