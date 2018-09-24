using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SaitamaTec.CastTime
{
  public class CastTimer : MonoBehaviour
  {
		public delegate void CastAction();
		[SerializeField]
		private float recastTime=10;
		[SerializeField]
		private float castTime=10;
		private float castingTime=0;
		private float recastingTime=0;

		public float RecastTime=> recastTime;
		public float CastTime=> castTime;
		public bool Castable=> (RecastingTime <= 0);

		public float RecastingTime=>recastingTime;

		public float RecastTimeRatio=>(RecastTime-RecastingTime)/RecastTime;
		
		public IEnumerator OnCast(CastAction a){
			Debug.Log("Cast...start!");
			yield return new WaitForSecondsRealtime(CastTime);
			Debug.Log("Cast...OK!");
			a();
			yield break;
		}

		public void Cast(){
			recastingTime = RecastTime;
			
			this.StartCoroutine(OnCast(()=>{}));
		}

		public void Start(){
			recastingTime = RecastTime;
		}

		
		public void Update(){
			recastingTime-=Time.deltaTime;

		}
  }

}
