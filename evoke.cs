using UnityEngine;

public class evoke : MonoBehaviour
{
//Gameobject which has to be cloned
public GameObject a;
void Start()
{
InvokeRepeating("projectfile" , 0.02f,2.0f);
}
void projectfile()
{
GameObject obj = Instantiate(a);
obj.transform.position = new Vector3 (0.0f, 0.0f,0.0f);
}
}