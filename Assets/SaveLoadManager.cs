using UnityEngine;

public interface ISaveLoader
{
    void LoadData();
    void SaveData();
}


//Теперь менеджер сохранений будет работать через интерфейс
public sealed class SaveLoadManager : MonoBehaviour
{
    private readonly ISaveLoader[] saveLoaders = {
        //new MoneySaveLoader(), //В идеале юзать DI
    };

    public void LoadGame()
    {
        Repository.LoadState();

        foreach (var saveLoader in this.saveLoaders)
        {
            saveLoader.LoadData();
        }
    }

    public void SaveGame()
    {
        foreach (var saveLoader in this.saveLoaders)
        {
            saveLoader.SaveData();
        }

        Repository.SaveState();
    }
}