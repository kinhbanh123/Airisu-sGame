using UnityEngine;

public class RepeatBG : MonoBehaviour
{
    private float repeatHeight;
    private Vector3 startPos;

    [SerializeField] private float speed = 100f; 

    private RectTransform rectTransform;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        startPos = rectTransform.anchoredPosition;
        repeatHeight = rectTransform.rect.height; 
    }

    void Update()
    {
        // Di chuyển xuống
        rectTransform.anchoredPosition += Vector2.down * speed * Time.deltaTime;

        // Kiểm tra nếu BG ra khỏi màn hình, đưa lên lại
        if (rectTransform.anchoredPosition.y <= startPos.y - repeatHeight)
        {
            rectTransform.anchoredPosition += new Vector2(0, repeatHeight * 2);
        }
    }
}
