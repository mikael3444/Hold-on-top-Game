using UnityEngine;
using System.Collections;

public class PodeExcluirTranslateXTest : MonoBehaviour {

    public float speed;

	void Update () {
        transform.Translate(new Vector2(speed * Time.deltaTime, 0));
	}
}
