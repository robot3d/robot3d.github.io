using System;
using UnityEngine;
using System.Collections;

public class LoadAB: MonoBehaviour
{
	private static string PATH = Application.dataPath+"/Resources/";
	private string BundleURL = PATH+"cube.assetbundle";  
	private string SceneURL = PATH+"scene1.unity3d";  
	private string Bundle1URL = PATH+"sphere.assetbundle"; 
	private string PersonURL = PATH+"person.assetbundle"; 
	
	void Start()
	{
		//BundleURL = "file//"+Application.dataPath+"/cube.assetbundle";
		JDebug.Log (new string[]{"debug:",Application.dataPath+"",BundleURL});
		StartCoroutine(DownloadAssetAndScene());
	}
	IEnumerator DownloadAssetAndScene()
	{

		//下载assetbundle，加载Cube
		using (WWW asset = new WWW(Bundle1URL))
		{
			yield return asset;
			Debug.Log("..............");
			AssetBundle bundle = asset.assetBundle;
			Instantiate(bundle.Load("Sphere"));
			bundle.Unload(false);
			yield return new WaitForSeconds(5);
		}
		//下载场景，加载场景
		using (WWW scene = new WWW(SceneURL))
		{
			yield return scene;
			AssetBundle bundle = scene.assetBundle;
			Application.LoadLevelAdditive("scene1");
			yield return new WaitForSeconds(5);
		}
		//下载assetbundle，加载Cube
		using (WWW asset = new WWW(BundleURL))
		{
			yield return asset;
			AssetBundle bundle = asset.assetBundle;
			Instantiate(bundle.Load("Cube"));
			bundle.Unload(false);
			yield return new WaitForSeconds(5);
		}
		//下载assetbundle，加载Person
		using (WWW asset = new WWW(PersonURL))
		{
			yield return asset;
			AssetBundle bundle = asset.assetBundle;
			Instantiate(bundle.Load("Person"));
			bundle.Unload(false);
			yield return new WaitForSeconds(5);
		}
	}

}