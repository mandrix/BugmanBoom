using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New hazard", menuName ="Hazard")]
public class hazards : ScriptableObject
{
	public new string name;

	[Tooltip("The name of the object that causes harm to an enemy")]
	public string hazardObjectName;

	public int damagePoints;
}
