using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class movement : MonoBehaviour
{

private Rigidbody rb;
public int speed;
private int count;
public AudioSource coin;
public Text t1;


// Start is called before the first frame update
void Start()
{
rb = GetComponent<Rigidbody>();

}

// Update is called once per frame
void Update()
{
float Horizontal = Input.GetAxis("Horizontal");
float Vertical = Input.GetAxis("Vertical");
float y = 0.0f;
if(Input.GetKeyDown(KeyCode.Space)){
    y = 20f;
}
Vector3 movement = new Vector3(Horizontal,y,Vertical);
    rb.AddForce(movement* speed);

}
    void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("welcome")){
            Debug.Log("Welcome To The Game");
        }
        
        if(other.gameObject.CompareTag("coin"))
        {   
            other.gameObject.SetActive(false);
            count++;
            t1.text = "Score: " + count.ToString();
            Debug.Log(count);
            coin.Play();
            
        }
        if(other.gameObject.CompareTag("speedmod"))
        {
            speed -= 10;
            Debug.Log(speed);
        }
        if(other.gameObject.CompareTag("speedmod2"))
        {
            speed -= 20;
            Debug.Log(speed);
        }
        if(speed <= 0){
            SceneManager.LoadScene(1);
        }
        
    }
}