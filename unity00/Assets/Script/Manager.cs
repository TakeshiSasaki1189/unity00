using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour {

	// Use this for initialization
	void Start () {

		SceneManager.LoadScene("Scene_1",LoadSceneMode.Additive );
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI()
	{
		if (GUI.Button (new Rect (0,0,Screen.width / 6,Screen.height /6), "Scene_1->Scene_2")) {
			
			StartCoroutine(SceneMove());
		}
	}


	IEnumerator SceneMove()
	{
		//loadシーンアクティブ
//		SceneManager.LoadScene("load",LoadSceneMode.Additive );
		
		//１フレーム待つ カメラがない時間があるため
		yield return new WaitForSeconds(Time.deltaTime);
		
		//アニメーション長さ分待つ&アニメーション再生
//		yield return new WaitForSeconds(load.Instance.Gate_in());
		
		//次のシーンアクティブ
		SceneManager.LoadScene("Scene_2",LoadSceneMode.Additive );
		
		//一応保険として１フレーム待つ
		yield return new WaitForSeconds(Time.deltaTime);
		
		//前のシーン非アクティブ
//		SceneManager.UnloadScene ("Scene_1");
		
		//ロード時間とりあえず今回は時間で判定
		yield return new WaitForSeconds(3);
		
		//アニメーション長さ分待つ&アニメーション再生
//		yield return new WaitForSeconds(load.Instance.Gate_out());
		
		//ロードシーン非アクティブ
//		SceneManager.UnloadScene ("load");
	}


}
