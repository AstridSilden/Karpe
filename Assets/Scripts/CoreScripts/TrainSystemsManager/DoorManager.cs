using UnityEngine;

public class DoorManager : MonoBehaviour
{
    [SerializeField] private CharacterInteractionCounter _primaryInteractionCounter;
    [SerializeField] private InteractionHandler _primaryInteraction;
    private BoxCollider _collider;
    private Vector3 defaultVector;
    [SerializeField] private GameObject NPC; 

    private Transform _transform;
    private bool canMove; 

    private void Start()
    {
        _transform = GetComponent<Transform>();
        _collider = GetComponent<BoxCollider>();
        defaultVector = transform.position;
        canMove = true;
    }

    private void Update()
    {
        UnlockDoor();
    }

    private void UnlockDoor()
    {
        if (_primaryInteractionCounter.MyInteractions == _primaryInteraction._audio.Count - 1 && canMove)
        {
            print("Conditions fulfilled");
            _transform.position = new Vector3(_transform.position.x, (transform.position.y - 3f), _transform.position.z);
            _collider.isTrigger = true; 
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canMove = false;
            _collider.isTrigger = false;
            _transform.position = defaultVector;
            NPC.SetActive(false);
        }
    }
}
