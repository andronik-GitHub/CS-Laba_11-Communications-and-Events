using System;

class Dispatcher
{
    string name = "No name";

    public string Name
    {
        get => name;
        set
        {
            name = value;
            OnNameChange(new NameChangeEventArgs(Name)); // після зміни імені викликається подія
        }
    }

    public event NameChangeEventHandler? NameChange;

    public void OnNameChange(NameChangeEventArgs args)
    {
        NameChange?.Invoke(new object(), args); // викликається подія
    }
}

public delegate void NameChangeEventHandler(object sender, NameChangeEventArgs args);