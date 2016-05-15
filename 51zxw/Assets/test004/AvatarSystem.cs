using UnityEngine;
using System.Collections.Generic;

public class AvatarSystem : MonoBehaviour {

    private Transform source;
    private Transform target;

    private GameObject tempsource;
    private GameObject temptarget;

    private Dictionary<string, Dictionary<string, Transform>> data = new Dictionary<string, Dictionary<string, Transform>>();
    private Transform[] hips;

    private Dictionary<string, SkinnedMeshRenderer> targetSmr = new Dictionary<string, SkinnedMeshRenderer>();

    const float fadeLength = .8f;

    //Clip
    private Animation mAnim;
    private AnimationClip mClip;

    private int count = 0;

	// Use this for initialization
	void Start () 
    {
        InstantiateAvatar();
        LoadAvatarData(source);
        LoadSkeleton();

        hips = target.GetComponentsInChildren<Transform>();
        mAnim = target.GetComponentInChildren<Animation>();

        InitAvatar();
	}
	                                                           
    //load source model
    void InstantiateAvatar()
    {
        tempsource = Instantiate(Resources.Load("FemaleAvatar")) as GameObject;
        source = tempsource.transform;
        //Destroy(tempsource);
        tempsource.SetActive(false);
    }

    //load source skinnedmeshrenderer
    void LoadAvatarData(Transform source)
    {
        if (null == source)
            return;

        SkinnedMeshRenderer[] parts = source.GetComponentsInChildren<SkinnedMeshRenderer>(true);

         foreach (SkinnedMeshRenderer part in parts)
         {
             string[] partName = part.name.Split('-');
             if(!data.ContainsKey(partName[0]))
             {
                 data.Add(partName[0], new Dictionary<string, Transform>());
                 GameObject partObj = new GameObject();
                 partObj.name = partName[0];
                 partObj.transform.parent = target;

                 targetSmr.Add(partName[0], partObj.AddComponent<SkinnedMeshRenderer>());
             }

             data[partName[0]].Add(partName[1], part.transform);
 
         }
    }

    //load skeleton model
    void LoadSkeleton()
    {
        temptarget = Instantiate(Resources.Load("targetmodel")) as GameObject;
        target = temptarget.transform;
    }

    //avatar change mesh
    void ChangeMesh(string part, string item)
    {
        SkinnedMeshRenderer smr = data[part][item].GetComponent<SkinnedMeshRenderer>();

        List<Transform> bones = new List<Transform>();
        foreach (Transform bone in smr.bones)
        {
            foreach (Transform hip in hips)
            {
                if (hip.name != bone.name)
                    continue;
                bones.Add(hip);
                break;
            }
        }

        targetSmr[part].sharedMesh = smr.sharedMesh;
        targetSmr[part].bones = bones.ToArray();
        targetSmr[part].materials = smr.materials;

    }
     
    //init avatar resource
    void InitAvatar()
    {
        ChangeMesh("coat", "003");
        ChangeMesh("head", "003");
        ChangeMesh("hair", "003");
        ChangeMesh("pant", "003");
        ChangeMesh("foot", "003");
        ChangeMesh("hand", "003");

    }

    void OnGUI()
    {
        if (GUILayout.Button("Head"))
        {
            if (count == 1)
            {
                ChangeMesh("head", "001");
                count = 0;
            }
            else
            {
                ChangeMesh("head", "003");
                count = 1;
            }
                
        }

        if (GUILayout.Button("Pant"))
        {
            if (count == 1)
            {
                ChangeMesh("pant", "001");
                  count = 0;
            }
            else
            {
                ChangeMesh("pant","003");
                count = 1;
            }
        }

        if(GUILayout.Button("Hair"))
        {
            if(count == 1)
            {
                ChangeMesh("hair", "001");
                count = 0;
            }
            else
            {
                ChangeMesh("hair", "003");
                count = 1;
            }
        }

        if(GUILayout.Button("Hand"))
        {
            if(count == 1)
            {
                ChangeMesh("hand", "001");
                count = 0;
            }
            else
            {
                ChangeMesh("hand", "003");
                count = 1;
            }
        }

        if(GUILayout.Button("Foot"))
        {
            if(count == 1)
            {
                ChangeMesh("foot", "001");
                count = 0;
            }
            else
            {
                ChangeMesh("foot", "003");
                count = 1;
            }
        }
        if(GUILayout.Button("Coat"))
        {
            if(count == 1)
            {
                ChangeMesh("coat", "001");
                count = 0;
            }
            else
            {
                ChangeMesh("coat", "003");
                count = 1;
            }
        }

    }
	// Update is called once per frame
	void Update () {
	
	}
}
