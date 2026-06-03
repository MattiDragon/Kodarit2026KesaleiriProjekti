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
        currentIndex--;

        if (currentIndex < 0)
        {
            currentIndex = options.Length - 1;
        }

        targetRenderer.sprite = options[currentIndex];
    }

    public void Next()
    {
        currentIndex++;
        
        if (currentIndex >= options.Length)
        {
            currentIndex = 0;
        }

        targetRenderer.sprite = options[currentIndex];
    }

    public void SetColor(Color color)
    {
        targetRenderer.color = color;
    }

    public Color GetColor()
    {
        return targetRenderer.color;
    }

    public void SetIndex(int newIndex)
    {
        currentIndex = newIndex;
    }

    public int GetIndex()
    {
        return currentIndex;
    }
}
