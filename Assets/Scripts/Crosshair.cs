using UnityEngine;
using UnityEngine.UI;

namespace ZombieEscape
{
    public class Crosshair : MonoBehaviour
    {
        public Image imageCrosshair;

        public float crosshairSize = 64f;
        public Color normalColor = Color.black;
        public Color hitColor = Color.red;

        void Awake()
        {
            imageCrosshair.rectTransform.sizeDelta = new Vector2(crosshairSize, crosshairSize);
            imageCrosshair.color = normalColor;
        }

        public void OnTargetHit()
        {
            imageCrosshair.color = hitColor;
            Invoke("resetColor", 0.4f);
        }

        private void resetColor()
        {
            imageCrosshair.color = normalColor;
        }
    }
}