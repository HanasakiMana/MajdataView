﻿using System.IO;
using UnityEngine;
#nullable enable
public static class SpriteLoader
{
    public static Sprite LoadSpriteFromFile(string path)
    {
        Debug.Log("Loading: " + path);
        if (!File.Exists(path))
        {
            Debug.LogWarning("File does not exist: " + path);
            return Sprite.Create(new Texture2D(0, 0), new Rect(0, 0, 0, 0), new Vector2(0.5f, 0.5f));
        }
        var bytes = File.ReadAllBytes(path);
        var texture = new Texture2D(0, 0);
        texture.LoadImage(bytes);
        return Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));
    }

    public static Sprite LoadSpriteFromFile(string path, Vector4 border)
    {
        Debug.Log("Loading: " + path);
        if (!File.Exists(path))
        {
            Debug.LogWarning("File does not exist: " + path);
            return Sprite.Create(new Texture2D(0, 0), new Rect(0, 0, 0, 0), new Vector2(0.5f, 0.5f));
        }
        var bytes = File.ReadAllBytes(path);
        var texture = new Texture2D(0, 0);
        texture.LoadImage(bytes);
        return Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100, 1,
            SpriteMeshType.FullRect, border);
    }
}