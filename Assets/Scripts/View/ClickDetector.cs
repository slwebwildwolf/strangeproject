using System;
using UnityEngine;
using strange.extensions.mediation.impl;

namespace Project
{
	public class ClickDetector : EventView
	{
		public const string CLICK = "CLICK";
		
		void OnMouseDown()
		{
			dispatcher.Dispatch(CLICK);
		}
	}
}

