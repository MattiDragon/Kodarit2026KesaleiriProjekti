using UnityEngine;

public class PartSelector : MonoBehaviour
{
    public Sprite[] options;

    private SpriteRenderer targetRenderer;

    private int currentIndex = 0;

    void Awake()
    {
        targetRenderer = GetComponent<SpriteRenderer>();
    }

    public void Previous()
    {
        currentIndex -= 1;

        if (currentIndex < 0)
        {
            currentIndex = options.Length - 1;
        }

        targetRenderer.sprite = options[currentIndex];
    }

    public void Next()
    {
        currentIndex += 1;

        if (currentIndex >= options.Length)
        {
            currentIndex = 0;
        }

        targetRenderer.sprite = options[currentIndex];
    }

    public int GetIndex()
    {
        return currentIndex;
    }

    public void SetIndex(int index)
    {
        currentIndex = index;
        targetRenderer.sprite = options[currentIndex];
    }

    public Color GetColor()
    {
        return targetRenderer.color;
    }

    public void SetColor(Color color)
    {
        targetRenderer.color = color;
    }
}
