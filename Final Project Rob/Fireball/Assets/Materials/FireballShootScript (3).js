#pragma strict
public var Fireball: GameObject;
public var Camera : GameObject;
public var Capsule : GameObject;
private var plugin: RazerHydraPlugin = new RazerHydraPlugin();

var shotForce : float = 1500.0;
var timeOfNextShot : float;

function Start () {
	plugin.init();
}

function Update () {
	plugin.getNewestData(0);
	
	if(plugin.data.trigger >= 0.8 && Time.time > timeOfNextShot)
	{
		var cloneBall: GameObject = Instantiate(Fireball, Camera.transform.position, Camera.transform.rotation);
		//Physics.IgnoreCollision(cloneBall.GetComponent.<Collider>(), Capsule.GetComponent.<Collider>());
		cloneBall.active = true;
		cloneBall.GetComponent.<Rigidbody>().AddForce(Camera.transform.forward * shotForce);
		timeOfNextShot = Time.time + 0.8;
		
		/*
		var cloneBall: GameObject = Instantiate(Fireball, Camera.transform.position, Camera.transform.rotation);
		Fireball.active = true;
		Fireball.GetComponent.<Rigidbody>().AddForce(Fireball.transform.forward * shotForce);
		timeOfNextShot = Time.time + 0.8;
	*/
	}
}
