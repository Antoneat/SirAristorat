using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PMov : MonoBehaviour
{
    Vector3 targetPosition;
    Vector3 lookAtTarget;
    Quaternion playerRot;
    public LayerMask IgnoreMe;

   float rotSpeed = 5f; //vel de rotacion
   public float speed = 10f; //vel mov

    bool moving;
    void Start()
    {
        moving = false;
       
    }

  
    void Update()
    {

        if (Input.GetMouseButton(0)) //0 para boton izquierdo del mouse, 1 pa derecho, si el boton izquierdo es presionado/input ir a set target yadaya
        {
            SetTargetPosition();
          
        }
        
        if (moving)
        {
            Move();
        }
    }

    public void SetTargetPosition() //aqui le dice que si presionas un lugar toma la direccion del lugar y t manda al lugar
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //castea el ray hacia donde clikeaste, hit point es donde esta el colider. aqui declare ray
        RaycastHit hit; //aqui declare el hit
       

        if (Physics.Raycast(ray, out hit, 1000, IgnoreMe)) //con esto le di su valor al ray, ray lo manda a donde debe ir, out hit devuelve la posicion donde cayo la wea, 1000 es la distancia que recorrera el ray
        {
            targetPosition = hit.point;  // this.transform.LookAt(targetPosition); //look at hace que mire a donde le dices, en este caso al target pos
            if (Vector3.Distance(this.transform.position, targetPosition) >= 1.3f)
            {
                lookAtTarget = new Vector3(targetPosition.x - transform.position.x, transform.position.y, targetPosition.z - transform.position.z);  // asi solo se voltea en x y z
                playerRot = Quaternion.LookRotation(lookAtTarget); //rotacion para mirar al target, se fija el angulo que tienes que rotar
                moving = true;
            }
            
            
        }
    }

    public void Move()
    {
        
        transform.rotation = Quaternion.Slerp(transform.rotation, playerRot, rotSpeed * Time.deltaTime);        //transform.position = Vector3.Lerp(starPos, endPos, speed * Time.deltaTime);
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        if (Vector3.Distance(this.transform.position, targetPosition) <= 1.3f)  //(transform.position == targetPosition)
        {
            moving = false;
        }              
    }


    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "walls")
        {
           moving = false;
        }
    }
}
