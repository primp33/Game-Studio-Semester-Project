//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class EnemyMovement : MonoBehaviour
//{
//    public Vector3 targetPosition;
//    public float mySpeed;
    
//    Animator myAnim;
//    Vector3 originPosition, turnPoint;

//    bool isFirstTimeIdle;

//    private void awake(){
//        myAnim = GetComponent<Animator>();
//        originPosition = new Vector3(transform.position.x, transform.position.y,transform.position.z);

//        isFirstTimeIdle = true;
//    }

//    // Update is called once per frame
//    void Update()
//    {
//       if(transform.position.x == targetPosition.x)
//       {
//        myAnim.SetTrigger("Idle");
//        turnPoint = originPosition;
//        StartCoroutine(Turn(true));
//        isFirstTimeIdle = false;

//       }
//       else if(transform.position.x == originPosition.x)
//       {
//         if(!isFirstTimeIdle){
//            myAnim.SetTrigger("Idle");
//        }
        
//        turnPoint = targetPosition;
//        StartCoroutine(Turn(false));
//       }
       
//       if(myAnim.GetCurrentAnimatorStateInfo(0).IsName("Walk"))
//       {
//          transform.position = Vector.MoveTowards(transform.position, turnPoint, mySpeed * Time.deltaTime);
//       }
       
//    }
//      IEnumerator Trun(bool TurnRight){
//        yield return new WaitForSeconds(2.0f);
//        if(TurnRight){
//        transform.localScale = new Vector3(1.0f,1.0f,1.0f);
//        }
//        else if (!TurnRight){
//        transform.localScale = new Vector3(-1.0f,1.0f,1.0f);
//        }
        
//      }

//}
