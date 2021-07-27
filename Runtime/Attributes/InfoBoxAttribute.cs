using UnityEngine;

public enum InfoBoxType
{
    Info,
    Warning,
    Error, 
    None
}

[System.AttributeUsage(System.AttributeTargets.Field, AllowMultiple = true)]
public class InfoBoxAttribute : PropertyAttribute
{
    public readonly string text;
    public readonly InfoBoxType infoBoxType;

    public InfoBoxAttribute(string text, InfoBoxType type = InfoBoxType.Info)
    {
        this.text = text;
        infoBoxType = type;
    }
}
