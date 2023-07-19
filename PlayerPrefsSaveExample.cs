using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Instructions:
 * - Press 'S' to save data
 * - Press 'L' to load data
 * - Press 'D' to delete data
 * - Press 'C' to check for saved data
 * - Press '1' to change data to settings 1
 * - Press '2' to change data to settings 2
 * - Press '3' to change data to settings 3
 */
public class PlayerPrefsSaveExample : MonoBehaviour
{
    float volume_master;
    float volume_music;
    float volume_sfx;

    int resolution_x;
    int resolution_y;
    int graphics_quality;

    string player_color;

    float default_volume = 100;
    int default_x = 1920;
    int default_y = 1080;
    int default_quality = 1;
    string default_color = "blue";
    // Start is called before the first frame update
    void Start()
    {
        ResetValues();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
            SaveData();
        if (Input.GetKeyDown(KeyCode.L))
            LoadData();
        if (Input.GetKeyDown(KeyCode.D))
            DeleteAllData();
        if (Input.GetKeyDown(KeyCode.C))
            CheckData();
        if (Input.GetKeyDown(KeyCode.Alpha1))
            ResetValues();
        if (Input.GetKeyDown(KeyCode.Alpha2))
            ChangeValues2();
        if (Input.GetKeyDown(KeyCode.Alpha3))
            ChangeValues3();
    }


    void SaveData()
    {
        PlayerPrefs.SetFloat("volume_master", volume_master);
        PlayerPrefs.SetFloat("volume_music", volume_music);
        PlayerPrefs.SetFloat("volume_sfx", volume_sfx);

        PlayerPrefs.SetInt("resolution_x", resolution_x);
        PlayerPrefs.SetInt("resolution_y", resolution_y);
        PlayerPrefs.SetInt("graphics_quality", graphics_quality);

        PlayerPrefs.SetString("player_color", player_color);

        PlayerPrefs.Save();

        Debug.Log("----------------------------------------------");
        Debug.Log("Data has been saved.");
    }

    void LoadData()
    {
        volume_master = PlayerPrefs.GetFloat("volume_master", default_volume);
        volume_music = PlayerPrefs.GetFloat("volume_music", default_volume);
        volume_sfx = PlayerPrefs.GetFloat("volume_sfx", default_volume);

        resolution_x = PlayerPrefs.GetInt("resolution_x", default_x); ;
        resolution_y = PlayerPrefs.GetInt("resolution_y", default_y); ;
        graphics_quality = PlayerPrefs.GetInt("graphics_quality", default_quality);

        player_color = PlayerPrefs.GetString("player_color", default_color);

        Debug.Log("----------------------------------------------");
        Debug.Log("Load data complete.");
        Debug.Log("Master Volume: " + volume_master);
        Debug.Log("Music Volume: " + volume_music);
        Debug.Log("SFX Volume: " + volume_sfx);
        Debug.Log("Resolution: " + resolution_x + " x " + resolution_y);
        Debug.Log("Graphics Quality: " + graphics_quality);
    }

    void DeleteAllData()
    {
        if (PlayerPrefs.HasKey("volume_master"))
        {
            PlayerPrefs.DeleteAll();
            Debug.Log("----------------------------------------------");
            Debug.Log("Data has been deleted.");
        }
        else
        {
            Debug.Log("----------------------------------------------");
            Debug.Log("No data to delete.");
        }
    }

    void CheckData()
    {
        if (PlayerPrefs.HasKey("volume_master"))
        {
            Debug.Log("----------------------------------------------");
            Debug.Log("Saved data detected!");
        }
        else
        {
            Debug.Log("----------------------------------------------");
            Debug.Log("No saved data available!");
        }
    }

    void ChangeValues2()
    {
        volume_master = 50;
        volume_music = 50;
        volume_sfx = 75;

        resolution_x = 2560;
        resolution_y = 1440;
        graphics_quality = 2;

        player_color = "green";

        Debug.Log("----------------------------------------------");
        Debug.Log("Data #2 selected.");
        Debug.Log("Master Volume: " + volume_master);
        Debug.Log("Music Volume: " + volume_music);
        Debug.Log("SFX Volume: " + volume_sfx);
        Debug.Log("Resolution: " + resolution_x + " x " + resolution_y);
        Debug.Log("Graphics Quality: " + graphics_quality);
    }

    void ChangeValues3()
    {
        volume_master = 75;
        volume_music = 80;
        volume_sfx = 90;

        resolution_x = 3840;
        resolution_y = 2160;
        graphics_quality = 3;

        player_color = "orange";

        Debug.Log("----------------------------------------------");
        Debug.Log("Data #3 selected.");
        Debug.Log("Master Volume: " + volume_master);
        Debug.Log("Music Volume: " + volume_music);
        Debug.Log("SFX Volume: " + volume_sfx);
        Debug.Log("Resolution: " + resolution_x + " x " + resolution_y);
        Debug.Log("Graphics Quality: " + graphics_quality);
    }

    void ResetValues()
    {
        volume_master = default_volume;
        volume_music = default_volume;
        volume_sfx = default_volume;

        resolution_x = default_x;
        resolution_y = default_y;
        graphics_quality = default_quality;

        player_color = default_color;

        Debug.Log("----------------------------------------------");
        Debug.Log("Default Data selected.");
        Debug.Log("Master Volume: " + volume_master);
        Debug.Log("Music Volume: " + volume_music);
        Debug.Log("SFX Volume: " + volume_sfx);
        Debug.Log("Resolution: " + resolution_x + " x " + resolution_y);
        Debug.Log("Graphics Quality: " + graphics_quality);
    }
}
