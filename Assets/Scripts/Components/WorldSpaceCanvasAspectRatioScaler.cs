using UnityEngine;

public class WorldSpaceCanvasAspectRatioScaler : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private RectTransform _canvas;
    [SerializeField] private int _x;
    [SerializeField] private int _y;

    private void Start()
    {
        float defaultAspectRation = _x/(float)_y;

        if(defaultAspectRation > _camera.aspect)
        {
            // adjust width
            int newWidth = _y*_camera.pixelWidth/_camera.pixelHeight;

            _canvas.sizeDelta = new Vector2(newWidth, _y);
        }
        
        if(defaultAspectRation < _camera.aspect)
        {
            // adjust height
            int newHeight = _x*_camera.pixelHeight/_camera.pixelWidth;

            _canvas.sizeDelta = new Vector2(_x, newHeight);

        }
    }
}
