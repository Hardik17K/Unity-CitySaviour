
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    private Enemy[] _enemies;
    private static int _nextLevel = 1;

    private void OnEnable()
    {
        _enemies = FindObjectsOfType<Enemy>();    
    }

    void Update()
    {
        foreach(Enemy enemy in _enemies)
        {
            if(enemy!=null)
                return;
        }  

        Debug.Log("You Killed All Enemies");

        _nextLevel++;
        string nextLevelName = "Level" + _nextLevel;

        SceneManager.LoadScene(nextLevelName);
    }
    
}
