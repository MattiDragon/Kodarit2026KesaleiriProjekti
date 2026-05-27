using UnityEngine;
using UnityEngine.U2D.Animation;

public class PartSelector : MonoBehaviour
{
    public SpriteLibraryAsset[] options;

    private SpriteRenderer targetRenderer;
    private SpriteLibrary spriteLibrary;

    private int currentIndex = 0;

    void Awake()
    {
        targetRenderer = GetComponent<SpriteRenderer>();
        spriteLibrary = GetComponent<SpriteLibrary>();
    }

    public void Previous()
    {
        currentIndex -= 1;

        if (currentIndex < 0)
        {
            currentIndex = options.Length - 1;
        }

        spriteLibrary.spriteLibraryAsset = options[currentIndex];
    }

    public void Next()
    {
        currentIndex += 1;

        if (currentIndex >= options.Length)
        {
            currentIndex = 0;
        }

        spriteLibrary.spriteLibraryAsset = options[currentIndex];
    }

    public int GetIndex()
    {
        return currentIndex;
    }

    public void SetIndex(int index)
    {
        currentIndex = index;
        spriteLibrary.spriteLibraryAsset = options[currentIndex];
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
