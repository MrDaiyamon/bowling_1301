using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private int playerScore;
    public int PlayerScore { get { return playerScore; } set { playerScore = value; } }

    [SerializeField]
    private TMP_Text notiText;

    [SerializeField]
    private GameObject[] pinPositions;

    [SerializeField]
    private GameObject pinPrefab;
    
    public static GameManager instance;

    void Awake()
    {
        instance = this;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetPin(0);
        SetPin(1);
        SetPin(2);
        SetPin(3);
        SetPin(4);
        SetPin(5);
        SetPin(6);
        SetPin(7);
        SetPin(8);
        SetPin(9);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SetPin(int i)
    {
        GameObject obj = Instantiate(pinPrefab,
                    pinPositions[i].transform.position,
                    Quaternion.identity);
    }

    public void ShowNotiText(int n)
    {
        PlayerScore += n;
        notiText.text = $"Pins have down x{playerScore}\nTotal Score is {playerScore}";
    }
    public void ShowString(string s)
    {
        notiText.text = s;
    }
}
