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
        currentIndex--;

        if (currentIndex < 0)
        {
            currentIndex = options.Length - 1;
        }

        spriteLibrary.spriteLibraryAsset = options[currentIndex];
    }

    public void Next()
    {
        currentIndex++;
        
        if (currentIndex >= options.Length)
        {
            currentIndex = 0;
        }

        spriteLibrary.spriteLibraryAsset = options[currentIndex];
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
        spriteLibrary.spriteLibraryAsset = options[currentIndex];
    }

    public int GetIndex()
    {
        return currentIndex;
    }
}
