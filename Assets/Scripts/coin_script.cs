using UnityEngine;

public class coin_script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0, 5, 0, Space.World);
    }

    public void OnTriggerEnter(Collider collider)
    {
        Destroy(gameObject);
        CoinCounter.numOfCoin++;
    }

}
