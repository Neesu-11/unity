using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Load : MonoBehaviour
{
    // Start is called before the first frame update
   public void Load_Game(){
    SceneManager.LoadScene(2);
   }
  public void quitgame()
{
UnityEditor.EditorApplication.isPlaying= false;
}
public void pausebtn()
{
Time.timeScale=0;
}
public void restartbtn()
{
Time.timeScale=1;
}

}
