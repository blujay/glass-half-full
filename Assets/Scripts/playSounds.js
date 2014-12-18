#pragma strict

function OnCollisionEnter(collision : Collision)
{
	
	if (collision.transform.tag == "drop" || "vitality" || "gold" && audio != null)
	audio.Play();

}

