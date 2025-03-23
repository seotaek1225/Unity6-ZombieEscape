using UnityEngine;

namespace ZombieEscape
{
    public class TitleScene : MonoBehaviour
    {
        void Update()
        {
            if (Input.anyKey == true)
            {
                SceneController.Instance.Load(SceneName.Play);
            }
        }
    }
}