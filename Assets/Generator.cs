using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public SpriteRenderer BG, Skin, Beard, Hat, EyeColor, Outfit;
    public List<Sprite> BGList, SkinList, BeardList, HatList, EyeColorList, OutfitList = new List<Sprite>();

    int NFT_count = 0;
    void Start()
    {
        StartCoroutine(Generate());
    }

    IEnumerator Generate()
    {
        foreach (Sprite bg in BGList)
        {
            foreach (Sprite skin in SkinList)
            {
                foreach (Sprite beard in BeardList)
                {
                    foreach (Sprite hat in HatList)
                    {
                        foreach (Sprite eyecolor in EyeColorList)
                        {
                            foreach (Sprite outfit in OutfitList)
                            {
                                NFT_count++;
                                yield return new WaitForSeconds(0.1f);
                                BG.sprite = bg;
                                Skin.sprite = skin;
                                Beard.sprite = beard;
                                Hat.sprite = hat;
                                EyeColor.sprite = eyecolor;
                                Outfit.sprite = outfit;
                                ScreenCapture.CaptureScreenshot("NFT (" + NFT_count + ").png");
                            }
                        }
                    }
                }
            }

        }
    }
}
