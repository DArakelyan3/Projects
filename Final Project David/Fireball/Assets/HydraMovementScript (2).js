#pragma strict
private var plugin: RazerHydraPlugin = new RazerHydraPlugin();

function Start () {
	plugin.init();
}

function Update () {
	
}

function FixedUpdate() {
	// right hand look
	plugin.getNewestData(1);
	
	//transform.position.x = plugin.data.position.x/100;
	//transform.position.y = plugin.data.position.y/100;
	//transform.position.z = plugin.data.position.z/-100;
	
	transform.rotation.x = plugin.data.rotation.x*-1;
	transform.rotation.y = plugin.data.rotation.y*-1;
	transform.rotation.z = plugin.data.rotation.z; 
	
	// left hand move
	var joy_x: float;
	var joy_y: float;
	
	plugin.getNewestData(0);
	
	joy_x = plugin.data.joystick_x;
	joy_y = plugin.data.joystick_y;
	
	transform.position.x = transform.position.x + joy_x/3;
	//transform.position.y
	transform.position.z = transform.position.z + joy_y/3;
}