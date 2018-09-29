using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AccuracyFade : MonoBehaviour {

    public float FadeRate;
    private Image image;
    private float targetAlpha;

    public List<Sprite> images;
    // Use this for initialization
    void Start()
    {
        this.image = this.GetComponent<Image>();
        if (this.image == null)
        {
            Debug.LogError("Error: No image on " + this.name);
        }
        this.targetAlpha = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        Color curColor = this.image.color;
        float alphaDiff = Mathf.Abs(curColor.a - this.targetAlpha);
        if (alphaDiff > 0.0001f)
        {
            curColor.a = Mathf.Lerp(curColor.a, targetAlpha, this.FadeRate * Time.deltaTime);
            this.image.color = curColor;
        }
    }

    public void ChangeImage(int key)
    {
        this.image.sprite = images[key];
        Color newColor = this.image.color;
        newColor.a = 1f;
        this.image.color = newColor;
    }
}
