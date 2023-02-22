using UnityEngine;

public class DoorManager : MonoBehaviour
{
    [SerializeField] private CharacterInteractionCounter _primaryInteractionCounter;
    [SerializeField] private InteractionHandler _primaryInteraction;
    private BoxCollider _collider;
    private Vector3 defaultVector;
    [SerializeField] private GameObject NPC; 

    private Transform _transform;

    private void Start()
    {
        _transform = GetComponent<Transform>();
        _collider = GetComponent<BoxCollider>();
        defaultVector = transform.position;
    }

    private void Update()
    {
        UnlockDoor();
    }

    private void UnlockDoor()
    {
        if (_primaryInteractionCounter.MyInteractions == _primaryInteraction._audio.Count - 1)
        {
            _transform.position = new Vector3(_transform.position.x, (transform.position.y - 3), _transform.position.z);
            _collider.transform.position = new Vector3(defaultVector.x - 1, defaultVector.y, defaultVector.z);
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _transform.position = defaultVector;
            NPC.SetActive(false);
        }
    }
}
