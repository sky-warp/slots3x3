using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class CustomPool<T> where T : MonoBehaviour
{
    private T _prefab;
    private List<T> _objects;

    public CustomPool(T prefab, int prewarm)
    {
        _prefab = prefab;

        for (int i = 0; i < prewarm; i++)
        {
            var obj = GameObject.Instantiate(_prefab);
            obj.GameObject().SetActive(false);
            _objects.Add(obj);
        }
    }

    public T Get()
    {
        var obj = _objects.FirstOrDefault(x => !x.isActiveAndEnabled);

        if (obj == null)
        {
            Create();
        }

        obj.gameObject.SetActive(true);
        return obj;
    }

    private T Create()
    {
        var obj = GameObject.Instantiate(_prefab);
        _objects.Add(obj);
        return obj;
    }

    public void Release(T obj)
    {
        obj.gameObject.SetActive(false);
    }
}