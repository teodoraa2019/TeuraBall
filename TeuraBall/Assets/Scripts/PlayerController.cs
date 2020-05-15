using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public Text countText;
    public Text winText;

    private Rigidbody rb;
    private int count;

	public AudioClip pickup;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
    }

    void FixedUpdate()
    {
		//pomicanje loptice
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
		//provjera ako je object dijamant
        if (other.gameObject.CompareTag("Pick Up"))
        {
			//uvećanje za jedan
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
		AudioSource.PlayClipAtPoint (pickup, transform.position);
    }

    void SetCountText()
    {
		//brojenje sakupljenih dijamanata
        countText.text = "Rezultat: " + count.ToString() + " / 12";
        if (count >= 12)
        {
			//bacanje na novu scenu ukoliko su sakupljeni svi dijamanti
            winText.text = "Pobjeda!";
			Application.LoadLevel("Win");
        }
    }
}