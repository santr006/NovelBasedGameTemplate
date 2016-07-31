using UnityEngine;
using System.Collections;

public class StartUp : MonoBehaviour {

    public string path_to_character_sprite;
    public string path_to_speech_box_sprite;
    public string path_to_conversation;

    private GameObject character;
    private SpriteRenderer character_renderer;
    private GameObject speech_box;
    private SpriteRenderer speech_box_renderer;
    private GameObject speech;
    private CanvasRenderer speech_renderer;

	// Use this for initialization
	void Start () {
        //spawn character sprite
        Texture2D tex = Resources.Load(path_to_character_sprite, typeof(Texture2D)) as Texture2D;
        Rect rec = new Rect(0,0,tex.width,tex.height);
        character = new GameObject("character");
        character_renderer = character.AddComponent<SpriteRenderer>();
        character_renderer.sprite = Sprite.Create(tex, rec, new Vector2(0.5f, 0));
        character_renderer.flipX = true;

        //spawn speech
        tex = Resources.Load(path_to_speech_box_sprite, typeof(Texture2D)) as Texture2D;
        rec = new Rect(0, 0, tex.width, tex.height);
        speech_box = new GameObject("speech_box");
        speech_box_renderer = speech_box.AddComponent<SpriteRenderer>();
        speech_box_renderer.sprite = Sprite.Create(tex, rec, new Vector2(0.5f, 0));
        speech_box.transform.position = new Vector3(0, -speech_box_renderer.sprite.bounds.size.y, 0);

        //spawn text
        speech = new GameObject("speech");
        speech_renderer = speech.AddComponent<CanvasRenderer>();
        //speech.AddComponent<Text>();
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
