using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SaitamaTec.CastTime
{
  public class CastTimer : MonoBehaviour
  {
		[SerializeField]
		private float recastTime=10;
		[SerializeField]
		private float castTime=10;

		
		private float castingTime=0;
		private float recastingTime=0;


		public float RecastTime{
			get{
				return recastTime;
			}
		}
		

		public bool Castable{
			get{
				return RecastingTime <= 0;
			}
		}		
		public float RecastingTime{
			get{
				return recastingTime;
			}
		}

		public int RecastTimeFrame{
			set{

			}
		}

		public void Cast(){
			recastingTime = RecastTime;
		}

		public void Start(){
			recastingTime = RecastTime;
		}

		
		public void Update(){
			recastingTime-=Time.deltaTime;

		}
  }

}
