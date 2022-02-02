using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour



{
    // Start is called before the first frame update

    public float speed = 10f;
    private float maxX=2.55f;
    private float minX=-2.55f;
    

    // Update is called once per frame
    void Update()
    {
        MovePlayer();


    }

    void MovePlayer(){

        float h = Input.GetAxis("Horizontal");
        Vector2 currentPosition = transform.position;

        if(h > 0){
            // sağ yön
            currentPosition.x += speed * Time.deltaTime;
        }else if(h < 0){ 
            // sol yön
            currentPosition.x -= speed * Time.deltaTime;
        }

        if(currentPosition.x < minX){
            currentPosition.x = minX;
        }
        if(currentPosition.x > maxX){
            currentPosition.x = maxX;
        }

        transform.position = currentPosition;

    }

    void OnTriggerEnter2D(Collider2D target){

        if(target.tag == "Bomb"){

            Time.timeScale = 0f;
            
        }
    }
}
