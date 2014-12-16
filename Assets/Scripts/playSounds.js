#pragma strict

function OnCollisionEnter(collision : Collision)
{
	
	if (collision.transform.tag == "drop" && audio != null)
	audio.Play();

}

