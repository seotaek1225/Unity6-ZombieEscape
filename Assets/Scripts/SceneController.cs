using UnityEngine;
using UnityEngine.SceneManagement;

namespace ZombieEscape
{
    public enum SceneName
    {
        Title = 0,
        Play
    }

    public class SceneController : Singleton<SceneController>
    {
        protected override void Awake()
        {
            base.Awake();
        }

        public void Load(SceneName _name)
        {
            SceneManager.LoadScene(_name.ToString());
        }
    }
}

