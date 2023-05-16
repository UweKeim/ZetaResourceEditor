﻿namespace ZetaResourceEditor.ExtendedControlsLibrary.General.UIUpdating;

public sealed class UpdateUIInformation
{
    public UpdateUIInformation(object? userState = null)
    {
        UserState = userState;
    }

    public object? UserState { get; }

    public Guid Token { get; } = Guid.NewGuid();

    public DateTime CreatedAt { get; } = DateTime.Now;
}