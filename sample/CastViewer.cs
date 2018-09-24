using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SaitamaTec.CastTime
{
	[RequireComponent(typeof(UnityEngine.UI.Button))]
	[RequireComponent(typeof(UnityEngine.UI.Image))]
	[RequireComponent(typeof(Collider))]
  public class CastViewer : MonoBehaviour
  {

		[SerializeField]
    public CastTimer WatchTarget;

		public UnityEngine.UI.Text TimeLabel;
		public UnityEngine.UI.Button CastButton;

		public void OnMouseDown(){
			Debug.Log("NNNN");
		}

		public void Start(){
			this.CastButton.onClick.AddListener(
				()=>{
					Debug.Log("ボタン押したで！");
					WatchTarget.Cast();
				}
			);
		}
		public void Update(){
			TimeLabel.text=TimeLabelString;

			CastButton.interactable = WatchTarget.Castable;
		}

		public string TimeLabelString{
			get{
				return WatchTarget.Castable
					?"Rady!"
					:WatchTarget.RecastTimeRatio.ToString("00%");
			}			
		}
  }

}
