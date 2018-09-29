using UnityEngine;

public class OnExit : MonoBehaviour {
    public GameObject ground;
    public GameObject[] Obs;
    public static OnExit onExit;
    public Vector3 offset;
    private bool created=false;
    public int max;
    private int selector;
    private int a;
    private void OnTriggerExit(Collider other)
   {
        
        if (other.tag == "Player" && !created)
        {
            Creator();
            created = true;
        }
   }
    public void Creator()
    {
        selector = Random.Range(0, max);
        a = selector;
        ground = Instantiate(ground, ground.transform.GetChild(0).transform.position + offset, Quaternion.identity);
        Instantiate(Obs[selector], ground.transform.GetChild(2).transform.position  , Quaternion.identity);
        
        selector = Random.Range(0, max);
        while(a==selector)
            selector = Random.Range(0, max);
        a = selector;
        Instantiate(Obs[selector], ground.transform.GetChild(3).transform.position  , Quaternion.identity);
        selector = Random.Range(0, max);
        while (a == selector)
            selector = Random.Range(0, max);
        a = selector;
        Instantiate(Obs[selector], ground.transform.GetChild(4).transform.position  , Quaternion.identity);
        selector = Random.Range(0, max);
        while (a == selector)
            selector = Random.Range(0, max);
        a = selector;
        Instantiate(Obs[selector], ground.transform.GetChild(5).transform.position  , Quaternion.identity);


    }
   
}
