using UnityEngine;
using System.Collections;

public class StartUp : MonoBehaviour {

    public string path_to_character_sprite;
    public Sprite the_sprite;

    private GameObject character;
    private SpriteRenderer character_renderer;
    private Sprite character_sprite;

	// Use this for initialization
	void Start () {
        //spawn character sprite
        Texture2D tex = Resources.Load("character_sprite", typeof(Texture2D)) as Texture2D;
        Rect rec = new Rect(0,0,tex.width,tex.height);
        //character_sprite = Sprite.Create(tex, rec, new Vector2(0,0));
        character = new GameObject("character");
        character_renderer = character.AddComponent<SpriteRenderer>() as SpriteRenderer;
        character_renderer.sprite = Sprite.Create(tex, rec, new Vector2(0, 0));
        character_renderer.flipX = true;
        //character.GetComponent<SpriteRenderer>().sprite = character_sprite;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
