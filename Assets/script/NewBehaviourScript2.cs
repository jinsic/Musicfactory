using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class NewBehaviourScript2 : MonoBehaviour {
    public Sprite OtherSprite1;
    public Sprite OtherSprite2;
    public Sprite OtherSprite3;
    public Sprite OtherSprite4;
    public Sprite OtherSprite5;
    public Sprite OtherSprite6;
    public Sprite OtherSprite7;
    public Sprite OtherSprite8;
    public Sprite OtherSprite9;

    private int pageNum = 0;
    Image[] images;
    float time;
    // Use this for initialization
    void Start () {
        // Get all components of type Image that are children of this GameObject.
    }

    // Update is called once per frame
    void Update () {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            pageNum++;
        }
        if (OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger))
        {
            if (pageNum > 0) { 
            pageNum--;
            }
        }
        if (pageNum < 1)
        {
            images = gameObject.GetComponentsInChildren<Image>();
            // Loop through each image and set it's Sprite to the other Sprite.
            images[0].sprite = OtherSprite1;
        }
        else if (pageNum < 2)
        {
            images = gameObject.GetComponentsInChildren<Image>();
            // Loop through each image and set it's Sprite to the other Sprite.
            images[0].sprite = OtherSprite2;
        }
        else if (pageNum < 3)
        {
            images = gameObject.GetComponentsInChildren<Image>();
            // Loop through each image and set it's Sprite to the other Sprite.
            images[0].sprite = OtherSprite3;
        }
        else if (pageNum < 4)
        {
            images = gameObject.GetComponentsInChildren<Image>();
            // Loop through each image and set it's Sprite to the other Sprite.
            images[0].sprite = OtherSprite4;
        }
        else if (pageNum < 5)
        {
            images = gameObject.GetComponentsInChildren<Image>();
            // Loop through each image and set it's Sprite to the other Sprite.
            images[0].sprite = OtherSprite5;
        }
        else if (pageNum < 6)
        {
            images = gameObject.GetComponentsInChildren<Image>();
            // Loop through each image and set it's Sprite to the other Sprite.
            images[0].sprite = OtherSprite6;
        }
        else if (pageNum < 7)
        {
            images = gameObject.GetComponentsInChildren<Image>();
            // Loop through each image and set it's Sprite to the other Sprite.
            images[0].sprite = OtherSprite7;
        }
        else if (pageNum < 8)
        {
            images = gameObject.GetComponentsInChildren<Image>();
            // Loop through each image and set it's Sprite to the other Sprite.
            images[0].sprite = OtherSprite8;
        }
        else if (pageNum < 9)
        {
            images = gameObject.GetComponentsInChildren<Image>();
            // Loop through each image and set it's Sprite to the other Sprite.
            images[0].sprite = OtherSprite9;
        }
        else
        {
            GameObject g = gameObject;
            Destroy(g);
            Destroy(this);
        }

    }


}
