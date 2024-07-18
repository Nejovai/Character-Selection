using UnityEngine;
using UnityEngine.UI;
using Enemy;

public class Main : MonoBehaviour
{
    [SerializeField] private Text _name;
    [SerializeField] private Text _description;

    [SerializeField] private Transform _spawnPosition;
    [SerializeField] private GameObject[] _enemies;

    private int count = 0;

    private void Start()
    {
        Instantiate(_enemies[count], _spawnPosition.position, Quaternion.identity);
    }

    public void Back()
    {
        if (count == 0)
            count = _enemies.Length - 1;
        else
            count--;

        Destroy(GameObject.FindGameObjectWithTag("Enemy"));
        Instantiate(_enemies[count], _spawnPosition.position, Quaternion.identity);
    }

    public void Forward()
    {
        if (count < _enemies.Length)
            count++;
        if (count == _enemies.Length)
            count = 0;

        Destroy(GameObject.FindGameObjectWithTag("Enemy"));
        Instantiate(_enemies[count], _spawnPosition.position, Quaternion.identity);
    }

    public void Exit()
    {
        {
            Application.Quit();

#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#endif
        };
    }


    private void Update()
    {
        var enemy = FindAnyObjectByType<Enemies>();
        _name.text = $"Èìÿ: {enemy.Name()}";
        _description.text = enemy.Description();
    }
}
