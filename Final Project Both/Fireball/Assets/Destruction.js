#pragma strict

var speed : float = 5.0; 
var timeDestroy : float = 4.0; 
 
private var startTime : float; 
 
function Start () { 
 transform.DetachChildren(); 
 startTime = Time.time; 
} 
 
function Update () { 
 if(Time.time > startTime + timeDestroy) 
 Destroy(this.gameObject); 
} 

function OnCollisionEnter(col : Collision)
{
	if(col.gameObject.tag == "Target")
	{
		Destroy (this.gameObject);
	}
	if(col.gameObject.tag == "Environment")
	{
		Destroy (this.gameObject);
	}
}