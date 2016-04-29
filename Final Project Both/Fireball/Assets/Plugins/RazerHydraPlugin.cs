using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;
using System.Text;
public class RazerHydraPlugin {
	public struct sixenseControllerData{
		public Vector3 position;
		public Vector3 rot_mat_x;
		public Vector3 rot_mat_y;
		public Vector3 rot_mat_z;
		public float joystick_x;
		public float joystick_y;
		public byte trigger;
		public int buttons;
		public byte sequence_number;
		public Quaternion rotation; 
		public short firmware_revision;
		public short hardware_revision;
		public short packet_type;
		public short magnetic_frequency;
		public int enabled;
		public int controller_index;
		public byte is_docked;
		public byte which_hand;
	};
	
	public sixenseControllerData data;
	[DllImport ("sixense")] private static extern int sixenseInit( );
	[DllImport ("sixense")] private static extern int sixenseExit( );
	[DllImport ("sixense")] private static extern int
		sixenseGetNewestData(int which, out sixenseControllerData data);
	[DllImport ("sixense")] private static extern int
		sixenseSetFilterEnabled(int filterEnabled);
	// [DllImport ("sixense")] private static extern int sixenseGetMaxBases();
	// [DllImport ("sixense")] private static extern int sixenseSetActiveBase(int baseNum);
	// [DllImport ("sixense")] private static extern intsixenseIsBaseConnected(int baseNum );
	// [DllImport ("sixense")] private static extern intsixenseGetMaxControllers( );
	// [DllImport ("sixense")] private static extern intsixenseGetNumActiveControllers( );
	// [DllImport ("sixense")] private static extern intsixenseIsControllerEnabled(int which);
	// [DllImport ("sixense")] private static extern intsixenseGetAllNewestData(out _sixenseAllControllerData allData);
	// [DllImport ("sixense")] private static extern int sixenseGetAllData(intindexBack, out _sixenseAllControllerData allData);
	// [DllImport ("sixense")] private static extern int sixenseGetData(intwhich, int indexData,out _sixenseControllerData data);
	// [DllImport ("sixense")] private static extern intsixenseGetHistorySize( );
	// [DllImport ("sixense")] private static extern intsixenseGetFilterEnabled(out int filterEnabled);
	// [DllImport ("sixense")] private static extern intsixenseSetFilterParams(float nearRange, float nearVal, float farRange, floatfarVal );
	// [DllImport ("sixense")] private static extern intsixenseGetFilterParams(out float nearRange,out float nearVal,out floatfarRange,out float farVal );
	// [DllImport ("sixense")] private static extern intsixenseTriggerVibration(int controllerId, int duration100ms, int patternId );
	// [DllImport ("sixense")] private static extern intsixenseAutoEnableHemisphereTracking(int whichController );
	// [DllImport ("sixense")] private static extern intsixenseSetHighPriorityBindingEnabled(int onOrOff );
	// [DllImport ("sixense")] private static extern intsixenseGetHighPriorityBindingEnabled(out int onOrOff );
	public int init(){ 
		return sixenseInit();
	}
	
	public int exit(){
		return sixenseExit();
	}
	
	public void setFilterEnabled(int enabled){
		sixenseSetFilterEnabled(enabled);
	}
	
	public int getNewestData(int id){
		sixenseGetNewestData(id, out data);
		return 0;
	}
}

