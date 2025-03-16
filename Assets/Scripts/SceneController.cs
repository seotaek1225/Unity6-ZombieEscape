using UnityEngine;
using UnityEngine.SceneManagement;

namespace ZombieEscape
{
    public enum SceneName
    {
        Title = 0,
        Play
    }

    public class SceneController : MonoBehaviour
    {
        public static SceneController Instance;

        private void Awake()
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }

        public void Load(SceneName _name)
        {
            SceneManager.LoadScene(_name.ToString());
        }
    }
}

